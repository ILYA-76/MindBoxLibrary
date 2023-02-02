# C#
### Задание:

Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:

Юнит-тесты

Легкость добавления других фигур

Вычисление площади фигуры без знания типа фигуры в compile-time

Проверку на то, является ли треугольник прямоугольным 

# SQL
### Задание:

В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. 
Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.

### Создаем таблицы

CREATE TABLE Products(
id INT PRIMARY KEY IDENTITY, 
name VARCHAR(255) NOT NULL);

CREATE TABLE Category(
id INT PRIMARY KEY IDENTITY,
name VARCHAR(255) NOT NULL);

CREATE TABLE ProdCat(
products_id INT NOT NULL,
category_id INT NOT NULL,
FOREIGN KEY(products_id) REFERENCES Products(id) ON DELETE CASCADE,
FOREIGN KEY(category_id) REFERENCES Category(id) ON DELETE CASCADE);

CREATE UNIQUE INDEX product_category ON ProductCategory(products_id, category_id);

### Заполняем таблицы

INSERT INTO Products VALUES('Бумага'), ('Ножницы'), ('Ложка');
INSERT INTO Category VALUES('Канцелярия'), ('Столовые приборы');
INSERT INTO ProductCategory VALUES(1, 1), (2, 1), (3, 2);

### Запрос - решение

SELECT Product.name AS product, Category.name AS category FROM Products AS prod
LEFT JOIN ProductCategory AS prodCat ON prod.id = prodCat.products_id
INNER JOIN Category AS cat ON cat.id = prodCat.category_id
ORDER BY product;

