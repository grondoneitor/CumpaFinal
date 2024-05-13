--PRODUCTOS

select * from Productos
select * from Categoria_Producto
select Categoria_Producto from Categoria_Producto

select pp.ID_Productos, pp.Producto,cp.Categoria_Producto, pp.Color,pp.Tamaño,pp.Stock_Minimo,pp.Stock, pp.Precio_Costo,pp.Precio_Venta, pp.Nota
from Productos pp 
inner join Categoria_Producto cp on pp.ID_Categoria_Producto = cp.ID_Categoria_Producto


insert into Categoria_Producto(Categoria_Producto)
values('Mates'),
       ('Bombillas'), ('Materas')


insert into Productos(ID_Categoria_Producto,Producto,Color,Tamaño,Stock,Stock_Minimo,Precio_Costo,Precio_Venta,Nota)
values(2,'Pico loro cincelada','Plateada','Grande',4,10,8000,15000,null)



create procedure AgregarProducto
@ID_Producto int,
@Categoria_Producto varchar(50),
@Producto varchar(50),
@Color varchar(50),
@Tamaño varchar(50),
@Stock int,
@Stock_Minimo int,
@Precio_Costo money, 
@Precio_Venta money, 
@Nota varchar(150)
as begin 

  declare @ID_Categoria_Producto int
  select @ID_Categoria_Producto = 
  from Categoria

end