# LabEvaluacion

INSERT INTO Products(Name, Price) VALUES
('iPhone', 999.99),
('Coca-Cola', 1.99),
('Post-it', 0.99),
('Nutella', 4.99),
('Kleenex', 2.49),
('Nespresso', 199.99),
('Lego', 49.99),
('Adidas', 79.99),
('PlayStation', 499.99),
('Kindle', 89.99);


INSERT INTO Customers(fullname) VALUES ('Sofía García');
INSERT INTO Customers (fullname) VALUES ('Juan Martínez');
INSERT INTO Customers (fullname) VALUES ('María Rodríguez');
INSERT INTO Customers (fullname) VALUES ('Pedro Sánchez');
INSERT INTO Customers (fullname) VALUES ('Ana Pérez');
INSERT INTO Customers (fullname) VALUES ('Luis González');
INSERT INTO Customers (fullname) VALUES ('Carla Fernández');
INSERT INTO Customers (fullname) VALUES ('Jorge López');
INSERT INTO Customers (fullname) VALUES ('Lucía Díaz');
INSERT INTO Customers (fullname) VALUES ('Diego Gómez');

INSERT INTO Details (price, amount, productID,InvoiceID ) VALUES (15, 2, 1,1);
INSERT INTO Details (price, amount, productID,InvoiceID) VALUES (20, 1, 2,2);
INSERT INTO Details (price, amount, productID,InvoiceID) VALUES (10, 3, 3,3);
INSERT INTO Details (price, amount, productID,InvoiceID) VALUES (5, 4, 4,4);
INSERT INTO Details (price, amount, productID,InvoiceID) VALUES (12, 2, 5,4);
INSERT INTO Details (price, amount, productID,InvoiceID) VALUES (8, 1, 6,5);
INSERT INTO Details (price, amount, productID,InvoiceID) VALUES (18, 3, 7,6);
INSERT INTO Details (price, amount, productID,InvoiceID) VALUES (9, 2, 8,7);
INSERT INTO Details (price, amount, productID,InvoiceID) VALUES (14, 1, 9,8);
INSERT INTO Details (price, amount, productID,InvoiceID) VALUES (7, 4, 10,8);


INSERT INTO invoices (CustomerId, CreatedOn, numberinvoice) VALUES (1, '2022-01-01', 1001);
INSERT INTO invoices (CustomerId, CreatedOn, numberinvoice) VALUES (2, '2022-01-02', 1002);
INSERT INTO invoices (CustomerId, CreatedOn, numberinvoice) VALUES (3, '2022-01-03', 1003);
INSERT INTO invoices (CustomerId, CreatedOn, numberinvoice) VALUES (4, '2022-01-04', 1004);
INSERT INTO invoices (CustomerId, CreatedOn, numberinvoice) VALUES (5, '2022-01-05', 1005);
INSERT INTO invoices (CustomerId, CreatedOn, numberinvoice) VALUES (6, '2022-01-06', 1006);
INSERT INTO invoices (CustomerId, CreatedOn, numberinvoice) VALUES (7, '2022-01-07', 1007);
INSERT INTO invoices (CustomerId, CreatedOn, numberinvoice) VALUES (8, '2022-01-08', 1008);
INSERT INTO invoices (CustomerId, CreatedOn, numberinvoice) VALUES (9, '2022-01-09', 1009);
INSERT INTO invoices (CustomerId, CreatedOn, numberinvoice) VALUES (10, '2022-01-10', 1010);

