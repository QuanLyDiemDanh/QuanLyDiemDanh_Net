create database QuanLyDiemDanhSV
use QuanLyDiemDanhSV

-- Tạo bảng Sinh Viên
CREATE TABLE Students (
    StudentID Varchar(10) PRIMARY KEY,
    HoTen NVARCHAR(255),
    NgaySinh DATE,
    GioiTinh NVARCHAR(10),
    Lop NVARCHAR(20)
);

-- Tạo bảng Môn Học
CREATE TABLE Courses (
    CourseID INT PRIMARY KEY,
    TenMonHoc NVARCHAR(255),
    GiangVien NVARCHAR(255)
);

-- Tạo bảng Buổi Học
CREATE TABLE Classes (
    ClassID INT PRIMARY KEY,
    NgayHoc DATE,
    ThoiGianBatDau TIME,
    ThoiGianKetThuc TIME,
    CourseID INT,
    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
);

-- Tạo bảng Điểm Danh
CREATE TABLE Attendance (
    AttendanceID INT PRIMARY KEY,
    StudentID varchar(10),
    ClassID INT,
    Status NVARCHAR(20),
    FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
    FOREIGN KEY (ClassID) REFERENCES Classes(ClassID)
);

ALTER TABLE Students
ALTER COLUMN HoTen NVARCHAR(255) NOT NULL;

ALTER TABLE Students
ALTER COLUMN NgaySinh DATE NOT NULL;

ALTER TABLE Courses
ALTER COLUMN TenMonHoc NVARCHAR(255) NOT NULL;

ALTER TABLE Courses
ALTER COLUMN GiangVien NVARCHAR(255) NOT NULL;

ALTER TABLE Classes
ALTER COLUMN NgayHoc DATE NOT NULL;

ALTER TABLE Classes
ALTER COLUMN ThoiGianBatDau TIME NOT NULL;

ALTER TABLE Classes
ALTER COLUMN ThoiGianKetThuc TIME NOT NULL;

ALTER TABLE Attendance
ALTER COLUMN Status NVARCHAR(20) NOT NULL;

ALTER TABLE Students
ADD CONSTRAINT UC_StudentID UNIQUE (StudentID);

ALTER TABLE Courses
ADD CONSTRAINT UC_CourseID UNIQUE (CourseID);

ALTER TABLE Classes
ADD CONSTRAINT UC_ClassID UNIQUE (ClassID);

ALTER TABLE Attendance
ADD CONSTRAINT UC_AttendanceID UNIQUE (AttendanceID);

ALTER TABLE Students
ADD CONSTRAINT CHK_GioiTinh CHECK (GioiTinh IN ('Nam', N'Nữ'));

ALTER TABLE Attendance
ADD CONSTRAINT CHK_Status CHECK (Status IN (N'Có mặt', N'Vắng không phép', N'Vắng có phép'));

INSERT INTO Students (StudentID, HoTen, NgaySinh, GioiTinh, Lop)
VALUES
    ('2001215616', N'Nguyễn Kế Bảo', '2003-11-30', 'Nam', 'CNTT1'),
    ('2001213621', N'Trương Hải Yến', '2001-06-23', N'Nữ', 'CNTT2'),
    ('2001215112', N'Lê Sĩ Thịnh', '2003-06-06', 'Nam', 'CNTT3'),
    ('2001215789', N'Phạm Thị Tâm', '2003-07-07', N'Nữ', 'CNTT1'),
    ('2001212654', N'Hoàng Văn Nhật', '2002-08-01', 'Nam', 'CNTT2'),
    ('2001216172', N'Lê Khánh Vy', '2002-03-09', N'Nữ', 'CNTT3'),
    ('2001216182', N'Trần Văn Quyết', '2003-10-10', 'Nam', 'CNTT1'),
    ('2001215203', N'Lê Thị An', '2003-11-11', N'Nữ', 'CNTT2'),
    ('2001216179', N'Phạm Minh Nhật', '2001-12-12', 'Nam', 'CNTT3'),
    ('2001215666', N'Lưu Hoàng Khánh Ly', '2002-01-01', N'Nữ', 'CNTT1');

INSERT INTO Courses (CourseID, TenMonHoc, GiangVien)
VALUES
    (1, N'Lập Trình C++', N'Hoàng Mỹ Nữ'),
    (2, N'Cơ Sở Dữ Liệu', N'Trần Thanh Tùng'),
    (3, N'An Toàn Thông Tin', N'Vũ Văn Thanh');

INSERT INTO Classes (ClassID, NgayHoc, ThoiGianBatDau, ThoiGianKetThuc, CourseID)
VALUES
    (101, '2023-01-01', '08:00:00', '10:00:00', 1),
    (102, '2023-01-02', '10:30:00', '12:30:00', 2),
    (103, '2023-01-03', '13:00:00', '15:00:00', 3);
