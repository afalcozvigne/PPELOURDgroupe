USE [master]
GO
/****** Object:  Database [GestionStock]    Script Date: 27/04/2016 15:06:57 ******/
CREATE DATABASE [GestionStock]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'wavedatabase', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.INSTANCE1\MSSQL\DATA\wavedatabase.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'wavedatabase_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.INSTANCE1\MSSQL\DATA\wavedatabase_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [GestionStock] SET COMPATIBILITY_LEVEL = 110
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
ALTER DATABASE [GestionStock] SET AUTO_CREATE_STATISTICS ON 
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
EXEC sys.sp_db_vardecimal_storage_format N'GestionStock', N'ON'
GO
USE [GestionStock]
GO
/****** Object:  Table [dbo].[Bondelivraison]    Script Date: 27/04/2016 15:06:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bondelivraison](
	[id_bon] [int] IDENTITY(1,1) NOT NULL,
	[date_bon] [date] NOT NULL,
 CONSTRAINT [PK_Bondelivraison] PRIMARY KEY CLUSTERED 
(
	[id_bon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[client]    Script Date: 27/04/2016 15:06:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[client](
	[id_client] [int] IDENTITY(1,1) NOT NULL,
	[nom_client] [nvarchar](50) NOT NULL,
	[prenom_client] [nvarchar](50) NOT NULL,
	[adresse_client] [nvarchar](max) NOT NULL,
	[tel_client] [int] NOT NULL,
 CONSTRAINT [PK_client] PRIMARY KEY CLUSTERED 
(
	[id_client] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Date]    Script Date: 27/04/2016 15:06:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Date](
	[id_date] [int] IDENTITY(1,1) NOT NULL,
	[libelle_date] [date] NOT NULL,
 CONSTRAINT [PK_Date] PRIMARY KEY CLUSTERED 
(
	[id_date] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[employer]    Script Date: 27/04/2016 15:06:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[employer](
	[id_employer] [int] IDENTITY(1,1) NOT NULL,
	[nom_employer] [nchar](10) NOT NULL,
	[prenom_employer] [nchar](10) NOT NULL,
	[ddn_employer] [nchar](10) NOT NULL,
	[adresse_employer] [nvarchar](150) NOT NULL,
	[tel_employer] [varchar](50) NOT NULL,
 CONSTRAINT [PK_employer] PRIMARY KEY CLUSTERED 
(
	[id_employer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[fixations]    Script Date: 27/04/2016 15:06:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[fixations](
	[id_fixation] [int] IDENTITY(1,1) NOT NULL,
	[libele_fixation] [varchar](50) NOT NULL,
	[type_fixation] [varchar](20) NOT NULL,
	[prix__fixation] [float] NOT NULL,
	[id_produit_fix] [nchar](10) NULL,
	[nom_fixation] [varchar](50) NULL,
 CONSTRAINT [PK_fixations] PRIMARY KEY CLUSTERED 
(
	[id_fixation] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[fournisseur]    Script Date: 27/04/2016 15:06:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[fournisseur](
	[id_fournisseur] [int] IDENTITY(1,1) NOT NULL,
	[labelle_fournisseur] [varchar](50) NOT NULL,
	[adresse_fournisseur] [varchar](max) NOT NULL,
	[tel_fournisseur] [int] NOT NULL,
	[id_produitpro] [int] NOT NULL,
 CONSTRAINT [PK_foursniseur] PRIMARY KEY CLUSTERED 
(
	[id_fournisseur] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[fournit]    Script Date: 27/04/2016 15:06:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[fournit](
	[id_fournit] [int] IDENTITY(1,1) NOT NULL,
	[quatitee_fournit] [int] NOT NULL,
	[id_fournisseurfournit] [int] NULL,
	[prix_fournit] [int] NOT NULL,
 CONSTRAINT [PK_fourni] PRIMARY KEY CLUSTERED 
(
	[id_fournit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Livrer]    Script Date: 27/04/2016 15:06:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Livrer](
	[id_livre] [int] IDENTITY(1,1) NOT NULL,
	[quatitee_livre] [int] NOT NULL,
 CONSTRAINT [PK_Livrer] PRIMARY KEY CLUSTERED 
(
	[id_livre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[orders]    Script Date: 27/04/2016 15:06:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orders](
	[id_order] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_orders] PRIMARY KEY CLUSTERED 
(
	[id_order] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[pour]    Script Date: 27/04/2016 15:06:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pour](
	[id_pour] [int] IDENTITY(1,1) NOT NULL,
	[quatitee_pour] [int] NOT NULL,
 CONSTRAINT [PK_pour] PRIMARY KEY CLUSTERED 
(
	[id_pour] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[produits]    Script Date: 27/04/2016 15:06:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[produits](
	[id_produit] [int] IDENTITY(1,1) NOT NULL,
	[labelle_produit] [nvarchar](50) NOT NULL,
	[typemateriel_produit] [varchar](20) NOT NULL,
	[typecomposant_produit] [varchar](20) NOT NULL,
	[prix_produit] [float] NOT NULL,
	[vitesse_produit] [int] NULL,
	[figure_produit] [int] NULL,
	[style_produit] [int] NULL,
	[stabilite_produit] [int] NULL,
	[id_pourprod] [int] NOT NULL,
 CONSTRAINT [PK_produits] PRIMARY KEY CLUSTERED 
(
	[id_produit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[roues]    Script Date: 27/04/2016 15:06:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[roues](
	[id_roue] [int] IDENTITY(1,1) NOT NULL,
	[libelle_roue] [varchar](50) NOT NULL,
	[type_roue] [varchar](20) NOT NULL,
	[prix_roue] [float] NOT NULL,
	[id_produit_roue] [int] NULL,
	[vitesse_roue] [int] NOT NULL,
	[figure_roue] [int] NOT NULL,
	[stabilitee_roue] [int] NOT NULL,
	[style_roue] [int] NOT NULL,
	[nom_roue] [varchar](50) NULL,
 CONSTRAINT [PK_roues] PRIMARY KEY CLUSTERED 
(
	[id_roue] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[users]    Script Date: 27/04/2016 15:06:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[users](
	[id_utilisateur] [int] IDENTITY(1,1) NOT NULL,
	[name_utilisateur] [nchar](50) NOT NULL,
	[admin_utilisateur] [bit] NULL,
	[mdp_utilisateur] [varchar](50) NOT NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[id_utilisateur] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Bondelivraison]  WITH CHECK ADD  CONSTRAINT [FK_Bondelivraison_client] FOREIGN KEY([id_bon])
REFERENCES [dbo].[client] ([id_client])
GO
ALTER TABLE [dbo].[Bondelivraison] CHECK CONSTRAINT [FK_Bondelivraison_client]
GO
ALTER TABLE [dbo].[Bondelivraison]  WITH CHECK ADD  CONSTRAINT [FK_Bondelivraison_Livrer] FOREIGN KEY([id_bon])
REFERENCES [dbo].[Livrer] ([id_livre])
GO
ALTER TABLE [dbo].[Bondelivraison] CHECK CONSTRAINT [FK_Bondelivraison_Livrer]
GO
ALTER TABLE [dbo].[Bondelivraison]  WITH CHECK ADD  CONSTRAINT [FK_Bondelivraison_pour] FOREIGN KEY([id_bon])
REFERENCES [dbo].[pour] ([id_pour])
GO
ALTER TABLE [dbo].[Bondelivraison] CHECK CONSTRAINT [FK_Bondelivraison_pour]
GO
ALTER TABLE [dbo].[fournisseur]  WITH CHECK ADD  CONSTRAINT [FK_fournisseur_produits] FOREIGN KEY([id_produitpro])
REFERENCES [dbo].[produits] ([id_produit])
GO
ALTER TABLE [dbo].[fournisseur] CHECK CONSTRAINT [FK_fournisseur_produits]
GO
ALTER TABLE [dbo].[fournit]  WITH CHECK ADD  CONSTRAINT [FK_fourni_Date] FOREIGN KEY([id_fournit])
REFERENCES [dbo].[Date] ([id_date])
GO
ALTER TABLE [dbo].[fournit] CHECK CONSTRAINT [FK_fourni_Date]
GO
ALTER TABLE [dbo].[fournit]  WITH CHECK ADD  CONSTRAINT [FK_fournit_fournisseur] FOREIGN KEY([id_fournisseurfournit])
REFERENCES [dbo].[fournisseur] ([id_fournisseur])
GO
ALTER TABLE [dbo].[fournit] CHECK CONSTRAINT [FK_fournit_fournisseur]
GO
ALTER TABLE [dbo].[orders]  WITH CHECK ADD  CONSTRAINT [FK_orders_Date] FOREIGN KEY([id_order])
REFERENCES [dbo].[Date] ([id_date])
GO
ALTER TABLE [dbo].[orders] CHECK CONSTRAINT [FK_orders_Date]
GO
ALTER TABLE [dbo].[orders]  WITH CHECK ADD  CONSTRAINT [FK_orders_fournisseur] FOREIGN KEY([id_order])
REFERENCES [dbo].[fournisseur] ([id_fournisseur])
GO
ALTER TABLE [dbo].[orders] CHECK CONSTRAINT [FK_orders_fournisseur]
GO
ALTER TABLE [dbo].[orders]  WITH CHECK ADD  CONSTRAINT [FK_orders_users] FOREIGN KEY([id_order])
REFERENCES [dbo].[users] ([id_utilisateur])
GO
ALTER TABLE [dbo].[orders] CHECK CONSTRAINT [FK_orders_users]
GO
ALTER TABLE [dbo].[pour]  WITH CHECK ADD  CONSTRAINT [FK_pour_orders] FOREIGN KEY([id_pour])
REFERENCES [dbo].[orders] ([id_order])
GO
ALTER TABLE [dbo].[pour] CHECK CONSTRAINT [FK_pour_orders]
GO
ALTER TABLE [dbo].[produits]  WITH CHECK ADD  CONSTRAINT [FK_produits_pour] FOREIGN KEY([id_pourprod])
REFERENCES [dbo].[pour] ([id_pour])
GO
ALTER TABLE [dbo].[produits] CHECK CONSTRAINT [FK_produits_pour]
GO
ALTER TABLE [dbo].[roues]  WITH CHECK ADD  CONSTRAINT [FK_roues_produits] FOREIGN KEY([id_produit_roue])
REFERENCES [dbo].[produits] ([id_produit])
GO
ALTER TABLE [dbo].[roues] CHECK CONSTRAINT [FK_roues_produits]
GO
ALTER TABLE [dbo].[users]  WITH CHECK ADD  CONSTRAINT [FK_users_employer] FOREIGN KEY([id_utilisateur])
REFERENCES [dbo].[employer] ([id_employer])
GO
ALTER TABLE [dbo].[users] CHECK CONSTRAINT [FK_users_employer]
GO
USE [master]
GO
ALTER DATABASE [GestionStock] SET  READ_WRITE 
GO
