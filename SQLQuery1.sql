-- Aþý tablosu için doðru veri giriþi
INSERT INTO Asi (AsiAdi, AsiTarihi, SonrakiTarih)
VALUES ('Kuduz Aþýsý', '2024-06-01', '2025-06-01');

-- Tedavi tablosu için örnekler
INSERT INTO Tedavi (Teshis, UygulananTedavi, Ucret)
VALUES
('Kulak enfeksiyonu', 'Antibiyotik tedavisi', 350.00),
('Diþ eti iltihabý', 'Diþ temizliði ve ilaç', 500.00),
('Ýç parazit', 'Aðýzdan þurup uygulamasý', 250.00),
('Kuduz', 'Aþý yapýldý', 150.00);


-- Hayvan ve veteriner tablolarýnda ID = 1 kayýtlarý varsa bu çalýþýr.
INSERT INTO Randevu (Tarih, Saat, Aciklama,VeterinerID)
VALUES
('2024-06-01', '10:00', 'Genel kontrol', 1),
('2024-06-02', '11:00', 'Diþ temizliði', 1),
('2024-06-03', '12:00', 'Aþý uygulamasý', 1);

