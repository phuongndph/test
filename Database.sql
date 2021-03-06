USE abc
GO
/****** Object:  Table [dbo].[Khach_Hang]    Script Date: 10/12/2015 22:21:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khach_Hang](
	[MaKH] [nvarchar](10) NOT NULL,
	[TenKH] [nvarchar](30) NULL,
	[DiaChi] [nvarchar](30) NULL,
	[SoDT] [nvarchar](30) NULL,
 CONSTRAINT [PK_Khach_Hang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[The_Loai]    Script Date: 10/12/2015 22:21:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[The_Loai](
	[MaTL] [nvarchar](10) NOT NULL,
	[TenTL] [nvarchar](30) NULL,
	[Mota] [nvarchar](50) NULL,
 CONSTRAINT [PK_The_Loai] PRIMARY KEY CLUSTERED 
(
	[MaTL] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[San_Pham]    Script Date: 10/12/2015 22:21:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[San_Pham](
	[MaSP] [nvarchar](10) NOT NULL,
	[TenSP] [nvarchar](30) NULL,
	[Soluong] [nvarchar](10) NULL,
	[NgayNhap] [datetime] NULL,
	[MaTL] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_San_Pham] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hoa_Don]    Script Date: 10/12/2015 22:21:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hoa_Don](
	[MaHD] [nvarchar](10) NOT NULL,
	[MaKH] [nvarchar](10) NOT NULL,
	[NgayLapHD] [datetime] NULL,
	[DonGia] [nvarchar](10) NULL,
 CONSTRAINT [PK_Hoa_Don] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTiet_HoaDon]    Script Date: 10/12/2015 22:21:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTiet_HoaDon](
	[MaHD] [nvarchar](10) NOT NULL,
	[MaSP] [nvarchar](10) NOT NULL,
	[SoLuong] [nvarchar](10) NULL,
	[GiaBan] [nvarchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_ChiTiet_HoaDon_Hoa_Don]    Script Date: 10/12/2015 22:21:21 ******/
ALTER TABLE [dbo].[ChiTiet_HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTiet_HoaDon_Hoa_Don] FOREIGN KEY([MaHD])
REFERENCES [dbo].[Hoa_Don] ([MaHD])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTiet_HoaDon] CHECK CONSTRAINT [FK_ChiTiet_HoaDon_Hoa_Don]
GO
/****** Object:  ForeignKey [FK_ChiTiet_HoaDon_San_Pham]    Script Date: 10/12/2015 22:21:21 ******/
ALTER TABLE [dbo].[ChiTiet_HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTiet_HoaDon_San_Pham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[San_Pham] ([MaSP])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTiet_HoaDon] CHECK CONSTRAINT [FK_ChiTiet_HoaDon_San_Pham]
GO
/****** Object:  ForeignKey [FK_Hoa_Don_Khach_Hang]    Script Date: 10/12/2015 22:21:21 ******/
ALTER TABLE [dbo].[Hoa_Don]  WITH CHECK ADD  CONSTRAINT [FK_Hoa_Don_Khach_Hang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[Khach_Hang] ([MaKH])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Hoa_Don] CHECK CONSTRAINT [FK_Hoa_Don_Khach_Hang]
GO
/****** Object:  ForeignKey [FK_San_Pham_The_Loai]    Script Date: 10/12/2015 22:21:21 ******/
ALTER TABLE [dbo].[San_Pham]  WITH CHECK ADD  CONSTRAINT [FK_San_Pham_The_Loai] FOREIGN KEY([MaTL])
REFERENCES [dbo].[The_Loai] ([MaTL])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[San_Pham] CHECK CONSTRAINT [FK_San_Pham_The_Loai]
GO
