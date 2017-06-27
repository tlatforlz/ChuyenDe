USE [QL_THUVIEN]
GO
/****** Object:  StoredProcedure [dbo].[CT_PhieuMuon_PhieuMuon]    Script Date: 6/27/2017 10:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[CT_PhieuMuon_PhieuMuon]
@maphieu nvarchar(50)
as 
begin
select MAPHIEU,s.MASACH,TENSACH,NGAYTRA,TINHTRANGMUON,TRA
from CT_PHIEUMUON as ct,SACH as s,ISBN as i
where ct.MAPHIEU=@maphieu and ct.MASACH=s.MASACH and s.ISBN=i.ISBN
end


GO
/****** Object:  StoredProcedure [dbo].[sp_CapNhatTrangThai_ISBN]    Script Date: 6/27/2017 10:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_CapNhatTrangThai_ISBN]
@CHECK INT,
@MAISBN NCHAR(10)
AS
BEGIN
	UPDATE DBO.ISBN SET TRANGTHAI = @CHECK WHERE ISBN = @MAISBN

	IF(@@ROWCOUNT != 0)
	BEGIN
		RETURN 1	
	END
	
	RETURN 0 -- không tồn tại mã ISBN để cập nhật

END

GO
/****** Object:  StoredProcedure [dbo].[SP_ChuyenQuyen]    Script Date: 6/27/2017 10:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 

 CREATE proc [dbo].[SP_ChuyenQuyen]
 @quyen1 nvarchar(20),
 @quyen2 nvarchar(20),
 @USRNAME nvarchar(20)

 as
 begin
 SET XACT_ABORT ON
BEGIN TRAN
BEGIN TRY
 EXEC sp_droprolemember @quyen1,@USRNAME
 EXEC sp_addrolemember @quyen2, @USRNAME
 COMMIT
END TRY
BEGIN CATCH
ROLLBACK TRAN
   DECLARE @ErrorMessage VARCHAR(2000)
   SELECT @ErrorMessage = 'Lỗi: ' + ERROR_MESSAGE()
   RAISERROR(@ErrorMessage, 16, 1)
END CATCH

 end

GO
/****** Object:  StoredProcedure [dbo].[SP_DangNhap]    Script Date: 6/27/2017 10:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DangNhap] 
@login nvarchar(40)
AS
BEGIN
	SET NOCOUNT ON
	declare @role nvarchar(20)
	declare @tenuser nvarchar(50)
	set @tenuser = (SELECT NAME FROM sys.sysusers WHERE sid = SUSER_SID(@login))
	if @tenuser IS NOT NULL
	begin
		SELECT @role = NAME FROM sys.sysusers 
		WHERE UID = (
					SELECT GROUPUID 
					FROM SYS.SYSMEMBERS 
					WHERE MEMBERUID = ( SELECT UID FROM sys.sysusers WHERE NAME=@tenuser )
					)
		
		begin
			
			select *,@role as 'quyen'
			 from NHANVIEN where MANV = @tenuser

		end
		
	end
END



GO
/****** Object:  StoredProcedure [dbo].[SP_DangNhap_DocGia]    Script Date: 6/27/2017 10:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_DangNhap_DocGia]
@login nvarchar(40)
AS 
BEGIN
SELECT MADG as ma,HODG as ho,TENDG as ten,'DOCGIA' as 'quyen'
FROM DOCGIA
WHERE MADG=@login and TRANGTHAI=0
END

GO
/****** Object:  StoredProcedure [dbo].[SP_DangNhap_NhanVien]    Script Date: 6/27/2017 10:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DangNhap_NhanVien]
@login nvarchar(40)
AS
BEGIN
	SET NOCOUNT ON
	declare @role nvarchar(20)
	declare @tenuser nvarchar(50)
	set @tenuser = (SELECT NAME FROM sys.sysusers WHERE sid = SUSER_SID(@login))
	if @tenuser IS NOT NULL
	begin
		SELECT @role = NAME FROM sys.sysusers 
		WHERE UID = (
					SELECT GROUPUID 
					FROM SYS.SYSMEMBERS 
					WHERE MEMBERUID = ( SELECT UID FROM sys.sysusers WHERE NAME=@tenuser )
					)
		
		begin	
			
			if not exists (select MANV as ma ,HONV as ho ,TENNV as ten,@role as 'quyen'
								from NHANVIEN 
								where MANV = @tenuser and TRANGTHAI=1 )
			
			SELECT MADG as ma,HODG as ho,TENDG as ten,@role as 'quyen'
					FROM DOCGIA
					WHERE SOCMND=@tenuser and TRANGTHAI=1
			else
				(select MANV as ma ,HONV as ho ,TENNV as ten,@role as 'quyen'
								from NHANVIEN 
								where MANV = @tenuser and TRANGTHAI=1 )
			
		end
		
	end
END



GO
/****** Object:  StoredProcedure [dbo].[SP_DocGia_PhieuMuon]    Script Date: 6/27/2017 10:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_DocGia_PhieuMuon]
@maDocGia nvarchar(50)
as 
begin
if (@maDocGia='')
 select MAPHIEU, MADG,MANV,HINHTHUC,NGAYMUON from PHIEUMUON
else
select MAPHIEU, MADG,MANV,HINHTHUC,NGAYMUON from PHIEUMUON where MADG=@maDocGia
end

GO
/****** Object:  StoredProcedure [dbo].[sp_DocGiaMuonSachQuaHan_ThoiGian_KT]    Script Date: 6/27/2017 10:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_DocGiaMuonSachQuaHan_ThoiGian_KT]
@CHECK INT,
@T1 DATETIME,
@T2 DATETIME
AS
BEGIN

			IF(@CHECK = 1) -- ĐỘC GIẢ QUÁ HẠN: ĐÃ TRẢ SÁCH
			BEGIN
				
				SELECT MP_DOCGIA.MADG, (SELECT DBO.DOCGIA.HODG +  DBO.DOCGIA.TENDG FROM DBO.DOCGIA WHERE MP_DOCGIA.MADG = DBO.DOCGIA.MADG) AS N'HỌ TÊN ĐỘC GIẢ',
				MP_DOCGIA.MAPHIEU, CT_PM.MASACH, MP_DOCGIA.NGAYMUON AS N'NGÀY MƯỢN', CT_PM.NGAYTRA AS N'NGÀY TRẢ', ((CASE WHEN CT_PM.NGAYTRA IS NOT NULL THEN DATEDIFF(DD,MP_DOCGIA.NGAYMUON, CT_PM.NGAYTRA) END)) AS N'SỐ NGÀY QUÁ HẠN'
				FROM (SELECT DG_MUON.MADG, PM_1.MAPHIEU, PM_1.NGAYMUON FROM (SELECT PM.MADG FROM DBO.PHIEUMUON PM GROUP BY PM.MADG) DG_MUON INNER JOIN DBO.PHIEUMUON PM_1 ON PM_1.MADG = DG_MUON.MADG AND PM_1.NGAYMUON BETWEEN @T1 AND @T2) MP_DOCGIA 
				INNER JOIN DBO.CT_PHIEUMUON CT_PM ON MP_DOCGIA.MAPHIEU =  CT_PM.MAPHIEU 	
				WHERE  ((CASE WHEN CT_PM.NGAYTRA IS NOT NULL THEN DATEDIFF(DD,MP_DOCGIA.NGAYMUON, CT_PM.NGAYTRA) END)) > 30
				ORDER BY MP_DOCGIA.MADG ASC

			END

			ELSE IF(@CHECK = 2) -- ĐỘC GIẢ QUÁ HẠN: CHƯA TRẢ SÁCH
			BEGIN
				
				SELECT MP_DOCGIA.MADG, (SELECT DBO.DOCGIA.HODG +  DBO.DOCGIA.TENDG FROM DBO.DOCGIA WHERE MP_DOCGIA.MADG = DBO.DOCGIA.MADG) AS N'HỌ TÊN ĐỘC GIẢ',
				MP_DOCGIA.MAPHIEU, CT_PM.MASACH, MP_DOCGIA.NGAYMUON AS N'NGÀY MƯỢN', CT_PM.NGAYTRA AS N'NGÀY TRẢ', (CASE WHEN  CT_PM.NGAYTRA IS NULL THEN (DATEDIFF(DD,MP_DOCGIA.NGAYMUON, GETDATE())) END) AS N'SỐ NGÀY QUÁ HẠN'
				FROM (SELECT DG_MUON.MADG, PM_1.MAPHIEU, PM_1.NGAYMUON FROM (SELECT PM.MADG FROM DBO.PHIEUMUON PM GROUP BY PM.MADG) DG_MUON INNER JOIN DBO.PHIEUMUON PM_1 ON PM_1.MADG = DG_MUON.MADG AND PM_1.NGAYMUON BETWEEN @T1 AND @T2) MP_DOCGIA 
				INNER JOIN DBO.CT_PHIEUMUON CT_PM ON MP_DOCGIA.MAPHIEU =  CT_PM.MAPHIEU 	
				WHERE (CASE WHEN  CT_PM.NGAYTRA IS NULL THEN (DATEDIFF(DD,MP_DOCGIA.NGAYMUON, GETDATE())) END) > 30
				ORDER BY MP_DOCGIA.MADG ASC

			END
			
			ELSE  -- ĐỘC GIẢ QUÁ HẠN: CHƯA TRẢ VÀ ĐÃ TRẢ SÁCH MƯỢN  
			BEGIN
				
				SELECT MP_DOCGIA.MADG, (SELECT DBO.DOCGIA.HODG +  DBO.DOCGIA.TENDG FROM DBO.DOCGIA WHERE MP_DOCGIA.MADG = DBO.DOCGIA.MADG) AS N'HỌ TÊN ĐỘC GIẢ',
				MP_DOCGIA.MAPHIEU, CT_PM.MASACH, MP_DOCGIA.NGAYMUON AS N'NGÀY MƯỢN', CT_PM.NGAYTRA AS N'NGÀY TRẢ', (CASE WHEN CT_PM.NGAYTRA IS NULL THEN DATEDIFF(DD,MP_DOCGIA.NGAYMUON, GETDATE()) ELSE DATEDIFF(DD,MP_DOCGIA.NGAYMUON, CT_PM.NGAYTRA) END) AS N'SỐ NGÀY QUÁ HẠN'
				FROM (SELECT DG_MUON.MADG, PM_1.MAPHIEU, PM_1.NGAYMUON FROM (SELECT PM.MADG FROM DBO.PHIEUMUON PM GROUP BY PM.MADG) DG_MUON INNER JOIN DBO.PHIEUMUON PM_1 ON PM_1.MADG = DG_MUON.MADG AND PM_1.NGAYMUON BETWEEN @T1 AND @T2) MP_DOCGIA 
				INNER JOIN DBO.CT_PHIEUMUON CT_PM ON MP_DOCGIA.MAPHIEU =  CT_PM.MAPHIEU 	
				WHERE  ((CASE WHEN CT_PM.NGAYTRA IS NULL THEN DATEDIFF(DD,MP_DOCGIA.NGAYMUON, GETDATE()) ELSE DATEDIFF(DD,MP_DOCGIA.NGAYMUON, CT_PM.NGAYTRA) END)) > 30
				ORDER BY MP_DOCGIA.MADG ASC

			END	

			
END


GO
/****** Object:  StoredProcedure [dbo].[sp_DocGiaMuonSachQuanHan]    Script Date: 6/27/2017 10:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_DocGiaMuonSachQuanHan]
AS
BEGIN
			SELECT MP_DOCGIA.MADG, (SELECT DBO.DOCGIA.HODG +  DBO.DOCGIA.TENDG FROM DBO.DOCGIA WHERE MP_DOCGIA.MADG = DBO.DOCGIA.MADG) AS N'HỌ TÊN ĐỘC GIẢ',
			MP_DOCGIA.MAPHIEU, CT_PM.MASACH, MP_DOCGIA.NGAYMUON AS N'NGÀY MƯỢN', CT_PM.NGAYTRA AS N'NGÀY TRẢ', DATEDIFF(DD,MP_DOCGIA.NGAYMUON, CT_PM.NGAYTRA) AS N'SỐ NGÀY QUÁ HẠN'
			FROM (SELECT DG_MUON.MADG, PM_1.MAPHIEU, PM_1.NGAYMUON FROM (SELECT PM.MADG FROM DBO.PHIEUMUON PM GROUP BY PM.MADG) DG_MUON INNER JOIN DBO.PHIEUMUON PM_1 ON PM_1.MADG = DG_MUON.MADG) MP_DOCGIA 
			INNER JOIN DBO.CT_PHIEUMUON CT_PM ON MP_DOCGIA.MAPHIEU =  CT_PM.MAPHIEU
			WHERE DATEDIFF(DD,MP_DOCGIA.NGAYMUON, CT_PM.NGAYTRA) > 30
			ORDER BY MP_DOCGIA.MADG ASC
END

GO
/****** Object:  StoredProcedure [dbo].[SP_DS_ISBN]    Script Date: 6/27/2017 10:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_DS_ISBN]
@test nvarchar(3)
as
begin 
select i.ISBN,i.TENSACH,count(i.isbn) as "So Luong"  from ISBN as i,SACH as s
where i.ISBN=s.ISBN and s.CHOMUON=0 
group by i.ISBN,i.TENSACH
having COUNT(i.ISBN)>0
end




GO
/****** Object:  StoredProcedure [dbo].[SP_DSLOGIN]    Script Date: 6/27/2017 10:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROC [dbo].[SP_DSLOGIN]
as
select MANV=tbluser.name , Loginname=tbllogin.name ,  rolename  
from 
  (select uid, name, sid from sys.sysusers where issqluser =1 
  and hasdbaccess =1 and name <> 'dbo') tbluser , 
  (select roleid= uid,  rolename= name from sys.sysusers 
    where issqluser =0  and uid between 1 and 16380) tblrole,
  sys.sysmembers ,
  (select name, sid from sys.syslogins) tbllogin
  where sys.sysmembers.groupuid=tblrole.roleid and 
	sys.sysmembers.memberuid=tbluser.uid and tbluser.sid =tbllogin.sid

GO
/****** Object:  StoredProcedure [dbo].[SP_KiemTra_MuonSach]    Script Date: 6/27/2017 10:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_KiemTra_MuonSach]
@maDG nvarchar(20)
as 
begin
select count(*) as dem
from PHIEUMUON as pm,CT_PHIEUMUON as ct
where pm.MADG=@maDG and pm.MAPHIEU=ct.MAPHIEU and ct.TRA=0
end


GO
/****** Object:  StoredProcedure [dbo].[sp_KiemTraMaISBN_SACH]    Script Date: 6/27/2017 10:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_KiemTraMaISBN_SACH]
@MAISBN NCHAR(10)
AS
BEGIN
	
	IF(EXISTS(SELECT ISBN FROM DBO.SACH WHERE @MAISBN = ISBN))
	BEGIN
		RETURN 1
	END 

	RETURN 0  -- không tồn tại mã MAISBN
	
END

GO
/****** Object:  StoredProcedure [dbo].[sp_KiemTraMaSach_CTPM]    Script Date: 6/27/2017 10:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_KiemTraMaSach_CTPM]
@MASACH NVARCHAR(50)
AS
BEGIN
	IF(EXISTS( SELECT MASACH FROM DBO.CT_PHIEUMUON WHERE @MASACH = MASACH))
	BEGIN
		RETURN 1; -- TỒN TẠI
	END

	RETURN 0;
END

GO
/****** Object:  StoredProcedure [dbo].[SP_KiemTraMaTacGia]    Script Date: 6/27/2017 10:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_KiemTraMaTacGia]
@MATACGIA varchar(10)
AS
BEGIN
	IF EXISTS(SELECT 1 FROM dbo.TACGIA_SACH WHERE dbo.TACGIA_SACH.MATACGIA = @MATACGIA)
	BEGIN
		RETURN 1
	END
	RETURN 0
END

GO
/****** Object:  StoredProcedure [dbo].[sp_LayMaISBN]    Script Date: 6/27/2017 10:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_LayMaISBN]
AS
BEGIN
	SELECT ISBN FROM dbo.ISBN
END

GO
/****** Object:  StoredProcedure [dbo].[sp_LayMaNgonNgu]    Script Date: 6/27/2017 10:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_LayMaNgonNgu]
AS
BEGIN
	SELECT MANGONNGU FROM dbo.NGONNGU
END

GO
/****** Object:  StoredProcedure [dbo].[sp_LayMaTenDauSach]    Script Date: 6/27/2017 10:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_LayMaTenDauSach]
AS
BEGIN
	SELECT ISBN,TENSACH FROM dbo.ISBN
END


GO
/****** Object:  StoredProcedure [dbo].[sp_LayMaTenNganTu]    Script Date: 6/27/2017 10:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_LayMaTenNganTu]
AS
BEGIN
	SELECT DBO.NGANTU.MANGANTU, DBO.NGANTU.MOTA FROM DBO.NGANTU 
END


GO
/****** Object:  StoredProcedure [dbo].[sp_LayMaTenNgonNgu]    Script Date: 6/27/2017 10:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_LayMaTenNgonNgu]
AS
BEGIN
	SELECT DBO.NGONNGU.MANGONNGU, DBO.NGONNGU.NGONNGU FROM DBO.NGONNGU 
END

GO
/****** Object:  StoredProcedure [dbo].[sp_LayMaTenTacGia]    Script Date: 6/27/2017 10:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_LayMaTenTacGia]
AS
BEGIN
	SELECT MATACGIA, HOTENTG FROM dbo.TACGIA WHERE TINHTRANG = 1;
END

GO
/****** Object:  StoredProcedure [dbo].[sp_LayMaTenTheLoai]    Script Date: 6/27/2017 10:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_LayMaTenTheLoai]
AS
BEGIN
	SELECT DBO.THELOAI.MATL, DBO.THELOAI.THELOAI FROM DBO.THELOAI
END

GO
/****** Object:  StoredProcedure [dbo].[sp_LayMaTheLoai]    Script Date: 6/27/2017 10:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_LayMaTheLoai]
AS
BEGIN
	SELECT MATL FROM dbo.THELOAI
END

GO
/****** Object:  StoredProcedure [dbo].[SP_ListBackup]    Script Date: 6/27/2017 10:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_ListBackup]
AS
BEGIN
DECLARE @MEDIA_ID INT
SELECT @MEDIA_ID= [msdb].[dbo].[backupmediafamily].media_set_id 
FROM [msdb].[dbo].[backupmediafamily] WHERE [msdb].[dbo].[backupmediafamily].logical_device_name = 'QL_THUVIEN'
SELECT [msdb].[dbo].[backupset].[backup_set_id]
      ,[position]
      ,[backup_start_date]
      FROM  [msdb].[dbo].[backupset] WHERE media_set_id = @MEDIA_ID
	  AND [backup_set_id] NOT IN (SELECT [msdb].[dbo].[restorehistory].[backup_set_id] FROM [msdb].[dbo].[restorehistory])
	  AND database_name = 'QL_THUVIEN' 
	  ORDER BY backup_set_id DESC;
END

GO
/****** Object:  StoredProcedure [dbo].[SP_MaTacGia]    Script Date: 6/27/2017 10:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_MaTacGia]
AS
BEGIN
	DECLARE @MaTacGia int;
	SELECT @MaTacGia = Max(dbo.TACGIA.MATACGIA) FROM dbo.TACGIA
	return @MaTacGia + 1;
END

GO
/****** Object:  StoredProcedure [dbo].[sp_TanSuatXuatHienSach]    Script Date: 6/27/2017 10:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_TanSuatXuatHienSach]
@T1 DATETIME,
@T2 DATETIME
AS
BEGIN

	SELECT CTPM.MASACH, COUNT(*) AS N'TANSUAT'
	FROM (SELECT PM.MAPHIEU, PM.NGAYMUON FROM DBO.PHIEUMUON PM WHERE PM.NGAYMUON BETWEEN @T1 AND @T2) PM_TG
	INNER JOIN DBO.CT_PHIEUMUON CTPM ON PM_TG.MAPHIEU = CTPM.MAPHIEU
	GROUP BY CTPM.MASACH 

END
GO
/****** Object:  StoredProcedure [dbo].[Sp_Them_CT_PhieuMuon]    Script Date: 6/27/2017 10:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Sp_Them_CT_PhieuMuon]
@maPhieu nvarchar(50),
@maISBN  nvarchar(50),
@maNV    nvarchar(50)
as 
declare @maSach nvarchar(50), @ngayTra date
begin
select top 1 @maSach=s.MASACH
from SACH as s
where s.ISBN=@maISBN and s.CHOMUON=0
INSERT INTO CT_PHIEUMUON
--VALUES (@maPhieu,@maSach,GETDATE() +30,1,0,@maNV)
VALUES (@maPhieu,@maSach,null,1,0,@maNV)
UPDATE SACH
SET CHOMUON = 1
WHERE MASACH=@maSach; 
end



GO
/****** Object:  StoredProcedure [dbo].[sp_ThemISBN_TACGIA_SACH]    Script Date: 6/27/2017 10:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_ThemISBN_TACGIA_SACH]
@MATG INT,
@MAISBN NCHAR(10)
AS
BEGIN
	
	INSERT INTO DBO.TACGIA_SACH
	VALUES (@MATG, @MAISBN)

	IF(@@ROWCOUNT != 0)
	BEGIN
		RETURN 1
	END

	RETURN 0
END

GO
/****** Object:  StoredProcedure [dbo].[SP_ThemTacGia]    Script Date: 6/27/2017 10:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_ThemTacGia]
	@HoTenTG nvarchar(30),
	@DiaChi nvarchar(30),
	@SoDienThoai varchar(10)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	INSERT INTO dbo.TACGIA(HOTENTG, DIACHITG,DIENTHOAITG) VALUES(@HoTenTG, @DiaChi, @SoDienThoai);
END

GO
/****** Object:  StoredProcedure [dbo].[SP_UndoChinhSuaTacGia]    Script Date: 6/27/2017 10:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_UndoChinhSuaTacGia]
 @MaTacGia int,
 @HoTenTacGia nvarchar(30),
 @DiaChi nvarchar(30),
 @SoDienThoai varchar(12)
AS
BEGIN
	UPDATE dbo.TACGIA SET HOTENTG = @HoTenTacGia, 
	DIACHITG = @DiaChi,
	 DIENTHOAITG = @SoDienThoai WHERE MATACGIA = @MaTacGia;
END

GO
/****** Object:  StoredProcedure [dbo].[SP_UndoDeleteTacGia]    Script Date: 6/27/2017 10:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_UndoDeleteTacGia]
@MaTacGia int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	UPDATE dbo.TACGIA SET TINHTRANG = 1 WHERE MATACGIA = @MaTacGia;
END

GO
/****** Object:  StoredProcedure [dbo].[SP_UndoThemTacGia]    Script Date: 6/27/2017 10:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_UndoThemTacGia]
 @MaTacGia int
AS
BEGIN
	UPDATE dbo.TACGIA SET dbo.TACGIA.TINHTRANG = 0 WHERE MATACGIA = @MaTacGia;
END

GO
/****** Object:  StoredProcedure [dbo].[SP_User_Login]    Script Date: 6/27/2017 10:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[SP_User_Login]
@user nvarchar(40)
AS 
Begin
	select name from sys.syslogins where sid=(select sid from sys.sysusers where name=@user)
END


GO
/****** Object:  StoredProcedure [dbo].[Sp_Xoa_CT_PhieuMuon]    Script Date: 6/27/2017 10:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Sp_Xoa_CT_PhieuMuon]
@maPhieu nvarchar(50),
@maSach  nvarchar(50),
@maNV    nvarchar(50)
as 
begin
SET XACT_ABORT ON
BEGIN TRAN
BEGIN TRY
	delete from CT_PHIEUMUON 
	where MAPHIEU=@maPhieu and MASACH=@maSach and MANVNS=@maNV
	UPDATE SACH
	SET CHOMUON = 0
	WHERE MASACH=@maSach; 
COMMIT
END TRY
BEGIN CATCH
   ROLLBACK TRAN
   DECLARE @ErrorMessage VARCHAR(2000)
   SELECT @ErrorMessage = 'Lỗi: ' + ERROR_MESSAGE()
   RAISERROR(@ErrorMessage, 16, 1)
END CATCH

end



GO
/****** Object:  StoredProcedure [dbo].[sp_XoaISBN_TACGIA_SACH]    Script Date: 6/27/2017 10:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_XoaISBN_TACGIA_SACH]
@MAISBN NCHAR(10)
AS
BEGIN
	DELETE 
	FROM DBO.TACGIA_SACH
	WHERE @MAISBN = ISBN
END

GO
/****** Object:  StoredProcedure [dbo].[sp_XoaISBN_TonTai]    Script Date: 6/27/2017 10:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_XoaISBN_TonTai]
@MAISBN NCHAR(10)
AS
BEGIN
	DELETE FROM DBO.ISBN WHERE @MAISBN = ISBN
END

GO
/****** Object:  StoredProcedure [dbo].[TAO_LOGIN]    Script Date: 6/27/2017 10:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[TAO_LOGIN]
  @LGNAME VARCHAR(50),
  @PASS VARCHAR(50),
  @USRNAME VARCHAR(50),
 @ROLE VARCHAR(50)
AS
  DECLARE @RET INT
  EXEC @RET= SP_ADDLOGIN @LGNAME, @PASS,'QL_THUVIEN'
   IF (@RET =1)  -- LOGIN NAME BI TRUNG
     RETURN 1
 
  EXEC @RET= SP_GRANTDBACCESS @LGNAME, @USRNAME
  IF (@RET =1)  -- USER  NAME BI TRUNG
  BEGIN
       EXEC SP_DROPLOGIN @LGNAME
       RETURN 2
  END

IF (@ROLE ='ADMIN')
BEGIN
  EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
  EXEC sp_addsrvrolemember @LGNAME, 'DBCreator'
  EXEC sp_addsrvrolemember @LGNAME, 'ProcessAdmin'
  EXEC sp_addrolemember 'ADMIN', @USRNAME
END
IF (@ROLE ='NHANVIEN')  -- THUOC NHOM NHANVIEN
BEGIN
EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
  EXEC sp_addsrvrolemember @LGNAME, 'DBCreator'
  EXEC sp_addsrvrolemember @LGNAME, 'ProcessAdmin'
  EXEC sp_addrolemember 'NHANVIEN', @USRNAME
  Update  NHANVIEN set TRANGTHAI=1 where MANV=@USRNAME
END
IF (@ROLE ='DOCGIA')  -- THUOC NHOM DOCGIA
BEGIN
   EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
  EXEC sp_addrolemember 'DOCGIA', @USRNAME
  Update  DOCGIA set TRANGTHAI=1 where MADG=@USRNAME
END
--BEGIN
--	Update  NHANVIEN set TRANGTHAI=1 where MANV=@USRNAME
--END

RETURN 0  -- THANH CONG



GO
/****** Object:  StoredProcedure [dbo].[Xoa_Login]    Script Date: 6/27/2017 10:50:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Xoa_Login]
  @LGNAME VARCHAR(50),
  @USRNAME VARCHAR(50)
  
AS


EXEC SP_DROPUSER @USRNAME
  EXEC SP_DROPLOGIN @LGNAME
  


GO
