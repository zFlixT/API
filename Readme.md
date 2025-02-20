API 
Este proyecto es una API desarrollada en .NET 8 que permite la gestión de artículos.

Instalación y configuración.

1- Clonar el repositorio:
    git clone https://github.com/zFlixT/API
     cd API

2- Restaurar las dependencias:
    dotnet restore

3- Configurar la base de datos:
- Modifica el archivo appsettings.json con la cadena de conexión de su SQL Server.
   "Server=NombreDeSuServidor;Database=TiendaDB;Trusted_Connection=True;TrustServerCertificate=True"
- Aplica las migraciones para configurar la base de datos:
    dotnet ef database update

4- Ejecutar la API

-------------------------------------------------------------------------------------------------------------

Uso de la API

- Obtener todos los artículos
   GET /api/articulos
     "se muestran todos los productos existentes"

- Obtener un artículo por ID
   GET /api/articulos/{id}
    id : "Insertar la id del producto a mostrar"

- Crear un nuevo artículo
   POST /api/artículos/InsertarProducto
     {
       "id": 0,
       "nombre": "NombreDelProducto",
       "precio": 0.01,
       "stock": 10
     }

- Actualizar un artículo existente
   PUT /api/artículos/EditarProducto/{id}
     id: "Seleccionar id del producto a editar"
	EditarProducto
	{
  	  "id": 0,
  	  "nombre": "NuevoNombre",
  	  "precio": "NuevoPrecio",
  	  "stock": "NuevoStock"
	}

- Eliminar un artículo
   DELETE /api/Articulos/EliminarProducto/{id}
      id : "ingresar la id del producto a eliminar"
