using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;  

namespace negocio
{
    public class ArticuloNegocio
    {

        public List<Articulo> Listar()
        {
			List<Articulo> listaArticulos = new List<Articulo>();	
			AccesoDatos datos = new AccesoDatos();	

            try
			{
				datos.setearConsulta("select A.Id, A.Codigo, A.Nombre, A.Descripcion, A.Precio, M.Descripcion as Marca, C.Descripcion as Categoria from ARTICULOS A inner join MARCAS M on A.IdMarca = M.Id inner join CATEGORIAS C on A.IdCategoria = C.Id");
				datos.ejecutarLectura();

				while (datos.Lector.Read())
				{
                    Articulo articulo = new Articulo();
					articulo.Id = (int)datos.Lector["Id"];	
					articulo.Codigo = (string)datos.Lector["Codigo"];
                    articulo.Nombre = (string)datos.Lector["Nombre"];
                    articulo.Descripcion = (string)datos.Lector["Descripcion"];
                    articulo.Marca = new Marca();
                    articulo.Marca.Descripcion = (string)datos.Lector["Marca"];
                    articulo.Categoria = new Categoria();
                    articulo.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    articulo.Precio = (decimal)datos.Lector["Precio"];


                    listaArticulos.Add(articulo);	
                }

                    return listaArticulos; 
			}
            catch (Exception)
            {
                throw;
            }
            finally
			{
				datos.cerrarConexion();	
            }
        }


    }
}
