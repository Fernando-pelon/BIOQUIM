go
create database BIOQUIM_PTC
go
use BIOQUIM_PTC
go 

-- CategoriaProducto
CREATE TABLE CategoriaProducto (
    idCategoriaProduc INT IDENTITY(1,1) PRIMARY KEY,
    nombreCategoriaProducto VARCHAR(50)
);
go

-- Proveedores
CREATE TABLE Proveedores (
    idProveedor INT IDENTITY(1,1) PRIMARY KEY,
    nombreProveedor VARCHAR(50)
);
go

-- Producto
CREATE TABLE Producto (
    idProducto INT IDENTITY(1,1) PRIMARY KEY,
    nombreProducto VARCHAR(50),
    costoProducto FLOAT,
    cantidadProducto FLOAT,
    idCategoriaProduc INT,
    idProveedor int,
    CONSTRAINT FK_CatePoduc FOREIGN KEY (idCategoriaProduc) REFERENCES CategoriaProducto(idCategoriaProduc) ON DELETE CASCADE,
    CONSTRAINT FK_Proveedor FOREIGN KEY (idProveedor) REFERENCES Proveedores(idProveedor) ON DELETE  CASCADE );
    go

-- Empresas
CREATE TABLE Empresas (
    idEmpresa INT IDENTITY(1,1) PRIMARY KEY,
    NombreEmpresa VARCHAR(50),
    correoEmpresa VARCHAR(50),
);
go

-- TipoPago
CREATE TABLE TipoPago (
    idTipoPago INT IDENTITY(1,1) PRIMARY KEY,
    nombreTipoPago VARCHAR(50)
);
go

-- Pagos
CREATE TABLE Pagos (
    idPago INT IDENTITY(1,1) PRIMARY KEY,
    montoPago FLOAT,
    idEmpresa INT,
    idProducto INT,
    idTipoPago INT,
    CONSTRAINT FK_Empresas FOREIGN KEY (idEmpresa) REFERENCES Empresas(idEmpresa) ON DELETE CASCADE,
    CONSTRAINT FK_Produc FOREIGN KEY (idProducto) REFERENCES Producto(idProducto) ON DELETE CASCADE,
    CONSTRAINT FK_TipoPago FOREIGN KEY (idTipoPago) REFERENCES TipoPago(idTipoPago) ON DELETE CASCADE
);
go

-- Pedidos
CREATE TABLE Pedidos (
    idPedidos INT IDENTITY(1,1) PRIMARY KEY,
    cantidadProducto FLOAT,
    DireccionEntrega VARCHAR(100),
    id_Empresa INT,
    id_Producto INT,
    fecha DATE,
    idPago INT,
    CONSTRAINT FK_Empre FOREIGN KEY (id_Empresa) REFERENCES Empresas(idEmpresa) ON DELETE CASCADE,
    CONSTRAINT FK_Producto FOREIGN KEY (id_Producto) REFERENCES Producto(idProducto) ON DELETE CASCADE,
    CONSTRAINT FK_Pagos FOREIGN KEY (idPago) REFERENCES Pagos(idPago)
);

-- TipoUsuario
CREATE TABLE TipoUsuario (
    idTipoUsuario INT IDENTITY(1,1) PRIMARY KEY,
    nombreTipoUsuario VARCHAR(50)
);
go

-- Departamento
CREATE TABLE Departamento (
    idDepartamento INT IDENTITY(1,1) PRIMARY KEY,
    nombreDepartamento VARCHAR(50)
);
go


-- Usuario
CREATE TABLE Usuario (
    idUsuario INT IDENTITY(1,1) PRIMARY KEY,
    nombreUsuario VARCHAR(50) NOT NULL,
    apellidoUsuario VARCHAR(50) NOT NULL,
    correoUsuario VARCHAR(50),
    contrasenaUsuario VARCHAR(50) NOT NULL,
    idTipoUsuario INT,
    idDepartamento INT,
    CONSTRAINT FK_TipoUser FOREIGN KEY (idTipoUsuario)
        REFERENCES TipoUsuario(idTipoUsuario)
        ON DELETE CASCADE,
    CONSTRAINT FK_Departamento FOREIGN KEY (idDepartamento)
        REFERENCES Departamento(idDepartamento)
        ON DELETE CASCADE
);
go

CREATE TABLE Ubicaciones
(
idUbicacion int identity(1,1) primary key,
UbicacionEmpresa varchar(100)
);


-- RutaDeEntrega 
CREATE TABLE RutaDeEntrega (
    idRutaEntrega INT IDENTITY(1,1) PRIMARY KEY,
    idProducto INT,
    montoPago DECIMAL(10,2),
    idEmpresa INT,
    idTipoPago INT,
    idUbicacion int,
    idUsuario INT,
    CONSTRAINT FK_Product FOREIGN KEY (idProducto)REFERENCES Producto(idProducto) ON DELETE CASCADE,
    CONSTRAINT FK_Empresa FOREIGN KEY (idEmpresa) REFERENCES Empresas(idEmpresa) ON DELETE CASCADE,
    CONSTRAINT FK_TipoPagos FOREIGN KEY (idTipoPago)REFERENCES TipoPago(idTipoPago) ON DELETE CASCADE,
    CONSTRAINT FK_Ubicacion FOREIGN KEY (idUbicacion) REFERENCES Ubicaciones(idUbicacion) ON DELETE CASCADE,
    CONSTRAINT FK_Ruta_Usuario FOREIGN KEY (idUsuario)REFERENCES Usuario(idUsuario) 
);
go

-- CategoriaProducto
insert into CategoriaProducto(nombreCategoriaProducto) values
('detergentes'), ('blanqueadores'), ('suavizantes'), ('desinfectantes'), ('neutralizantes');

-- Proveedores
insert into Proveedores values
('Duisa'), ('Rquimica'), ('Dibarsa'), ('Unichemical'), ('HomeComfort');

-- Producto
insert into Producto(nombreProducto, costoProducto, cantidadProducto, idCategoriaProduc, idProveedor) values
('Cloro', 45.00, 25, 4, 4),
('Secuestrante', 38.50, 40, 4, 4),
('Blanquedar Industrial', 22.75, 30, 4, 4),
('Desinfectante', 35.90, 15, 4, 4),
('Detergente industrial', 29.99, 20, 4, 4);

-- Empresas
insert into Empresas(NombreEmpresa, correoEmpresa) values
('Hospital Nacional Rosales', 'compras@rosales.gob.sv'),
('Hospital San Juan de Dios', 'contacto@sanjuandios.gob.sv'),
('Hospital Nacional Zacamil', 'logistica@zacamil.gob.sv' ),
('Hospital de la Mujer', 'admin@mujer.gob.sv'),
('Hospital Bloom', 'servicios@bloom.gob.sv' );

-- TipoPago
insert into TipoPago(nombreTipoPago) values
('Efectivo'), ('Tarjeta de Crédito');

-- Pagos
insert into Pagos(montoPago, idEmpresa, idProducto, idTipoPago) values
(850.00, 1, 1, 1),
(13.50, 2, 2, 2),
(129.95, 3, 3, 1),
(15.00, 4, 4, 2),
(445.00, 5, 5, 1);

-- Pedidos
insert into Pedidos(cantidadProducto, DireccionEntrega, id_Empresa, id_Producto, fecha, idPago) values
(10, 'Entrada de lavandería, sector B', 1, 1, '2025-07-20', 1),
(15, 'Zona de suministros, nivel 2', 2, 2, '2025-07-18', 2),
(12, 'Pasillo quirúrgico, recepción central', 3, 3, '2025-07-19', 3),
(8, 'Depósito de higiene, módulo C', 4, 4, '2025-07-21', 4),
(20, 'Edificio logístico, acceso 1', 5, 5, '2025-07-17', 5);

-- TipoUsuario
insert into TipoUsuario(nombreTipoUsuario) values
('Administrador'), ('Empleado'), ('Repartidor');

-- Departamento
insert into Departamento(nombreDepartamento) values
('Secretaria'), ('Repartidores'), ('Finanzas'), ('Recursos Humanos');

-- Usuario
insert into Usuario(nombreUsuario, apellidoUsuario, correoUsuario, contrasenaUsuario, idTipoUsuario, idDepartamento) values
('Carlos', 'Ramírez', 'c.ramirez@novacorp.com', 'c4rl0sR!', 1, 5),
('Sandra', 'Mejía', 's.mejia@elegantwear.com', 'S@ndr@M', 2, 1),
('Luis', 'Hernández', 'l.hernandez@freshfoods.com', 'Lu1sH_23', 3, 2),
('Andrea', 'Gómez', 'a.gomez@cleanhouse.com', 'Andre@G', 4, 3),
('María', 'Flores', 'm.flores@furnizone.com', 'Mar1aF!', 5, 4);

-- RutaDeEntrega
INSERT INTO RutaDeEntrega(idProducto, montoPago, idEmpresa, idTipoPago, idUbicacion)
VALUES
( 1, 850.00, 1, 2, 1),
( 2, 13.50, 2, 1, 2),
( 3, 129.95, 3, 2, 3),
( 4, 15.00, 3, 1, 4),
( 5, 445.00, 5, 2, 5);

--Ubicacion
INSERT INTO Ubicaciones(UbicacionEmpresa)
VALUES
('San Salvador'),
( 'Santa Ana'),
('Mejicanos'),
( 'San Miguel'),
('Soyapango')

select 
    p.nombreProducto,
    c.nombreCategoriaProducto,
    pr.nombreProveedor
from Producto p
inner join CategoriaProducto c on p.idCategoriaProduc = c.idCategoriaProduc
inner join Proveedores pr on p.idProveedor = pr.idProveedor;

select 
    e.NombreEmpresa,
    pr.nombreProducto,
    tp.nombreTipoPago,
    pa.montoPago
from Pagos pa
inner join Empresas e on pa.idEmpresa = e.idEmpresa
inner join Producto pr on pa.idProducto = pr.idProducto
inner join TipoPago tp on pa.idTipoPago = tp.idTipoPago;

select 
    pe.idPedidos,
    pe.fecha,
    e.NombreEmpresa,
    pr.nombreProducto,
    pa.montoPago
from Pedidos pe
inner join Empresas e on pe.id_Empresa = e.idEmpresa
inner join Producto pr on pe.id_Producto = pr.idProducto
inner join Pagos pa on pe.idPago = pa.idPago;

select 
    re.idRutaEntrega,
    Ub.ubicacionEmpresa,
    pr.nombreProducto,
    e.NombreEmpresa,
    tp.nombreTipoPago,
    u.nombreUsuario + ' ' + u.apellidoUsuario as repartidor
from RutaDeEntrega re
inner join
Producto pr on re.idProducto = pr.idProducto
inner join 
Empresas e on re.idEmpresa = e.idEmpresa
inner join
TipoPago tp on re.idTipoPago = tp.idTipoPago
inner join
Usuario u on re.idUsuario = u.idUsuario
inner join
Ubicaciones Ub on re.idUbicacion = Ub.idUbicacion
;


create view Rutas3 as 
SELECT 
    P.nombreProducto,
    P.cantidadProducto,
    R.montoPago,
    E.nombreEmpresa,
    Ub.ubicacionEmpresa,
    T.nombreTipoPago
FROM RutaDeEntrega R
left JOIN Ubicaciones Ub on R.idUbicacion = Ub.idUbicacion
left JOIN Producto Pr ON R.idProducto = Pr.cantidadProducto
left JOIN Producto P ON R.idProducto = P.idProducto
left JOIN Empresas E ON R.idEmpresa = E.idEmpresa
left JOIN TipoPago T ON R.idTipoPago = T.idTipoPago;



select *from Empresas
select * from RutaDeEntrega
select *from Departamento
select * from Producto
select *from Ubicaciones

insert into RutaDeEntrega(idProducto,montoPago,idEmpresa,idTipoPago) values(1,20,2,1);

create view inven as
SELECT 
    P.idProducto AS [N° Registro],
    P.nombreProducto AS [Nombre Producto],
    P.cantidadProducto AS [Cantidad],
    P.costoProducto AS [Precio]
FROM 
    Producto P
LEFT JOIN 
    CategoriaProducto C ON P.idCategoriaProduc = C.idCategoriaProduc
LEFT JOIN 
    Proveedores PR ON P.idProveedor = PR.idProveedor;