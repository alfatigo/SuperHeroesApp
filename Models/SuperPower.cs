
namespace SuperHeroesApp.Models
{
    internal class SuperPower
    {
        public string Name;
        public string Description;
        public int level;

        public SuperPower()
        {

            level = (int)PowerLevel.LevelOne;

        }
    }
}
