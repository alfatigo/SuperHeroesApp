using System.Text;

namespace SuperHeroesApp.Models
{
    internal abstract class Heroe
    {
        public abstract string Name { get; set; }
        public abstract string SaveTheWorld();
        public abstract string SaveTheEarth();
    }
}