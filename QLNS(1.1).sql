﻿create database QLNhaSach
go
use QLNhaSach
--drop database QLNhaSach
go
SET DATEFORMAT dmy;
--Tạo bảng chi nhánh
create table ChiNhanh(
maCN varchar(10) not null,
tenCN nvarchar(50) not null,
diaChi nvarchar(150) not null,
soDienThoai varchar(12) not null,
email varchar(50) not null,
ghiChu nvarchar(150) null,
primary key(maCN))
go
--Tạo bảng loại hàng hóa
create table LoaiHangHoa (
maLHH varchar(5) not null,
tenLHH nvarchar (45) not null,
ghiChu nvarchar(150) not null,
primary key (maLHH)
)
go
--Tao bang chuc vu
create table ChucVu(
maChucVu INT IDENTITY(1,1) primary key ,
tenChucVu nvarchar(20) not null)
go
--Tạo bảng nhà phân phối
create table NhaPhanPhoi(
maNPP varchar(11) primary key,
tenNPP nvarchar(50) not null,
diachiNPP nvarchar(100) not null,
sdtNPP varchar(12) not null,
emailNPP varchar(50) not null,
)
go
--Khách hàng
create table KhachHang(
maKH varchar(11) primary key ,
hoTenKH nvarchar(50) not null,
ngaysinhKH datetime null,
gioitinhKH nvarchar(3) not null,
diachiKH nvarchar(50) not null,
sdtKH varchar(12) not null,
emailKH varchar(50) null, )
go
-- Địa chỉ khách hàng
create table DiaChiKhachHang(
madiachiKH varchar(11) primary key,
maKH varchar(11) foreign key references KhachHang(maKH),
diachiKH nvarchar(100) not null,
)
go
--Tạo bảng sản phẩm
create table HangHoa (
maHH varchar(13) not null,
maLHH varchar(5) foreign key references LoaiHangHoa(maLHH) ,
tenHH nvarchar(45) not null,
giaHH int not null,
donViTinh nvarchar(15) not null,
soLuongTon int not null,
maNPP varchar(11) foreign key references NhaPhanPhoi(maNPP),
tacGia nvarchar(45) null,
hanSD int null,
--ngayNhap datetime not null,
--ngayHetHan datetime not null,
moTa nvarchar(150) not null,
ghiChu nvarchar(150) not null,
tinhTrang nvarchar(15) not null,
primary key (maHH)
)
go

--Tao bang chi tiet nhập hàng
create table NhapHang(
maNH varchar(11) primary key,
ngayNH DateTime not null,
maNPP varchar(11) foreign key references NhaPhanPhoi(maNPP))
go
--Tao bang chi tiet nhập hàng
create table ChTietNhapHang(
maCTNCC INT IDENTITY(1,1) ,
maNH varchar(11) foreign key references NhapHang(maNH),
maHH varchar(13) foreign key references HangHoa(maHH),
soLuong int ,
ghiChu nvarchar(200),
constraint PK_CTNCC primary key(maCTNCC,maHH))
go
--Tạo bảng Khuyến Mãi
create table KhuyenMai(
maKM varchar(25) primary key,
tenKM nvarchar(50) not null,
giamGia int null,
maHH varchar(13) foreign key references HangHoa(maHH) null,
ngayBD dateTime not null,
ngayKT dateTime not null,
ghiChu nvarchar(100)  null ,
--maHH varchar(13)  --Qua tang kem )
)
go
--Tao bang chi tiet khuyen mai
create table CTKhuyenMai(
maCTKM INT IDENTITY(1,1),
maHH varchar(13) foreign key references HangHoa(maHH) ,
maKM varchar(25) foreign key references KhuyenMai(maKM),
constraint PK_CTKM primary key(maHH,maKM,maCTKM))
--Tao bang nhan vien
create table NhanSu (
	maNS varchar(7) primary key,
	tenNS nvarchar(45) not null,
	gioiTinh nvarchar(3) not null,
	cccdNS nvarchar(11) not null,
	sdtNV varchar(10) not null,
	emailNV varchar(40) not null,
	diaChiNha nvarchar(55),
	maCN varchar(10) foreign key references ChiNhanh(maCN),
	chucVu INT  foreign key references ChucVu(maChucVu) ,
	luongcanban varchar(30),
	matkhau nvarchar(25) not null,
)
go
--Tao bang Hoa Don
create table HoaDon(
maHD varchar(10) not null,
maNS varchar (7) foreign key references NhanSu(maNS),
maKH varchar(11) foreign key references KhachHang(maKH),
tongTien float,
ngayIn date not null,
ghiChu nvarchar(150) null,
primary key (maHD))
go
--Tao bang chi tiet hoa don
create table CTHoaDon(
maCTHD INT IDENTITY(1,1) ,
maHD varchar(10) foreign key references HoaDon(maHD),
maHH varchar(13)  foreign key references HangHoa(maHH) ,
SL int,
DonGia int,
constraint PK_CTHD primary key (maHD,maHH,maCTHD))

--Tao bảng ca trực
create table CaTruc(
maCT INT IDENTITY(1,1) primary key ,
maCN varchar(10) foreign key references ChiNhanh(maCN),
tenCaTruc nvarchar(30) not null ,
gioBD Time ,
gioKT Time ,
ghiChu nvarchar(150) null,)
--Tao bảng chi tiết ca trực
create table ChiTietCaTruc(
maCTCT INT IDENTITY(1,1) primary key ,
maCT INT foreign key references CaTruc(maCT),
maNS varchar(7) foreign key references NhanSu(maNS), )
go
--Tinh luong
create table BangTinhLuong(
maBangLuong varchar(30) primary key,
maNS varchar (7) foreign key references NhanSu(maNS),
ngayBD dateTime not null,
ngayKT dateTime not null,)
go
create table ChiTietLuong(
maCTLuong int IDENTITY(1,1) primary key,
maBangLuong varchar(30) foreign key references BangTinhLuong(maBangLuong),
luongCB varchar(30),
maNS varchar (7) foreign key references NhanSu(maNS),
ngayTC int ,	
ngayNghi int ,
soNgayLam int not null,
tienLuong int not null,
)
go

