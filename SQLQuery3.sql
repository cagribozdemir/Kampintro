--Select
--ANSII
Select Contactname Adi,CompanyName Sirketadi,City Sehir from Customers

Select * from Customers where City = 'Berlin'

--case insensitive
select * from Products where CategoryID=1 or CategoryID=3

select * from Products where CategoryID=1 and UnitPrice>=10

select * from Products order by CategoryID,ProductName

select * from Products where CategoryID=1 order by UnitPrice desc --ascending(asc) --descending(desc)

select count(*) Adet from Products where CategoryID=2 --Ürün sayısı


select categoryId,count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10


select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName 
from Products inner join Categories 
on Products.CategoryID= Categories.CategoryID
where Products.UnitPrice>10

--DTO Data Transformation Object

select * from Products p inner join [Order Details] od
on p.ProductID=od.ProductID
inner join Orders o
on o.OrderID=od.OrderID



select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null