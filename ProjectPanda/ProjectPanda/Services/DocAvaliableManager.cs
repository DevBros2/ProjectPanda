using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Azure.Documents.Client;
using Microsoft.Azure.Documents.Linq;
using ProjectPanda.Models;

namespace ProjectPanda.Services
{
    public partial class DocAvaliableManager
    {
        static DocAvaliableManager defaultInstance = new DocAvaliableManager();

        const string accountURL = @"https://doctorlist.documents.azure.com:443/";
        const string accountKey = @"VjEZjLJIhLPicfqAAssH6iiO4JtRHvGNK1uZOFQXYvkrZiKiqYcFN7uMPx41AyyW6eJsZxKLyJnMsicnqksElg==";
        const string databaseId = @"DocAvaliable";
        const string collectionId = @"Doctors";

        private Uri collectionLink = UriFactory.CreateDocumentCollectionUri(databaseId, collectionId);

        private DocumentClient client;

        private DocAvaliableManager()
        {
            client = new DocumentClient(new System.Uri(accountURL), accountKey);
        }

        public static DocAvaliableManager DefaultManager
        {
            get
            {
                return defaultInstance;
            }
            private set
            {
                defaultInstance = value;
            }
        }
        public List<DocAvaliable> Doctors { get; private set; }

        public async Task<List<DocAvaliable>> GetDoctorsList()
        {
            try
            {
                //The query excludes completed list
                var query = client.CreateDocumentQuery<DocAvaliable>(collectionLink, new FeedOptions { MaxItemCount = -1 })
                    .Where(DocAvaliable => DocAvaliable.Complete == false)
                    .AsDocumentQuery();

                Doctors = new List<DocAvaliable>();
                while (query.HasMoreResults)
                {
                    Doctors.AddRange(await query.ExecuteNextAsync<DocAvaliable>());
                }
            }

            catch(Exception e)
            {
                Console.Error.WriteLine(@"ERROR {0}", e.Message);
                return null;
            }

            return Doctors;
            

            
        }
    }

}
