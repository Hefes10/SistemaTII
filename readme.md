## MANUAL DE USUARIO

# 1. Requisitos del sistema
- SQL Server Management Studio 15.0.18410.0
- SQL Server Management Objects (SMO) 16.100.47008.0
- Microsoft .NET Framework 4.0.30319.42000
- Microsoft Visual Studio Community 2019 Version 16.11.20



# 2. Primeros pasos
1. Restaurar base de datos:
Dentro de SQL Server Management Studio, click derecho sobre Databases -> Restore Database... -> Seleccionar Device -> Click en "..." -> Add -> Seleccionar el archivo de restauración de la base (*.bak) incluído en el proyecto -> Ok -> Ok

2. La copia de restauración de la base de datos incluye datos de prueba, en caso de querer dejar la base en blanco para su uso se debe eliminar los registros en el siguiente orden:

- Eliminar registros de tabla maestro/detalle, ya que ninguna tabla depende de estas, pero estas si dependen de las demás.

`delete from detalle_venta;
delete from venta;
delete from detalle_ingreso;
delete from ingreso;`

- Eliminar registros de tablas dependientes.

`delete from persona;
delete from articulo;`


- Eliminar por último los registros de tablas independientes, estos registros se eliminan en último lugar puesto que son referenciados por otras tablas.

`delete from categoria;`


- Después de eliminar los registros podemos iniciar el valor de los campos identity de las tablas para que nuevamente comiencen en 1.

`DBCC CHECKIDENT ('detalle_venta', RESEED, 1);  
GO`
 
`DBCC CHECKIDENT ('venta', RESEED, 1);  
GO
DBCC CHECKIDENT ('detalle_ingreso', RESEED, 1);  
GO
DBCC CHECKIDENT ('ingreso', RESEED, 1);  
GO
DBCC CHECKIDENT ('persona', RESEED, 1);  
GO
DBCC CHECKIDENT ('articulo', RESEED, 1);  
GO
DBCC CHECKIDENT ('categoria', RESEED, 1);  
GO`


Todas estas secuencias sql se deben ejecutar en la ventana de consultas de Sql Server Management, seleccionando la base de datos correspondiente.

3. Generar Instalador: 
- Abrir el proyecto en Visual Studio -> click derecho en Sistema.Presentación -> Publish -> Seleccionar ruta a guardar el instalador -> Next -> Next -> Next -> Finish

# 2. Perfiles y datos de acceso

Existen 4 perfiles de acceso:
1. Vendedor: Comple las funciones de Venta y gestión de Clientes
- user: vendedor@prueba.com
- password: asd
2. Almacenero: Cumple las funciones de Registro de Ingreso y Gestión de Proveedores.
- user: almacenero@prueba.com
- password: asd
3. Administrador: Puede acceder a todas las funciones anteriores y además se encarga del Alta de Nuevos Usuarios, Alta de Nuevos Articulos, Alta de Nuevas Categorías, Consulta de Reportes y Backup de la Base de Datos.
- user: administrador@prueba.com
- password: asd
4. SysAdmin: Puede acceder a todas las funciones anteriores y además se encuentra habilitado para hacer el Restore de la Base de Datos.
- user: sa@prueba.com
- password: asd

# 3. Funcionalidades

1. Solapa Ventas:
- Clientes: En esta funcionalidad es posible la busqueda de clientes, listado de clientes, alta baja y modificación de clientes.
- Ventas: Buscar una venta, generar comprobante de venta, lsitar todas las ventas, anular una venta, generar una venta.
- Mis Ventas: Como rol de vendedor es posible consultar todas las ventas propias en un rango de fechas.
2. Solapa Ingresos:
- Proveedores: En esta funcionalidad es posible la busqueda de proveedores, listado de proveedores, alta baja y modificación de proveedores.
- Compras: Buscar una compra, generar comprobante de compra, lsitar todas las ventas, anular una compra, generar una compra.
3. Solapa Almacén:
- Categoría: En esta funcionalidad es posible la busqueda de categorías, listado de categorías, alta baja y modificación de categorías.
- Artículos: En esta funcionalidad es posible la busqueda de artículos, listado de artículos, alta baja y modificación de artículos.
4. Solapa Acceso:
- Roles: Listado de roles.
- Usuarios: En esta funcionalidad es posible la busqueda de usuarios, listado de usuarios, alta baja y modificación de usuarios.
5. Solapa Consultas - Consulta de Ventas:
- Listado por Vendedor: Reporte de Ventas por vendedor en un rango de fechas.
- Listado entre Fechas: Reporte de ventas en un rango de fechas (sin filtro por vendedor).
- Listado por Producto: Reporte de Ventas por producto en un rango de fechas.
- Listado más Vendidos: Reporte del Top 10 de productos más vendidos en un rango de fechas.
6. Solapa Backup:
- Funcion backup: Permite realizar un backup de la base de datos (Administrador).
- Función Restore: Permite restaurar la base de datos desde un archivo de backup (Solo usuario con provilegios de Sysadmin).
