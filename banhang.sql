

CREATE proc [dbo].[DeleteCTHDB] @MaHDB varchar(10), @MaSP varchar(10)
as
begin
	delete from CHITIETHOADONBAN
	where MaHD = @MaHDB and MaSP = @MaSP
end

GO
/****** Object:  StoredProcedure [dbo].[DeleteHDB]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DeleteHDB] @MaHDB varchar(10)
as
begin
	delete HOADONBAN
	where MaHDB = @MaHDB
end

GO
/****** Object:  StoredProcedure [dbo].[DeleteKH]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[DeleteKH] @MaKH varchar(10)
as
begin
	delete KHACHHANG
	where MaKH = @MaKH
end

GO
/****** Object:  StoredProcedure [dbo].[DeletePHB]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[DeletePHB] @MaPhieu varchar(10)
as
begin
	Delete PHIEUBAOHANH
	where SoPhieu = @MaPhieu
end

GO
/****** Object:  StoredProcedure [dbo].[InsertCTHDB]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[InsertCTHDB] @MaHDB varchar(10), @MaSP varchar(10), @SoLuong int, @dongia float, @ThanhTien float
as
begin
	insert into CHITIETHOADONBAN values
	(@MaHDB, @MaSP, @SoLuong, CONVERT(bigint, @dongia), convert(bigint, @ThanhTien))
end

GO
/****** Object:  StoredProcedure [dbo].[InsertHDB]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[InsertHDB] @MaKH varchar(10), @NgayBan datetime, @TongTien bigint
as
begin
	declare @MaHDB varchar(10)
	declare @Sott int
	declare contro CURSOR forward_only for select MaHDB from HOADONBAN
	set @Sott = 0

	open contro
	fetch next from contro into @MaHDB
	while(@@FETCH_STATUS = 0)
	BEGIN
		if((CAST(right(@MaHDB, 7) as int) - @sott) = 1)
			begin
				set @Sott = CAST(right(@MaHDB, 7) as int)
			end
		else break;
		fetch next from contro into @MaHDB
	end

	declare @cdai int
	declare @i int
	set @MaHDB = CAST((@sott + 1) as varchar(7))
	set @cdai = LEN(@MaHDB)
	set @i = 1
	while ( @i <= 7 - @cdai)
	begin
		set @MaHDB = '0' + @MaHDB
		set @i = @i + 1
	end
	set @MaHDB = 'HDB' + @MaHDB

	insert into HOADONBAN(MaHDB, MaKH, NgayBan, TongTien) values ( @MaHDB, @MaKH, @NgayBan, @TongTien)
	select @MaHDB
	close contro
	deallocate contro
end

GO
/****** Object:  StoredProcedure [dbo].[InsertKH]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--pro insert:
create PROC [dbo].[InsertKH] @TenKH nvarchar(50), @gt nvarchar(5), @DC nvarchar(50), @SDT varchar(15), @LoaiKH nvarchar(50), @ghichu ntext
as 
begin
	declare @MaKH varchar(10)
	declare @Sott int
	declare contro CURSOR forward_only for select MaKH from khachhang
	set @Sott = 0

	open contro
	fetch next from contro into @MaKH
	while(@@FETCH_STATUS = 0)
	BEGIN
		if((CAST(right(@MaKH, 8) as int) - @sott) = 1)
			begin
				set @Sott = CAST(right(@MaKH, 8) as int)
			end
		else break;
		fetch next from contro into @MaKH
	end

	declare @cdai int
	declare @i int
	set @MaKH = CAST((@sott + 1) as varchar(8))
	set @cdai = LEN(@makh)
	set @i = 1
	while ( @i <= 8 - @cdai)
	begin
		set @MaKH = '0' + @MaKH
		set @i = @i + 1
	end
	set @MaKH = 'KH' + @MaKH

	insert into khachhang (MaKH, TenKH, GT, DiaChi, SDT, LoaiKH, GhiChu) values ( @MaKH, @TenKH, @gt, @DC, @SDT, @LoaiKH, @ghichu)
	select @MaKH
	close contro
	deallocate contro
end

GO
/****** Object:  StoredProcedure [dbo].[InsertPBH]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[InsertPBH] @MaSP varchar(10), @MaKH varchar (10), @NgayBD date, @NgayKT date, @SoLan int
as
begin
		declare @MaPhieu varchar(10)
	declare @Sott1 int
	declare contro CURSOR forward_only for select SoPhieu from PHIEUBAOHANH
	set @Sott1 = 0

	open contro
	fetch next from contro into @MaPhieu
	while(@@FETCH_STATUS = 0)
	BEGIN
		if((CAST(right(@MaPhieu, 7) as int) - @Sott1) = 1) 
			begin
				set @Sott1 = CAST(right(@MaPhieu, 7) as int)
			end
		else break;
		fetch next from contro into @MaPhieu
	end

	declare @cdai int
	declare @i int
	set @MaPhieu = CAST((@Sott1 + 1) as varchar(8))
	set @cdai = LEN(@MaPhieu)
	set @i = 1
	while ( @i <= 7 - @cdai)
	begin
		set @MaPhieu = '0' + @MaPhieu
		set @i = @i + 1
	end
	set @MaPhieu = 'PBH' + @MaPhieu

	insert into PHIEUBAOHANH(SoPhieu,MaKH, MaSP, NgayBatDau, NgayKetThuc, SoLan) values ( @MaPhieu, @MaKH, @MaSP, @NgayBD, @NgayKT, @SoLan)
	select @MaPhieu
	close contro
	deallocate contro
end

--

GO
/****** Object:  StoredProcedure [dbo].[InsertPBH2]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[InsertPBH2] (@SoPhieu varchar(10), @MaSP varchar(10), @MaKH varchar(10), @NgayBatDau datetime, @NgayKetThuc datetime,@SoLan int)
as
begin
	insert into PHIEUBAOHANH values
	(@SoPhieu, @MaSP, @MaKH, CONVERT(datetime, @NgayBatDau), convert(datetime, @NgayKetThuc),CONVERT(int,@SoLan))
end
GO
/****** Object:  StoredProcedure [dbo].[KetNoiSP_LH]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[KetNoiSP_LH]
as
begin
	SELECT     dbo.SANPHAM.MaSP, dbo.SANPHAM.TenSP, dbo.LOAIHANG.TenLH, dbo.SANPHAM.NSX, dbo.SANPHAM.GiaBan, dbo.SANPHAM.SoLuong, 
                      dbo.SANPHAM.HinhAnh
	FROM         dbo.SANPHAM INNER JOIN
                      dbo.LOAIHANG ON dbo.SANPHAM.MaLH = dbo.LOAIHANG.MaLH 
end

GO
/****** Object:  StoredProcedure [dbo].[MuaNhieuNhat]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[MuaNhieuNhat]
as
begin
	select top 10 *
	from (SELECT     dbo.HOADONBAN.MaHDB, dbo.KHACHHANG.MaKH, dbo.KHACHHANG.TenKH, dbo.HOADONBAN.NgayBan, SUM(dbo.CHITIETHOADONBAN.ThanhTien) 
                      AS TongTien
	FROM         dbo.HOADONBAN INNER JOIN
						  dbo.KHACHHANG ON dbo.HOADONBAN.MaKH = dbo.KHACHHANG.MaKH INNER JOIN
						  dbo.CHITIETHOADONBAN ON dbo.HOADONBAN.MaHDB = dbo.CHITIETHOADONBAN.MaHD
	GROUP BY dbo.HOADONBAN.MaHDB, dbo.KHACHHANG.MaKH, dbo.KHACHHANG.TenKH, dbo.HOADONBAN.NgayBan) as temp
	order by temp.TongTien DESC
end

GO
/****** Object:  StoredProcedure [dbo].[PhieuNhap]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[PhieuNhap] @mancc varchar(10)
AS
BEGIN
	SELECT MaHDN, NgayNhap, TongTien FROM HOADONNHAP, 
	(SELECT MaHD, SUM(ThanhTien)TongTien FROM CHITIETHOADONNHAP GROUP BY MaHD) a
	WHERE MaNCC = @mancc AND MaHDN = MaHD
END

GO
/****** Object:  StoredProcedure [dbo].[SearchDCKH]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SearchDCKH] @str nvarchar(50)
as
begin
	select *
	from KHACHHANG
	where DiaChi like '%'+ @str + '%'
end

GO
/****** Object:  StoredProcedure [dbo].[SearchLoaiKH]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SearchLoaiKH] @str nvarchar(50)
as
begin
	select *
	from KHACHHANG
	where LoaiKH like '%'+ @str + '%'
end

GO
/****** Object:  StoredProcedure [dbo].[SearchTenKH]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SearchTenKH] @str nvarchar(50)
as
begin
	select *
	from KHACHHANG
	where TenKH like '%'+ @str + '%'
end

GO
/****** Object:  StoredProcedure [dbo].[SearchTenLH]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SearchTenLH] @str nvarchar(50)
as
begin
	SELECT     dbo.SANPHAM.MaSP, dbo.SANPHAM.TenSP, dbo.LOAIHANG.TenLH, dbo.SANPHAM.NSX, dbo.SANPHAM.GiaBan, dbo.SANPHAM.SoLuong, 
                      dbo.SANPHAM.HinhAnh
	FROM         dbo.SANPHAM INNER JOIN
						  dbo.LOAIHANG ON dbo.SANPHAM.MaLH = dbo.LOAIHANG.MaLH
	WHERE     (dbo.LOAIHANG.TenLH LIKE N'%' + @str + N'%')
end

GO
/****** Object:  StoredProcedure [dbo].[SearchTenNSX]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SearchTenNSX] @str nvarchar(50)
as
begin
	SELECT     dbo.SANPHAM.MaSP, dbo.SANPHAM.TenSP, dbo.LOAIHANG.TenLH, dbo.SANPHAM.NSX, dbo.SANPHAM.GiaBan, dbo.SANPHAM.SoLuong, 
                      dbo.SANPHAM.HinhAnh
	FROM         dbo.SANPHAM INNER JOIN
						  dbo.LOAIHANG ON dbo.SANPHAM.MaLH = dbo.LOAIHANG.MaLH
	WHERE     (NSX LIKE N'%' + @str + N'%')
end

GO
/****** Object:  StoredProcedure [dbo].[SearchTenSP]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SearchTenSP] @str nvarchar(50)
as
begin
	SELECT     dbo.SANPHAM.MaSP, dbo.SANPHAM.TenSP, dbo.LOAIHANG.TenLH, dbo.SANPHAM.NSX, dbo.SANPHAM.GiaBan, dbo.SANPHAM.SoLuong, 
                      dbo.SANPHAM.HinhAnh
	FROM         dbo.SANPHAM INNER JOIN
						  dbo.LOAIHANG ON dbo.SANPHAM.MaLH = dbo.LOAIHANG.MaLH
	WHERE     (dbo.SANPHAM.TenSP LIKE N'%' + @str + N'%')
end

GO
/****** Object:  StoredProcedure [dbo].[Show10KH]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Show10KH]
as
begin
		select top 10 *
	from (

		select kh.*, temp.TongTien
		from (SELECT  dbo.KHACHHANG.MaKH, SUM(dbo.HOADONBAN.TongTien) 
						  AS TongTien
		FROM         dbo.HOADONBAN INNER JOIN
							  dbo.KHACHHANG ON dbo.HOADONBAN.MaKH = dbo.KHACHHANG.MaKH
		GROUP BY dbo.KHACHHANG.MaKH) as temp, KHACHHANG kh
		where temp.MaKH = kh.MaKH
	) as c
	order by c.TongTien DESC
end

GO
/****** Object:  StoredProcedure [dbo].[ShowCTHDB]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ShowCTHDB]
as
begin
	SELECT     dbo.CHITIETHOADONBAN.MaHD, dbo.CHITIETHOADONBAN.MaSP, dbo.SANPHAM.TenSP, dbo.CHITIETHOADONBAN.SoLuong, dbo.CHITIETHOADONBAN.DonGia, 
                      dbo.CHITIETHOADONBAN.ThanhTien
	FROM         dbo.CHITIETHOADONBAN INNER JOIN
                      dbo.SANPHAM ON dbo.CHITIETHOADONBAN.MaSP = dbo.SANPHAM.MaSP
end

GO
/****** Object:  StoredProcedure [dbo].[ShowCTHDB2]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ShowCTHDB2] @MaHDB varchar(10)
as
begin
	SELECT     dbo.CHITIETHOADONBAN.MaHD, dbo.CHITIETHOADONBAN.MaSP, dbo.SANPHAM.TenSP, dbo.CHITIETHOADONBAN.SoLuong, dbo.CHITIETHOADONBAN.DonGia, 
                      dbo.CHITIETHOADONBAN.ThanhTien
	FROM         dbo.CHITIETHOADONBAN INNER JOIN
                      dbo.SANPHAM ON dbo.CHITIETHOADONBAN.MaSP = dbo.SANPHAM.MaSP
    where dbo.CHITIETHOADONBAN.MaHD = @MaHDB
end

GO
/****** Object:  StoredProcedure [dbo].[ShowHDB]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ShowHDB]
as
begin
	SELECT     dbo.HOADONBAN.MaHDB, dbo.KHACHHANG.MaKH, dbo.KHACHHANG.TenKH, dbo.HOADONBAN.NgayBan, SUM(dbo.CHITIETHOADONBAN.ThanhTien) 
                      AS TongTien
	FROM         dbo.HOADONBAN INNER JOIN
						  dbo.KHACHHANG ON dbo.HOADONBAN.MaKH = dbo.KHACHHANG.MaKH INNER JOIN
						  dbo.CHITIETHOADONBAN ON dbo.HOADONBAN.MaHDB = dbo.CHITIETHOADONBAN.MaHD
	GROUP BY dbo.HOADONBAN.MaHDB, dbo.KHACHHANG.MaKH, dbo.KHACHHANG.TenKH, dbo.HOADONBAN.NgayBan
end

GO
/****** Object:  StoredProcedure [dbo].[ShowHDB1Ngay]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ShowHDB1Ngay] @date datetime
as
begin
	SELECT     dbo.HOADONBAN.MaHDB, dbo.KHACHHANG.MaKH, dbo.KHACHHANG.TenKH, dbo.HOADONBAN.NgayBan, SUM(dbo.CHITIETHOADONBAN.ThanhTien) 
                      AS TongTien
	FROM         dbo.HOADONBAN INNER JOIN
						  dbo.KHACHHANG ON dbo.HOADONBAN.MaKH = dbo.KHACHHANG.MaKH INNER JOIN
						  dbo.CHITIETHOADONBAN ON dbo.HOADONBAN.MaHDB = dbo.CHITIETHOADONBAN.MaHD
	GROUP BY dbo.HOADONBAN.MaHDB, dbo.KHACHHANG.MaKH, dbo.KHACHHANG.TenKH, dbo.HOADONBAN.NgayBan
	having convert(date, dbo.HOADONBAN.NgayBan) = CONVERT(date, @date)
end

GO
/****** Object:  StoredProcedure [dbo].[ShowHDBNhieuNgay]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ShowHDBNhieuNgay] @date1 datetime, @date2 datetime
as
begin
	SELECT     dbo.HOADONBAN.MaHDB, dbo.KHACHHANG.MaKH, dbo.KHACHHANG.TenKH, dbo.HOADONBAN.NgayBan, SUM(dbo.CHITIETHOADONBAN.ThanhTien) 
                      AS TongTien
	FROM         dbo.HOADONBAN INNER JOIN
						  dbo.KHACHHANG ON dbo.HOADONBAN.MaKH = dbo.KHACHHANG.MaKH INNER JOIN
						  dbo.CHITIETHOADONBAN ON dbo.HOADONBAN.MaHDB = dbo.CHITIETHOADONBAN.MaHD
	GROUP BY dbo.HOADONBAN.MaHDB, dbo.KHACHHANG.MaKH, dbo.KHACHHANG.TenKH, dbo.HOADONBAN.NgayBan
	having CONVERT(date, dbo.HOADONBAN.NgayBan) between CONVERT(date, @date1) and CONVERT(date, @date2)
end

GO
/****** Object:  StoredProcedure [dbo].[ShowHDBTongTien]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ShowHDBTongTien] @tien1 bigint, @tien2 bigint
as
begin
	select *
	from ( SELECT     dbo.HOADONBAN.MaHDB, dbo.KHACHHANG.MaKH, dbo.KHACHHANG.TenKH, dbo.HOADONBAN.NgayBan, SUM(dbo.CHITIETHOADONBAN.ThanhTien) 
                      AS TongTien
	FROM         dbo.HOADONBAN INNER JOIN
						  dbo.KHACHHANG ON dbo.HOADONBAN.MaKH = dbo.KHACHHANG.MaKH INNER JOIN
						  dbo.CHITIETHOADONBAN ON dbo.HOADONBAN.MaHDB = dbo.CHITIETHOADONBAN.MaHD
	GROUP BY dbo.HOADONBAN.MaHDB, dbo.KHACHHANG.MaKH, dbo.KHACHHANG.TenKH, dbo.HOADONBAN.NgayBan
	) as temp
	where temp.Tongtien >= @tien1 and temp.tongtien < @tien2
end

GO
/****** Object:  StoredProcedure [dbo].[ShowKHNhieuNgay]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ShowKHNhieuNgay] @date1 datetime, @date2 datetime
as
begin
	SELECT  dbo.KHACHHANG.*
	FROM         dbo.HOADONBAN INNER JOIN
						  dbo.KHACHHANG ON dbo.HOADONBAN.MaKH = dbo.KHACHHANG.MaKH
	where CONVERT(date, dbo.HOADONBAN.NgayBan) between CONVERT(date, @date1) and CONVERT(date, @date2)
end

GO
/****** Object:  StoredProcedure [dbo].[ShowPBH]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ShowPBH]
as
begin
	SELECT     dbo.PHIEUBAOHANH.SoPhieu, dbo.SANPHAM.MaSP, dbo.SANPHAM.TenSP, dbo.KHACHHANG.MaKH, dbo.KHACHHANG.TenKH, dbo.PHIEUBAOHANH.NgayBatDau, 
						  dbo.PHIEUBAOHANH.NgayKetThuc, dbo.PHIEUBAOHANH.SoLan
	FROM         dbo.PHIEUBAOHANH INNER JOIN
                      dbo.SANPHAM ON dbo.PHIEUBAOHANH.MaSP = dbo.SANPHAM.MaSP INNER JOIN
                      dbo.KHACHHANG ON dbo.PHIEUBAOHANH.MaKH = dbo.KHACHHANG.MaKH
end

GO
/****** Object:  StoredProcedure [dbo].[ShowSPBanChayNhat]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ShowSPBanChayNhat]
as
begin
	select a.*, b.SoLuongBan
	from SANPHAM a, 
		(SELECT     dbo.SANPHAM.MaSP, SUM(dbo.CHITIETHOADONBAN.SoLuong) AS SoLuongBan
		FROM         dbo.SANPHAM INNER JOIN
						  dbo.CHITIETHOADONBAN ON dbo.SANPHAM.MaSP = dbo.CHITIETHOADONBAN.MaSP
		GROUP BY dbo.SANPHAM.MaSP
		having SUM(dbo.CHITIETHOADONBAN.SoLuong) = (select MAX(SoLuongBan)
			from(
			SELECT     dbo.SANPHAM.MaSP, SUM(dbo.CHITIETHOADONBAN.SoLuong) AS SoLuongBan
			FROM         dbo.SANPHAM INNER JOIN
							  dbo.CHITIETHOADONBAN ON dbo.SANPHAM.MaSP = dbo.CHITIETHOADONBAN.MaSP
			GROUP BY dbo.SANPHAM.MaSP
			) as temp)
		) b
	where a.MaSP = b.MaSP
end

GO
/****** Object:  StoredProcedure [dbo].[SuaCTHD]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaCTHD] @mahd varchar(10), @masp nvarchar(50), @soluong int, @dongia float, @thanhtien float
AS
BEGIN
UPDATE CHITIETHOADONNHAP SET MaSP = @masp, SoLuong = @soluong, DonGia = @dongia, ThanhTien = @thanhtien
WHERE MaHD = @mahd
END

GO
/****** Object:  StoredProcedure [dbo].[SuaHDN]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaHDN] @mahdn varchar(10), @mancc nvarchar(50), @ngaynhap date
AS
BEGIN
UPDATE HOADONNHAP SET MaNCC = @mancc, NgayNhap = @ngaynhap
WHERE MaHDN = @mahdn
END

GO
/****** Object:  StoredProcedure [dbo].[SuaLH]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaLH] @malh varchar(10), @tenlh nvarchar(50)
AS
BEGIN
UPDATE LOAIHANG SET TenLH = @tenlh
WHERE MaLH = @malh
END

GO
/****** Object:  StoredProcedure [dbo].[SuaNCC]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaNCC] @mancc varchar(10), @tenncc nvarchar(50), @diachi nvarchar(50), @sdt varchar(15)
AS
BEGIN
UPDATE NHACUNGCAP SET TenNCC = @tenncc, DiaChi = @diachi, SDT = @sdt
WHERE MaNCC = @mancc
END

GO
/****** Object:  StoredProcedure [dbo].[SuaNhanVien]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaNhanVien](@TenDn nvarchar(50), @MatKhau varchar(50), @TenNV nvarchar(50), @GT varchar(3), @DiaChi nvarchar(50), @SDT nvarchar(50))
AS
BEGIN
	UPDATE NHANVIEN SET MatKhau=@MatKhau, TenNV=@TenNV, GT=@GT, DiaChi=@DiaChi, SDT=@SDT
						   WHERE TenDn=@TenDn
END
GO
/****** Object:  StoredProcedure [dbo].[SuaSL]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaSL] @masp varchar(10), @sl int
AS
BEGIN
	UPDATE SANPHAM SET SoLuong = SoLuong + @sl
	WHERE MaSP = @masp
END

GO
/****** Object:  StoredProcedure [dbo].[SuaSP]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaSP] @masp varchar(10), @tensp nvarchar(50), @malh nvarchar(50), @soluong int, @loinhuan float, @gianhap bigint, @mota text, @nsx nvarchar(50), @hinhanh nvarchar(100)
AS
BEGIN
UPDATE SANPHAM SET TenSP = @tensp,
MaLH = @malh, SoLuong = @soluong, GiaNhap = @gianhap, GiaBan = @gianhap+@gianhap*@loinhuan/100, MoTa = @mota, NSX = @nsx, LoiNhuan = @loinhuan, HinhAnh = @hinhanh
WHERE MaSP = @masp
END

GO
/****** Object:  StoredProcedure [dbo].[ThemCTHD]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemCTHD] @mahd varchar(10), @masp varchar(10), @soluong int, @dongia float, @thanhtien float
AS
BEGIN
INSERT INTO CHITIETHOADONNHAP(MaHD, MaSP, SoLuong, DonGia, ThanhTien) values (@mahd, @masp, @soluong, @dongia, @thanhtien)
END

GO
/****** Object:  StoredProcedure [dbo].[ThemGiaBan]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemGiaBan] @masp varchar(10), @gia float
AS
BEGIN
	UPDATE SANPHAM SET GiaBan = @gia + @gia * LoiNhuan / 100
	WHERE MaSP = @masp
END

GO
/****** Object:  StoredProcedure [dbo].[ThemHDN]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemHDN] @mancc nvarchar(50), @ngaynhap date
AS
BEGIN
DECLARE @MaHDN varchar(10)
DECLARE @Sott int
DECLARE contro CURSOR FORWARD_ONLY FOR SELECT MaHDN from HOADONNHAP
SET @Sott = 0

OPEN contro
FETCH NEXT FROM contro INTO @MaHDN
WHILE(@@FETCH_STATUS = 0)
BEGIN
	IF((CAST(right(@MaHDN, 7) AS int) - @sott) = 1)
		BEGIN
			SET @Sott = @Sott + 1
		END
	ELSE BREAK
	FETCH NEXT FROM contro INTO @MaHDN
END
DECLARE @cdai int
DECLARE @i int
SET @MaHDN = CAST((@sott + 1) as varchar(8))
SET @cdai = LEN(@MaHDN)
SET @i = 1
while ( @i <= 7 - @cdai)
BEGIN
	SET @MaHDN = '0' + @MaHDN
	SET @i = @i + 1
END
SET @MaHDN = 'HDN' + @MaHDN

INSERT INTO HOADONNHAP(MaHDN, MaNCC, NgayNhap) values (@MaHDN, @mancc, @ngaynhap)
SELECT @MaHDN
CLOSE contro
DEALLOCATE contro
END

GO
/****** Object:  StoredProcedure [dbo].[ThemLH]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----PROC Thêm sản phẩm
CREATE PROC [dbo].[ThemLH] @tenlh nvarchar(50)
AS
BEGIN
DECLARE @MaLH varchar(10)
DECLARE @Sott int
DECLARE contro CURSOR FORWARD_ONLY FOR SELECT MaLH from LOAIHANG
SET @Sott = 0

OPEN contro
FETCH NEXT FROM contro INTO @MaLH
WHILE(@@FETCH_STATUS = 0)
BEGIN
	IF((CAST(right(@MaLH, 8) AS int) - @sott) = 1)
		BEGIN
			SET @Sott = @Sott + 1
		END
	ELSE BREAK
	FETCH NEXT FROM contro INTO @MaLH
END
DECLARE @cdai int
DECLARE @i int
SET @MaLH = CAST((@sott + 1) as varchar(8))
SET @cdai = LEN(@MaLH)
SET @i = 1
while ( @i <= 8 - @cdai)
BEGIN
	SET @MaLH = '0' + @MaLH
	SET @i = @i + 1
END
SET @MaLH = 'LH' + @MaLH

INSERT INTO LOAIHANG(MaLH, TenLH) values (@MaLH, @tenlh)
CLOSE contro
DEALLOCATE contro
END

----exec DanhMaKH @tenKH = N'Hiếu', @dc = N'Thái Nguyên', @SDT = '09127862476', @LoaiKH = N'Khách VIP'

--CREATE PROC SuaLH @malh varchar(10), @tenlh nvarchar(50)
--AS
--BEGIN
--UPDATE LOAIHANG SET TenLH = @tenlh
--WHERE MaLH = @malh
--END

--CREATE PROC XoaLH @malh varchar(10)
--AS
--BEGIN
--DELETE FROM LOAIHANG WHERE MaLH = @malh
--END

GO
/****** Object:  StoredProcedure [dbo].[ThemNCC]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----PROC Thêm sản phẩm
CREATE PROC [dbo].[ThemNCC] @tenlh nvarchar(50), @diachi nvarchar(50), @sdt varchar(15)
AS
BEGIN
DECLARE @MaNCC varchar(10)
DECLARE @Sott int
DECLARE contro CURSOR FORWARD_ONLY FOR SELECT MaNCC from NHACUNGCAP
SET @Sott = 0

OPEN contro
FETCH NEXT FROM contro INTO @MaNCC
WHILE(@@FETCH_STATUS = 0)
BEGIN
	IF((CAST(right(@MaNCC, 7) AS int) - @sott) = 1)
		BEGIN
			SET @Sott = @Sott + 1
		END
	ELSE BREAK
	FETCH NEXT FROM contro INTO @MaNCC
END
DECLARE @cdai int
DECLARE @i int
SET @MaNCC = CAST((@sott + 1) as varchar(8))
SET @cdai = LEN(@MaNCC)
SET @i = 1
while ( @i <= 7 - @cdai)
BEGIN
	SET @MaNCC = '0' + @MaNCC
	SET @i = @i + 1
END
SET @MaNCC = 'NCC' + @MaNCC

INSERT INTO NHACUNGCAP(MaNCC, TenNCC, DiaChi, SDT) values (@MaNCC, @tenlh, @diachi, @sdt)
CLOSE contro
DEALLOCATE contro
END

----exec DanhMaKH @tenKH = N'Hiếu', @dc = N'Thái Nguyên', @SDT = '09127862476', @LoaiKH = N'Khách VIP'

--CREATE PROC SuaNCC @mancc varchar(10), @tenncc nvarchar(50), @diachi nvarchar(50), @sdt varchar(15)
--AS
--BEGIN
--UPDATE NHACUNGCAP SET TenNCC = @tenncc, DiaChi = @diachi, SDT = @sdt
--WHERE MaNCC = @mancc
--END

--CREATE PROC XoaNCC @mancc varchar(10)
--AS
--BEGIN
--DELETE FROM NHACUNGCAP WHERE MaNCC = @mancc
--END

GO
/****** Object:  StoredProcedure [dbo].[ThemSP]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemSP] @tensp nvarchar(50), @malh nvarchar(50), @soluong int, @loinhuan float, @gianhap bigint, @mota text, @nsx nvarchar(50), @hinhanh nvarchar(100)
AS
BEGIN
DECLARE @MaSP varchar(10)
DECLARE @Sott int
DECLARE contro CURSOR FORWARD_ONLY FOR SELECT MaSP from SANPHAM
SET @Sott = 0

OPEN contro
FETCH NEXT FROM contro INTO @MaSP
WHILE(@@FETCH_STATUS = 0)
BEGIN
	IF((CAST(right(@MaSP, 8) AS int) - @sott) = 1)
		BEGIN
			SET @Sott = CAST(right(@MaSP, 8) AS int)
		END
	ELSE BREAK
	FETCH NEXT FROM contro INTO @MaSP
END

DECLARE @cdai int
DECLARE @i int
SET @MaSP = CAST((@sott + 1) as varchar(8))
SET @cdai = LEN(@MaSP)
SET @i = 1
while ( @i <= 8 - @cdai)
BEGIN
	SET @MaSP = '0' + @MaSP
	SET @i = @i + 1
END
SET @MaSP = 'SP' + @MaSP

INSERT INTO SANPHAM(MaSP, TenSP, MaLH, SoLuong, LoiNhuan, GiaNhap, GiaBan, MoTa, NSX, HinhAnh) values ( @MaSP, @tensp, @malh, @soluong, @loinhuan, @gianhap, (@gianhap+@gianhap*@loinhuan/100), @mota, @nsx, @hinhanh)
SELECT @MaSP
CLOSE contro
DEALLOCATE contro
END

GO
/****** Object:  StoredProcedure [dbo].[ThongKeHDN]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThongKeHDN] @ngaydau date, @ngaycuoi date
AS
BEGIN
	SELECT * FROM HOADONNHAP
	WHERE NgayNhap BETWEEN @ngaydau AND @ngaycuoi
END

GO
/****** Object:  StoredProcedure [dbo].[ThongKeSPB]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThongKeSPB] @ngaydau date, @ngaycuoi date
AS
BEGIN
	SELECT sp.MaSP, TenSP, LoiNhuan, GiaNhap, GiaBan, MoTa, NSX, sp.SoLuong
	FROM SANPHAM sp, HOADONBAN hdb, CHITIETHOADONBAN cthdb
	WHERE sp.MaSP = cthdb.MaSP AND hdb.MaHDB = cthdb.MaHD AND CONVERT(date, NgayBan) BETWEEN @ngaydau AND @ngaycuoi
END

GO
/****** Object:  StoredProcedure [dbo].[ThongKeTop10]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThongKeTop10] @ngaydau date, @ngaycuoi date
AS
BEGIN
	SELECT TOP(10)(b.soluong)soluong, sp.MaSP, sp.TenSP, sp.LoiNhuan, sp.GiaNhap, sp.GiaBan, sp.MoTa, sp.NSX FROM SANPHAM sp,
	(SELECT a.MaSP as masp,  SUM(a.sls)soluong
	FROM  (SELECT cthdb.MaSP, NgayBan, SUM(cthdb.SoLuong)sls
		FROM CHITIETHOADONBAN cthdb, HOADONBAN hdb 
		WHERE cthdb.MaHD = hdb.MaHDB 
		GROUP BY cthdb.MaSP, NgayBan
		HAVING CONVERT(date, NgayBan) BETWEEN @ngaydau AND @ngaycuoi) a
GROUP BY a.MaSP) b
WHERE b.masp = sp.MaSP
END

GO
/****** Object:  StoredProcedure [dbo].[TongTien]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[TongTien] @mahd varchar(10)
AS
BEGIN
	DECLARE @tongtien bigint
	SELECT @tongtien = SUM(ThanhTien)
	FROM CHITIETHOADONNHAP WHERE MaHD = @mahd
	SELECT @tongtien
END

GO
/****** Object:  StoredProcedure [dbo].[UpdateCTHDB]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[UpdateCTHDB] (@MaHDB varchar(10), @MaSP varchar(10), @SoLuong int, @dongia float, @ThanhTien float)
as
begin
	UPDATE  CHITIETHOADONBAN SET MaSP=@MaSP, SoLuong=@SoLuong,DonGia=@dongia, ThanhTien=@ThanhTien
	WHERE MaHD=@MaHDB
end

GO
/****** Object:  StoredProcedure [dbo].[UpdateHDB]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UpdateHDB] @MaHDB varchar(10)
as
begin
	update HOADONBAN
	set  TongTien = temp.TongTien
	from (SELECT  SUM(dbo.CHITIETHOADONBAN.ThanhTien) AS TongTien
			FROM dbo.HOADONBAN INNER JOIN  dbo.CHITIETHOADONBAN ON dbo.HOADONBAN.MaHDB = dbo.CHITIETHOADONBAN.MaHD
			where  dbo.HOADONBAN.MaHDB = @MaHDB
	GROUP BY dbo.HOADONBAN.MaHDB) as temp
	where MaHDB = @MaHDB
end

GO
/****** Object:  StoredProcedure [dbo].[UpdateKH]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[UpdateKH] @MaKH varchar(10), @TenKH nvarchar(50), @gt nvarchar(5), @DC nvarchar(50), @SDT varchar(15), @LoaiKH nvarchar(50), @ghichu ntext
as
begin
	update KHACHHANG
	set TenKH = @TenKH, GT = @gt, DiaChi = @DC, SDT = @SDT, LoaiKH = @LoaiKH, GhiChu = @ghichu
	where MaKH = @MaKH
end

GO
/****** Object:  StoredProcedure [dbo].[UpdatePHB]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UpdatePHB] @MaPhieu varchar(10), @MaSP varchar(10), @MaKH varchar (10), @NgayBD date, @NgayKT date, @SoLan int
as
begin
	update PHIEUBAOHANH
	set  MaKH = @MaKH, MaSP = @MaSP, NgayBatDau = @NgayBD, NgayKetThuc = @NgayKT, SoLan = @SoLan
	where SoPhieu = @MaPhieu
end

GO
/****** Object:  StoredProcedure [dbo].[UpdateSLBan]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[UpdateSLBan] @masp varchar(10), @sl int
AS
BEGIN
	UPDATE SANPHAM SET SoLuong = SoLuong - @sl
	WHERE MaSP = @masp
END

GO
/****** Object:  StoredProcedure [dbo].[Xoa_NV]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Xoa_NV] (@TenDn nvarchar(10))
AS
BEGIN
	DELETE FROM NHANVIEN WHERE TenDn = @TenDn
END
GO
/****** Object:  StoredProcedure [dbo].[XoaCTHD]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XoaCTHD] @mahd varchar(10), @masp varchar(10)
AS
BEGIN
DELETE FROM CHITIETHOADONNHAP WHERE MaHD = @mahd AND MaSP = @masp
END

GO
/****** Object:  StoredProcedure [dbo].[XoaHDN]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XoaHDN] @mahdn varchar(10)
AS
BEGIN
DELETE FROM HOADONNHAP WHERE MaHDN = @mahdn
END

GO
/****** Object:  StoredProcedure [dbo].[XoaLH]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XoaLH] @malh varchar(10)
AS
BEGIN
DELETE FROM LOAIHANG WHERE MaLH = @malh
END

GO
/****** Object:  StoredProcedure [dbo].[XoaNCC]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XoaNCC] @mancc varchar(10)
AS
BEGIN
DELETE FROM NHACUNGCAP WHERE MaNCC = @mancc
END

GO
/****** Object:  StoredProcedure [dbo].[XoaSP]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XoaSP] @masp varchar(10)
AS
BEGIN
DELETE FROM SANPHAM WHERE MaSP = @masp
END

GO
/****** Object:  Table [dbo].[tblChiTietHoaDon]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblChiTietHoaDon](
	[MaHD] [varchar](10) NOT NULL,
	[MaSP] [varchar](10) NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [bigint] NULL,
	[ThanhTien] [bigint] NULL,
 CONSTRAINT [CTHDB_MAHD_PK] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblHoaDonBan]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblHoaDonBan](
	[MaHDB] [varchar](10) NOT NULL,
	[MaKH] [varchar](10) NULL,
	[NgayBan] [datetime] NULL,
	[TongTien] [bigint] NULL,
 CONSTRAINT [HDB_MAHDB_PK] PRIMARY KEY CLUSTERED 
(
	[MaHDB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblKhachHang]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblKhachHang](
	[MaKH] [varchar](10) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[GT] [nvarchar](5) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [nvarchar](50) NULL,
	[LoaiKH] [nvarchar](50) NULL,
	[GhiChu] [ntext] NULL,
 CONSTRAINT [KH_MAKH_PK] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblLoaiHang]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblLoaiHang](
	[MaLH] [varchar](10) NOT NULL,
	[TenLH] [nvarchar](50) NOT NULL,
 CONSTRAINT [LH_MALH_PK] PRIMARY KEY CLUSTERED 
(
	[MaLH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblNhaCungCap]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblNhaCungCap](
	[TenNCC] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [char](15) NULL,
 CONSTRAINT [PK_NHACUNGCAP] PRIMARY KEY CLUSTERED 
(
	[TenNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblNhanVien]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblNhanVien](
	[TenDn] [nvarchar](50) NOT NULL,
	[MatKhau] [varchar](50) NULL,
	[TenNV] [nvarchar](50) NULL,
	[GT] [varchar](3) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [nvarchar](50) NULL,
 CONSTRAINT [PK_DANGNHAP] PRIMARY KEY CLUSTERED 
(
	[TenDn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblPhieuBaoHanh]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblPhieuBaoHanh](
	[SoPhieu] [varchar](10) NOT NULL,
	[MaSP] [varchar](10) NULL,
	[MaKH] [varchar](10) NULL,
	[NgayBatDau] [datetime] NULL,
	[NgayKetThuc] [datetime] NULL,
	[SoLan] [int] NULL,
 CONSTRAINT [PBH_SOPHIEU_PK] PRIMARY KEY CLUSTERED 
(
	[SoPhieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblSanPham]    Script Date: 11/2/2016 4:13:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblSanPham](
	[MaSP] [varchar](10) NOT NULL,
	[TenSP] [nvarchar](50) NOT NULL,
	[MaLH] [varchar](10) NULL,
	[SoLuong] [int] NULL,
	[LoiNhuan] [float] NULL,
	[GiaNhap] [bigint] NULL,
	[GiaBan] [bigint] NULL,
	[MoTa] [ntext] NULL,
	[NSX] [nvarchar](50) NULL,
	[HinhAnh] [nvarchar](100) NULL,
	[NhaCC] [nvarchar](50) NULL,
 CONSTRAINT [SP_MASP_PK] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO

INSERT [dbo].[tblChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HDB0000001', N'SP00000002', 1, 21716800, 21716800)
INSERT [dbo].[tblChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HDB0000001', N'SP00000003', 5, 11979100, 59895500)
INSERT [dbo].[tblChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HDB0000001', N'SP00000004', 5, 18359000, 91795000)
INSERT [dbo].[tblChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HDB0000002', N'SP00000002', 5, 21716800, 108584000)
INSERT [dbo].[tblChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HDB0000002', N'SP00000003', 3, 11979100, 35937300)
INSERT [dbo].[tblChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HDB0000002', N'SP00000004', 1, 18359000, 18359000)
INSERT [dbo].[tblChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HDB0000003', N'SP00000002', 3, 21716800, 21716800)
INSERT [dbo].[tblChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HDB0000003', N'SP00000003', 1, 11979100, 11979100)
INSERT [dbo].[tblChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HDB0000003', N'SP00000004', 1, 18359000, 18359000)
INSERT [dbo].[tblChiTietHoaDon] ([MaHD], [MaSP], [SoLuong], [DonGia], [ThanhTien]) VALUES (N'HDB0000003', N'SP00000007', 5, 17259000, 86295000)
INSERT [dbo].[tblHoaDonBan] ([MaHDB], [MaKH], [NgayBan], [TongTien]) VALUES (N'HDB0000001', N'KH00000001', CAST(0x0000A49C0161AE94 AS DateTime), 173407300)
INSERT [dbo].[tblHoaDonBan] ([MaHDB], [MaKH], [NgayBan], [TongTien]) VALUES (N'HDB0000002', N'KH00000002', CAST(0x0000A49C01634790 AS DateTime), 162880300)
INSERT [dbo].[tblHoaDonBan] ([MaHDB], [MaKH], [NgayBan], [TongTien]) VALUES (N'HDB0000003', N'KH00000003', CAST(0x0000A49C0171DD28 AS DateTime), 138349900)
INSERT [dbo].[tblKhachHang] ([MaKH], [TenKH], [GT], [DiaChi], [SDT], [LoaiKH], [GhiChu]) VALUES (N'KH00000001', N'Nga', N'Nữ', N'Ninh Bình', N'016456565', N'Khách Sộp', N'')
INSERT [dbo].[tblKhachHang] ([MaKH], [TenKH], [GT], [DiaChi], [SDT], [LoaiKH], [GhiChu]) VALUES (N'KH00000002', N'Linh', N'Nữ', N'Ninh Bình', N'016456565', N'Khách Sộp', N'')
INSERT [dbo].[tblKhachHang] ([MaKH], [TenKH], [GT], [DiaChi], [SDT], [LoaiKH], [GhiChu]) VALUES (N'KH00000003', N'Lượng', N'Nam', N'Kim Sơn - Ninh Bình', N'01662405826', N'Khách VIP', N'Cần Quan tâm kĩ')
INSERT [dbo].[tblKhachHang] ([MaKH], [TenKH], [GT], [DiaChi], [SDT], [LoaiKH], [GhiChu]) VALUES (N'KH00000004', N'Long', N'Nam', N'Hải Dương', N'016966564536', N'Khách Thường Xuyên', N'')
INSERT [dbo].[tblKhachHang] ([MaKH], [TenKH], [GT], [DiaChi], [SDT], [LoaiKH], [GhiChu]) VALUES (N'KH00000005', N'H.Anh', N'Nam', N'Nghệ An', N'02231312', N'Khách Thường Xuyên', N'')
INSERT [dbo].[tblLoaiHang] ([MaLH], [TenLH]) VALUES (N'LH1       ', N'LapTop')
INSERT [dbo].[tblLoaiHang] ([MaLH], [TenLH]) VALUES (N'LH2       ', N'Máy tính bảng')
INSERT [dbo].[tblLoaiHang] ([MaLH], [TenLH]) VALUES (N'LH3       ', N'Linh kiện máy tính')
INSERT [dbo].[tblLoaiHang] ([MaLH], [TenLH]) VALUES (N'LH4       ', N'Thiết bị mạng')
INSERT [dbo].[tblLoaiHang] ([MaLH], [TenLH]) VALUES (N'LH5       ', N'Phụ kiện máy tính')
INSERT [dbo].[tblLoaiHang] ([MaLH], [TenLH]) VALUES (N'LH6       ', N'Máy văn phòng')
INSERT [dbo].[tblLoaiHang] ([MaLH], [TenLH]) VALUES (N'LH7       ', N'Điện thoại')
INSERT [dbo].[tblNhaCungCap] ([TenNCC], [DiaChi], [SDT]) VALUES (N'Anh Khang', N'210 Thái Hà, Trung Liệt, Đống Đa, Hà Nội', N'0435379888     ')
INSERT [dbo].[tblNhaCungCap] ([TenNCC], [DiaChi], [SDT]) VALUES (N'Ben Computer', N'74 Nguyễn Khánh Toàn, Cầu Giấy, Hà Nội', N'0437677045     ')
INSERT [dbo].[tblNhaCungCap] ([TenNCC], [DiaChi], [SDT]) VALUES (N'DMART', N'Khu đô tị mới Trung Yên, Cầu Giấy, Hà Nội', N'0436282899     ')
INSERT [dbo].[tblNhaCungCap] ([TenNCC], [DiaChi], [SDT]) VALUES (N'Hoàng Minh', N'92 Trần Đại Nghĩa, Hai Bà Trưng, Hà Nội', N'0986536974     ')
INSERT [dbo].[tblNhaCungCap] ([TenNCC], [DiaChi], [SDT]) VALUES (N'LaptopVip', N'245 Trường Trinh, P.12, Quận Tân Bình, TP.HCM', N'0862974098     ')
INSERT [dbo].[tblNhaCungCap] ([TenNCC], [DiaChi], [SDT]) VALUES (N'LAZADA', N'Phường Đakao, Quận 1, TP.HCM', N'0435379888     ')
INSERT [dbo].[tblNhanVien] ([TenDn], [MatKhau], [TenNV], [GT], [DiaChi], [SDT]) VALUES (N'ADMIN', N'ADMIN', NULL, NULL, NULL, NULL)
INSERT [dbo].[tblNhanVien] ([TenDn], [MatKhau], [TenNV], [GT], [DiaChi], [SDT]) VALUES (N'Dung', N'123456', N'Lê Tiến Dũng', N'Nam', N'Thanh Hóa', N'0912344555')
INSERT [dbo].[tblNhanVien] ([TenDn], [MatKhau], [TenNV], [GT], [DiaChi], [SDT]) VALUES (N'Hoang Anh', N'123456', N'Lê Viết Hoàng Anh', N'Nam', N'Nghệ An', N'0987666777')
INSERT [dbo].[tblNhanVien] ([TenDn], [MatKhau], [TenNV], [GT], [DiaChi], [SDT]) VALUES (N'Huyen', N'123456', N'Trần Thị Huyền', N'Nu', N'Hà Tĩnh', N'0945678546')
INSERT [dbo].[tblNhanVien] ([TenDn], [MatKhau], [TenNV], [GT], [DiaChi], [SDT]) VALUES (N'Linh', N'123456', N'Bạch Thị Diệu Linh', N'Nu', N'Hòa Bình', N'0912345678')
INSERT [dbo].[tblNhanVien] ([TenDn], [MatKhau], [TenNV], [GT], [DiaChi], [SDT]) VALUES (N'Long', N'123456', N'Đoàn Quang Long', N'Nam', N'Hải Dương', N'0936662226')
INSERT [dbo].[tblNhanVien] ([TenDn], [MatKhau], [TenNV], [GT], [DiaChi], [SDT]) VALUES (N'Luong', N'123456', N'Phạm Văn Lượng', N'Nam', N'Ninh Bình', N'0987666778')
INSERT [dbo].[tblNhanVien] ([TenDn], [MatKhau], [TenNV], [GT], [DiaChi], [SDT]) VALUES (N'Quang', N'123456', N'Nguyễn Hòa Nhật Quang', N'Nam', N'An Giang', N'0945673526')
INSERT [dbo].[tblSanPham] ([MaSP], [TenSP], [MaLH], [SoLuong], [LoiNhuan], [GiaNhap], [GiaBan], [MoTa], [NSX], [HinhAnh], [NhaCC]) VALUES (N'SP00000001', N'Dell Inspiron 14 3443 70055103 Black', N'LH1       ', 4, 15, 12390000, 14248500, N'CPU Intel Core i5-5200U Broadwell (2.2Ghz upto 2.7Ghz, 3MB Cache L3)/ Ram 4GB Buss 1600Mhz/ HDD 1TB 5400rpm/ VGA Intel HD Graphic 5500/ Display 14.0" LED/ OS Ubuntu', N'Dell', N'120_5273_7737_touch.jpg', NULL)
INSERT [dbo].[tblSanPham] ([MaSP], [TenSP], [MaLH], [SoLuong], [LoiNhuan], [GiaNhap], [GiaBan], [MoTa], [NSX], [HinhAnh], [NhaCC]) VALUES (N'SP00000002', N'Dell Inspiron 13 7348 C3I5609W Silver', N'LH1       ', 267, 12, 19390000, 21716800, N'CPU Intel Core i5-5200U Broadwell (2.2Ghz upto 2.7Ghz, 3MB Cache L3)/ Ram 4GB Buss 1600Mhz/ HDD 500GB 5400rpm/ VGA Intel HD Graphic 5500/ Display 13.3" LED Touch Screen - Màn hình c?m ?ng da di?m ch?m - Xoay 360 Ð?/ OS Windows 8.1', N'Dell', N'120_5274_15009_14948_14117_dell_inspiron_773720140228051328.jpg', NULL)
INSERT [dbo].[tblSanPham] ([MaSP], [TenSP], [MaLH], [SoLuong], [LoiNhuan], [GiaNhap], [GiaBan], [MoTa], [NSX], [HinhAnh], [NhaCC]) VALUES (N'SP00000003', N'Dell Vostro 5480 VTI31008 Silver', N'LH1       ', 76, 9, 10990000, 11979100, N'CPU Intel Core i3-4005U (1.7Ghz, 3Mb Cache L3)/ Ram 4GB DDR3 1600Mhz/ HDD 500GB 5400Rpm/ VGA Intel HD Graphics 4400/ Display 14.0" LED (1366x768)/ Free Dos', N'Dell', N'120_5275_4891_.jpg', NULL)
INSERT [dbo].[tblSanPham] ([MaSP], [TenSP], [MaLH], [SoLuong], [LoiNhuan], [GiaNhap], [GiaBan], [MoTa], [NSX], [HinhAnh], [NhaCC]) VALUES (N'SP00000004', N'Dell Inspiron 15R N5548 M5I5652W Silver', N'LH1       ', 125, 10, 16690000, 18359000, N'CPU Intel Core i5 5200U (2.2Ghz up to 2.7GHz)/ Ram 4GB 1600MHz DDR3/ HDD 500GB 5400rpm/ VGA AMD Raedon HD R7 M270 4GB/ Display 15.6" LED HD(1366x768)/ Windows 8.1', N'Dell', N'120_5276_dell_inpiron_14_3442.jpg', NULL)
INSERT [dbo].[tblSanPham] ([MaSP], [TenSP], [MaLH], [SoLuong], [LoiNhuan], [GiaNhap], [GiaBan], [MoTa], [NSX], [HinhAnh], [NhaCC]) VALUES (N'SP00000005', N'Dell Inspiron 15R N5548 M5I52652 Silver', N'LH1       ', 120, 10, 15550000, 17105000, N'CPU Intel Core i5 5200U (2.2Ghz up to 2.7GHz)/ Ram 4GB 1600MHz DDR3/ HDD 500GB 5400rpm/ VGA AMD Raedon HD R7 M270 4GB/ Display 15.6" LED HD(1366x768)/ Free Dos', N'Dell', N'120_5277_dell_inspiron_14_3442_reviews.jpg', NULL)
INSERT [dbo].[tblSanPham] ([MaSP], [TenSP], [MaLH], [SoLuong], [LoiNhuan], [GiaNhap], [GiaBan], [MoTa], [NSX], [HinhAnh], [NhaCC]) VALUES (N'SP00000006', N'Dell Inspiron 15R N5548 M5I5610W Silver', N'LH1       ', 120, 10, 15690000, 17259000, N'CPU Intel Core i5 5200U (2.2Ghz up to 2.7GHz)/ Ram 4GB 1600MHz DDR3/ HDD 500GB 5400rpm/ VGA AMD Raedon HD R7 M265 2GB/ Display 15.6" LED HD(1366x768)/ Windows 8.1', N'Dell', N'120_5278_laptop_latitude_3340_screen.jpg', NULL)
INSERT [dbo].[tblSanPham] ([MaSP], [TenSP], [MaLH], [SoLuong], [LoiNhuan], [GiaNhap], [GiaBan], [MoTa], [NSX], [HinhAnh], [NhaCC]) VALUES (N'SP00000007', N'Dell Inspiron 14 N3442 C4I72252 Black', N'LH1       ', 130, 10, 15690000, 17259000, N'CPU Intel Core i7-5500U (2.4Ghz upto 3.0Ghz, 4MB Cache L3)/Ram 4GB DDR3L 1600Mhz/ HDD 500GB 5400rpm/ VGA Nvidia GeForce GT840M 2GB/ Display 14.0" LED HD(1366x768)/ Free Dos', N'Dell', N'120_5279_4821_.jpg', NULL)
INSERT [dbo].[tblSanPham] ([MaSP], [TenSP], [MaLH], [SoLuong], [LoiNhuan], [GiaNhap], [GiaBan], [MoTa], [NSX], [HinhAnh], [NhaCC]) VALUES (N'SP00000008', N'Dell Insprion 15 N3531 V5C001W Black', N'LH1       ', 135, 10, 69990000, 76989000, N'CPU Intel Celeron N2830(2.16GHz Burst Frequenc 2.41GHz, 1MB Cache)/ Ram 4GB DDR3 1600Mhz/ HDD 500GB 5400Rpm/ VGA Intel HD Graphics/ Display 15.6" LED (1366x768)/ Windows 8.1', N'Dell', N'120_5302_dell_inspiron_11_3148.jpg', NULL)
INSERT [dbo].[tblSanPham] ([MaSP], [TenSP], [MaLH], [SoLuong], [LoiNhuan], [GiaNhap], [GiaBan], [MoTa], [NSX], [HinhAnh], [NhaCC]) VALUES (N'SP00000009', N'Dell Inspiron N7447A P55G001-TI54504W81 Black', N'LH1       ', 120, 10, 179990000, 197989000, N'CPU Intel Core i5-4200H (2.8GHz Max Turbo Boost 3.4GHz, 3M Cache)/ Ram 4GB DDR3L 1600MHz/ HDD 500GB 5400rpm/ VGA Nvidia GeForce GTX850M 4GB/ Display 14 inch HD(1366x768)/ OS Windows 8.1', N'Dell', N'120_5367_dell_xps_12_duo_xi5402w.jpg', NULL)
INSERT [dbo].[tblSanPham] ([MaSP], [TenSP], [MaLH], [SoLuong], [LoiNhuan], [GiaNhap], [GiaBan], [MoTa], [NSX], [HinhAnh], [NhaCC]) VALUES (N'SP00000010', N'Dell Inspiron T7347A P57G001-TI34500W8.1 Silver', N'LH1       ', 110, 10, 16390000, 18029000, N'CPU Intel Core i3-4010U (1.7Ghz, 3MB Cache L3)/ Ram 4GB Buss 1600Mhz/ HDD 500GB 5400rpm/ VGA Intel HD Graphic 4400/ Display 13.3" LED Backlit Display - Touch Screen - Màn hình c?m ?ng da di?m ch?m - Xoay 360 Ð?/ OS Windows 8.1', N'Dell', N'120_5394_4769_.jpg', NULL)
INSERT [dbo].[tblSanPham] ([MaSP], [TenSP], [MaLH], [SoLuong], [LoiNhuan], [GiaNhap], [GiaBan], [MoTa], [NSX], [HinhAnh], [NhaCC]) VALUES (N'SP00000011', N'Dell Latitude L3540B P28F004-TI54500', N'LH1       ', 120, 10, 13690000, 15059000, N'CPU Intel Core i5-4210U (1.7GHz upto 2.7Ghz, 3MB Cache L3)/ Ram 4GB DDR3 1600Mhz/ HDD 500GB 5400rpm/ VGA Intel HD Graphics 4400/ Display 15.6" LED HD(1366x768)/ Free Dos', N'Dell', N'120_5395_246540_98437.JPG', NULL)
INSERT [dbo].[tblSanPham] ([MaSP], [TenSP], [MaLH], [SoLuong], [LoiNhuan], [GiaNhap], [GiaBan], [MoTa], [NSX], [HinhAnh], [NhaCC]) VALUES (N'SP00000012', N'Dell Inspiron 15R N5547 M5I5609W Silver', N'LH1       ', 120, 10, 15090000, 16599000, N'CPU Intel Core i5 4210U (1.7Ghz up to 2.7 Ghz )/ Ram 4GB 1600MHz DDR3/ HDD 500G 5400rpm/ VGA AMD Raedon HD R7 M265 2GB/ Display 15.6" LED HD(1366x768)/ Windows 8.1', N'Dell', N'120_5396_01.jpg', NULL)
INSERT [dbo].[tblSanPham] ([MaSP], [TenSP], [MaLH], [SoLuong], [LoiNhuan], [GiaNhap], [GiaBan], [MoTa], [NSX], [HinhAnh], [NhaCC]) VALUES (N'SP00000013', N'Dell Inspiron 14 5442 M4I324PW Black', N'LH1       ', 120, 10, 10790000, 11869000, N'CPU Intel Core i3 4005U (2*1.7Ghz, 3MB Cache L3)/ Ram 4GB DDR3 1600Mhz/ HDD 500GB 5400rpm/VGA Intel HD Graphics 4400/ Display 14.0 HD(1366x768)/ Windows 8.1', N'Dell', N'120_5493_5272_1077_dell_inspiron_n7447_mjwkv1_3.jpg', NULL)
INSERT [dbo].[tblSanPham] ([MaSP], [TenSP], [MaLH], [SoLuong], [LoiNhuan], [GiaNhap], [GiaBan], [MoTa], [NSX], [HinhAnh], [NhaCC]) VALUES (N'SP00000014', N'Dell Inspiron 15 N3542 C5I3325W Black', N'LH1       ', 123, 10, 11550000, 12705000, N'CPU Intel Core i3-4030U (1.9Ghz, 3MB Cache)/ Ram 4GB DDR3 1600Mhz/ HDD 1TB 5400rpm/ VGA Intel HD Graphics 4400/ Display 15.6 inch LED HD(1366x768)/ Windows 8.1', N'Dell', N'120_5492_dell_inspiron_t7347a.jpg', NULL)
INSERT [dbo].[tblSanPham] ([MaSP], [TenSP], [MaLH], [SoLuong], [LoiNhuan], [GiaNhap], [GiaBan], [MoTa], [NSX], [HinhAnh], [NhaCC]) VALUES (N'SP00000015', N'Dell Inspiron 15 3542 C15I328PW Black', N'LH1       ', 120, 10, 11480000, 12628000, N'CPU Intel Core i3-4005U (1.7Ghz, 3MB Cache)/ Ram 4GB DDR3 1600Mhz/ HDD 500GB 5400rpm/ VGA Nvidia GeForce Geforce 820M 2GB/ Display 15.6 inch LED HD(1366x768)/ Windows 8.1', N'Dell', N'120_5555_53_500x500.jpg', NULL)
INSERT [dbo].[tblSanPham] ([MaSP], [TenSP], [MaLH], [SoLuong], [LoiNhuan], [GiaNhap], [GiaBan], [MoTa], [NSX], [HinhAnh], [NhaCC]) VALUES (N'SP00000016', N'Asus fonepad 7 FE170CG 6B008A White', N'LH2       ', 110, 10, 2750000, 3025000, N'Processor Intel Atom Multi-Core Z2520 1.2 GHz/ Ram 1GB/ B? nh? trong 8GB /wifi / 3G / BlueTooth / Dual SIM / 7 inch WSVGA (1024 X 600)/ 0.3MP Front / 2.0 MP Cam.Rear / Android 4.3/ Black - Tablet Chính hãng', N'Asus', N'120_4232_0_p_500.jpg', NULL)
INSERT [dbo].[tblSanPham] ([MaSP], [TenSP], [MaLH], [SoLuong], [LoiNhuan], [GiaNhap], [GiaBan], [MoTa], [NSX], [HinhAnh], [NhaCC]) VALUES (N'SP00000017', N'Asus fonepad 7 FE170CG 1A026A Black', N'LH2       ', 120, 10, 2750000, 3025000, N'Processor Intel Atom Multi-Core Z2520 1.2 GHz/ Ram 1GB/ B? nh? trong 8GB /wifi / 3G / BlueTooth / Dual SIM / 7 inch WSVGA (1024 X 600)/ 0.3MP Front / 2.0 MP Cam.Rear / Android 4.3/ Black - Tablet Chính hãng', N'Asus', N'120_4610_0_index.jpg', NULL)
INSERT [dbo].[tblSanPham] ([MaSP], [TenSP], [MaLH], [SoLuong], [LoiNhuan], [GiaNhap], [GiaBan], [MoTa], [NSX], [HinhAnh], [NhaCC]) VALUES (N'SP00000018', N'Lenovo Yoga 10 HD+ B8080-H 5941-2210 Gold', N'LH2       ', 110, 10, 8330000, 9163000, N'Processor Qualcomm® Snapdragon™ 400 Quad-Core MSM8228 (4*1.6GHz, 4*1MB L2 cache)/Ram 2GB LPDDR2/ B? nh? trong 32GB eMMC, mSD upto 64GB/ Màn hình 10.1FHD IPS 1920*1200/ 3.5G: HSPA+, WiFi: 802.11b/g/n, Bluetooth: 4.0/ Camera Rear: 8MP, Front: 1.6MP/ Tr?ng lu?ng 628g/ Os Android 4.3', N'Lenovo', N'120_4826_1_index.jpg', NULL)
INSERT [dbo].[tblSanPham] ([MaSP], [TenSP], [MaLH], [SoLuong], [LoiNhuan], [GiaNhap], [GiaBan], [MoTa], [NSX], [HinhAnh], [NhaCC]) VALUES (N'SP00000019', N'Lenovo Yoga 10 HD+ B8080-H 5941-1683 Silver', N'LH2       ', 120, 10, 8330000, 9163000, N'Processor Qualcomm® Snapdragon™ 400 Quad-Core MSM8228 (4*1.6GHz, 4*1MB L2 cache)/Ram 2GB LPDDR2/ B? nh? trong 32GB eMMC, mSD upto 64GB/ Màn hình 10.1FHD IPS 1920*1200/ 3.5G: HSPA+, WiFi: 802.11b/g/n, Bluetooth: 4.0/ Camera Rear: 8MP, Front: 1.6MP/ Tr?ng lu?ng 628g/ Os Android 4.3', N'Lenovo', N'120_4827_0_images.jpg', NULL)
INSERT [dbo].[tblSanPham] ([MaSP], [TenSP], [MaLH], [SoLuong], [LoiNhuan], [GiaNhap], [GiaBan], [MoTa], [NSX], [HinhAnh], [NhaCC]) VALUES (N'SP00000020', N'Lenovo Yoga 2-830 5942-9240 Platinum', N'LH2       ', 123, 10, 7410000, 8151000, N'Processor Intel® Quad-Core Z3745 (4*1.33GHz, Turbo Boot 1,86Ghz, 4Theads, 2MB L2 cache, 64 bit)/Ram 2GB LP-DDR3/ B? nh? trong 16GB eMMC, mSD upto 64GB/ VGA Intel HD Graphics/ Màn hình 8.0 Full HD IPS 1920*1200/Voice Call 4G-LTE, Wi-Fi 802.11 a/b/g/n, MiMo, 2.4GHz&5GHz Dual Band, Bluetooth 4.0/ Camera Rear: 8MP, Front: 1.6MP/ Tr?ng lu?ng 400g/ Os Android 4.4', N'Lenovo', N'120_4828_0_17433_13591_lenovo_ideatab_a5500_white.jpg', NULL)
INSERT [dbo].[tblSanPham] ([MaSP], [TenSP], [MaLH], [SoLuong], [LoiNhuan], [GiaNhap], [GiaBan], [MoTa], [NSX], [HinhAnh], [NhaCC]) VALUES (N'SP00000021', N'Lenovo S8-50 5942-9256 Yellow', N'LH2       ', 123, 10, 6030000, 6633000, N'Processor Intel Quad-Core Z3745 *1.33GHz, Turbo Boot 1,86Ghz, 4Theads, 2MB L2 cache, 64 bit)/Ram 2GB LP-DDR3/ B? nh? trong 16GB eMMC, mSD upto 64GB/ VGA Intel HD Graphics/ Màn hình 8.0 Full HD IPS 1920*1200/ Voice Call 4G-FDD LTE, WiFi: 802.11a/b/g/n, Bluetooth: 4.0, Satellite: GPS+A-GPS/ Camera Rear: 8MP, Front: 1.6MP/ Tr?ng lu?ng 299g/ Os Android 4.4', N'Lenovo', N'120_4829_0_41wmizg4fql.jpg', NULL)
INSERT [dbo].[tblSanPham] ([MaSP], [TenSP], [MaLH], [SoLuong], [LoiNhuan], [GiaNhap], [GiaBan], [MoTa], [NSX], [HinhAnh], [NhaCC]) VALUES (N'SP00000022', N'Lenovo S8-50 5942-9258 Ebony', N'LH2       ', 123, 10, 6030000, 6633000, N'Processor Intel Quad-Core Z3745 *1.33GHz, Turbo Boot 1,86Ghz, 4Theads, 2MB L2 cache, 64 bit)/Ram 2GB LP-DDR3/ B? nh? trong 16GB eMMC, mSD upto 64GB/ VGA Intel HD Graphics/ Màn hình 8.0 Full HD IPS 1920*1200/ Voice Call 4G-FDD LTE, WiFi: 802.11a/b/g/n, Bluetooth: 4.0, Satellite: GPS+A-GPS/ Camera Rear: 8MP, Front: 1.6MP/ Tr?ng lu?ng 299g/ Os Android 4.4', N'Lenovo', N'120_5038_0_8000_b1_7400.jpg', NULL)
INSERT [dbo].[tblSanPham] ([MaSP], [TenSP], [MaLH], [SoLuong], [LoiNhuan], [GiaNhap], [GiaBan], [MoTa], [NSX], [HinhAnh], [NhaCC]) VALUES (N'SP00000023', N'Lenovo A7-50 A3500-HV 5941-2099 Blue', N'LH2       ', 120, 10, 3350000, 3685000, N'Processor MediaTek® Quad-Core MT8382(4*1.3GHz, 4*256KB L2)/Ram 1GB LPDDR2/ B? nh? trong 16GB eMMC, mSD upto 32GB/ Màn hình 7.0HD IPS(1280*800)/ Voice Call 3.5G: HSPA+, WiFi: 802.11b/g/n, Bluetooth: 4.0/ Camera Rear: 5MP, Front: 2 MP/ Tr?ng lu?ng 320g/ Os Android 4.4', N'Lenovo', N'120_5039_2_iconiaone7_b1.jpg', NULL)
INSERT [dbo].[tblSanPham] ([MaSP], [TenSP], [MaLH], [SoLuong], [LoiNhuan], [GiaNhap], [GiaBan], [MoTa], [NSX], [HinhAnh], [NhaCC]) VALUES (N'SP00000024', N'Lenovo A7-30 A3300-HV 5942-5674 Black', N'LH2       ', 123, 10, 2610000, 2871000, N'Processor MediaTek® Quad-Core MT8382(4*1.3GHz, 4*256KB L2)/Ram 1GB LPDDR2/ B? nh? trong 8GB eMMC, mSD upto 32GB/ Màn hình 7.0 WSVGA (1024*600)/ Voice Call 3.5G: HSPA+, WiFi: 802.11b/g/n, Bluetooth: 4.0/ Camera Rear: 2MP, Front: 1.2 MP/ Tr?ng lu?ng 327g/ Os Android 4.4', N'Lenovo', N'120_5040_0_iconia_a1_830.jpg', NULL)
INSERT [dbo].[tblSanPham] ([MaSP], [TenSP], [MaLH], [SoLuong], [LoiNhuan], [GiaNhap], [GiaBan], [MoTa], [NSX], [HinhAnh], [NhaCC]) VALUES (N'SP00000025', N'Tablet Dell Venue 7 3740 1FC3C', N'LH2       ', 123, 10, 3690000, 4059000, N'Processor Intel Atom Z3460 (2*1.60GHz, 2Threads, 1MB L2 cache, 64bit)/ Ram 1GB DDR3/ B? nh? 16GB/ Màn hình c?m ?ng 7.0 HD IPS 1280*800/ K?t n?i Wifi 802.11 a/b/g/n/ac + Bluetooth 4.0/ Pin 4550mAh up to 8.9hours/ OS Android 4.4', N'Dell', N'120_5041_0_acer_713_maxx.jpg', NULL)
INSERT [dbo].[tblSanPham] ([MaSP], [TenSP], [MaLH], [SoLuong], [LoiNhuan], [GiaNhap], [GiaBan], [MoTa], [NSX], [HinhAnh], [NhaCC]) VALUES (N'SP00000026', N'Tablet Dell Venue 8 3840 6GY6F', N'LH2       ', 123, 10, 5550000, 6105000, N'Processor Intel Atom Processor Z3480 (1M Cache, up to 2.13 GHz)/ Ram 1GB DDR3/ B? nh? 16GB/ Màn hình c?m ?ng 8.0" IPS Full HD(1920x1200)/Call/4G/Bluetooth/HSPA+ WiFi: 802.11 a/b/g/n/ac GPS/ Camera tru?c 2Mpx/ Camera sau 5Mpx/ Pin 4550mAh 8.9hours/ OS Android 4.4', N'Dell', N'120_5042_1_acer_iconia_tab_7_a1_713hd__43066_zoom.jpg', NULL)
INSERT [dbo].[tblSanPham] ([MaSP], [TenSP], [MaLH], [SoLuong], [LoiNhuan], [GiaNhap], [GiaBan], [MoTa], [NSX], [HinhAnh], [NhaCC]) VALUES (N'SP00000027', N'Mouse Optical Logitech B100', N'LH3       ', 123, 10, 190000, 209000, N'Model • Logitech B100 Chu?n chu?t • Chu?t quang có dây C?ng k?t n?i • USB Ð? phân gi?i • 800dpi Ch?c nang d?c bi?t • Chu?t di chuy?n d? dàng và r?t tho?i mái, b?n s? ki?m soát chu?t c?c t?t khi dùng thêm mi?ng lót chu?t. B?n có th? d? dàng di chuy?n con tr? chu?t ch? b?ng m?t cái l?c c? tay nh? nhàng, b?n có th? c?m nh?n du?c d? chính xác c?a con tr? trong qua trình làm vi?c ho?c gi?i trí.', N'Logitech', N'120_46_index.jpg', NULL)
INSERT [dbo].[tblSanPham] ([MaSP], [TenSP], [MaLH], [SoLuong], [LoiNhuan], [GiaNhap], [GiaBan], [MoTa], [NSX], [HinhAnh], [NhaCC]) VALUES (N'SP00000028', N'Mouse Lenovo 1000 không dây', N'LH3       ', 123, 13, 1200000, 1356000, N'Hãng s?n xu?t: Microsoft Xu?t x?:Chính hãng B?o hành:36 tháng Lo?i chu?t:Không dây Ki?u giao ti?p:USB Wireless S? d?ng cho:PC,laptop Ð? phân gi?i quang h?c: 1000 dpi S? nút: 2 nút', N'Lenovo', N'120_5387_asus_2126.jpg', NULL)
INSERT [dbo].[tblSanPham] ([MaSP], [TenSP], [MaLH], [SoLuong], [LoiNhuan], [GiaNhap], [GiaBan], [MoTa], [NSX], [HinhAnh], [NhaCC]) VALUES (N'SP00000029', N'Mouse HP không dây X4000', N'LH3       ', 123, 10, 299000, 328900, N'Hãng s?n xu?t HP Xu?t x? Chính Hãng B?o hành : 12 tháng Lo?i chu?t : Không dây Ki?u giao ti?p : USB S? d?ng cho :PC,Laptop Ð? phân gi?i quang h?c: 1600 dpi S? nút : 2 nút', N'HP', N'120_5389_fm_512.jpg', NULL)
INSERT [dbo].[tblSanPham] ([MaSP], [TenSP], [MaLH], [SoLuong], [LoiNhuan], [GiaNhap], [GiaBan], [MoTa], [NSX], [HinhAnh], [NhaCC]) VALUES (N'SP00000030', N'Mouse HP X1500', N'LH3       ', 123, 10, 135000, 148500, N'Hãng s?n xu?t : HP Lo?i : Chu?t Quang Ki?u giao ti?p : Có dây Dành cho : Ngu?i thu?n tay trái ho?c tay ph?i Ð? phân gi?i quang h?c : 800 dpi Tính nang : Thi?t k? d?ng 03 nút v?i bánh cu?n van b?n, H? tr? plug and play không c?n cài driver', N'HP', N'120_5532_p.png', NULL)
INSERT [dbo].[tblSanPham] ([MaSP], [TenSP], [MaLH], [SoLuong], [LoiNhuan], [GiaNhap], [GiaBan], [MoTa], [NSX], [HinhAnh], [NhaCC]) VALUES (N'SP00000031', N'Keyboard & Mouse Newmen R095', N'LH3       ', 123, 10, 390000, 429000, N'B? bàn Phím + Chu?t Không dây, m?ng, d?p. Phím nh?y, gõ êm, chu?t d? phân gi?i 1000DPI. Thích h?p dùng cho h? th?ng HTPC phòng khách và mang di mang l?i.', N'Newmen', N'120_5494_0001569_keyboard_newmen_e360_usb.jpeg', NULL)
INSERT [dbo].[tblSanPham] ([MaSP], [TenSP], [MaLH], [SoLuong], [LoiNhuan], [GiaNhap], [GiaBan], [MoTa], [NSX], [HinhAnh], [NhaCC]) VALUES (N'SP00000032', N'Keyboard Newmen E360 ', N'LH3       ', 123, 10, 195000, 214500, N'"Bàn phím Keyboard Newmen E360 giành cho game th?,ch?ng nu?c, th?i trang. Nút b?m to, êm, t?o c?m giác r?t tho?i mái. Tích h?p 11 phím nóng di?u khi?n d? dàng: Ch?p hình, Âm thanh, Duy?t Web,… Giao di?n PS/2, c?m là có th? ch?y. S? d?ng công ngh? in kh?c Laser siêu b?n. Có th? thi?t l?p ch?c nang c?a các Phím tùy ý theo s? thích b?ng ph?n m?m c?a Newmen. S? d?ng cho: Desktop PC"', N'Newmen', N'120_5495_3037_3_newmen_r095_4.jpg', NULL)
INSERT [dbo].[tblSanPham] ([MaSP], [TenSP], [MaLH], [SoLuong], [LoiNhuan], [GiaNhap], [GiaBan], [MoTa], [NSX], [HinhAnh], [NhaCC]) VALUES (N'SP00000033', N'Màn hình Dell E2414H 24" LED ', N'LH3       ', 123, 10, 3560000, 3916000, N'- Kích thuo´c: 24" - Ð? phân gi?i: 1920x1080 - Ð? sáng: 250cd/m2 - T? l? tuong ph?n: 1.000:1 - Th?i gian dáp ?ng: 5ms - Góc nhìn: 170°(H)/160°(V) - C?ng k?t n?i: VGA - C?ng k?t n?i: DVI', N'Dell', N'120_5403_195_0549_23565.jpg', NULL)
INSERT [dbo].[tblSanPham] ([MaSP], [TenSP], [MaLH], [SoLuong], [LoiNhuan], [GiaNhap], [GiaBan], [MoTa], [NSX], [HinhAnh], [NhaCC]) VALUES (N'SP00000034', N'Màn hình Dell P1914S 19" LED ', N'LH3       ', 123, 15, 3405000, 3915750, N'- Kích thu?c: 19" - Ð? phân gi?i: 1280 x 1024 - Ð? sáng: 250cd/m2 - T? l? tuong ph?n: 1000-1 - Th?i gian dáp ?ng: 8ms - C?ng k?t n?i: VGA & DVI', N'Dell', N'120_5404_5036143man_hinh_dell_p2414h_23_8_inch_led.jpg', NULL)
INSERT [dbo].[tblSanPham] ([MaSP], [TenSP], [MaLH], [SoLuong], [LoiNhuan], [GiaNhap], [GiaBan], [MoTa], [NSX], [HinhAnh], [NhaCC]) VALUES (N'SP00000035', N'Màn hình Dell S2740L 27" LED ', N'LH3       ', 123, 10, 8105000, 8915500, N'- Kích thu?c: 27" - Ð? phân gi?i: 1920x1080 - Ð? sáng: 250cd/m2 - T? l? tuong ph?n: 8.000.000:1 - Th?i gian dáp ?ng: 7ms - C?ng k?t n?i: D-Sub - C?ng k?t n?i: HDMI', N'Dell', N'120_5406_u2414h.jpg', NULL)
INSERT [dbo].[tblSanPham] ([MaSP], [TenSP], [MaLH], [SoLuong], [LoiNhuan], [GiaNhap], [GiaBan], [MoTa], [NSX], [HinhAnh], [NhaCC]) VALUES (N'SP00000036', N'Màn hình Dell E2214H 21.5inch LED Full HD', N'LH3       ', 123, 10, 3010000, 3311000, N'Kích Thu?c Màn Hình 21.5" Wide LED Ð? Sáng Màn Hình 250 cd/m² T? L? Tuong Ph?n Ð?ng MEGA 1000 : 1 Ð? Phân Gi?i Màn Hình 1920 x 1080', N'Dell', N'120_5419_p2815q.jpg', NULL)
INSERT [dbo].[tblSanPham] ([MaSP], [TenSP], [MaLH], [SoLuong], [LoiNhuan], [GiaNhap], [GiaBan], [MoTa], [NSX], [HinhAnh], [NhaCC]) VALUES (N'SP00000037', N'Ram PC G.skill 4GB DDR3 Buss 1600Mhz', N'LH3       ', 123, 10, 850000, 935000, N'Ram PC Gskin, DDRAM III, dung lu?ng 4Gb, bus 1600, PC3 1600', N'Kington', N'120_5409_ram_evm_sodimm.jpg', NULL)
INSERT [dbo].[tblSanPham] ([MaSP], [TenSP], [MaLH], [SoLuong], [LoiNhuan], [GiaNhap], [GiaBan], [MoTa], [NSX], [HinhAnh], [NhaCC]) VALUES (N'SP00000038', N'AP TP-Link 720N', N'LH4       ', 123, 10, 250000, 275000, N'Hãng s?n xu?t: TP Link S? c?ng k?t n?i: 1 RJ45 WAN, 2 x RJ45 T?c d? truy?n d? li?u: 10/100Mbps Chu?n giao ti?p: IEEE 802.11b, IEEE 802.11g, IEEE 802.11n', N'TP-Link', N'120_2301_2301_3476.jpg', NULL)
INSERT [dbo].[tblSanPham] ([MaSP], [TenSP], [MaLH], [SoLuong], [LoiNhuan], [GiaNhap], [GiaBan], [MoTa], [NSX], [HinhAnh], [NhaCC]) VALUES (N'SP00000039', N'PCI TP-LINK WN781ND', N'LH4       ', 123, 10, 260000, 286000, N'TPlink TL-WN781ND Wireles: Card m?ng wireless PCI - Express 1x 150Mbps chu?n N, Atheros chipset, 1T1R, 2.4GHz, compatible with 802.11n/g/b, Ang-ten r?i', N'TP-Link', N'120_2303_2303_3485.jpg', NULL)
INSERT [dbo].[tblSanPham] ([MaSP], [TenSP], [MaLH], [SoLuong], [LoiNhuan], [GiaNhap], [GiaBan], [MoTa], [NSX], [HinhAnh], [NhaCC]) VALUES (N'SP00000040', N'Thiết bị mạng ko dây Asus USB-N10', N'LH4       ', 123, 10, 440000, 484000, N'Thi?t b? m?ng ko dây Asus USB-N10', N'Asus', N'120_2305_2305_4652.jpg', NULL)
INSERT [dbo].[tblSanPham] ([MaSP], [TenSP], [MaLH], [SoLuong], [LoiNhuan], [GiaNhap], [GiaBan], [MoTa], [NSX], [HinhAnh], [NhaCC]) VALUES (N'SP00000041', N'Tp_Link TL-WR740N', N'LH4       ', 123, 10, 290000, 319000, N'150M Wireless N Router, Athreos chipset, 1T1R, 2.4GHz, work with 802.11n product, compatible with 802.11g/b, 4 10/100 LAN, 1 10/100 WAN, SPI firewall, autorun utility, Ang-ten li?n.', N'TP-Link', N'120_2304_2304_4651.jpg', NULL)
INSERT [dbo].[tblSanPham] ([MaSP], [TenSP], [MaLH], [SoLuong], [LoiNhuan], [GiaNhap], [GiaBan], [MoTa], [NSX], [HinhAnh], [NhaCC]) VALUES (N'SP00000042', N'Bộ định tuyến Asus RT-N56U', N'LH4       ', 123, 10, 3090000, 3399000, N'300Mbits Stylish Concurrent Dual Band (300+300) Wireless-N Gigabit Router', N'Asus', N'120_2306_2306_3497.jpg', NULL)
INSERT [dbo].[tblSanPham] ([MaSP], [TenSP], [MaLH], [SoLuong], [LoiNhuan], [GiaNhap], [GiaBan], [MoTa], [NSX], [HinhAnh], [NhaCC]) VALUES (N'SP00000043', N'Bộ thu phát Asus RT-N12HP', N'LH4       ', 123, 10, 1460000, 1606000, N'- Wifi 300Mbits High Performance Router/Repeater/Bridge - k?t n?i: 4xRJ45, 1xWAN/ - 2x ang ten tháo d?i 9 dBi - Công su?t phát c?c m?nh, g?p hon 3 l?n so v?i các Wireless router thông thu?ng - Multi SSID*4 (t?o 4 m?ng wifi cùng lúc, v?i SSID, pasword khác nhau.)', N'Asus', N'120_3631_tl_mr3020_01.jpg', NULL)
INSERT [dbo].[tblSanPham] ([MaSP], [TenSP], [MaLH], [SoLuong], [LoiNhuan], [GiaNhap], [GiaBan], [MoTa], [NSX], [HinhAnh], [NhaCC]) VALUES (N'SP00000044', N'TL-MR3020 Router chuẩn N không dây 3G/3.75G ', N'LH4       ', 123, 10, 530000, 583000, N'Nhu~ng Tính Nang Nô?i Bâ?t: Chia s? k?t n?i di d?ng 3G, tuong thích v?i các modem USB 3G bang t?n 120+ UMTS/HSPA/EVDO dã du?c th? nghi?m trong môi tru?ng này Ki?u dáng du l?ch, nh? g?n d? dàng mang theo bên mình, cho phép ngu?i dùng chia s? m?t k?t n?i di d?ng 3G ? b?t c? noi nào có sóng 3G bao ph? T?c d? không dây lên d?n 150Mbps 3 ch? d? thích h?p v?i nhi?u tình hu?ng khác nhau: Ch? d? 3G Router, WISP Client Router và Travel (AP Mode) V?i ch? d? d? phòng 3G/WAN, thi?t b? TL-MR3020 có th? cung c?p m?t k?t n?i internet b?n b? *Ho?t d?ng t?t v?i USB 3G c?a Mobifone, Vinaphone và Viettel (Firmware m?i nh?t). ', N'TP-Link', N'120_3929_neo_x5_1.jpg', NULL)
INSERT [dbo].[tblSanPham] ([MaSP], [TenSP], [MaLH], [SoLuong], [LoiNhuan], [GiaNhap], [GiaBan], [MoTa], [NSX], [HinhAnh], [NhaCC]) VALUES (N'SP00000045', N'Modem ADSL2+ tích hợp Wireless TP-Link TD-W8961ND', N'LH4       ', 123, 10, 980000, 1078000, N'300Mb Wireless ADSL2+ Router with 4 Ports LAN ethernet, wireless chu?n N 300Mbps (2T2R) & tuong thích ngu?c v?i chu?n 802.11b/g, tính nang DHCP server + NAT + DMZ + Firewall…ch?ng sét 4000V + support IPTV, 2 Ang-ten 3 dBi r?i ', N'TP-Link', N'120_4441_0_8_bd33942_c0_68914_b.jpg', NULL)
ALTER TABLE [dbo].[tblHoaDonBan] ADD  CONSTRAINT [HDB_NB_DF]  DEFAULT (getdate()) FOR [NgayBan]
GO
ALTER TABLE [dbo].[tblPhieuBaoHanh] ADD  CONSTRAINT [PBH_NBD_DF]  DEFAULT (getdate()) FOR [NgayBatDau]
GO
ALTER TABLE [dbo].[tblChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [CTHD_MAHDB_FK] FOREIGN KEY([MaHD])
REFERENCES [dbo].[tblHoaDonBan] ([MaHDB])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblChiTietHoaDon] CHECK CONSTRAINT [CTHD_MAHDB_FK]
GO
ALTER TABLE [dbo].[tblChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [CTHDB_MASP_FK] FOREIGN KEY([MaSP])
REFERENCES [dbo].[tblSanPham] ([MaSP])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblChiTietHoaDon] CHECK CONSTRAINT [CTHDB_MASP_FK]
GO
ALTER TABLE [dbo].[tblHoaDonBan]  WITH CHECK ADD  CONSTRAINT [HDB_MAKH_FK] FOREIGN KEY([MaKH])
REFERENCES [dbo].[tblKhachHang] ([MaKH])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[tblHoaDonBan] CHECK CONSTRAINT [HDB_MAKH_FK]
GO
ALTER TABLE [dbo].[tblPhieuBaoHanh]  WITH CHECK ADD  CONSTRAINT [PBH_MAKH_FK] FOREIGN KEY([MaKH])
REFERENCES [dbo].[tblKhachHang] ([MaKH])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[tblPhieuBaoHanh] CHECK CONSTRAINT [PBH_MAKH_FK]
GO
ALTER TABLE [dbo].[tblPhieuBaoHanh]  WITH CHECK ADD  CONSTRAINT [PBH_MASP_FK] FOREIGN KEY([MaSP])
REFERENCES [dbo].[tblSanPham] ([MaSP])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[tblPhieuBaoHanh] CHECK CONSTRAINT [PBH_MASP_FK]
GO
ALTER TABLE [dbo].[tblSanPham]  WITH CHECK ADD  CONSTRAINT [FK_SANPHAM_NHACUNGCAP] FOREIGN KEY([NhaCC])
REFERENCES [dbo].[tblNhaCungCap] ([TenNCC])
GO
ALTER TABLE [dbo].[tblSanPham] CHECK CONSTRAINT [FK_SANPHAM_NHACUNGCAP]
GO
ALTER TABLE [dbo].[tblSanPham]  WITH CHECK ADD  CONSTRAINT [SP_MALH_FK] FOREIGN KEY([MaLH])
REFERENCES [dbo].[tblLoaiHang] ([MaLH])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[tblSanPham] CHECK CONSTRAINT [SP_MALH_FK]
GO
USE [master]
GO
ALTER DATABASE [Bai6_BanHangSieuThi] SET  READ_WRITE 
GO
