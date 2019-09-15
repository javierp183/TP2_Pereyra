using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;

namespace Catalogo
{
    public class CatalogoDeArticulos
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            Articulo aux;

            SqlCommand comando = new SqlCommand();
            SqlConnection conexion= new SqlConnection();
            SqlDataReader lector;



            try
            {
                conexion.ConnectionString = "data source=LAPTOP-82OTF4J8\\SQLEXPRESS; initial catalog=CATALOGO_DB; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT p.Id, p.Codigo, p.Nombre, p.Descripcion, p.Precio, p.IdMarca, p.IdCategoria from ARTICULOS p";
                //comando.CommandText = " SELECT p.Id, p.Codigo, p.Nombre, p.Descripcion, p.Precio, p.IdMarca, p.IdCategoria from ARTICULOS p"; // inner join CATEGORIAS b on p.idcategoria = b.Id inner join marca c on p.IdMcarca = c.id";
                //comando.CommandText = "SELECT p.Id, p.Codigo, p.Nombre, p.Descripcion, p.Precio, p.IdMarca, p.IdCategoria from ARTICULOS p inner join CATEGORIAS b on p.idcategoria = b.Id inner join MARCAS c on p.IdMarca = c.id";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    aux = new Articulo();
                    aux.Id = lector.GetInt32(0);
                    aux.Codigo = lector["Codigo"].ToString();
                    aux.Nombre = lector["Nombre"].ToString();
                    aux.Descripcion = lector["Descripcion"].ToString();
                    aux.Precio = (decimal)lector["Precio"];

                    //Declaro el objeto Marca.
                    //aux.Marca = new Marca();
                    //aux.Marca.Id = (int)lector["IdMarca"];
                    

                

                    lista.Add(aux);

                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

        public List<Articulo> buscar(string Codigo)
        {
            List<Articulo> lista = new List<Articulo>();
            Articulo aux;
            Console.WriteLine(Codigo);

            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection();
            SqlDataReader lector;



            try
            {
                conexion.ConnectionString = "data source=LAPTOP-82OTF4J8\\SQLEXPRESS; initial catalog=CATALOGO_DB; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT p.Id, p.Codigo, p.Nombre, p.Descripcion, p.Precio, p.IdMarca, p.IdCategoria from ARTICULOS p";
                //comando.CommandText = " SELECT p.Id, p.Codigo, p.Nombre, p.Descripcion, p.Precio, p.IdMarca, p.IdCategoria from ARTICULOS p"; // inner join CATEGORIAS b on p.idcategoria = b.Id inner join marca c on p.IdMcarca = c.id";
                //comando.CommandText = "SELECT p.Id, p.Codigo, p.Nombre, p.Descripcion, p.Precio, p.IdMarca, p.IdCategoria from ARTICULOS p inner join CATEGORIAS b on p.idcategoria = b.Id inner join MARCAS c on p.IdMarca = c.id";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    

                    if (Codigo == lector["Codigo"].ToString()) {
                        aux = new Articulo();

                        aux.Codigo = lector["Codigo"].ToString();
                    aux.Id = lector.GetInt32(0);
                    aux.Nombre = lector["Nombre"].ToString();
                    aux.Descripcion = lector["Descripcion"].ToString();
                    aux.Precio = (decimal)lector["Precio"];

                    //Declaro el objeto Marca.
                    //aux.Marca = new Marca();
                    //aux.Marca.Id = (int)lector["IdMarca"];

                    lista.Add(aux);

                    }

                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

        public void agregar(Articulo articulo)
        {
            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion.ConnectionString = "data source=LAPTOP-82OTF4J8\\SQLEXPRESS; initial catalog=CATALOGO_DB; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                //comando.CommandText = "Insert into ARTICULOS values ('" + articulo.Id + "', @Codigo, @Nombre, @Descripcion, @Precio)";
                //comando.CommandText = "Insert into ARTICULOS values('" + articulo.Id + "', @Codigo,@Nombre,@Descripcion,@IdMarca,@IdCategoria,@Precio)";
                comando.CommandText = "Insert into ARTICULOS values(@Codigo,@Nombre,@Descripcion,@IdMarca,@IdCategoria,1,@Precio)";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Codigo", articulo.Codigo);
                comando.Parameters.AddWithValue("@Nombre", articulo.Nombre);
                comando.Parameters.AddWithValue("@Descripcion", articulo.Descripcion);
                comando.Parameters.AddWithValue("@Precio", articulo.Precio);
                comando.Parameters.AddWithValue("@IdMarca", articulo.Marca);
                comando.Parameters.AddWithValue("@IdCategoria", articulo.Categoria);


                comando.Connection = conexion;
                conexion.Open();
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexion.Close();
            }
            
        }

        public void borrar(string cod)
        {
            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = "data source=LAPTOP-82OTF4J8\\SQLEXPRESS; initial catalog=CATALOGO_DB; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "DELETE FROM ARTICULOS WHERE Codigo = @Codigo";
                comando.Parameters.AddWithValue("@Codigo", cod);

                comando.Connection = conexion;

                conexion.Open();
                comando.ExecuteNonQuery();





            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexion.Close();
            }
            
        }

        public void modificar(Articulo articulo)
        {
            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = "data source=LAPTOP-82OTF4J8\\SQLEXPRESS; initial catalog=CATALOGO_DB; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                //comando.CommandText = "update ARTICULOS set Codigo=@Codigo, Nombre=@Nombre, Descripcion=@Descripcion, IdMarca=@IdMarca,IdCategoria=@IdCategoria,Precio=@Precio where Id=@Id ";
                //comando.CommandText = "update ARTICULOS set Nombre = @Nombre where Id = @Id ";
                comando.CommandText = "Update ARTICULOS set Nombre=@Nombre,Codigo=@Codigo Where Id=@Id";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Nombre", articulo.Nombre);
                comando.Parameters.AddWithValue("@Codigo", articulo.Codigo);
                //comando.Parameters.AddWithValue("@IdMarca", articulo.Marca);
                //comando.Parameters.AddWithValue("@Descripcion", articulo.Descripcion);
                //comando.Parameters.AddWithValue("@Descripcion", articulo.Descripcion);
                comando.Parameters.AddWithValue("@Id", articulo.Id);
                comando.Connection = conexion;

                //Console.WriteLine(articulo.Nombre);
                //Console.WriteLine(articulo.Id);
                Console.WriteLine("salida:");
                Console.WriteLine(articulo.Descripcion);

                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexion.Close();
            }

        }

    }

}
