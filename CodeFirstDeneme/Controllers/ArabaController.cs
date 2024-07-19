using CodeFirstDeneme.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstDeneme.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArabaController : ControllerBase
    {

        private readonly ArabaContext arabaaContext;

        public ArabaController(ArabaContext arabaContext)
        {
            this.arabaaContext = arabaContext;
        }

        [HttpGet]
        [Route("GetAraba")]
        public List<Araba> GetAraba()
        {
            return arabaaContext.Araba.ToList();
        }

        [HttpPost]
        [Route("AddAraba")]
        public string AddAraba(Araba araba)
        {
            string response = string.Empty;
            arabaaContext.Araba.Add(araba);
            arabaaContext.SaveChanges();
            return "Başarıyla Kaydedildi";
        }
    }
}
