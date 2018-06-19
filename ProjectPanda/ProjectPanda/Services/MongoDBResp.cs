using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ProjectPanda.Models;
using MongoDB.Driver;

namespace ProjectPanda.Services
{
    public class MongoDBResp
    {
        readonly static string connectionString = "mongodb://localhost:27017";//for local development
        readonly static string DatabaseCall = "database"; //making it readonly so cant be attacked easily
        readonly static string CollectionCall = "Collection";

        private IMongoClient _client;
        private IMongoDatabase _database;
        IMongoCollection<DocAvaliable> _doctorCollection;

        /// <summary>

        /// Checking is connection to the database established.

        /// </summary>
        /// 
        public bool CheckConnection()//method for checking connectivity before attempt to CRUD data.
        {
            try
            {
                _database.ListCollections();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public MongoDBResp(string connectionString)
        {

            _client = new MongoClient(connectionString);

            _database = _client
                .GetDatabase(DatabaseCall);

            _doctorCollection = _database
                .GetCollection<DocAvaliable>(CollectionCall); 
            
        }
        public async Task<List<DocAvaliable>> GetUsersBySpecialization(string medicalbuilding, string docSpecialization )
        {
            //filter function, this will filter by Medical building and specialization
            var filter = Builders<DocAvaliable>
                .Filter
                .Eq(medicalbuilding, docSpecialization);
            //adds filter to the query
            var result = await _doctorCollection
                .Find(filter)
                .ToListAsync();//retiurns it as a list
            return result;
        }


    }
}