using System.Data.SqlClient;



namespace CRUDCORE.Datos
{
    public class Conexion
    {
        public string cadenaSQL = string.Empty;
        //metodo
        public Conexion() {
            //obtener la cadena de conexion del appsettings.json
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            cadenaSQL = builder.GetSection("ConnectionStrings:CadenaSQL").Value;
        }

        public string getCadenaSQL(){
            return cadenaSQL;
    }
       
    }
}
