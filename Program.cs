using System.Text;
using SuperHeroesApp.Models;

var canFly = new SuperPower();
canFly.Name = "Fly";
canFly.Description = "Has the ability to fly and plane in the air";
canFly.level = (int)PowerLevel.LevelTwo;

var superStrength = new SuperPower();
superStrength.Name = "Superhuman Strength";
superStrength.Description = "Has super strngth, can lift more than 1tons";
superStrength.level = (int)PowerLevel.LevelTwo;

var Intelect = new SuperPower();
Intelect.Name = "Genius-level intellect";
Intelect.Description = "Has an IQ of over 250";
Intelect.level = (int)PowerLevel.LevelTwo;

var batman = new SuperHeroe();
batman.Id = 1;
batman.Name = "Batman";
batman.secretIdentity = "Bruce Wayne";
batman.City = "Gotham City";
batman.Fly = false;

List<SuperPower> BatmanSuperPower = new List<SuperPower>();
BatmanSuperPower.Add(Intelect);
BatmanSuperPower.Add(superStrength);
batman.SuperPower = BatmanSuperPower;
batman.UseSupoerPower();


var superman = new SuperHeroe();
superman.Id = 2;
superman.Name = "Superman    ";
superman.secretIdentity = "Clark Kent";
superman.City = "metropolis city";
superman.Fly = true;

List<SuperPower> SupermanSuperPower = new List<SuperPower>();
SupermanSuperPower.Add(canFly);
SupermanSuperPower.Add(superStrength);
superman.SuperPower = SupermanSuperPower;
string resultSuperPower = superman.UseSupoerPower();
Console.WriteLine(resultSuperPower);

enum PowerLevel
{
    LevelOne = 1,
    LevelTwo = 2,
    LevelTrhee = 3
}