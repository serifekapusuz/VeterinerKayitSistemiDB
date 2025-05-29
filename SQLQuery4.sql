INSERT INTO Musteri (Ad, Soyad, Telefon, Adres)
VALUES 
('Ahmet', 'Yýlmaz', '05551112233', 'Ýstanbul, Kadýköy'),
('Elif', 'Kaya', '05332221144', 'Ankara, Çankaya'),
('Mehmet', 'Demir', '05443334455', 'Ýzmir, Konak');

ALTER TABLE Hayvan
ALTER COLUMN Cinsiyet NVARCHAR(10);


INSERT INTO Hayvan (Ad, Tur, Irk, DogumTarihi, Cinsiyet, MusteriID)
VALUES
('Pamuk', 'Kedi', 'Van Kedisi', '2020-05-10', 'Diþi', 1),
('Karabaþ', 'Köpek', 'Golden Retriever', '2019-08-20', 'Erkek', 2),
('Minik', 'Kedi', 'Tekir', '2021-01-15', 'Diþi', 3);

INSERT INTO Veteriner (Ad, Soyad, Uzmanlik)
VALUES
('Can', 'Öztürk', 'Dahiliye'),
('Zeynep', 'Yýldýz', 'Cerrahi');

SELECT HayvanID, Ad, Tur FROM Hayvan;
SELECT VeterinerID, Ad, Soyad FROM Veteriner;



INSERT INTO Randevu (Tarih, Saat, Aciklama, HayvanID, VeterinerID)
VALUES
('2024-06-01', '10:00', 'Yýllýk genel kontrol', 5, 1),
('2024-06-03', '11:30', 'Aþý takibi', 2, 2),
('2024-06-05', '09:00', 'Göz muayenesi', 6, 1);

-- Aþý tablosu için doðru veri giriþi
INSERT INTO Asi (AsiAdi, AsiTarihi, SonrakiTarih, HayvanID)
VALUES ('Kuduz Aþýsý', '2024-06-01', '2025-06-01', 1);

-- Tedavi tablosu için örnekler
INSERT INTO Tedavi (RandevuID, Teshis, UygulananTedavi, Ucret)
VALUES
(6 ,'Kulak enfeksiyonu', 'Antibiyotik tedavisi', 350.00),
(7 ,'Diþ eti iltihabý', 'Diþ temizliði ve ilaç', 500.00),
(8 ,'Ýç parazit', 'Aðýzdan þurup uygulamasý', 250.00),
(9, 'Kuduz', 'Aþý yapýldý', 150.00);

sp_help Tedavi;

SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Tedavi';

SELECT * FROM Randevu WHERE RandevuID = 1;

INSERT INTO Randevu (Tarih, Saat, Aciklama, HayvanID, VeterinerID)
VALUES
('2024-06-01', '10:00', 'Genel kontrol', 1, 1),     -- RandevuID = 1
('2024-06-02', '11:00', 'Diþ kontrolü', 1, 1),       -- RandevuID = 2
('2024-06-03', '12:00', 'Aþý kontrolü', 1, 1);       -- RandevuID = 3
