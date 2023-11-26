
var canFly = new SuperPower();
canFly.Name = "Fly"; 
canFly.Description = "Has the ability to fly and plane in the air";
canFly.level = PowerLevel.LevelTwo;

var superStrength = new SuperPower();
superStrength.Name = "Superhuman Strength";
superStrength.Description = "Has super strngth, can lift more than 1tons";
superStrength.level = PowerLevel.LevelTwo;

var Intelect = new SuperPower();
Intelect.Name = "Genius-level intellect";
Intelect.Description = "Has an IQ of over 250";
Intelect.level = PowerLevel.LevelTwo;

var batman = new SuperHeroe();
batman.Id = 1;
batman.Name = "Batman";
batman.secretIdentity = "Bruce Wayne";
batman.City = "Gotham City";
batman .Fly = false;

List<SuperPower> BatmanSuperPower  = new List<SuperPower>();
BatmanSuperPower.Add(Intelect);
BatmanSuperPower.Add(superStrength);

var superman = new SuperHeroe();
superman.Id = 2;
superman.Name = "Superman";
superman.secretIdentity ="Clark Kent";
superman.City = "metropolis city";
superman.Fly = true;

List<SuperPower>  SupermanSuperPower = new List<SuperPower>();
SupermanSuperPower.Add(canFly);
SupermanSuperPower.Add(superStrength);

superman.SuperPower = SupermanSuperPower;
class SuperHeroe
{

    public int Id;
    public string Name;
    public string secretIdentity;
    public string City;
    public List<SuperPower> SuperPower;
    public bool Fly;

}

class SuperPower
{
    public string Name;
    public string Description;
    public int level;
}

enum PowerLevel
{
    LevelOne, 
    LevelTwo, 
    LevelTrhee
}