

/****** Object:  Table [dbo].[Kurs]    Script Date: 12/29/2019 2:08:23 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Kurs](
	[IDKursa] [int] NOT NULL,
	[Naziv] [nchar](255) NULL,
	[Trajanje] [int] NULL,
	[Cena] [nvarchar](max) NULL,
	[Prostor] [int] NOT NULL,
	[Tip] [int] NULL,
 CONSTRAINT [PK_Kurs] PRIMARY KEY CLUSTERED 
(
	[IDKursa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Kurs]  WITH CHECK ADD  CONSTRAINT [FK_Kurs_Prostor] FOREIGN KEY([Prostor])
REFERENCES [dbo].[Ucionica] ([SifraProstora])
GO

ALTER TABLE [dbo].[Kurs] CHECK CONSTRAINT [FK_Kurs_Prostor]
GO

ALTER TABLE [dbo].[Kurs]  WITH CHECK ADD  CONSTRAINT [FK_Kurs_TipKursa] FOREIGN KEY([Tip])
REFERENCES [dbo].[TipKursa] ([IDTipa])
GO

ALTER TABLE [dbo].[Kurs] CHECK CONSTRAINT [FK_Kurs_TipKursa]
GO


