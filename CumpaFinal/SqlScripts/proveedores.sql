select * from Proveedores
select * from Datos_Personales

select pp.ID_Provincia,pp.Provincia,ll.ID_Localidades ,ll.Localidad
from Localidades ll 
inner join Provincia pp on ll.ID_Provincias = pp.ID_Provincia


insert into Datos_Personales(Mail, Telefono,Contacto,Direccion, ID_Provincia,ID_Localidad)
values('mate@mate.com', '22222222222', 'wpp', 'gualegay 333', 2,205)


insert into Proveedores(Proveedor,ID_Datos_Personales)
values('gualegay mates', 1004)

select pp.ID_Proveedor ,pp.Proveedor,dd.Mail,dd.Telefono,dd.Contacto,dd.Direccion,rr.Provincia,ll.Localidad
from Proveedores pp 
inner join Datos_Personales dd on pp.ID_Datos_Personales = dd.ID_Datos_Personales
inner join Localidades ll on dd.ID_Localidad=ll.ID_Localidades
inner join Provincia rr on dd.ID_Provincia = rr.ID_Provincia


create procedure IngresarProveedor
@Proveedor varchar(50),
@Mail varchar(100),
@Telefono char(11),
@Contacto varchar(50),
@Direccion varchar(100),
@Provincia varchar(50),
@Localidad varchar(100)
as begin 
          
		  declare @ID_Provincia int
		  select @ID_Provincia = ID_Provincia
		  from Provincia 
		  where Provincia =@Provincia

		  declare @ID_Localidad int
		  select @ID_Localidad = ID_Localidades
		  from Localidades 
		  where Localidad = @Localidad

		  insert into Datos_Personales(Mail,Telefono,Contacto,Direccion,ID_Provincia,ID_Localidad)
		  values(@Mail,@Telefono,@Contacto,@Direccion,@ID_Provincia,@ID_Localidad)

		  declare @ID_Datos_Personales int
		  select top 1 @ID_Datos_Personales = ID_Datos_Personales
		  from Datos_Personales
		  order by ID_Datos_Personales desc

		  insert into Proveedores(Proveedor,ID_Datos_Personales)
		  values(@Proveedor, @ID_Datos_Personales)

end

	exec IngresarProveedor 'Cuero Cordoba','cueros@gmail.com', '33333333333','facebook','cordoba 111','Córdoba','Las Palmas'



	create procedure ActualizarProveedores
	  @ID_Proveedor int,
	  @Proveedor varchar(50),
	  @Mail varchar(100),
	  @Telefono varchar(11),
	  @Contacto varchar(50),
	  @Direccion varchar(100),
	  @Provincia varchar(50),
	  @Localidad varchar(80)
	  as begin 
	         
			    declare @ID_Provincia int
			    select @ID_Provincia = ID_Provincia from Provincia where Provincia=@Provincia

				declare @ID_Localidad int
				select  @ID_Localidad = ID_Localidades from Localidades where Localidad=@Localidad

				declare @ID_Datos int
				select @ID_Datos = ID_Datos_Personales from Proveedores where ID_Proveedor = @ID_Proveedor

				UPDATE Datos_Personales
				set Mail=@Mail,Contacto=@Contacto,Telefono=@Telefono,Direccion=@Direccion,ID_Provincia=@ID_Provincia,ID_Localidad=@ID_Localidad
				where ID_Datos_Personales =@ID_Datos

                UPDATE Proveedores 
				set Proveedor=@Proveedor
				where ID_Proveedor=@ID_Proveedor
               

      end
	   	  exec ActualizarProveedores 5,'Facu','facu@gmail.com','1122457620','twiter','pedro lozano 4479','Capital Federal','Agronomía'

	     create procedure BorrarProveedor
	      @ID_Proveedor int
	     as begin 

				declare @ID_Datos int
				select  @ID_Datos = ID_Datos_Personales from Proveedores where ID_Proveedor = @ID_Proveedor

	            delete Proveedores 
				where ID_Proveedor = @ID_Proveedor



				Delete Datos_Personales
				where ID_Datos_Personales =@ID_Datos

           
               

         end

		 exec BorrarProveedor 5
