--Insert into  ChiNhanh(maCN,tenCN,diaChi,soDienThoai,email,ghiChu)
--values ('01','Nhà sách Sài Gòn','Sài gòn','09102931','quyngo',''),
--('02','Nhà sách Hà Nội','Hà Nội','09102931','quyngo','')
--go
use QLNhaSach

set dateformat dmy

Insert into  ChucVu(tenChucVu)
values ('Quản lý'),('Nhân Viên')
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

go
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
('LHH12',N'Sách tài liệu',N'Sách cung cấp tài liệu khác nhau.');
go

insert into HangHoa(maHH, maLHH, tenHH, giaHH, donViTinh, soLuongTon, maNPP, tacGia, hanSD, moTa, ghiChu, tinhTrang) values
---sach giao khoa.
('1107112400001','LHH01',N'Bộ sách giáo khoa lớp 1',115000,N'Bộ',46,'NPP11','','',N'Sách giáo khoa cấp 1 - Lớp 1',N'Không bán lẻ',N'Còn hàng'),
('1107112400002','LHH01',N'Bộ sách giáo khoa lớp 2',120000,N'Bộ',13,'NPP11','','',N'Sách giáo khoa cấp 1 - Lớp 2',N'Không bán lẻ',N'Còn hàng'),
('1207112400003','LHH01',N'Bộ sách giáo khoa lớp 3',127000,N'Bộ',27,'NPP12','','',N'Sách giáo khoa cấp 1 - Lớp 3',N'Không bán lẻ',N'Còn hàng'),
('1207112400004','LHH01',N'Bộ sách giáo khoa lớp 4',139000,N'Bộ',36,'NPP12','','',N'Sách giáo khoa cấp 1 - Lớp 4',N'Không bán lẻ',N'Còn hàng'),
('1307112400005','LHH01',N'Bộ sách giáo khoa lớp 5',165000,N'Bộ',44,'NPP13','','',N'Sách giáo khoa cấp 1 - Lớp 5',N'Không bán lẻ',N'Còn hàng'),
('1307112400006','LHH01',N'Bộ sách giáo khoa lớp 6',198000,N'Bộ',35,'NPP13','','',N'Sách giáo khoa cấp 2 - Lớp 6',N'Không bán lẻ',N'Còn hàng'),
('1407112400007','LHH01',N'Bộ sách giáo khoa lớp 7',203000,N'Bộ',28,'NPP14','','',N'Sách giáo khoa cấp 2 - Lớp 7',N'Không bán lẻ',N'Còn hàng'),
('1407112400008','LHH01',N'Bộ sách giáo khoa lớp 8',213000,N'Bộ',23,'NPP14','','',N'Sách giáo khoa cấp 2 - Lớp 8',N'Không bán lẻ',N'Còn hàng'),
('1507112400009','LHH01',N'Bộ sách giáo khoa lớp 9',231000,N'Bộ',38,'NPP15','','',N'Sách giáo khoa cấp 2 - Lớp 9',N'Không bán lẻ',N'Còn hàng'),
('1507112400010','LHH01',N'Bộ sách giáo khoa lớp 10',241000,N'Bộ',15,'NPP15','','',N'Sách giáo khoa cấp 3 - Lớp 10',N'Không bán lẻ',N'Còn hàng'),
('1607112400011','LHH01',N'Bộ sách giáo khoa lớp 11',265000,N'Bộ',41,'NPP16','','',N'Sách giáo khoa cấp 3 - Lớp 11',N'Không bán lẻ',N'Còn hàng'),
('1607112400012','LHH01',N'Bộ sách giáo khoa lớp 12',270000,N'Bộ',19,'NPP16','','',N'Sách giáo khoa cấp 3 - Lớp 12',N'Không bán lẻ',N'Còn hàng');
---sach tham khao.
--('1920110311413','LHH02',N'Giáo trình Kinh tế vi mô 1',197000,N'Cuốn',52,'NPP11','',N'Giáo trình Kinh tế vĩ mô - Nguyễn Văn Hòa.',N'Không có',N'Còn hàng'),
--('1920110311414','LHH02',N'Giáo trình Kinh tế vi mô 2',117000,N'Cuốn',38,'NPP11','',N'Giáo trình Kinh tế vĩ mô - Trần Hoàng Nguyên.',N'Không có',N'Còn hàng'),
--('1920110311415','LHH02',N'Lịch sử Việt Nam từ nguồn gốc đến thế kỷ XXI',188000,N'Cuốn',64,'NPP12','',N'Tài liệu tham khảo về lịch sử Việt Nam từ nguồn gốc đến thế kỷ XXI.',N'Không có',N'Còn hàng'),
--('1920110311416','LHH02',N'Nguyên lý kế toán',154000,N'Cuốn',31,'NPP12','',N'Nguyên lý kế toán.',N'Không có',N'Còn hàng'),
--('1920110311417','LHH02',N'Nhập môn Tâm lý học',157000,N'Cuốn',59,'NPP13','',N'Nhập môn tâm lý học.',N'Không có',N'Còn hàng'),
--('1920110311418','LHH02',N'Phương pháp nghiên cứu khoa học',99000,N'Cuốn',48,'NPP13','',N'Phương pháp nghiên cứu khoa học.',N'Không có',N'Còn hàng'),
--('1920110311419','LHH02',N'Quản trị học',197000,N'Cuốn',52,'NPP14','',N'Tài liệu tham khảo môn học kinh tế vĩ mô.',N'Không có',N'Còn hàng'),
--('1920110311420','LHH02',N'Giáo trình Kinh tế vi mô',197000,N'Cuốn',52,'NPP14','',N'Tài liệu tham khảo môn học kinh tế vĩ mô.',N'Không có',N'Còn hàng'),
--('1920110311421','LHH02',N'Giáo trình Kinh tế vi mô',197000,N'Cuốn',52,'NPP15','',N'Tài liệu tham khảo môn học kinh tế vĩ mô.',N'Không có',N'Còn hàng'),
--('1920110311422','LHH02',N'Giáo trình Kinh tế vi mô',197000,N'Cuốn',52,'NPP15','',N'Tài liệu tham khảo môn học kinh tế vĩ mô.',N'Không có',N'Còn hàng'),
--('1920110311423','LHH02',N'Giáo trình Kinh tế vi mô',197000,N'Cuốn',52,'NPP16','',N'Tài liệu tham khảo môn học kinh tế vĩ mô.',N'Không có',N'Còn hàng'),
--('1920110311424','LHH02',N'Giáo trình Kinh tế vi mô',197000,N'Cuốn',52,'NPP16','',N'Tài liệu tham khảo môn học kinh tế vĩ mô.',N'Không có',N'Còn hàng'),


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


