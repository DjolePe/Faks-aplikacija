
/****** Object:  Table [dbo].[Prisustvo]    Script Date: 12/29/2019 2:09:10 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Prisustvo](
	[Kurs] [int] NOT NULL,
	[Clan] [int] NOT NULL,
	[BrojPosete] [int] NOT NULL,
	[Datum] [datetime] NULL,
 CONSTRAINT [PK_Poseta] PRIMARY KEY CLUSTERED 
(
	[BrojPosete] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Prisustvo]  WITH CHECK ADD  CONSTRAINT [FK_Prisustvo_Osoba] FOREIGN KEY([Clan])
REFERENCES [dbo].[Osoba] ([Sifra])
GO

ALTER TABLE [dbo].[Prisustvo] CHECK CONSTRAINT [FK_Prisustvo_Osoba]
GO


