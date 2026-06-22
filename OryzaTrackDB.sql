CREATE DATABASE OryzaTrack;
GO
USE OryzaTrack;
GO

CREATE TABLE admin (
    idAdmin       INT IDENTITY(1,1) NOT NULL,
    namaAdmin     VARCHAR(100) NOT NULL,
    username      VARCHAR(50) NOT NULL,
    passwordAdmin VARCHAR(255) NOT NULL,
    email         VARCHAR(100) NOT NULL,

    --Primary Key
    CONSTRAINT PK_Admin PRIMARY KEY (idAdmin),

    --Unique Constraint untuk username dan email | 
    CONSTRAINT UQ_Admin_Username UNIQUE (username),
    CONSTRAINT UQ_Admin_Email UNIQUE (email),

    -- CK : Validasi format data
    CONSTRAINT CK_Admin_Nama
        CHECK (namaAdmin NOT LIKE '%[^a-zA-Z ]%' AND LEN(namaAdmin) >= 2),

    CONSTRAINT Cek_Admin_Email
        CHECK (email LIKE '%_@__%.__%'),

    CONSTRAINT Cek_Admin_Username 
        CHECK (LEN(username) >= 5),

    CONSTRAINT Cek_Admin_Password 
        CHECK (LEN(passwordAdmin) >= 6)
);

CREATE TABLE petani (
    idPetani      INT IDENTITY(1,1) NOT NULL,
    namaPetani    VARCHAR(100) NOT NULL,
    NIK           CHAR(16) NOT NULL,
    alamat        VARCHAR(255) NOT NULL,
    noTelepon     VARCHAR(15) NOT NULL,
    statusAktif   BIT NOT NULL DEFAULT 1,

    --Primary Key
    CONSTRAINT PK_Petani PRIMARY KEY (idPetani),

    --Unique Constraint untuk NIK
    CONSTRAINT UQ_Petani_NIK UNIQUE (NIK),

    -- CK : Validasi format data
    CONSTRAINT CK_Petani_Nama
        CHECK (namaPetani NOT LIKE '%[^a-zA-Z ]%' AND LEN(namaPetani) >= 2),

    CONSTRAINT CK_Petani_NIK
        CHECK (LEN(NIK) = 16 AND NIK NOT LIKE '%[^0-9]%'),

    CONSTRAINT CK_Petani_Alamat
        CHECK (LEN(alamat) >= 10),

    CONSTRAINT CK_Petani_NoTelepon
        CHECK (
        LEN(noTelepon) BETWEEN 10 AND 15 
        AND noTelepon NOT LIKE '%+%+%'
        AND noTelepon NOT LIKE '%[^0-9+]%'
        AND (noTelepon LIKE '08%' OR noTelepon LIKE '+62%')
    )
);

CREATE TABLE Padi (
    idPadi        INT IDENTITY(1,1) NOT NULL,
    idPetani      INT NOT NULL,
    jenisBibit    VARCHAR(100) NOT NULL,
    lokasiLahan   VARCHAR(100) NOT NULL,
    tanggalTanam  DATE NOT NULL,

    --Primary Key
    CONSTRAINT PK_Padi PRIMARY KEY (idPadi),

    --Foreign Key
    CONSTRAINT FK_Padi_Petani 
        FOREIGN KEY (idPetani) REFERENCES petani(idPetani)
        ON DELETE CASCADE,

    -- CK : Validasi format data
    CONSTRAINT CK_Padi_JenisBibit
        CHECK (jenisBibit IN ('IR64', 'Ciherang', 'Inpari 32', 'Mekongga')),

    CONSTRAINT CK_Padi_LokasiLahan
        CHECK (lokasiLahan IN ('Lahan Utara', 'Lahan Selatan', 'Lahan Barat', 'Lahan Timur')),

    CONSTRAINT CK_Padi_TanggalTanam
        CHECK (YEAR(tanggalTanam) BETWEEN 2025 AND 2026)
);

CREATE TABLE Penyakit (
    idPenyakit      INT IDENTITY(1,1) NOT NULL,
    Kategori VARCHAR(50) NOT NULL,
    gejalaPenyakit  VARCHAR(MAX) NOT NULL,
    tingkatKerusakan VARCHAR(50) NOT NULL,
    tanggalSerangan DATE NOT NULL,

    --Primary Key
    CONSTRAINT PK_Penyakit PRIMARY KEY (idPenyakit),

    -- CK : Validasi format data
    CONSTRAINT CK_Penyakit_Kategori
        CHECK (Kategori IN ('Hama', 'Penyakit')),

    CONSTRAINT CK_Penyakit_Gejala
        CHECK (LEN(gejalaPenyakit) >= 10),

    CONSTRAINT CK_Penyakit_TingkatKerusakan
        CHECK (tingkatKerusakan IN ('Ringan', 'Sedang', 'Berat')),

    CONSTRAINT CK_Penyakit_TanggalSerangan
        CHECK (YEAR(tanggalSerangan) BETWEEN 2025 AND 2026)
);

CREATE TABLE perawatanPadi (
    idPerawatan      INT IDENTITY(1,1) NOT NULL,
    jenisPerawatan   VARCHAR(100) NOT NULL,
    jenisPestisida   VARCHAR(100) NOT NULL,
    tanggalPerawatan DATE NOT NULL,
    hasilPerawatan   VARCHAR(100) NOT NULL,

    --Primary Key
    CONSTRAINT PK_Perawatan PRIMARY KEY (idPerawatan),


    -- CK : Validasi format data
    CONSTRAINT CK_Perawatan_JenisPestisida
        CHECK (jenisPestisida IN ('Insektisida Furadan', 'Fungisida Dithane', 'Herbisida Glyphosate')),

    CONSTRAINT CK_Perawatan_TanggalPerawatan
        CHECK (YEAR(tanggalPerawatan) BETWEEN 2025 AND 2026),

    CONSTRAINT CK_Perawatan_HasilPerawatan
        CHECK (hasilPerawatan IN ('Berhasil', 'Sebagian Berhasil', 'Gagal'))
);

--EDIT
ALTER TABLE perawatanPadi DROP CONSTRAINT FK_Perawatan_Padi;
ALTER TABLE perawatanPadi DROP CONSTRAINT FK_Perawatan_Penyakit;

ALTER TABLE perawatanPadi DROP COLUMN idPadi;
ALTER TABLE perawatanPadi DROP COLUMN idPenyakit;

-- Tambahkan kolom baru yang menyambung ke tabel Riwayat
ALTER TABLE perawatanPadi ADD idRiwayat INT NOT NULL;

-- Beri Foreign Key baru
ALTER TABLE perawatanPadi 
ADD CONSTRAINT FK_Perawatan_RiwayatPenyakit 
FOREIGN KEY (idRiwayat) REFERENCES RiwayatPenyakit(idRiwayat) ON DELETE CASCADE;

CREATE TABLE riwayatPenyakit (
    idRiwayat       INT IDENTITY(1,1) NOT NULL,
    idPadi           INT NOT NULL,
    idPenyakit       INT NOT NULL,
    tanggalTerdeteksi DATE NOT NULL,
    tanggalSelesai DATE,
    keterangan VARCHAR(255) NOT NULL,

    --Primary Key
    CONSTRAINT PK_Riwayat PRIMARY KEY (idRiwayat),

    --Foreign Key
    CONSTRAINT FK_Riwayat_Padi 
        FOREIGN KEY (idPadi) REFERENCES Padi(idPadi)
        ON DELETE CASCADE,

    CONSTRAINT FK_Riwayat_Penyakit 
        FOREIGN KEY (idPenyakit) REFERENCES Penyakit(idPenyakit)
        ON DELETE CASCADE,

    -- CK : Validasi format data
    CONSTRAINT CK_Riwayat_TanggalTerdeteksi
        CHECK (YEAR(tanggalTerdeteksi) BETWEEN 2025 AND 2026),

    CONSTRAINT CK_Riwayat_TanggalSelesai
        CHECK (tanggalSelesai IS NULL OR YEAR(tanggalSelesai) BETWEEN 2025 AND 2026),

    CONSTRAINT CK_Riwayat_UrutanTanggal
        CHECK (tanggalSelesai IS NULL OR tanggalSelesai >= tanggalTerdeteksi)
);


/*=====================
      INSERT DATA
=======================*/

-- 1. Insert Admin
INSERT INTO admin (namaAdmin, username, passwordAdmin, email)
VALUES ('SuperAdmin', 'admin', 'admin123', 'admin@gmail.com');

-- 2. Insert Petani
INSERT INTO petani (namaPetani, NIK, alamat, noTelepon)
VALUES 
('Andi Tani', '1234567890123456', 'Jl. Sawah Hijau No. 5, Sleman', '081299887766'),
('Bambang Sugeng', '3401122334455667', 'Jl. Merdeka No. 12, Bantul', '085711223344'),
('Slamet Riyadi', '3402233445566778', 'Dusun Tani Makmur No. 8, Klaten', '08133445566');

-- 3. Insert Padi (Tanam)
INSERT INTO Padi (idPetani, jenisBibit, lokasiLahan, tanggalTanam)
VALUES 
(1, 'Inpari 32', 'Lahan Utara', '2026-01-10'),
(2, 'IR64', 'Lahan Selatan', '2026-02-05'),
(3, 'Ciherang', 'Lahan Barat', '2026-03-12');

-- 4. Insert Penyakit
INSERT INTO Penyakit (Kategori, gejalaPenyakit, tingkatKerusakan, tanggalSerangan)
VALUES 
('Hama', 'Batang padi terlihat berlubang dan layu', 'Berat', '2026-02-15'),
('Penyakit', 'Daun menguning dan terdapat bercak coklat kemerahan', 'Sedang', '2026-03-20'),
('Hama', 'Tanaman terlihat kerdil dan banyak serangga wereng', 'Berat', '2026-04-01');


-- 5. Insert Riwayat
INSERT INTO riwayatPenyakit (idPadi, idPenyakit, tanggalTerdeteksi, keterangan)
VALUES (1, 1, '2026-02-16', 'Serangan penggerek batang di sisi timur lahan.'),
(2, 2, '2026-03-22','Infeksi jamur daun mulai meluas karena kelembaban tinggi.'),
(3, 3, '2026-04-02', 'Populasi wereng meningkat drastis di blok barat.');

-- 6. Insert Perawatan
INSERT INTO perawatanPadi (idPadi, idPenyakit, jenisPerawatan, jenisPestisida, tanggalPerawatan, hasilPerawatan)
VALUES (1, 1, 'Penyemprotan Berjadwal', 'Insektisida Furadan', '2026-02-17', 'Sebagian Berhasil'),
(2, 2, 'Penyemprotan Fungisida', 'Fungisida Dithane', '2026-03-25', 'Berhasil'),
(3, 3, 'Pengendalian Hama Terpadu', 'Insektisida Furadan', '2026-04-05', 'Gagal');

/** HAPUS DB sebelum execute yang di atas**/
--Drop database OryzaTrack soalnya banyak perubahan tabel
DROP DATABASE OryzaTrack;


/**
==============================
Mau perbaikan Constraint nya
==============================
**/
-- Hapus constraint jenisBibit
ALTER TABLE Padi DROP CONSTRAINT CK_Padi_JenisBibit;

-- Hapus constraint lokasiLahan
ALTER TABLE Padi DROP CONSTRAINT CK_Padi_LokasiLahan;

-- Hapus constraint tanggalTanam
ALTER TABLE Padi DROP CONSTRAINT CK_Padi_TanggalTanam;

-- Hapus constraint tanggalSerangan
ALTER TABLE Penyakit DROP CONSTRAINT CK_Penyakit_TanggalSerangan;

-- Hapus constraint jenisPestisida
ALTER TABLE perawatanPadi DROP CONSTRAINT CK_Perawatan_JenisPestisida;

-- Hapus constraint tanggalPerawatan
ALTER TABLE perawatanPadi DROP CONSTRAINT CK_Perawatan_TanggalPerawatan;

-- Hapus constraint tanggalTerdeteksi
ALTER TABLE riwayatPenyakit DROP CONSTRAINT CK_Riwayat_TanggalTerdeteksi;

-- Hapus constraint tanggalSelesai
ALTER TABLE riwayatPenyakit DROP CONSTRAINT CK_Riwayat_TanggalSelesai;

/**
==============================
Mau perbaikan Constraint nya, 
Tapi ini constraint barunya
==============================
**/

-- lokasiLahan: minimal 5 karakter saja
ALTER TABLE Padi ADD CONSTRAINT CK_Padi_LokasiLahan
    CHECK (LEN(lokasiLahan) >= 5);

-- tanggalTanam: dari tahun 2000 sampai hari ini
ALTER TABLE Padi ADD CONSTRAINT CK_Padi_TanggalTanam
    CHECK (tanggalTanam >= '2000-01-01' AND tanggalTanam <= GETDATE());

-- tanggalSerangan penyakit
ALTER TABLE Penyakit ADD CONSTRAINT CK_Penyakit_TanggalSerangan
    CHECK (tanggalSerangan >= '2000-01-01' AND tanggalSerangan <= GETDATE());

-- tanggalPerawatan
ALTER TABLE perawatanPadi ADD CONSTRAINT CK_Perawatan_TanggalPerawatan
    CHECK (tanggalPerawatan >= '2000-01-01' AND tanggalPerawatan <= GETDATE());

-- tanggalTerdeteksi
ALTER TABLE riwayatPenyakit ADD CONSTRAINT CK_Riwayat_TanggalTerdeteksi
    CHECK (tanggalTerdeteksi >= '2000-01-01' AND tanggalTerdeteksi <= GETDATE());

-- tanggalSelesai
ALTER TABLE riwayatPenyakit ADD CONSTRAINT CK_Riwayat_TanggalSelesai
    CHECK (tanggalSelesai IS NULL OR 
          (tanggalSelesai >= '2000-01-01' AND tanggalSelesai <= DATEADD(YEAR, 1, GETDATE())));


/*======================
         UCP2
========================*/

-- 1. PETANI

--VIEW petani
CREATE VIEW vw_Petani AS
SELECT 
    idPetani,
    namaPetani,
    NIK,
    alamat,
    noTelepon,
    CASE WHEN statusAktif = 1 THEN 'Aktif' ELSE 'Tidak Aktif' END AS statusAktif
FROM petani;

-- =====================
-- SP INSERT PETANI
-- =====================
CREATE PROCEDURE sp_InsertPetani
    @namaPetani  VARCHAR(100),
    @NIK         CHAR(16),
    @alamat      VARCHAR(255),
    @noTelepon   VARCHAR(15),
    @pesanHasil    VARCHAR(200) OUTPUT  -- output pesan hasil
AS
BEGIN
    SET NOCOUNT ON;

    -- Logika 1: Cek NIK duplikat (bukan sekadar INSERT biasa)
    IF EXISTS (SELECT 1 FROM petani WHERE NIK = @NIK)
    BEGIN
        SET @pesanHasil = 'NIK sudah terdaftar di sistem!';
        RETURN;
    END

    -- Logika 2: Cek NoTelepon duplikat
    IF EXISTS (SELECT 1 FROM petani WHERE noTelepon = @noTelepon)
    BEGIN
        SET @pesanHasil = 'Nomor telepon sudah digunakan petani lain!';
        RETURN;
    END

    -- Baru INSERT kalau lolos validasi
    INSERT INTO petani (namaPetani, NIK, alamat, noTelepon)
    VALUES (@namaPetani, @NIK, @alamat, @noTelepon);

    SET @pesanHasil = 'OK';
END;
GO

-- =====================
-- SP UPDATE PETANI
-- =====================
CREATE PROCEDURE sp_UpdatePetani
    @idPetani    INT,
    @namaPetani  VARCHAR(100),
    @NIK         CHAR(16),
    @alamat      VARCHAR(255),
    @noTelepon   VARCHAR(15),
    @statusAktif BIT,
    @pesanHasil    VARCHAR(200) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    -- Logika 1: Cek apakah petani ada
    IF NOT EXISTS (SELECT 1 FROM petani WHERE idPetani = @idPetani)
    BEGIN
        SET @pesanHasil = 'Data petani tidak ditemukan!';
        RETURN;
    END

    -- Logika 2: Cek NIK duplikat (kecuali milik sendiri)
    IF EXISTS (SELECT 1 FROM petani WHERE NIK = @NIK AND idPetani != @idPetani)
    BEGIN
        SET @pesanHasil = 'NIK sudah digunakan petani lain!';
        RETURN;
    END

    -- Logika 3: Cek NoTelepon duplikat (kecuali milik sendiri)
    IF EXISTS (SELECT 1 FROM petani WHERE noTelepon = @noTelepon AND idPetani != @idPetani)
    BEGIN
        SET @pesanHasil = 'Nomor telepon sudah digunakan petani lain!';
        RETURN;
    END

    UPDATE petani
    SET namaPetani  = @namaPetani,
        NIK         = @NIK,
        alamat      = @alamat,
        noTelepon   = @noTelepon,
        statusAktif = @statusAktif
    WHERE idPetani = @idPetani;

    SET @pesanHasil = 'OK';
END;
GO

-- =====================
-- SP DELETE PETANI
-- =====================
CREATE PROCEDURE sp_DeletePetani
    @idPetani INT,
    @pesanHasil VARCHAR(200) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    -- Logika: Cek apakah petani masih punya data Padi aktif
    IF EXISTS (SELECT 1 FROM Padi WHERE idPetani = @idPetani)
    BEGIN
        SET @pesanHasil = 'Petani masih memiliki data padi, tidak bisa dihapus!';
        RETURN;
    END

    DELETE FROM petani WHERE idPetani = @idPetani;
    SET @pesanHasil = 'OK';
END;
GO

/* =====================
   SP SEARCH PETANI
 =====================*/

CREATE PROCEDURE sp_SearchPetani
    @keyword VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    -- Logika tambahan: trim & ubah ke lowercase untuk pencarian fleksibel
    SET @keyword = LTRIM(RTRIM(@keyword));

    SELECT 
        idPetani,
        namaPetani,
        NIK,
        alamat,
        noTelepon,
        CASE WHEN statusAktif = 1 THEN 'Aktif' ELSE 'Tidak Aktif' END AS statusAktif
    FROM petani
    WHERE 
        CAST(idPetani AS VARCHAR) LIKE '%' + @keyword + '%'
        OR namaPetani     LIKE '%' + @keyword + '%'
        OR NIK            LIKE '%' + @keyword + '%'
        OR alamat         LIKE '%' + @keyword + '%'
        OR noTelepon      LIKE '%' + @keyword + '%';
END;
GO

--================================================================================================
-- =====================
-- VIEW PADI
-- =====================
CREATE VIEW vw_Padi AS
SELECT 
    p.idPadi,
    p.idPetani,
    pt.namaPetani,
    p.jenisBibit,
    p.lokasiLahan,
    CONVERT(VARCHAR, p.tanggalTanam, 103) AS tanggalTanam  -- format DD/MM/YYYY
FROM Padi p
JOIN petani pt ON p.idPetani = pt.idPetani;
GO

-- =====================
-- SP INSERT PADI
-- =====================
CREATE PROCEDURE sp_InsertPadi
    @idPetani     INT,
    @jenisBibit   VARCHAR(100),
    @lokasiLahan  VARCHAR(100),
    @tanggalTanam DATE,
    @pesanHasil     VARCHAR(200) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    -- Logika 1: Cek apakah petani ada dan aktif
    IF NOT EXISTS (SELECT 1 FROM petani WHERE idPetani = @idPetani AND statusAktif = 1)
    BEGIN
        SET @pesanHasil = 'Petani tidak ditemukan atau tidak aktif!';
        RETURN;
    END

    -- Logika 2: Cek duplikasi lahan + petani yang sama di tanggal sama
    IF EXISTS (
        SELECT 1 FROM Padi 
        WHERE idPetani = @idPetani 
          AND lokasiLahan = @lokasiLahan 
          AND tanggalTanam = @tanggalTanam
    )
    BEGIN
        SET @pesanHasil = 'Petani sudah menanam di lahan ini pada tanggal yang sama!';
        RETURN;
    END

    INSERT INTO Padi (idPetani, jenisBibit, lokasiLahan, tanggalTanam)
    VALUES (@idPetani, @jenisBibit, @lokasiLahan, @tanggalTanam);

    SET @pesanHasil = 'OK';
END;
GO

-- =====================
-- SP UPDATE PADI
-- =====================
CREATE PROCEDURE sp_UpdatePadi
    @idPadi       INT,
    @idPetani     INT,
    @jenisBibit   VARCHAR(100),
    @lokasiLahan  VARCHAR(100),
    @tanggalTanam DATE,
    @pesanHasil     VARCHAR(200) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    -- Logika 1: Cek data padi ada
    IF NOT EXISTS (SELECT 1 FROM Padi WHERE idPadi = @idPadi)
    BEGIN
        SET @pesanHasil = 'Data padi tidak ditemukan!';
        RETURN;
    END

    -- Logika 2: Cek petani aktif
    IF NOT EXISTS (SELECT 1 FROM petani WHERE idPetani = @idPetani AND statusAktif = 1)
    BEGIN
        SET @pesanHasil = 'Petani tidak ditemukan atau tidak aktif!';
        RETURN;
    END

    -- Logika 3: Cek duplikasi lahan (kecuali dirinya sendiri)
    IF EXISTS (
        SELECT 1 FROM Padi 
        WHERE idPetani = @idPetani 
          AND lokasiLahan = @lokasiLahan 
          AND tanggalTanam = @tanggalTanam
          AND idPadi != @idPadi
    )
    BEGIN
        SET @pesanHasil = 'Petani sudah menanam di lahan ini pada tanggal yang sama!';
        RETURN;
    END

    UPDATE Padi
    SET idPetani     = @idPetani,
        jenisBibit   = @jenisBibit,
        lokasiLahan  = @lokasiLahan,
        tanggalTanam = @tanggalTanam
    WHERE idPadi = @idPadi;

    SET @pesanHasil = 'OK';
END;
GO

-- =====================
-- SP DELETE PADI
-- =====================
CREATE PROCEDURE sp_DeletePadi
    @idPadi   INT,
    @pesanHasil VARCHAR(200) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    -- Logika: Cek apakah padi masih punya riwayat/perawatan
    IF EXISTS (SELECT 1 FROM riwayatPenyakit WHERE idPadi = @idPadi)
       OR EXISTS (SELECT 1 FROM perawatanPadi WHERE idPadi = @idPadi)
    BEGIN
        SET @pesanHasil = 'Data padi masih memiliki riwayat/perawatan, tidak bisa dihapus!';
        RETURN;
    END

    DELETE FROM Padi WHERE idPadi = @idPadi;
    SET @pesanHasil = 'OK';
END;
GO

-- =====================
-- SP SEARCH PADI
-- =====================
CREATE PROCEDURE sp_SearchPadi
    @keyword VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    SET @keyword = LTRIM(RTRIM(@keyword));

    SELECT 
        p.idPadi,
        p.idPetani,
        pt.namaPetani,
        p.jenisBibit,
        p.lokasiLahan,
        CONVERT(VARCHAR, p.tanggalTanam, 103) AS tanggalTanam
    FROM Padi p
    JOIN petani pt ON p.idPetani = pt.idPetani
    WHERE 
        CAST(p.idPadi AS VARCHAR)            LIKE '%' + @keyword + '%'
        OR pt.namaPetani                     LIKE '%' + @keyword + '%'
        OR p.jenisBibit                      LIKE '%' + @keyword + '%'
        OR p.lokasiLahan                     LIKE '%' + @keyword + '%'
        OR CONVERT(VARCHAR, p.tanggalTanam, 103) LIKE '%' + @keyword + '%';
END;
GO

--============================================================================================

-- =====================
-- VIEW PENYAKIT
-- =====================
CREATE VIEW vw_Penyakit AS
SELECT 
    idPenyakit,
    Kategori,
    gejalaPenyakit,
    tingkatKerusakan,
    CONVERT(VARCHAR, tanggalSerangan, 103) AS tanggalSerangan  -- format DD/MM/YYYY
FROM Penyakit;
GO

-- =====================
-- SP INSERT PENYAKIT
-- =====================
CREATE PROCEDURE sp_InsertPenyakit
    @kategori        VARCHAR(50),
    @gejalaPenyakit  VARCHAR(MAX),
    @tingkatKerusakan VARCHAR(50),
    @tanggalSerangan DATE,
    @pesanHasil        VARCHAR(200) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    -- Logika 1: Cek duplikasi gejala + kategori yang sama di tanggal sama
    IF EXISTS (
        SELECT 1 FROM Penyakit
        WHERE Kategori        = @kategori
          AND gejalaPenyakit  = @gejalaPenyakit
          AND tanggalSerangan = @tanggalSerangan
    )
    BEGIN
        SET @pesanHasil = 'Data penyakit dengan gejala dan tanggal serangan yang sama sudah ada!';
        RETURN;
    END

    -- Logika 2: Tanggal tidak boleh masa depan (double-check di DB)
    IF @tanggalSerangan > CAST(GETDATE() AS DATE)
    BEGIN
        SET @pesanHasil = 'Tanggal serangan tidak boleh di masa depan!';
        RETURN;
    END

    INSERT INTO Penyakit (Kategori, gejalaPenyakit, tingkatKerusakan, tanggalSerangan)
    VALUES (@kategori, @gejalaPenyakit, @tingkatKerusakan, @tanggalSerangan);

    SET @pesanHasil = 'OK';
END;
GO

-- =====================
-- SP UPDATE PENYAKIT
-- =====================
CREATE PROCEDURE sp_UpdatePenyakit
    @idPenyakit       INT,
    @kategori         VARCHAR(50),
    @gejalaPenyakit   VARCHAR(MAX),
    @tingkatKerusakan VARCHAR(50),
    @tanggalSerangan  DATE,
    @pesanHasil         VARCHAR(200) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    -- Logika 1: Cek data ada
    IF NOT EXISTS (SELECT 1 FROM Penyakit WHERE idPenyakit = @idPenyakit)
    BEGIN
        SET @pesanHasil = 'Data penyakit tidak ditemukan!';
        RETURN;
    END

    -- Logika 2: Cek duplikasi (kecuali dirinya sendiri)
    IF EXISTS (
        SELECT 1 FROM Penyakit
        WHERE Kategori        = @kategori
          AND gejalaPenyakit  = @gejalaPenyakit
          AND tanggalSerangan = @tanggalSerangan
          AND idPenyakit     != @idPenyakit
    )
    BEGIN
        SET @pesanHasil = 'Data penyakit serupa sudah ada di tanggal yang sama!';
        RETURN;
    END

    -- Logika 3: Cek apakah tingkat kerusakan naik drastis (Ringan → Berat langsung)
    -- Sebagai warning/log, tetap lanjut update tapi catat di log
    DECLARE @tingkatLama VARCHAR(50);
    SELECT @tingkatLama = tingkatKerusakan FROM Penyakit WHERE idPenyakit = @idPenyakit;

    IF @tingkatLama = 'Ringan' AND @tingkatKerusakan = 'Berat'
    BEGIN
        -- Tidak block, tapi beri pesan khusus
        UPDATE Penyakit
        SET Kategori         = @kategori,
            gejalaPenyakit   = @gejalaPenyakit,
            tingkatKerusakan = @tingkatKerusakan,
            tanggalSerangan  = @tanggalSerangan
        WHERE idPenyakit = @idPenyakit;

        SET @pesanHasil = 'PERINGATAN: Tingkat kerusakan naik drastis dari Ringan ke Berat!';
        RETURN;
    END

    UPDATE Penyakit
    SET Kategori         = @kategori,
        gejalaPenyakit   = @gejalaPenyakit,
        tingkatKerusakan = @tingkatKerusakan,
        tanggalSerangan  = @tanggalSerangan
    WHERE idPenyakit = @idPenyakit;

    SET @pesanHasil = 'OK';
END;
GO

-- =====================
-- SP DELETE PENYAKIT
-- =====================
CREATE PROCEDURE sp_DeletePenyakit
    @idPenyakit INT,
    @pesanHasil   VARCHAR(200) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    -- Logika: Cek apakah penyakit masih dipakai di riwayat atau perawatan
    IF EXISTS (SELECT 1 FROM riwayatPenyakit WHERE idPenyakit = @idPenyakit)
    BEGIN
        SET @pesanHasil = 'Penyakit masih terdaftar di Riwayat Penyakit, tidak bisa dihapus!';
        RETURN;
    END

    IF EXISTS (SELECT 1 FROM perawatanPadi WHERE idPenyakit = @idPenyakit)
    BEGIN
        SET @pesanHasil = 'Penyakit masih terdaftar di Perawatan Padi, tidak bisa dihapus!';
        RETURN;
    END

    DELETE FROM Penyakit WHERE idPenyakit = @idPenyakit;
    SET @pesanHasil = 'OK';
END;
GO

-- =====================
-- SP SEARCH PENYAKIT
-- =====================
CREATE PROCEDURE sp_SearchPenyakit
    @keyword VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    SET @keyword = LTRIM(RTRIM(@keyword));

    SELECT 
        idPenyakit,
        Kategori,
        gejalaPenyakit,
        tingkatKerusakan,
        CONVERT(VARCHAR, tanggalSerangan, 103) AS tanggalSerangan
    FROM Penyakit
    WHERE 
        CAST(idPenyakit AS VARCHAR)                    LIKE '%' + @keyword + '%'
        OR Kategori                                    LIKE '%' + @keyword + '%'
        OR gejalaPenyakit                              LIKE '%' + @keyword + '%'
        OR tingkatKerusakan                            LIKE '%' + @keyword + '%'
        OR CONVERT(VARCHAR, tanggalSerangan, 103)      LIKE '%' + @keyword + '%';
END;
GO

--==========================================================================================================

-- =====================
-- VIEW PERAWATAN PADI
-- =====================
CREATE VIEW vw_PerawatanPadi AS
SELECT 
    pp.idPerawatan,
    pp.idPadi,
    pp.idPenyakit,
    pt.namaPetani,
    p.jenisBibit,
    p.lokasiLahan,
    pn.Kategori         AS kategoriPenyakit,
    pp.jenisPerawatan,
    pp.jenisPestisida,
    CONVERT(VARCHAR, pp.tanggalPerawatan, 103) AS tanggalPerawatan,
    pp.hasilPerawatan
FROM perawatanPadi pp
JOIN Padi p         ON pp.idPadi     = p.idPadi
JOIN petani pt      ON p.idPetani    = pt.idPetani
JOIN Penyakit pn    ON pp.idPenyakit = pn.idPenyakit;
GO

-- =====================
-- SP INSERT PERAWATAN
-- =====================
CREATE PROCEDURE sp_InsertPerawatan
    @idPadi           INT,
    @idPenyakit       INT,
    @jenisPerawatan   VARCHAR(100),
    @jenisPestisida   VARCHAR(100),
    @tanggalPerawatan DATE,
    @hasilPerawatan   VARCHAR(100),
    @hasilMsg         VARCHAR(200) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    -- Logika 1: Cek padi ada
    IF NOT EXISTS (SELECT 1 FROM Padi WHERE idPadi = @idPadi)
    BEGIN
        SET @hasilMsg = 'Data padi tidak ditemukan!';
        RETURN;
    END

    -- Logika 2: Cek penyakit ada
    IF NOT EXISTS (SELECT 1 FROM Penyakit WHERE idPenyakit = @idPenyakit)
    BEGIN
        SET @hasilMsg = 'Data penyakit tidak ditemukan!';
        RETURN;
    END

    -- Logika 3: Cek apakah kombinasi padi+penyakit sudah pernah dirawat
    --           di tanggal yang sama (hindari duplikasi perawatan)
    IF EXISTS (
        SELECT 1 FROM perawatanPadi
        WHERE idPadi           = @idPadi
          AND idPenyakit       = @idPenyakit
          AND tanggalPerawatan = @tanggalPerawatan
    )
    BEGIN
        SET @hasilMsg = 'Perawatan untuk padi dan penyakit ini pada tanggal tersebut sudah ada!';
        RETURN;
    END

    -- Logika 4: Validasi konsistensi pestisida dengan kategori penyakit
    DECLARE @kategori VARCHAR(50);
    SELECT @kategori = Kategori FROM Penyakit WHERE idPenyakit = @idPenyakit;

    IF @kategori = 'Hama' AND @jenisPestisida = 'Fungisida Dithane'
    BEGIN
        SET @hasilMsg = 'Fungisida Dithane tidak cocok untuk kategori Hama!';
        RETURN;
    END

    IF @kategori = 'Penyakit' AND @jenisPestisida = 'Insektisida Furadan'
    BEGIN
        SET @hasilMsg = 'Insektisida Furadan tidak cocok untuk kategori Penyakit (jamur/bakteri)!';
        RETURN;
    END

    INSERT INTO perawatanPadi 
        (idPadi, idPenyakit, jenisPerawatan, jenisPestisida, tanggalPerawatan, hasilPerawatan)
    VALUES 
        (@idPadi, @idPenyakit, @jenisPerawatan, @jenisPestisida, @tanggalPerawatan, @hasilPerawatan);

    SET @hasilMsg = 'OK';
END;
GO

-- =====================
-- SP UPDATE PERAWATAN
-- =====================
CREATE PROCEDURE sp_UpdatePerawatan
    @idPerawatan      INT,
    @idPadi           INT,
    @idPenyakit       INT,
    @jenisPerawatan   VARCHAR(100),
    @jenisPestisida   VARCHAR(100),
    @tanggalPerawatan DATE,
    @hasilPerawatan   VARCHAR(100),
    @hasilMsg         VARCHAR(200) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    -- Logika 1: Cek data perawatan ada
    IF NOT EXISTS (SELECT 1 FROM perawatanPadi WHERE idPerawatan = @idPerawatan)
    BEGIN
        SET @hasilMsg = 'Data perawatan tidak ditemukan!';
        RETURN;
    END

    -- Logika 2: Cek duplikasi (kecuali dirinya sendiri)
    IF EXISTS (
        SELECT 1 FROM perawatanPadi
        WHERE idPadi           = @idPadi
          AND idPenyakit       = @idPenyakit
          AND tanggalPerawatan = @tanggalPerawatan
          AND idPerawatan     != @idPerawatan
    )
    BEGIN
        SET @hasilMsg = 'Perawatan serupa pada tanggal ini sudah ada!';
        RETURN;
    END

    -- Logika 3: Validasi konsistensi pestisida vs kategori penyakit
    DECLARE @kategori VARCHAR(50);
    SELECT @kategori = Kategori FROM Penyakit WHERE idPenyakit = @idPenyakit;

    IF @kategori = 'Hama' AND @jenisPestisida = 'Fungisida Dithane'
    BEGIN
        SET @hasilMsg = 'Fungisida Dithane tidak cocok untuk kategori Hama!';
        RETURN;
    END

    IF @kategori = 'Penyakit' AND @jenisPestisida = 'Insektisida Furadan'
    BEGIN
        SET @hasilMsg = 'Insektisida Furadan tidak cocok untuk kategori Penyakit!';
        RETURN;
    END

    -- Logika 4: Jika hasil sebelumnya 'Berhasil', tidak boleh diubah ke 'Gagal'
    DECLARE @hasilLama VARCHAR(100);
    SELECT @hasilLama = hasilPerawatan FROM perawatanPadi WHERE idPerawatan = @idPerawatan;

    IF @hasilLama = 'Berhasil' AND @hasilPerawatan = 'Gagal'
    BEGIN
        SET @hasilMsg = 'Perawatan yang sudah Berhasil tidak bisa diubah menjadi Gagal!';
        RETURN;
    END

    UPDATE perawatanPadi
    SET idPadi           = @idPadi,
        idPenyakit       = @idPenyakit,
        jenisPerawatan   = @jenisPerawatan,
        jenisPestisida   = @jenisPestisida,
        tanggalPerawatan = @tanggalPerawatan,
        hasilPerawatan   = @hasilPerawatan
    WHERE idPerawatan = @idPerawatan;

    SET @hasilMsg = 'OK';
END;
GO

-- =====================
-- SP DELETE PERAWATAN
-- =====================
CREATE PROCEDURE sp_DeletePerawatan
    @idPerawatan INT,
    @hasilMsg    VARCHAR(200) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    -- Logika: Tidak boleh hapus jika hasil perawatan = 'Berhasil'
    --         karena bisa jadi referensi laporan penting
    DECLARE @hasil VARCHAR(100);
    SELECT @hasil = hasilPerawatan 
    FROM perawatanPadi 
    WHERE idPerawatan = @idPerawatan;

    IF @hasil IS NULL
    BEGIN
        SET @hasilMsg = 'Data perawatan tidak ditemukan!';
        RETURN;
    END

    IF @hasil = 'Berhasil'
    BEGIN
        SET @hasilMsg = 'Perawatan yang sudah Berhasil tidak dapat dihapus karena menjadi referensi laporan!';
        RETURN;
    END

    DELETE FROM perawatanPadi WHERE idPerawatan = @idPerawatan;
    SET @hasilMsg = 'OK';
END;
GO

-- =====================
-- SP SEARCH PERAWATAN
-- =====================
CREATE PROCEDURE sp_SearchPerawatan
    @keyword VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    SET @keyword = LTRIM(RTRIM(@keyword));

    SELECT 
        pp.idPerawatan,
        pp.idPadi,
        pp.idPenyakit,
        pt.namaPetani,
        p.jenisBibit,
        p.lokasiLahan,
        pn.Kategori         AS kategoriPenyakit,
        pp.jenisPerawatan,
        pp.jenisPestisida,
        CONVERT(VARCHAR, pp.tanggalPerawatan, 103) AS tanggalPerawatan,
        pp.hasilPerawatan
    FROM perawatanPadi pp
    JOIN Padi p         ON pp.idPadi     = p.idPadi
    JOIN petani pt      ON p.idPetani    = pt.idPetani
    JOIN Penyakit pn    ON pp.idPenyakit = pn.idPenyakit
    WHERE 
        CAST(pp.idPerawatan AS VARCHAR)              LIKE '%' + @keyword + '%'
        OR pt.namaPetani                             LIKE '%' + @keyword + '%'
        OR p.jenisBibit                              LIKE '%' + @keyword + '%'
        OR pn.Kategori                               LIKE '%' + @keyword + '%'
        OR pp.jenisPerawatan                         LIKE '%' + @keyword + '%'
        OR pp.jenisPestisida                         LIKE '%' + @keyword + '%'
        OR pp.hasilPerawatan                         LIKE '%' + @keyword + '%'
        OR CONVERT(VARCHAR, pp.tanggalPerawatan,103) LIKE '%' + @keyword + '%';
END;
GO

--================================================================================================

-- =====================
-- VIEW RIWAYAT PENYAKIT
-- =====================
CREATE VIEW vw_RiwayatPenyakit AS
SELECT 
    r.idRiwayat,
    r.idPadi,       -- wajib ada untuk CellClick SelectedValue
    r.idPenyakit,   -- wajib ada untuk CellClick SelectedValue
    pt.namaPetani,
    p.jenisBibit,
    p.lokasiLahan,
    pn.Kategori         AS kategoriPenyakit,
    pn.tingkatKerusakan,
    CONVERT(VARCHAR, r.tanggalTerdeteksi, 103) AS tanggalTerdeteksi,
    CASE 
        WHEN r.tanggalSelesai IS NULL THEN 'Belum Selesai'
        ELSE CONVERT(VARCHAR, r.tanggalSelesai, 103)
    END AS tanggalSelesai,
    r.keterangan
FROM riwayatPenyakit r
JOIN Padi p         ON r.idPadi     = p.idPadi
JOIN petani pt      ON p.idPetani   = pt.idPetani
JOIN Penyakit pn    ON r.idPenyakit = pn.idPenyakit;
GO

-- =====================
-- SP INSERT RIWAYAT
-- =====================
CREATE PROCEDURE sp_InsertRiwayat
    @idPadi             INT,
    @idPenyakit         INT,
    @tanggalTerdeteksi  DATE,
    @tanggalSelesai     DATE = NULL,
    @keterangan         VARCHAR(255),
    @hasilMsg           VARCHAR(200) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    -- Logika 1: Cek padi ada
    IF NOT EXISTS (SELECT 1 FROM Padi WHERE idPadi = @idPadi)
    BEGIN
        SET @hasilMsg = 'Data padi tidak ditemukan!';
        RETURN;
    END

    -- Logika 2: Cek penyakit ada
    IF NOT EXISTS (SELECT 1 FROM Penyakit WHERE idPenyakit = @idPenyakit)
    BEGIN
        SET @hasilMsg = 'Data penyakit tidak ditemukan!';
        RETURN;
    END

    -- Logika 3: Cek apakah padi + penyakit yang sama sudah ada riwayat aktif
    --           (tanggalSelesai masih NULL = belum selesai)
    IF EXISTS (
        SELECT 1 FROM riwayatPenyakit
        WHERE idPadi      = @idPadi
          AND idPenyakit  = @idPenyakit
          AND tanggalSelesai IS NULL
    )
    BEGIN
        SET @hasilMsg = 'Padi ini masih memiliki riwayat penyakit aktif yang belum selesai!';
        RETURN;
    END

    -- Logika 4: Validasi urutan tanggal
    IF @tanggalSelesai IS NOT NULL AND @tanggalSelesai < @tanggalTerdeteksi
    BEGIN
        SET @hasilMsg = 'Tanggal selesai tidak boleh sebelum tanggal terdeteksi!';
        RETURN;
    END

    INSERT INTO riwayatPenyakit 
        (idPadi, idPenyakit, tanggalTerdeteksi, tanggalSelesai, keterangan)
    VALUES 
        (@idPadi, @idPenyakit, @tanggalTerdeteksi, @tanggalSelesai, @keterangan);

    SET @hasilMsg = 'OK';
END;
GO

-- =====================
-- SP UPDATE RIWAYAT
-- =====================
CREATE PROCEDURE sp_UpdateRiwayat
    @idRiwayat          INT,
    @idPadi             INT,
    @idPenyakit         INT,
    @tanggalTerdeteksi  DATE,
    @tanggalSelesai     DATE = NULL,
    @keterangan         VARCHAR(255),
    @hasilMsg           VARCHAR(200) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    -- Logika 1: Cek data riwayat ada
    IF NOT EXISTS (SELECT 1 FROM riwayatPenyakit WHERE idRiwayat = @idRiwayat)
    BEGIN
        SET @hasilMsg = 'Data riwayat tidak ditemukan!';
        RETURN;
    END

    -- Logika 2: Cek urutan tanggal
    IF @tanggalSelesai IS NOT NULL AND @tanggalSelesai < @tanggalTerdeteksi
    BEGIN
        SET @hasilMsg = 'Tanggal selesai tidak boleh sebelum tanggal terdeteksi!';
        RETURN;
    END

    -- Logika 3: Jika riwayat sudah selesai (tanggalSelesai terisi),
    --           tidak boleh diubah kembali jadi aktif (NULL)
    DECLARE @tglSelesaiLama DATE;
    SELECT @tglSelesaiLama = tanggalSelesai 
    FROM riwayatPenyakit WHERE idRiwayat = @idRiwayat;

    IF @tglSelesaiLama IS NOT NULL AND @tanggalSelesai IS NULL
    BEGIN
        SET @hasilMsg = 'Riwayat yang sudah selesai tidak bisa dikembalikan ke status aktif!';
        RETURN;
    END

    -- Logika 4: Cek duplikasi riwayat aktif (kecuali dirinya sendiri)
    IF EXISTS (
        SELECT 1 FROM riwayatPenyakit
        WHERE idPadi        = @idPadi
          AND idPenyakit    = @idPenyakit
          AND tanggalSelesai IS NULL
          AND idRiwayat    != @idRiwayat
    )
    BEGIN
        SET @hasilMsg = 'Sudah ada riwayat aktif lain untuk padi dan penyakit yang sama!';
        RETURN;
    END

    UPDATE riwayatPenyakit
    SET idPadi             = @idPadi,
        idPenyakit         = @idPenyakit,
        tanggalTerdeteksi  = @tanggalTerdeteksi,
        tanggalSelesai     = @tanggalSelesai,
        keterangan         = @keterangan
    WHERE idRiwayat = @idRiwayat;

    SET @hasilMsg = 'OK';
END;
GO

-- =====================
-- SP DELETE RIWAYAT
-- =====================
CREATE PROCEDURE sp_DeleteRiwayat
    @idRiwayat INT,
    @hasilMsg  VARCHAR(200) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    -- Logika: Riwayat yang masih aktif (belum selesai) tidak boleh dihapus
    DECLARE @tglSelesai DATE;
    SELECT @tglSelesai = tanggalSelesai 
    FROM riwayatPenyakit WHERE idRiwayat = @idRiwayat;

    IF @tglSelesai IS NULL
    BEGIN
        SET @hasilMsg = 'Riwayat penyakit yang masih aktif tidak bisa dihapus! Isi tanggal selesai terlebih dahulu.';
        RETURN;
    END

    DELETE FROM riwayatPenyakit WHERE idRiwayat = @idRiwayat;
    SET @hasilMsg = 'OK';
END;
GO

-- =====================
-- SP SEARCH RIWAYAT
-- =====================
CREATE PROCEDURE sp_SearchRiwayat
    @keyword VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    SET @keyword = LTRIM(RTRIM(@keyword));

    SELECT 
        r.idRiwayat,
        r.idPadi,
        r.idPenyakit,
        pt.namaPetani,
        p.jenisBibit,
        p.lokasiLahan,
        pn.Kategori         AS kategoriPenyakit,
        pn.tingkatKerusakan,
        CONVERT(VARCHAR, r.tanggalTerdeteksi, 103) AS tanggalTerdeteksi,
        CASE 
            WHEN r.tanggalSelesai IS NULL THEN 'Belum Selesai'
            ELSE CONVERT(VARCHAR, r.tanggalSelesai, 103)
        END AS tanggalSelesai,
        r.keterangan
    FROM riwayatPenyakit r
    JOIN Padi p         ON r.idPadi     = p.idPadi
    JOIN petani pt      ON p.idPetani   = pt.idPetani
    JOIN Penyakit pn    ON r.idPenyakit = pn.idPenyakit
    WHERE
        pt.namaPetani                              LIKE '%' + @keyword + '%'
        OR p.jenisBibit                            LIKE '%' + @keyword + '%'
        OR p.lokasiLahan                           LIKE '%' + @keyword + '%'
        OR pn.Kategori                             LIKE '%' + @keyword + '%'
        OR pn.tingkatKerusakan                     LIKE '%' + @keyword + '%'
        OR r.keterangan                            LIKE '%' + @keyword + '%'
        OR CONVERT(VARCHAR, r.tanggalTerdeteksi, 103) LIKE '%' + @keyword + '%'
        OR CAST(r.idRiwayat AS VARCHAR)            LIKE '%' + @keyword + '%';
END;
GO

--=====================================================================================
-- =====================
-- VIEW LAPORAN
-- (sama dengan vw_RiwayatPenyakit tapi tanggal tetap DATE
--  supaya filter tanggal di SP bisa jalan)
-- =====================
CREATE VIEW vw_Laporan AS
SELECT 
    r.idRiwayat,
    pt.namaPetani,
    p.jenisBibit,
    p.lokasiLahan,
    pn.Kategori             AS kategoriPenyakit,
    pn.tingkatKerusakan,
    r.tanggalTerdeteksi,    -- tetap DATE, bukan dikonversi string
    CASE 
        WHEN r.tanggalSelesai IS NULL THEN 'Belum Selesai'
        ELSE CONVERT(VARCHAR, r.tanggalSelesai, 103)
    END AS tanggalSelesai,
    r.keterangan,
    pp.jenisPerawatan,
    pp.jenisPestisida,
    pp.hasilPerawatan
FROM riwayatPenyakit r
JOIN Padi p         ON r.idPadi     = p.idPadi
JOIN petani pt      ON p.idPetani   = pt.idPetani
JOIN Penyakit pn    ON r.idPenyakit = pn.idPenyakit
LEFT JOIN perawatanPadi pp 
    ON pp.idPadi = r.idPadi AND pp.idPenyakit = r.idPenyakit;
GO

-- =====================
-- SP LAPORAN DENGAN FILTER
-- =====================
CREATE PROCEDURE sp_GetLaporan
    @tanggalAwal    DATE,
    @tanggalAkhir   DATE,
    @jenisBibit     VARCHAR(100) = NULL,  -- NULL = Semua
    @kategori       VARCHAR(50)  = NULL   -- NULL = Semua
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        r.idRiwayat,
        pt.namaPetani,
        p.jenisBibit,
        p.lokasiLahan,
        pn.Kategori             AS kategoriPenyakit,
        pn.tingkatKerusakan,
        CONVERT(VARCHAR, r.tanggalTerdeteksi, 103) AS tanggalTerdeteksi,
        CASE 
            WHEN r.tanggalSelesai IS NULL THEN 'Belum Selesai'
            ELSE CONVERT(VARCHAR, r.tanggalSelesai, 103)
        END AS tanggalSelesai,
        r.keterangan,
        pp.jenisPerawatan,
        pp.jenisPestisida,
        pp.hasilPerawatan
    FROM riwayatPenyakit r
    JOIN Padi p         ON r.idPadi     = p.idPadi
    JOIN petani pt      ON p.idPetani   = pt.idPetani
    JOIN Penyakit pn    ON r.idPenyakit = pn.idPenyakit
    LEFT JOIN perawatanPadi pp 
        ON pp.idPadi = r.idPadi AND pp.idPenyakit = r.idPenyakit
    WHERE 
        r.tanggalTerdeteksi BETWEEN @tanggalAwal AND @tanggalAkhir
        AND (@jenisBibit IS NULL OR p.jenisBibit = @jenisBibit)
        AND (@kategori   IS NULL OR pn.Kategori  = @kategori);
END;
GO

--================================================================================
-- SP COUNT dengan OUTPUT Parameter
--petani
CREATE PROCEDURE sp_CountPetani
    @totalData INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT @totalData = COUNT(*) FROM petani;
END;
GO

--padi
CREATE PROCEDURE sp_CountPadi        
    @totalData INT OUTPUT 
AS 
BEGIN 
    SELECT @totalData = COUNT(*) FROM Padi; 
END;
GO

--penyakit
CREATE PROCEDURE sp_CountPenyakit
    @totalData INT OUTPUT 
AS 
BEGIN 
    SELECT @totalData = COUNT(*) FROM Penyakit; 
END;
GO

--perawatan
CREATE PROCEDURE sp_CountPerawatan
    @totalData INT OUTPUT 
AS 
BEGIN 
    SELECT @totalData = COUNT(*) FROM perawatanPadi; 
END;
GO

--riwayat
CREATE PROCEDURE sp_CountRiwayat 
    @totalData INT OUTPUT 
AS 
BEGIN 
    SELECT @totalData = COUNT(*) FROM riwayatPenyakit; 
END;
GO

--===========================================================
--Backup data petani ke tabel sementara
--===========================================================
SELECT * INTO petani_backup FROM petani;

--------------------------------------------------------------

-- Hapus constraint lama
ALTER TABLE riwayatPenyakit DROP CONSTRAINT CK_Riwayat_TanggalSelesai;

-- Buat constraint baru: tanggal selesai tidak boleh melebihi hari ini
ALTER TABLE riwayatPenyakit ADD CONSTRAINT CK_Riwayat_TanggalSelesai
    CHECK (tanggalSelesai IS NULL OR 
          (tanggalSelesai >= '2000-01-01' AND tanggalSelesai <= GETDATE()));

-- Example: Set future dates to NULL or today's date
UPDATE dbo.riwayatPenyakit
SET tanggalSelesai = GETDATE()
WHERE tanggalSelesai > GETDATE();

--=====================================================
IF OBJECT_ID('v_ListStatus', 'V') IS NOT NULL DROP VIEW v_ListStatus
GO
CREATE VIEW v_ListStatus AS
SELECT DISTINCT statusAktif FROM petani
GO

IF OBJECT_ID('v_ListLahan', 'V') IS NOT NULL DROP VIEW v_ListLahan
GO
CREATE VIEW v_ListLahan AS
SELECT DISTINCT lokasiLahan FROM padi
GO

IF OBJECT_ID('v_ListPetaniCombo', 'V') IS NOT NULL DROP VIEW v_ListPetaniCombo
GO
CREATE VIEW v_ListPetaniCombo AS
SELECT idPetani, namaPetani FROM petani
GO

IF OBJECT_ID('v_ListBibit', 'V') IS NOT NULL DROP VIEW v_ListBibit
GO
CREATE VIEW v_ListBibit AS
SELECT DISTINCT jenisBibit FROM padi
GO

IF OBJECT_ID('v_ListKategori', 'V') IS NOT NULL DROP VIEW v_ListKategori
GO
CREATE VIEW v_ListKategori AS
SELECT DISTINCT Kategori FROM penyakit
GO

IF OBJECT_ID('v_ListTingkatKerusakan', 'V') IS NOT NULL DROP VIEW v_ListTingkatKerusakan
GO
CREATE VIEW v_ListTingkatKerusakan AS
SELECT DISTINCT tingkatKerusakan FROM penyakit
GO

IF OBJECT_ID('v_ListPestisida', 'V') IS NOT NULL DROP VIEW v_ListPestisida
GO
CREATE VIEW v_ListPestisida AS
SELECT DISTINCT jenisPestisida FROM perawatanPadi
GO

IF OBJECT_ID('v_ListHasil', 'V') IS NOT NULL DROP VIEW v_ListHasil
GO
CREATE VIEW v_ListHasil AS
SELECT DISTINCT hasilPerawatan FROM perawatanPadi
GO


SELECT name FROM sys.tables;

select * from admin
select * from petani
select * from Padi
select * from Penyakit
select * from perawatanPadi
select * from riwayatPenyakit
select * from petani_backup

--cek sp nya apa aja
SELECT name, type_desc, create_date, modify_date 
FROM sys.procedures;

-- lihat kode sp semua
SELECT 
    name AS ProcedureName,
    OBJECT_DEFINITION(object_id) AS ProcedureBody
FROM 
    sys.procedures;

-- cek isi view
SELECT 
    v.name AS ViewName,
    m.definition AS ViewDefinition
FROM 
    sys.sql_modules m
JOIN 
    sys.views v ON m.object_id = v.object_id;

-- =====================
-- VIEW PERAWATAN PADI (UPDATED)
-- =====================
ALTER VIEW vw_PerawatanPadi AS
SELECT 
    pp.idPerawatan,
    rp.idRiwayat,       -- Menggantikan idPadi & idPenyakit murni di tabel perawatan
    rp.idPadi,
    rp.idPenyakit,
    pt.namaPetani,
    p.jenisBibit,
    p.lokasiLahan,
    pn.Kategori         AS kategoriPenyakit,
    pp.jenisPerawatan,
    pp.jenisPestisida,
    CONVERT(VARCHAR, pp.tanggalPerawatan, 103) AS tanggalPerawatan,
    pp.hasilPerawatan
FROM perawatanPadi pp
JOIN RiwayatPenyakit rp ON pp.idRiwayat = rp.idRiwayat  -- Jalur berantai baru
JOIN Padi p            ON rp.idPadi     = p.idPadi
JOIN petani pt         ON p.idPetani    = pt.idPetani
JOIN Penyakit pn       ON rp.idPenyakit = pn.idPenyakit;
GO

-- =====================
-- SP INSERT PERAWATAN (UPDATED)
-- =====================
ALTER PROCEDURE sp_InsertPerawatan
    @idRiwayat        INT, -- Menggantikan idPadi & idPenyakit
    @jenisPerawatan   VARCHAR(100),
    @jenisPestisida   VARCHAR(100),
    @tanggalPerawatan DATE,
    @hasilPerawatan   VARCHAR(100),
    @hasilMsg         VARCHAR(200) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    -- Logika 1: Cek kasus riwayat penyakit ada
    IF NOT EXISTS (SELECT 1 FROM RiwayatPenyakit WHERE idRiwayat = @idRiwayat)
    BEGIN
        SET @hasilMsg = 'Data kasus riwayat penyakit tidak ditemukan!';
        RETURN;
    END

    -- Logika 2: Cek apakah kasus ini sudah pernah dirawat di tanggal yang sama
    IF EXISTS (
        SELECT 1 FROM perawatanPadi
        WHERE idRiwayat        = @idRiwayat
          AND tanggalPerawatan = @tanggalPerawatan
    )
    BEGIN
        SET @hasilMsg = 'Perawatan untuk kasus penyakit ini pada tanggal tersebut sudah dicatat!';
        RETURN;
    END

    -- Logika 3: Validasi konsistensi pestisida dengan kategori penyakit (Dilacak lewat idRiwayat)
    DECLARE @kategori VARCHAR(50);
    SELECT @kategori = pn.Kategori 
    FROM RiwayatPenyakit rp
    JOIN Penyakit pn ON rp.idPenyakit = pn.idPenyakit
    WHERE rp.idRiwayat = @idRiwayat;

    IF @kategori = 'Hama' AND @jenisPestisida = 'Fungisida Dithane'
    BEGIN
        SET @hasilMsg = 'Fungisida Dithane tidak cocok untuk kategori Hama!';
        RETURN;
    END

    IF @kategori = 'Penyakit' AND @jenisPestisida = 'Insektisida Furadan'
    BEGIN
        SET @hasilMsg = 'Insektisida Furadan tidak cocok untuk kategori Penyakit (jamur/bakteri)!';
        RETURN;
    END

    -- Insert ke tabel baru yang sudah memuat idRiwayat
    INSERT INTO perawatanPadi 
        (idRiwayat, jenisPerawatan, jenisPestisida, tanggalPerawatan, hasilPerawatan)
    VALUES 
        (@idRiwayat, @jenisPerawatan, @jenisPestisida, @tanggalPerawatan, @hasilPerawatan);

    SET @hasilMsg = 'OK';
END;
GO

-- =====================
-- SP UPDATE PERAWATAN (UPDATED)
-- =====================
ALTER PROCEDURE sp_UpdatePerawatan
    @idPerawatan      INT,
    @idRiwayat        INT, -- Menggantikan idPadi & idPenyakit
    @jenisPerawatan   VARCHAR(100),
    @jenisPestisida   VARCHAR(100),
    @tanggalPerawatan DATE,
    @hasilPerawatan   VARCHAR(100),
    @hasilMsg         VARCHAR(200) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    -- Logika 1: Cek data perawatan ada
    IF NOT EXISTS (SELECT 1 FROM perawatanPadi WHERE idPerawatan = @idPerawatan)
    BEGIN
        SET @hasilMsg = 'Data perawatan tidak ditemukan!';
        RETURN;
    END

    -- Logika 2: Cek duplikasi perawatan serupa pada tanggal yang sama (kecuali dirinya sendiri)
    IF EXISTS (
        SELECT 1 FROM perawatanPadi
        WHERE idRiwayat        = @idRiwayat
          AND tanggalPerawatan = @tanggalPerawatan
          AND idPerawatan     != @idPerawatan
    )
    BEGIN
        SET @hasilMsg = 'Perawatan serupa untuk kasus ini pada tanggal tersebut sudah ada!';
        RETURN;
    END

    -- Logika 3: Validasi konsistensi pestisida vs kategori penyakit
    DECLARE @kategori VARCHAR(50);
    SELECT @kategori = pn.Kategori 
    FROM RiwayatPenyakit rp
    JOIN Penyakit pn ON rp.idPenyakit = pn.idPenyakit
    WHERE rp.idRiwayat = @idRiwayat;

    IF @kategori = 'Hama' AND @jenisPestisida = 'Fungisida Dithane'
    BEGIN
        SET @hasilMsg = 'Fungisida Dithane tidak cocok untuk kategori Hama!';
        RETURN;
    END

    IF @kategori = 'Penyakit' AND @jenisPestisida = 'Insektisida Furadan'
    BEGIN
        SET @hasilMsg = 'Insektisida Furadan tidak cocok untuk kategori Penyakit!';
        RETURN;
    END

    -- Logika 4: Proteksi status 'Berhasil'
    DECLARE @hasilLama VARCHAR(100);
    SELECT @hasilLama = hasilPerawatan FROM perawatanPadi WHERE idPerawatan = @idPerawatan;

    IF @hasilLama = 'Berhasil' AND @hasilPerawatan = 'Gagal'
    BEGIN
        SET @hasilMsg = 'Perawatan yang sudah Berhasil tidak bisa diubah menjadi Gagal!';
        RETURN;
    END

    UPDATE perawatanPadi
    SET idRiwayat        = @idRiwayat,
        jenisPerawatan   = @jenisPerawatan,
        jenisPestisida   = @jenisPestisida,
        tanggalPerawatan = @tanggalPerawatan,
        hasilPerawatan   = @hasilPerawatan
    WHERE idPerawatan = @idPerawatan;

    SET @hasilMsg = 'OK';
END;
GO

-- =====================
-- SP SEARCH PERAWATAN (UPDATED)
-- =====================
ALTER PROCEDURE sp_SearchPerawatan
    @keyword VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    SET @keyword = LTRIM(RTRIM(@keyword));

    SELECT 
        pp.idPerawatan,
        rp.idRiwayat,
        rp.idPadi,
        rp.idPenyakit,
        pt.namaPetani,
        p.jenisBibit,
        p.lokasiLahan,
        pn.Kategori         AS kategoriPenyakit,
        pp.jenisPerawatan,
        pp.jenisPestisida,
        CONVERT(VARCHAR, pp.tanggalPerawatan, 103) AS tanggalPerawatan,
        pp.hasilPerawatan
    FROM perawatanPadi pp
    JOIN RiwayatPenyakit rp ON pp.idRiwayat = rp.idRiwayat
    JOIN Padi p            ON rp.idPadi     = p.idPadi
    JOIN petani pt         ON p.idPetani    = pt.idPetani
    JOIN Penyakit pn       ON rp.idPenyakit = pn.idPenyakit
    WHERE 
        CAST(pp.idPerawatan AS VARCHAR)              LIKE '%' + @keyword + '%'
        OR pt.namaPetani                             LIKE '%' + @keyword + '%'
        OR p.jenisBibit                              LIKE '%' + @keyword + '%'
        OR pn.Kategori                               LIKE '%' + @keyword + '%'
        OR pp.jenisPerawatan                         LIKE '%' + @keyword + '%'
        OR pp.jenisPestisida                         LIKE '%' + @keyword + '%'
        OR pp.hasilPerawatan                         LIKE '%' + @keyword + '%'
        OR CONVERT(VARCHAR, pp.tanggalPerawatan,103) LIKE '%' + @keyword + '%';
END;
GO


--Perbaikan constarint perawatan padi
DECLARE @ConstraintName NVARCHAR(200);

-- 1. Mencari nama acak constraint jenisPestisida secara otomatis
SELECT @ConstraintName = dc.name
FROM sys.check_constraints dc
WHERE dc.parent_object_id = OBJECT_ID('perawatanPadi')
  AND dc.definition LIKE '%jenisPestisida%';

-- 2. Jika ketemu, hapus constraint acak tersebut
IF @ConstraintName IS NOT NULL
BEGIN
    EXEC('ALTER TABLE perawatanPadi DROP CONSTRAINT ' + @ConstraintName);
END

-- 3. Buat baru dengan nama yang konsisten dan tambahkan opsi 'Tanpa Pestisida'
ALTER TABLE perawatanPadi 
ADD CONSTRAINT CK_Perawatan_JenisPestisida 
CHECK (jenisPestisida IN ('Insektisida Furadan', 'Fungisida Dithane', 'Herbisida Glyphosate', 'Tanpa Pestisida'));


SELECT name, definition 
FROM sys.check_constraints 
WHERE parent_object_id = OBJECT_ID('perawatanPadi');

--PERBAIAK SP GET LAPORAN 
ALTER PROCEDURE sp_GetLaporan
    @tanggalAwal    DATE,
    @tanggalAkhir   DATE,
    @jenisBibit     VARCHAR(100) = NULL,
    @kategori       VARCHAR(50)  = NULL
AS
BEGIN
    SET NOCOUNT ON;

    -- Menyelaraskan string 'Semua' dari C# agar dibaca sebagai NULL (Semua Data) oleh SQL
    IF @jenisBibit = 'Semua' SET @jenisBibit = NULL;
    IF @kategori = 'Semua'   SET @kategori = NULL;

    SELECT 
        r.idRiwayat,
        pt.namaPetani,
        p.jenisBibit,
        p.lokasiLahan,
        pn.Kategori                             AS kategoriPenyakit,
        pn.tingkatKerusakan,
        CONVERT(VARCHAR, r.tanggalTerdeteksi, 103) AS tanggalTerdeteksi,
        CASE 
            WHEN r.tanggalSelesai IS NULL THEN 'Belum Selesai'
            ELSE CONVERT(VARCHAR, r.tanggalSelesai, 103)
        END AS tanggalSelesai,
        r.keterangan,
        pp.jenisPerawatan,
        pp.jenisPestisida,
        pp.hasilPerawatan
    FROM riwayatPenyakit r
    JOIN Padi p         ON r.idPadi     = p.idPadi
    JOIN petani pt      ON p.idPetani   = pt.idPetani
    JOIN Penyakit pn    ON r.idPenyakit = pn.idPenyakit
    -- FIX JALUR BERANTAI: Hubungkan menggunakan idRiwayat yang baru
    LEFT JOIN perawatanPadi pp ON pp.idRiwayat = r.idRiwayat
    WHERE 
        r.tanggalTerdeteksi BETWEEN @tanggalAwal AND @tanggalAkhir
        AND (@jenisBibit IS NULL OR p.jenisBibit = @jenisBibit)
        AND (@kategori   IS NULL OR pn.Kategori  = @kategori);
END;
GO