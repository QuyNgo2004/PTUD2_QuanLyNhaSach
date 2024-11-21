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