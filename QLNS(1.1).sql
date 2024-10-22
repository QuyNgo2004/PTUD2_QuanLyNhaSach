create database QLNhaSach
go
use QLNhaSach
--drop database QLNhaSach
go
SET DATEFORMAT dmy;
--Tạo bảng chi nhánh
create table ChiNhanh(
maCN varchar(10) not null,
tenCN varchar(50) not null,
diaChi nvarchar(150) not null,
soDienThoai varchar(12) not null,
email varchar(50) not null,
ghiChi nvarchar(150) null,
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
hanSD int null,
--ngayNhap datetime not null,
--ngayHetHan datetime not null,
moTa nvarchar(150) not null,
ghiChu nvarchar(150) not null,
tinhTrang nvarchar(15) not null,
primary key (maHH)
)
go
--Tao bang chi tiet nha cung cap
create table NhaCCCT(
maCTNCC INT IDENTITY(1,1) ,
maHH varchar(13) foreign key references HangHoa(maHH),
ngayCC datetime,
soLuong int ,
ghiChu nvarchar(200),
constraint PK_CTNCC primary key(maCTNCC,maHH))
go
--Tạo bảng Khuyến Mãi
create table KhuyenMai(
maKM varchar(20) primary key,
tenKM nvarchar(50),
giamGia int null,
--maHH varchar(13)  --Qua tang kem )
)
--Tao bang chi tiet khuyen mai
create table CTKhuyenMai(
maCTKM INT IDENTITY(1,1),
maHH varchar(13) foreign key references HangHoa(maHH) ,
maKM varchar(20) foreign key references KhuyenMai(maKM),
ngayBD dateTime,
ngayKT dateTime,
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
	chucVu nvarchar(25) not null,
	matkhau nvarchar(25) not null,
)
go
--Tao bang Hoa Don
create table HoaDon(
maHD varchar(10) not null,
maNS varchar (7) foreign key references NhanSu(maNS),
maCN varchar(10) foreign key references ChiNhanh(maCN),
maKH varchar(11) foreign key references KhachHang(maKH),
donGia float,
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
constraint PK_CTHD primary key (maHD,maHH,maCTHD))

-----Chen du lieu cho cac bang.

insert into KhachHang(maKH, hoTenKH, ngaysinhKH, gioitinhKH, diachiKH, sdtKH, emailKH)
values  
    ('KH01', N'Hoàng Văn Duy', '15/07/2005', N'Nam', N'18 Thành Mỹ Lợi, Thủ Đức, TP HCM', '0123467868', 'hoangduy@gmail.com'),
    ('KH02', N'Nguyễn Hoàng Nam', '12/03/2002', N'Nam', N'123 Nguyễn Văn Bứa, Bình Chánh, TP HCM', '0123456789', 'namnguyen@gmail.com'),
    ('KH03', N'Phạm Minh Khôi', '25/11/1998', N'Nam', N'456 Phú Mỹ Hưng, Quận 7, TP HCM', '0123567890', 'minhkhoi@gmail.com'),
    ('KH04', N'Nguyễn Thị Hoa', '05/06/2001', N'Nữ', N'789 Lê Quý Đôn, Quận 3, TP HCM', '0123678901', 'hoanguyen@gmail.com'),
    ('KH05', N'Đặng Thế Huy', '30/09/1995', N'Nam', N'321 Nguyễn Thái Bình, Quận 1, TP HCM', '0123789012', 'thehuy@gmail.com'),
    ('KH06', N'Nguyễn Hương Giang', '20/04/1999', N'Nữ', N'654 Trần Hưng Đạo, Quận 5, TP HCM', '0123890123', 'huonggiang@gmail.com'),
    ('KH07', N'Ngô Minh Tuấn', '15/12/2003', N'Nam', N'987 Trần Nhân Tôn, Quận 10, TP HCM', '0123901234', 'minhtuan@gmail.com'),
    ('KH08', N'Nguyễn Thị Hằng', '11/08/2000', N'Nữ', N'123 Tôn Thất Thuyết, Quận 4, TP HCM', '0124012345', 'thihang@gmail.com'),
    ('KH09', N'Nguyễn Văn Tâm', '22/05/1996', N'Nam', N'456 Đường Lê Lợi, Quận 1, TP HCM', '0124123456', 'vantam@gmail.com'),
    ('KH10', N'Phan Thị Ngọc', '02/01/2004', N'Nữ', N'789 Đường Bạch Đằng, Bình Thạnh, TP HCM', '0124234567', 'thinhoc@gmail.com'),
    ('KH11', N'Nguyễn Đình Sơn', '28/02/1997', N'Nam', N'321 Đường Nguyễn Tất Thành, Quận 4, TP HCM', '0124345678', 'dinhson@gmail.com'),
    ('KH12', N'Trần Hoàng Yến', '19/07/2002', N'Nữ', N'654 Lê Văn Sỹ, Phú Nhuận, TP HCM', '0124456789', 'hoangyen@gmail.com'),
    ('KH13', N'Nguyễn Văn An', '09/09/2000', N'Nam', N'789 Lê Hồng Phong, Quận 10, TP HCM', '0124567890', 'vanan@gmail.com'),
    ('KH14', N'Vũ Thị Mai', '30/06/1998', N'Nữ', N'321 Trường Chinh, Tân Bình, TP HCM', '0124678901', 'thimai@gmail.com'),
    ('KH15', N'Nguyễn Tiến Dũng', '15/04/1995', N'Nam', N'654 Nguyễn Văn Cừ, Quận 5, TP HCM', '0124789012', 'tiendung@gmail.com'),
    ('KH16', N'Phạm Thị Lành', '10/03/2003', N'Nữ', N'987 Lê Thị Hồng Gấm, Quận 1, TP HCM', '0124890123', 'thilanh@gmail.com'),
    ('KH17', N'Đỗ Minh Trí', '07/10/2001', N'Nam', N'123 Đinh Tiên Hoàng, Bình Thạnh, TP HCM', '0124901234', 'minhtri@gmail.com'),
    ('KH18', N'Nguyễn Thị Nhi', '25/11/2002', N'Nữ', N'456 Phan Đăng Lưu, Phú Nhuận, TP HCM', '0125012345', 'thinhi@gmail.com'),
    ('KH19', N'Trần Quang Hưng', '15/12/1999', N'Nam', N'789 Hoàng Văn Thụ, Tân Bình, TP HCM', '0125123456', 'quanghung@gmail.com'),
    ('KH20', N'Lê Thị Như', '30/08/2000', N'Nữ', N'321 Lê Duẩn, Quận 1, TP HCM', '0125234567', 'nhu@gmail.com'),
    ('KH21', N'Nguyễn Hoàng Anh', '01/01/1996', N'Nam', N'654 Trần Quốc Toản, Quận 3, TP HCM', '0125345678', 'hoanganh@gmail.com'),
    ('KH22', N'Ngô Thị Vân', '06/05/2004', N'Nữ', N'987 Nguyễn Thái Học, Quận 10, TP HCM', '0125456789', 'thivan@gmail.com'),
    ('KH23', N'Vũ Minh Hiếu', '12/07/1997', N'Nam', N'123 Trường Sa, Bình Thạnh, TP HCM', '0125567890', 'minhhieu@gmail.com'),
    ('KH24', N'Phạm Thị Bích', '22/02/1998', N'Nữ', N'456 Nguyễn Thượng Hiền, Quận 1, TP HCM', '0125678901', 'thibich@gmail.com'),
    ('KH25', N'Trần Văn Long', '19/03/1995', N'Nam', N'789 Đường Huyền Trân Công Chúa, Quận 5, TP HCM', '0125789012', 'vanlong@gmail.com'),
    ('KH26', N'Nguyễn Thị Ngọc Bích', '29/06/2001', N'Nữ', N'321 Đường số 10, Gò Vấp, TP HCM', '0125890123', 'ngocbich@gmail.com'),
    ('KH27', N'Lê Đình Phúc', '18/12/1999', N'Nam', N'654 Đường Bùi Viện, Quận 1, TP HCM', '0125901234', 'dinhphuc@gmail.com'),
    ('KH28', N'Trần Thị Phương', '11/10/2000', N'Nữ', N'987 Phan Văn Trị, Gò Vấp, TP HCM', '0126012345', 'thiphuong@gmail.com'),
    ('KH29', N'Nguyễn Tiến Đạt', '05/04/1998', N'Nam', N'123 Trần Quốc Thảo, Quận 3, TP HCM', '0126123456', 'tiendat@gmail.com'),
    ('KH30', N'Nguyễn Thị Tươi', '01/09/2002', N'Nữ', N'456 Đường số 5, Bình Thạnh, TP HCM', '0126234567', 'thitui@gmail.com'),
    ('KH31', N'Trần Văn Thắng', '20/08/2003', N'Nam', N'789 Nguyễn Kiệm, Phú Nhuận, TP HCM', '0126345678', 'vanthang@gmail.com'),
    ('KH32', N'Nguyễn Thị Nhung', '15/11/1997', N'Nữ', N'321 Lê Trọng Tấn, Tân Bình, TP HCM', '0126456789', 'thinhu@gmail.com'),
    ('KH33', N'Ngô Minh Sang', '12/02/2000', N'Nam', N'654 Lê Văn Lương, Quận 7, TP HCM', '0126567890', 'minhsang@gmail.com'),
    ('KH34', N'Trần Thị Thanh', '25/04/2001', N'Nữ', N'987 Đường Huỳnh Văn Bánh, Phú Nhuận, TP HCM', '0126678901', 'thithanh@gmail.com'),
    ('KH35', N'Nguyễn Văn Hải', '30/05/1999', N'Nam', N'123 Đường Nguyễn Thị Minh Khai, Quận 1, TP HCM', '0126789012', 'vanhai@gmail.com'), 
    ('KH36', N'Nguyễn Văn Phúc', '22/07/1998', N'Nam', N'111 Đường 3/2, Quận 10, TP HCM', '0126890123', 'vanphuc@gmail.com'),
    ('KH37', N'Trần Hữu Nghĩa', '30/11/1996', N'Nam', N'222 Đường Lê Lợi, Quận 1, TP HCM', '0126901234', 'hunghia@gmail.com'),
    ('KH38', N'Nguyễn Thị Kim', '05/01/2003', N'Nữ', N'333 Đường Nguyễn Trãi, Quận 5, TP HCM', '0127012345', 'thikim@gmail.com'),
    ('KH39', N'Phạm Văn Hưng', '16/08/2001', N'Nam', N'444 Đường Trần Bình Trọng, Quận 6, TP HCM', '0127123456', 'vanhung@gmail.com'),
    ('KH40', N'Trần Thị Hạnh', '29/09/2000', N'Nữ', N'555 Đường Tôn Đức Thắng, Quận 3, TP HCM', '0127234567', 'thihanh@gmail.com'),
    ('KH41', N'Nguyễn Văn Tài', '11/02/1997', N'Nam', N'666 Đường Ngô Thời Nhiệm, Quận 7, TP HCM', '0127345678', 'vantai@gmail.com'),
    ('KH42', N'Trần Minh Tâm', '21/10/2004', N'Nữ', N'777 Đường Lê Văn Sỹ, Quận 3, TP HCM', '0127456789', 'minhtam@gmail.com'),
    ('KH43', N'Nguyễn Thị Bích', '14/03/1995', N'Nữ', N'888 Đường Hoàng Diệu, Quận 4, TP HCM', '0127567890', 'thibich@gmail.com'),
    ('KH44', N'Ngô Văn Khải', '07/12/1998', N'Nam', N'999 Đường Nguyễn Thị Minh Khai, Quận 1, TP HCM', '0127678901', 'vankhai@gmail.com'),
    ('KH45', N'Phan Thị Ly', '20/05/2002', N'Nữ', N'1111 Đường Trần Hưng Đạo, Quận 5, TP HCM', '0127789012', 'thily@gmail.com'),
    ('KH46', N'Trần Văn Bảo', '15/06/1996', N'Nam', N'2222 Đường Tôn Thất Tùng, Quận 4, TP HCM', '0127890123', 'vanbao@gmail.com'),
    ('KH47', N'Nguyễn Thị Phương', '28/04/2000', N'Nữ', N'3333 Đường Lê Văn Khương, Quận 12, TP HCM', '0127901234', 'thiphuong@gmail.com'),
    ('KH48', N'Đặng Văn Hòa', '03/11/1999', N'Nam', N'4444 Đường Nguyễn Hữu Cảnh, Bình Thạnh, TP HCM', '0128012345', 'vanhoa@gmail.com'),
    ('KH49', N'Trần Thị Ngọc', '30/01/2001', N'Nữ', N'5555 Đường Điện Biên Phủ, Bình Thạnh, TP HCM', '0128123456', 'thingoct@gmail.com'),
    ('KH50', N'Nguyễn Văn Đạo', '17/08/1997', N'Nam', N'6666 Đường Nguyễn Thái Sơn, Gò Vấp, TP HCM', '0128234567', 'vandaot@gmail.com'),
    ('KH51', N'Trần Văn Tú', '26/09/2003', N'Nam', N'7777 Đường Quốc Lộ 13, Bình Thạnh, TP HCM', '0128345678', 'vantu@gmail.com'),
    ('KH52', N'Nguyễn Thị Vân', '19/12/2002', N'Nữ', N'8888 Đường Lê Văn Sỹ, Quận 3, TP HCM', '0128456789', 'thivan@gmail.com'),
    ('KH53', N'Phạm Minh Tuấn', '01/04/1995', N'Nam', N'9999 Đường Lê Thị Riêng, Quận 1, TP HCM', '0128567890', 'minhtuan@gmail.com'),
    ('KH54', N'Trần Thị Lệ', '09/10/1998', N'Nữ', N'11111 Đường Trần Hưng Đạo, Quận 5, TP HCM', '0128678901', 'thile@gmail.com'),
    ('KH55', N'Nguyễn Văn Lực', '22/05/2000', N'Nam', N'22222 Đường Đinh Bộ Lĩnh, Bình Thạnh, TP HCM', '0128789012', 'vanluc@gmail.com'),
    ('KH56', N'Ngô Thị Thắm', '05/01/1996', N'Nữ', N'33333 Đường Nguyễn Thị Minh Khai, Quận 1, TP HCM', '0128890123', 'thitham@gmail.com'),
    ('KH57', N'Đặng Văn Lâm', '14/02/1999', N'Nam', N'44444 Đường Phạm Văn Đồng, Gò Vấp, TP HCM', '0128901234', 'vanlam@gmail.com'),
    ('KH58', N'Nguyễn Thị Lan', '03/03/2001', N'Nữ', N'55555 Đường Đinh Tiên Hoàng, Bình Thạnh, TP HCM', '0129012345', 'thilan@gmail.com'),
    ('KH59', N'Phạm Văn Nghĩa', '15/06/2002', N'Nam', N'66666 Đường Bạch Đằng, Bình Thạnh, TP HCM', '0129123456', 'vanghia@gmail.com'),
    ('KH60', N'Trần Thị Minh', '28/07/1997', N'Nữ', N'77777 Đường Hồ Văn Huê, Phú Nhuận, TP HCM', '0129234567', 'thiminh@gmail.com'),
    ('KH61', N'Nguyễn Văn Mạnh', '11/08/1998', N'Nam', N'88888 Đường Lê Hồng Phong, Quận 10, TP HCM', '0129345678', 'vanmanh@gmail.com'),
    ('KH62', N'Trần Thị Yến', '20/09/2003', N'Nữ', N'99999 Đường Trần Văn Đang, Quận 5, TP HCM', '0129456789', 'thiyen@gmail.com'),
    ('KH63', N'Nguyễn Hữu An', '25/10/2002', N'Nam', N'1111 Đường Nguyễn Hữu Cảnh, Bình Thạnh, TP HCM', '0129567890', 'huoan@gmail.com'),
    ('KH64', N'Trần Thị Hương', '06/11/1996', N'Nữ', N'2222 Đường Bến Bình Đông, Quận 8, TP HCM', '0129678901', 'thihuong@gmail.com'),
    ('KH65', N'Nguyễn Văn Khải', '09/12/1995', N'Nam', N'3333 Đường Nguyễn Trãi, Quận 1, TP HCM', '0129789012', 'vankhai@gmail.com'),
    ('KH66', N'Ngô Thị Ngọc', '15/01/2004', N'Nữ', N'4444 Đường D1, Quận Bình Thạnh, TP HCM', '0129890123', 'thingoc@gmail.com'),
    ('KH67', N'Đặng Văn Tiến', '17/02/2000', N'Nam', N'5555 Đường Lê Văn Sỹ, Quận 3, TP HCM', '0129901234', 'vantiend@gmail.com'),
    ('KH68', N'Nguyễn Thị Bạch', '23/03/1999', N'Nữ', N'6666 Đường Trần Quốc Thảo, Quận 3, TP HCM', '0129912345', 'thibach@gmail.com'),
    ('KH69', N'Phạm Minh Châu', '30/04/2001', N'Nam', N'7777 Đường Tôn Đức Thắng, Quận 3, TP HCM', '0129923456', 'minhchau@gmail.com'),
    ('KH70', N'Trần Văn Tùng', '05/05/1996', N'Nam', N'8888 Đường Nam Kỳ Khởi Nghĩa, Quận 3, TP HCM', '0129934567', 'vantung@gmail.com'),
    ('KH71', N'Nguyễn Thị Sương', '11/06/2002', N'Nữ', N'9999 Đường Đinh Tiên Hoàng, Quận 1, TP HCM', '0129945678', 'thisuong@gmail.com'),
    ('KH72', N'Ngô Văn Hải', '18/07/1997', N'Nam', N'11111 Đường Phạm Ngọc Thạch, Quận 1, TP HCM', '0129956789', 'vanhai@gmail.com'),
    ('KH73', N'Phan Thị Nga', '23/08/2000', N'Nữ', N'22222 Đường Lê Quý Đôn, Quận 1, TP HCM', '0129967890', 'thinga@gmail.com'),
    ('KH74', N'Nguyễn Văn Quyết', '14/09/2003', N'Nam', N'33333 Đường Nguyễn Thị Minh Khai, Quận 1, TP HCM', '0129978901', 'vanquyet@gmail.com'),
    ('KH75', N'Trần Thị Hằng', '19/10/2002', N'Nữ', N'44444 Đường Nguyễn Văn Cừ, Quận 5, TP HCM', '0129989012', 'thihang@gmail.com'),
    ('KH76', N'Nguyễn Văn Tiến', '15/11/2001', N'Nam', N'55555 Đường Trần Hưng Đạo, Quận 5, TP HCM', '0129990123', 'vantiend@gmail.com'),
    ('KH77', N'Trần Văn Đạt', '10/12/1996', N'Nam', N'66666 Đường Lê Thị Hồng, Quận 1, TP HCM', '0130001234', 'vandat@gmail.com'),
    ('KH78', N'Nguyễn Thị Liên', '05/01/1999', N'Nữ', N'77777 Đường Điện Biên Phủ, Bình Thạnh, TP HCM', '0130112345', 'thilien@gmail.com'),
    ('KH79', N'Phạm Văn Huy', '22/02/2000', N'Nam', N'88888 Đường Trường Sa, Phú Nhuận, TP HCM', '0130223456', 'vanhuy@gmail.com'),
    ('KH80', N'Trần Thị Dung', '18/03/2002', N'Nữ', N'99999 Đường Nguyễn Huệ, Quận 1, TP HCM', '0130334567', 'thidung@gmail.com'),
    ('KH81', N'Nguyễn Văn Cường', '26/04/1998', N'Nam', N'11111 Đường Võ Văn Tần, Quận 3, TP HCM', '0130445678', 'vancuong@gmail.com'),
    ('KH82', N'Trần Thị Thanh', '30/05/2003', N'Nữ', N'22222 Đường Tôn Đức Thắng, Quận 1, TP HCM', '0130556789', 'thithanh@gmail.com'),
    ('KH83', N'Nguyễn Văn Sỹ', '07/06/1995', N'Nam', N'33333 Đường Lê Văn Lương, Quận 7, TP HCM', '0130667890', 'vansy@gmail.com'),
    ('KH84', N'Trần Thị Hồng', '01/07/2001', N'Nữ', N'44444 Đường Trần Văn Đang, Quận 5, TP HCM', '0130778901', 'thihong@gmail.com'),
    ('KH85', N'Nguyễn Văn Khoa', '20/08/2000', N'Nam', N'55555 Đường Nguyễn Đình Chiểu, Quận 1, TP HCM', '0130889012', 'vankhoa@gmail.com'),
    ('KH86', N'Ngô Thị Mỹ', '15/09/1998', N'Nữ', N'66666 Đường Tôn Thất Thuyết, Quận 4, TP HCM', '0130990123', 'thimy@gmail.com'),
    ('KH87', N'Phạm Văn Phát', '11/10/1997', N'Nam', N'77777 Đường Phạm Hùng, Quận 8, TP HCM', '0131001234', 'vanphat@gmail.com'),
    ('KH88', N'Trần Thị Bảo', '20/11/1999', N'Nữ', N'88888 Đường Lê Trọng Tấn, Quận 1, TP HCM', '0131112345', 'thibao@gmail.com'),
    ('KH89', N'Nguyễn Văn Minh', '30/12/2002', N'Nam', N'99999 Đường Hàn Hải Nguyên, Quận 5, TP HCM', '0131223456', 'vanminh@gmail.com'),
    ('KH90', N'Trần Thị Xuân', '17/01/2001', N'Nữ', N'11111 Đường 3/2, Quận 10, TP HCM', '0131334567', 'thixuan@gmail.com'),
    ('KH91', N'Nguyễn Văn Tùng', '04/02/1996', N'Nam', N'22222 Đường Nguyễn Thái Sơn, Gò Vấp, TP HCM', '0131445678', 'vantung@gmail.com'),
    ('KH92', N'Trần Thị Huyền', '20/03/2000', N'Nữ', N'33333 Đường Tôn Đức Thắng, Quận 1, TP HCM', '0131556789', 'thihuyen@gmail.com'),
    ('KH93', N'Nguyễn Văn Đăng', '01/04/1995', N'Nam', N'44444 Đường Trần Quốc Thảo, Quận 3, TP HCM', '0131667890', 'vandang@gmail.com'),
    ('KH94', N'Trần Thị Phượng', '16/05/2002', N'Nữ', N'55555 Đường Nguyễn Thị Minh Khai, Quận 1, TP HCM', '0131778901', 'thiphuong@gmail.com'),
    ('KH95', N'Nguyễn Văn Hậu', '22/06/1998', N'Nam', N'66666 Đường Phan Văn Trị, Gò Vấp, TP HCM', '0131889012', 'vanhau@gmail.com'),
    ('KH96', N'Trần Thị Hoa', '30/07/2001', N'Nữ', N'77777 Đường Nguyễn Hữu Cảnh, Bình Thạnh, TP HCM', '0131990123', 'thihhoa@gmail.com'),
    ('KH97', N'Nguyễn Văn Trường', '08/08/1999', N'Nam', N'88888 Đường Cách Mạng Tháng Tám, Quận 1, TP HCM', '0132001234', 'vantruong@gmail.com'),
    ('KH98', N'Trần Thị Tuyết', '21/09/1997', N'Nữ', N'99999 Đường Đinh Bộ Lĩnh, Bình Thạnh, TP HCM', '0132112345', 'thituyet@gmail.com'),
    ('KH99', N'Nguyễn Văn Phúc', '26/10/1998', N'Nam', N'11111 Đường Hậu Giang, Quận 6, TP HCM', '0132223456', 'vanphuc@gmail.com'),
    ('KH100', N'Trần Thị Cúc', '30/11/2000', N'Nữ', N'22222 Đường Bến Vân Đồn, Quận 4, TP HCM', '0132334567', 'thicuc@gmail.com');
