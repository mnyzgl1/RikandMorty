using RestSharp;
using RikendMorty.Models;
using static RikendMorty.Models.Karakter;
using Newtonsoft.Json;
namespace RikendMorty.Repository
{
    public interface IRikandMortyRepository
    {
        public List<Karakter> GetKarakters();

    } 
    public class RikandMortyRepository:IRikandMortyRepository
    {
        public List<Karakter> GetKarakters()
        {
            ///Restsharp ile apiye istek atılır.
            var restClient = new RestClient("https://rickandmortyapi.com/api");
            var restRequest = new RestRequest("character");
            var response= restClient.ExecuteGet(restRequest);


            var karakterResults = JsonConvert.DeserializeObject<KarakterResult>(response.Content);
            return karakterResults.results;
        }
    }
}
