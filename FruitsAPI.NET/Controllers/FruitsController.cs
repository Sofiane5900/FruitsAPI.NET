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

            // Liste de mes fruits.
            List<Fruits> listeFruits = new List<Fruits>();
            listeFruits.Add(Pomme);
            listeFruits.Add(Banane);
            listeFruits.Add(Fraise);
            listeFruits.Add(Orange);
            listeFruits.Add(Raisin);



        }
    }
}
