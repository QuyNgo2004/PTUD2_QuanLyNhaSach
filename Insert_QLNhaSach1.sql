--Insert into  ChiNhanh(maCN,tenCN,diaChi,soDienThoai,email,ghiChu)
--values ('01','Nhà sách Sài Gòn','Sài gòn','09102931','quyngo',''),
--('02','Nhà sách Hà Nội','Hà Nội','09102931','quyngo','')
--go
use QLNhaSach

set dateformat dmy

Insert into  ChucVu(tenChucVu)
values (N'Quản lý'),(N'Nhân Viên')
go


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

--go
--INSERT INTO NhaPhanPhoi (maNPP, tenNPP, diachiNPP, sdtNPP, emailNPP)
--VALUES
--('NPP01', N'Nhà Phân Phối Minh Phát', N'123 Đường Trần Phú, Quận 5, TP.HCM', '0912233445', 'minhphat@company.com'),
--('NPP02', N'Nhà Phân Phối Nam Tiến', N'456 Đường Hoàng Văn Thụ, Phú Nhuận, TP.HCM', '0913344556', 'namtien@company.com'),
--('NPP03', N'Nhà Phân Phối Phú Lộc', N'789 Đường Cách Mạng Tháng 8, Quận 10, TP.HCM', '0914455667', 'phuloc@company.com'),
--('NPP04', N'Nhà Phân Phối An Khang', N'321 Đường Võ Thị Sáu, Quận 3, TP.HCM', '0915566778', 'ankhang@company.com'),
--('NPP05', N'Nhà Phân Phối Thanh Long', N'654 Đường Nguyễn Trãi, Quận 1, TP.HCM', '0916677889', 'thanhlong@company.com'),
--('NPP06', N'Nhà Phân Phối Hưng Thịnh', N'987 Đường Trường Chinh, Tân Bình, TP.HCM', '0917788990', 'hungthinh@company.com'),
--('NPP07', N'Nhà Phân Phối Ngọc Lan', N'111 Đường Lý Tự Trọng, Quận 1, TP.HCM', '0918899001', 'ngoclan@company.com'),
--('NPP08', N'Nhà Phân Phối Thảo Nguyên', N'222 Đường Lê Duẩn, Quận 1, TP.HCM', '0919900112', 'thaonguyen@company.com'),
--('NPP09', N'Nhà Phân Phối Hòa Bình', N'333 Đường Nguyễn Thị Minh Khai, Quận 3, TP.HCM', '0920112233', 'hoabinh@company.com'),
--('NPP10', N'Nhà Phân Phối Đại Nam', N'444 Đường Điện Biên Phủ, Bình Thạnh, TP.HCM', '0921223344', 'dainam@company.com');
go
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
go
insert into KhachHang(maKH, hoTenKH, ngaysinhKH, gioitinhKH, diachiKH, sdtKH, emailKH) values
('KH000', N'Khách vãn lai', '01/01/2000', N'Nam', N'Không có', '0000000000', 'example@gmail.com'),
('KH001', N'Hoàng Văn Duy', '18/07/2005', N'Nam', N'18 Thành Mỹ Lợi, Thủ Đức, TP HCM', '0123467868', 'hoangduy@gmail.com'), 
('KH002', N'Nguyễn Hoàng Nam', '12/03/2002', N'Nam', N'123 Nguyễn Văn Bứa, Bình Chánh, TP HCM', '0123456789', 'namnguyen@gmail.com'), 
('KH003', N'Phạm Minh Khôi', '25/11/1998', N'Nam', N'456 Phú Mỹ Hưng, Quận 7, TP HCM', '0123567890', 'minhkhoi@gmail.com'), 
('KH004', N'Nguyễn Thị Hoa', '05/06/2001', N'Nữ', N'789 Lê Quý Đôn, Quận 3, TP HCM', '0123678901', 'hoanguyen@gmail.com'), 
('KH005', N'Đặng Thế Huy', '30/09/1995', N'Nam', N'321 Nguyễn Thái Bình, Quận 1, TP HCM', '0123789012', 'thehuy@gmail.com'), 
('KH006', N'Nguyễn Hương Giang', '20/04/1999', N'Nữ', N'654 Trần Hưng Đạo, Quận 5, TP HCM', '0123890123', 'huonggiang@gmail.com'), 
('KH007', N'Ngô Minh Tuấn', '15/12/2003', N'Nam', N'987 Trần Nhân Tôn, Quận 10, TP HCM', '0123901234', 'minhtuan@gmail.com'), 
('KH008', N'Nguyễn Thị Hằng', '11/08/2000', N'Nữ', N'123 Tôn Thất Thuyết, Quận 4, TP HCM', '0124012345', 'thihang@gmail.com'), 
('KH009', N'Nguyễn Văn Tâm', '22/05/1996', N'Nam', N'456 Đường Lê Lợi, Quận 1, TP HCM', '0124123456', 'vantam@gmail.com'), 
('KH010', N'Phan Thị Ngọc', '02/01/2004', N'Nữ', N'789 Đường Bạch Đằng, Bình Thạnh, TP HCM', '0124234567', 'thinhoc@gmail.com'), 
('KH011', N'Nguyễn Đình Sơn', '28/02/1997', N'Nam', N'321 Đường Nguyễn Tất Thành, Quận 4, TP HCM', '0124345678', 'dinhson@gmail.com'), 
('KH012', N'Trần Hoàng Yến', '19/07/2002', N'Nữ', N'654 Lê Văn Sỹ, Phú Nhuận, TP HCM', '0124456789', 'hoangyen@gmail.com'), 
('KH013', N'Nguyễn Văn An', '09/09/2000', N'Nam', N'789 Lê Hồng Phong, Quận 10, TP HCM', '0124567890', 'vanan@gmail.com'), 
('KH014', N'Vũ Thị Mai', '30/06/1998', N'Nữ', N'321 Trường Chinh, Tân Bình, TP HCM', '0124678901', 'thimai@gmail.com'), 
('KH015', N'Nguyễn Tiến Dũng', '15/04/1995', N'Nam', N'654 Nguyễn Văn Cừ, Quận 5, TP HCM', '0124789012', 'tiendung@gmail.com'), 
('KH016', N'Phạm Thị Lành', '10/03/2003', N'Nữ', N'987 Lê Thị Hồng Gấm, Quận 1, TP HCM', '0124890123', 'thilanh@gmail.com'), 
('KH017', N'Đỗ Minh Trí', '07/10/2001', N'Nam', N'123 Đinh Tiên Hoàng, Bình Thạnh, TP HCM', '0124901234', 'minhtri@gmail.com'), 
('KH018', N'Nguyễn Thị Nhi', '25/11/2002', N'Nữ', N'456 Phan Đăng Lưu, Phú Nhuận, TP HCM', '0125012345', 'thinhi@gmail.com'), 
('KH019', N'Trần Quang Hưng', '15/12/1999', N'Nam', N'789 Hoàng Văn Thụ, Tân Bình, TP HCM', '0125123456', 'quanghung@gmail.com'), 
('KH020', N'Lê Thị Như', '30/08/2000', N'Nữ', N'321 Lê Duẩn, Quận 1, TP HCM', '0125234567', 'nhu@gmail.com'), 
('KH021', N'Nguyễn Hoàng Anh', '01/01/1996', N'Nam', N'654 Trần Quốc Toản, Quận 3, TP HCM', '0125345678', 'hoanganh@gmail.com'), 
('KH022', N'Ngô Thị Vân', '06/05/2004', N'Nữ', N'987 Nguyễn Thái Học, Quận 10, TP HCM', '0125456789', 'thivan@gmail.com'), 
('KH023', N'Vũ Minh Hiếu', '12/07/1997', N'Nam', N'123 Trường Sa, Bình Thạnh, TP HCM', '0125567890', 'minhhieu@gmail.com'), 
('KH024', N'Phạm Thị Bích', '22/02/1998', N'Nữ', N'456 Nguyễn Thượng Hiền, Quận 1, TP HCM', '0125678901', 'thibich@gmail.com'), 
('KH025', N'Trần Văn Long', '19/03/1995', N'Nam', N'789 Đường Huyền Trân Công Chúa, Quận 5, TP HCM', '0125789012', 'vanlong@gmail.com'), 
('KH026', N'Nguyễn Thị Ngọc Bích', '29/06/2001', N'Nữ', N'321 Đường số 10, Gò Vấp, TP HCM', '0125890123', 'ngocbich@gmail.com'), 
('KH027', N'Lê Đình Phúc', '18/12/1999', N'Nam', N'654 Đường Bùi Viện, Quận 1, TP HCM', '0125901234', 'dinhphuc@gmail.com'), 
('KH028', N'Trần Thị Phương', '11/10/2000', N'Nữ', N'987 Phan Văn Trị, Gò Vấp, TP HCM', '0126012345', 'thiphuong@gmail.com'), 
('KH029', N'Nguyễn Tiến Đạt', '05/04/1998', N'Nam', N'123 Trần Quốc Thảo, Quận 3, TP HCM', '0126123456', 'tiendat@gmail.com'), 
('KH030', N'Nguyễn Thị Tươi', '01/09/2002', N'Nữ', N'456 Đường số 5, Bình Thạnh, TP HCM', '0126234567', 'thitui@gmail.com'), 
('KH031', N'Trần Văn Thắng', '20/08/2003', N'Nam', N'789 Nguyễn Kiệm, Phú Nhuận, TP HCM', '0126345678', 'vanthang@gmail.com'), 
('KH032', N'Nguyễn Thị Nhung', '15/11/1997', N'Nữ', N'321 Lê Trọng Tấn, Tân Bình, TP HCM', '0126456789', 'thinhu@gmail.com'), 
('KH033', N'Ngô Minh Sang', '12/02/2000', N'Nam', N'654 Lê Văn Lương, Quận 7, TP HCM', '0126567890', 'minhsang@gmail.com'), 
('KH034', N'Trần Thị Thanh', '25/04/2001', N'Nữ', N'987 Đường Huỳnh Văn Bánh, Phú Nhuận, TP HCM', '0126678901', 'thithanh@gmail.com'), 
('KH035', N'Nguyễn Văn Hải', '30/05/1999', N'Nam', N'123 Đường Nguyễn Thị Minh Khai, Quận 1, TP HCM', '0126789012', 'vanhai@gmail.com'), 
('KH036', N'Vũ Thị Tuyết', '22/09/2003', N'Nữ', N'456 Đường Phú Thọ Hòa, Tân Phú, TP HCM', '0126890123', 'thituyet@gmail.com'), 
('KH037', N'Nguyễn Xuân Hòa', '14/06/2002', N'Nam', N'789 Đường Trần Khánh Dư, Quận 5, TP HCM', '0126901234', 'xuanhoa@gmail.com'), 
('KH038', N'Phạm Minh Tuấn', '03/03/1998', N'Nam', N'321 Đường Bạch Đằng, Bình Thạnh, TP HCM', '0127012345', 'minhtuan@gmail.com'), 
('KH039', N'Nguyễn Thị Hồng', '08/12/2000', N'Nữ', N'654 Đường Cách Mạng Tháng Tám, Quận 10, TP HCM', '0127123456', 'thihong@gmail.com'), 
('KH040', N'Trần Ngọc Bích', '11/01/1996', N'Nữ', N'987 Đường Võ Văn Kiệt, Quận 1, TP HCM', '0127234567', 'ngocbich@gmail.com'),
('KH041', N'Nguyễn Văn Đức', '21/08/1999', N'Nam', N'123 Đường Lê Quý Đôn, Quận 3, TP HCM', '0127345678', 'vanduc@gmail.com'), 
('KH042', N'Ngô Thị Bích', '10/05/2001', N'Nữ', N'456 Đường Nguyễn Huệ, Quận 1, TP HCM', '0127456789', 'thibich@gmail.com'), 
('KH043', N'Trần Minh Khoa', '04/09/2000', N'Nam', N'789 Đường Nguyễn Thái Bình, Quận 5, TP HCM', '0127567890', 'minkhoa@gmail.com'), 
('KH044', N'Phạm Thị Lan', '28/02/1998', N'Nữ', N'321 Đường Đinh Tiên Hoàng, Quận Bình Thạnh, TP HCM', '0127678901', 'thilan@gmail.com'), 
('KH045', N'Nguyễn Hoàng Bảo', '19/12/1996', N'Nam', N'654 Đường Lê Văn Sĩ, Phú Nhuận, TP HCM', '0127789012', 'hoangbao@gmail.com'), 
('KH046', N'Vũ Thị Thảo', '15/10/2002', N'Nữ', N'987 Đường Lê Thị Hồng Gấm, Quận 1, TP HCM', '0127890123', 'thithao@gmail.com'), 
('KH047', N'Nguyễn Đức Anh', '30/07/1997', N'Nam', N'123 Đường Hồng Bàng, Quận 5, TP HCM', '0127901234', 'ducanh@gmail.com'), 
('KH048', N'Trần Thị Vân', '08/04/1995', N'Nữ', N'456 Đường Lê Văn Chí, Thủ Đức, TP HCM', '0128012345', 'thivan@gmail.com'), 
('KH049', N'Ngô Thanh Tùng', '12/11/2000', N'Nam', N'789 Đường Hoàng Văn Thụ, Tân Bình, TP HCM', '0128123456', 'thanhtung@gmail.com'), 
('KH050', N'Nguyễn Thị Ly', '21/01/2003', N'Nữ', N'321 Đường Số 7, Bình Thạnh, TP HCM', '0128234567', 'thily@gmail.com'), 
('KH051', N'Trần Ngọc Hải', '05/06/1999', N'Nam', N'654 Đường Trần Hưng Đạo, Quận 1, TP HCM', '0128345678', 'ngochai@gmail.com'), 
('KH052', N'Phạm Minh Hòa', '22/03/1996', N'Nam', N'987 Đường Võ Văn Tần, Quận 3, TP HCM', '0128456789', 'minhhoa@gmail.com'), 
('KH053', N'Nguyễn Thị Diễm', '17/05/2002', N'Nữ', N'123 Đường Tân Hòa Đông, Bình Tân, TP HCM', '0128567890', 'thidiem@gmail.com'), 
('KH054', N'Vũ Quốc Toàn', '30/08/2001', N'Nam', N'456 Đường Phạm Văn Hai, Tân Bình, TP HCM', '0128678901', 'quoctoan@gmail.com'), 
('KH055', N'Trần Thị Tuyết', '12/04/1998', N'Nữ', N'789 Đường Bùi Thị Xuân, Quận 1, TP HCM', '0128789012', 'thituyet@gmail.com'), 
('KH056', N'Nguyễn Minh Thi', '23/11/1997', N'Nữ', N'321 Đường Quốc Lộ 13, Thủ Đức, TP HCM', '0128890123', 'minhthi@gmail.com'), 
('KH057', N'Trần Văn Tài', '07/10/1999', N'Nam', N'654 Đường Nam Kỳ Khởi Nghĩa, Quận 1, TP HCM', '0128901234', 'vantai@gmail.com'), 
('KH058', N'Nguyễn Thị Thanh Hương', '01/03/2002', N'Nữ', N'987 Đường Điện Biên Phủ, Bình Thạnh, TP HCM', '0129012345', 'thanhhuong@gmail.com'), 
('KH059', N'Vũ Hồng Quân', '26/09/1998', N'Nam', N'123 Đường Cách Mạng Tháng Tám, Quận 10, TP HCM', '0129123456', 'hongquan@gmail.com'), 
('KH060', N'Trần Minh Châu', '15/01/2000', N'Nữ', N'456 Đường Lê Trọng Tấn, Tân Bình, TP HCM', '0129234567', 'minhchau@gmail.com'), 
('KH061', N'Nguyễn Thanh Sơn', '21/06/2001', N'Nam', N'789 Đường Lê Đại Hành, Quận 11, TP HCM', '0129345678', 'thanhson@gmail.com'), 
('KH062', N'Phạm Thị Phương Thảo', '02/12/1999', N'Nữ', N'321 Đường Số 6, Bình Thạnh, TP HCM', '0129456789', 'phuongthao@gmail.com'), 
('KH063', N'Ngô Minh Quân', '28/02/1997', N'Nam', N'654 Đường Lê Quý Đôn, Tân Bình, TP HCM', '0129567890', 'minhquan@gmail.com'), 
('KH064', N'Trần Thị Kiều', '10/05/2003', N'Nữ', N'987 Đường Nguyễn Văn Khối, Gò Vấp, TP HCM', '0129678901', 'thikieu@gmail.com'), 
('KH065', N'Nguyễn Văn Kiên', '09/04/1996', N'Nam', N'123 Đường Bình Quới, Bình Thạnh, TP HCM', '0129789012', 'vankien@gmail.com'), 
('KH066', N'Phạm Thị Mỹ', '04/01/2000', N'Nữ', N'456 Đường Ngô Đức Kế, Quận 1, TP HCM', '0129890123', 'thimy@gmail.com'), 
('KH067', N'Vũ Đình Luân', '22/03/1998', N'Nam', N'789 Đường Nguyễn Thái Bình, Quận 5, TP HCM', '0129901234', 'dinhluan@gmail.com'), 
('KH068', N'Nguyễn Thị Xuân', '10/12/2001', N'Nữ', N'321 Đường Trần Khánh Dư, Quận 1, TP HCM', '0129012345', 'thixuan@gmail.com'), 
('KH069', N'Trần Thanh Sang', '30/08/1999', N'Nam', N'654 Đường Phan Văn Trị, Gò Vấp, TP HCM', '0129123456', 'thanhsang@gmail.com'), 
('KH070', N'Nguyễn Hữu Trí', '05/11/1997', N'Nam', N'987 Đường Nam Kỳ Khởi Nghĩa, Quận 3, TP HCM', '0129234567', 'huutri@gmail.com'), 
('KH071', N'Trần Thị Hòa', '19/05/1996', N'Nữ', N'123 Đường Trần Quốc Thảo, Quận 3, TP HCM', '0129345678', 'thihoa@gmail.com'), 
('KH072', N'Nguyễn Văn Hùng', '27/07/2002', N'Nam', N'456 Đường Bạch Đằng, Bình Thạnh, TP HCM', '0129456789', 'vanhung@gmail.com'), 
('KH073', N'Vũ Thị Ngọc', '15/09/2001', N'Nữ', N'789 Đường Nguyễn Văn Đậu, Bình Thạnh, TP HCM', '0129567890', 'thingoc@gmail.com'), 
('KH074', N'Trần Minh Nhật', '09/06/2003', N'Nam', N'321 Đường số 12, Quận 2, TP HCM', '0129678901', 'minhnhat@gmail.com'), 
('KH075', N'Nguyễn Thị Hạnh', '20/10/1998', N'Nữ', N'654 Đường Phú Thọ Hòa, Tân Phú, TP HCM', '0129789012', 'thihanh@gmail.com'), 
('KH076', N'Phạm Văn Duy', '11/03/1995', N'Nam', N'987 Đường Hòa Bình, Tân Phú, TP HCM', '0129890123', 'vanduy@gmail.com'), 
('KH077', N'Nguyễn Hoàng Nhân', '24/01/1999', N'Nam', N'123 Đường Ngô Tất Tố, Bình Thạnh, TP HCM', '0129901234', 'hoangnhan@gmail.com'), 
('KH078', N'Trần Thị Diễm', '07/11/2000', N'Nữ', N'456 Đường 3/2, Quận 10, TP HCM', '0129012345', 'thidien@gmail.com'), 
('KH079', N'Ngô Thái Bình', '30/08/2002', N'Nam', N'789 Đường Nguyễn Hữu Cảnh, Bình Thạnh, TP HCM', '0129123456', 'thaibinh@gmail.com'), 
('KH080', N'Nguyễn Minh Kha', '12/12/1996', N'Nam', N'321 Đường Trần Phú, Quận 5, TP HCM', '0129234567', 'minhkha@gmail.com'), 
('KH081', N'Trần Thị Thủy', '19/04/1998', N'Nữ', N'654 Đường Lê Quý Đôn, Quận 3, TP HCM', '0129345678', 'thuy@gmail.com'), 
('KH082', N'Nguyễn Văn Tiến', '27/05/2001', N'Nam', N'987 Đường Võ Văn Kiệt, Quận 1, TP HCM', '0129456789', 'vantiend@gmail.com'), 
('KH083', N'Phạm Thị Nhan', '10/10/2000', N'Nữ', N'123 Đường Lê Văn Lương, Nhà Bè, TP HCM', '0129567890', 'thinhan@gmail.com'), 
('KH084', N'Vũ Thế Sơn', '06/06/1999', N'Nam', N'456 Đường Số 8, Tân Phú, TP HCM', '0129678901', 'thesonn@gmail.com'), 
('KH085', N'Trần Văn Bình', '25/03/1997', N'Nam', N'789 Đường Trần Văn Đang, Quận 3, TP HCM', '0129789012', 'vanbinh@gmail.com'), 
('KH086', N'Nguyễn Thị Bình', '18/09/2002', N'Nữ', N'321 Đường Cách Mạng Tháng Tám, Quận 10, TP HCM', '0129890123', 'thibinh@gmail.com'), 
('KH087', N'Ngô Văn Hạnh', '30/01/2001', N'Nam', N'654 Đường Bùi Thị Xuân, Quận 1, TP HCM', '0129901234', 'vanhanh@gmail.com'), 
('KH088', N'Trần Thị Thúy', '09/05/2003', N'Nữ', N'987 Đường Phạm Ngũ Lão, Quận 1, TP HCM', '0129012345', 'thithuy@gmail.com'), 
('KH089', N'Nguyễn Hữu Phúc', '14/07/1998', N'Nam', N'123 Đường Nguyễn Văn Lượng, Gò Vấp, TP HCM', '0129123456', 'huuphu@gmail.com'), 
('KH090', N'Phạm Thị Thúy', '12/12/1996', N'Nữ', N'456 Đường Lê Trọng Tấn, Tân Bình, TP HCM', '0129234567', 'thithuy123@gmail.com'), 
('KH091', N'Vũ Văn Hiệp', '20/04/1997', N'Nam', N'789 Đường Bình Giã, Tân Bình, TP HCM', '0129345678', 'vanhiep@gmail.com'), 
('KH092', N'Trần Ngọc Khánh', '22/11/2001', N'Nữ', N'321 Đường Đinh Tiên Hoàng, Quận 1, TP HCM', '0129456789', 'ngockhanh@gmail.com'), 
('KH093', N'Nguyễn Văn Minh', '30/10/2000', N'Nam', N'654 Đường Phan Đăng Lưu, Bình Thạnh, TP HCM', '0129567890', 'vanminh@gmail.com'), 
('KH094', N'Ngô Thị Vân', '03/08/1999', N'Nữ', N'987 Đường Lê Hồng Phong, Quận 10, TP HCM', '0129678901', 'thivan@gmail.com'), 
('KH095', N'Trần Minh Thắng', '15/06/1998', N'Nam', N'123 Đường Hùng Vương, Quận 5, TP HCM', '0129789012', 'minhthang@gmail.com'), 
('KH096', N'Nguyễn Thị Bảo', '01/01/2002', N'Nữ', N'456 Đường Số 10, Tân Phú, TP HCM', '0129890123', 'thibao@gmail.com'), 
('KH097', N'Vũ Văn Hòa', '25/12/1996', N'Nam', N'789 Đường Hoàng Sa, Quận 1, TP HCM', '0129012345', 'vanhoa@gmail.com'), 
('KH098', N'Trần Thị Lệ', '04/09/2003', N'Nữ', N'321 Đường Hòa Bình, Quận 11, TP HCM', '0129123456', 'thile@gmail.com'), 
('KH099', N'Nguyễn Hữu Nghĩa', '17/03/2000', N'Nam', N'654 Đường Nguyễn Thị Minh Khai, Quận 1, TP HCM', '0129234567', 'huunghia@gmail.com'), 
('KH100', N'Trần Thị Lộc', '29/07/1998', N'Nữ', N'987 Đường Trần Hưng Đạo, Quận 5, TP HCM', '0129345678', 'thiloc@gmail.com');
go
insert into LoaiHangHoa(maLHH, tenLHH, ghiChu) values
('LHH01',N'Sách giáo khoa',N'Sách từ cấp tiểu học đến trung học phổ thông.'),
('LHH02',N'Sách tài liệu tham khảo',N'Sách ôn thi, sách bổ trợ cho các môn học.'),
('LHH03',N'Sách ngoại ngữ',N'Sách học các môn ngoại ngữ.'),
('LHH04',N'Sách kỹ năng sống',N'Sách phát triển bản thân, kỹ năng giao tiếp.'),
('LHH05',N'Sách văn học',N'Tiểu thuyết, truyện ngắn, thơ, văn học Việt Nam và nước ngoài.'),
('LHH06',N'Sách khoa học',N'Sách khoa học phổ thông, khoa học ứng dụng.'),
('LHH07',N'Sách thiếu nhi',N'Sách cho trẻ em như truyện tranh, sách tô màu.'),
('LHH08',N'Sách từ điển',N'Sách từ điển của nhiều ngôn ngữ khác nhau.'),
('LHH09',N'Văn phòng phẩm',N'Bút, sổ tay, giấy viết, dụng cụ học tập khác.'),
('LHH10',N'Đồ chơi giáo dục',N'Đồ chơi hỗ trợ phát triển trí tuệ, tư duy cho trẻ.'),
('LHH11',N'Đồ lưu niệm',N'Các sản phẩm trang trí, quà tặng nhỏ.');
go

insert into HangHoa(maHH, maLHH, tenHH, giaHH, donViTinh, soLuongTon, maNPP, tacGia, moTa, ghiChu, tinhTrang) values
---sach giao khoa.
('1107112400001','LHH01',N'Bộ sách giáo khoa lớp 1',115000,N'Bộ',46,'NPP11','',N'Sách giáo khoa cấp 1 - Lớp 1',N'Không bán lẻ',N'Còn hàng'),
('1107112400002','LHH01',N'Bộ sách giáo khoa lớp 2',120000,N'Bộ',13,'NPP11','',N'Sách giáo khoa cấp 1 - Lớp 2',N'Không bán lẻ',N'Còn hàng'),
('1207112400003','LHH01',N'Bộ sách giáo khoa lớp 3',127000,N'Bộ',27,'NPP12','',N'Sách giáo khoa cấp 1 - Lớp 3',N'Không bán lẻ',N'Còn hàng'),
('1207112400004','LHH01',N'Bộ sách giáo khoa lớp 4',139000,N'Bộ',36,'NPP12','',N'Sách giáo khoa cấp 1 - Lớp 4',N'Không bán lẻ',N'Còn hàng'),
('1307112400005','LHH01',N'Bộ sách giáo khoa lớp 5',165000,N'Bộ',44,'NPP13','',N'Sách giáo khoa cấp 1 - Lớp 5',N'Không bán lẻ',N'Còn hàng'),
('1307112400006','LHH01',N'Bộ sách giáo khoa lớp 6',198000,N'Bộ',35,'NPP13','',N'Sách giáo khoa cấp 2 - Lớp 6',N'Không bán lẻ',N'Còn hàng'),
('1407112400007','LHH01',N'Bộ sách giáo khoa lớp 7',203000,N'Bộ',28,'NPP14','',N'Sách giáo khoa cấp 2 - Lớp 7',N'Không bán lẻ',N'Còn hàng'),
('1407112400008','LHH01',N'Bộ sách giáo khoa lớp 8',213000,N'Bộ',23,'NPP14','',N'Sách giáo khoa cấp 2 - Lớp 8',N'Không bán lẻ',N'Còn hàng'),
('1507112400009','LHH01',N'Bộ sách giáo khoa lớp 9',231000,N'Bộ',38,'NPP15','',N'Sách giáo khoa cấp 2 - Lớp 9',N'Không bán lẻ',N'Còn hàng'),
('1507112400010','LHH01',N'Bộ sách giáo khoa lớp 10',241000,N'Bộ',15,'NPP15','',N'Sách giáo khoa cấp 3 - Lớp 10',N'Không bán lẻ',N'Còn hàng'),
('1607112400011','LHH01',N'Bộ sách giáo khoa lớp 11',265000,N'Bộ',41,'NPP16','',N'Sách giáo khoa cấp 3 - Lớp 11',N'Không bán lẻ',N'Còn hàng'),
('1607112400012','LHH01',N'Bộ sách giáo khoa lớp 12',270000,N'Bộ',19,'NPP16','',N'Sách giáo khoa cấp 3 - Lớp 12',N'Không bán lẻ',N'Còn hàng'),
---sach tham khao.
('1117112400013','LHH02',N'Lược sử loài người',180000,N'Cuốn',46,'NPP11','Yuval Noah Harari',N'Cuốn sách này cung cấp cái nhìn tổng quan về lịch sử loài người','',N'Còn hàng'),
('1117112400014','LHH02',N'Thói quen tạo nên sự thay đổi',150000,N'Cuốn',13,'NPP11','James Clear',N'Cuốn sách chia sẻ về cách xây dựng thói quen nhỏ nhưng hiệu quả giúp thay đổi cuộc sống','',N'Còn hàng'),
('1217112400015','LHH02',N'Thinking, Fast and Slow',220000,N'Cuốn',27,'NPP12','Daniel Kahneman',N'Daniel Kahneman, nhà tâm lý học và người đoạt giải Nobel, chia sẻ về hai hệ thống tư duy trong não bộ','',N'Còn hàng'),
('1217112400016','LHH02',N'Thực tại của hiện tại',170000,N'Cuốn',36,'NPP12','Eckhart Tolle',N'Cuốn sách này khám phá tầm quan trọng của việc sống trong khoảnh khắc hiện tại và làm sao để thoát khỏi những suy nghĩ về quá khứ và tương lai.','',N'Còn hàng'),
('1317112400017','LHH02',N'Những người thành công vượt trội',180000,N'Cuốn',44,'NPP13','Malcolm Gladwell',N'Cuốn sách đưa ra một cái nhìn sâu sắc về thành công.','',N'Còn hàng'),
('1317112400018','LHH02',N'Tự học',200000,N'Cuốn',35,'NPP13','Tara Westover',N'Cuốn sách là một minh chứng cho sức mạnh của sự kiên trì và khát khao học hỏi.','',N'Hết hàng'),
('1417112400019','LHH02',N'Nghệ thuật tinh tế của việc đếch quan tâm',160000,N'Cuốn',28,'NPP14','Mark Manson',N'Mark Manson chia sẻ quan điểm sống thực tế và đôi khi thẳng thắn.','',N'Còn hàng'),
('1417112400020','LHH02',N'Bốn thỏa thuận',210000,N'Cuốn',23,'NPP14','Don Miguel Ruiz',N'Cuốn sách này đưa ra bốn nguyên lý sống giúp con người sống hạnh phúc và tự do hơn','',N'Còn hàng'),
('1517112400021','LHH02',N'Giáo dục người hành nghề tư duy phản xạ',130000,N'Cuốn',38,'NPP15','Donald A Schon',N'Cuốn sách này nói về quá trình học hỏi và phát triển kỹ năng chuyên môn thông qua việc phản ánh và suy ngẫm về công việc thực tế.','',N'Còn hàng'),
('1517112400022','LHH02',N'Nhà giả kim',250000,N'Cuốn',15,'NPP15','Paulo Coelho',N'Cuốn tiểu thuyết nổi tiếng của Paulo Coelho kể về hành trình của một cậu bé chăn cừu tên Santiago tìm kiếm kho báu.','',N'Còn hàng'),
('1617112400023','LHH02',N'Con đường',120000,N'Cuốn',41,'NPP16','Cormac McCarthy',N'Một cuốn tiểu thuyết đen tối và xúc động về hành trình của một người cha và cậu con trai trong thế giới hậu tận thế.','',N'Hết hàng'),
('1617112400024','LHH02',N'Nghệ thuật chiến tranh',190000,N'Cuốn',19,'NPP16','Sun Tzu',N'Cuốn sách cổ điển này của Sun Tzu là một tác phẩm chiến lược nổi tiếng','',N'Còn hàng'),
---sach ngoai ngu.
('1117112400025', 'LHH03', N'English Grammar in Use', 300000, N'Cuốn', 100, 'NPP11', N'Raymond Murphy', N'Cuốn sách tự học ngữ pháp tiếng Anh dành cho người học ở mọi trình độ, với các bài tập thực hành chi tiết.', N'Giới thiệu về ngữ pháp cơ bản đến nâng cao', N'Còn hàng'),
('1117112400026', 'LHH03', N'To Kill a Mockingbird', 200000, N'Cuốn', 50, 'NPP11', N'Harper Lee', N'Một cuốn tiểu thuyết kinh điển của Mỹ, xoay quanh câu chuyện về phân biệt chủng tộc và công lý.', N'Khám phá sâu về xã hội Mỹ những năm 1930', N'Còn hàng'),
('1217112400027', 'LHH03', N'Advanced Language Practice', 350000, N'Cuốn', 30, 'NPP12', N'Michael Vince', N'Cuốn sách này giúp học viên nâng cao khả năng sử dụng ngữ pháp và từ vựng tiếng Anh ở mức độ nâng cao.', N'Chuyên sâu về ngữ pháp và từ vựng', N'Còn hàng'),
('1217112400028', 'LHH03', N'1984', 250000, N'Cuốn', 40, 'NPP12', N'George Orwell', N'Tiểu thuyết dystopian mô tả một thế giới tương lai đầy áp bức, giám sát và kiểm soát xã hội.', N'Phân tích sự giám sát và kiểm soát trong xã hội', N'Còn hàng'),
('1317112400029', 'LHH03', N'Verity', 320000, N'Cuốn', 20, 'NPP13', N'Colleen Hoover', N'Một câu chuyện lãng mạn kết hợp yếu tố bí ẩn, hấp dẫn người đọc với những tình tiết gay cấn.', N'Khám phá sự thật đằng sau một câu chuyện tình yêu', N'Còn hàng'),
('1317112400030', 'LHH03', N'Pride and Prejudice', 180000, N'Cuốn', 80, 'NPP13', N'Jane Austen', N'Cuốn tiểu thuyết lãng mạn nổi tiếng, phân tích những xung đột giữa các tầng lớp xã hội và tình yêu trong xã hội Anh.', N'Một câu chuyện tình yêu nổi tiếng', N'Còn hàng'),
('1417112400031', 'LHH03', N'One Hundred Years of Solitude', 350000, N'Cuốn', 100, 'NPP14', N'Gabriel Garcia Marquez', N'Một tác phẩm vĩ đại của văn học Latin America, kể về lịch sử và truyền thống của một gia đình qua các thế hệ.', N'Tiểu thuyết mang đậm ảnh hưởng văn hóa Latin', N'Còn hàng'),
('1417112400032', 'LHH03', N'The Catcher in the Rye', 220000, N'Cuốn', 70, 'NPP14', N'J.D. Salinger', N'Một câu chuyện đầy tính triết lý về tuổi trưởng thành, cô đơn và sự khủng hoảng của một thiếu niên.', N'Khám phá tâm lý và sự khủng hoảng tuổi mới lớn', N'Còn hàng'),
('1517112400033', 'LHH03', N'The Great Gatsby', 250000, N'Cuốn', 90, 'NPP15', N'F. Scott Fitzgerald', N'Tiểu thuyết nổi tiếng của Mỹ về cuộc sống xa hoa nhưng đầy bi kịch trong thời kỳ "Jazz Age".', N'Một câu chuyện về sự tan vỡ của giấc mơ Mỹ', N'Còn hàng'),
('1517112400034', 'LHH03', N'The Little Prince', 150000, N'Cuốn', 120, 'NPP15', N'Antoine de Saint-Exupéry', N'Cuốn sách mang tính triết lý này kể về hành trình của một hoàng tử nhỏ từ hành tinh khác.', N'Một câu chuyện đầy tính nhân văn', N'Còn hàng'),
('1617112400035', 'LHH03', N'Brida', 280000, N'Cuốn', 60, 'NPP16', N'Paulo Coelho', N'Một câu chuyện về hành trình tự tìm kiếm bản thân và khám phá sức mạnh tiềm ẩn bên trong mỗi người.', N'Khám phá sự kết nối giữa tình yêu và sự huyền bí', N'Còn hàng'),
('1617112400036', 'LHH03', N'Big Magic', 290000, N'Cuốn', 50, 'NPP16', N'Elizabeth Gilbert', N'Cuốn sách này khuyến khích bạn sống một cuộc đời đầy cảm hứng và sáng tạo, khám phá sức mạnh của sự sáng tạo trong công việc và cuộc sống.', N'Tìm kiếm sự sáng tạo trong cuộc sống', N'Còn hàng'),
---sach ky nang song.
('1117112400037', 'LHH04', N'Khám Phá Tâm Lý Học', 180000, N'Cuốn', 100, 'NPP11', N'Đặng Hoàng Giang', N'Cuốn sách này giúp người đọc hiểu rõ về tâm lý học trong cuộc sống và các tình huống xã hội, từ đó áp dụng vào công việc và các mối quan hệ.', N'Phát triển hiểu biết về tâm lý học và áp dụng trong cuộc sống', N'Còn hàng'),
('1117112400038', 'LHH04', N'Con Đường Phía Trước', 250000, N'Cuốn', 80, 'NPP11', N'Nguyễn Hồng Quang', N'Cuốn sách này chia sẻ về những nguyên tắc sống và chiến lược thành công từ góc nhìn của một người đã trải qua nhiều thử thách trong cuộc đời.', N'Khám phá cách sống tích cực và đối diện với khó khăn', N'Còn hàng'),
('1217112400039', 'LHH04', N'Đánh Thức Con Người Phi Thường Trong Bạn', 220000, N'Cuốn', 120, 'NPP12', N'Nguyễn Thái Dương', N'Một cuốn sách giúp bạn nhận ra tiềm năng ẩn giấu trong bản thân và cách thức phát triển bản thân để đạt được mục tiêu lớn.', N'Tìm kiếm và phát huy tiềm năng bản thân', N'Còn hàng'),
('1217112400040', 'LHH04', N'Kỹ Năng Quản Lý Thời Gian', 200000, N'Cuốn', 90, 'NPP12', N'Võ Hồng Quang', N'Cuốn sách này cung cấp những phương pháp đơn giản nhưng hiệu quả trong việc quản lý thời gian.', N'Cải thiện kỹ năng quản lý thời gian', N'Còn hàng'),
('1317112400041', 'LHH04', N'Bạn Đã Sẵn Sàng Chưa?', 230000, N'Cuốn', 70, 'NPP13', N'Nguyễn Phương Mai', N'Cuốn sách này giúp bạn chuẩn bị tâm lý và phát triển thói quen tích cực để bắt đầu những thay đổi lớn trong cuộc đời.', N'Hướng dẫn bắt đầu thay đổi cuộc sống và phát triển bản thân', N'Còn hàng'),
('1317112400042', 'LHH04', N'Những Điều Cần Biết Về Bản Thân', 210000, N'Cuốn', 110, 'NPP13', N'Hoàng Minh Tâm', N'Cuốn sách này giúp người đọc nhận diện bản thân, khám phá những đặc điểm nổi bật của mình để tự tin hơn trong giao tiếp và công việc.', N'Khám phá bản thân và phát triển kỹ năng cá nhân', N'Còn hàng'),
('1417112400043', 'LHH04', N'Giải Mã Tư Duy Thành Công', 250000, N'Cuốn', 60, 'NPP14', N'Trần Đình Hoàng', N'Cuốn sách này chia sẻ các chiến lược và phương pháp tư duy giúp bạn trở thành một người thành công trong công việc và cuộc sống.', N'Phát triển tư duy thành công và áp dụng trong công việc', N'Còn hàng'),
('1417112400044', 'LHH04', N'Chiến Lược Sống Tích Cực', 240000, N'Cuốn', 50, 'NPP14', N'Phan Đức Tuấn', N'Cuốn sách này sẽ hướng dẫn bạn cách sống tích cực, cải thiện sức khỏe tinh thần và xây dựng mối quan hệ tốt đẹp với mọi người xung quanh.', N'Tạo ra một cuộc sống tích cực và khỏe mạnh', N'Còn hàng'),
('1517112400045', 'LHH04', N'Khơi Dậy Sức Mạnh Nội Tại', 280000, N'Cuốn', 90, 'NPP15', N'Nguyễn Minh Hằng', N'Cuốn sách giúp bạn khai thác sức mạnh bên trong mình, phát huy tối đa năng lực cá nhân để đạt được thành công trong công việc và cuộc sống.', N'Khám phá và phát huy sức mạnh nội tại của bản thân', N'Còn hàng'),
('1517112400046', 'LHH04', N'Chìa Khóa Thành Công', 260000, N'Cuốn', 100, 'NPP15', N'Nguyễn Hoàng Sơn', N'Cuốn sách này cung cấp các phương pháp giúp bạn đạt được thành công bền vững trong cả sự nghiệp và cuộc sống cá nhân.', N'Tìm hiểu các yếu tố then chốt dẫn đến thành công', N'Còn hàng'),
('1617112400047', 'LHH04', N'Người Lãnh Đạo Đúng Nghĩa', 320000, N'Cuốn', 80, 'NPP16', N'Đoàn Ngọc Khánh', N'Cuốn sách này giới thiệu những phẩm chất cần có của một nhà lãnh đạo xuất sắc, và cách phát triển khả năng lãnh đạo trong bất kỳ lĩnh vực nào.', N'Khám phá và phát triển phẩm chất lãnh đạo', N'Còn hàng'),
('1617112400048', 'LHH04', N'Phát Triển Bản Thân Mỗi Ngày', 300000, N'Cuốn', 70, 'NPP16', N'Trương Thị Thu', N'Một cuốn sách thực tế và hữu ích về cách phát triển bản thân mỗi ngày để trở thành một phiên bản tốt hơn của chính mình.', N'Cải thiện bản thân từng ngày để đạt được mục tiêu', N'Còn hàng'),
---sach van hoc.
('1117112400049', 'LHH05', N'Đoạn Đường Ký Ức', 180000, N'Cuốn', 100, 'NPP11', N'Nguyễn Nhật Ánh', N'Cuốn tiểu thuyết của Nguyễn Nhật Ánh kể về tuổi trẻ, tình bạn, tình yêu và những kỷ niệm khó quên.', N'Khám phá những kỷ niệm tuổi trẻ và tình bạn', N'Còn hàng'),
('1117112400050', 'LHH05', N'Những Đoá Hoa Xanh', 220000, N'Cuốn', 80, 'NPP11', N'Phan Hồn Nhiên', N'Cuốn sách kể về cuộc sống của những người trẻ trong thời kỳ đổi mới, những thử thách, khát khao tự do và tình yêu giữa những biến động xã hội.', N'Khám phá tình yêu và sự tự do trong thời kỳ đổi mới', N'Còn hàng'),
('1217112400051', 'LHH05', N'Sông Cửu Long Trong Tôi', 210000, N'Cuốn', 120, 'NPP12', N'Nguyễn Bình Phương', N'Một tác phẩm kể về những câu chuyện quê hương, những con người sống gắn bó với dòng sông Cửu Long.', N'Khám phá vẻ đẹp của sông nước miền Tây và tình yêu quê hương', N'Còn hàng'),
('1217112400052', 'LHH05', N'Verity', 240000, N'Cuốn', 90, 'NPP12', N'Colleen Hoover', N'Cuốn tiểu thuyết lãng mạn nhưng đầy bí ẩn, kể về câu chuyện tình giữa Lowen Ashleigh và Jeremy Crawford.', N'Một câu chuyện tình yêu kịch tính và đầy bất ngờ', N'Còn hàng'),
('1317112400053', 'LHH05', N'Thảm Kinh Hoàng', 270000, N'Cuốn', 70, 'NPP13', N'Stephen King', N'Cuốn tiểu thuyết nổi tiếng của Stephen King, với những yếu tố kinh dị, ly kỳ và nhiều tình tiết bất ngờ.', N'Tiểu thuyết kinh dị với những tình tiết kịch tính', N'Còn hàng'),
('1317112400054', 'LHH05', N'Người Tình', 260000, N'Cuốn', 110, 'NPP13', N'Anh Đức', N'Cuốn tiểu thuyết tình yêu đầy đam mê và bi kịch giữa những con người ở những hoàn cảnh khác nhau.', N'Khám phá sự phức tạp của tình yêu và những lựa chọn trong cuộc sống', N'Còn hàng'),
('1417112400055', 'LHH05', N'Tôi Thấy Hoa Vàng Trên Cỏ Xanh', 200000, N'Cuốn', 60, 'NPP14', N'Nguyễn Nhật Ánh', N'Cuốn sách kể về tuổi thơ trong sáng của những đứa trẻ làng quê miền Trung.', N'Thể hiện một phần của tuổi thơ Việt Nam với những tình cảm trong sáng', N'Còn hàng'),
('1417112400056', 'LHH05', N'Bông Hồng Vàng', 210000, N'Cuốn', 50, 'NPP14', N'Lê Hoàng', N'Cuốn sách miêu tả cuộc sống và những bi kịch của con người trong bối cảnh chiến tranh.', N'Câu chuyện đầy bi kịch về chiến tranh và tình yêu', N'Còn hàng'),
('1517112400057', 'LHH05', N'Những Cánh Hoa Rơi', 230000, N'Cuốn', 90, 'NPP15', N'Phan Kế Bính', N'Cuốn sách này là một tập hợp những câu chuyện ngắn đầy cảm động, kể về tình yêu.', N'Một tác phẩm văn học đầy cảm xúc về tình yêu và cuộc sống', N'Còn hàng'),
('1517112400058', 'LHH05', N'Sự Im Lặng Của Biển', 250000, N'Cuốn', 100, 'NPP15', N'Vercors', N'Cuốn tiểu thuyết nói về cuộc chiến nội tâm của những con người sống dưới sự chi phối của chiến tranh.', N'Tiểu thuyết về chiến tranh và sự đấu tranh nội tâm', N'Còn hàng'),
('1617112400059', 'LHH05', N'Tiếng Chim Hót Trong Bụi Mận Gai', 280000, N'Cuốn', 80, 'NPP16', N'Colleen McCullough', N'Cuốn sách kể về cuộc đời của một người phụ nữ mạnh mẽ trong suốt những thăng trầm và thử thách trong xã hội và gia đình.', N'Một câu chuyện cảm động về tình yêu, gia đình và sự kiên cường', N'Còn hàng'),
('1617112400060', 'LHH05', N'Tàu Biển', 220000, N'Cuốn', 70, 'NPP16', N'Nguyễn Minh Châu', N'Cuốn sách này kể về những chuyến đi qua những bến cảng xa lạ, những cuộc gặp gỡ tình cờ đầy bất ngờ và sâu sắc', N'Khám phá những câu chuyện về cuộc sống, tình yêu và sự kiên trì', N'Còn hàng'),
---sach khoa hoc.
('1117112400061', 'LHH06', N'Cosmos', 350000, N'Cuốn', 100, 'NPP11', N'Carl Sagan', N'Cuốn sách "Cosmos" của Carl Sagan đưa người đọc vào cuộc hành trình vũ trụ qua những kiến thức sâu rộng về thiên văn học', N'Tìm hiểu về vũ trụ và các khám phá khoa học vĩ đại', N'Còn hàng'),
('1117112400062', 'LHH06', N'Vật Lý Của Những Điều Kỳ Diệu', 400000, N'Cuốn', 80, 'NPP11', N'Michio Kaku', N'Michio Kaku giải thích những khái niệm phức tạp trong vật lý học bằng cách làm cho chúng trở nên dễ hiểu và gần gũi với người đọc.', N'Khám phá vật lý học và những hiện tượng kỳ diệu trong vũ trụ', N'Còn hàng'),
('1217112400063', 'LHH06', N'Einstein: Life and Universe', 420000, N'Cuốn', 120, 'NPP12', N'Walter Isaacson', N'Cuốn sách này đi sâu vào cuộc đời và di sản khoa học của Albert Einstein, người đã thay đổi cách chúng ta nhìn nhận vũ trụ', N'Khám phá cuộc đời và những cống hiến vĩ đại của Einstein', N'Còn hàng'),
('1217112400064', 'LHH06', N'The Selfish Gene', 370000, N'Cuốn', 90, 'NPP12', N'Richard Dawkins', N'Cuốn sách này giải thích về cách các gene ảnh hưởng đến sự tiến hóa và hành vi sống của loài người và động vật.', N'Sự tiến hóa qua lăng kính của lý thuyết gene ích kỷ', N'Còn hàng'),
('1317112400065', 'LHH06', N'A Brief History of Time', 430000, N'Cuốn', 110, 'NPP13', N'Stephen Hawking', N'Cuốn sách nổi tiếng của Stephen Hawking đưa ra những lý thuyết về vũ trụ, thời gian và sự sáng tạo của vũ trụ.', N'Tiểu luận về thời gian, không gian và nguồn gốc vũ trụ', N'Còn hàng'),
('1317112400066', 'LHH06', N'The Gene: An Intimate History', 390000, N'Cuốn', 80, 'NPP13', N'Siddhartha Mukherjee', N'Cuốn sách này kể về lịch sử của gene, giải thích về di truyền học và các tiến bộ trong khoa học.', N'Khám phá lịch sử gene và ảnh hưởng của nó đối với sự sống và y học', N'Còn hàng'),
('1417112400067', 'LHH06', N'The Man Who Mistook His Wife for a Hat', 360000, N'Cuốn', 60, 'NPP14', N'Oliver Sacks', N'Cuốn sách này là một tập hợp các trường hợp lâm sàng về các bệnh lý thần kinh kỳ lạ.', N'Khám phá những bệnh lý thần kinh và tác động của chúng đến nhận thức', N'Còn hàng'),
('1417112400068', 'LHH06', N'The Structure of Scientific Revolutions', 380000, N'Cuốn', 70, 'NPP14', N'Thomas S. Kuhn', N'Cuốn sách phân tích quá trình thay đổi trong khoa học và sự chuyển giao giữa các lý thuyết khoa học.', N'Sự thay đổi và cách mạng trong lịch sử khoa học', N'Còn hàng'),
('1517112400069', 'LHH06', N'Outliers: The Story of Success', 420000, N'Cuốn', 90, 'NPP15', N'Malcolm Gladwell', N'Cuốn sách này khám phá những yếu tố không ngờ tới ảnh hưởng đến sự thành công, từ gia đình, môi trường xã hội đến cơ hội và thời gian.', N'Khám phá những yếu tố không ngờ tới ảnh hưởng đến thành công', N'Còn hàng'),
('1517112400070', 'LHH06', N'The Art and Science of Prediction', 460000, N'Cuốn', 100, 'NPP15', N'Philip E. Tetlock', N'Cuốn sách này phân tích các dự báo khoa học và tìm ra lý do tại sao một số người có thể dự đoán tương lai tốt hơn những người khác.', N'Khám phá nghệ thuật và khoa học của dự đoán chính xác', N'Còn hàng'),
('1617112400071', 'LHH06', N'A Biography of Cancer', 440000, N'Cuốn', 80, 'NPP16', N'Siddhartha Mukherjee', N'Cuốn sách này là một tiểu sử của ung thư, kể về sự tiến hóa của bệnh ung thư qua các thế kỷ.', N'Tiểu sử của ung thư và các bước tiến trong nghiên cứu', N'Còn hàng'),
('1617112400072', 'LHH06', N'The Immortal Life of Henrietta Lacks', 450000, N'Cuốn', 70, 'NPP16', N'Rebecca Skloot', N'Cuốn sách kể về cuộc đời của Henrietta Lacks và những tế bào của bà đã trở thành một trong những công cụ quan trọng trong y học.', N'Khám phá cuộc đời của Henrietta Lacks và ảnh hưởng của tế bào HeLa trong y học', N'Còn hàng'),
---sach thieu nhi.
('1117112400073', 'LHH07', N'Con Cào Cào', 50000, N'Cuốn', 100, 'NPP11', N'Nguyễn Thị Lan', N'Cuốn sách kể về cuộc sống của con cào cào và những bài học về sự kiên trì, nỗ lực trong cuộc sống.', N'Giúp trẻ em hiểu về sự kiên trì và chăm chỉ', N'Còn hàng'),
('1117112400074', 'LHH07', N'Những Câu Chuyện Hay Cho Bé', 60000, N'Cuốn', 80, 'NPP11', N'Nguyễn Minh Tâm', N'Cuốn sách này tổng hợp những câu chuyện giáo dục và bổ ích, giúp trẻ em học hỏi về đạo đức, tình bạn, và tình yêu thương.', N'Những câu chuyện giáo dục giúp trẻ phát triển nhân cách', N'Còn hàng'),
('1217112400075', 'LHH07', N'Đi Tìm Bạn Cũ', 45000, N'Cuốn', 90, 'NPP12', N'Phan Thị Vàng Anh', N'Cuốn sách về cuộc hành trình tìm kiếm bạn cũ của một em bé, qua đó trẻ học được giá trị của tình bạn và sự kết nối.', N'Học hỏi giá trị của tình bạn và sự chia sẻ', N'Còn hàng'),
('1217112400076', 'LHH07', N'Bé Tập Đếm', 30000, N'Cuốn', 120, 'NPP12', N'Hoàng Đình Thao', N'Cuốn sách dành cho trẻ em làm quen với những con số đầu tiên qua hình ảnh sinh động và các bài học đơn giản, dễ hiểu.', N'Trẻ em làm quen với toán học cơ bản qua hình ảnh', N'Còn hàng'),
('1317112400077', 'LHH07', N'Theo Dấu Chân Của Bụt', 65000, N'Cuốn', 100, 'NPP13', N'Phạm Thu Hương', N'Cuốn sách kể về câu chuyện của một em bé đi theo dấu chân của Phật, học được nhiều bài học quý giá về sự nhân từ và lòng khoan dung.', N'Giới thiệu về những giá trị đạo đức qua câu chuyện', N'Còn hàng'),
('1317112400078', 'LHH07', N'Cô Bé Quàng Khăn Đỏ', 70000, N'Cuốn', 110, 'NPP13', N'Nguyễn Thị Minh Ngọc', N'Sách kể lại câu chuyện cổ tích Cô Bé Quàng Khăn Đỏ với những tình tiết thú vị và bài học về sự cẩn trọng trong cuộc sống.', N'Câu chuyện cổ tích về sự cẩn trọng và lòng dũng cảm', N'Còn hàng'),
('1417112400079', 'LHH07', N'Bé Làm Bác Sĩ', 80000, N'Cuốn', 80, 'NPP14', N'Nguyễn Hoàng Nam', N'Cuốn sách dành cho trẻ em khám phá nghề bác sĩ qua các trò chơi và tình huống giả tưởng, giúp trẻ hiểu về nghề y và sự chăm sóc sức khỏe.', N'Khám phá nghề bác sĩ qua các trò chơi', N'Còn hàng'),
('1417112400080', 'LHH07', N'Cây Cối Thật Thú Vị', 55000, N'Cuốn', 90, 'NPP14', N'Phan Thị Lan', N'Cuốn sách giúp trẻ khám phá thế giới cây cối, từ các loài cây quen thuộc cho đến những cây kỳ lạ, qua đó rèn luyện sự yêu thiên nhiên.', N'Học về thiên nhiên và cây cối qua những câu chuyện thú vị', N'Còn hàng'),
('1517112400081', 'LHH07', N'Khám Phá Thế Giới Xung Quanh', 60000, N'Cuốn', 70, 'NPP15', N'Nguyễn Thị Bích Ngọc', N'Cuốn sách này giúp trẻ em khám phá thế giới xung quanh từ những điều nhỏ bé nhất, khơi gợi sự tò mò và học hỏi về các sự vật, hiện tượng tự nhiên.', N'Khám phá thế giới tự nhiên qua những câu chuyện hấp dẫn', N'Còn hàng'),
('1517112400082', 'LHH07', N'Con Mèo Màu Xám', 45000, N'Cuốn', 100, 'NPP15', N'Lê Thị Mỹ Hạnh', N'Cuốn sách kể về một chú mèo màu xám trong cuộc sống sinh động và đáng yêu, với những bài học về tình bạn và sự chia sẻ.', N'Chú mèo màu xám và những bài học cuộc sống cho trẻ', N'Còn hàng'),
('1617112400083', 'LHH07', N'Cuộc Phiêu Lưu Của Chú Chim Non', 70000, N'Cuốn', 80, 'NPP16', N'Phạm Tuấn Anh', N'Cuốn sách kể về cuộc phiêu lưu đầy thử thách của một chú chim non, giúp trẻ học về sự dũng cảm, kiên nhẫn và khát khao khám phá thế giới.', N'Sự phiêu lưu của chú chim non qua các câu chuyện thú vị', N'Còn hàng'),
('1617112400084', 'LHH07', N'Những Điều Kỳ Diệu Của Con Mèo', 65000, N'Cuốn', 110, 'NPP16', N'Nguyễn Thị Bích Thuận', N'Cuốn sách kể về những điều kỳ diệu mà một con mèo có thể mang lại cho cuộc sống của trẻ em, với những bài học về tình bạn và sự quan tâm.', N'Thực hành tình yêu thương qua những câu chuyện về mèo', N'Còn hàng'),
---sach tu dien.
('1117112400085', 'LHH08', N'Từ Điển Anh - Việt', 120000, N'Cuốn', 100, 'NPP11', N'Nguyễn Văn A', N'Từ điển Anh - Việt với hơn 50,000 từ vựng, giúp học viên dễ dàng tra cứu và nâng cao khả năng tiếng Anh.', N'Giúp học viên nâng cao khả năng tiếng Anh', N'Còn hàng'),
('1117112400086', 'LHH08', N'Từ Điển Việt - Anh', 130000, N'Cuốn', 80, 'NPP11', N'Nguyễn Thị B', N'Từ điển Việt - Anh với nhiều từ vựng thông dụng, hỗ trợ người học dễ dàng chuyển ngữ từ tiếng Việt sang tiếng Anh.', N'Dành cho người học tiếng Anh', N'Còn hàng'),
('1217112400087', 'LHH08', N'Từ Điển Tiếng Pháp - Việt', 140000, N'Cuốn', 60, 'NPP12', N'Nguyễn Minh C', N'Từ điển Pháp - Việt với hơn 30,000 từ vựng, giúp học viên dễ dàng học tiếng Pháp và nâng cao khả năng giao tiếp.', N'Giúp người học cải thiện khả năng tiếng Pháp', N'Còn hàng'),
('1217112400088', 'LHH08', N'Từ Điển Tiếng Nhật - Việt', 150000, N'Cuốn', 90, 'NPP12', N'Phan Thị D', N'Từ điển Nhật - Việt bao gồm các từ vựng cơ bản và nâng cao, hỗ trợ học sinh, sinh viên học tiếng Nhật hiệu quả.', N'Từ điển Nhật - Việt chi tiết, đầy đủ', N'Còn hàng'),
('1317112400089', 'LHH08', N'Từ Điển Tiếng Trung Quốc - Việt', 160000, N'Cuốn', 75, 'NPP13', N'Lê Thị E', N'Từ điển Trung - Việt với các từ vựng thường dùng trong giao tiếp và các lĩnh vực chuyên ngành, dễ sử dụng và tra cứu.', N'Học từ vựng tiếng Trung hiệu quả', N'Còn hàng'),
('1317112400090', 'LHH08', N'Từ Điển Tiếng Hàn Quốc - Việt', 170000, N'Cuốn', 85, 'NPP13', N'Trần Thanh F', N'Từ điển Hàn - Việt được thiết kế chi tiết, cung cấp các từ vựng từ cơ bản đến nâng cao cho người học tiếng Hàn.', N'Giúp học tiếng Hàn từ cơ bản đến nâng cao', N'Còn hàng'),
('1417112400091', 'LHH08', N'Từ Điển Tiếng Tây Ban Nha - Việt', 145000, N'Cuốn', 100, 'NPP14', N'Hồ Minh G', N'Từ điển Tây Ban Nha - Việt với các từ vựng phổ biến và các cụm từ thông dụng trong giao tiếp hàng ngày.', N'Khám phá và học tiếng Tây Ban Nha', N'Còn hàng'),
('1417112400092', 'LHH08', N'Từ Điển Tiếng Nga - Việt', 160000, N'Cuốn', 70, 'NPP14', N'Phạm Thị H', N'Từ điển Nga - Việt với các từ vựng và cấu trúc ngữ pháp cơ bản, giúp người học tiếp cận tiếng Nga dễ dàng hơn.', N'Tiếng Nga cho người mới bắt đầu', N'Còn hàng'),
('1517112400093', 'LHH08', N'Từ Điển Tiếng Đức - Việt', 155000, N'Cuốn', 80, 'NPP15', N'Nguyễn Thị I', N'Từ điển Đức - Việt dành cho người học tiếng Đức với các từ vựng thông dụng và cấu trúc ngữ pháp cơ bản.', N'Tiếng Đức cơ bản cho người học', N'Còn hàng'),
('1517112400094', 'LHH08', N'Từ Điển Tiếng Ý - Việt', 150000, N'Cuốn', 90, 'NPP15', N'Vũ Minh K', N'Từ điển Ý - Việt hỗ trợ học viên học tiếng Ý từ cơ bản đến nâng cao, bao gồm các từ vựng thông dụng và cụm từ hàng ngày.', N'Học tiếng Ý qua từ điển chi tiết', N'Còn hàng'),
('1617112400095', 'LHH08', N'Từ Điển Tiếng Bồ Đào Nha - Việt', 165000, N'Cuốn', 70, 'NPP16', N'Trương Thị L', N'Từ điển Bồ Đào Nha - Việt cung cấp các từ vựng phổ biến và các cấu trúc ngữ pháp cho người học tiếng Bồ Đào Nha.', N'Học tiếng Bồ Đào Nha với từ điển chi tiết', N'Còn hàng'),
('1617112400096', 'LHH08', N'Từ Điển Tiếng Ả Rập - Việt', 180000, N'Cuốn', 50, 'NPP16', N'Nguyễn Thị M', N'Từ điển Ả Rập - Việt với các từ vựng cơ bản giúp học viên dễ dàng tiếp cận và học tiếng Ả Rập.', N'Khám phá tiếng Ả Rập qua từ điển', N'Còn hàng'),
---van phong pham.
('1717112400097', 'LHH09', N'Bút Bi', 15000, N'Cây', 200, 'NPP17', NULL, N'Bút bi được thiết kế nhỏ gọn, dễ sử dụng, phù hợp cho học sinh và văn phòng.', N'Phù hợp cho học sinh và nhân viên văn phòng', N'Còn hàng'),
('1717112400098', 'LHH09', N'Giấy A4', 50000, N'Lốc', 150, 'NPP17', NULL, N'Giấy A4 chất lượng cao, phù hợp cho máy in, photocopy và viết tay.', N'Sử dụng cho văn phòng và học tập', N'Còn hàng'),
('1717112400099', 'LHH09', N'Tẩy', 2000, N'Cái', 300, 'NPP17', NULL, N'Tẩy chất lượng cao, không làm rách giấy, dễ dàng tẩy sạch các vết bút chì.', N'Dành cho học sinh và nhân viên văn phòng', N'Còn hàng'),
('1717112400100', 'LHH09', N'Bút Dạ Quang', 25000, N'Cây', 180, 'NPP17', NULL, N'Bút dạ quang có nhiều màu sắc nổi bật, thích hợp cho việc đánh dấu, ghi chú.', N'Giúp ghi chú và đánh dấu dễ dàng', N'Còn hàng'),
('1817112400101', 'LHH09', N'Sổ Tay', 35000, N'Cuốn', 120, 'NPP18', NULL, N'Sổ tay với nhiều kích thước, bìa cứng, tiện dụng cho việc ghi chép hàng ngày.', N'Phù hợp cho việc ghi chép, sổ công tác', N'Còn hàng'),
('1817112400102', 'LHH09', N'Bút Chì', 8000, N'Cây', 250, 'NPP18', NULL, N'Bút chì chất lượng cao, thích hợp cho viết, vẽ, và sử dụng trong các bài thi.', N'Giúp học sinh dễ dàng làm bài tập', N'Còn hàng'),
('1817112400103', 'LHH09', N'Kẹp Giấy', 12000, N'Cái', 100, 'NPP18', NULL, N'Kẹp giấy giúp tổ chức tài liệu dễ dàng, giữ cho giấy tờ không bị rơi rớt.', N'Giữ tài liệu gọn gàng và ngăn nắp', N'Còn hàng'),
('1817112400104', 'LHH09', N'Hồ Sơ Lưu Trữ', 40000, N'Cái', 60, 'NPP18', NULL, N'Hồ sơ lưu trữ với chất liệu bền, giúp bảo quản tài liệu lâu dài.', N'Phù hợp cho việc lưu trữ tài liệu trong văn phòng', N'Còn hàng'),
('1917112400105', 'LHH09', N'Băng Dính', 5000, N'Cái', 400, 'NPP19', NULL, N'Băng dính chất lượng cao, dùng để dán các vật liệu văn phòng và bao bì.', N'Dùng trong các công việc văn phòng và đóng gói', N'Còn hàng'),
('1917112400106', 'LHH09', N'Kéo', 20000, N'Cái', 180, 'NPP19', NULL, N'Kéo sắc bén, dễ sử dụng, phù hợp cho văn phòng, học sinh và các công việc thủ công.', N'Dùng trong văn phòng và học tập', N'Còn hàng'),
('1917112400107', 'LHH09', N'Bìa Cứng', 25000, N'Cái', 150, 'NPP19', NULL, N'Bìa cứng bảo vệ tài liệu khỏi hư hỏng, sử dụng cho các hồ sơ quan trọng.', N'Phù hợp với lưu trữ hồ sơ quan trọng', N'Còn hàng'),
('1917112400108', 'LHH09', N'Mực In', 35000, N'Hộp', 200, 'NPP19', NULL, N'Mực in chất lượng cao cho các loại máy in laser và phun mực, đảm bảo bản in rõ ràng và sắc nét.', N'Sử dụng cho máy in văn phòng', N'Còn hàng'),
---do choi giao duc.
('2217112400109', 'LHH10', N'Xe Lắc', 120000, N'Cái', 50, 'NPP22', NULL, N'Xe lắc cho trẻ em, giúp phát triển kỹ năng vận động và tăng cường sự khéo léo.', N'Dành cho trẻ em từ 3 tuổi trở lên', N'Còn hàng'),
('2217112400110', 'LHH10', N'Bộ Xếp Hình', 80000, N'Bộ', 100, 'NPP22', NULL, N'Bộ xếp hình giúp trẻ phát triển tư duy sáng tạo, kết hợp vui chơi và học hỏi.', N'Phù hợp cho trẻ em từ 4 tuổi trở lên', N'Còn hàng'),
('2217112400111', 'LHH10', N'Búp Bê', 150000, N'Cái', 60, 'NPP22', NULL, N'Búp bê với nhiều kiểu dáng dễ thương, giúp trẻ phát triển khả năng tưởng tượng và sáng tạo.', N'Dành cho trẻ em từ 5 tuổi', N'Còn hàng'),
('2217112400112', 'LHH10', N'Đồ Chơi Xếp Lắp', 95000, N'Cái', 80, 'NPP22', NULL, N'Bộ đồ chơi xếp lắp giúp trẻ em phát triển trí thông minh và khả năng tư duy không gian.', N'Phù hợp cho trẻ em từ 3 tuổi', N'Còn hàng'),
('2317112400113', 'LHH10', N'Bóng Nhún', 130000, N'Cái', 70, 'NPP23', NULL, N'Bóng nhún giúp trẻ em vui chơi, rèn luyện thể lực và phát triển cơ bắp.', N'Dành cho trẻ em từ 4 tuổi', N'Còn hàng'),
('2317112400114', 'LHH10', N'Chòi Chơi', 250000, N'Cái', 30, 'NPP23', NULL, N'Chòi chơi ngoài trời, giúp trẻ em vui chơi, khám phá và phát triển thể chất.', N'Phù hợp cho sân chơi ngoài trời', N'Còn hàng'),
('2317112400115', 'LHH10', N'Bộ Sản Phẩm Nhựa Xếp Hình', 95000, N'Bộ', 100, 'NPP23', NULL, N'Bộ đồ chơi nhựa xếp hình, phát triển kỹ năng giải quyết vấn đề và sáng tạo của trẻ.', N'Phù hợp cho trẻ em từ 4 tuổi trở lên', N'Còn hàng'),
('2317112400116', 'LHH10', N'Bộ Đồ Chơi Xây Dựng', 120000, N'Bộ', 90, 'NPP23', NULL, N'Bộ đồ chơi xây dựng giúp trẻ em phát triển tư duy logic và kỹ năng phối hợp tay mắt.', N'Phù hợp cho trẻ em từ 4 tuổi trở lên', N'Còn hàng'),
('2417112400117', 'LHH10', N'Bộ Thú Nhún', 150000, N'Bộ', 120, 'NPP24', NULL, N'Bộ thú nhún cho trẻ em, giúp phát triển thể chất và mang lại niềm vui khi chơi.', N'Dành cho trẻ em từ 3 tuổi', N'Còn hàng'),
('2417112400118', 'LHH10', N'Tàu Hỏa Điều Khiển', 180000, N'Cái', 80, 'NPP24', NULL, N'Tàu hỏa điều khiển từ xa giúp trẻ em phát triển khả năng điều khiển và khả năng phối hợp tay mắt.', N'Phù hợp cho trẻ em từ 5 tuổi', N'Còn hàng'),
('2417112400119', 'LHH10', N'Bộ Đồ Chơi Xe Cảnh Sát', 200000, N'Bộ', 90, 'NPP24', NULL, N'Bộ đồ chơi xe cảnh sát với các chi tiết mô phỏng, giúp trẻ em phát triển trí tưởng tượng và sáng tạo.', N'Dành cho trẻ em từ 4 tuổi trở lên', N'Còn hàng'),
('2417112400120', 'LHH10', N'Bộ Đồ Chơi Nấu Ăn', 130000, N'Bộ', 100, 'NPP24', NULL, N'Bộ đồ chơi nấu ăn giúp trẻ em phát triển khả năng giao tiếp và sáng tạo qua các trò chơi giả lập.', N'Phù hợp cho trẻ em từ 3 tuổi trở lên', N'Còn hàng'),
---do luu niem.
('2017112400121', 'LHH11', N'Mô Hình Tháp Eiffel', 350000, N'Cái', 40, 'NPP20', NULL, N'Mô hình tháp Eiffel bằng kim loại, được làm tinh xảo, phù hợp làm quà lưu niệm hoặc trang trí.', N'Phù hợp cho người yêu thích du lịch và văn hóa Pháp', N'Còn hàng'),
('2017112400122', 'LHH11', N'Tượng Con Rồng', 500000, N'Cái', 30, 'NPP20', NULL, N'Tượng con rồng được chạm khắc thủ công, mang lại may mắn và tài lộc cho gia chủ.', N'Phù hợp làm quà tặng hoặc trang trí trong nhà', N'Còn hàng'),
('2017112400123', 'LHH11', N'Bộ Quà Tặng Trà', 200000, N'Bộ', 60, 'NPP20', NULL, N'Bộ quà tặng trà bao gồm ấm trà và cốc trà sứ cao cấp, thích hợp cho những buổi trà chiều thư giãn.', N'Phù hợp cho những người yêu thích thưởng thức trà', N'Còn hàng'),
('2017112400124', 'LHH11', N'Bộ 3 Mô Hình Tượng Phật', 450000, N'Bộ', 50, 'NPP20', NULL, N'Bộ tượng Phật mini bằng đá quý, mang ý nghĩa tâm linh sâu sắc.', N'Phù hợp làm quà tặng hoặc bài trí trong không gian sống', N'Còn hàng'),
('2017112400125', 'LHH11', N'Tượng Mèo May Mắn', 250000, N'Tượng', 100, 'NPP20', NULL, N'Tượng mèo may mắn được làm từ gốm sứ, mang lại sự thịnh vượng và tài lộc cho gia đình.', N'Dành cho những người yêu thích đồ trang trí phong thủy', N'Còn hàng'),
('2017112400126', 'LHH11', N'Đồng Hồ Gỗ Tự Chế', 350000, N'Cái', 80, 'NPP20', NULL, N'Đồng hồ gỗ tự chế, phù hợp làm quà tặng lưu niệm hoặc sử dụng trong không gian nội thất.', N'Phù hợp cho những người yêu thích đồ handmade', N'Còn hàng'),
('2117112400127', 'LHH11', N'Tượng Lúa Mạch', 400000, N'Tượng', 70, 'NPP21', NULL, N'Tượng lúa mạch được chế tác tinh xảo, mang ý nghĩa phát đạt và thịnh vượng.', N'Phù hợp làm quà tặng trong các dịp lễ tết', N'Còn hàng'),
('2117112400128', 'LHH11', N'Mô Hình Con Công', 600000, N'Cái', 45, 'NPP21', NULL, N'Mô hình con công bằng đồng, có thể đặt trong phòng khách hoặc văn phòng.', N'Phù hợp cho những ai yêu thích nghệ thuật trang trí', N'Còn hàng'),
('2117112400129', 'LHH11', N'Tượng Ngựa May Mắn', 550000, N'Tượng', 60, 'NPP21', NULL, N'Tượng ngựa bằng đá cao cấp, biểu tượng của sự bền bỉ và phát đạt trong công việc.', N'Phù hợp làm quà tặng cho doanh nhân', N'Còn hàng'),
('2117112400130', 'LHH11', N'Chén Cổ Đẹp', 120000, N'Cái', 120, 'NPP21', NULL, N'Chén cổ điển với thiết kế tinh tế, mang đến vẻ đẹp sang trọng cho phòng trà hoặc phòng ăn.', N'Phù hợp cho những người yêu thích đồ cổ', N'Còn hàng'),
('2117112400131', 'LHH11', N'Mô Hình Thuyền Buồm', 650000, N'Cái', 90, 'NPP21', NULL, N'Mô hình thuyền buồm được làm từ gỗ tự nhiên, tinh xảo và chi tiết.', N'Phù hợp làm quà tặng lưu niệm hoặc trang trí', N'Còn hàng'),
('2117112400132', 'LHH11', N'Tượng Con Ngựa Vàng', 700000, N'Tượng', 30, 'NPP21', NULL, N'Tượng con ngựa vàng mang ý nghĩa phong thủy, giúp gia chủ thu hút tài lộc và may mắn.', N'Phù hợp làm quà tặng trong các dịp lễ tết', N'Còn hàng');

go

insert into NhapHang(maNH, ngayNH, maNPP) values
---sach.
('11112400001','12/01/2024','NPP11'),
('11112400002','19/01/2024','NPP11'),
('11112400003','08/02/2024','NPP12'),
('11112400004','23/02/2024','NPP12'),
('11112400005','07/03/2024','NPP13'),
('11112400006','25/03/2024','NPP13'),
('11112400007','04/04/2024','NPP14'),
('11112400008','21/04/2024','NPP14'),
('11112400009','17/05/2024','NPP15'),
('11112400010','28/05/2024','NPP15'),
('11112400011','02/06/2024','NPP16'),
---van phong pham.
('11112400012','02/06/2024','NPP17'),
('11112400013','02/06/2024','NPP18'),
('11112400014','02/06/2024','NPP19'),
---do luu niem.
('11112400015','02/06/2024','NPP20'),
('11112400016','02/06/2024','NPP21'),
---do choi tre em.
('11112400017','02/06/2024','NPP22'),
('11112400018','02/06/2024','NPP23'),
('11112400019','02/06/2024','NPP24');

go

insert into ChTietNhapHang( maNH, maHH, soLuong, ghiChu) values
---sach.
('11112400001','1517112400045',50,'Không'),
('11112400001','2217112400110',69,'Không'),
('11112400002','1917112400105',8,'Không'),
('11112400002','1517112400033',25,'Không'),
('11112400003','2117112400130',38,'Không'),
('11112400003','2017112400126',52,'Không'),
('11112400004','1317112400017',93,'Không'),
('11112400004','1517112400094',77,'Không'),
('11112400005','1117112400038',16,'Không'),
('11112400005','1507112400010',73,'Không'),
('11112400006','1517112400034',64,'Không'),
('11112400006','1717112400098',82,'Không'),
('11112400007','1717112400099',75,'Không'),
('11112400007','1617112400023',6,'Không'),
('11112400008','2217112400110',75,'Không'),
('11112400008','1417112400031',7,'Không'),
('11112400009','1417112400080',93,'Không'),
('11112400009','1317112400078',19,'Không'),
('11112400010','1107112400001',99,'Không'),
('11112400010','1607112400011',10,'Không'),
('11112400011','2317112400114',17,'Không'),
('11112400011','1117112400025',2,'Không'),
---van phong pham.
('11112400012','1817112400104',98,'Không'),
('11112400012','1917112400107',107,'Không'),
('11112400013','1717112400098',44,'Không'),
('11112400013','1917112400105',33,'Không'),
('11112400014','1717112400099',78,'Không'),
('11112400014','1717112400100',50,'Không'),
---do luu niem.
('11112400015','2017112400125',50,'Không'),
('11112400015','2117112400128',40,'Không'),
('11112400016','2017112400122',20,'Không'),
('11112400016','2117112400131',30,'Không'),
---do choi.
('11112400017','2317112400116',20,'Không'),
('11112400017','2317112400114',30,'Không'),
('11112400018','2417112400117',20,'Không'),
('11112400018','2417112400120',30,'Không'),
('11112400019','2217112400109',20,'Không'),
('11112400019','2417112400118',30,'Không');

go

-- Đảm bảo tên bảng đúng và không có lệnh nào trước CREATE PROCEDURE
CREATE PROCEDURE TimChiTietNhapHangMaNhapHang
    @MaNhapHang NVARCHAR(13)
AS
BEGIN
    -- Chọn dữ liệu từ bảng ChiTietNhapHang và HangHoa dựa trên mã nhập hàng
    SELECT 
        ctnh.maNH,           -- Mã nhập hàng
        ctnh.maHH,           -- Mã hàng hóa
        ctnh.soLuong,        -- Số lượng
        ctnh.ghiChu,         -- Ghi chú
        hh.tenHangHoa        -- Tên hàng hóa
    FROM ChiTietNhapHang ctnh
    JOIN HangHoa hh ON hh.maHH = ctnh.maHH  -- Liên kết với bảng HangHoa qua maHH
    WHERE ctnh.maNH = @MaNhapHang;          -- Lọc theo mã nhập hàng từ tham số
END;

go

CREATE PROCEDURE TimNhapHangTheoMaNPP
    @MaNPP NVARCHAR(11)
AS
BEGIN
    SELECT 
        nh.maNH AS MaNhapHang,
        nh.ngayNH AS NgayNhapHang,
        nh.maNPP AS MaNhaPhanPhoi,
        npp.tenNPP AS TenNhaPhanPhoi,
        npp.diachiNPP AS DiaChi,
        npp.sdtNPP AS SoDienThoai,
        npp.emailNPP AS Email
    FROM NhapHang nh
    JOIN NhaPhanPhoi npp ON nh.maNPP = npp.maNPP
    WHERE nh.maNPP = @MaNPP;
END;

go

CREATE PROCEDURE TimNhapHangTheoMaHangHoa
    @MaHangHoa NVARCHAR(13)
AS
BEGIN
    SELECT 
        ctnh.maNH AS MaNhapHang,
        nh.ngayNH AS NgayNhapHang,
        ctnh.maHH AS MaHangHoa,
        hh.tenHH AS TenHangHoa,
        hh.giaHH AS GiaHangHoa,
        ctnh.soLuong AS SoLuongNhap,
        ctnh.ghiChu AS GhiChu
    FROM ChiTietNhapHang ctnh
    JOIN NhapHang nh ON ctnh.maNH = nh.maNH
    JOIN HangHoa hh ON ctnh.maHH = hh.maHH
    WHERE ctnh.maHH = @MaHangHoa;
END;

go

CREATE PROCEDURE TimLichSuNhapHangTheoMaNPPVaMaHH
    @MaNPP NVARCHAR(11),  -- Mã nhà phân phối
    @MaHangHoa NVARCHAR(13)  -- Mã hàng hóa
AS
BEGIN
    SELECT 
        nh.maNH AS MaNhapHang,
        nh.ngayNH AS NgayNhapHang,
        ctnh.maHH AS MaHangHoa,
        hh.tenHH AS TenHangHoa,
        hh.giaHH AS GiaHangHoa,
        ctnh.soLuong AS SoLuongNhap,
        ctnh.ghiChu AS GhiChu,
        npp.tenNPP AS TenNhaPhanPhoi
    FROM ChiTietNhapHang ctnh
    JOIN NhapHang nh ON ctnh.maNH = nh.maNH
    JOIN HangHoa hh ON ctnh.maHH = hh.maHH
    JOIN NhaPhanPhoi npp ON nh.maNPP = npp.maNPP
    WHERE nh.maNPP = @MaNPP AND ctnh.maHH = @MaHangHoa;
END;

go

Insert into  CaTruc(tenCaTruc,gioBD,gioKT,maCN,ghiChu)
values ('T2_Sang','8:00:00','10:00:00','CN01','')
go 
Insert into  NhanSu(maNS,tenNS,gioiTinh,cccdNS,sdtNV,emailNV,diaChiNha,maCN,chucVu,matkhau,luongcanban)

values ('NS01',N'Văn A',N'Nam','09878983762','0928372892','quy@gmail.com',N'Tiền Giang','CN01','1','0',2000000),
('NS02',N'A Ánh',N'Nữ','09878983762','0928372832','Son@gmail.com',N'Hậu Giang','CN01','2','0',2000000),
('NS03',N'Văn Thơ',N'Nữ','09878983762','0928372832','Tho@gmail.com',N'Kiên Giang','CN01','2','0',2000000),
('NS04',N'Tuấn Tú',N'Nam','09878983762','0928372832','Tu123@gmail.com',N'Hậu Giang','CN01','2','0',2000000),
('NS05',N'Tuấn Anh',N'Nam','09878983762','0928372832','Anh321@gmail.com',N'Kiên Giang','CN01','2','0',2000000)
go

Insert into  KhuyenMai(maKM,tenKM,giamGia,maHH,ngayBD,ngayKT,ghiChu)
values ('KM01',N'Khuyến Mãi 20%',20,null,'07/11/2024','08/11/2024','Thang 11'),('KM03',N'Tặng sách giáo khoa',0,'1107112400001','04/10/2024','08/10/2024','Thang 10')
go

CREATE PROCEDURE TimKhachHangTheoSoDienThoai
    @SoDienThoai NVARCHAR(12)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT *
    FROM KhachHang
    WHERE sdtKH = @SoDienThoai;
END;
go

CREATE PROCEDURE TimHangHoaTheoMa
    @MaHangHoa nvarchar(13)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT *
    FROM HangHoa hh
	join LoaiHangHoa lhh on lhh.maLHH = hh.maLHH
	join NhaPhanPhoi npp on npp.maNPP = hh.maNPP
    WHERE maHH = @MaHangHoa;
END;
go

Create Procedure TimHoaDonTheoSoDienThoai
	@SdtKH varchar(12)
as
begin
	Select hd.maHD,hd.maNS,hd.maKH,hd.tongTien,hd.ngayIn,hd.ghiChu
	from HoaDon hd
	join KhachHang kh on kh.maKH = hd.maKH
	where kh.sdtKH = @SdtKH;
end;
go


Create procedure TimHoaDonTheoTenNhanVien
	@TenNS nvarchar(45)
as
begin
	select hd.maHD,hd.maNS,hd.maKH,hd.tongTien,hd.ngayIn,hd.ghiChu
	from HoaDon hd
	join NhanSu ns on ns.maNS = hd.maNS
	where ns.tenNS = @TenNS;
end;
go

create procedure TimHoaDonTheoKhoangThoiGian
	@NgayBD date,
	@NgayKT date
as
begin
	select hd.maHD,hd.maNS,hd.maKH,hd.tongTien,hd.ngayIn,hd.ghiChu
	from HoaDon hd
	where hd.ngayIn >= @NgayBD AND hd.ngayIn <= @NgayKT
end;
go

create procedure TimHoaDonTheoNgay
    @NgayBD date -- Ngày bắt đầu
as
begin
    select hd.maHD,hd.maNS,hd.maKH,hd.tongTien,hd.ngayIn,hd.ghiChu
    from HoaDon hd
    where hd.ngayIn >= @NgayBD AND hd.ngayIn <= GETDATE();
end;
go

create procedure InHoaDon
	@MaHD varchar(10)
as
begin
	select hd.maHD,hd.maNS,hd.tongTien,hd.ngayIn,kh.sdtKH,cthd.SL,cthd.DonGia,ThanhTien = cthd.DonGia * cthd.SL,hh.tenHH
	from HoaDon hd
	join KhachHang kh on kh.maKH = hd.maKH
	join CTHoaDon cthd on cthd.maHD = hd.maHD
	join HangHoa hh on hh.maHH = cthd.maHH
	where hd.maHD = @MaHD
end;
go
