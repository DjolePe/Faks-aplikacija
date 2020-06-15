
/****** Object:  Table [dbo].[Clan]    Script Date: 12/29/2019 2:07:34 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Clan](
	[SifraClana] [int] NOT NULL,
	[Email] [varchar](255) NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Clan]  WITH CHECK ADD  CONSTRAINT [FK__Clan__SifraClana__276EDEB3] FOREIGN KEY([SifraClana])
REFERENCES [dbo].[Osoba] ([Sifra])
GO

ALTER TABLE [dbo].[Clan] CHECK CONSTRAINT [FK__Clan__SifraClana__276EDEB3]
GO


