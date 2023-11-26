
var batman = new SuperHeroe();
batman.Id = 1;
batman.Name = "Batman";
batman.secretIdentity = "Bruce Wayne";
batman.City = "Gotham City";
batman .Fly = false;
batman.Abilities = new[] {"Intellect","Fighting skills","Wealth", "Martial arts skills"};

var superman = new SuperHeroe();
superman.Id = 2;
superman.Name = "Superman";
superman.secretIdentity ="Clark Kent";
superman.City = "metropolis city";
superman.Fly = true;
superman.Abilities = new[] {"Superhuman Strength","X-ray Vision", "Super-Speed", "Nigh-Invulnerability"};
class SuperHeroe
{

    public int Id;
    public string Name;
    public string secretIdentity;
    public string City;
    public string[] Abilities;
    public bool Fly;

}

