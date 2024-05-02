using RikendMorty.Models;
using RikendMorty.Repository;

namespace RikendMorty.Services
{
    public interface IRikandMortyService
    {
        public List<Karakter> GetKarakters();
    }
    public class RikandMortyService:IRikandMortyService
    {
        public IRikandMortyRepository _repository;

        public RikandMortyService(IRikandMortyRepository repository)
        {
            _repository = repository;
        }

        public List<Karakter> GetKarakters()
        {
            return _repository.GetKarakters(); 
        }
    }
  

}
