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
	Constraint [PK_tHangSanXuat] PRIMARY KEY CLUSTERED
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
Create Table tSanPham
(
	MaSP Nvarchar(10) not null,
	TenSP Nvarchar(20) not null,
	MaTH nvarchar(30),
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
ALTER TABLE [tSanPham]  WITH CHECK ADD  CONSTRAINT [FK_tSanPham_tHangSanXuat] FOREIGN KEY([MaTH])
REFERENCES [tThuongHieu] ([MaTH])

insert tThuongHieu values(N'TH001', 'Sonny')
insert tThuongHieu values(N'TH002', 'SamSung')
select * from tThuongHieu

insert tSanPham values(N'SP002', 'SamSung oled', 'TH002', '32 inch', 'oled',9 , 32432, 3432243, 'df.png','ol')
	insert tSanPham values(N'SP003', 'sony oled', 'TH001', '39 inch', 'oled',6, 4000000, 9000000, 'd.png','ol')
	insert tSanPham values(N'SP004', 'sony ofd', 'TH001', '56 inch', 'OLED',4, 5000000, 9000000, 'h.png','ol')
insert tSanPham values(N'SP005', 'sony ffd', 'TH001', '48 inch', 'oled', 7, 6000000, 9000000, 'h.png','ol')

select * from tSanPham

insert tNhanVien values('nv003', 'vu truong phuoc', '2013-4-5', '0123456789', 'hai duong','q','222', 1)
insert tNhanVien values('nv002', 'vuong kien quoc', '2015-6-5', '0987654321', 'ha noi','p','123', 0)
select * from tNhanVien


insert tHoaDonBan values('HDB001','nv002', 'KH002', '2022-10-14', 5000000)
insert tHoaDonBan values('HDB002','nv002', 'KH003', '2022-10-13', 9000000)
select * from tHoaDonBan

insert tKhachHang values('KH003', 'cao ba sung', 'Nữ', '0929292939', 'ha nội')
insert tKhachHang values('KH002', 'cao ba quat', 'Nam', '0929292929', 'ha thanh')
insert tKhachHang values('KH001', 'nguyen thi cao', 'Nữ', '0939292929', 'tp hcm')

insert tChiTietHDB values('HDB001','sp002', '3', null)
insert tChiTietHDB values('HDB001','sp003', '1', null)

select tSanPham.MaSP, TenSP,SLBan, DonGiaBan,sum(SoLuong*DonGiaBan) as TongTien from tChiTietHDB,tSanPham 
	where tSanPham.MaSP = tChiTietHDB.MaSP 
	group by tSanPham.MaSP, TenSP,SLBan, DonGiaBan

select * from tChiTietHDB
select * from tHoaDonBan

delete tChiTietHDB where SoHDB = 'hdb145' and MaSP = 'sp002'

delete tHoaDonBan where SoHDB = 'hdb144'

select tSanPham.MaSP, TenSP,SLBan, DonGiaBan,SLBan*DonGiaBan -Khuyenmai*(SLBan*DonGiaBan)/100 as TongTien from tChiTietHDB,tSanPham 
                where tSanPham.MaSP = tChiTietHDB.MaSP and SoHDB = 'HDB96'
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
select * from tHoaDonBan 