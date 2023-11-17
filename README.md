# Srint3
CREATE DATABASE	QLNVien
GO
USE QLNVien

CREATE TABLE TaiKhoan(
	IDTaiKhoan int primary key,
	Tendangnhap nvarchar(50),
	Matkhau nvarchar(100),
	rolelogin int,
)

CREATE TABLE Phongban(
	IDPhong int primary key,
	Tenphong nvarchar(100)
)

CREATE TABLE NhanVien(
	IDNhanVien int primary key,
	Hoten nvarchar(200),
	Gioitinh bit,
	namsinh int,
	sdt nvarchar(10),
	email nvarchar(50),
	chucvu nvarchar(20),
	IDTaiKhoan int foreign key references Taikhoan(IDTaiKhoan),
	IDPhong int foreign key references Phongban(IDPhong)
)

insert into TaiKhoan values(1,'Taikhoan1','Matkhau1',1),(2,'Taikhoan2','Matkhau2',1),(3,'Taikhoan3','Matkhau3',2),(4,'Taikhoan4','Matkhau4',2),(5,'Taikhoan5','Matkhau5',2)
select * from TaiKhoan
insert into Phongban values(1,'Nhan su'),(2,'Ky thuat'),(3,'Marketing')
select * from Phongban
insert into NhanVien values(1,'Pham Van A',0,1996,'0162734526','APV@gmail.com','Trưởng phòng',1,3),
							(2,'Pham Thi C',1,1995,'0162734527','CPT@gmail.com','Trưởng phòng ',1,1),
							(3,'Tran Van D',0,1999,'0162734528','DTV@gmail.com','Nhân viên',2,2),
							(4,'Nguyen Duc P',0,2001,'0162734529','PND@gmail.com','Nhân viên',2,3),
							(5,'Hoang Thi V',1,2003,'0162734524','VHT@gmail.com','Nhân viên',2,1),
							(6,'Le H',1,2000,'0162734523','HL@gmail.com','Nhân viên',2,3)
select * from NhanVien
