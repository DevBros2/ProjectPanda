using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using ProjectPanda.Models;
using System.Threading.Tasks;
using Microsoft.Azure.Documents.Client;
using Microsoft.Azure.Documents.Linq;

namespace ProjectPanda.Services
{
    public partial class UserRegistrationManager
    {
        static UserRegistrationManager defaultInstance = new UserRegistrationManager();

        const string accountURL = @"https://users.documents.azure.com:443/";
        const string accountKey = @"9JfL5hQSWXjjdQ1qVa4cprR3djjCyZXDeEFwYdEikBWdaTq28XNWxyFnZl8cjwf6R9b6MmUolb3QhQJQegvASA==";
        const string databaseId = @"users";
        const string collectionId = @"Information";

        private Uri collectionLink = UriFactory.CreateDocumentCollectionUri(databaseId, collectionId);

        private DocumentClient client;

        private UserRegistrationManager()
        {
            client = new DocumentClient(new System.Uri(accountURL), accountKey);
        }

        public static UserRegistrationManager DefaultManager
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

        public async Task<PatientInfo> InsertUsers(PatientInfo userRegistration)
        {
            try {

                var result = await client.CreateDocumentAsync(collectionLink, userRegistration);
                userRegistration.Id = result.Resource.Id;

        } catch (Exception e) {

                Console.Error.WriteLine (@"ERROR {0}", e.Message);
			}
			return userRegistration;
		}
        

    }
}
