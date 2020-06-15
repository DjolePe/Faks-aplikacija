
/****** Object:  Table [dbo].[Ucionica]    Script Date: 12/29/2019 2:08:44 PM ******/

/****** Object:  Table [dbo].[Ucionica]    Script Date: 12/29/2019 2:08:44 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Ucionica](
	[SifraProstora] [int] NOT NULL,
	[NazivProstora] [nchar](40) NULL,
 CONSTRAINT [PK_Prostor] PRIMARY KEY CLUSTERED 
(
	[SifraProstora] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


