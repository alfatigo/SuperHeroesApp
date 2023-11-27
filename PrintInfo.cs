using SuperHeroesApp.Interfaces;

namespace SuperHeroesApp
{
    internal class PrintInfo
    {
        public void PrintSuperHeroe(ISuperHeroe superHeroe)
        {
            Console.WriteLine($"ID: {superHeroe.Id}");
            Console.WriteLine($"Name: {superHeroe.Name}");
            Console.WriteLine($"Secret Identity: {superHeroe.secretIdentity}");
        }
    }
}