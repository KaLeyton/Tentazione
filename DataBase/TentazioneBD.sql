--DROP TABLE tbVenta ;
--DROP TABLE tbCliente ;
--DROP TABLE tbEmpleado ;
--DROP TABLE tbCotizacion ;
--DROP TABLE tbUsuario ;
--DROP TABLE tbDetalleVenta ;
--DROP TABLE tbProductoExtendido ;
--DROP TABLE tbDetalleCotizacion ;
--DROP TABLE tbProducto ;
--DROP TABLE tbSesion;

create table tbUsuario(IdUsuario int identity(1,1) not null,
					   NombreUsuario varchar(20) unique not null,
					   Contrasena varchar(15) not null,
					   Rol varchar(10) not null);

create table tbCliente(NombreCompleto varchar(50),
					   Edad int,
					   Telefono int,
					   Email varchar(100),
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
							tbProductoExtendido_CodBarra int not null);

create table tbProductoExtendido(CodBarra int identity(111111,1) not null,
								 FechaElaboracion date not null,
								 FechaVencimiento date not null,
								 Stock int not null,
								 tbProducto_SkuProducto int not null);

create table tbDetalleCotizacion(IdDetalleCotizacion int not null,
								 UnidadesProducto decimal not null,
								 tbProducto_SkuProducto int not null);

create table tbProducto(SkuProducto int identity(1111,1) not null,
					    NombreProducto varchar(50) not null,
					    Valor int not null,
						CantPaquete decimal not null,
					    UnidadMedida varchar(15) not null);

create table tbSesion (id int not null, 
					   Sesion varchar(10) not null);

ALTER TABLE tbUsuario ADD PRIMARY KEY (IdUsuario);
ALTER TABLE tbVenta ADD PRIMARY KEY (IdVenta);
ALTER TABLE tbDetalleVenta ADD PRIMARY KEY (IdDetalleVenta);
ALTER TABLE tbCotizacion ADD PRIMARY KEY (IdCotizacion);
ALTER TABLE tbProductoExtendido ADD PRIMARY KEY (CodBarra);
ALTER TABLE tbDetalleCotizacion ADD PRIMARY KEY (IdDetalleCotizacion);
ALTER TABLE tbProducto ADD PRIMARY KEY (SkuProducto);
ALTER TABLE tbCliente ADD PRIMARY KEY (tbUsuario_IdUsuario);
ALTER TABLE tbEmpleado ADD PRIMARY KEY (tbUsuario_IdUsuario);
ALTER TABLE tbSesion ADD PRIMARY KEY (id);

ALTER TABLE tbDetalleVenta
ADD FOREIGN KEY (tbProductoExtendido_CodBarra) REFERENCES tbProductoExtendido(CodBarra); 
ALTER TABLE tbEmpleado
ADD FOREIGN KEY (tbUsuario_IdUsuario) REFERENCES tbUsuario(IdUsuario);
ALTER TABLE tbCliente
ADD FOREIGN KEY (tbUsuario_IdUsuario) REFERENCES tbUsuario(IdUsuario);
ALTER TABLE tbProductoExtendido
ADD FOREIGN KEY (tbProducto_SkuProducto) REFERENCES tbProducto(SkuProducto) ON DELETE CASCADE; 
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

INSERT INTO tbUsuario (NombreUsuario, Contrasena, Rol) VALUES ('Karen', 'marmota','Empleado');
INSERT INTO tbUsuario (NombreUsuario, Contrasena, Rol) VALUES ('Empleado1', 'Emp1', 'Empleado');
INSERT INTO tbUsuario (NombreUsuario, Contrasena, Rol) VALUES ('Empleado2', 'Emp2', 'Empleado');

INSERT INTO tbUsuario (NombreUsuario, Contrasena, Rol) VALUES ('Cliente1', 'Cli1', 'Cliente');
INSERT INTO tbUsuario (NombreUsuario, Contrasena, Rol) VALUES ('Cliente2', 'Cli2', 'Cliente');
INSERT INTO tbUsuario (NombreUsuario, Contrasena, Rol) VALUES ('Cliente3', 'Cli3', 'Cliente');
INSERT INTO tbUsuario (NombreUsuario, Contrasena, Rol) VALUES ('Cliente4', 'Cli4', 'Cliente');
INSERT INTO tbUsuario (NombreUsuario, Contrasena, Rol) VALUES ('Chris', 'marmotita', 'Cliente');

INSERT INTO tbEmpleado (NombreCompleto, Edad, Telefono, Email, Sexo, tbUsuario_IdUsuario) VALUES ('Karen Leyton', 25, 987654321, 'kaleyton@ipy.xd', 'ninguno', 1);
INSERT INTO tbEmpleado (NombreCompleto, Edad, Telefono, Email, Sexo, tbUsuario_IdUsuario) VALUES ('Juan Perez', 45, 965874123, 'juaperez@ipy.xd', 'fem', 2);
INSERT INTO tbEmpleado (NombreCompleto, Edad, Telefono, Email, Sexo, tbUsuario_IdUsuario) VALUES ('Rodrigo Rodriguez', 32, 857496321, 'rodrodriguez@ipy.xd', 'masc', 3);

INSERT INTO tbCliente (NombreCompleto, Edad, Telefono, Email, Sexo, tbUsuario_IdUsuario) VALUES ('Fernando Fernandez', 29, 753198426, 'ferfernandez@ipy.xd', 'fem', 4);
INSERT INTO tbCliente (NombreCompleto, Edad, Telefono, Email, Sexo, tbUsuario_IdUsuario) VALUES ('Gonzalo Gonzalez', 47, 724865193, 'gongonzalez@ipy.xd', 'masc', 5);
INSERT INTO tbCliente (NombreCompleto, Edad, Telefono, Email, Sexo, tbUsuario_IdUsuario) VALUES ('Martin Martinez', 34, 764325891, 'marmartinez@ipy.xd', 'ninguno', 6);
INSERT INTO tbCliente (NombreCompleto, Edad, Telefono, Email, Sexo, tbUsuario_IdUsuario) VALUES ('Miguel Rojas', 23, 654987321, 'migrojas@ipy.xd', 'fem', 7);
INSERT INTO tbCliente (NombreCompleto, Edad, Telefono, Email, Sexo, tbUsuario_IdUsuario) VALUES ('Christian Villarroel', 26, 741852963, 'chrvillaroel@ipy.xd', 'masc', 8);

INSERT INTO tbSesion (id, Sesion) VALUES (0, '0');

INSERT INTO tbProducto (NombreProducto, Valor, CantPaquete, UnidadMedida) VALUES ('Doblon', 2500, 30,'Unidades');
INSERT INTO tbProducto (NombreProducto, Valor, CantPaquete, UnidadMedida) VALUES ('Galletas Sabor Coco', 2500, 800,'Gramos');
INSERT INTO tbProducto (NombreProducto, Valor, CantPaquete, UnidadMedida) VALUES ('Galletas Zoologico', 2500, 800,'Gramos');
INSERT INTO tbProducto (NombreProducto, Valor, CantPaquete, UnidadMedida) VALUES ('Galletas Vainilla Fruna', 2000, 850,'Gramos');
INSERT INTO tbProducto (NombreProducto, Valor, CantPaquete, UnidadMedida) VALUES ('Tableton', 2000, 650,'Gramos');
INSERT INTO tbProducto (NombreProducto, Valor, CantPaquete, UnidadMedida) VALUES ('Chocolates Verona', 2000, 680,'Gramos');
INSERT INTO tbProducto (NombreProducto, Valor, CantPaquete, UnidadMedida) VALUES ('Gansito', 3500, 10,'Unidades');
INSERT INTO tbProducto (NombreProducto, Valor, CantPaquete, UnidadMedida) VALUES ('Rayita', 1500, 8,'Unidades');
INSERT INTO tbProducto (NombreProducto, Valor, CantPaquete, UnidadMedida) VALUES ('Sustancias', 2500, 20,'Unidades');
INSERT INTO tbProducto (NombreProducto, Valor, CantPaquete, UnidadMedida) VALUES ('Helados De Invierno', 2500, 20,'Unidades');
INSERT INTO tbProducto (NombreProducto, Valor, CantPaquete, UnidadMedida) VALUES ('Cubanito', 5000, 1200,'Gramos');
INSERT INTO tbProducto (NombreProducto, Valor, CantPaquete, UnidadMedida) VALUES ('Alfajor Premium', 3500, 12,'Unidades');
INSERT INTO tbProducto (NombreProducto, Valor, CantPaquete, UnidadMedida) VALUES ('Rolls Nuts', 3500, 30,'Unidades');
INSERT INTO tbProducto (NombreProducto, Valor, CantPaquete, UnidadMedida) VALUES ('Bon o bon', 4000, 30,'Unidades');
INSERT INTO tbProducto (NombreProducto, Valor, CantPaquete, UnidadMedida) VALUES ('Galletas Oreo', 600, 1,'Unidades');

INSERT INTO tbProductoExtendido (FechaElaboracion, FechaVencimiento, Stock, tbProducto_SkuProducto) VALUES ('2020-01-25', '2020-08-25', 100, 1111);
INSERT INTO tbProductoExtendido (FechaElaboracion, FechaVencimiento, Stock, tbProducto_SkuProducto) VALUES ('2020-03-12', '2020-10-12', 200, 1111);
INSERT INTO tbProductoExtendido (FechaElaboracion, FechaVencimiento, Stock, tbProducto_SkuProducto) VALUES ('2020-06-22', '2021-01-22', 300, 1111);
INSERT INTO tbProductoExtendido (FechaElaboracion, FechaVencimiento, Stock, tbProducto_SkuProducto) VALUES ('2020-01-25', '2020-08-25', 100, 1112);
INSERT INTO tbProductoExtendido (FechaElaboracion, FechaVencimiento, Stock, tbProducto_SkuProducto) VALUES ('2020-03-12', '2020-10-12', 200, 1112);
INSERT INTO tbProductoExtendido (FechaElaboracion, FechaVencimiento, Stock, tbProducto_SkuProducto) VALUES ('2020-06-22', '2021-01-22', 300, 1112);
INSERT INTO tbProductoExtendido (FechaElaboracion, FechaVencimiento, Stock, tbProducto_SkuProducto) VALUES ('2020-01-25', '2020-08-25', 100, 1113);
INSERT INTO tbProductoExtendido (FechaElaboracion, FechaVencimiento, Stock, tbProducto_SkuProducto) VALUES ('2020-03-12', '2020-10-12', 200, 1113);
INSERT INTO tbProductoExtendido (FechaElaboracion, FechaVencimiento, Stock, tbProducto_SkuProducto) VALUES ('2020-06-22', '2021-01-22', 300, 1113);
INSERT INTO tbProductoExtendido (FechaElaboracion, FechaVencimiento, Stock, tbProducto_SkuProducto) VALUES ('2020-01-25', '2020-08-25', 100, 1114);
INSERT INTO tbProductoExtendido (FechaElaboracion, FechaVencimiento, Stock, tbProducto_SkuProducto) VALUES ('2020-03-12', '2020-10-12', 200, 1114);
INSERT INTO tbProductoExtendido (FechaElaboracion, FechaVencimiento, Stock, tbProducto_SkuProducto) VALUES ('2020-06-22', '2021-01-22', 300, 1114);
INSERT INTO tbProductoExtendido (FechaElaboracion, FechaVencimiento, Stock, tbProducto_SkuProducto) VALUES ('2020-01-25', '2020-08-25', 100, 1115);
INSERT INTO tbProductoExtendido (FechaElaboracion, FechaVencimiento, Stock, tbProducto_SkuProducto) VALUES ('2020-03-12', '2020-10-12', 200, 1115);
INSERT INTO tbProductoExtendido (FechaElaboracion, FechaVencimiento, Stock, tbProducto_SkuProducto) VALUES ('2020-06-22', '2021-01-22', 300, 1115);
INSERT INTO tbProductoExtendido (FechaElaboracion, FechaVencimiento, Stock, tbProducto_SkuProducto) VALUES ('2020-01-25', '2020-08-25', 100, 1116);
INSERT INTO tbProductoExtendido (FechaElaboracion, FechaVencimiento, Stock, tbProducto_SkuProducto) VALUES ('2020-03-12', '2020-10-12', 200, 1116);
INSERT INTO tbProductoExtendido (FechaElaboracion, FechaVencimiento, Stock, tbProducto_SkuProducto) VALUES ('2020-06-22', '2021-01-22', 300, 1116);
INSERT INTO tbProductoExtendido (FechaElaboracion, FechaVencimiento, Stock, tbProducto_SkuProducto) VALUES ('2020-01-25', '2020-08-25', 100, 1117);
INSERT INTO tbProductoExtendido (FechaElaboracion, FechaVencimiento, Stock, tbProducto_SkuProducto) VALUES ('2020-03-12', '2020-10-12', 200, 1117);
INSERT INTO tbProductoExtendido (FechaElaboracion, FechaVencimiento, Stock, tbProducto_SkuProducto) VALUES ('2020-06-22', '2021-01-22', 300, 1117);
INSERT INTO tbProductoExtendido (FechaElaboracion, FechaVencimiento, Stock, tbProducto_SkuProducto) VALUES ('2020-01-25', '2020-08-25', 100, 1118);
INSERT INTO tbProductoExtendido (FechaElaboracion, FechaVencimiento, Stock, tbProducto_SkuProducto) VALUES ('2020-03-12', '2020-10-12', 200, 1118);
INSERT INTO tbProductoExtendido (FechaElaboracion, FechaVencimiento, Stock, tbProducto_SkuProducto) VALUES ('2020-06-22', '2021-01-22', 300, 1118);
INSERT INTO tbProductoExtendido (FechaElaboracion, FechaVencimiento, Stock, tbProducto_SkuProducto) VALUES ('2020-01-25', '2020-08-25', 100, 1119);
INSERT INTO tbProductoExtendido (FechaElaboracion, FechaVencimiento, Stock, tbProducto_SkuProducto) VALUES ('2020-03-12', '2020-10-12', 200, 1119);
INSERT INTO tbProductoExtendido (FechaElaboracion, FechaVencimiento, Stock, tbProducto_SkuProducto) VALUES ('2020-06-22', '2021-01-22', 300, 1119);
INSERT INTO tbProductoExtendido (FechaElaboracion, FechaVencimiento, Stock, tbProducto_SkuProducto) VALUES ('2020-01-25', '2020-08-25', 100, 1120);
INSERT INTO tbProductoExtendido (FechaElaboracion, FechaVencimiento, Stock, tbProducto_SkuProducto) VALUES ('2020-03-12', '2020-10-12', 200, 1120);
INSERT INTO tbProductoExtendido (FechaElaboracion, FechaVencimiento, Stock, tbProducto_SkuProducto) VALUES ('2020-06-22', '2021-01-22', 300, 1120);
INSERT INTO tbProductoExtendido (FechaElaboracion, FechaVencimiento, Stock, tbProducto_SkuProducto) VALUES ('2020-01-25', '2020-08-25', 100, 1121);
INSERT INTO tbProductoExtendido (FechaElaboracion, FechaVencimiento, Stock, tbProducto_SkuProducto) VALUES ('2020-03-12', '2020-10-12', 200, 1121);
INSERT INTO tbProductoExtendido (FechaElaboracion, FechaVencimiento, Stock, tbProducto_SkuProducto) VALUES ('2020-06-22', '2021-01-22', 300, 1121);
INSERT INTO tbProductoExtendido (FechaElaboracion, FechaVencimiento, Stock, tbProducto_SkuProducto) VALUES ('2020-01-25', '2020-08-25', 100, 1122);
INSERT INTO tbProductoExtendido (FechaElaboracion, FechaVencimiento, Stock, tbProducto_SkuProducto) VALUES ('2020-03-12', '2020-10-12', 200, 1122);
INSERT INTO tbProductoExtendido (FechaElaboracion, FechaVencimiento, Stock, tbProducto_SkuProducto) VALUES ('2020-06-22', '2021-01-22', 300, 1122);
INSERT INTO tbProductoExtendido (FechaElaboracion, FechaVencimiento, Stock, tbProducto_SkuProducto) VALUES ('2020-01-25', '2020-08-25', 100, 1123);
INSERT INTO tbProductoExtendido (FechaElaboracion, FechaVencimiento, Stock, tbProducto_SkuProducto) VALUES ('2020-03-12', '2020-10-12', 200, 1123);
INSERT INTO tbProductoExtendido (FechaElaboracion, FechaVencimiento, Stock, tbProducto_SkuProducto) VALUES ('2020-06-22', '2021-01-22', 300, 1123);
INSERT INTO tbProductoExtendido (FechaElaboracion, FechaVencimiento, Stock, tbProducto_SkuProducto) VALUES ('2020-01-25', '2020-08-25', 100, 1124);
INSERT INTO tbProductoExtendido (FechaElaboracion, FechaVencimiento, Stock, tbProducto_SkuProducto) VALUES ('2020-03-12', '2020-10-12', 200, 1124);
INSERT INTO tbProductoExtendido (FechaElaboracion, FechaVencimiento, Stock, tbProducto_SkuProducto) VALUES ('2020-06-22', '2021-01-22', 300, 1124);
INSERT INTO tbProductoExtendido (FechaElaboracion, FechaVencimiento, Stock, tbProducto_SkuProducto) VALUES ('2020-01-25', '2020-08-25', 100, 1125);
INSERT INTO tbProductoExtendido (FechaElaboracion, FechaVencimiento, Stock, tbProducto_SkuProducto) VALUES ('2020-03-12', '2020-10-12', 200, 1125);
INSERT INTO tbProductoExtendido (FechaElaboracion, FechaVencimiento, Stock, tbProducto_SkuProducto) VALUES ('2020-06-22', '2021-01-22', 300, 1125);


select * from tbProducto join tbProductoExtendido on tbProducto.SkuProducto=tbProductoExtendido.tbProducto_SkuProducto;

