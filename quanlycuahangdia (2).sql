
create database quanlycuahangbangdia 
go 
create table noisanxuat(
mansx char(5) not null primary key,
tennsx nvarchar(50) not null 
)
create table theloai(
matheloai char(10) not null primary key,
tentheloai nvarchar(20) not null)
create table congviec(
macv char(10) not null primary key,
tencv nvarchar(20) not null)
create table nhanvien(
manv char(10) not null primary key,
tennv nvarchar(20) not null,
gioitinh nvarchar(10) ,
ngaysinh date,
dienthoai char(15),
diachi nvarchar(50),
macv char(10) not null,
constraint fk_macv foreign key(macv) references congviec(macv))

create table khachhang(
makhach char(10) not null primary key,
tenkhach nvarchar(20) not null,
dienthoai char(15))

create table nhacungcap(
mancc char(20) not null primary key,
tenncc nvarchar(20) not null,
diachi nvarchar(50),
dienthoai char(15))

create table hoadonnhap(
sohdn char(10) not null primary key,
manv char(10) not null,
ngaynhap date,
mancc char(20) not null,
tongtien float,
constraint fk_manv foreign key(manv) references nhanvien(manv),
constraint fk_mancc foreign key(mancc) references nhacungcap(mancc));


create table khodia(
madia char(10) not null primary key,
tendia nvarchar(20) not null,
soluong char(50),
dongiaban float,
dongianhap float,
mansx char(5),
matheloai char(10),
ghichu nvarchar(50),
constraint fk_mansx foreign key (mansx) references noisanxuat(mansx),
constraint fk_matheloai foreign key (matheloai) references theloai(matheloai))

create table chitiethoadonnhap(
sohdn char(50) not null primary key ,
madia char(10) ,
soluong char(100),
dongia float,
giamgia float,
thanhtien float,
constraint fk_madia foreign key (madia) references khodia(madia))
alter table chitiethoadonnhap


create table matdia(
sohdn char(50),
madia char(10) primary key ,
soluongmat float,
ngaymat date,
constraint fk_sohdn foreign key (sohdn) references chitiethoadonnhap(sohdn))

create table hoadonban(
sohdb char(50) primary key,
manv char(10) not null ,
ngayban date,
makhach char(10) not null ,
tongtien float,
constraint fk_makhach foreign key (makhach) references khachhang(makhach))
create table chitiethoadonban(
sohdb char(50) ,
madia char(10),
soluong float,
giamgia float,
thanhtien float,
constraint fk_sohdb foreign key (sohdb) references hoadonban(sohdb))

alter table khachhang
add diachi nvarchar(50)


