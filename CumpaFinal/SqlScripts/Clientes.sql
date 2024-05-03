select * from Cliente
select * from Provincia 
select * from Localidades 
select * from Datos_Personales
insert into Cliente(Nombre,Apellido,ID_Datos_Personales)
values('Facundo','grondona',1),
      ('Belgrano', 'belgra',2)

	  select cc.ID_Cliente ,cc.Nombre, cc.Apellido, dd.Mail, dd.Telefono, dd.Contacto, dd.Direccion, pp.Provincia, ll.Localidad
	  from Cliente cc
	  inner join Datos_Personales dd on cc.ID_Datos_Personales = dd.ID_Datos_Personales
	  inner join Localidades ll on dd.ID_Localidad = ll.ID_Localidades
	  inner join Provincia pp on ll.ID_Provincias = pp.ID_Provincia


select * from Localidades
select * from Provincia
	  create procedure InsertarCliente
	  @Nombre varchar(50),
	  @Apellido varchar(50),
	  @Mail varchar(100),
	  @Contacto varchar(50),
	  @Telefono varchar(11),
	  @Direccion varchar(100),
	  @Provincia varchar(50),
	  @Localidad varchar(80)
	  as begin 
	         
			    declare @ID_Provincia int
			    select @ID_Provincia = ID_Provincia from Provincia where Provincia=@Provincia

				declare @ID_Localidad int
				select  @ID_Localidad = ID_Localidades from Localidades where Localidad=@Localidad

				insert into Datos_Personales(Mail,Telefono,Contacto,Direccion,ID_Provincia,ID_Localidad)
				values(@Mail,@Telefono, @Contacto,@Direccion, @ID_Provincia,@ID_Localidad)

                declare @ID_Datos_Personales int
				select TOP 1 @ID_Datos_Personales =  ID_Datos_Personales    from Datos_Personales order by ID_Datos_Personales desc
				
				insert into Cliente(Nombre,Apellido,ID_Datos_Personales)
				values(@Nombre,@Apellido,@ID_Datos_Personales)

      end

	  exec  InsertarCliente 'Agusto','viola','viola@gmail.com','@viola','11111111111','viola 111','Buenos Aires-GBA','Villa de Mayo'

	  select * from Cliente
	  select * from Datos_Personales
	  select * from Provincia
	  select * from Localidades


select * from Localidades
select * from Provincia
	  create procedure ActualizarCliente
	  @ID_Cliente int,
	  @Nombre varchar(50),
	  @Apellido varchar(50),
	  @Mail varchar(100),
	  @Contacto varchar(50),
	  @Telefono varchar(11),
	  @Direccion varchar(100),
	  @Provincia varchar(50),
	  @Localidad varchar(80)
	  as begin 
	         
			    declare @ID_Provincia int
			    select @ID_Provincia = ID_Provincia from Provincia where Provincia=@Provincia

				declare @ID_Localidad int
				select  @ID_Localidad = ID_Localidades from Localidades where Localidad=@Localidad

				declare @ID_Datos int
				select @ID_Datos = ID_Datos_Personales from Cliente where ID_Cliente = @ID_Cliente

				UPDATE Datos_Personales
				set Mail=@Mail,Contacto=@Contacto,Telefono=@Telefono,Direccion=@Direccion,ID_Provincia=@ID_Provincia,ID_Localidad=@ID_Localidad
				where ID_Datos_Personales =@ID_Datos

                UPDATE Cliente 
				set Nombre=@Nombre, Apellido=@Apellido
				where ID_Cliente=@ID_Cliente
               

      end

	  exec ActualizarCliente 1,'Felipe','Gomez','lucho@gmail.com','11111111111','instagram','franco 123', 'Córdoba','Pueblo Italiano'

	  	  select * from Cliente
	  select * from Datos_Personales
	  select * from Provincia
	  select * from Localidades

	  
	  	  create procedure BorrarCliente
	      @ID_Cliente int
	     as begin 

				declare @ID_Datos int
				select  @ID_Datos = ID_Datos_Personales from Cliente where ID_Cliente = @ID_Cliente

	            delete Cliente 
				where ID_Cliente=@ID_Cliente  



				Delete Datos_Personales
				where ID_Datos_Personales =@ID_Datos

           
               

         end
exec BorrarCliente 3

delete Datos_Personales
where ID_Datos_Personales =3
