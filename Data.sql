CREATE DATABASE QUAN_LY_KHACH_SAN
GO

USE QUAN_LY_KHACH_SAN
GO
--Phòng--
CREATE TABLE LOAI_PHONG
(
 MaLoaiPhong INT NOT NULL PRIMARY KEY,
 TenLoaiPhong NVARCHAR(50) NOT NULL DEFAULT N'CHUA DAT TEN',
 DonGia MONEY  
)
GO

CREATE TABLE TINH_TRANG_PHONG
(
 MaTinhTrang INT NOT NULL PRIMARY KEY,
 TenTinhTrang NVARCHAR(50) DEFAULT N'CO THE THUE',
)
GO


CREATE TABLE PHONG
(
MaPhong INT NOT NULL PRIMARY KEY,
TenPhong NVARCHAR(50) NOT NULL DEFAULT N'CHUA DAT TEN',
MaLoaiPhong INT NOT NULL,
GhiChu NVARCHAR(100),
TinhTrangPhong INT NOT NULL DEFAULT 1,-- 1 có thể thuê , 0 đã được thuê.

 FOREIGN KEY (MaLoaiPhong) REFERENCES LOAI_PHONG(MaLoaiPhong),
 FOREIGN KEY (TinhTrangPhong) REFERENCES TINH_TRANG_PHONG(MaTinhTrang) 
)
GO

INSERT INTO dbo.TINH_TRANG_PHONG( MaTinhTrang, TenTinhTrang ) VALUES(1, N'Có thể cho thuê ')
INSERT INTO dbo.TINH_TRANG_PHONG( MaTinhTrang, TenTinhTrang ) VALUES(2, N'Đang cho thuê ')
INSERT INTO dbo.TINH_TRANG_PHONG( MaTinhTrang, TenTinhTrang ) VALUES(3, N'Đang sửa chữa ')
GO
INSERT INTO dbo.LOAI_PHONG ( MaLoaiPhong, TenLoaiPhong, DonGia )VALUES(1,'A', 150000)
INSERT INTO dbo.LOAI_PHONG ( MaLoaiPhong, TenLoaiPhong, DonGia )VALUES(2,'B', 170000)
INSERT INTO dbo.LOAI_PHONG ( MaLoaiPhong, TenLoaiPhong, DonGia )VALUES(3,'C', 200000)
GO

INSERT INTO dbo.PHONG( MaPhong,TenPhong,MaLoaiPhong,GhiChu,TinhTrangPhong)VALUES(1, N'Phòng 1', 1, N'note 1', 1)
INSERT INTO dbo.PHONG( MaPhong,TenPhong,MaLoaiPhong,GhiChu,TinhTrangPhong)VALUES(2, N'Phòng 2', 2, N'note 2', 2)
INSERT INTO dbo.PHONG( MaPhong,TenPhong,MaLoaiPhong,GhiChu,TinhTrangPhong)VALUES(3, N'Phòng 3', 3, N'note 3', 3)
INSERT INTO dbo.PHONG( MaPhong,TenPhong,MaLoaiPhong,GhiChu,TinhTrangPhong)VALUES(4, N'Phòng 4', 1, N'note 4', 1)
INSERT INTO dbo.PHONG( MaPhong,TenPhong,MaLoaiPhong,GhiChu,TinhTrangPhong)VALUES(5, N'Phòng 5', 2, N'note 4', 2)
GO





--Báo cáo doanh thu
CREATE TABLE BAO_CAO_DOANH_THU
(
  Thang	INT NOT NULL,
  Nam INT NOT NULL,
  TongDoanhThu MONEY,
  PRIMARY KEY(Thang, Nam)
 ) 
GO

CREATE TABLE CHI_TIET_BAO_CAO_DOANH_THU
(
  Thang INT NOT NULL,
  Nam INT NOT NULL,
  MaLoaiPhong INT NOT NULL,
  PRIMARY KEY(Thang, Nam, MaLoaiPhong),

  DoanhThu MONEY DEFAULT 0,
  TyLe FLOAT,
  FOREIGN KEY (Thang,Nam) REFERENCES BAO_CAO_DOANH_THU(Thang,Nam),
  FOREIGN KEY (MaLoaiPhong) REFERENCES LOAI_PHONG(MaLoaiPhong),
 )
GO





--Phiếu thuê phòng
CREATE TABLE LOAI_KHACH_HANG 
(
	MaLoaiKhachHang INT NOT NULL PRIMARY KEY,
	TenLoaiKhachHang NVARCHAR(30) NOT NULL DEFAULT N'chua dat ten',
)
GO
 CREATE TABLE HINH_THUC_THUE
 (
	MaHinhThucThue INT IDENTITY NOT NULL PRIMARY KEY,
	TenHinhThucThue NVARCHAR(40) NOT NULL,
	SoGio INT NOT NULL,
	TyLeDonGia FLOAT NOT NULL
)
GO
CREATE TABLE PHIEU_THUE_PHONG 
(
	MaPhieuThue INT identity NOT NULL PRIMARY KEY,
	MaPhong INT NOT NULL,
	MaHinhThucThue INT ,
	NgayGioBatDauThue DATETIME NOT NULL,
	SoKhach INT,
	TinhTrangThanhToan INT DEFAULT 0, -- 0: Chưa Thanh Toán || 1: Đã Thanh Toán

	FOREIGN KEY (MaPhong) REFERENCES dbo.PHONG(MaPhong),
	FOREIGN KEY (MaHinhThucThue) REFERENCES dbo.HINH_THUC_THUE(MaHinhThucThue)
)
GO
CREATE TABLE CHI_TIET_PHIEU_THUE 
(
	MaPhieuThue INT NOT NULL,
	TenKhachHang NVARCHAR(50) NOT NULL DEFAULT N'chua dat ten',
	MaLoaiKhachHang INT NOT NULL,
	CMND INT,
	DiaChi NVARCHAR(100) DEFAULT N'chua them dia chi',

	PRIMARY KEY (MaPhieuThue, TenKhachHang),
	FOREIGN KEY (MaPhieuThue) REFERENCES dbo.PHIEU_THUE_PHONG(MaPhieuThue),
	FOREIGN KEY (MaLoaiKhachHang) REFERENCES dbo.LOAI_KHACH_HANG(MaLoaiKhachHang)
)
GO

CREATE TABLE DICH_VU
(
	MaDichVu INT IDENTITY PRIMARY KEY,
	TenDichVu NVARCHAR(50),
	DonGia MONEY
)
GO
CREATE TABLE CHI_TIET_SU_DUNG_DICH_VU(
	MaPhieuThue INT NOT NULL,
	MaDichVu INT NOT NULL,
	KhachHangSuDung NVARCHAR(50) NOT NULL,
	NgayGioSuDung DATETIME DEFAULT GETDATE(),
	SoLuong INT,
	ThanhTien MONEY DEFAULT(0),

	PRIMARY KEY(MaPhieuThue, MaDichVu, KhachHangSuDung, NgayGioSuDung),
	FOREIGN KEY (MaPhieuThue) REFERENCES dbo.PHIEU_THUE_PHONG(MaPhieuThue),
	FOREIGN KEY (MaDichVu) REFERENCES dbo.DICH_VU(MaDichVu),
)
GO
INSERT INTO dbo.LOAI_KHACHHANG( MaLoaiKhachHang ,TenLoaiKhachHang)VALUES  ( 1, N'Nội địa' )
INSERT INTO dbo.LOAI_KHACHHANG( MaLoaiKhachHang ,TenLoaiKhachHang)VALUES  ( 2, N'Nước ngoài' )
GO


--Hoá đơn--
CREATE TABLE HOA_DON (
	MaHoaDon INT identity NOT NULL PRIMARY KEY,
	TenKhachHang NVARCHAR(50) DEFAULT N'chua ghi ten',
	NgayGioThanhToan DATETIME NOT NULL DEFAULT GETDATE(),
	TongTien MONEY DEFAULT(0),
)
GO

CREATE TABLE CHI_TIET_HOA_DON 
(
	MaHoaDon INT NOT NULL,
	MaPhieuThue INT NOT NULL,
	SoLuongThue INT,
	DonGia MONEY,
	TongTienThuePhong MONEY,
	TongTienDichVu MONEY,
	ThanhTien MONEY ,

	PRIMARY KEY (MaHoaDon, MaPhieuThue),
	FOREIGN KEY (MaHoaDon) REFERENCES dbo.HOA_DON(MaHoaDon),
	FOREIGN KEY (MaPhieuThue) REFERENCES dbo.PHIEU_THUE_PHONG(MaPhieuThue)
)
GO

CREATE TABLE THAMSO (
	TenThamSo NVARCHAR(30) NOT NULL PRIMARY KEY,
	GiaTri FLOAT NOT NULL
	--Các Record THAMSO(TenThamSo, GiaTri)

	----KhachToiDa					:	3
	----SoKhachKhongTinhPhuThu		:	2
	----TyLePhuThu					:	0.25
	----HeSoPhuThu					:	1.5
	----LuongCoBan					:	5000000
)
GO
INSERT INTO dbo.THAMSO( TenThamSo, GiaTri ) VALUES  ( 'KhachToiDa', 3)
INSERT INTO dbo.THAMSO( TenThamSo, GiaTri ) VALUES  ( 'SoKhachKhongTinhPhuThu', 2)
INSERT INTO dbo.THAMSO( TenThamSo, GiaTri ) VALUES  ( 'TyLePhuThu', 0.25)
INSERT INTO dbo.THAMSO( TenThamSo, GiaTri ) VALUES  ( 'HeSoPhuThu', 1.5 )
INSERT INTO dbo.THAMSO( TenThamSo, GiaTri ) VALUES  ( 'LuongCoBan', 5000000 )
GO

CREATE TABLE NHOM_NGUOI_DUNG (
	 MaNhom int not null primary key,
	 TenNhom NVARCHAR(30) not null,	
)
GO
insert into dbo.NHOM_NGUOI_DUNG(MaNhom,TenNhom) values(1,N'Admin')
insert into dbo.NHOM_NGUOI_DUNG(MaNhom,TenNhom) values(2,N'staff')

CREATE TABLE CHUC_NANG (
	MaChucNang int identity not null primary key,
	TenChucNang NVARCHAR(30) not null,
	TenManHinhDuocLoad NVARCHAR(30) not null
)
GO

insert into dbo.CHUC_NANG(TenChucNang,TenManHinhDuocLoad) values(N'Phòng',N'fRoom')
insert into dbo.CHUC_NANG(TenChucNang,TenManHinhDuocLoad) values(N'Tìm phòng',N'fSearch')
insert into dbo.CHUC_NANG(TenChucNang,TenManHinhDuocLoad) values(N'Thêm phòng',N'fAddRoom')
insert into dbo.CHUC_NANG(TenChucNang,TenManHinhDuocLoad) values(N'Xóa phòng',N'fDeleteRoom')
insert into dbo.CHUC_NANG(TenChucNang,TenManHinhDuocLoad) values(N'Sửa phòng',N'fEditRoom')
insert into dbo.CHUC_NANG(TenChucNang,TenManHinhDuocLoad) values(N'Thuê phòng',N'fRent')
insert into dbo.CHUC_NANG(TenChucNang,TenManHinhDuocLoad) values(N'Thanh toán',N'fPayInfo')
insert into dbo.CHUC_NANG(TenChucNang,TenManHinhDuocLoad) values(N'Dịch vụ',N'fService')
insert into dbo.CHUC_NANG(TenChucNang,TenManHinhDuocLoad) values(N'Thống kê',N'fReport')
insert into dbo.CHUC_NANG(TenChucNang,TenManHinhDuocLoad) values(N'Thay đổi quy định',N'fChangeRegulations')
insert into dbo.CHUC_NANG(TenChucNang,TenManHinhDuocLoad) values(N'Nhân viên',N'fStaff')
--insert into dbo.CHUC_NANG(TenChucNang,TenManHinhDuocLoad) values(N'Về chúng tôi',N'AboutUs')
--insert into dbo.CHUC_NANG(TenChucNang,TenManHinhDuocLoad) values(N'Quản lý tài khoản',N'fAccountManagement')


CREATE TABLE PHAN_QUYEN (
	MaNhom int not null ,
	MaChucNang int not null,
	PRIMARY KEY (MaNhom,MaChucNang),
	FOREIGN KEY (MaNhom) REFERENCES dbo.NHOM_NGUOI_DUNG(MaNhom),
	FOREIGN KEY (MaChucNang) REFERENCES dbo.CHUC_NANG(MaChucNang)
)
GO

insert into dbo.NHOM_NGUOI_DUNG(MaNhom,TenNhom) values(1,N'Admin')
insert into dbo.NHOM_NGUOI_DUNG(MaNhom,TenNhom) values(2,N'staff')
GO

CREATE TABLE NGUOI_DUNG(
	TenDangNhap NVARCHAR(30) not null primary key,
	MatKhau NVARCHAR(30) not null,
	MaNhom int not null,
	FOREIGN KEY (MaNhom) REFERENCES dbo.NHOM_NGUOI_DUNG(MaNhom)
)
GO
--Thêm 1 tài khoản admin và 1 tài khoản staff
insert into dbo.NGUOI_DUNG(TenDangNhap,MatKhau,MaNhom) values('admin','admin',1)
insert into dbo.NGUOI_DUNG(TenDangNhap,MatKhau,MaNhom) values('staff1','staff1',2)
GO 


