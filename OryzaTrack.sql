CREATE DATABASE OryzaTrack;
GO
USE OryzaTrack;
GO

CREATE TABLE admin (
    idAdmin       INT IDENTITY(1,1) PRIMARY KEY,
    namaAdmin     VARCHAR(100),
    username      VARCHAR(50),
    passwordAdmin VARCHAR(100),
    email         VARCHAR(100) CONSTRAINT Cek_Email CHECK (email LIKE '%@%')
);

CREATE TABLE hama (
    idHama          INT IDENTITY(1,1) PRIMARY KEY,
    idAdmin         INT FOREIGN KEY REFERENCES admin(idAdmin),
    namaHama        VARCHAR(100),
    jenisHama       VARCHAR(100),
    gejalaHama      TEXT,
    lokasiLahan     VARCHAR(100),
    tanggalSerangan DATE
);

CREATE TABLE riwayatPenyakit (
    idPenyakit      INT IDENTITY(1,1) PRIMARY KEY,
    idAdmin         INT FOREIGN KEY REFERENCES admin(idAdmin),
    gejalaPenyakit  VARCHAR(100),
    tingkatKerusakan VARCHAR(50),
    lokasiLahan     VARCHAR(100),
    tanggalSerangan DATE
);

CREATE TABLE perawatanPadi (
    idPerawatan      INT IDENTITY(1,1) PRIMARY KEY,
    idAdmin          INT FOREIGN KEY REFERENCES admin(idAdmin),
    idPenyakit       INT FOREIGN KEY REFERENCES riwayatPenyakit(idPenyakit),
    idHama           INT FOREIGN KEY REFERENCES hama(idHama),
    jenisPerawatan   VARCHAR(100),
    jenisPestisida   VARCHAR(100),
    tanggalPerawatan DATE,
    hasilPerawatan   VARCHAR(100)
);

-- Insert data admin default
INSERT INTO admin (namaAdmin, username, passwordAdmin, email)
VALUES ('Administrator', 'admin', 'admin123', 'admin@pertanian.com');

-- Insert sample data hama
INSERT INTO hama (idAdmin, namaHama, jenisHama, gejalaHama, lokasiLahan, tanggalSerangan)
VALUES 
(1, 'Wereng Coklat', 'Serangga', 'Daun menguning dan mengering', 'Blok A', '2025-01-10'),
(1, 'Tikus Sawah', 'Mamalia', 'Batang padi terpotong', 'Blok B', '2025-02-15');

-- Insert sample data riwayatPenyakit
INSERT INTO riwayatPenyakit (idAdmin, gejalaPenyakit, tingkatKerusakan, lokasiLahan, tanggalSerangan)
VALUES 
(1, 'Bercak coklat pada daun', 'Sedang', 'Blok A', '2025-01-12'),
(1, 'Busuk batang', 'Berat', 'Blok C', '2025-02-20');

-- Insert sample data perawatanPadi
INSERT INTO perawatanPadi (idAdmin, idPenyakit, idHama, jenisPerawatan, jenisPestisida, tanggalPerawatan, hasilPerawatan)
VALUES 
(1, 1, 1, 'Penyemprotan', 'Insektisida Furadan', '2025-01-15', 'Berhasil'),
(1, 2, 2, 'Pemasangan Jebakan', 'Rodentisida', '2025-02-25', 'Sebagian Berhasil');