using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;  

namespace negocio
{
    public class CategoriaNegocio
    {

        public List<Categoria> Listar()
        {
			List<Categoria> listaCategoria = new List<Categoria>();	
			AccesoDatos datos = new AccesoDatos();	

            try
			{
				datos.setearConsulta("SELECT Id, Descripcion FROM CATEGORIAS");
				datos.ejecutarLectura();

				while (datos.Lector.Read())
				{
                    Categoria categoria = new Categoria();
					categoria.Id = (int)datos.Lector["Id"];	
					categoria.Descripcion = (string)datos.Lector["Descripcion"];	

					listaCategoria.Add(categoria);	
                }

                    return listaCategoria; 
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

        public void agregar(Categoria cat)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into CATEGORIAS(Descripcion) values(@Descripcion)");
                datos.setearParametro("@Descripcion", cat.Descripcion);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

    }
}
