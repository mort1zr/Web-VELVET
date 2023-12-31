USE [BD_VENTA]
GO
/****** Object:  Table [dbo].[CATEGORIA]    Script Date: 28/06/2023 01:39:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CATEGORIA](
	[idCATEGORIA] [int] IDENTITY(1,1) NOT NULL,
	[nombreCATEGORIA] [varchar](50) NULL,
 CONSTRAINT [PK_CATEGORIA] PRIMARY KEY CLUSTERED 
(
	[idCATEGORIA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CLIENTE]    Script Date: 28/06/2023 01:39:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CLIENTE](
	[idCLIENTE] [int] IDENTITY(1,1) NOT NULL,
	[nombreCLIENTE] [varchar](50) NULL,
	[apellidoCLIENTE] [varchar](50) NULL,
	[direccionCLIENTE] [varchar](50) NULL,
	[passwordCLIENTE] [varchar](50) NULL,
 CONSTRAINT [PK_CLIENTE] PRIMARY KEY CLUSTERED 
(
	[idCLIENTE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalleVENTA]    Script Date: 28/06/2023 01:39:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalleVENTA](
	[idVENTA] [int] NOT NULL,
	[idPRODUCTO] [int] NOT NULL,
	[precioVENTA] [float] NOT NULL,
	[CANTIDAD] [int] NOT NULL,
	[idDV] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_detalleVENTA] PRIMARY KEY CLUSTERED 
(
	[idDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRODUCT]    Script Date: 28/06/2023 01:39:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRODUCT](
	[idPRODUCTO] [int] IDENTITY(1,1) NOT NULL,
	[nombrePRODUCTO] [varchar](50) NOT NULL,
	[precioPRODUCTO] [float] NOT NULL,
	[stockPRODUCTO] [int] NOT NULL,
	[idCATEGORIA] [int] NOT NULL,
	[imgPRODUCTO] [varchar](max) NULL,
	[desProducto] [text] NULL,
 CONSTRAINT [PK_PRODUCT] PRIMARY KEY CLUSTERED 
(
	[idPRODUCTO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VENTA]    Script Date: 28/06/2023 01:39:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VENTA](
	[idVENTA] [int] IDENTITY(1,1) NOT NULL,
	[fechaVENTA] [date] NULL,
	[montoVENTA] [float] NULL,
	[idCLIENTE] [int] NULL,
	[estadoVENTA] [nchar](10) NULL,
 CONSTRAINT [PK_VENTA] PRIMARY KEY CLUSTERED 
(
	[idVENTA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CATEGORIA] ON 

INSERT [dbo].[CATEGORIA] ([idCATEGORIA], [nombreCATEGORIA]) VALUES (1, N'Polos')
INSERT [dbo].[CATEGORIA] ([idCATEGORIA], [nombreCATEGORIA]) VALUES (2, N'Casacas')
INSERT [dbo].[CATEGORIA] ([idCATEGORIA], [nombreCATEGORIA]) VALUES (3, N'Poleras')
INSERT [dbo].[CATEGORIA] ([idCATEGORIA], [nombreCATEGORIA]) VALUES (4, N'Accesorios')
INSERT [dbo].[CATEGORIA] ([idCATEGORIA], [nombreCATEGORIA]) VALUES (5, N'Buzos')
INSERT [dbo].[CATEGORIA] ([idCATEGORIA], [nombreCATEGORIA]) VALUES (6, N'Jeans')
INSERT [dbo].[CATEGORIA] ([idCATEGORIA], [nombreCATEGORIA]) VALUES (7, N'Pijamas')
INSERT [dbo].[CATEGORIA] ([idCATEGORIA], [nombreCATEGORIA]) VALUES (8, N'Zapatos')
INSERT [dbo].[CATEGORIA] ([idCATEGORIA], [nombreCATEGORIA]) VALUES (9, N'Zapatillas')
INSERT [dbo].[CATEGORIA] ([idCATEGORIA], [nombreCATEGORIA]) VALUES (10, N'Sandalias')
SET IDENTITY_INSERT [dbo].[CATEGORIA] OFF
GO
SET IDENTITY_INSERT [dbo].[CLIENTE] ON 

INSERT [dbo].[CLIENTE] ([idCLIENTE], [nombreCLIENTE], [apellidoCLIENTE], [direccionCLIENTE], [passwordCLIENTE]) VALUES (0, NULL, NULL, NULL, NULL)
INSERT [dbo].[CLIENTE] ([idCLIENTE], [nombreCLIENTE], [apellidoCLIENTE], [direccionCLIENTE], [passwordCLIENTE]) VALUES (1, N'Aaron', N'Ortiz', N'aaronov23@gmail.com', N'aaron123        ')
INSERT [dbo].[CLIENTE] ([idCLIENTE], [nombreCLIENTE], [apellidoCLIENTE], [direccionCLIENTE], [passwordCLIENTE]) VALUES (2, N'Angie', N'Jara', N'angie.jara@usil.pe', N'angie123            ')
INSERT [dbo].[CLIENTE] ([idCLIENTE], [nombreCLIENTE], [apellidoCLIENTE], [direccionCLIENTE], [passwordCLIENTE]) VALUES (3, N'Admin', N'Total', N'admin@gmail.com', N'Admin123')
SET IDENTITY_INSERT [dbo].[CLIENTE] OFF
GO
SET IDENTITY_INSERT [dbo].[PRODUCT] ON 

INSERT [dbo].[PRODUCT] ([idPRODUCTO], [nombrePRODUCTO], [precioPRODUCTO], [stockPRODUCTO], [idCATEGORIA], [imgPRODUCTO], [desProducto]) VALUES (1, N'PoloH', 15.5, 1000, 1, N'https://hmperu.vtexassets.com/arquivos/ids/2865807/Camisa-de-twill-Relaxed-Fit---Rojo-Negro---H-M-PE.jpg?v=637944458326200000', N'Polo para hombre')
INSERT [dbo].[PRODUCT] ([idPRODUCTO], [nombrePRODUCTO], [precioPRODUCTO], [stockPRODUCTO], [idCATEGORIA], [imgPRODUCTO], [desProducto]) VALUES (2, N'PoloM', 20, 1000, 1, N'https://cdn.shopify.com/s/files/1/0548/9128/2691/products/42_48694cdd-ec78-462c-a825-3f7b270d5f2e_533x.png?v=1675823990', N'Polo para mujer')
INSERT [dbo].[PRODUCT] ([idPRODUCTO], [nombrePRODUCTO], [precioPRODUCTO], [stockPRODUCTO], [idCATEGORIA], [imgPRODUCTO], [desProducto]) VALUES (3, N'CasacaM', 59.99, 200, 2, N'https://hmperu.vtexassets.com/arquivos/ids/2927929-483-725/Chaqueta-puffy---Beige-claro---H-M-PE.jpg?v=637964426379930000', N'Casaca bonita para mujer')
INSERT [dbo].[PRODUCT] ([idPRODUCTO], [nombrePRODUCTO], [precioPRODUCTO], [stockPRODUCTO], [idCATEGORIA], [imgPRODUCTO], [desProducto]) VALUES (4, N'PoleraH', 75.5, 300, 3, N'https://oechsle.vteximg.com.br/arquivos/ids/12373505-1000-1000/imageUrl_1.jpg?v=638037284249170000', NULL)
INSERT [dbo].[PRODUCT] ([idPRODUCTO], [nombrePRODUCTO], [precioPRODUCTO], [stockPRODUCTO], [idCATEGORIA], [imgPRODUCTO], [desProducto]) VALUES (5, N'PoleraM', 79.99, 300, 3, N'https://www.gap.com.pe/media/catalog/product/cache/image/700x560/e9c3970ab036de70892d86c6d221abfe/5/2/527507_c09_1.jpg', NULL)
INSERT [dbo].[PRODUCT] ([idPRODUCTO], [nombrePRODUCTO], [precioPRODUCTO], [stockPRODUCTO], [idCATEGORIA], [imgPRODUCTO], [desProducto]) VALUES (6, N'Zapatilla Tenis', 299.99, 100, 9, N'https://bataperu.vtexassets.com/arquivos/ids/313948-800-auto?v=638127049335670000&width=800&height=auto&aspect=true', NULL)
INSERT [dbo].[PRODUCT] ([idPRODUCTO], [nombrePRODUCTO], [precioPRODUCTO], [stockPRODUCTO], [idCATEGORIA], [imgPRODUCTO], [desProducto]) VALUES (7, N'Zapatilla Urbana', 299.99, 19, 9, N'https://coliseum.vteximg.com.br/arquivos/ids/469048-1000-1000/ZAPATILLA-MUJER-FILA-DISRUPTOR-II-PREMIUM-5XM01134-650_1.jpg?v=637889181970330000', NULL)
INSERT [dbo].[PRODUCT] ([idPRODUCTO], [nombrePRODUCTO], [precioPRODUCTO], [stockPRODUCTO], [idCATEGORIA], [imgPRODUCTO], [desProducto]) VALUES (8, N'Sandalia', 49.99, 300, 10, N'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSGHTnl1qyP4RZaAE18ObjhSjy9KsajPGmun1uAPMzhJMMQvaC4QTmur5_-9wCI41xz2T8&usqp=CAU', N'Sandilia bonita')
INSERT [dbo].[PRODUCT] ([idPRODUCTO], [nombrePRODUCTO], [precioPRODUCTO], [stockPRODUCTO], [idCATEGORIA], [imgPRODUCTO], [desProducto]) VALUES (9, N'Jean', 79.99, 20, 6, NULL, N'Jean azul')
INSERT [dbo].[PRODUCT] ([idPRODUCTO], [nombrePRODUCTO], [precioPRODUCTO], [stockPRODUCTO], [idCATEGORIA], [imgPRODUCTO], [desProducto]) VALUES (10, N'Buzo Camo', 56.6, 40, 5, NULL, N'Buzo Camuflado Verde')
INSERT [dbo].[PRODUCT] ([idPRODUCTO], [nombrePRODUCTO], [precioPRODUCTO], [stockPRODUCTO], [idCATEGORIA], [imgPRODUCTO], [desProducto]) VALUES (11, N'Reloj', 99.5, 5, 4, NULL, N'Reloj que marca la hora')
INSERT [dbo].[PRODUCT] ([idPRODUCTO], [nombrePRODUCTO], [precioPRODUCTO], [stockPRODUCTO], [idCATEGORIA], [imgPRODUCTO], [desProducto]) VALUES (12, N'Pijama', 65.75, 20, 7, NULL, N'Pijama para mujer')
INSERT [dbo].[PRODUCT] ([idPRODUCTO], [nombrePRODUCTO], [precioPRODUCTO], [stockPRODUCTO], [idCATEGORIA], [imgPRODUCTO], [desProducto]) VALUES (13, N'Pijama', 45.5, 10, 7, NULL, N'Pijama para hombre')
INSERT [dbo].[PRODUCT] ([idPRODUCTO], [nombrePRODUCTO], [precioPRODUCTO], [stockPRODUCTO], [idCATEGORIA], [imgPRODUCTO], [desProducto]) VALUES (14, N'Botines', 299.5, 10, 9, NULL, N'Botines Caterpillar')
INSERT [dbo].[PRODUCT] ([idPRODUCTO], [nombrePRODUCTO], [precioPRODUCTO], [stockPRODUCTO], [idCATEGORIA], [imgPRODUCTO], [desProducto]) VALUES (15, N'Zapatilla Training', 250.99, 15, 9, NULL, N'Zapatilla Nike M')
INSERT [dbo].[PRODUCT] ([idPRODUCTO], [nombrePRODUCTO], [precioPRODUCTO], [stockPRODUCTO], [idCATEGORIA], [imgPRODUCTO], [desProducto]) VALUES (16, N'Zapatilla Casual', 219, 20, 9, NULL, N'Zapatilla Tenis Mujer Adidas')
INSERT [dbo].[PRODUCT] ([idPRODUCTO], [nombrePRODUCTO], [precioPRODUCTO], [stockPRODUCTO], [idCATEGORIA], [imgPRODUCTO], [desProducto]) VALUES (17, N'Sandalias Unisex', 89.4, 7, 10, NULL, N'Sandalias Unisex adidas Adilette')
INSERT [dbo].[PRODUCT] ([idPRODUCTO], [nombrePRODUCTO], [precioPRODUCTO], [stockPRODUCTO], [idCATEGORIA], [imgPRODUCTO], [desProducto]) VALUES (18, N'Sandalias Crocs', 249, 8, 10, NULL, N'Sandalias Crocs Crocband Unisex')
INSERT [dbo].[PRODUCT] ([idPRODUCTO], [nombrePRODUCTO], [precioPRODUCTO], [stockPRODUCTO], [idCATEGORIA], [imgPRODUCTO], [desProducto]) VALUES (19, N'Casaca Chiporro', 79.9, 25, 2, N'https://s7d2.scene7.com/is/image/TottusPE/42916723_1?wid=1500&hei=1500&qlt=70', N'Casaca Chiporro Hombre')
INSERT [dbo].[PRODUCT] ([idPRODUCTO], [nombrePRODUCTO], [precioPRODUCTO], [stockPRODUCTO], [idCATEGORIA], [imgPRODUCTO], [desProducto]) VALUES (20, N'Chaqueta', 199, 22, 2, N'https://falabella.scene7.com/is/image/FalabellaPE/120172511_1?wid=800&hei=800&qlt=70', N'Chaqueta tipo cuero para hombre chaqueta de informal abrigo cálido')
INSERT [dbo].[PRODUCT] ([idPRODUCTO], [nombrePRODUCTO], [precioPRODUCTO], [stockPRODUCTO], [idCATEGORIA], [imgPRODUCTO], [desProducto]) VALUES (21, N'Abrigo Casual', 293.93, 10, 2, NULL, N'Abrigo Casual Mujer Springfield')
INSERT [dbo].[PRODUCT] ([idPRODUCTO], [nombrePRODUCTO], [precioPRODUCTO], [stockPRODUCTO], [idCATEGORIA], [imgPRODUCTO], [desProducto]) VALUES (22, N'Cardigan', 39.95, 10, 2, NULL, N'Cardigan Mujer University Club')
INSERT [dbo].[PRODUCT] ([idPRODUCTO], [nombrePRODUCTO], [precioPRODUCTO], [stockPRODUCTO], [idCATEGORIA], [imgPRODUCTO], [desProducto]) VALUES (23, N'Casaca Parka', 184, 10, 2, NULL, N'Casaca Parka Mujer Fordan Jeans')
INSERT [dbo].[PRODUCT] ([idPRODUCTO], [nombrePRODUCTO], [precioPRODUCTO], [stockPRODUCTO], [idCATEGORIA], [imgPRODUCTO], [desProducto]) VALUES (24, N'Abrigo', 129.25, 16, 2, NULL, N'Abrigo Mujer Basement')
INSERT [dbo].[PRODUCT] ([idPRODUCTO], [nombrePRODUCTO], [precioPRODUCTO], [stockPRODUCTO], [idCATEGORIA], [imgPRODUCTO], [desProducto]) VALUES (25, N'Camisaco', 149.9, 50, 2, NULL, N'Camisaco Cuerina Mujer')
SET IDENTITY_INSERT [dbo].[PRODUCT] OFF
GO
SET IDENTITY_INSERT [dbo].[VENTA] ON 

INSERT [dbo].[VENTA] ([idVENTA], [fechaVENTA], [montoVENTA], [idCLIENTE], [estadoVENTA]) VALUES (23, CAST(N'2023-06-27' AS Date), 35.5, 1, N'Pendiente ')
INSERT [dbo].[VENTA] ([idVENTA], [fechaVENTA], [montoVENTA], [idCLIENTE], [estadoVENTA]) VALUES (24, CAST(N'2023-06-27' AS Date), 75.49, 1, N'Pendiente ')
INSERT [dbo].[VENTA] ([idVENTA], [fechaVENTA], [montoVENTA], [idCLIENTE], [estadoVENTA]) VALUES (25, CAST(N'2023-06-27' AS Date), 15.5, 1, N'Pendiente ')
INSERT [dbo].[VENTA] ([idVENTA], [fechaVENTA], [montoVENTA], [idCLIENTE], [estadoVENTA]) VALUES (26, CAST(N'2023-06-27' AS Date), 59.99, 1, N'Pendiente ')
INSERT [dbo].[VENTA] ([idVENTA], [fechaVENTA], [montoVENTA], [idCLIENTE], [estadoVENTA]) VALUES (28, CAST(N'2023-06-27' AS Date), 20, 1, N'Realizada ')
INSERT [dbo].[VENTA] ([idVENTA], [fechaVENTA], [montoVENTA], [idCLIENTE], [estadoVENTA]) VALUES (29, CAST(N'2023-06-27' AS Date), 15.5, 2, N'Realizada ')
SET IDENTITY_INSERT [dbo].[VENTA] OFF
GO
/****** Object:  Index [IX_detalleVENTA]    Script Date: 28/06/2023 01:39:08 ******/
CREATE NONCLUSTERED INDEX [IX_detalleVENTA] ON [dbo].[detalleVENTA]
(
	[idVENTA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[detalleVENTA]  WITH CHECK ADD  CONSTRAINT [FK_detalleVENTA_PRODUCT] FOREIGN KEY([idPRODUCTO])
REFERENCES [dbo].[PRODUCT] ([idPRODUCTO])
GO
ALTER TABLE [dbo].[detalleVENTA] CHECK CONSTRAINT [FK_detalleVENTA_PRODUCT]
GO
ALTER TABLE [dbo].[detalleVENTA]  WITH CHECK ADD  CONSTRAINT [FK_detalleVENTA_VENTA] FOREIGN KEY([idVENTA])
REFERENCES [dbo].[VENTA] ([idVENTA])
GO
ALTER TABLE [dbo].[detalleVENTA] CHECK CONSTRAINT [FK_detalleVENTA_VENTA]
GO
ALTER TABLE [dbo].[PRODUCT]  WITH CHECK ADD  CONSTRAINT [FK_PRODUCT_CATEGORIA] FOREIGN KEY([idCATEGORIA])
REFERENCES [dbo].[CATEGORIA] ([idCATEGORIA])
GO
ALTER TABLE [dbo].[PRODUCT] CHECK CONSTRAINT [FK_PRODUCT_CATEGORIA]
GO
ALTER TABLE [dbo].[VENTA]  WITH CHECK ADD  CONSTRAINT [FK_VENTA_CLIENTE] FOREIGN KEY([idCLIENTE])
REFERENCES [dbo].[CLIENTE] ([idCLIENTE])
GO
ALTER TABLE [dbo].[VENTA] CHECK CONSTRAINT [FK_VENTA_CLIENTE]
GO
