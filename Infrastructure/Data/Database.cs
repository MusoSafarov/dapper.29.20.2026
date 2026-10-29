using System.Data;
using Npgsql;

namespace Infrastructure.Data;

public class Database
{
    private string connection = "Host=localhost;Port=5432;Database=crm;Username=postgres;Password=1234";
    public IDbConnection Connection()=> new NpgsqlConnection(connection);
}
