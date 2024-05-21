-- Active: 1716291186468@@127.0.0.1@5432@bi@public
create table barang ("KODE" varchar(255) primary key, "NAMA" varchar(255), "HARGA" decimal(255,0));
create table pelanggan ("KODE" varchar(11) primary key, "NAMA" varchar(255), "ALAMAT" varchar(255));
create table transaksi("KODE" varchar(255) primary key, "TANGGAL" date, "KODE_PELANGGAN" varchar(255) references pelanggan("KODE"), "KODE_BARANG" varchar(255) references barang("KODE"), "JUMLAH_BARANG" decimal(255,0));
insert into pelanggan("KODE", "NAMA", "ALAMAT") values
('P1', 'Yogi', 'JAKARTA'),
('P2', 'Anggi', 'BANDUNG'),
('P3', 'Rahma', 'BANDUNG');
insert into barang ("KODE", "NAMA", "HARGA") values
('B1', 'Baju', 12000),
('B2', 'Celana', 10000),
('B3', 'Sepatu', 30000);

insert into transaksi("KODE", "TANGGAL", "KODE_PELANGGAN", "KODE_BARANG", "JUMLAH_BARANG") values 
('TRX001', '2019-10-02', 'P1', 'B1', 3),
('TRX002', '2019-10-02', 'P2', 'B2', 2),
('TRX003', '2019-10-08', 'P2', 'B1', 5),
('TRX004', '2019-10-10', 'P1', 'B1', 1),
('TRX005', '2019-10-17', 'P3', 'B3', 2),
('TRX006', '2019-10-17', 'P2', 'B3', 1),
('TRX007', '2019-10-18', 'P3', 'B1', 4),
('TRX008', '2019-10-18', 'P2', 'B2', 2);

-- 4 A
SELECT * FROM barang WHERE "HARGA" > 10000 ORDER BY "HARGA" ASC;

-- 4 B
SELECT * FROM pelanggan WHERE "NAMA" LIKE '%g%';

-- 4 C
SELECT t."KODE", t."TANGGAL", p."NAMA" as "NAMA PELANGGAN", b."NAMA" as "NAMA BARANG", t."JUMLAH_BARANG" as JUMLAH, b."HARGA" as "HARGA SATUAN", sum(t."JUMLAH_BARANG"*b."HARGA") as TOTAL FROM transaksi as t
JOIN barang as b ON b."KODE" = t."KODE_BARANG"
JOIN pelanggan as p ON p."KODE" = t."KODE_PELANGGAN"
GROUP BY t."KODE", p."NAMA", b."NAMA", t."JUMLAH_BARANG", b."HARGA"
ORDER BY p."NAMA", t."TANGGAL";

-- 4 D
SELECT p."NAMA" as "NAMA PELANGGAN", sum(t."JUMLAH_BARANG") as "JUMLAH", sum(t."JUMLAH_BARANG" * b."HARGA") as "TOTAL HARGA" FROM transaksi as t
JOIN pelanggan as p ON p."KODE" = t."KODE_PELANGGAN"
JOIN barang as b ON b."KODE" = t."KODE_BARANG"
GROUP BY p."NAMA"
ORDER BY p."NAMA";
