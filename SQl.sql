SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER TRIGGER [dbo].[AddGiangVienTrigger]
ON [dbo].[GiangVien]
AFTER INSERT
AS
BEGIN
    -- Insert into TaiKhoanGV with default values
    INSERT INTO TaiKhoanGV (GiangVienID, PassGV)
    SELECT GiangVienID, REPLACE(NgaySinh, '/', '') -- Remove '/' from NgaySinh
    FROM inserted;
END;