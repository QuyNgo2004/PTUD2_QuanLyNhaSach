CREATE PROCEDURE TimKhachHangTheoSoDienThoai
    @SoDienThoai NVARCHAR(12)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT *
    FROM KhachHang
    WHERE sdtKH = @SoDienThoai;
END;

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
