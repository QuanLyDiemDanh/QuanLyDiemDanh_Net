CREATE PROCEDURE sp_AddGiangVien
    @GiangVienID VARCHAR(MAX),
    @NgaySinh VARCHAR(MAX)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @FormattedDate VARCHAR(10);
    
    -- Format ngày sinh mà không chứa dấu '/'
    SET @FormattedDate = REPLACE(@NgaySinh, '/', '');

    -- Thêm một giảng viên vào bảng GiangVien
    INSERT INTO GiangVien (GiangVienID, NgaySinh) VALUES (@GiangVienID, @NgaySinh);

    -- Thêm một tài khoản vào bảng TaiKhoanGV với username là GiangVienID và pass là NgaySinh
    INSERT INTO TaiKhoanGV (GiangVienID, Password) VALUES (@GiangVienID, @FormattedDate);
END

