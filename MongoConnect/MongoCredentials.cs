using System.Configuration;
public static class MongoCredentials

{
    public static bool useSecurity { get; set; }
    public static string host { get; set; }
    public static int port { get; set; }
    public static string username { get; set; }
    public static string password { get; set; }
    public static string database { get; set; }

    static MongoCredentials()
    {
        useSecurity = true;
        port = int.Parse(ConfigurationManager.AppSettings["port"]);
        host =  ConfigurationManager.AppSettings["host"];
        username= ConfigurationManager.AppSettings["username"];
        password = ConfigurationManager.AppSettings["password"];
        database = ConfigurationManager.AppSettings["database"];
        
    }
}