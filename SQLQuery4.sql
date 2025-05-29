INSERT INTO Musteri (Ad, Soyad, Telefon, Adres)
VALUES 
('Ahmet', 'Y�lmaz', '05551112233', '�stanbul, Kad�k�y'),
('Elif', 'Kaya', '05332221144', 'Ankara, �ankaya'),
('Mehmet', 'Demir', '05443334455', '�zmir, Konak');

ALTER TABLE Hayvan
ALTER COLUMN Cinsiyet NVARCHAR(10);


INSERT INTO Hayvan (Ad, Tur, Irk, DogumTarihi, Cinsiyet, MusteriID)
VALUES
('Pamuk', 'Kedi', 'Van Kedisi', '2020-05-10', 'Di�i', 1),
('Karaba�', 'K�pek', 'Golden Retriever', '2019-08-20', 'Erkek', 2),
('Minik', 'Kedi', 'Tekir', '2021-01-15', 'Di�i', 3);

INSERT INTO Veteriner (Ad, Soyad, Uzmanlik)
VALUES
('Can', '�zt�rk', 'Dahiliye'),
('Zeynep', 'Y�ld�z', 'Cerrahi');

SELECT HayvanID, Ad, Tur FROM Hayvan;
SELECT VeterinerID, Ad, Soyad FROM Veteriner;



INSERT INTO Randevu (Tarih, Saat, Aciklama, HayvanID, VeterinerID)
VALUES
('2024-06-01', '10:00', 'Y�ll�k genel kontrol', 5, 1),
('2024-06-03', '11:30', 'A�� takibi', 2, 2),
('2024-06-05', '09:00', 'G�z muayenesi', 6, 1);

-- A�� tablosu i�in do�ru veri giri�i
INSERT INTO Asi (AsiAdi, AsiTarihi, SonrakiTarih, HayvanID)
VALUES ('Kuduz A��s�', '2024-06-01', '2025-06-01', 1);

-- Tedavi tablosu i�in �rnekler
INSERT INTO Tedavi (RandevuID, Teshis, UygulananTedavi, Ucret)
VALUES
(6 ,'Kulak enfeksiyonu', 'Antibiyotik tedavisi', 350.00),
(7 ,'Di� eti iltihab�', 'Di� temizli�i ve ila�', 500.00),
(8 ,'�� parazit', 'A��zdan �urup uygulamas�', 250.00),
(9, 'Kuduz', 'A�� yap�ld�', 150.00);

sp_help Tedavi;

SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Tedavi';

SELECT * FROM Randevu WHERE RandevuID = 1;

INSERT INTO Randevu (Tarih, Saat, Aciklama, HayvanID, VeterinerID)
VALUES
('2024-06-01', '10:00', 'Genel kontrol', 1, 1),     -- RandevuID = 1
('2024-06-02', '11:00', 'Di� kontrol�', 1, 1),       -- RandevuID = 2
('2024-06-03', '12:00', 'A�� kontrol�', 1, 1);       -- RandevuID = 3
