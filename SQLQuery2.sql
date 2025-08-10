-- Chuyển về cơ sở dữ liệu master để tránh sử dụng BookStore_Management
USE master;
GO

-- Kiểm tra và xóa cơ sở dữ liệu nếu tồn tại
IF EXISTS (SELECT * FROM sys.databases WHERE name = 'BookStore_Management')
BEGIN
    ALTER DATABASE BookStore_Management SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE BookStore_Management;
END
GO

-- Tạo cơ sở dữ liệu
CREATE DATABASE BookStore_Management;
GO

-- Đợi vài giây để đảm bảo CSDL đã được tạo hoàn tất
WAITFOR DELAY '00:00:03';
GO

-- Sử dụng cơ sở dữ liệu
USE BookStore_Management;
GO

-- Tạo bảng NhanVien
CREATE TABLE NhanVien
(
    MaNV varchar(10) PRIMARY KEY,
    TenNV nvarchar(100) NOT NULL,
    NgSinh datetime NOT NULL,
    Phai nvarchar(10) NOT NULL,
    DiaChi nvarchar(100) NOT NULL,
    SDT nvarchar(10) UNIQUE NOT NULL,
    Email nvarchar(100) UNIQUE NOT NULL
);
GO

-- Tạo bảng Sach
CREATE TABLE Sach
(
    MaSach varchar(10) PRIMARY KEY,
    TenSach nvarchar(50) UNIQUE NOT NULL,
    TacGia nvarchar(100) NOT NULL,
    NXB datetime NOT NULL,
    TheLoai nvarchar(50) NOT NULL,
    SoLuong int NOT NULL,
    MaNV varchar(10) NOT NULL,
    CONSTRAINT Sach_MaNV_FK FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV) ON DELETE CASCADE
);
GO

-- Tạo bảng DichVu
CREATE TABLE DichVu
(
    MaDV varchar(10) PRIMARY KEY,
    TenDV nvarchar(20) NOT NULL,
    MaSach varchar(10) NOT NULL,
    GiaTien float NOT NULL,
    CONSTRAINT DV_MaSach_FK FOREIGN KEY (MaSach) REFERENCES Sach(MaSach) ON DELETE CASCADE,
    CONSTRAINT UQ_MaSach_TenDV UNIQUE (MaSach, TenDV)
);
GO

-- Tạo bảng KhachHang
CREATE TABLE KhachHang
(
    MaKH varchar(10) PRIMARY KEY,
    TenKH nvarchar(100) UNIQUE NOT NULL,
    Email nvarchar(100) UNIQUE NOT NULL,
    SDT nvarchar(10) UNIQUE NOT NULL
);
GO

-- Tạo bảng LSMuaHang
CREATE TABLE LSMuaHang
(
    MaKH varchar(10) NOT NULL,
    MaSach varchar(10) NOT NULL,
    SoLuong int NOT NULL,
    MaDV varchar(10) NOT NULL,
    PRIMARY KEY (MaKH, MaSach, MaDV),
    CONSTRAINT GH_MaKH_FK FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH) ON DELETE CASCADE,
    CONSTRAINT GH_MaSach_FK FOREIGN KEY (MaSach) REFERENCES Sach(MaSach) ON DELETE CASCADE,
    CONSTRAINT GH_MaDV_FK FOREIGN KEY (MaDV) REFERENCES DichVu(MaDV) ON DELETE NO ACTION
);
GO

-- Tạo bảng HoaDon
CREATE TABLE HoaDon
(
    MaHD int IDENTITY(1,1) PRIMARY KEY,
    MaKH varchar(10) NOT NULL,
    MaSach varchar(10) NOT NULL,
    MaDV varchar(10) NOT NULL,
    SoLuong int NOT NULL,
    ThanhTien float NOT NULL,
    NgayMua datetime DEFAULT GETDATE(),
    CONSTRAINT HD_MaKH_FK FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH) ON DELETE CASCADE,
    CONSTRAINT HD_MaSach_FK FOREIGN KEY (MaSach) REFERENCES Sach(MaSach) ON DELETE NO ACTION,
    CONSTRAINT HD_MaDV_FK FOREIGN KEY (MaDV) REFERENCES DichVu(MaDV) ON DELETE NO ACTION
);
GO

-- Chèn dữ liệu mẫu vào bảng NhanVien
INSERT INTO NhanVien (MaNV, TenNV, NgSinh, Phai, DiaChi, SDT, Email) VALUES
('NV001', N'Nguyễn Minh Hiền', '2005-12-11', N'Nữ', N'TP HCM', '0123456789', '4901103027@student.hcmue.edu.vn'),
('NV002', N'Mai Yến Khoa', '2005-10-30', N'Nữ', N'TP HCM', '0123456790', '4901103039@student.hcmue.edu.vn'),
('NV003', N'Ngô Lê Uyên Phương', '2005-03-29', N'Nữ', N'TP HCM', '0123456791', '4901103071@student.hcmue.edu.vn'),
('NV004', N'Phan Thị Quý Thịnh', '2005-11-11', N'Nữ', N'TP HCM', '0123456792', '4901103079@student.hcmue.edu.vn');
GO

-- Chèn dữ liệu mẫu vào bảng Sach
INSERT INTO Sach (MaSach, TenSach, TacGia, NXB, TheLoai, MaNV, SoLuong) VALUES
('S001', N'Dế Mèn Phiêu Lưu Ký', N'Tô Hoài', '1941-01-20', N'Sử Thi', 'NV001', 10),
('S002', N'Chí Phèo', N'Nam Cao', '1955-10-24', N'Truyện Ngắn', 'NV002', 15),
('S003', N'Người Lái Đò Sông Đà', N'Nguyễn Tuân', '1960-08-15', N'Tùy Bút', 'NV003', 20);
GO

-- Chèn dữ liệu mẫu vào bảng DichVu
INSERT INTO DichVu (MaDV, TenDV, MaSach, GiaTien) VALUES
('DV001', N'Bán', 'S001', 25000),
('DV002', N'Thuê', 'S001', 10000),
('DV003', N'Bán', 'S002', 35000),
('DV004', N'Thuê', 'S002', 16000),
('DV005', N'Bán', 'S003', 20000),
('DV006', N'Thuê', 'S003', 9000);
GO

-- Chèn dữ liệu mẫu vào bảng KhachHang
INSERT INTO KhachHang (MaKH, TenKH, Email, SDT) VALUES
('KH001', N'Nguyễn Văn A', N'anv@gmail.com', '1234567890'),
('KH002', N'Nguyễn Văn B', N'bnv@gmail.com', '1234567891');
GO

-- Chèn dữ liệu mẫu vào bảng LSMuaHang
INSERT INTO LSMuaHang (MaKH, MaSach, SoLuong, MaDV) VALUES
('KH001', 'S001', 2, 'DV001'),
('KH002', 'S002', 5, 'DV003');
GO

-- Chèn dữ liệu mẫu vào bảng HoaDon
INSERT INTO HoaDon (MaKH, MaSach, MaDV, SoLuong, ThanhTien, NgayMua) VALUES
('KH001', 'S001', 'DV001', 2, 50000, '2025-01-18 10:00:00'),
('KH002', 'S002', 'DV003', 5, 175000, '2025-01-18 15:30:00');
GO

-- Truy vấn tổng số lượng và doanh thu
SELECT 
    SUM(ISNULL(SoLuong, 0)) AS TongSoLuong,
    SUM(ISNULL(ThanhTien, 0)) AS TongDoanhThu
FROM HoaDon
WHERE NgayMua >= '2025-01-18 00:00:00' 
  AND NgayMua <= '2025-01-19 23:59:59';
GO
