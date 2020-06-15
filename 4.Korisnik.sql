

ALTER TABLE [dbo].[Korisnik] DROP CONSTRAINT [FK__Korisnik__Sifra__5BE2A6F2]
GO

/****** Object:  Table [dbo].[Korisnik]    Script Date: 12/29/2019 2:07:54 PM ******/
DROP TABLE [dbo].[Korisnik]
GO

/****** Object:  Table [dbo].[Korisnik]    Script Date: 12/29/2019 2:07:54 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Korisnik](
	[Sifra] [int] NOT NULL,
	[Username] [varchar](255) NULL,
	[Password] [varchar](255) NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Korisnik]  WITH CHECK ADD FOREIGN KEY([Sifra])
REFERENCES [dbo].[Osoba] ([Sifra])
GO


