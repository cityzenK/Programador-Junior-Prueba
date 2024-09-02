/*Creamos nuestras tablas*/
CREATE TABLE clientes (
	clienteID INT PRIMARY KEY IDENTITY(1,1),
	Nombre VARCHAR(100),
	Email VARCHAR(100),
);

CREATE TABLE Ordenes(
	OrdenID INT PRIMARY KEY IDENTITY(1,1),
	ClienteID INT,
	FechaOrden DATE,
	Total DECIMAL(10,2)
);
/*Creamos una foranea en la tabla Ordenes*/
ALTER TABLE ORDENES ADD CONSTRAINT FK_ClienteOrdenes FOREIGN KEY (ClienteID) REFERENCES clientes(ClienteID);

/*Llenamos la tablas con ejemplos*/
INSERT INTO CLIENTES(Nombre, Email) VALUES('Mario Argeta','MArgeta@mail.com');
INSERT INTO CLIENTES(Nombre, Email) VALUES('Sofia Castillos','SCastillos@mail.com');
INSERT INTO CLIENTES(Nombre, Email) VALUES('Ruben Montes','RMontes@mail.com');
INSERT INTO CLIENTES(Nombre, Email) VALUES('Clara Aguilas','CAgilar@mail.com');
INSERT INTO CLIENTES(Nombre, Email) VALUES('Santiago Sempere','SSempere@mail.com');

INSERT INTO Ordenes(ClienteID, FechaOrden, Total) VALUES (1, CURRENT_TIMESTAMP, 135.50);
INSERT INTO Ordenes(ClienteID, FechaOrden, Total) VALUES (1, CURRENT_TIMESTAMP, 100.00);
INSERT INTO Ordenes(ClienteID, FechaOrden, Total) VALUES (1, CURRENT_TIMESTAMP, 185.00);
INSERT INTO Ordenes(ClienteID, FechaOrden, Total) VALUES (2, CURRENT_TIMESTAMP, 135.00);
INSERT INTO Ordenes(ClienteID, FechaOrden, Total) VALUES (2, CURRENT_TIMESTAMP, 411.50);
INSERT INTO Ordenes(ClienteID, FechaOrden, Total) VALUES (3, CURRENT_TIMESTAMP, 120.00);
INSERT INTO Ordenes(ClienteID, FechaOrden, Total) VALUES (4, CURRENT_TIMESTAMP, 200.75);
INSERT INTO Ordenes(ClienteID, FechaOrden, Total) VALUES (4, CURRENT_TIMESTAMP, 50.40);
INSERT INTO Ordenes(ClienteID, FechaOrden, Total) VALUES (5, CURRENT_TIMESTAMP, 333.33);
