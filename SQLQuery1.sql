-- A�� tablosu i�in do�ru veri giri�i
INSERT INTO Asi (AsiAdi, AsiTarihi, SonrakiTarih)
VALUES ('Kuduz A��s�', '2024-06-01', '2025-06-01');

-- Tedavi tablosu i�in �rnekler
INSERT INTO Tedavi (Teshis, UygulananTedavi, Ucret)
VALUES
('Kulak enfeksiyonu', 'Antibiyotik tedavisi', 350.00),
('Di� eti iltihab�', 'Di� temizli�i ve ila�', 500.00),
('�� parazit', 'A��zdan �urup uygulamas�', 250.00),
('Kuduz', 'A�� yap�ld�', 150.00);


-- Hayvan ve veteriner tablolar�nda ID = 1 kay�tlar� varsa bu �al���r.
INSERT INTO Randevu (Tarih, Saat, Aciklama,VeterinerID)
VALUES
('2024-06-01', '10:00', 'Genel kontrol', 1),
('2024-06-02', '11:00', 'Di� temizli�i', 1),
('2024-06-03', '12:00', 'A�� uygulamas�', 1);

