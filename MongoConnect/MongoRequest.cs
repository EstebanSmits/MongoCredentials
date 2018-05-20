using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver.Linq;
using MongoDB.Driver;

namespace MongoConnect
{
    public class MongoRequest
    {
        private IMongoDatabase localdatabase;
        public MongoRequest()
        {
             InitializeDB();
        }

     
        public IMongoQueryable<T> GetCollection<T>(string collection, Expression<Func<T,bool>> predicate)
        {
            var companies = localdatabase.GetCollection<T>(collection);
            var result = companies.AsQueryable<T>().Where(predicate);
            return result;
        }

        public async Task<IMongoQueryable<T>> GetCollectionAsync<T>(string collection, Expression<Func<T, bool>> predicate)
        {
            var companies = localdatabase.GetCollection<T>(collection);
            var result = await Task.Run(() => companies.AsQueryable<T>().Where(predicate));
            return result;
        }


        public void InsertCollection<T>(string collection, List<T> listToAdd)
        {
            var companies = localdatabase.GetCollection<T>(collection);
        }
        public void InitializeDB()
        {
            MongoClientSettings settings = new MongoClientSettings();
            settings.Server = new MongoServerAddress(MongoCredentials.host, MongoCredentials.port);
            if (MongoCredentials.useSecurity)
            {
                settings.UseSsl = true;
                settings.SslSettings = new SslSettings();
                settings.SslSettings.EnabledSslProtocols = System.Security.Authentication.SslProtocols.Tls12;
                var identity = new MongoInternalIdentity(MongoCredentials.database, MongoCredentials.username);
                var evidence = new PasswordEvidence(MongoCredentials.password);
                settings.Credential = new MongoCredential(null, identity, evidence);
            }
            var client = new MongoClient(settings);
            localdatabase = client.GetDatabase(MongoCredentials.database);
        }
    }
}