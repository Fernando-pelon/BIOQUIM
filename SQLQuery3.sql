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
    correoUsuario VARCHAR(100) unique,
    contrasenaUsuario VARCHAR(100) NOT NULL,
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

go
-- RutaDeEntrega 
CREATE TABLE RutaDeEntrega (
    idRutaEntrega INT IDENTITY(1,1) PRIMARY KEY,
    idProducto INT,
    montoPago DECIMAL(10,2) not null,
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
go
-- Proveedores
insert into Proveedores values
('Duisa'), ('Rquimica'), ('Dibarsa'), ('Unichemical'), ('HomeComfort');
go
-- Empresas
insert into Empresas(NombreEmpresa, correoEmpresa) values
('Hospital Nacional Rosales', 'compras@rosales.gob.sv'),
('Hospital San Juan de Dios', 'contacto@sanjuandios.gob.sv'),
('Hospital Nacional Zacamil', 'logistica@zacamil.gob.sv' ),
('Hospital de la Mujer', 'admin@mujer.gob.sv'),
('Hospital Bloom', 'servicios@bloom.gob.sv' );
go
-- TipoPago
insert into TipoPago(nombreTipoPago) values
('Efectivo'), ('Tarjeta de Crédito');
go
-- Pagos
insert into Pagos(montoPago, idEmpresa, idProducto, idTipoPago) values
(850.00, 1, 1, 1),
(13.50, 2, 2, 2),
(129.95, 3, 3, 1),
(15.00, 4, 4, 2),
(445.00, 5, 5, 1);
go
-- TipoUsuario
insert into TipoUsuario(nombreTipoUsuario) values
('Administrador'), ('Empleado'), ('Repartidor');
go
-- Departamento
insert into Departamento(nombreDepartamento) values
('Secretaria'), ('Repartidores'), ('Finanzas'), ('Recursos Humanos');
go
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
go

CREATE VIEW Rutas4 AS
SELECT 
    R.idRutaEntrega AS [N° Registro],
    P.nombreProducto,
    P.cantidadProducto,
    R.montoPago,
    E.nombreEmpresa,
    Ub.ubicacionEmpresa,
    T.nombreTipoPago
FROM RutaDeEntrega R
LEFT JOIN Ubicaciones Ub ON R.idUbicacion = Ub.idUbicacion
LEFT JOIN Producto P ON R.idProducto = P.idProducto
LEFT JOIN Empresas E ON R.idEmpresa = E.idEmpresa
LEFT JOIN TipoPago T ON R.idTipoPago = T.idTipoPago;

go
select *from UsuariosDGV
select * from RutaDeEntrega
select *from Departamento
select * from Producto
select *from Ubicaciones
select *from Usuario
select *from TipoUsuario

insert into RutaDeEntrega(idProducto,montoPago,idEmpresa,idTipoPago) values(1,20,2,1);
go
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
    go
    CREATE VIEW UsuariosDGV AS
SELECT
    U.idUsuario as Id,
    U.nombreUsuario AS Usuario,
    U.apellidoUsuario AS Apellido,
    U.correoUsuario AS Correo,
    U.contrasenaUsuario AS Contraseña,
    D.nombreDepartamento AS Departamento,
    T.nombreTipoUsuario AS TipoDeUsuario
FROM Usuario U
LEFT JOIN TipoUsuario T ON U.idTipoUsuario = T.idTipoUsuario
LEFT JOIN Departamento D ON U.idDepartamento = D.idDepartamento;
go 
CREATE VIEW Rutas AS
SELECT 
    P.NombreProducto,
    R.MontoPago,
    E.NombreEmpresa,
    Ub.UbicacionEmpresa,
    T.NombreTipoPago
FROM RutaDeEntrega R
LEFT JOIN Ubicaciones Ub ON R.idUbicacion = Ub.idUbicacion
LEFT JOIN Producto P ON R.idProducto = P.idProducto
LEFT JOIN Empresas E ON R.idEmpresa = E.idEmpresa
LEFT JOIN TipoPago T ON R.idTipoPago = T.idTipoPago;

  delete from Usuario where idUsuario= 3