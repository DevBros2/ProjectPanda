using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using ProjectPanda.Models;
using System.Threading.Tasks;
using Microsoft.Azure.Documents.Client;
using Microsoft.Azure.Documents.Linq;

namespace SerapisPatientWebService.Controllers
{
    [Route("api/PatientUser")]
    public class DocAvaliableController : Controller
    {
        DataAccess objds;
        
        // DocumentDB deafult values
        static UserRegistrationManager defaultInstance = new UserRegistrationManager();
        const string accountURL = @"https://users.documents.azure.com:443/";
        const string accountKey = @"9JfL5hQSWXjjdQ1qVa4cprR3djjCyZXDeEFwYdEikBWdaTq28XNWxyFnZl8cjwf6R9b6MmUolb3QhQJQegvASA==";
        const string databaseId = @"users"; // value must change
        const string collectionId = @"Information";//values must change

        private Uri collectionLink = UriFactory.CreateDocumentCollectionUri(databaseId, collectionId);

        private DocumentClient client;

        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            DocAvaliable _docAvaliable = await DocumentDBRepository<DocAvaliable>.GetItemAsync(id);
            if (_user == null)
            {
                return HttpNotFound();
            }

            return View(_docAvaliable);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            DocAvaliable _docAvaliable = await DocumentDBRepository<Movie>.GetItemAsync(id);
            await DocumentDBRepository<DocAvaliable>.RemoveItemAsync(_docAvaliable.Id, _docAvaliable);

        }
    }
}
