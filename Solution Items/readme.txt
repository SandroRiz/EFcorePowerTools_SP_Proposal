if you already had the database add only

CREATE PROC GetDiscontinuedProducts
AS

-- only for sample
SELECT ProductID,
	   ProductName,
	   SupplierID,
	   CategoryID,
	   QuantityPerUnit,
	   UnitPrice,
	   UnitsInStock,
	   UnitsOnOrder,
	   ReorderLevel,
	   Discontinued 
FROM dbo.Products WHERE Discontinued = 1