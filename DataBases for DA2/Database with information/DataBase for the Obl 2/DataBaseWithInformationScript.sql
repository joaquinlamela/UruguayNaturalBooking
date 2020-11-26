USE [master]
GO

/****** Object:  Database [ObligatorioDataBase]    Script Date: 26/11/2020 15:25:42 ******/
DROP DATABASE [ObligatorioDataBase]
GO

/****** Object:  Database [ObligatorioDataBase]    Script Date: 26/11/2020 15:25:42 ******/
CREATE DATABASE [ObligatorioDataBase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ObligatorioDataBase', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\ObligatorioDataBase.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ObligatorioDataBase_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\ObligatorioDataBase_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ObligatorioDataBase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [ObligatorioDataBase] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [ObligatorioDataBase] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [ObligatorioDataBase] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [ObligatorioDataBase] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [ObligatorioDataBase] SET ARITHABORT OFF 
GO

ALTER DATABASE [ObligatorioDataBase] SET AUTO_CLOSE ON 
GO

ALTER DATABASE [ObligatorioDataBase] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [ObligatorioDataBase] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [ObligatorioDataBase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [ObligatorioDataBase] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [ObligatorioDataBase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [ObligatorioDataBase] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [ObligatorioDataBase] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [ObligatorioDataBase] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [ObligatorioDataBase] SET  ENABLE_BROKER 
GO

ALTER DATABASE [ObligatorioDataBase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [ObligatorioDataBase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [ObligatorioDataBase] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [ObligatorioDataBase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [ObligatorioDataBase] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [ObligatorioDataBase] SET READ_COMMITTED_SNAPSHOT ON 
GO

ALTER DATABASE [ObligatorioDataBase] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [ObligatorioDataBase] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [ObligatorioDataBase] SET  MULTI_USER 
GO

ALTER DATABASE [ObligatorioDataBase] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [ObligatorioDataBase] SET DB_CHAINING OFF 
GO

ALTER DATABASE [ObligatorioDataBase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [ObligatorioDataBase] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [ObligatorioDataBase] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [ObligatorioDataBase] SET QUERY_STORE = OFF
GO

ALTER DATABASE [ObligatorioDataBase] SET  READ_WRITE 
GO
