using System.Text;

namespace SuperHeroesApp.Models
{

    class SuperHeroe
    {

        public int Id;
        public string Name;
        public string secretIdentity;
        public string City;
        public List<SuperPower> SuperPower;
        public bool Fly;

        public SuperHeroe()
        {

            Id = 1;
            SuperPower = new List<SuperPower>();
            Fly = false;

        }
        public string UseSupoerPower()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var power in SuperPower)
            {
                sb.AppendLine($"The super Heroe {Name} is using the power: {power.Name}");
            }
            return sb.ToString();
        }
    }
}