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
    idPadi           INT NOT NULL,
    idPenyakit       INT NOT NULL,
    jenisPerawatan   VARCHAR(100) NOT NULL,
    jenisPestisida   VARCHAR(100) NOT NULL,
    tanggalPerawatan DATE NOT NULL,
    hasilPerawatan   VARCHAR(100) NOT NULL,

    --Primary Key
    CONSTRAINT PK_Perawatan PRIMARY KEY (idPerawatan),

    --Foreign Key
    CONSTRAINT FK_Perawatan_Padi 
        FOREIGN KEY (idPadi) REFERENCES Padi(idPadi)
        ON DELETE CASCADE,

    CONSTRAINT FK_Perawatan_Penyakit 
        FOREIGN KEY (idPenyakit) REFERENCES Penyakit(idPenyakit)
        ON DELETE CASCADE,

    -- CK : Validasi format data
    CONSTRAINT CK_Perawatan_JenisPestisida
        CHECK (jenisPestisida IN ('Insektisida Furadan', 'Fungisida Dithane', 'Herbisida Glyphosate')),

    CONSTRAINT CK_Perawatan_TanggalPerawatan
        CHECK (YEAR(tanggalPerawatan) BETWEEN 2025 AND 2026),

    CONSTRAINT CK_Perawatan_HasilPerawatan
        CHECK (hasilPerawatan IN ('Berhasil', 'Sebagian Berhasil', 'Gagal'))
);

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