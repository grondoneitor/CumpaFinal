--PRODUCTOS

select * from Productos
select * from Categoria_Producto
select Categoria_Producto from Categoria_Producto

select pp.ID_Productos, pp.Producto,cp.Categoria_Producto, pp.Color,pp.Tama�o,pp.Stock_Minimo,pp.Stock, pp.Precio_Costo,pp.Precio_Venta, pp.Nota
from Productos pp 
inner join Categoria_Producto cp on pp.ID_Categoria_Producto = cp.ID_Categoria_Producto


insert into Categoria_Producto(Categoria_Producto)
values('Mates'),
       ('Bombillas'), ('Materas')


insert into Productos(ID_Categoria_Producto,Producto,Color,Tama�o,Stock,Stock_Minimo,Precio_Costo,Precio_Venta,Nota)
values(2,'Pico loro cincelada','Plateada','Grande',4,10,8000,15000,null)



create procedure AgregarProducto
@Categoria_Producto varchar(50),
@Producto varchar(50),
@Color varchar(50),
@Tama�o varchar(50),
@Stock int,
@Stock_Minimo int,
@Precio_Costo money, 
@Precio_Venta money, 
@Nota varchar(150)
as begin 

  declare @ID_Categoria_Producto int
  select @ID_Categoria_Producto = ID_Categoria_Producto
  from Categoria_Producto 
  where Categoria_Producto = @Categoria_Producto

  insert into Productos(ID_Categoria_Producto,Producto,Color,Tama�o,Stock,Stock_Minimo,Precio_Costo,Precio_Venta,Nota)	
  values(@ID_Categoria_Producto,@Producto,@Color,@Tama�o,@Stock,@Stock_Minimo,@Precio_Costo,@Precio_Venta,@Nota)

end

exec AgregarProducto 'Mates','Cincelado','Bordo','Medio',15,10,16000,33000,null


create procedure ModificarProductos
@ID_Producto int,
@Categoria_Producto varchar(50),
@Producto varchar(50),
@Color varchar(50),
@Tama�o varchar(50),
@Stock int,
@Stock_Minimo int,
@Precio_Costo money, 
@Precio_Venta money, 
@Nota varchar(150)
as begin 
      
  declare @ID_Categoria_Producto int
  select @ID_Categoria_Producto = ID_Categoria_Producto
  from Categoria_Producto 
  where Categoria_Producto = @Categoria_Producto

  update Productos
  set ID_Categoria_Producto = @ID_Categoria_Producto, Producto= @Producto,
      Color=@Color,Tama�o=@Tama�o,Stock=@Stock,Stock_Minimo=@Stock_Minimo,
	  Precio_Costo=@Precio_Costo,Precio_Venta=@Precio_Venta, Nota=@Nota
  where ID_Productos =@ID_Producto


end

exec ModificarProductos 5,'Mates','Torpedo virola lisa','Bordo','Chico',10,5,10000,20000,null


delete Productos where ID_Productos=5