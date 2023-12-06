CREATE DATABASE QL_NHANVIEN_AGI
GO
USE QL_NHANVIEN_AGI

create table taikhoan
(
	id int primary key,
	Tendangnhap nvarchar(50),
	matkhau nvarchar(50),
	rolelogin int
)

create table NHANVIEN
(	id int identity(1,1) primary key,
	ten nvarchar(50) not null,
	diachi varchar(150) not null,
	sodienthoai varchar(10),
	email varchar(50),
	chucvu varchar(20),
	idCN int
)
go
create table Phongban
(	id int identity(1,1) primary key,
	ten nvarchar(50) not null
)
go
alter table NHANVIEN add constraint FKNV_CT FOREIGN KEY (idCN)  references Phongban(id)