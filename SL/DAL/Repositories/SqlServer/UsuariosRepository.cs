using Microsoft.Data.SqlClient;

using SL.Domain.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.DAL.Repositories.SqlServer
{
    public class UsuariosRepository
    {

        //PermisosRepository repoPermisos;
        public UsuariosRepository()
        {
            // repoPermisos = new PermisosRepository();
        }
        private string GetConnectionString()
        {
            var cs = new SqlConnectionStringBuilder();
            cs.IntegratedSecurity = true;
            cs.DataSource = ".";
            cs.InitialCatalog = "Composite";
            return cs.ConnectionString;
        }

        public List<UsuarioEntity> GetAll()
        {
            var cnn = new SqlConnection(GetConnectionString());
            cnn.Open();
            var cmd = new SqlCommand();
            cmd.Connection = cnn;

            var sql = $@"select * from usuarios;";

            cmd.CommandText = sql;

            var reader = cmd.ExecuteReader();

            var lista = new List<UsuarioEntity>();

            while (reader.Read())
            {
                UsuarioEntity c = new UsuarioEntity();
                c.Id = reader.GetInt32(reader.GetOrdinal("id_usuario"));
                c.nombre = reader.GetString(reader.GetOrdinal("nombre"));
                lista.Add(c);
            }

            reader.Close();
            cnn.Close();

            //vinculo los usuarios con las patentes y familias que tiene configuradas.
            //foreach (var item in lista)
            //{
            //   repoPermisos.FillUserPermissions(item);
            //}



            return lista;
        }
        public void GuardarPermisos(UsuarioEntity u)
        {

            try
            {
                var cnn = new SqlConnection(GetConnectionString());
                cnn.Open();

                var cmd = new SqlCommand();
                cmd.Connection = cnn;

                cmd.CommandText = $@"delete from usuarios_permisos where id_usuario=@id;";
                cmd.Parameters.Add(new SqlParameter("id", u.Id));
                cmd.ExecuteNonQuery();

                foreach (var item in u.Permisos)
                {
                    cmd = new SqlCommand();
                    cmd.Connection = cnn;

                    cmd.CommandText = $@"insert into usuarios_permisos (id_usuario,id_permiso) values (@id_usuario,@id_permiso) "; ;
                    cmd.Parameters.Add(new SqlParameter("id_usuario", u.Id));
                    cmd.Parameters.Add(new SqlParameter("id_permiso", item.Id));

                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
