using System.Text;


namespace SuperHeroesApp.Models{
   internal class  AntiHeroe : SuperHeroe{

    public string DoAntiheroeThing(string action){

        return $"Anti Heroe {secretIdentity}: {action}";
    }


    }
}
