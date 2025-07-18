USE [master]
GO
/****** Object:  Database [eBelediye]    Script Date: 5.07.2025 22:22:20 ******/
CREATE DATABASE [eBelediye]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'eBelediye', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\eBelediye.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'eBelediye_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\eBelediye_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [eBelediye] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [eBelediye].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [eBelediye] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [eBelediye] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [eBelediye] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [eBelediye] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [eBelediye] SET ARITHABORT OFF 
GO
ALTER DATABASE [eBelediye] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [eBelediye] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [eBelediye] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [eBelediye] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [eBelediye] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [eBelediye] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [eBelediye] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [eBelediye] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [eBelediye] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [eBelediye] SET  ENABLE_BROKER 
GO
ALTER DATABASE [eBelediye] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [eBelediye] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [eBelediye] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [eBelediye] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [eBelediye] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [eBelediye] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [eBelediye] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [eBelediye] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [eBelediye] SET  MULTI_USER 
GO
ALTER DATABASE [eBelediye] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [eBelediye] SET DB_CHAINING OFF 
GO
ALTER DATABASE [eBelediye] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [eBelediye] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [eBelediye] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [eBelediye] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [eBelediye] SET QUERY_STORE = ON
GO
ALTER DATABASE [eBelediye] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [eBelediye]
GO
/****** Object:  Table [dbo].[Basvuru]    Script Date: 5.07.2025 22:22:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Basvuru](
	[BasvuruID] [int] IDENTITY(1,1) NOT NULL,
	[VatandasID] [int] NULL,
	[BasvuruTarihi] [datetime] NULL,
	[BasvuruTipi] [nvarchar](50) NOT NULL,
	[Durum] [nvarchar](20) NULL,
	[Detaylar] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[BasvuruID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BasvuruNoSorgulama]    Script Date: 5.07.2025 22:22:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BasvuruNoSorgulama](
	[SorgulamaID] [int] IDENTITY(1,1) NOT NULL,
	[BasvuruID] [int] NULL,
	[SorgulamaTarihi] [datetime] NULL,
	[SorgulamaSonucu] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[SorgulamaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Belge]    Script Date: 5.07.2025 22:22:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Belge](
	[BelgeID] [int] IDENTITY(1,1) NOT NULL,
	[VatandasID] [int] NULL,
	[BelgeTuru] [nvarchar](50) NULL,
	[BelgeYolu] [nvarchar](max) NULL,
	[YüklemeTarihi] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[BelgeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Borc]    Script Date: 5.07.2025 22:22:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Borc](
	[BorcID] [int] IDENTITY(1,1) NOT NULL,
	[VatandasID] [int] NULL,
	[BorcTarihi] [datetime] NULL,
	[BorcTutari] [decimal](18, 2) NULL,
	[Aciklama] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[BorcID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EBasvuru]    Script Date: 5.07.2025 22:22:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EBasvuru](
	[EBasvuruID] [int] IDENTITY(1,1) NOT NULL,
	[VatandasID] [int] NULL,
	[BasvuruTarihi] [datetime] NULL,
	[BasvuruDetay] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[EBasvuruID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EBeyan]    Script Date: 5.07.2025 22:22:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EBeyan](
	[EBeyanID] [int] IDENTITY(1,1) NOT NULL,
	[VatandasID] [int] NULL,
	[BeyanTarihi] [datetime] NULL,
	[BeyanDetay] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[EBeyanID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EBilgi]    Script Date: 5.07.2025 22:22:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EBilgi](
	[EBilgiID] [int] IDENTITY(1,1) NOT NULL,
	[VatandasID] [int] NULL,
	[BilgiTarihi] [datetime] NULL,
	[BilgiDetay] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[EBilgiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EEksper]    Script Date: 5.07.2025 22:22:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EEksper](
	[EEksperID] [int] IDENTITY(1,1) NOT NULL,
	[VatandasID] [int] NULL,
	[EksperTarihi] [datetime] NULL,
	[EksperDetay] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[EEksperID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KariyerMerkezi]    Script Date: 5.07.2025 22:22:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KariyerMerkezi](
	[KariyerID] [int] IDENTITY(1,1) NOT NULL,
	[IsID] [nvarchar](50) NULL,
	[Pozisyon] [nvarchar](100) NULL,
	[Tarih] [datetime] NULL,
	[Detay] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[KariyerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MakbuzDogrulama]    Script Date: 5.07.2025 22:22:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MakbuzDogrulama](
	[DogrulamaID] [int] IDENTITY(1,1) NOT NULL,
	[OdemeID] [int] NULL,
	[DogrulamaTarihi] [datetime] NULL,
	[DogrulamaSonucu] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[DogrulamaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NikahSalonlari]    Script Date: 5.07.2025 22:22:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NikahSalonlari](
	[SalonID] [int] IDENTITY(1,1) NOT NULL,
	[SalonAdi] [nvarchar](100) NULL,
	[SalonTarihi] [datetime] NULL,
	[Detay] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[SalonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Odeme]    Script Date: 5.07.2025 22:22:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Odeme](
	[OdemeID] [int] IDENTITY(1,1) NOT NULL,
	[VatandasID] [int] NULL,
	[OdemeTarihi] [datetime] NULL,
	[OdemeTutari] [decimal](18, 2) NULL,
	[OdemeYontemi] [nvarchar](50) NULL,
	[MakbuzNo] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[OdemeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SSS]    Script Date: 5.07.2025 22:22:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SSS](
	[SSSID] [int] IDENTITY(1,1) NOT NULL,
	[Soru] [nvarchar](max) NULL,
	[Cevap] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[SSSID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vatandas]    Script Date: 5.07.2025 22:22:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vatandas](
	[VatandasID] [int] IDENTITY(1,1) NOT NULL,
	[TC_KimlikNo] [varchar](11) NOT NULL,
	[Ad] [nvarchar](50) NOT NULL,
	[Soyad] [nvarchar](50) NOT NULL,
	[Sifre] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](100) NULL,
	[TelefonNo] [nvarchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[VatandasID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Basvuru] ON 

INSERT [dbo].[Basvuru] ([BasvuruID], [VatandasID], [BasvuruTarihi], [BasvuruTipi], [Durum], [Detaylar]) VALUES (1, 1, CAST(N'2024-08-01T00:00:00.000' AS DateTime), N'İmar Başvurusu', N'Beklemede', N'İmar izin başvurusu.')
INSERT [dbo].[Basvuru] ([BasvuruID], [VatandasID], [BasvuruTarihi], [BasvuruTipi], [Durum], [Detaylar]) VALUES (2, 2, CAST(N'2024-07-15T00:00:00.000' AS DateTime), N'Ruhsat Başvurusu', N'Onaylandı', N'Ruhsat yenileme başvurusu.')
INSERT [dbo].[Basvuru] ([BasvuruID], [VatandasID], [BasvuruTarihi], [BasvuruTipi], [Durum], [Detaylar]) VALUES (3, 3, CAST(N'2024-06-20T00:00:00.000' AS DateTime), N'Su Aboneliği Başvurusu', N'Reddedildi', N'Yeni su aboneliği için başvuru.')
INSERT [dbo].[Basvuru] ([BasvuruID], [VatandasID], [BasvuruTarihi], [BasvuruTipi], [Durum], [Detaylar]) VALUES (4, 4, CAST(N'2024-05-30T00:00:00.000' AS DateTime), N'Çöp Konteyneri Başvurusu', N'Beklemede', N'Ek çöp konteyneri talebi.')
INSERT [dbo].[Basvuru] ([BasvuruID], [VatandasID], [BasvuruTarihi], [BasvuruTipi], [Durum], [Detaylar]) VALUES (5, 5, CAST(N'2024-04-10T00:00:00.000' AS DateTime), N'İskan Başvurusu', N'Onaylandı', N'İskan izni başvurusu.')
SET IDENTITY_INSERT [dbo].[Basvuru] OFF
GO
SET IDENTITY_INSERT [dbo].[BasvuruNoSorgulama] ON 

INSERT [dbo].[BasvuruNoSorgulama] ([SorgulamaID], [BasvuruID], [SorgulamaTarihi], [SorgulamaSonucu]) VALUES (1, 1, CAST(N'2024-01-15T10:30:00.000' AS DateTime), N'Başvuru başarılı bir şekilde sonuçlandırıldı.')
INSERT [dbo].[BasvuruNoSorgulama] ([SorgulamaID], [BasvuruID], [SorgulamaTarihi], [SorgulamaSonucu]) VALUES (2, 2, CAST(N'2024-02-20T14:45:00.000' AS DateTime), N'Başvuru inceleme aşamasında.')
INSERT [dbo].[BasvuruNoSorgulama] ([SorgulamaID], [BasvuruID], [SorgulamaTarihi], [SorgulamaSonucu]) VALUES (3, 3, CAST(N'2024-03-05T09:15:00.000' AS DateTime), N'Başvuru reddedildi. Eksik belgeler var.')
INSERT [dbo].[BasvuruNoSorgulama] ([SorgulamaID], [BasvuruID], [SorgulamaTarihi], [SorgulamaSonucu]) VALUES (4, 4, CAST(N'2024-04-10T16:00:00.000' AS DateTime), N'Başvuru onay bekliyor.')
INSERT [dbo].[BasvuruNoSorgulama] ([SorgulamaID], [BasvuruID], [SorgulamaTarihi], [SorgulamaSonucu]) VALUES (5, 5, CAST(N'2024-05-25T11:20:00.000' AS DateTime), N'Başvuru iptal edildi.')
SET IDENTITY_INSERT [dbo].[BasvuruNoSorgulama] OFF
GO
SET IDENTITY_INSERT [dbo].[Belge] ON 

INSERT [dbo].[Belge] ([BelgeID], [VatandasID], [BelgeTuru], [BelgeYolu], [YüklemeTarihi]) VALUES (1, 1, N'Kimlik Fotokopisi', N'C:\\Belgeler\\Kimlik1.pdf', CAST(N'2023-01-15T00:00:00.000' AS DateTime))
INSERT [dbo].[Belge] ([BelgeID], [VatandasID], [BelgeTuru], [BelgeYolu], [YüklemeTarihi]) VALUES (2, 9, N'İkametgah', N'C:\\Belgeler\\Ikametgah2.pdf', CAST(N'2023-02-20T00:00:00.000' AS DateTime))
INSERT [dbo].[Belge] ([BelgeID], [VatandasID], [BelgeTuru], [BelgeYolu], [YüklemeTarihi]) VALUES (3, 3, N'Tapu', N'C:\\Belgeler\\Tapu3.pdf', CAST(N'2023-03-10T00:00:00.000' AS DateTime))
INSERT [dbo].[Belge] ([BelgeID], [VatandasID], [BelgeTuru], [BelgeYolu], [YüklemeTarihi]) VALUES (4, 7, N'Ruhsat', N'C:\\Belgeler\\Ruhsat4.pdf', CAST(N'2023-04-25T00:00:00.000' AS DateTime))
INSERT [dbo].[Belge] ([BelgeID], [VatandasID], [BelgeTuru], [BelgeYolu], [YüklemeTarihi]) VALUES (5, 5, N'Vergi Levhası', N'C:\\Belgeler\\VergiLevhasi5.pdf', CAST(N'2023-05-05T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Belge] OFF
GO
SET IDENTITY_INSERT [dbo].[Borc] ON 

INSERT [dbo].[Borc] ([BorcID], [VatandasID], [BorcTarihi], [BorcTutari], [Aciklama]) VALUES (1, 1, CAST(N'2023-01-15T00:00:00.000' AS DateTime), CAST(1500.75 AS Decimal(18, 2)), N'Emlak vergisi borcu.')
INSERT [dbo].[Borc] ([BorcID], [VatandasID], [BorcTarihi], [BorcTutari], [Aciklama]) VALUES (2, 2, CAST(N'2023-02-10T00:00:00.000' AS DateTime), CAST(500.00 AS Decimal(18, 2)), N' İlan ve Reklam vergisi borcu.')
INSERT [dbo].[Borc] ([BorcID], [VatandasID], [BorcTarihi], [BorcTutari], [Aciklama]) VALUES (3, 9, CAST(N'2023-03-25T00:00:00.000' AS DateTime), CAST(200.50 AS Decimal(18, 2)), N'İskan izni ücreti.')
INSERT [dbo].[Borc] ([BorcID], [VatandasID], [BorcTarihi], [BorcTutari], [Aciklama]) VALUES (4, 4, CAST(N'2023-04-12T00:00:00.000' AS DateTime), CAST(750.00 AS Decimal(18, 2)), N'Ruhsat yenileme ücreti.')
INSERT [dbo].[Borc] ([BorcID], [VatandasID], [BorcTarihi], [BorcTutari], [Aciklama]) VALUES (5, 7, CAST(N'2023-05-05T00:00:00.000' AS DateTime), CAST(300.25 AS Decimal(18, 2)), N'Çöp konteyneri ücreti.')
SET IDENTITY_INSERT [dbo].[Borc] OFF
GO
SET IDENTITY_INSERT [dbo].[EBasvuru] ON 

INSERT [dbo].[EBasvuru] ([EBasvuruID], [VatandasID], [BasvuruTarihi], [BasvuruDetay]) VALUES (1, 1, CAST(N'2024-09-07T11:16:43.000' AS DateTime), N'Kamu hizmeti için başvuru yapılmakta. Başvuru detayları: Toplantı talebi.')
INSERT [dbo].[EBasvuru] ([EBasvuruID], [VatandasID], [BasvuruTarihi], [BasvuruDetay]) VALUES (2, 1, CAST(N'2024-09-12T20:49:29.000' AS DateTime), N'Ruhsat yenileme başvurusu.')
SET IDENTITY_INSERT [dbo].[EBasvuru] OFF
GO
SET IDENTITY_INSERT [dbo].[EBeyan] ON 

INSERT [dbo].[EBeyan] ([EBeyanID], [VatandasID], [BeyanTarihi], [BeyanDetay]) VALUES (1, 1, CAST(N'2024-09-12T13:49:25.343' AS DateTime), N' Arazi beyannamesi')
INSERT [dbo].[EBeyan] ([EBeyanID], [VatandasID], [BeyanTarihi], [BeyanDetay]) VALUES (2, 5, CAST(N'2024-08-23T00:00:00.000' AS DateTime), N'Beyan detayları: Konut Vergi beyannamesi.')
INSERT [dbo].[EBeyan] ([EBeyanID], [VatandasID], [BeyanTarihi], [BeyanDetay]) VALUES (3, 4, CAST(N'2024-09-05T00:00:00.000' AS DateTime), N'Beyan detayları: Arsa Vergi beyannamesi.')
INSERT [dbo].[EBeyan] ([EBeyanID], [VatandasID], [BeyanTarihi], [BeyanDetay]) VALUES (4, 3, CAST(N'2024-09-16T00:00:00.000' AS DateTime), N'Beyan detayları: Çevre Temizlik Vergi beyannamesi.')
INSERT [dbo].[EBeyan] ([EBeyanID], [VatandasID], [BeyanTarihi], [BeyanDetay]) VALUES (5, 6, CAST(N'2024-09-15T21:54:39.030' AS DateTime), N'Konut Vergi beyannamesi.')
INSERT [dbo].[EBeyan] ([EBeyanID], [VatandasID], [BeyanTarihi], [BeyanDetay]) VALUES (6, 5, CAST(N'2024-08-23T00:00:00.000' AS DateTime), N'Beyan detayları: Konut Vergi beyannamesi.')
INSERT [dbo].[EBeyan] ([EBeyanID], [VatandasID], [BeyanTarihi], [BeyanDetay]) VALUES (7, 4, CAST(N'2024-09-05T00:00:00.000' AS DateTime), N'Beyan detayları: Arsa Vergi beyannamesi.')
INSERT [dbo].[EBeyan] ([EBeyanID], [VatandasID], [BeyanTarihi], [BeyanDetay]) VALUES (8, 3, CAST(N'2024-09-16T00:00:00.000' AS DateTime), N'Beyan detayları: Çevre Temizlik Vergi beyannamesi.')
SET IDENTITY_INSERT [dbo].[EBeyan] OFF
GO
SET IDENTITY_INSERT [dbo].[EBilgi] ON 

INSERT [dbo].[EBilgi] ([EBilgiID], [VatandasID], [BilgiTarihi], [BilgiDetay]) VALUES (1, 1, CAST(N'2024-09-01T00:00:00.000' AS DateTime), N'Bilgi detayları: Proje A hakkında genel bilgiler.')
INSERT [dbo].[EBilgi] ([EBilgiID], [VatandasID], [BilgiTarihi], [BilgiDetay]) VALUES (2, 2, CAST(N'2024-09-05T00:00:00.000' AS DateTime), N'Bilgi detayları: Proje B için güncellemeler.')
INSERT [dbo].[EBilgi] ([EBilgiID], [VatandasID], [BilgiTarihi], [BilgiDetay]) VALUES (3, 3, CAST(N'2024-09-10T00:00:00.000' AS DateTime), N'Bilgi detayları: Proje C ile ilgili talimatlar.')
INSERT [dbo].[EBilgi] ([EBilgiID], [VatandasID], [BilgiTarihi], [BilgiDetay]) VALUES (4, 2, CAST(N'2024-09-12T00:00:00.000' AS DateTime), N'Bilgi detayları: Nöbetçi Eczaneler')
INSERT [dbo].[EBilgi] ([EBilgiID], [VatandasID], [BilgiTarihi], [BilgiDetay]) VALUES (5, 3, CAST(N'2024-09-10T00:00:00.000' AS DateTime), N'Bilgi detayları: Meclis Kararları')
SET IDENTITY_INSERT [dbo].[EBilgi] OFF
GO
SET IDENTITY_INSERT [dbo].[EEksper] ON 

INSERT [dbo].[EEksper] ([EEksperID], [VatandasID], [EksperTarihi], [EksperDetay]) VALUES (1, 3, CAST(N'2024-09-09T11:56:18.000' AS DateTime), N'Başvuru detayları: Dosya 789012, belge eksiklikleri var, ek belgeler isteniyor.')
INSERT [dbo].[EEksper] ([EEksperID], [VatandasID], [EksperTarihi], [EksperDetay]) VALUES (2, 1, CAST(N'2024-09-12T21:02:14.000' AS DateTime), N'Arsanın metrekare değerlemesi ve imar durumu hakkında detaylı rapor talep ediyorum.')
SET IDENTITY_INSERT [dbo].[EEksper] OFF
GO
SET IDENTITY_INSERT [dbo].[KariyerMerkezi] ON 

INSERT [dbo].[KariyerMerkezi] ([KariyerID], [IsID], [Pozisyon], [Tarih], [Detay]) VALUES (1, N'1', N'İnşaat Mühendisi', CAST(N'2024-09-02T20:03:48.000' AS DateTime), N'Şirketmizde deneyimli inşaat mühendisi arıyoruz')
INSERT [dbo].[KariyerMerkezi] ([KariyerID], [IsID], [Pozisyon], [Tarih], [Detay]) VALUES (2, N'2', N'Bilgisayar Programcı', CAST(N'2024-09-12T20:05:02.800' AS DateTime), N'Yazılım şirketinde çalışacak yeni mezun bilgisayar programcısı arıyoruz')
SET IDENTITY_INSERT [dbo].[KariyerMerkezi] OFF
GO
SET IDENTITY_INSERT [dbo].[MakbuzDogrulama] ON 

INSERT [dbo].[MakbuzDogrulama] ([DogrulamaID], [OdemeID], [DogrulamaTarihi], [DogrulamaSonucu]) VALUES (1, 1, CAST(N'2024-09-12T08:52:18.820' AS DateTime), N'Başarılı')
INSERT [dbo].[MakbuzDogrulama] ([DogrulamaID], [OdemeID], [DogrulamaTarihi], [DogrulamaSonucu]) VALUES (2, NULL, CAST(N'2024-09-12T08:52:25.087' AS DateTime), N'Başarısız')
INSERT [dbo].[MakbuzDogrulama] ([DogrulamaID], [OdemeID], [DogrulamaTarihi], [DogrulamaSonucu]) VALUES (3, 2, CAST(N'2024-09-12T09:20:22.900' AS DateTime), N'Başarılı')
INSERT [dbo].[MakbuzDogrulama] ([DogrulamaID], [OdemeID], [DogrulamaTarihi], [DogrulamaSonucu]) VALUES (4, 4, CAST(N'2024-09-12T16:54:04.253' AS DateTime), N'Başarılı')
INSERT [dbo].[MakbuzDogrulama] ([DogrulamaID], [OdemeID], [DogrulamaTarihi], [DogrulamaSonucu]) VALUES (5, 5, CAST(N'2024-09-15T17:44:29.023' AS DateTime), N'Başarılı')
INSERT [dbo].[MakbuzDogrulama] ([DogrulamaID], [OdemeID], [DogrulamaTarihi], [DogrulamaSonucu]) VALUES (6, 1, CAST(N'2024-10-07T22:22:52.397' AS DateTime), N'Başarılı')
INSERT [dbo].[MakbuzDogrulama] ([DogrulamaID], [OdemeID], [DogrulamaTarihi], [DogrulamaSonucu]) VALUES (7, 1, CAST(N'2025-02-26T21:35:21.937' AS DateTime), N'Başarılı')
SET IDENTITY_INSERT [dbo].[MakbuzDogrulama] OFF
GO
SET IDENTITY_INSERT [dbo].[Odeme] ON 

INSERT [dbo].[Odeme] ([OdemeID], [VatandasID], [OdemeTarihi], [OdemeTutari], [OdemeYontemi], [MakbuzNo]) VALUES (1, 14, CAST(N'2024-09-11T23:13:45.857' AS DateTime), CAST(1500.00 AS Decimal(18, 2)), N'Nakit', N'MKZ001')
INSERT [dbo].[Odeme] ([OdemeID], [VatandasID], [OdemeTarihi], [OdemeTutari], [OdemeYontemi], [MakbuzNo]) VALUES (2, 19, CAST(N'2024-09-11T23:14:28.740' AS DateTime), CAST(50025.00 AS Decimal(18, 2)), N'Kredi Kartı', N'MKZ002')
INSERT [dbo].[Odeme] ([OdemeID], [VatandasID], [OdemeTarihi], [OdemeTutari], [OdemeYontemi], [MakbuzNo]) VALUES (3, 9, CAST(N'2024-09-11T23:15:06.633' AS DateTime), CAST(89075.00 AS Decimal(18, 2)), N'Banka Havalesi', N'MKZ003')
INSERT [dbo].[Odeme] ([OdemeID], [VatandasID], [OdemeTarihi], [OdemeTutari], [OdemeYontemi], [MakbuzNo]) VALUES (4, 1, CAST(N'2024-09-12T16:41:59.860' AS DateTime), CAST(1500.00 AS Decimal(18, 2)), N'Kredi Kartı', N'MKZ004')
INSERT [dbo].[Odeme] ([OdemeID], [VatandasID], [OdemeTarihi], [OdemeTutari], [OdemeYontemi], [MakbuzNo]) VALUES (5, 7, CAST(N'2024-09-15T17:12:39.337' AS DateTime), CAST(2300.00 AS Decimal(18, 2)), N'Nakit', N'MKZ005')
SET IDENTITY_INSERT [dbo].[Odeme] OFF
GO
SET IDENTITY_INSERT [dbo].[SSS] ON 

INSERT [dbo].[SSS] ([SSSID], [Soru], [Cevap]) VALUES (1, N'Bağcılar Belediyesi''ne nasıl başvuruda bulunabilirim?', N'Bağcılar Belediyesi''ne başvuruda bulunmak için e-Belediye sistemimize giriş yaparak ilgili başvuru formunu doldurabilirsiniz. Ayrıca, belediye binasına bizzat başvuruda bulunabilirsiniz.')
INSERT [dbo].[SSS] ([SSSID], [Soru], [Cevap]) VALUES (2, N'E-belediye sistemine nasıl kayıt olabilirim?', N'E-belediye sistemine kayıt olmak için ana sayfamızdaki "Kayıt Ol" butonuna tıklayarak gerekli bilgileri doldurmanız gerekmektedir. Kayıt işlemi tamamlandıktan sonra e-posta adresinize bir doğrulama linki gönderilecektir.')
INSERT [dbo].[SSS] ([SSSID], [Soru], [Cevap]) VALUES (3, N'Çöp toplama günleri nelerdir?', N'Çöp toplama günleri, mahalleye göre değişiklik göstermektedir. Güncel toplama takvimine e-Belediye sisteminden ulaşabilirsiniz veya belediye hizmet biriminizle iletişime geçebilirsiniz.')
INSERT [dbo].[SSS] ([SSSID], [Soru], [Cevap]) VALUES (4, N'Ruhsat işlemlerini nasıl takip edebilirim?', N'Ruhsat işlemlerinizin durumunu e-Belediye sistemi üzerinden "Ruhsat Takibi" bölümünden öğrenebilirsiniz. Ayrıca, başvurunuzun durumunu belediyenizin ilgili birimlerinden de sorgulayabilirsiniz.')
INSERT [dbo].[SSS] ([SSSID], [Soru], [Cevap]) VALUES (5, N'Sosyal yardım başvurusu nasıl yapılır?', N'Sosyal yardım başvurusu yapmak için e-Belediye sistemimize giriş yaparak "Sosyal Yardım Başvurusu" formunu doldurmanız gerekmektedir. Başvurunuz değerlendirildikten sonra size geri dönüş yapılacaktır.')
SET IDENTITY_INSERT [dbo].[SSS] OFF
GO
SET IDENTITY_INSERT [dbo].[Vatandas] ON 

INSERT [dbo].[Vatandas] ([VatandasID], [TC_KimlikNo], [Ad], [Soyad], [Sifre], [Email], [TelefonNo]) VALUES (1, N'11111111111', N'Ahmet', N'Yılmaz', N'sifre123', N'ahmet.yilmaz@example.com', N'555-111-1111')
INSERT [dbo].[Vatandas] ([VatandasID], [TC_KimlikNo], [Ad], [Soyad], [Sifre], [Email], [TelefonNo]) VALUES (2, N'22222222222', N'Mehmet', N'Kaya', N'sifre456', N'mehmet.kaya@example.com', N'555-222-2222')
INSERT [dbo].[Vatandas] ([VatandasID], [TC_KimlikNo], [Ad], [Soyad], [Sifre], [Email], [TelefonNo]) VALUES (3, N'33333333333', N'Ayşe', N'Demir', N'sifre789', N'ayse.demir@example.com', N'555-333-3333')
INSERT [dbo].[Vatandas] ([VatandasID], [TC_KimlikNo], [Ad], [Soyad], [Sifre], [Email], [TelefonNo]) VALUES (4, N'44444444444', N'Fatma', N'Çelik', N'sifre101', N'fatma.celik@example.com', N'555-444-4444')
INSERT [dbo].[Vatandas] ([VatandasID], [TC_KimlikNo], [Ad], [Soyad], [Sifre], [Email], [TelefonNo]) VALUES (5, N'55555555555', N'Ali', N'Koç', N'sifre102', N'ali.koc@example.com', N'555-555-5555')
INSERT [dbo].[Vatandas] ([VatandasID], [TC_KimlikNo], [Ad], [Soyad], [Sifre], [Email], [TelefonNo]) VALUES (6, N'66666666666', N'Hüseyin', N'Ak', N'sifre103', N'huseyin.ak@example.com', N'555-666-6666')
INSERT [dbo].[Vatandas] ([VatandasID], [TC_KimlikNo], [Ad], [Soyad], [Sifre], [Email], [TelefonNo]) VALUES (7, N'77777777777', N'Elif', N'Kara', N'sifre104', N'elif.kara@example.com', N'555-777-7777')
INSERT [dbo].[Vatandas] ([VatandasID], [TC_KimlikNo], [Ad], [Soyad], [Sifre], [Email], [TelefonNo]) VALUES (8, N'88888888888', N'Mustafa', N'Kurt', N'sifre105', N'mustafa.kurt@example.com', N'555-888-8888')
INSERT [dbo].[Vatandas] ([VatandasID], [TC_KimlikNo], [Ad], [Soyad], [Sifre], [Email], [TelefonNo]) VALUES (9, N'99999999999', N'Zeynep', N'Şahin', N'sifre106', N'zeynep.sahin@example.com', N'555-999-9999')
INSERT [dbo].[Vatandas] ([VatandasID], [TC_KimlikNo], [Ad], [Soyad], [Sifre], [Email], [TelefonNo]) VALUES (10, N'10101010101', N'Murat', N'Arslan', N'sifre107', N'murat.arslan@example.com', N'555-101-0101')
INSERT [dbo].[Vatandas] ([VatandasID], [TC_KimlikNo], [Ad], [Soyad], [Sifre], [Email], [TelefonNo]) VALUES (11, N'12121212121', N'Sibel', N'Bulut', N'sifre108', N'sibel.bulut@example.com', N'555-121-2121')
INSERT [dbo].[Vatandas] ([VatandasID], [TC_KimlikNo], [Ad], [Soyad], [Sifre], [Email], [TelefonNo]) VALUES (12, N'13131313131', N'Veli', N'Yıldırım', N'sifre109', N'veli.yildirim@example.com', N'555-131-3131')
INSERT [dbo].[Vatandas] ([VatandasID], [TC_KimlikNo], [Ad], [Soyad], [Sifre], [Email], [TelefonNo]) VALUES (13, N'14141414141', N'Serkan', N'Taş', N'sifre110', N'serkan.tas@example.com', N'555-141-4141')
INSERT [dbo].[Vatandas] ([VatandasID], [TC_KimlikNo], [Ad], [Soyad], [Sifre], [Email], [TelefonNo]) VALUES (14, N'15151515151', N'Deniz', N'Er', N'sifre111', N'deniz.er@example.com', N'555-151-5151')
INSERT [dbo].[Vatandas] ([VatandasID], [TC_KimlikNo], [Ad], [Soyad], [Sifre], [Email], [TelefonNo]) VALUES (15, N'16161616161', N'Gizem', N'Güneş', N'sifre112', N'gizem.gunes@example.com', N'555-161-6161')
INSERT [dbo].[Vatandas] ([VatandasID], [TC_KimlikNo], [Ad], [Soyad], [Sifre], [Email], [TelefonNo]) VALUES (16, N'17171717171', N'Burak', N'Ekin', N'sifre113', N'burak.ekin@example.com', N'555-171-7171')
INSERT [dbo].[Vatandas] ([VatandasID], [TC_KimlikNo], [Ad], [Soyad], [Sifre], [Email], [TelefonNo]) VALUES (17, N'18181818181', N'Leyla', N'Deniz', N'sifre114', N'leyla.deniz@example.com', N'555-181-8181')
INSERT [dbo].[Vatandas] ([VatandasID], [TC_KimlikNo], [Ad], [Soyad], [Sifre], [Email], [TelefonNo]) VALUES (18, N'19191919191', N'Emre', N'Çınar', N'sifre115', N'emre.cinar@example.com', N'555-191-9191')
INSERT [dbo].[Vatandas] ([VatandasID], [TC_KimlikNo], [Ad], [Soyad], [Sifre], [Email], [TelefonNo]) VALUES (19, N'20202020202', N'Naz', N'Altun', N'sifre116', N'naz.altun@example.com', N'555-202-0202')
INSERT [dbo].[Vatandas] ([VatandasID], [TC_KimlikNo], [Ad], [Soyad], [Sifre], [Email], [TelefonNo]) VALUES (20, N'21212121212', N'Ozan', N'Toprak', N'sifre117', N'ozan.toprak@example.com', N'555-212-1212')
INSERT [dbo].[Vatandas] ([VatandasID], [TC_KimlikNo], [Ad], [Soyad], [Sifre], [Email], [TelefonNo]) VALUES (21, N'12345678901', N'Kerem', N'Oğuzhan', N'1234', N'dsjkdvjkskv', N'54321')
SET IDENTITY_INSERT [dbo].[Vatandas] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Vatandas__87F61AFA19DD9BCF]    Script Date: 5.07.2025 22:22:21 ******/
ALTER TABLE [dbo].[Vatandas] ADD UNIQUE NONCLUSTERED 
(
	[TC_KimlikNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Basvuru] ADD  DEFAULT ('Beklemede') FOR [Durum]
GO
ALTER TABLE [dbo].[Basvuru]  WITH CHECK ADD FOREIGN KEY([VatandasID])
REFERENCES [dbo].[Vatandas] ([VatandasID])
GO
ALTER TABLE [dbo].[BasvuruNoSorgulama]  WITH CHECK ADD FOREIGN KEY([BasvuruID])
REFERENCES [dbo].[Basvuru] ([BasvuruID])
GO
ALTER TABLE [dbo].[Belge]  WITH CHECK ADD FOREIGN KEY([VatandasID])
REFERENCES [dbo].[Vatandas] ([VatandasID])
GO
ALTER TABLE [dbo].[Borc]  WITH CHECK ADD FOREIGN KEY([VatandasID])
REFERENCES [dbo].[Vatandas] ([VatandasID])
GO
ALTER TABLE [dbo].[EBasvuru]  WITH CHECK ADD FOREIGN KEY([VatandasID])
REFERENCES [dbo].[Vatandas] ([VatandasID])
GO
ALTER TABLE [dbo].[EBeyan]  WITH CHECK ADD FOREIGN KEY([VatandasID])
REFERENCES [dbo].[Vatandas] ([VatandasID])
GO
ALTER TABLE [dbo].[EBilgi]  WITH CHECK ADD FOREIGN KEY([VatandasID])
REFERENCES [dbo].[Vatandas] ([VatandasID])
GO
ALTER TABLE [dbo].[EEksper]  WITH CHECK ADD FOREIGN KEY([VatandasID])
REFERENCES [dbo].[Vatandas] ([VatandasID])
GO
ALTER TABLE [dbo].[MakbuzDogrulama]  WITH CHECK ADD FOREIGN KEY([OdemeID])
REFERENCES [dbo].[Odeme] ([OdemeID])
GO
ALTER TABLE [dbo].[Odeme]  WITH CHECK ADD FOREIGN KEY([VatandasID])
REFERENCES [dbo].[Vatandas] ([VatandasID])
GO
USE [master]
GO
ALTER DATABASE [eBelediye] SET  READ_WRITE 
GO
