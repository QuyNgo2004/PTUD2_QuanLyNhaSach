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
	select *
	from HoaDon hd
	where hd.ngayIn >= @NgayBD AND hd.ngayIn <= @NgayKT
end;
go

create procedure TimHoaDonTheoNgay
    @NgayBD date -- Ngày bắt đầu
as
begin
    select *
    from HoaDon hd
    where hd.ngayIn >= @NgayBD AND hd.ngayIn <= GETDATE();
end;
go

