using System;

namespace AppProducto
{
    public class Producto
    {
        //PROPIEDADES
        public string Codigo;
        public string Descripcion;
        public double Precio;
        public int Stock;

        //METODOS
        public Producto(string codigo,string descripcion, double precio, int stock){

            Codigo = codigo;
            Descripcion = descripcion;
            Precio = precio;
            Stock = stock;
        }

        public void MostrarUnProducto()
        {
            Console.WriteLine("\nCodigo: {0}",Codigo);
            Console.WriteLine("Descripcion: {0}",Descripcion);
            Console.WriteLine("Precio: {0}",Precio);
            Console.WriteLine("Stock: {0}",Stock);
        }
    }    

}