Insert into  ChiNhanh(maCN,tenCN,diaChi,soDienThoai,email,ghiChu)
values ('01','Nhà sách Sài Gòn','Sài gòn','09102931','quyngo',''),
('02','Nhà sách Hà Nội','Hà Nội','09102931','quyngo','')
go
Insert into  ChucVu(tenChucVu)
values ('Quản lý'),('Nhân Viên')
go
Insert into  CaTruc(tenCaTruc,gioBD,gioKT,maCN,ghiChu)
values ('T2_Sang','8:00:00','10:00:00','01','')
go 
Insert into  NhanSu(maNS,tenNS,gioiTinh,cccdNS,sdtNV,emailNV,diaChiNha,maCN,chucVu,matkhau)
values ('NS01','Văn A','Nam','09878983762','0928372892','quy@gmail.com','Tiền Giang','01','1','0'),
('NS02','A Ánh','Nữ','09878983762','0928372832','Sơn@gmail.com','Hậu Giang','01','2','0')