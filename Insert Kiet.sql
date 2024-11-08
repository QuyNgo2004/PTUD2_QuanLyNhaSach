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

