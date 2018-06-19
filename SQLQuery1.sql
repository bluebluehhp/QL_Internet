select * from Khach_Hang
delete Khach_Hang where Ten_Dang_Nhap='hhh1'
update Khach_Hang set So_Du_TG=5000 where Ten_Dang_Nhap='1'
update Khach_Hang set Ten_Dang_Nhap='2',Mat_Khau='2' ,So_Du_TG=5000 ,Kieu_ND='Guest' where Ten_Dang_Nhap=''
select Khach_Hang.So_Du_TG from Khach_Hang where Ten_Dang_Nhap='hhh1'
select * from Nhan_Vien
select * from DonHang_DA
select * from Do_An
delete Do_An where Ten_DA=''
insert into Do_An values(N'Bún ốc',30000)
select * from Kieu_Nguoi_Dung
update Do_An set Ten_DA='', DonGia=5 where Ma_DA=3
select da.Ten_DA,da.DonGia,dh.SL,dh.ThanhTien from DonHang_DA as dh,Do_An as da where dh.Ma_DA=da.Ma_DA
update Khach_Hang set Mat_Khau='h' where Ten_Dang_Nhap='h'
select Do_An.Ma_DA from Do_An where Ten_DA=N'Cơm Rang'

insert into Loai_May values ('Vip',1000000)
select * from May
insert into May values ('h','Vip')

insert into DonHang_DA values('h',4,1,25000)
select * from DonHang_DA
select Do_An.Ten_DA, Do_An.DonGia, DonHang_DA.SL, DonHang_DA.ThanhTien from DonHang_DA, Do_An where DonHang_DA.Ma_DA=Do_An.Ma_DA and DonHang_DA.Ten_May='h'
update DonHang_DA set Ma_DA=4,SL=2,ThanhTien=50000 where Ten_May='h'
select Do_An.DonGia from Do_An where Do_An.Ma_DA=3
select Do_An.Ma_DA from Do_An where Ten_DA=N'Cơm Rang'
delete DonHang_DA where Ten_May='h'
select Sum(DonHang_DA.ThanhTien) from DonHang_DA where Ten_May='h'
insert into DonHang_DA(Ten_May) values('dung')

insert into May(Ten_May) values ('dung')
delete May where Ten_May='dung'

select Nhan_Vien.Ma_NV,Nhan_Vien.Ten_Dang_Nhap,Nhan_Vien.HoTen,Nhan_Vien.SDT from Nhan_Vien

select DonHang_DA.Ten_May,Do_An.Ten_DA, Do_An.DonGia, DonHang_DA.SL, DonHang_DA.ThanhTien from DonHang_DA, Do_An where DonHang_DA.Ma_DA=Do_An.Ma_DA

--update nhan vien
select * from Nhan_Vien
insert into Nhan_Vien(HoTen,Ten_Dang_Nhap,Mat_Khau,SDT) values(N'','','','','')

--check kieu nguoi dung của tai khoan nhan vien

select Kieu_ND from Nhan_Vien where Ten_Dang_Nhap='1'
delete Nhan_Vien where Ten_Dang_Nhap=''
