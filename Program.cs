using System;

namespace AppProducto
{
    class Program
    {
        static void Main(string[] args)
        {
            RepoProductos productos = new RepoProductos();
            int opcion;
            string cod = "";
            do{
                Console.WriteLine("---------MENU------------");
                Console.WriteLine("1- Nuevo Producto");
                Console.WriteLine("2- Borrar Producto");
                Console.WriteLine("3- Listar Productos");
                Console.WriteLine("4- Buscar Producto");
                Console.WriteLine("5- Devolver precio del producto");
                Console.WriteLine("0- Salir");
                opcion = Convert.ToInt16(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese Codigo del Producto: ");
                        string codigo = Console.ReadLine();
                        Console.Write("Ingrese Descripcion del Producto: ");
                        string descripcion = Console.ReadLine();
                        Console.Write("Ingrese Precio del Producto: ");
                        double precio = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese Stock del Producto: ");
                        int stock = Convert.ToInt32(Console.ReadLine());
                        Producto producto = new Producto(codigo,descripcion,precio,stock);
                        productos.AgregarProductos(producto);
                        break;
                    case 2:
                        Console.Write("Ingrese el codigo del producto a borrar: ");
                        cod = Console.ReadLine();
                        productos.BorrarProducto(cod);
                        break;
                    case 3:
                        productos.MostrarProductos();
                        break;
                    case 4:
                        Console.Write("Ingrese el codigo del producto a buscar: ");
                        cod = Console.ReadLine();
                        Producto productoMostrar = productos.BuscarProducto(cod);
                        productoMostrar.MostrarUnProducto();
                        break;
                    case 5: 
                        Console.Write("Ingrese el codigo del producto: ");
                        cod = Console.ReadLine();
                        productos.DevolverPrecio(cod);
                        break;
                    default:
                        if(opcion != 0){
                            Console.WriteLine("Opcion Incorrecta! Vuelva a ingresar una opcion.");
                        }
                        break;
                }
            } while (opcion != 0);
            
            
        }
    }
}
