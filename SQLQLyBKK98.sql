create database QLyBanhKemK98
go

use QLyBanhKemK98
go 

CREATE TABLE DANGNHAP (
	TenDn VARCHAR(50) PRIMARY KEY,
	HoTen NVARCHAR(100) NOT NULL,
	MatKhau VARBINARY(64) NOT NULL, -- Lưu mật khẩu đã băm
);
GO
-- Tạo bảng LichSuDangNhap để lưu lịch sử đăng nhập
CREATE TABLE LichSuDangNhap (
	Id INT IDENTITY(1,1) PRIMARY KEY,
	TenDn VARCHAR(50),
	ThoiGian DATETIME DEFAULT GETDATE(),
	FOREIGN KEY (TenDn) REFERENCES DANGNHAP(TenDn)
);
GO
INSERT INTO DANGNHAP (TenDn, HoTen, MatKhau) VALUES
('NguyenA', N'Nguyễn A', HASHBYTES('SHA2_256', '12345678')),
('NguyenB', N'Nguyễn B', HASHBYTES('SHA2_256', '87654321')),
('NguyenC', N'Nguyễn C', HASHBYTES('SHA2_256', '1122334455'));
GO
CREATE TABLE Orders (
    OrderID INT PRIMARY KEY IDENTITY(1,1),
    PhoneNumber NVARCHAR(15),
    QuantityStrawberry INT,
    QuantityChocolate INT,
    QuantityVanilla INT,
    PaymentMethod NVARCHAR(50),
    DeliveryMethod NVARCHAR(50),
    TotalAmount DECIMAL(18,2),
    Description NVARCHAR(255),
    OrderDate DATETIME DEFAULT GETDATE(),
);
GO
CREATE TABLE NhanVien (
    ID NVARCHAR(12) PRIMARY KEY,
	TenDN VARCHAR(50) NOT NULL,
    TenHo NVARCHAR(50) NOT NULL,
    Ten NVARCHAR(50) NOT NULL,
    DiaChi NVARCHAR(100),
    NgaySinh DATE NOT NULL,
	FOREIGN KEY (TenDn) REFERENCES DANGNHAP(tenDn),
    ViTri NVARCHAR(20) NOT NULL CHECK (ViTri IN (N'guest', N'employee', N'manager')) -- kiểm tra giá trị vị trí
);
GO
ALTER TABLE NhanVien ADD Anh NVARCHAR(50);
SELECT NhanVien.ID, NhanVien.TenHo, NhanVien.Ten, NhanVien.DiaChi, 
       NhanVien.NgaySinh, NhanVien.ViTri, NhanVien.Anh, DANGNHAP.TenDn, 
       DANGNHAP.HoTen
FROM NhanVien
INNER JOIN DANGNHAP ON NhanVien.TenDN = DANGNHAP.TenDn;
ALTER TABLE NhanVien ADD Vitri NVARCHAR(20);
SELECT NhanVien.ViTri
FROM DANGNHAP
INNER JOIN NhanVien ON DANGNHAP.TenDn = NhanVien.TenDn
WHERE DANGNHAP.TenDn = @tk AND DANGNHAP.MatKhau = @mk;
DECLARE @tk VARCHAR(50) = 'NguyenA'; -- Thay thế bằng giá trị thực tế
DECLARE @mk VARBINARY(64) = HASHBYTES('SHA2_256', '12345678'); -- Thay thế bằng giá trị thực tế
SELECT * FROM DANGNHAP WHERE TenDn = 'newuser123';
INSERT INTO NhanVien (ID, TenDN, TenHo, Ten, DiaChi, NgaySinh, ViTri) 
VALUES ('123456789012', 'newuser123', N'New', N'User', N'123 Fake Street', '1990-01-01', N'employee');


DELETE FROM NhanVien
WHERE TenDn = 'Test';
DELETE FROM dbo.NhanVien
WHERE TenDn = 'Test23456';


-- CHAY5 CHUONG TRINH KIEM TRA 3 BANG
SELECT * FROM dbo.NhanVien
SELECT * from DANGNHAP
SELECT * from Orders
