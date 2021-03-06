USE [sistema_mensajeria]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 4/13/2020 10:16:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](20) NOT NULL,
	[Apellido] [varchar](20) NOT NULL,
	[Correo] [varchar](150) NOT NULL,
	[Contrasena] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[usuarios] ON 

INSERT [dbo].[usuarios] ([Id], [Nombre], [Apellido], [Correo], [Contrasena]) VALUES (1, N'Katiuska', N'Gonzalez', N'katiuska012011@gmail.com', N'yoseretusol')
INSERT [dbo].[usuarios] ([Id], [Nombre], [Apellido], [Correo], [Contrasena]) VALUES (2, N'Benjamin', N'Baez', N'Benja@gmail.com', N'amo a katiuska')
INSERT [dbo].[usuarios] ([Id], [Nombre], [Apellido], [Correo], [Contrasena]) VALUES (4, N'Admin', N'Admin', N'admin@gmail.com', N'123')
INSERT [dbo].[usuarios] ([Id], [Nombre], [Apellido], [Correo], [Contrasena]) VALUES (5, N'Migdalia', N'Baez', N'migdalia.baez@gmail.com', N'1234')
INSERT [dbo].[usuarios] ([Id], [Nombre], [Apellido], [Correo], [Contrasena]) VALUES (6, N'jababa', N'jabababa', N'jababa@gmail.com', N'hola')
SET IDENTITY_INSERT [dbo].[usuarios] OFF
