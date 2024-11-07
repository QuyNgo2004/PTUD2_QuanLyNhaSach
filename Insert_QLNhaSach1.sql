--Insert into  ChiNhanh(maCN,tenCN,diaChi,soDienThoai,email,ghiChu)
--values ('01','Nhà sách Sài Gòn','Sài gòn','09102931','quyngo',''),
--('02','Nhà sách Hà Nội','Hà Nội','09102931','quyngo','')
--go
use QLNhaSach

set dateformat dmy


INSERT INTO ChiNhanh (maCN, tenCN, diaChi, soDienThoai, email, ghiChu)
VALUES 
('CN01', N'Chi Nhánh Hà Nội', N'123 Đường Láng, Đống Đa, Hà Nội', '0901234567', 'hanoi@company.com', N'Chi nhánh chính'),
('CN02', N'Chi Nhánh TP.HCM', N'456 Đường Điện Biên Phủ, Quận 3, TP.HCM', '0902345678', 'tphcm@company.com', NULL),
('CN03', N'Chi Nhánh Đà Nẵng', N'789 Đường Nguyễn Văn Linh, Hải Châu, Đà Nẵng', '0903456789', 'danang@company.com', NULL),
('CN04', N'Chi Nhánh Hải Phòng', N'321 Đường Lê Hồng Phong, Ngô Quyền, Hải Phòng', '0904567890', 'haiphong@company.com', NULL),
('CN05', N'Chi Nhánh Cần Thơ', N'654 Đường Trần Hưng Đạo, Ninh Kiều, Cần Thơ', '0905678901', 'cantho@company.com', NULL),
('CN06', N'Chi Nhánh Vinh', N'987 Đường Phan Đình Phùng, Vinh, Nghệ An', '0906789012', 'vinh@company.com', NULL),
('CN07', N'Chi Nhánh Huế', N'111 Đường Hùng Vương, TP Huế, Thừa Thiên Huế', '0907890123', 'hue@company.com', NULL),
('CN08', N'Chi Nhánh Nha Trang', N'222 Đường Trần Phú, TP Nha Trang, Khánh Hòa', '0908901234', 'nhatrang@company.com', NULL),
('CN09', N'Chi Nhánh Bình Dương', N'333 Đường Cách Mạng Tháng 8, Thủ Dầu Một, Bình Dương', '0909012345', 'binhduong@company.com', NULL),
('CN10', N'Chi Nhánh Biên Hòa', N'444 Đường Phạm Văn Thuận, Biên Hòa, Đồng Nai', '0910123456', 'bienhoa@company.com', NULL);


INSERT INTO NhaPhanPhoi (maNPP, tenNPP, diachiNPP, sdtNPP, emailNPP)
VALUES
('NPP01', N'Nhà Phân Phối Minh Phát', N'123 Đường Trần Phú, Quận 5, TP.HCM', '0912233445', 'minhphat@company.com'),
('NPP02', N'Nhà Phân Phối Nam Tiến', N'456 Đường Hoàng Văn Thụ, Phú Nhuận, TP.HCM', '0913344556', 'namtien@company.com'),
('NPP03', N'Nhà Phân Phối Phú Lộc', N'789 Đường Cách Mạng Tháng 8, Quận 10, TP.HCM', '0914455667', 'phuloc@company.com'),
('NPP04', N'Nhà Phân Phối An Khang', N'321 Đường Võ Thị Sáu, Quận 3, TP.HCM', '0915566778', 'ankhang@company.com'),
('NPP05', N'Nhà Phân Phối Thanh Long', N'654 Đường Nguyễn Trãi, Quận 1, TP.HCM', '0916677889', 'thanhlong@company.com'),
('NPP06', N'Nhà Phân Phối Hưng Thịnh', N'987 Đường Trường Chinh, Tân Bình, TP.HCM', '0917788990', 'hungthinh@company.com'),
('NPP07', N'Nhà Phân Phối Ngọc Lan', N'111 Đường Lý Tự Trọng, Quận 1, TP.HCM', '0918899001', 'ngoclan@company.com'),
('NPP08', N'Nhà Phân Phối Thảo Nguyên', N'222 Đường Lê Duẩn, Quận 1, TP.HCM', '0919900112', 'thaonguyen@company.com'),
('NPP09', N'Nhà Phân Phối Hòa Bình', N'333 Đường Nguyễn Thị Minh Khai, Quận 3, TP.HCM', '0920112233', 'hoabinh@company.com'),
('NPP10', N'Nhà Phân Phối Đại Nam', N'444 Đường Điện Biên Phủ, Bình Thạnh, TP.HCM', '0921223344', 'dainam@company.com');

insert into LoaiHangHoa(maLHH, tenLHH, ghiChu) values
('LHH01',N'Sách giáo khoa',N'Sách từ cấp tiểu học đến trung học phổ thông.'),
('LHH02',N'Sách tham khảo',N'Sách ôn thi, sách bổ trợ cho các môn học.'),
('LHH03',N'Sách ngoại ngữ',N'Sách học các môn ngoại ngữ.'),
('LHH04',N'Sách kỹ năng sống',N'Sách phát triển bản thân, kỹ năng giao tiếp.'),
('LHH05',N'Sách văn học',N'Tiểu thuyết, truyện ngắn, thơ, văn học Việt Nam và nước ngoài.'),
('LHH06',N'Sách khoa học',N'Sách khoa học phổ thông, khoa học ứng dụng.'),
('LHH07',N'Sách thiếu nhi',N'Sách cho trẻ em như truyện tranh, sách tô màu.'),
('LHH08',N'Văn phòng phẩm',N'Bút, sổ tay, giấy viết, dụng cụ học tập khác.'),
('LHH09',N'Đồ chơi giáo dục',N'Đồ chơi hỗ trợ phát triển trí tuệ, tư duy cho trẻ.'),
('LHH10',N'Đồ lưu niệm',N'Các sản phẩm trang trí, quà tặng nhỏ.'),
('LHH11',N'Từ điển',N'Sách từ điển của nhiều ngôn ngữ khác nhau.'),
('LHH12',N'Sách tài liệu',N'Sách cung cấp tài liệu khác nhau.'),
('LHH13',N'Mỹ phẩm',N'Mỹ phẩm các loại.');

insert into NhaPhanPhoi(maNPP, tenNPP, diachiNPP, sdtNPP, emailNPP) values
---phan phoi sach.
('NPP11',N'NXB Trẻ',N'161B Lý Chính Thắng, Phường Võ Thị Sáu, Quận 3, Hồ Chí Minh','0283931628','hopthubandoc@nxbtre.com.vn'),
('NPP12',N'NXB Kim Đồng',N'55 Quang Trung, Hai Bà Trưng, Hà Nội','0243942863','info@nxbkimdong.com.vn'),
('NPP13',N'NXB Tổng hợp TP.HCM',N'62 Nguyễn Thị Minh Khai, Phường Đa Kao, Quận 1, TP.HCM','0283825680','nstonghop@gmail.com'),
('NPP14',N'NXB Văn học',N'18 Nguyễn Trường Tộ, Ba Đình, Hà Nội','0978623868','info.nxbvanhoc@gmail.com'),
('NPP15',N'NXB Lao động',N'85 Đ. Cách Mạng Tháng 8, Phường Phạm Ngũ Lão, Quận 1, Hồ Chí Minh','0100110535','info@nxblaodong.com.vn'),
('NPP16',N'Công ty sách Thái Hà',N'23 Tân Thới Nhất 6, P. Tân Thới Nhất, Q. 12, TP. HCM','0888421456','Sachthaiha@thaihabooks.com'),
---phan phoi van phong pham.
('NPP17',N'Công ty TNHH Văn phòng phẩm Hòa Phát',N'Số nhà 1, quận Hoàng Mai, tp Hà Nội','0973030496','anhoaphat688@gmail.com'),
('NPP18',N'Công ty TNHH Văn phòng phẩm Thiên Long','Tầng 10, Sofic Tower, Số 10 Đường Mai Chí Thọ, Thành Phố Thủ Đức, TP HCM, Việt Nam','1900866819','salesonline@thienlongvn.com'),
('NPP19',N'Công ty TNHH Văn phòng phẩm An Lộc','30 Kha Vạn Cân, Hiệp Bình Chánh, Thủ Đức, Tp.HCM.','0287300773','vppanlocviet@gmail.com'),
---phan phoi do luu niem.
('NPP20',N'Công ty TNHH Sản xuất và Thương mại Hưng Phát',N'Số 134-136 Lê Quý Đôn, Tỉnh Thái Bình, Việt Nam','0363834200','hungphat@gmail.com'),
('NPP21',N'Công ty TNHH Quà tặng Minh Châu',N'6A, tòa nhà văn phòng Điện Biên, Quận Đống Đa, Thành phố Hà Nội','0328338032','minhchau@gmail.com'),
---phan phoi do choi cho tre em.
('NPP22',N'Công ty TNHH Đồ chơi Việt',N'Xóm lẻ, Xã Tân Triều, Huyện Thanh Trì, Thành phố Hà Nội, Việt Nam','0947555696','dochoivn@gmail.com'),
('NPP23',N'Công ty Cổ phần Đồ chơi thông minh Kids Plazza',N'Tầng 4 Tòa nhà CT2 - Bắc Hà C14, đường Tố Hữu, P.Trung Văn, Q.Nam Từ Liêm, Hà Nội.','1800660800','kidsplazza@gmail.com'),
('NPP24',N'Công ty TNHH Đồ chơi trẻ em Thế Giới',N'Số 30 Đường số 89, Ấp Cây Da, Xã Tân Phú Trung, Huyện Củ Chi, Thành phố Hồ Chí Minh, Việt Nam','0283796612','dochoitreem@gmail.com');
insert into HangHoa(maHH, maLHH, tenHH, giaHH, donViTinh, soLuongTon, maNPP, hanSD, moTa, ghiChu, tinhTrang) values
---sach giao khoa.
('1907110311401','LHH01',N'Bộ sách giáo khoa lớp 1',115000,N'Bộ',46,'NPP11','',N'Sách giáo khoa cấp 1 - Lớp 1',N'Không bán lẻ',N'Còn hàng'),
('1907110311402','LHH01',N'Bộ sách giáo khoa lớp 2',120000,N'Bộ',13,'NPP11','',N'Sách giáo khoa cấp 1 - Lớp 2',N'Không bán lẻ',N'Còn hàng'),
('1907110311403','LHH01',N'Bộ sách giáo khoa lớp 3',127000,N'Bộ',27,'NPP12','',N'Sách giáo khoa cấp 1 - Lớp 3',N'Không bán lẻ',N'Còn hàng'),
('1907110311404','LHH01',N'Bộ sách giáo khoa lớp 4',139000,N'Bộ',36,'NPP12','',N'Sách giáo khoa cấp 1 - Lớp 4',N'Không bán lẻ',N'Còn hàng'),
('1907110311405','LHH01',N'Bộ sách giáo khoa lớp 5',165000,N'Bộ',44,'NPP13','',N'Sách giáo khoa cấp 1 - Lớp 5',N'Không bán lẻ',N'Còn hàng'),
('1907110311406','LHH01',N'Bộ sách giáo khoa lớp 6',198000,N'Bộ',35,'NPP13','',N'Sách giáo khoa cấp 2 - Lớp 6',N'Không bán lẻ',N'Còn hàng'),
('1907110311407','LHH01',N'Bộ sách giáo khoa lớp 7',203000,N'Bộ',28,'NPP14','',N'Sách giáo khoa cấp 2 - Lớp 7',N'Không bán lẻ',N'Còn hàng'),
('1907110311408','LHH01',N'Bộ sách giáo khoa lớp 8',213000,N'Bộ',23,'NPP14','',N'Sách giáo khoa cấp 2 - Lớp 8',N'Không bán lẻ',N'Còn hàng'),
('1907110311409','LHH01',N'Bộ sách giáo khoa lớp 9',231000,N'Bộ',38,'NPP15','',N'Sách giáo khoa cấp 2 - Lớp 9',N'Không bán lẻ',N'Còn hàng'),
('1907110311410','LHH01',N'Bộ sách giáo khoa lớp 10',241000,N'Bộ',15,'NPP15','',N'Sách giáo khoa cấp 3 - Lớp 10',N'Không bán lẻ',N'Còn hàng'),
('1907110311411','LHH01',N'Bộ sách giáo khoa lớp 11',265000,N'Bộ',41,'NPP16','',N'Sách giáo khoa cấp 3 - Lớp 11',N'Không bán lẻ',N'Còn hàng'),
('1907110311412','LHH01',N'Bộ sách giáo khoa lớp 12',270000,N'Bộ',19,'NPP16','',N'Sách giáo khoa cấp 3 - Lớp 12',N'Không bán lẻ',N'Còn hàng');
go

go
Insert into  ChucVu(tenChucVu)
values ('Quản lý'),('Nhân Viên')
go

go
Insert into  CaTruc(tenCaTruc,gioBD,gioKT,maCN,ghiChu)
values ('T2_Sang','8:00:00','10:00:00','CN01','')
go 
Insert into  NhanSu(maNS,tenNS,gioiTinh,cccdNS,sdtNV,emailNV,diaChiNha,maCN,chucVu,matkhau)

values ('NS01',N'Văn A',N'Nam','09878983762','0928372892','quy@gmail.com',N'Tiền Giang','CN01','1','0'),
('NS02',N'A Ánh',N'Nữ','09878983762','0928372832','Son@gmail.com',N'Hậu Giang','CN01','2','0'),
('NS03',N'Văn Thơ',N'Nữ','09878983762','0928372832','Tho@gmail.com',N'Kiên Giang','CN01','2','0'),
('NS04',N'Tuấn Tú',N'Nam','09878983762','0928372832','Tu123@gmail.com',N'Hậu Giang','CN01','2','0'),
('NS05',N'Tuấn Anh',N'Nam','09878983762','0928372832','Anh321@gmail.com',N'Kiên Giang','CN01','2','0')
go
--insert into KhachHang(maKH, hoTenKH, ngaysinhKH, gioitinhKH, diachiKH, sdtKH, emailKH)
--values  ('KH001', N'Hoàng Văn Duy','2005/07/18',N'Nam',N'18 Thành Mỹ Lợi, Thủ Đức, TP HCM','0123467868','hoangduy@gmail.com'),
--		('KH002', N'Nguyễn Hoàng Nam', '2002/03/12', N'Nam', N'123 Nguyễn Văn Bứa, Bình Chánh, TP HCM', '0123456789', 'namnguyen@gmail.com'),
--		('KH003', N'Phạm Minh Khôi', '1998/11/25', N'Nam', N'456 Phú Mỹ Hưng, Quận 7, TP HCM', '0123567890', 'minhkhoi@gmail.com'),
--		('KH004', N'Nguyễn Thị Hoa', '2001/06/05', N'Nữ', N'789 Lê Quý Đôn, Quận 3, TP HCM', '0123678901', 'hoanguyen@gmail.com'),
--		('KH005', N'Đặng Thế Huy', '1995/09/30', N'Nam', N'321 Nguyễn Thái Bình, Quận 1, TP HCM', '0123789012', 'thehuy@gmail.com'),
--		('KH006', N'Nguyễn Hương Giang', '1999/04/20', N'Nữ', N'654 Trần Hưng Đạo, Quận 5, TP HCM', '0123890123', 'huonggiang@gmail.com'),
--		('KH007', N'Ngô Minh Tuấn', '2003/12/15', N'Nam', N'987 Trần Nhân Tôn, Quận 10, TP HCM', '0123901234', 'minhtuan@gmail.com'),
--		('KH008', N'Nguyễn Thị Hằng', '2000/08/11', N'Nữ', N'123 Tôn Thất Thuyết, Quận 4, TP HCM', '0124012345', 'thihang@gmail.com'),
--		('KH009', N'Nguyễn Văn Tâm', '1996/05/22', N'Nam', N'456 Đường Lê Lợi, Quận 1, TP HCM', '0124123456', 'vantam@gmail.com'),
--		('KH010', N'Phan Thị Ngọc', '2004/01/02', N'Nữ', N'789 Đường Bạch Đằng, Bình Thạnh, TP HCM', '0124234567', 'thinhoc@gmail.com'),
--		('KH011', N'Nguyễn Đình Sơn', '1997/02/28', N'Nam', N'321 Đường Nguyễn Tất Thành, Quận 4, TP HCM', '0124345678', 'dinhson@gmail.com'),
--		('KH012', N'Trần Hoàng Yến', '2002/07/19', N'Nữ', N'654 Lê Văn Sỹ, Phú Nhuận, TP HCM', '0124456789', 'hoangyen@gmail.com'),
--		('KH013', N'Nguyễn Văn An', '2000/09/09', N'Nam', N'789 Lê Hồng Phong, Quận 10, TP HCM', '0124567890', 'vanan@gmail.com'),
--		('KH014', N'Vũ Thị Mai', '1998/06/30', N'Nữ', N'321 Trường Chinh, Tân Bình, TP HCM', '0124678901', 'thimai@gmail.com'),
--		('KH015', N'Nguyễn Tiến Dũng', '1995/04/15', N'Nam', N'654 Nguyễn Văn Cừ, Quận 5, TP HCM', '0124789012', 'tiendung@gmail.com'),
--		('KH016', N'Phạm Thị Lành', '2003/03/10', N'Nữ', N'987 Lê Thị Hồng Gấm, Quận 1, TP HCM', '0124890123', 'thilanh@gmail.com'),
--		('KH017', N'Đỗ Minh Trí', '2001/10/07', N'Nam', N'123 Đinh Tiên Hoàng, Bình Thạnh, TP HCM', '0124901234', 'minhtri@gmail.com'),
--		('KH018', N'Nguyễn Thị Nhi', '2002/11/25', N'Nữ', N'456 Phan Đăng Lưu, Phú Nhuận, TP HCM', '0125012345', 'thinhi@gmail.com'),
--		('KH019', N'Trần Quang Hưng', '1999/12/15', N'Nam', N'789 Hoàng Văn Thụ, Tân Bình, TP HCM', '0125123456', 'quanghung@gmail.com'),
--		('KH020', N'Lê Thị Như', '2000/08/30', N'Nữ', N'321 Lê Duẩn, Quận 1, TP HCM', '0125234567', 'nhu@gmail.com'),
--		('KH021', N'Nguyễn Hoàng Anh', '1996/01/01', N'Nam', N'654 Trần Quốc Toản, Quận 3, TP HCM', '0125345678', 'hoanganh@gmail.com'),
--		('KH022', N'Ngô Thị Vân', '2004/05/06', N'Nữ', N'987 Nguyễn Thái Học, Quận 10, TP HCM', '0125456789', 'thivan@gmail.com'),
--		('KH023', N'Vũ Minh Hiếu', '1997/07/12', N'Nam', N'123 Trường Sa, Bình Thạnh, TP HCM', '0125567890', 'minhhieu@gmail.com'),
--		('KH024', N'Phạm Thị Bích', '1998/02/22', N'Nữ', N'456 Nguyễn Thượng Hiền, Quận 1, TP HCM', '0125678901', 'thibich@gmail.com'),
--		('KH025', N'Trần Văn Long', '1995/03/19', N'Nam', N'789 Đường Huyền Trân Công Chúa, Quận 5, TP HCM', '0125789012', 'vanlong@gmail.com'),
--		('KH026', N'Nguyễn Thị Ngọc Bích', '2001/06/29', N'Nữ', N'321 Đường số 10, Gò Vấp, TP HCM', '0125890123', 'ngocbich@gmail.com'),
--		('KH027', N'Lê Đình Phúc', '1999/12/18', N'Nam', N'654 Đường Bùi Viện, Quận 1, TP HCM', '0125901234', 'dinhphuc@gmail.com'),
--		('KH028', N'Trần Thị Phương', '2000/10/11', N'Nữ', N'987 Phan Văn Trị, Gò Vấp, TP HCM', '0126012345', 'thiphuong@gmail.com'),
--		('KH029', N'Nguyễn Tiến Đạt', '1998/04/05', N'Nam', N'123 Trần Quốc Thảo, Quận 3, TP HCM', '0126123456', 'tiendat@gmail.com'),
--		('KH030', N'Nguyễn Thị Tươi', '2002/09/01', N'Nữ', N'456 Đường số 5, Bình Thạnh, TP HCM', '0126234567', 'thitui@gmail.com'),
--		('KH031', N'Trần Văn Thắng', '2003/08/20', N'Nam', N'789 Nguyễn Kiệm, Phú Nhuận, TP HCM', '0126345678', 'vanthang@gmail.com'),
--		('KH032', N'Nguyễn Thị Nhung', '1997/11/15', N'Nữ', N'321 Lê Trọng Tấn, Tân Bình, TP HCM', '0126456789', 'thinhu@gmail.com'),
--		('KH033', N'Ngô Minh Sang', '2000/02/12', N'Nam', N'654 Lê Văn Lương, Quận 7, TP HCM', '0126567890', 'minhsang@gmail.com'),
--		('KH034', N'Trần Thị Thanh', '2001/04/25', N'Nữ', N'987 Đường Huỳnh Văn Bánh, Phú Nhuận, TP HCM', '0126678901', 'thithanh@gmail.com'),
--		('KH035', N'Nguyễn Văn Hải', '1999/05/30', N'Nam', N'123 Đường Nguyễn Thị Minh Khai, Quận 1, TP HCM', '0126789012', 'vanhai@gmail.com'),
--		('KH036', N'Phạm Thị Lệ', '2002/03/15', N'Nữ', N'456 Đường Tô Hiến Thành, Quận 10, TP HCM', '0126890123', 'thile@gmail.com'),
--		('KH037', N'Nguyễn Huy Hoàng', '2004/07/22', N'Nam', N'789 Đường số 7, Bình Tân, TP HCM', '0126901234', 'huyhoang@gmail.com'),
--		('KH038', N'Lê Thị Liên', '1996/01/11', N'Nữ', N'321 Nguyễn Văn Cừ, Quận 5, TP HCM', '0127012345', 'thilien@gmail.com'),
--		('KH039', N'Trần Minh Hòa', '1998/09/17', N'Nam', N'654 Trần Bình Trọng, Quận 1, TP HCM', '0127123456', 'minhoa@gmail.com'),
--		('KH040', N'Nguyễn Thị Yến', '2003/11/05', N'Nữ', N'987 Đường 3 tháng 2, Quận 10, TP HCM', '0127234567', 'thiyen@gmail.com'),
--		('KH041', N'Phan Đình Khoa', '2000/12/20', N'Nam', N'123 Đường Lê Quý Đôn, Tân Bình, TP HCM', '0127345678', 'dinhkhoa@gmail.com'),
--		('KH042', N'Nguyễn Thị Đào', '1999/05/25', N'Nữ', N'456 Đường Phan Huy Ích, Gò Vấp, TP HCM', '0127456789', 'thidao@gmail.com'),
--		('KH043', N'Trần Quốc Khánh', '1996/10/30', N'Nam', N'789 Đường Đinh Tiên Hoàng, Bình Thạnh, TP HCM', '0127567890', 'quockhanh@gmail.com'),
--		('KH044', N'Lê Thị Thảo', '2001/02/14', N'Nữ', N'321 Đường Hồ Văn Huê, Phú Nhuận, TP HCM', '0127678901', 'thithao@gmail.com'),
--		('KH045', N'Nguyễn Văn Cường', '2004/08/08', N'Nam', N'654 Đường Nguyễn Thị Thập, Quận 7, TP HCM', '0127789012', 'vancuong@gmail.com'),
--		('KH046', N'Phạm Thị Nguyệt', '1997/06/17', N'Nữ', N'987 Đường Lê Văn Sỹ, Phú Nhuận, TP HCM', '0127890123', 'thinguyet@gmail.com'),
--		('KH047', N'Nguyễn Thiện Hòa', '2000/03/22', N'Nam', N'123 Đường Tôn Đức Thắng, Quận 1, TP HCM', '0127901234', 'thienhoa@gmail.com'),
--		('KH048', N'Trần Thị Đan', '1998/07/09', N'Nữ', N'456 Đường Phú Thọ Hòa, Tân Phú, TP HCM', '0128012345', 'thidan@gmail.com'),
--		('KH049', N'Nguyễn Xuân Huy', '1995/12/12', N'Nam', N'789 Đường Đinh Công Tráng, Quận 5, TP HCM', '0128123456', 'xuanhuy@gmail.com'),
--		('KH050', N'Lê Thị Thùy', '2003/05/14', N'Nữ', N'321 Đường Lê Văn Khương, Hóc Môn, TP HCM', '0128234567', 'thithuy@gmail.com'),
--		('KH051', N'Nguyễn Đình Minh', '1996/09/28', N'Nam', N'654 Đường Sư Vạn Hạnh, Quận 10, TP HCM', '0128345678', 'dinhminh@gmail.com'),
--		('KH052', N'Trần Thị Huyền', '2002/04/05', N'Nữ', N'987 Đường Ngô Thời Nhiệm, Quận 1, TP HCM', '0128456789', 'thihuyen@gmail.com'),
--		('KH053', N'Nguyễn Văn Khải', '1997/11/18', N'Nam', N'123 Đường Hoàng Sa, Quận 3, TP HCM', '0128567890', 'vankhai@gmail.com'),
--		('KH054', N'Lê Thị Kim', '2001/01/30', N'Nữ', N'456 Đường 24 tháng 1, Quận 4, TP HCM', '0128678901', 'thikim@gmail.com'),
--		('KH055', N'Trần Minh Phúc', '2003/08/15', N'Nam', N'789 Đường Trần Não, Quận 2, TP HCM', '0128789012', 'minhphuc@gmail.com'),
--		('KH056', N'Nguyễn Thị Tuyết', '2002/06/12', N'Nữ', N'321 Đường Lê Quý Đôn, Bình Tân, TP HCM', '0128890123', 'thituyet@gmail.com'),
--		('KH057', N'Phạm Hoàng Nam', '1999/03/05', N'Nam', N'654 Đường Hồ Chí Minh, Tân Bình, TP HCM', '0128901234', 'hoangnam@gmail.com'),
--		('KH058', N'Lê Thị Kim Chi', '2000/12/14', N'Nữ', N'987 Đường Trần Quốc Thảo, Quận 1, TP HCM', '0129012345', 'kimchi@gmail.com'),
--		('KH059', N'Nguyễn Hữu Phước', '1998/07/30', N'Nam', N'123 Đường Phan Văn Đạt, Quận 6, TP HCM', '0129123456', 'huuphuoc@gmail.com'),
--		('KH060', N'Trần Thị Bích Ngọc', '2002/05/21', N'Nữ', N'456 Đường Phan Đình Phùng, Phú Nhuận, TP HCM', '0129234567', 'bichngoc@gmail.com'),
--		('KH061', N'Nguyễn Thành Vinh', '2003/01/29', N'Nam', N'789 Đường Nguyễn Thượng Hiền, Quận 10, TP HCM', '0129345678', 'thanhvinh@gmail.com'),
--		('KH062', N'Lê Thị Bảo', '1995/10/10', N'Nữ', N'321 Đường Nguyễn Văn Nghi, Gò Vấp, TP HCM', '0129456789', 'thibao@gmail.com'),
--		('KH063', N'Trần Minh Vũ', '1996/12/18', N'Nam', N'654 Đường 30 tháng 4, Quận 1, TP HCM', '0129567890', 'minhvu@gmail.com'),
--		('KH064', N'Nguyễn Thị Huệ', '2004/03/07', N'Nữ', N'987 Đường Lê Lợi, Quận 5, TP HCM', '0129678901', 'thihue@gmail.com'),
--		('KH065', N'Phạm Hùng Cường', '2001/09/25', N'Nam', N'123 Đường Lê Văn Quới, Bình Tân, TP HCM', '0129789012', 'hungcuong@gmail.com'),
--		('KH066', N'Lê Thị Vân Anh', '1998/11/02', N'Nữ', N'456 Đường Lê Văn Sỹ, Phú Nhuận, TP HCM', '0129890123', 'vananh@gmail.com'),
--		('KH067', N'Trần Thế Anh', '2000/08/09', N'Nam', N'789 Đường Cách Mạng Tháng Tám, Quận 10, TP HCM', '0129901234', 'theanh@gmail.com'),
--		('KH068', N'Nguyễn Thị Hạnh', '1996/02/15', N'Nữ', N'321 Đường Thái Thị Bôi, Quận 6, TP HCM', '0120012345', 'thihanh@gmail.com'),
--		('KH069', N'Phạm Minh Thiên', '2002/04/26', N'Nam', N'654 Đường Trần Phú, Quận 5, TP HCM', '0120123456', 'minhtien@gmail.com'),
--		('KH070', N'Trần Thị Nụ', '2003/06/18', N'Nữ', N'987 Đường số 4, Gò Vấp, TP HCM', '0120234567', 'thinhu@gmail.com'),
--		('KH071', N'Nguyễn Quang Huy', '1995/07/21', N'Nam', N'123 Đường Bùi Thị Xuân, Quận 1, TP HCM', '0120345678', 'quanghuy@gmail.com'),
--		('KH072', N'Lê Thị Nguyệt', '2001/10/05', N'Nữ', N'456 Đường Phan Đăng Lưu, Bình Thạnh, TP HCM', '0120456789', 'thinguye@gmail.com'),
--		('KH073', N'Nguyễn Khải Hoàn', '1999/09/12', N'Nam', N'789 Đường số 6, Quận 10, TP HCM', '0120567890', 'khaihoan@gmail.com'),
--		('KH074', N'Trần Hữu Đức', '2000/05/23', N'Nam', N'321 Đường Phạm Văn Đồng, Thủ Đức, TP HCM', '0120678901', 'huuduc@gmail.com'),
--		('KH075', N'Nguyễn Thị Thủy', '1998/01/02', N'Nữ', N'654 Đường Hòa Bình, Quận 11, TP HCM', '0120789012', 'thithuy@gmail.com'),
--		('KH076', N'Ngô Minh Quân', '1997/03/30', N'Nam', N'987 Đường Bạch Đằng, Quận 1, TP HCM', '0120890123', 'minhquan@gmail.com'),
--		('KH077', N'Lê Thị Tuyền', '2002/08/15', N'Nữ', N'123 Đường Thái Văn Lung, Quận 3, TP HCM', '0120901234', 'thituyen@gmail.com'),
--		('KH078', N'Trần Văn Hưng', '1995/10/22', N'Nam', N'456 Đường Nguyễn Cảnh Chân, Quận 1, TP HCM', '0121012345', 'vanhung@gmail.com'),
--		('KH079', N'Nguyễn Thị Vân Anh', '2000/11/18', N'Nữ', N'789 Đường Trường Chinh, Tân Bình, TP HCM', '0121123456', 'vananh@gmail.com'),
--		('KH080', N'Phạm Văn Hòa', '2004/03/12', N'Nam', N'321 Đường Trần Khánh Dư, Quận 5, TP HCM', '0121234567', 'vanhoa@gmail.com'),
--		('KH081', N'Lê Thị Thanh Bình', '1996/06/15', N'Nữ', N'654 Đường Nguyễn Hữu Cảnh, Bình Thạnh, TP HCM', '0121345678', 'thanhbinh@gmail.com'),
--		('KH082', N'Nguyễn Văn Bằng', '2001/02/10', N'Nam', N'987 Đường Huyền Trân, Quận 7, TP HCM', '0121456789', 'vanbang@gmail.com'),
--		('KH083', N'Trần Thị Quỳnh', '1997/05/01', N'Nữ', N'123 Đường Vạn Kiếp, Bình Thạnh, TP HCM', '0121567890', 'thiquynh@gmail.com'),
--		('KH084', N'Nguyễn Quang Đạt', '2003/08/25', N'Nam', N'456 Đường Đinh Bộ Lĩnh, Bình Thạnh, TP HCM', '0121678901', 'quangdat@gmail.com'),
--		('KH085', N'Lê Thị Thu', '2000/12/03', N'Nữ', N'789 Đường Tôn Đức Thắng, Quận 4, TP HCM', '0121789012', 'thithu@gmail.com'),
--		('KH086', N'Nguyễn Hoàng Bình', '1999/01/20', N'Nam', N'321 Đường Cộng Hòa, Tân Bình, TP HCM', '0121890123', 'hoangbinh@gmail.com'),
--		('KH087', N'Lê Thị Kiều', '1996/09/16', N'Nữ', N'654 Đường Hồng Bàng, Quận 5, TP HCM', '0121901234', 'thikieu@gmail.com'),
--		('KH088', N'Trần Văn Dương', '2002/07/11', N'Nam', N'987 Đường Đinh Tiên Hoàng, Quận 1, TP HCM', '0122012345', 'vandương@gmail.com'),
--		('KH089', N'Nguyễn Thị Mến', '1995/04/24', N'Nữ', N'123 Đường Bình Thạnh, Quận 2, TP HCM', '0122123456', 'thimen@gmail.com'),
--		('KH090', N'Phạm Huy Hải', '2003/10/03', N'Nam', N'456 Đường Sư Vạn Hạnh, Quận 10, TP HCM', '0122234567', 'huyhai@gmail.com'),
--		('KH091', N'Lê Thị Nhã', '2001/06/18', N'Nữ', N'789 Đường Nguyễn Thái Học, Quận 3, TP HCM', '0122345678', 'thinha@gmail.com'),
--		('KH092', N'Nguyễn Văn Phúc', '1998/12/30', N'Nam', N'321 Đường số 10, Tân Bình, TP HCM', '0122456789', 'vanphuc@gmail.com'),
--		('KH093', N'Trần Minh Hiền', '2002/08/25', N'Nữ', N'654 Đường Nguyễn Trãi, Quận 5, TP HCM', '0122567890', 'minhhien@gmail.com'),
--		('KH094', N'Nguyễn Quốc Anh', '1997/05/14', N'Nam', N'987 Đường Nguyễn Văn Cừ, Quận 7, TP HCM', '0122678901', 'quocanh@gmail.com'),
--		('KH095', N'Lê Thị Mỹ Linh', '2000/11/05', N'Nữ', N'123 Đường Nguyễn Công Trứ, Quận 1, TP HCM', '0122789012', 'mylinh@gmail.com'),
--		('KH096', N'Trần Hữu Khải', '1999/03/29', N'Nam', N'456 Đường Đinh Bộ Lĩnh, Quận 3, TP HCM', '0122890123', 'huukhai@gmail.com'),
--		('KH097', N'Nguyễn Thị Hồng', '2004/07/20', N'Nữ', N'789 Đường Hồ Văn Huê, Quận 10, TP HCM', '0122901234', 'thihong@gmail.com'),
--		('KH098', N'Phạm Minh Đức', '1996/10/13', N'Nam', N'321 Đường Phạm Văn Chiêu, Gò Vấp, TP HCM', '0123012345', 'minhduc@gmail.com'),
--		('KH099', N'Lê Thị Hà', '2001/01/30', N'Nữ', N'654 Đường Bến Thành, Quận 1, TP HCM', '0123123456', 'thihà@gmail.com'),
--		('KH100', N'Trần Văn Nam', '2003/12/25', N'Nam', N'987 Đường Phú Mỹ Hưng, Quận 7, TP HCM', '0123234567', 'vannam@gmail.com');
--go
Insert into  KhuyenMai(maKM,tenKM,giamGia,maHH,ngayBD,ngayKT,ghiChu)
values ('KM01',N'Khuyến Mãi 20%',20,null,'07/11/2024','08/11/2024','Thang 11'),('KM03',N'Tặng sách giáo khoa',0,'1907110311401','04/10/2024','08/10/2024','Thang 10')
go


