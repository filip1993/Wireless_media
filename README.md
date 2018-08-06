# WirelessMedia

Aplikacija prikazuje proizvode i omogućava unos i izmenu istih.
U aplikaciji postoji mogućnost korišćenja dve baze. Tj. SQL baze podataka i JSON fajl koji služi kao baza.
Aplikacija je rađena sa samo jednom tabelom, "Proizvod". JSON fajl se nalazi u folderu App_Data.

### SQL upiti za kreiranje baze i primeri unosa početnih proizvoda
---
CREATE TABLE Proizvod(
 ProizvodId int IDENTITY(1,1) PRIMARY KEY,
 Kategorija nvarchar(100) NULL,
 Proizvodjac nvarchar(100) NULL,
 Dobavljac nvarchar(100) NULL,
 Naziv nvarchar(100) NULL,
 Opis nvarchar(100) NULL,
 Cena decimal(10, 2) NOT NULL
);

INSERT INTO Proizvod (Cena, Kategorija, Naziv, Opis, Proizvodjac, Dobavljac) VALUES (CAST(34059.50 AS Decimal(10,2)), 'Procesori', 'AMD Ryzen 3 2200G', '3.5 GHz (3.7 GHz) AMD® AM4, AMD® Ryzen (3.gen)','Asus','Win Win')

INSERT INTO Proizvod (Cena, Kategorija, Naziv, Opis, Proizvodjac, Dobavljac) VALUES (CAST(10234.95 AS Decimal(10,2)), 'Procesori', 'AMD Ryzen 5 1600', '3.2 GHz (3.6 GHz) BOX sa Wraith Spire cooler-om AMD® AM4, AMD® Ryzen (5.gen)','Asus','Gigatron')

INSERT INTO Proizvod (Cena, Kategorija, Naziv, Opis, Proizvodjac, Dobavljac) VALUES (CAST(20999.00 AS Decimal(10,2)), 'Procesori', 'INTEL Core i7-8700K', '3.7GHz (4.7GHz) Intel® 1151 (8. gen.)','Intel','Emmi')

INSERT INTO Proizvod (Cena, Kategorija, Naziv, Opis, Proizvodjac, Dobavljac) VALUES (CAST(24999.00 AS Decimal(10,2)), 'Maticne ploce', 'ASUS PRIME', 'Z370-P Intel,(8. gen.),ATX','Intel','Win Win')

INSERT INTO Proizvod (Cena, Kategorija, Naziv, Opis, Proizvodjac, Dobavljac) VALUES (CAST(34999.00 AS Decimal(10,2)), 'Maticne ploce', 'ASUS MAXIMUS X HERO','(Wi-Fi AC) Intel,(8. gen.),Mini ATX','Intel','Gigatron')

INSERT INTO Proizvod (Cena, Kategorija, Naziv, Opis, Proizvodjac, Dobavljac) VALUES (CAST(15999.00 AS Decimal(10,2)), 'Maticne ploce', 'ASUS MB', 'SOCKET AM4 - ROG STRIX B350-F GAMING,ATX','Intel','Emmi')

INSERT INTO Proizvod (Cena, Kategorija, Naziv, Opis, Proizvodjac, Dobavljac) VALUES (CAST(34000.00 AS Decimal(10,2)), 'Memorije', 'G.SKILL Value', '8GB DDR4 2400MHz CL15 - F4-2400C15S-8GNT DDR4, 8GB,1.2V','Corsair','Comtrade')

INSERT INTO Proizvod (Cena, Kategorija, Naziv, Opis, Proizvodjac, Dobavljac) VALUES (CAST(12000.95 AS Decimal(10,2)), 'Memorije', 'HYPERX Predator Black', '8GB DDR4 3000MHz CL15 - HX430C15PB3/8 DDR4, 8GB,1.35V','Corsair','Win Win')

INSERT INTO Proizvod (Cena, Kategorija, Naziv, Opis, Proizvodjac, Dobavljac) VALUES (CAST(14999.00 AS Decimal(10,2)), 'Memorije', 'KINGSTON FURY Red', '8GB DDR3 1866MHz CL10 - HX318C10FR/8 DDR3, 8GB','Corsair','Gigatron')

INSERT INTO Proizvod (Cena, Kategorija, Naziv, Opis, Proizvodjac, Dobavljac) VALUES (CAST(34275.00 AS Decimal(10,2)), 'Graficke karte', 'ASUS nVidia GeForce GTX 1050Ti Phoenix','4GB GDDR5 128bit - PH-GTX1050TI-4G PCI Express 3.0, Nvidia','Nvidia','Emmi')

INSERT INTO Proizvod (Cena, Kategorija, Naziv, Opis, Proizvodjac, Dobavljac) VALUES (CAST(23348.95 AS Decimal(10,2)), 'Graficke karte', 'ASUS GeForce GTX 1050 Ti Cerberus', 'OC 4GB GDDR5 128bit - CERBERUS-GTX1050TI-O4G, PCI Express 3.0','Nvidia','Comtrade')

### Pristupne tačke - SQL baza
---
  - /, Home, Home/Index - za prikaz proizvoda
  - Home/Create - za kreiranje novog proizvoda
  - Home/Edit/id - za izmenu postojećeg proizvoda čijem id-u odgovara parametar id

### Pristupne tačke - JSON fajl
---
  - Json, Json/Index - za prikaz proizvoda
  - Json/Create - za kreiranje novog proizvoda
  - Json/Edit/id - za izmenu postojećeg proizvoda čijem id-u odgovara parametar id
