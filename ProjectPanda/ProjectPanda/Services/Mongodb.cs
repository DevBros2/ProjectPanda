using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using ProjectPanda.Models;

namespace ProjectPanda.Services
{
    public partial class MongoDB
    {
        public String DatabaseCall;//used when switching between Database(instead of repeating code)
        public String CollectionCall;//used when switching between collections(instead of repeating code) 

        private IMongoClient _client;

        private IMongoDatabase _database;

        private IMongoCollection<PatientInfo> _usersCollection;

         /// <summary>

        /// Checking is connection to the database established.

        /// </summary>

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
        public UsersRepository(string connectionString)
        {

        _client = new MongoClient(connectionString);

        _database = _client.GetDatabase(DatabaseCall);

        _usersCollection = _database.GetCollection<PatientInfo>(CollectionCall);

        }
        public async Task<List<DocAvaliable>> GetUsersByField(string DocName, string medicalbuilding)
        {
            var filter = Builders<DocAvaliable>.Filter.Eq(DocName, medicalbuilding);
            var result = await _usersCollection.Find(filter).ToListAsync();

            return result;
        }

    }

  
}

