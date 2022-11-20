Create Database BTL_CSharp
Go
Use BTL_CSharp
Go
Create table tChiTietHDB
(
	SoHDB nvarchar(10) not null,
	MaSP nvarchar(10) not null,
	SLBan int,
	Khuyenmai float,
	 CONSTRAINT [PK_tChiTietHDB] PRIMARY KEY CLUSTERED 
(
	[SoHDB] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

;
CREATE TABLE tHoaDonBan
(
	SoHDB Nvarchar(10) not null,
	MaNV Nvarchar(10),
	MaKH Nvarchar(10), 
	NgayLap Datetime,
	Thanhtien money
	Constraint [PK_tHoaDonBan] PRIMARY KEY CLUSTERED
(
	[SoHDB] ASC
	
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON ) ON [PRIMARY]
)ON [PRIMARY]
;
GO
Create Table tChitietHDN
(
	SoHDN Nvarchar(10) not null,
	MaSP Nvarchar(10) not null,
	SLNhap int,
	Khuyenmai float,
	Constraint [PK_tChiTietHDN] PRIMARY KEY CLUSTERED
(
	[SoHDN] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS =ON, ALLOW_PAGE_LOCKS =ON)ON [PRIMARY]
)ON [PRIMARY]
;

Create Table tHoaDonNhap
(
	SoHDN Nvarchar(10) not null, 
	MaNCC Nvarchar(10) ,
	MaNV Nvarchar(10),
	NgayNhap Datetime,
	ThanhTien money,
	Constraint [PK_tHoaDonNhap] PRIMARY KEY CLUSTERED
(
	[SoHDN] ASC
	
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON ) ON [PRIMARY]
)ON [PRIMARY]
;
GO
Create Table tNhanVien
(
	MaNV Nvarchar(10) not null,
	TenNV Nvarchar(40) not null,
	Ngaysinh Datetime,
	DienThoai Nvarchar(20),
	Diachi Nvarchar(40),
	Username nvarchar(30),
	Password nvarchar(1000) not null,
	LoaiTaiKhoan int not null
	Constraint [PK_tNhanVien] PRIMARY KEY CLUSTERED
(
	[MaNV] ASC
	
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON ) ON [PRIMARY]
)ON [PRIMARY]

;

ALTER TABLE tNHANVIEN
ADD
	CONSTRAINT CHK_NHANVIEN_SODIENTHOAI
	CHECK (	DIENTHOAI LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'
			or DIENTHOAI LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'
			or DIENTHOAI LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')

Create Table tKhachHang
(
	MaKH Nvarchar(10) not null,
	TenKH Nvarchar(20) not null,
	GioiTinh nvarchar(10),
	DienThoai nvarchar(20),
	DiaChi nvarchar(40),
	Constraint [PK_tKhachHang] PRIMARY KEY CLUSTERED
(
	[MaKH] ASC
	
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON ) ON [PRIMARY]
)ON [PRIMARY]
;
select * from tNhanVien
GO
ALTER TABLE tKhachHang
ADD
	CONSTRAINT CHK_KhachHang_SODIENTHOAI
	CHECK (	DIENTHOAI LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'
			or DIENTHOAI LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'
			or DIENTHOAI LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')

Create Table tThuongHieu
(
	MaTH nvarchar(10) not null,
	TenTH nvarchar(20) not null
	Constraint [PK_tThuongHieu] PRIMARY KEY CLUSTERED
(
	[MaTH] ASC
	
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON ) ON [PRIMARY]
)ON [PRIMARY]

;
GO
Create Table tNhaCungCap
(
	MaNCC nvarchar(10) not null,
	TenNCC nvarchar(40) not null,
	DienThoai nvarchar(20),
	DiaChi nvarchar(40),
	Constraint [PK_tNhaCungCap] PRIMARY KEY CLUSTERED
(
	[MaNCC] ASC
	
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON ) ON [PRIMARY]
)ON [PRIMARY]
;
ALTER TABLE tNhaCungCap
ADD
	CONSTRAINT CHK_NhaCungCap_SODIENTHOAI
	CHECK (	DIENTHOAI LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'
			or DIENTHOAI LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'
			or DIENTHOAI LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
GO
CREATE Table tSanPham
(
	MaSP Nvarchar(10) not null,
	TenSP Nvarchar(20) not null,
	MaTH nvarchar(10),
	KichThuoc nvarchar(10),
	ManHinh nvarchar(15),
	SoLuong int ,
	DonGiaNhap money,
	DonGiaBan money,
	HinhAnh nvarchar(20),
	GhiChu nvarchar(255),
	Constraint [PK_tSanPham] PRIMARY KEY CLUSTERED
(
	[MaSP] ASC
	
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON ) ON [PRIMARY]
)ON [PRIMARY]
;

ALTER TABLE [tChiTietHDB]  WITH CHECK ADD  CONSTRAINT [FK_tChiTietHDB_tHoaDonBan] FOREIGN KEY([SoHDB])
REFERENCES [tHoaDonBan] ([SoHDB])
ALTER TABLE [tChiTietHDB]  WITH CHECK ADD  CONSTRAINT [FK_tChiTietHDB_tSanPham] FOREIGN KEY([MaSP])
REFERENCES [tSanPham] ([MaSP])
ALTER TABLE [tChiTietHDN]  WITH CHECK ADD  CONSTRAINT [FK_tChiTietHDB_tHoaDonNhap] FOREIGN KEY([SoHDN])
REFERENCES [tHoaDonNhap] ([SoHDN])
ALTER TABLE [tChiTietHDN]  WITH CHECK ADD  CONSTRAINT [FK_tChiTietHDN_tSanPham] FOREIGN KEY([MaSP])
REFERENCES [tSanPham] ([MaSP])
ALTER TABLE [tHoaDonNhap]  WITH CHECK ADD  CONSTRAINT [FK_tHoaDonNhap_tNhanVien] FOREIGN KEY([MaNV])
REFERENCES [tNhanVien] ([MaNV])
ALTER TABLE [tHoaDonNhap]  WITH CHECK ADD  CONSTRAINT [FK_tHoaDonNhap_tNhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [tNhaCungCap] ([MaNCC])
ALTER TABLE [tHoaDonBan]  WITH CHECK ADD  CONSTRAINT [FK_tHoaDonBan_tKhachHang] FOREIGN KEY([MaKH])
REFERENCES [tKhachHang] ([MaKH])
ALTER TABLE [tHoaDonBan]  WITH CHECK ADD  CONSTRAINT [FK_tHoaDonBan_tNhanVien] FOREIGN KEY([MaNV])
REFERENCES [tNhanVien] ([MaNV])
ALTER TABLE [tSanPham]  WITH CHECK ADD  CONSTRAINT [FK_tSanPham_tThuongHieu] FOREIGN KEY([MaTH])
REFERENCES [tThuongHieu] ([MaTH])

insert tHoaDonNhap values(N'HDN001',N'NCC001', N'NV002', '2021-10-14', 16000000)
insert tHoaDonNhap values(N'HDN002',N'NCC002', N'NV003', '2022-9-20', 78000000)
--select * from tHoaDonNhap
GO

insert tChiTietHDN values(N'HDN001',N'SP002', '2', 0)
insert tChiTietHDN values(N'HDN001',N'SP003', '4', 0)
insert tChiTietHDN values(N'HDN002',N'SP004', '6', 0)
insert tChiTietHDN values(N'HDN002',N'SP005', '8', 0)
GO
insert tHoaDonBan values(N'HDB001', N'NV002', N'KH002', '2022-10-14',21000000)
insert tHoaDonBan values(N'HDB002', N'NV002', N'KH003', '2022-10-13',16000000)

--select * from tHoaDonBan
GO
insert tChiTietHDB values(N'HDB001', N'SP002', '3', 0)
insert tChiTietHDB values(N'HDB001', N'SP003', '1', 0)
insert tChiTietHDB values(N'HDB002', N'SP004', '1', 0)
insert tChiTietHDB values(N'HDB002', N'SP005', '1', 0)

--select * from tChiTietHDB
GO
insert tKhachHang values(N'KH001', N'cao ba sung', N'Nữ', '0929292939', N'Hà Nội')
insert tKhachHang values(N'KH002', N'Ngô Văn Anh', N'Nam', '0929292929', N'Hà Nội')
insert tKhachHang values(N'KH003', N'nguyen thi cao', N'Nữ', '0939292929', N'TP HCM')
GO
--select * from tKhachHang

insert tThuongHieu values(N'TH001', 'Sonny')
insert tThuongHieu values(N'TH002', 'SamSung')
--select * from tThuongHieu
GO
insert tSanPham values(N'SP002', 'SamSung OLED', N'TH002', '32 inch', 'OLED',9 , 2000000, 5000000, null,null)
insert tSanPham values(N'SP003', 'Sony OLED', N'TH001', '39 inch', 'OLED',6, 4000000, 6000000, null,null)
insert tSanPham values(N'SP004', 'Sony OFD', N'TH001', '56 inch', 'OLED',4, 5000000, 7000000, null,null)
insert tSanPham values(N'SP005', 'Sony FFD', N'TH001', '48 inch', 'OLED', 7, 6000000, 9000000, null,null)

select * from tSanPham
GO
insert tNhanVien values(N'NV003', N'Vũ Trường Phước', '2002-7-7', '0123456789', N'Hải Dương','phuoc','123', 1)
insert tNhanVien values(N'NV002', N'Vương Kiến Quốc', '2002-8-5', '0987654321', N'Hà Nội','quoc','222', 1)
insert tNhanVien values(N'NV001', N'Ngô Văn Anh', '2002-6-5', '0987654333', N'Hà Nội','anh','222', 0)
insert tNhanVien values(N'NV004', N'Phạm Minh Quân', '2002-11-4', '0987654322', N'Hà Nội','quan','222', 0)
--select * from tNhanVien
GO
insert tNhaCungCap VALUES (N'NCC001', N'Huấn Rose', '0111312222', N'Hà Nội')
insert tNhaCungCap VALUES (N'NCC002', N'Khá Bảnh', '0111112222', N'Hà Nội')
--select * from tNhaCungCap
GO
select * from tHoaDonBan where CONVERT(date,NgayLap,105) like '%10-14-2022%'
--select * from tHoaDonBan where CONVERT(nvarchar(20),NgayLap,105) like '2022-10-13'
--cap nhat hoa don ban--
--cập nhật hàng trong kho sau khi đặt hàng hoặc cập nhập
create trigger trg_dathang on tChiTietHDB after insert as 
begin
	update tSanPham set SoLuong = SoLuong -
	(select SLBan from inserted
	where MaSP = tSanPham.MaSP) from tSanPham
	join inserted on tSanPham.MaSP = inserted.MaSP
end
--cập nhật hàng trong kho sau khi hủy hàng
create trigger trg_huydathang on tChiTietHDB for delete as
begin
	update tSanPham set SoLuong = SoLuong +
	(select SLBan from deleted
	where MaSP = tSanPham.MaSP) from tSanPham
	join deleted on tSanPham.MaSP = deleted.MaSP
end
--cap nhat hàng trong kho sua khi cập nhật đặt hàng
create trigger trg_CapNhatDatHang on tChiTietHDB for update as
begin
	update tSanPham set SoLuong = SoLuong - 
	(select SoLuong from inserted where MaSP = tSanPham.MaSP) +
	(select SoLuong from deleted where MaSP = tSanPHam.MaSP)
	from tSanPHam join deleted on tSanPham.MaSP = deleted.MaSP
end

--cap nhat hoa don nhap--
--cập nhật hàng trong kho sau khi nhập hàng hoặc cập nhập
create trigger trg_nhaphang on tChiTietHDN after insert as 
begin
	update tSanPham set SoLuong = SoLuong +
	(select SLNhap from inserted
	where MaSP = tSanPham.MaSP) from tSanPham
	join inserted on tSanPham.MaSP = inserted.MaSP
end
--cập nhật hàng trong kho sau khi hủy nhập hàng
create trigger trg_huynhaphang on tChiTietHDN for delete as
begin
	update tSanPham set SoLuong = SoLuong -
	(select SLNhap from deleted
	where MaSP = tSanPham.MaSP) from tSanPham
	join deleted on tSanPham.MaSP = deleted.MaSP
end
--cap nhat hàng trong kho sua khi cập nhật nhập hàng
create trigger trg_CapNhatNhapHang on tChiTietHDN for update as
begin
	update tSanPham set SoLuong = SoLuong + 
	(select SoLuong from inserted where MaSP = tSanPham.MaSP) -
	(select SoLuong from deleted where MaSP = tSanPHam.MaSP)
	from tSanPHam join deleted on tSanPham.MaSP = deleted.MaSP
end

--thong ke doanh thu tung ngay
create function DoanhThuTheoThang(@thang int, @nam int) returns table
as return
(
select
isnull(sum(case day (NgayLap) when 1 then (SLBan*DonGiaBan - Khuyenmai*(SLBan*DonGiaBan)/100) end),0) as Ngay1,
isnull(sum(case day (NgayLap) when 2 then (SLBan*DonGiaBan - Khuyenmai*(SLBan*DonGiaBan)/100) end),0) as Ngay2,
isnull(sum(case day (NgayLap) when 3 then (SLBan*DonGiaBan - Khuyenmai*(SLBan*DonGiaBan)/100) end),0) as Ngay3,
isnull(sum(case day (NgayLap) when 4 then (SLBan*DonGiaBan - Khuyenmai*(SLBan*DonGiaBan)/100) end),0) as Ngay4,
isnull(sum(case day (NgayLap) when 5 then (SLBan*DonGiaBan - Khuyenmai*(SLBan*DonGiaBan)/100) end),0) as Ngay5,
isnull(sum(case day (NgayLap) when 6 then (SLBan*DonGiaBan - Khuyenmai*(SLBan*DonGiaBan)/100) end),0) as Ngay6,
isnull(sum(case day (NgayLap) when 7 then (SLBan*DonGiaBan - Khuyenmai*(SLBan*DonGiaBan)/100) end),0) as Ngay7,
isnull(sum(case day (NgayLap) when 8 then (SLBan*DonGiaBan - Khuyenmai*(SLBan*DonGiaBan)/100) end),0) as Ngay8,
isnull(sum(case day (NgayLap) when 9 then (SLBan*DonGiaBan - Khuyenmai*(SLBan*DonGiaBan)/100) end),0) as Ngay9,
isnull(sum(case day (NgayLap) when 10 then (SLBan*DonGiaBan - Khuyenmai*(SLBan*DonGiaBan)/100) end),0) as Ngay10,
isnull(sum(case day (NgayLap) when 11 then (SLBan*DonGiaBan - Khuyenmai*(SLBan*DonGiaBan)/100) end),0) as Ngay11,
isnull(sum(case day (NgayLap) when 12 then (SLBan*DonGiaBan - Khuyenmai*(SLBan*DonGiaBan)/100) end),0) as Ngay12,
isnull(sum(case day (NgayLap) when 13 then (SLBan*DonGiaBan - Khuyenmai*(SLBan*DonGiaBan)/100) end),0) as Ngay13,
isnull(sum(case day (NgayLap) when 14 then (SLBan*DonGiaBan - Khuyenmai*(SLBan*DonGiaBan)/100) end),0) as Ngay14,
isnull(sum(case day (NgayLap) when 15 then (SLBan*DonGiaBan - Khuyenmai*(SLBan*DonGiaBan)/100) end),0) as Ngay15,
isnull(sum(case day (NgayLap) when 16 then (SLBan*DonGiaBan - Khuyenmai*(SLBan*DonGiaBan)/100) end),0) as Ngay16,
isnull(sum(case day (NgayLap) when 17 then (SLBan*DonGiaBan - Khuyenmai*(SLBan*DonGiaBan)/100) end),0) as Ngay17,
isnull(sum(case day (NgayLap) when 18 then (SLBan*DonGiaBan - Khuyenmai*(SLBan*DonGiaBan)/100) end),0) as Ngay18,
isnull(sum(case day (NgayLap) when 19 then (SLBan*DonGiaBan - Khuyenmai*(SLBan*DonGiaBan)/100) end),0) as Ngay19,
isnull(sum(case day (NgayLap) when 20 then (SLBan*DonGiaBan - Khuyenmai*(SLBan*DonGiaBan)/100) end),0) as Ngay20,
isnull(sum(case day (NgayLap) when 21 then (SLBan*DonGiaBan - Khuyenmai*(SLBan*DonGiaBan)/100) end),0) as Ngay21,
isnull(sum(case day (NgayLap) when 22 then (SLBan*DonGiaBan - Khuyenmai*(SLBan*DonGiaBan)/100) end),0) as Ngay22,
isnull(sum(case day (NgayLap) when 23 then (SLBan*DonGiaBan - Khuyenmai*(SLBan*DonGiaBan)/100) end),0) as Ngay23,
isnull(sum(case day (NgayLap) when 24 then (SLBan*DonGiaBan - Khuyenmai*(SLBan*DonGiaBan)/100) end),0) as Ngay24,
isnull(sum(case day (NgayLap) when 25 then (SLBan*DonGiaBan - Khuyenmai*(SLBan*DonGiaBan)/100) end),0) as Ngay25,
isnull(sum(case day (NgayLap) when 26 then (SLBan*DonGiaBan - Khuyenmai*(SLBan*DonGiaBan)/100) end),0) as Ngay26,
isnull(sum(case day (NgayLap) when 27 then (SLBan*DonGiaBan - Khuyenmai*(SLBan*DonGiaBan)/100) end),0) as Ngay27,
isnull(sum(case day (NgayLap) when 28 then (SLBan*DonGiaBan - Khuyenmai*(SLBan*DonGiaBan)/100) end),0) as Ngay28,
isnull(sum(case day (NgayLap) when 29 then (SLBan*DonGiaBan - Khuyenmai*(SLBan*DonGiaBan)/100) end),0) as Ngay29,
isnull(sum(case day (NgayLap) when 30 then (SLBan*DonGiaBan - Khuyenmai*(SLBan*DonGiaBan)/100) end),0) as Ngay30,
isnull(sum(case day (NgayLap) when 31 then (SLBan*DonGiaBan - Khuyenmai*(SLBan*DonGiaBan)/100) end),0) as Ngay31
from tChiTietHDB ct
	join tHoaDonBan hdb on ct.SoHDB = hdb.SoHDB 
	join tSanPham s on ct.MaSP = s.MaSP
where month(hdb.NgayLap) = @thang and YEAR(hdb.NgayLap) = @nam
)
select * from dbo.DoanhThuTheoThang(11, 2022)
--thong ke doanh thu tung thang
create function DoanhThuTheoNam(@nam int) returns table
as return
(
select
isnull(sum(case month (NgayLap) when 1 then (SLBan*DonGiaBan - Khuyenmai*(SLBan*DonGiaBan)/100) end),0) as Thang1,
isnull(sum(case month (NgayLap) when 2 then (SLBan*DonGiaBan - Khuyenmai*(SLBan*DonGiaBan)/100) end),0) as Thang2,
isnull(sum(case month (NgayLap) when 3 then (SLBan*DonGiaBan - Khuyenmai*(SLBan*DonGiaBan)/100) end),0) as Thang3,
isnull(sum(case month (NgayLap) when 4 then (SLBan*DonGiaBan - Khuyenmai*(SLBan*DonGiaBan)/100) end),0) as Thang4,
isnull(sum(case month (NgayLap) when 5 then (SLBan*DonGiaBan - Khuyenmai*(SLBan*DonGiaBan)/100) end),0) as Thang5,
isnull(sum(case month (NgayLap) when 6 then (SLBan*DonGiaBan - Khuyenmai*(SLBan*DonGiaBan)/100) end),0) as Thang6,
isnull(sum(case month (NgayLap) when 7 then (SLBan*DonGiaBan - Khuyenmai*(SLBan*DonGiaBan)/100) end),0) as Thang7,
isnull(sum(case month (NgayLap) when 8 then (SLBan*DonGiaBan - Khuyenmai*(SLBan*DonGiaBan)/100) end),0) as Thang8,
isnull(sum(case month (NgayLap) when 9 then (SLBan*DonGiaBan - Khuyenmai*(SLBan*DonGiaBan)/100) end),0) as Thang9,
isnull(sum(case month (NgayLap) when 10 then (SLBan*DonGiaBan - Khuyenmai*(SLBan*DonGiaBan)/100) end),0) as Thang10,
isnull(sum(case month (NgayLap) when 11 then (SLBan*DonGiaBan - Khuyenmai*(SLBan*DonGiaBan)/100) end),0) as Thang11,
isnull(sum(case month (NgayLap) when 12 then (SLBan*DonGiaBan - Khuyenmai*(SLBan*DonGiaBan)/100) end),0) as Thang12
from tChiTietHDB ct
	join tHoaDonBan hdb on ct.SoHDB = hdb.SoHDB 
	join tSanPham s on ct.MaSP = s.MaSP
where year(hdb.NgayLap) = @nam
)
select * from dbo.DoanhThuTheoNam(2022)
--thong ke doanh thu tung quy
create function DoanhThuTheoTungQuy(@nam int) returns table
as return
(
select
isnull(sum(case month (NgayLap) when 1 then (SLBan*DonGiaBan - Khuyenmai*(SLBan*DonGiaBan)/100) end),0) + 
isnull(sum(case month (NgayLap) when 2 then (SLBan*DonGiaBan - Khuyenmai*(SLBan*DonGiaBan)/100) end),0) +
isnull(sum(case month (NgayLap) when 3 then (SLBan*DonGiaBan - Khuyenmai*(SLBan*DonGiaBan)/100) end),0) as Quy1,
isnull(sum(case month (NgayLap) when 4 then (SLBan*DonGiaBan - Khuyenmai*(SLBan*DonGiaBan)/100) end),0) +
isnull(sum(case month (NgayLap) when 5 then (SLBan*DonGiaBan - Khuyenmai*(SLBan*DonGiaBan)/100) end),0) +
isnull(sum(case month (NgayLap) when 6 then (SLBan*DonGiaBan - Khuyenmai*(SLBan*DonGiaBan)/100) end),0) as Quy2,
isnull(sum(case month (NgayLap) when 7 then (SLBan*DonGiaBan - Khuyenmai*(SLBan*DonGiaBan)/100) end),0) +
isnull(sum(case month (NgayLap) when 8 then (SLBan*DonGiaBan - Khuyenmai*(SLBan*DonGiaBan)/100) end),0) +
isnull(sum(case month (NgayLap) when 9 then (SLBan*DonGiaBan - Khuyenmai*(SLBan*DonGiaBan)/100) end),0) as Quy3,
isnull(sum(case month (NgayLap) when 10 then (SLBan*DonGiaBan - Khuyenmai*(SLBan*DonGiaBan)/100) end),0) +
isnull(sum(case month (NgayLap) when 11 then (SLBan*DonGiaBan - Khuyenmai*(SLBan*DonGiaBan)/100) end),0) +
isnull(sum(case month (NgayLap) when 12 then (SLBan*DonGiaBan - Khuyenmai*(SLBan*DonGiaBan)/100) end),0) as Quy4
from tChiTietHDB ct
	join tHoaDonBan hdb on ct.SoHDB = hdb.SoHDB 
	join tSanPham s on ct.MaSP = s.MaSP
where year(hdb.NgayLap) = @nam
)
--select * from dbo.DoanhThuTheoTungQuy()

--thong ke theo mat hang
create function MatHangBanRa(@ngaydau date , @ngaycuoi date) returns table
as return (
select TenSP,sum(SLBan) as SoLuongBan from tChiTietHDB,tHoaDonBan,tSanPham
	where tChiTietHDB.SoHDB = tHoaDonBan.SoHDB and
	tChiTietHDB.MaSP = tSanPham.MaSP and
	NgayLap between @ngaydau and @ngaycuoi	
	group by TenSP	
)
--select * from dbo.MatHangBanRa('2022/1/2','2022/11/12')
--order by SoLuongBan desc
--thống kê doanh thu từng mặt hàng
create function DoanhThuTungMatHang(@ngaydau date , @ngaycuoi date) returns table
as return (
	select TenSP, sum(SLBan*DonGiaBan - Khuyenmai*(SLBan*DonGiaBan)/100) as DoanhThu from tChiTietHDB,tHoaDonBan,tSanPham
	where tChiTietHDB.SoHDB = tHoaDonBan.SoHDB and
	tChiTietHDB.MaSP = tSanPham.MaSP and
	NgayLap between @ngaydau and @ngaycuoi
	group by TenSP
)
--select * from dbo.DoanhThuTungMatHang('2022/4/2','2022/11/9')

create function BaoCaoDoanhThuThang(@thang int , @nam int) returns table
as return (
select tSanPham.MaSP as MaSP,count(distinct tHoaDonBan.SoHDB) as SoLuongBan ,(sum(SLBan*DonGiaBan)) as TienHang,sum(Khuyenmai*(SLBan*DonGiaBan)/100) as Khuyenmai,sum(SLBan*DonGiaBan - Khuyenmai*(SLBan*DonGiaBan)/100) as DoanhThu
from tKhachHang,tHoaDonBan,tChiTietHDB,tSanPham
	where tChiTietHDB.SoHDB = tHoaDonBan.SoHDB and
	tChiTietHDB.MaSP = tSanPham.MaSP and
	tHoaDonBan.MaKH = tKhachHang.MaKH and
	month(NgayLap) = @thang and year(NgayLap) = @nam
	group by tSanPham.MaSP
)
select * from dbo.BaoCaoDoanhThuThang('11','2022')

create function dbo.BaoCaoDoanhThuNam(@nam int) returns table
as return (
select tSanPham.MaSP as MaSP,count(distinct tHoaDonBan.SoHDB) as SoLuongBan ,sum(SLBan*DonGiaBan) as TienHang,sum(Khuyenmai*(SLBan*DonGiaBan)/100) as Khuyenmai,sum(SLBan*DonGiaBan - Khuyenmai*(SLBan*DonGiaBan)/100) as DoanhThu
from tKhachHang,tHoaDonBan,tChiTietHDB,tSanPham
	where tChiTietHDB.SoHDB = tHoaDonBan.SoHDB and
	tChiTietHDB.MaSP = tSanPham.MaSP and
	tHoaDonBan.MaKH = tKhachHang.MaKH and
	year(NgayLap) = @nam
	group by tSanPham.MaSP
)
select * from dbo.BaoCaoDoanhThuNam('2022')
