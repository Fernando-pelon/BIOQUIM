select *from Rutas;
select *from RutaDeEntrega;
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
