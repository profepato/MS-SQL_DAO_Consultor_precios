CREATE DATABASE consultor_precios;
GO
USE consultor_precios;
GO

CREATE TABLE Producto(
	id CHAR(36),
	descripcion VARCHAR(100),
	precio INT,
	precioOferta VARCHAR(100),
	PRIMARY KEY(id)
);

INSERT INTO Producto VALUES(
	NEWID(), 
	'Cepillo Dento Plus mediano 2x1', 
	1399,
	'Sin Oferta'
);

SELECT * FROM Producto;

CREATE VIEW Productos AS
SELECT
	id AS 'ID',
	descripcion AS 'Descripción',
	precio AS 'Precio',
	precioOferta AS 'Precio Oferta'
FROM
	Producto;
	
SELECT * FROM Productos;

/*Drop database*/
USE master;
DROP DATABASE consultor_precios;
/*Drop database*/


/*DROP VIEW*/
DROP VIEW Productos;
/*DROP VIEW*/