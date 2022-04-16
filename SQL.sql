CREATE TABLE Categories (
  CategoryId INTEGER,
  CatName TEXT NOT NULL,
  PRIMARY KEY (CategoryId)
);

INSERT INTO Categories VALUES ('1', 'cat1');
INSERT INTO Categories VALUES ('2', 'cat2');
INSERT INTO Categories VALUES ('3', 'cat3');

CREATE TABLE Products (
  Id INTEGER,
  Name TEXT NOT NULL,
  PRIMARY KEY (Id)
);

INSERT INTO Products VALUES ('1', 'prod1');
INSERT INTO Products VALUES ('2', 'prod2');
INSERT INTO Products VALUES ('3', 'prod3' );

CREATE TABLE CatProds (
  Id INTEGER auto_increment,
  CategoryId INTEGER,
  ProductId  INTEGER,
  FOREIGN KEY (CategoryId) REFERENCES Categories (CategoryId) ON DELETE CASCADE,
  FOREIGN KEY (ProductId) REFERENCES Products (Id) ON DELETE CASCADE,
  PRIMARY KEY (Id)
);

INSERT INTO CatProds VALUES (1, 1, 1);
INSERT INTO CatProds VALUES (2, 2, 1);
INSERT INTO CatProds VALUES (3, 2, 2);
INSERT INTO CatProds VALUES (4, NULL, 3);
INSERT INTO CatProds VALUES (5, 3, NULL);

SELECT Products.Name, Categories.CatName
FROM Products
INNER JOIN CatProds 
ON CatProds.ProductId = Products.Id 
INNER JOIN Categories
ON CatProds.CategoryId = Categories.CategoryId;

SELECT Products.Name
FROM CatProds
INNER JOIN Products
ON Products.Id = CatProds.ProductId
WHERE CatProds.CategoryId IS NULL;