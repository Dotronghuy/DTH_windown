create database DoTrongHuy_2210900029
use DoTrongHuy_2210900029

create table Phongban(
	Maphong char(20) primary key,
	Tenphong nvarchar(50)
)
go
create table Nhanvien(
	Manv varchar(20) primary key,
	Tennv nvarchar(50) ,
	Ngaysinh date,
	Diachi nvarchar(20),
	Maphong char(20) foreign key (Maphong) references Phongban(Maphong)
)
go

insert into Phongban values (01,N'Kế Toán'),
							(02,N'Hành Chính'),
							(03,N'Khoa CNTT'),
							(04,N'Khoa Kiến Trúc')
insert into Nhanvien values ('NV01' , N'Phạm Hoàng Hà ', '1990-02-24',N'Hà Nội',01),
							('NV02' , N'Nguyễn Thị Thảo ', '1992-02-12',N'Hòa Bình',02),
							('NV03' , N'Trần Ánh Tuyết ', '1997-09-12',N'Thái Bình',02),
							('NV04' , N'Nguyễn Ngọc Vũ ', '1998-09-08',N'Hưng Yên',03),
							('NV05' , N'Quang Ngọc Hà', '1997-10-02',N'Sài Gòn',04)


