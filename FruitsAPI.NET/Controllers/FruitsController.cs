using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace FruitsAPI.NET.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FruitsController : ControllerBase
    {
     
        private readonly ILogger<FruitsController> _logger;

        public FruitsController(ILogger<FruitsController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetFruits")]
        public IEnumerable<Fruits> Get()
        {
            // Je cr�e des instance de ma classe (objets) Fruits pour peupler ma liste.
            Fruits Pomme = new Fruits("Pomme", "Un fruit croquant, souvent rouge ou vert, riche en fibres et parfait pour les desserts ou � croquer.", "Automne");
            Fruits Banane = new Fruits("Banane", "Un fruit jaune allong�, riche en potassium, id�al pour les sportifs ou en smoothie.", "Toute l'ann�e");
            Fruits Fraise = new Fruits("Fraise", "Un petit fruit rouge en forme de c�ur, avec une saveur sucr�e-acidul�e, souvent utilis� dans les p�tisseries.", "Printems & debut d'�t�");
            Fruits Orange = new Fruits("Orange", "Un agrume rond � �corce orange, juteux et plein de vitamine C, parfait pour les jus frais.", "Hiver");
            Fruits Raisin = new Fruits("Raisin", "De petites baies sucr�es, vertes ou violettes, utilis�es pour les vins, jus ou � grignoter nature.", "Automne");

            // Je d�clare une liste pour  mes fruits.
            List<Fruits> listeFruits = new List<Fruits>();
            // J'ajoute mes objets Fruits a ma liste.
            listeFruits.Add(Pomme);
            listeFruits.Add(Banane);
            listeFruits.Add(Fraise);
            listeFruits.Add(Orange);
            listeFruits.Add(Raisin);

            // Je return ma liste pour que la m�thode GET puisse r�cuperer mes donn�es.
            return listeFruits;



        }
    }
}
