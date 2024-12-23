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
            // Je crée des instance de ma classe (objets) Fruits pour peupler ma liste.
            Fruits Pomme = new Fruits("Pomme", "Un fruit croquant, souvent rouge ou vert, riche en fibres et parfait pour les desserts ou à croquer.", "Automne");
            Fruits Banane = new Fruits("Banane", "Un fruit jaune allongé, riche en potassium, idéal pour les sportifs ou en smoothie.", "Toute l'année");
            Fruits Fraise = new Fruits("Fraise", "Un petit fruit rouge en forme de cœur, avec une saveur sucrée-acidulée, souvent utilisé dans les pâtisseries.", "Printems & debut d'été");
            Fruits Orange = new Fruits("Orange", "Un agrume rond à écorce orange, juteux et plein de vitamine C, parfait pour les jus frais.", "Hiver");
            Fruits Raisin = new Fruits("Raisin", "De petites baies sucrées, vertes ou violettes, utilisées pour les vins, jus ou à grignoter nature.", "Automne");

            // Je déclare une liste pour  mes fruits.
            List<Fruits> listeFruits = new List<Fruits>();
            // J'ajoute mes objets Fruits a ma liste.
            listeFruits.Add(Pomme);
            listeFruits.Add(Banane);
            listeFruits.Add(Fraise);
            listeFruits.Add(Orange);
            listeFruits.Add(Raisin);

            //Debug, error & success
            _logger.LogError("Erreur.");
            _logger.LogInformation("Return" + listeFruits.Count() + "elements avec succés.");

            // Je return ma liste pour que la méthode GET puisse récuperer mes données.
            return listeFruits;
        }

        // Je crée une nouvelle route
        [HttpPost(Name = "PostFruits")]
        // Je crée une action de type Post je récupere les valeurs du request Body, je veux un type Fruits
        public IActionResult Post([FromBody] Fruits nouveauFruit)
        {
            // Si mon nouveauFruit est null, alors j'ai une erreur 400
            if (nouveauFruit == null)
            { 
                return BadRequest(); 
            }

            // Return success 200 si tout est OK.
            return Ok(nouveauFruit);
        }
    }
}
