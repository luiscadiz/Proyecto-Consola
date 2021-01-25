using System;
using System.Collections.Generic;

namespace AppProducto
{
    public class RepoProductos{
        public List <Producto> Productos = new List<Producto>();
        //METODOS
        public void AgregarProductos(Producto producto){

            if (producto.Codigo == ""){
                throw new Exception("Sin codigo de producto");
            }
            if (producto.Descripcion == ""){
                throw new Exception("Sin descripcion de producto");
            }
            if (producto.Precio == 0){
                throw new Exception("Sin precio de producto");
            }
            Productos.Add(producto);
        }

        public void MostrarProductos()
        {
            foreach (var producto in Productos)
            {
                producto.MostrarUnProducto();
            }
        }
        private Producto Buscar(string codigo)
        {
            foreach (var producto in Productos)
            {
                if(producto.Codigo == codigo){
                    return producto;
                }
            }
            throw new Exception("No se encontro el producto");
        }
        public Producto BuscarProducto(string codigo)
        {
            try
            {
                Producto productoBuscar = Buscar(codigo);
                return productoBuscar;  
            }
            catch (System.Exception error)
            {
                Console.WriteLine(error.Message);
            }
            return null; //coloco este return para que el modulo no me muestre un error
        }

        public void BorrarProducto(string codigo)
        {
            try
            {
                Producto productoEliminar = Buscar(codigo);
                Productos.Remove(productoEliminar);
                Console.WriteLine("Borrado Exitoso!!!");
            }
            catch (System.Exception error)
            {
                 Console.WriteLine(error.Message);
            }
        }

        public void DevolverPrecio(string codigo)
        {
            try
            {
                Producto producto = Buscar(codigo);
                Console.WriteLine("El precio del producto es: {0}",producto.Precio);
            }
            catch (System.Exception error)
            {
                 Console.WriteLine(error.Message);
            }
        }
    }
}
