--DROP TABLE tbProducto ;
--DROP TABLE tbDetalleCotizacion ;
--DROP TABLE tbProductoExtendido ;
--DROP TABLE tbDetalleVenta ;
--DROP TABLE tbCotizacion ;
--DROP TABLE tbEmpleado ;
--DROP TABLE tbVenta ;
--DROP TABLE tbCliente ;
--DROP TABLE tbUsuario ;

create table tbUsuario(IdUsuario int not null,
					   NombreUsuario varchar(20) not null,
					   Contrasena varchar(15) not null);

create table tbCliente(NombreCompleto varchar(50) not null,
					   Edad int,
					   Telefono int,
					   Email varchar(100) not null,
					   Sexo varchar(15),
					   tbUsuario_IdUsuario int not null);

create table tbVenta(IdVenta int not null,
					 FechaVenta date not null,
					 MontoVenta decimal not null,
					 DetalleVenta varchar(200) not null,
					 tbCotizacion_IdCotizacion int not null,
					 tbEmpleado_tbUsuario_IdUsuario int Not null,
					 tbCliente_tbUsuario_IdUsuario int not null);

create table tbEmpleado(NombreCompleto varchar(50) not null,
						Edad int,
						Telefono int,
						Email varchar(50) not null,
						sexo varchar(15),
						tbUsuario_IdUsuario int not null);

create table tbCotizacion(IdCotizacion int not null,
						  Mensaje varchar(200),
						  FechaIngreso date not null,
						  Respuesta varchar(200) not null,
						  FechaRespuesta date,
						  Estado varchar(15),
						  tbDetalleCotizacion_IdDetalleCotizacion int not null,
						  tbEmpleado_tbUsuario_IdUsuario int not null,
						  tbCliente_tbUsuario_IdUsuario int not null);

create table tbDetalleVenta(IdDetalleVenta int not null,
							UnidadesProducto decimal not null,
							tbProductoExtendido_CodBarra varchar(20) not null);

create table tbProductoExtendido(CodBarra varchar(20) not null,
								 FechaElaboracion date not null,
								 FechaVencimiento date not null,
								 tbProducto_SkuProducto varchar(30)not null);

create table tbDetalleCotizacion(IdDetalleCotizacion int not null,
								 UnidadesProducto decimal not null,
								 tbProducto_SkuProducto varchar(30)not null);

create table tbProducto(SkuProducto varchar(30) not null,
					    NombreProducto varchar(50) not null,
					    Valor int not null,
					    Imagen image not null,
					    UnidadMedida varchar(15) not null);


ALTER TABLE tbUsuario ADD PRIMARY KEY (IdUsuario);
ALTER TABLE tbVenta ADD PRIMARY KEY (IdVenta);
ALTER TABLE tbDetalleVenta ADD PRIMARY KEY (IdDetalleVenta);
ALTER TABLE tbCotizacion ADD PRIMARY KEY (IdCotizacion);
ALTER TABLE tbProductoExtendido ADD PRIMARY KEY (CodBarra);
ALTER TABLE tbDetalleCotizacion ADD PRIMARY KEY (IdDetalleCotizacion);
ALTER TABLE tbProducto ADD PRIMARY KEY (SkuProducto);
ALTER TABLE tbCliente ADD PRIMARY KEY (tbUsuario_IdUsuario);
ALTER TABLE tbEmpleado ADD PRIMARY KEY (tbUsuario_IdUsuario);



ALTER TABLE tbDetalleVenta
ADD FOREIGN KEY (tbProductoExtendido_CodBarra) REFERENCES tbProductoExtendido(CodBarra); 
ALTER TABLE tbEmpleado
ADD FOREIGN KEY (tbUsuario_IdUsuario) REFERENCES tbUsuario(IdUsuario);
ALTER TABLE tbCliente
ADD FOREIGN KEY (tbUsuario_IdUsuario) REFERENCES tbUsuario(IdUsuario);
ALTER TABLE tbProductoExtendido
ADD FOREIGN KEY (tbProducto_SkuProducto) REFERENCES tbProducto(SkuProducto); 
ALTER TABLE tbVenta
ADD FOREIGN KEY (tbCotizacion_IdCotizacion) REFERENCES tbCotizacion(IdCotizacion);
ALTER TABLE tbVenta
ADD FOREIGN KEY (tbEmpleado_tbUsuario_IdUsuario) REFERENCES tbUsuario(IdUsuario);
ALTER TABLE tbVenta
ADD FOREIGN KEY (tbCliente_tbUsuario_IdUsuario) REFERENCES tbUsuario(IdUsuario);
ALTER TABLE tbCotizacion
ADD FOREIGN KEY (tbDetalleCotizacion_IdDetalleCotizacion) REFERENCES tbDetalleCotizacion(IdDetalleCotizacion);
ALTER TABLE tbCotizacion
ADD FOREIGN KEY (tbEmpleado_tbUsuario_IdUsuario) REFERENCES tbUsuario(IdUsuario);
ALTER TABLE tbCotizacion
ADD FOREIGN KEY (tbCliente_tbUsuario_IdUsuario) REFERENCES tbUsuario(IdUsuario);
ALTER TABLE tbDetalleCotizacion
ADD FOREIGN KEY (tbProducto_SkuProducto) REFERENCES tbProducto(SkuProducto);

INSERT INTO tbUsuario (IdUsuario, NombreUsuario, Contrasena) VALUES (56789, 'Karen Leyt' ,'as12');
INSERT INTO tbUsuario (IdUsuario, NombreUsuario, Contrasena) VALUES (1313, 'Mitchies' ,'jUEGAuRF');
INSERT INTO tbUsuario (IdUsuario, NombreUsuario, Contrasena) VALUES (6969, 'Matias Vergas' ,'pelandoc');