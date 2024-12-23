using System.ComponentModel.DataAnnotations.Schema;

namespace FruitsAPI.NET
{
    public class Fruits
    {
        private string _nom;
        private string _description;
        private string _saison;

        public string nom { get => _nom; set => _nom = value; }
        public string description { get => _description; set => _description = value; }
        public string saison { get => _saison; set => _saison = value; }



       public Fruits(string nom, string description)
        {
            _nom = nom;
            _description = description;
            _saison = saison;
        }
    }
}
