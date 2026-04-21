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
                    articulo.Imagen = new Imagen();
                    listaArticulos.Add(articulo);	
                }

                    return listaArticulos; 
			}
            catch (Exception ex)
            {
                throw new Exception("Error de lectura en la DB" + ex.Message);
            }
            finally
			{
				datos.cerrarConexion();	
            }
        }

        public void agregar(Articulo art)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into ARTICULOS(Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) values(@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @Precio); insert into IMAGENES(IdArticulo, ImagenUrl) values(SCOPE_IDENTITY(), @UrlImagen)");
                datos.setearParametro("@Codigo", art.Codigo);
                datos.setearParametro("@Nombre", art.Nombre);
                datos.setearParametro("@Descripcion", art.Descripcion);
                datos.setearParametro("@IdMarca", art.Marca.Id);
                datos.setearParametro("@IdCategoria", art.Categoria.Id);
                datos.setearParametro("@Precio", art.Precio);
                datos.setearParametro("@UrlImagen", art.Imagen.ImagenUrl);
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

        public void editar(Articulo editado)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("UPDATE ARTICULOS SET Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, Precio = @Precio FROM ARTICULOS A INNER JOIN IMAGENES I ON A.Id = I.IdArticulo WHERE A.Id = @IdArticulo; UPDATE IMAGENES SET ImagenUrl = @NuevaImagenUrl WHERE IdArticulo = @IdArticulo;");
                datos.setearParametro("@Codigo", editado.Codigo);
                datos.setearParametro("@Nombre", editado.Nombre);
                datos.setearParametro("@Descripcion", editado.Descripcion);
                datos.setearParametro("@IdMarca", editado.Marca.Id);
                datos.setearParametro("@IdCategoria", editado.Categoria.Id);
                datos.setearParametro("@Precio", editado.Precio);
                datos.setearParametro("@NuevaImagenUrl", editado.Imagen.ImagenUrl);
                datos.setearParametro("@IdArticulo", editado.Id);

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
