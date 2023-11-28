using System.Data.SqlClient;
using Dapper;

using System.Collections.Generic;

public static class BD
{
    private static string connectionString = @"Server=localhost;DataBase=ingreso;Trusted_Connection=True;";

    public static void CrearUsuario(Usuario us)
    {
        using (SqlConnection BD = new SqlConnection(_connectionString))
        {
            string sql = "INSERT INTO Usuario([username],[contraseña],[nombre],[email]) VALUES(@Username,@Contraseña,@Nombre,@Email)";
            BD.Execute(sql, new { Username = us.username, Contraseña = us.contraseña, Nombre = us.nombre, Email = us.email });
        }
    }

    public static void CambiarContraseña(string Username, string nuevaContraseña)
    {
        using (SqlConnection BD = new SqlConnection(connectionString))
        {
            string sql = "UPDATE Usuario SET contraseña=@NuevaContraseña where username= @username";
            BD.Execute(sql, new { NuevaContraseña = nuevaContraseña, username = Username });
        }
    }

    public static Usuario mostrarDatos(int IdUsuario, string username, string nombre, string email, int telefono)
    {
        Usuario us = null;
        using (SqlConnection BD = new SqlConnection(connectionString))
        {
            string sql = "SELECT username, nombre, email, telefono from Usuario where idUsuario=@IDusuario";
            us = BD.QueryFirstOrDefault<Usuario>(sql, new { IdUsuario = IdUsuario });
        }
        return us;
    }

    public static string GetContraseñaPorUsername(string username)
    {
        string contraseña;
        using (SqlConnection BD = new SqlConnection(connectionString))
        {
            string sql = "SELECT contraseña FROM Usuario WHERE username=@Username";
            contraseña = BD.QueryFirstOrDefault<string>(sql, new { Username = username });
        }
        return contraseña;
    }

}
