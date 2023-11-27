using System.Security.Principal;
using System.Text;

namespace SuperHeroesApp.Models
{

    class SuperHeroe : Heroe
    {

        private string _Name;
        public int Id;
        public override string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value.Trim();
            }
        }

        public string SecretIdentity
        {
            get
            {
                return $"{Name} ({secretIdentity})";
            }
        }

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
                sb.AppendLine($"The super Heroe {SecretIdentity} is using the power: {power.Name}");
            }
            return sb.ToString();
        }

        public override string SaveTheWorld()
        {
            return $"{SecretIdentity} saved the World!";
        }
        public override string SaveTheEarth()
        {
            //return base.SaveTheEarth();
            return $"{SecretIdentity} saved The Earth!";
        }

    }
}