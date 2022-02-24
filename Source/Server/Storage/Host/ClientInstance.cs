using Storage.Cache;
using Storage.DataBase;
using Storage.Operations;

namespace Storage.Host;

public class ClientInstance
{
    public AllCache Cache { get; }

    public AllOperations Operations { get; }

    public DBInteraction DB { get; }

    public ClientInstance()
    {
        Cache = new AllCache();
        Operations = new AllOperations(Cache);
        DB = new("localhost", "coby", 3306, "coby", "1234");
    }
}