USE [master]
GO
/****** Object:  Database [GestionStock]    Script Date: 06/04/2016 14:53:39 ******/
CREATE DATABASE [GestionStock]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GestionStock', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\GestionStock.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'GestionStock_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\GestionStock_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [GestionStock] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GestionStock].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GestionStock] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GestionStock] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GestionStock] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GestionStock] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GestionStock] SET ARITHABORT OFF 
GO
ALTER DATABASE [GestionStock] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [GestionStock] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GestionStock] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GestionStock] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GestionStock] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GestionStock] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GestionStock] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GestionStock] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GestionStock] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GestionStock] SET  DISABLE_BROKER 
GO
ALTER DATABASE [GestionStock] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GestionStock] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GestionStock] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GestionStock] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GestionStock] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GestionStock] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GestionStock] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GestionStock] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [GestionStock] SET  MULTI_USER 
GO
ALTER DATABASE [GestionStock] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GestionStock] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GestionStock] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GestionStock] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [GestionStock] SET DELAYED_DURABILITY = DISABLED 
GO
USE [GestionStock]
GO
/****** Object:  Table [dbo].[Bondelivraison]    Script Date: 06/04/2016 14:53:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bondelivraison](
	[id_bon] [int] NOT NULL,
	[date_bon] [date] NOT NULL,
 CONSTRAINT [PK_Bondelivraison] PRIMARY KEY CLUSTERED 
(
	[id_bon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[client]    Script Date: 06/04/2016 14:53:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[client](
	[id-client] [int] NOT NULL,
	[nom-client] [nvarchar](50) NOT NULL,
	[prenom-client] [nvarchar](50) NOT NULL,
	[add-client] [nvarchar](max) NOT NULL,
	[tel-client] [int] NOT NULL,
 CONSTRAINT [PK_client] PRIMARY KEY CLUSTERED 
(
	[id-client] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Date]    Script Date: 06/04/2016 14:53:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Date](
	[id_date] [int] NOT NULL,
	[date] [date] NOT NULL,
 CONSTRAINT [PK_Date] PRIMARY KEY CLUSTERED 
(
	[id_date] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[employer]    Script Date: 06/04/2016 14:53:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[employer](
	[id-employer] [int] NOT NULL,
	[nom-employer] [nchar](10) NOT NULL,
	[prenom-employer] [nchar](10) NOT NULL,
	[age-employer] [nchar](10) NOT NULL,
	[add-employer] [nvarchar](50) NOT NULL,
	[tel-employer] [int] NOT NULL,
 CONSTRAINT [PK_employer] PRIMARY KEY CLUSTERED 
(
	[id-employer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[fourni]    Script Date: 06/04/2016 14:53:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[fourni](
	[id_fourni] [int] NOT NULL,
	[qte] [int] NOT NULL,
	[prix] [int] NOT NULL,
 CONSTRAINT [PK_fourni] PRIMARY KEY CLUSTERED 
(
	[id_fourni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[fournisseur]    Script Date: 06/04/2016 14:53:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[fournisseur](
	[id-fournisseur] [int] NOT NULL,
	[labelle-fournisseur] [nvarchar](50) NOT NULL,
	[add-fournisseur] [nvarchar](max) NOT NULL,
	[tel-fournisseur] [int] NOT NULL,
 CONSTRAINT [PK_foursniseur] PRIMARY KEY CLUSTERED 
(
	[id-fournisseur] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Livrer]    Script Date: 06/04/2016 14:53:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Livrer](
	[id_livre] [int] NOT NULL,
	[qteL] [int] NOT NULL,
 CONSTRAINT [PK_Livrer] PRIMARY KEY CLUSTERED 
(
	[id_livre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[orders]    Script Date: 06/04/2016 14:53:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orders](
	[id_order] [int] NOT NULL,
 CONSTRAINT [PK_orders] PRIMARY KEY CLUSTERED 
(
	[id_order] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[pour]    Script Date: 06/04/2016 14:53:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pour](
	[id-for] [int] NOT NULL,
	[qte for] [int] NOT NULL,
 CONSTRAINT [PK_pour] PRIMARY KEY CLUSTERED 
(
	[id-for] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[produits]    Script Date: 06/04/2016 14:53:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[produits](
	[id-produit] [int] NOT NULL,
	[labelle-produit] [nvarchar](50) NOT NULL,
	[prix-produit] [int] NOT NULL,
	[qte-produit] [int] NOT NULL,
 CONSTRAINT [PK_produits] PRIMARY KEY CLUSTERED 
(
	[id-produit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[users]    Script Date: 06/04/2016 14:53:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[id-utilisateur] [int] NOT NULL,
	[name-utilisateur] [nchar](10) NOT NULL,
	[mdp-utilisateur] [nchar](10) NOT NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[id-utilisateur] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Bondelivraison]  WITH CHECK ADD  CONSTRAINT [FK_Bondelivraison_client] FOREIGN KEY([id_bon])
REFERENCES [dbo].[client] ([id-client])
GO
ALTER TABLE [dbo].[Bondelivraison] CHECK CONSTRAINT [FK_Bondelivraison_client]
GO
ALTER TABLE [dbo].[Bondelivraison]  WITH CHECK ADD  CONSTRAINT [FK_Bondelivraison_Livrer] FOREIGN KEY([id_bon])
REFERENCES [dbo].[Livrer] ([id_livre])
GO
ALTER TABLE [dbo].[Bondelivraison] CHECK CONSTRAINT [FK_Bondelivraison_Livrer]
GO
ALTER TABLE [dbo].[Bondelivraison]  WITH CHECK ADD  CONSTRAINT [FK_Bondelivraison_pour] FOREIGN KEY([id_bon])
REFERENCES [dbo].[pour] ([id-for])
GO
ALTER TABLE [dbo].[Bondelivraison] CHECK CONSTRAINT [FK_Bondelivraison_pour]
GO
ALTER TABLE [dbo].[fourni]  WITH CHECK ADD  CONSTRAINT [FK_fourni_Date] FOREIGN KEY([id_fourni])
REFERENCES [dbo].[Date] ([id_date])
GO
ALTER TABLE [dbo].[fourni] CHECK CONSTRAINT [FK_fourni_Date]
GO
ALTER TABLE [dbo].[fourni]  WITH CHECK ADD  CONSTRAINT [FK_fourni_fournisseur] FOREIGN KEY([id_fourni])
REFERENCES [dbo].[fournisseur] ([id-fournisseur])
GO
ALTER TABLE [dbo].[fourni] CHECK CONSTRAINT [FK_fourni_fournisseur]
GO
ALTER TABLE [dbo].[fourni]  WITH CHECK ADD  CONSTRAINT [FK_fourni_produits] FOREIGN KEY([id_fourni])
REFERENCES [dbo].[produits] ([id-produit])
GO
ALTER TABLE [dbo].[fourni] CHECK CONSTRAINT [FK_fourni_produits]
GO
ALTER TABLE [dbo].[orders]  WITH CHECK ADD  CONSTRAINT [FK_orders_Date] FOREIGN KEY([id_order])
REFERENCES [dbo].[Date] ([id_date])
GO
ALTER TABLE [dbo].[orders] CHECK CONSTRAINT [FK_orders_Date]
GO
ALTER TABLE [dbo].[orders]  WITH CHECK ADD  CONSTRAINT [FK_orders_fournisseur] FOREIGN KEY([id_order])
REFERENCES [dbo].[fournisseur] ([id-fournisseur])
GO
ALTER TABLE [dbo].[orders] CHECK CONSTRAINT [FK_orders_fournisseur]
GO
ALTER TABLE [dbo].[orders]  WITH CHECK ADD  CONSTRAINT [FK_orders_users] FOREIGN KEY([id_order])
REFERENCES [dbo].[users] ([id-utilisateur])
GO
ALTER TABLE [dbo].[orders] CHECK CONSTRAINT [FK_orders_users]
GO
ALTER TABLE [dbo].[pour]  WITH CHECK ADD  CONSTRAINT [FK_pour_orders] FOREIGN KEY([id-for])
REFERENCES [dbo].[orders] ([id_order])
GO
ALTER TABLE [dbo].[pour] CHECK CONSTRAINT [FK_pour_orders]
GO
ALTER TABLE [dbo].[pour]  WITH CHECK ADD  CONSTRAINT [FK_pour_produits] FOREIGN KEY([id-for])
REFERENCES [dbo].[produits] ([id-produit])
GO
ALTER TABLE [dbo].[pour] CHECK CONSTRAINT [FK_pour_produits]
GO
ALTER TABLE [dbo].[users]  WITH CHECK ADD  CONSTRAINT [FK_users_employer] FOREIGN KEY([id-utilisateur])
REFERENCES [dbo].[employer] ([id-employer])
GO
ALTER TABLE [dbo].[users] CHECK CONSTRAINT [FK_users_employer]
GO
USE [master]
GO
ALTER DATABASE [GestionStock] SET  READ_WRITE 
GO
