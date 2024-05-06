CREATE DATABASE bd_modelorama;

CREATE TABLE empleado
(
  Curp VARCHAR(20) PRIMARY KEY,
  Edad INT NOT NULL,
  Puesto ENUM('SuperAdmin','Administrador', 'Cajero') NOT NULL,
  Nombre VARCHAR(50) NOT NULL,
  Contraseña VARCHAR(10) NOT NULL,
  Estatus ENUM('Activo', 'Inactivo') NOT NULL
);

CREATE TABLE logEmpleado
(
  ID INT AUTO_INCREMENT PRIMARY KEY,
  Curp_empleado VARCHAR(15) NOT NULL,
  Fecha_entrada DATETIME NOT NULL,
  Fecha_salida DATETIME NOT NULL,
  CONSTRAINT FOREIGN KEY (Curp_empleado) REFERENCES empleado (Curp)
);

CREATE TABLE cliente
(
  Dni VARCHAR(15) PRIMARY KEY,
  Nombre VARCHAR(80) NOT NULL,
  Fecha_nacimiento VARCHAR(10) NOT NULL,
  Direccion VARCHAR(100) NOT NULL,
  Estatus ENUM('Activo', 'Inactivo') NOT NULL
);

CREATE TABLE productos
(
  Codigo VARCHAR(15) PRIMARY KEY,
  Nombre VARCHAR(50) NOT NULL,
  Precio DOUBLE DEFAULT 0 NOT NULL,
  Precio_venta DOUBLE DEFAULT 0 NOT NULL,
  Stock INT DEFAULT 0 NOT NULL,
  Estatus ENUM('Activo', 'Inactivo') NOT NULL
);

CREATE TABLE proveedor
(
  ID VARCHAR(15) PRIMARY KEY,
  Nombre VARCHAR(80) NOT NULL,
  Direccion VARCHAR(100) NOT NULL
  Estatus ENUM('Activo', 'Inactivo') NOT NULL
);

CREATE TABLE venta 
(
  Codigo_venta VARCHAR(15) PRIMARY KEY,
  Fecha DATETIME NOT NULL,
  Curp_empleado VARCHAR(20) NOT NULL,
  Dni_cliente VARCHAR(15) NOT NULL,
  Monto_final doubel DEFAULT 0 NOT NULL,
  CONSTRAINT FOREIGN KEY (Curp_empleado) REFERENCES empleado (Curp),
  CONSTRAINT FOREIGN KEY (Dni_cliente) REFERENCES cliente (Dni)
);

CREATE TABLE aparece
(
  Codigo_venta VARCHAR(15) NOT NULL,
  Codigo_producto VARCHAR(15) NOT NULL,
  Nombre VARCHAR(100) NOT NULL,
  Cantidad INT DEFAULT 0 NOT NULL,
  Precio DOUBLE DEFAULT 0 NOT NULL,
  Monto DOUBLE DEFAULT 0 NOT NULL,
  CONSTRAINT FOREIGN KEY (Codigo_venta) REFERENCES venta (Codigo_venta),
  CONSTRAINT FOREIGN KEY (Codigo_producto) REFERENCES productos (Codigo)
);

CREATE TABLE compras
(
  Codigo VARCHAR(10) PRIMARY KEY,
  Id_proveedor VARCHAR(15) NOT NULL,
  Fecha DATETIME NOT NULL,
  Monto_Compra DOUBLE DEFAULT 0 NOT NULL,
  CONSTRAINT FOREIGN KEY (Id_proveedor) REFERENCES proveedor (ID)
);

CREATE TABLE tiene
(
  Codigo_compra VARCHAR(10) NOT NULL,
  Codigo_producto VARCHAR(15) NOT NULL,
  Nombre VARCHAR(50) NOT NULL,
  Cantidad INT DEFAULT 0 NOT NULL,
  Precio_compra DOUBLE DEFAULT 0 NOT NULL,
  Monto_compra DOUBLE DEFAULT 0 NOT NULL,
  CONSTRAINT FOREIGN KEY (Codigo_compra) REFERENCES compras (Codigo)
);

CREATE TABLE corte
(
  ID CHAR(10) PRIMARY KEY,
  Curp_empleado VARCHAR(15) NOT NULL,
  Fecha DATETIME NOT NULL,
  Ventas INT DEFAULT 0,
  Total_ventas DOUBLE DEFAULT 0,
  CONSTRAINT FOREIGN KEY (Curp_empleado) REFERENCES empleado (Curp)
);

-- PROCEDIMIENTOS ALMACENADOS
CREATE PROCEDURE AddEmpleado (pcurp VARCHAR(20), pedad INT, ppuesto ENUM('SuperAdmin','Administrador','Cajero'), pnombre VARCHAR(50), pcontraseña VARCHAR(10))
BEGIN
  DECLARE pestatus VARCHAR(15);
  SET pestatus = 'Activo';
  INSERT INTO empleado VALUES (pcurp, pedad, ppuesto, pnombre, pcontraseña, pestatus);
END$$

CREATE PROCEDURE DeleteEmpleado (pcurp VARCHAR(20), pestatus ENUM('Activo', 'Inactivo'))
BEGIN
  UPDATE empleado SET Estatus = pestatus WHERE Curp = pcurp;
END$$

CREATE PROCEDURE EditaEmpleado (pcurp VARCHAR(20), pedad INT, ppuesto ENUM('SuperAdmin','Administrador', 'Cajero'), pnombre VARCHAR(50), pcontraseña VARCHAR(10))
BEGIN
  UPDATE empleado SET Edad = pedad, Puesto = ppuesto, Nombre=pnombre, Contraseña = pcontraseña WHERE Curp = pcurp;
END$$

CREATE PROCEDURE ConsultaEmpleado (pcurp VARCHAR(20))
BEGIN
  SELECT * FROM empleado WHERE Curp = pcurp;
END$$

-- Procedimientos almacenados para clientes
CREATE PROCEDURE AddCliente (pdni VARCHAR(15), pnombre VARCHAR(80), pnacimiento VARCHAR(10), pdireccion VARCHAR(100))
BEGIN
  DECLARE estatus VARCHAR(15);
  SET estatus = 'Activo';
  INSERT INTO cliente VALUES (pdni, pnombre, pnacimiento, pdireccion, estatus);
END$$

CREATE PROCEDURE DeleteCliente (pdni VARCHAR(15), pestatus ENUM('Activo', 'Inactivo'))
BEGIN
  UPDATE cliente SET Estatus = pestatus WHERE Dni = pdni;
END$$

CREATE PROCEDURE EditaCliente (pdni VARCHAR(15), pnombre VARCHAR(80), pnacimiento VARCHAR(10), pdireccion VARCHAR(100))
BEGIN
  UPDATE cliente SET Nombre = pnombre, Fecha_nacimiento = pnacimiento, Direccion = pdireccion WHERE Dni = pdni;
END$$

CREATE PROCEDURE ConsultaCliente(_dni VARCHAR(15))
BEGIN
  SELECT * FROM cliente WHERE Dni = _dni; 
END$$

-- PROCEDIMIENTO ALMACENADOS PROVEEDOR
CREATE PROCEDURE AddProveedor (pid VARCHAR(15), pnombre VARCHAR(50), pdireccion VARCHAR(100))
BEGIN
  DECLARE estatus VARCHAR(15);
  SET estatus = 'Activo';
  INSERT INTO proveedor VALUES(pid, pnombre, pdireccion, estatus);
END$$

CREATE PROCEDURE DeleteProveedor (pid VARCHAR(15), pestatus ENUM('Activo', 'Inactivo'))
BEGIN
 UPDATE proveedor SET Estatus = pestatus WHERE ID = pid; 
END$$

CREATE PROCEDURE EditaProveedor (pid VARCHAR(15), pnombre VARCHAR(50), pdireccion VARCHAR(100))
BEGIN
  UPDATE proveedor SET Nombre = pnombre, Direccion = pdireccion WHERE ID = pid;
END$$

CREATE PROCEDURE ConsultaProveedor (_id VARCHAR(15))
BEGIN
 SELECT * FROM proveedor WHERE ID = _id;
END$$

-- PROCEDIMIENTOS ALMACENADOS COMPRAS
CREATE PROCEDURE AddCompra (codigo VARCHAR(10), id_proveedor VARCHAR(15), fecha DATETIME, monto DOUBLE)
BEGIN
  INSERT INTO compras VALUES(codigo, id_proveedor, fecha, monto);
END$$

--
-- PROCEDIMIENTOS ALMACENADOS TABLA TIENE
--

CREATE PROCEDURE AddTiene (_codigo_compra VARCHAR(10), _codigo_producto VARCHAR(15), _nombre VARCHAR(50), _precio_compra DOUBLE, _cantidad INT, _monto_compra DOUBLE)
BEGIN
  INSERT INTO tiene VALUES(_codigo_compra, _codigo_producto, _nombre, _cantidad, _precio_compra, _monto_compra);
END$$

--
-- PROCEDIMIENTOS ALMACENADOA PARA PRODUCTOS
--

CREATE PROCEDURE AddProductos (pcodigo VARCHAR(15), pnombre VARCHAR(50), pprecio DOUBLE, pprecio_venta DOUBLE, pstock INT)
BEGIN
  DECLARE estatus VARCHAR(15);
  SET estatus = 'Activo';
  INSERT INTO productos VALUES(pcodigo, pnombre, pprecio, pprecio_venta, pstock, estatus);
END$$

CREATE PROCEDURE DeleteProductos (pcodigo VARCHAR(15), pestatus ENUM('Activo', 'Inactivo'))
BEGIN
  UPDATE productos SET Estatus = pestatus WHERE Codigo = pcodigo;
END$$

CREATE PROCEDURE EditaProductos (pcodigo VARCHAR(15), pprecio_venta DOUBLE)
BEGIN
  UPDATE productos SET Precio_venta = pprecio_venta WHERE Codigo = pcodigo;
END$$

CREATE PROCEDURE ConsultaProductos (_codigo VARCHAR(15))
BEGIN
  SELECT * FROM productos WHERE Codigo = _codigo;
END$$

--
-- PROCEDIMIENTO ALMACENADOS APARECE
--

CREATE PROCEDURE AddAparece 
(_codigo_venta VARCHAR(15), _codigo_producto VARCHAR(15), _nombre VARCHAR(100),_cantidad INT, _precio DOUBLE)
BEGIN
  DECLARE monto DOUBLE;
  SELECT CalcularMonto(_cantidad, _precio) INTO monto;
  INSERT INTO aparece VALUES(_codigo_venta, _codigo_producto, _nombre ,_cantidad, _precio, monto);
END$$

--
-- PROCEDIMIENTO ALMACENADO DE VENTA
--
CREATE PROCEDURE AddVenta (_codigo VARCHAR(15), _fecha DATETIME, _curp VARCHAR(20), _dni VARCHAR(15), _monto DOUBLE)
BEGIN
  INSERT INTO venta VALUES(_codigo, _fecha, _curp, _dni, _monto);
END$$

-- PROCEDIMIENTOS ALMACENADOS DE CORTE
CREATE PROCEDURE AddCorte (_id CHAR(10), _curp VARCHAR(15), _fecha DATETIME, _ventas INT, _total DOUBLE)
BEGIN
  INSERT INTO corte VALUES(_id, _curp, _fecha, _ventas, _total);
END$$

-- PROCEDIMIENTO ALMACENADO PARA LOG
CREATE PROCEDURE AddLOG (_curp VARCHAR(15), _fecha_i DATETIME, _fecha_s DATETIME)
BEGIN
  INSERT INTO logempleado VALUES (NULL, _curp, _fecha_i, _fecha_s);
END$$

--
-- PROCEDIMIENTOS ALMACENADOS PARA CARGAR LA LISTA DE COMPRAS
--

CREATE PROCEDURE ListaEntradas()
BEGIN
  SELECT compras.*, tiene.Codigo_producto, tiene.Nombre, tiene.Cantidad, tiene.Precio_compra, tiene.Monto_compra FROM compras, tiene WHERE compras.Codigo = tiene.Codigo_compra;
END$$

-- PROCEDIMIENTO ALMACENADO PARA EL LOGIN
CREATE PROCEDURE LOGIN (pnombre VARCHAR(15), pcontraseña VARCHAR(10))
BEGIN
  SELECT * FROM empleado WHERE Nombre = pnombre AND Contraseña = pcontraseña;
END$$


-- FUNCIONES
CREATE FUNCTION CalcularMonto (cantidad INT, precio DOUBLE)
RETURNS DOUBLE
BEGIN
  RETURN cantidad * precio;
END$$

-- TRIGGER
CREATE TRIGGER ActualizarStock AFTER INSERT ON aparece 
FOR EACH ROW 
BEGIN
  DECLARE stockt INT;
  SET stockt = (SELECT Stock FROM productos WHERE Codigo = NEW.Codigo_producto) - NEW.Cantidad;
  if (stockt >= 0) then
  UPDATE productos SET Stock = stockt WHERE Codigo = NEW.Codigo_producto; 
  END if;
END$$
