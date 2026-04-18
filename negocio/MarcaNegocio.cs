using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;  

namespace negocio
{
    public class MarcaNegocio
    {

        public List<Marca> Listar()
        {
			List<Marca> listaMarca = new List<Marca>();	
			AccesoDatos datos = new AccesoDatos();	

            try
			{
				datos.setearConsulta("SELECT Id, Descripcion FROM MARCAS");
				datos.ejecutarLectura();

				while (datos.Lector.Read())
				{
					Marca marca = new Marca();
					marca.Id = (int)datos.Lector["Id"];	
					marca.Descripcion = (string)datos.Lector["Descripcion"];	

					listaMarca.Add(marca);	
                }

                    return listaMarca; 
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
