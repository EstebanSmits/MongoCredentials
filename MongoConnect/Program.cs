using System;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using Newtonsoft.Json;

namespace MongoConnect
{
    internal class Program
    {
        private static  void Main(string[] args)
        {
            var mr = new MongoRequest();
            var results =  mr.GetCollection<Company>("Companies", t => t.name == "Fuzz").ToList();
            
            Console.WriteLine( JsonConvert.SerializeObject(results));
        }
    }
}