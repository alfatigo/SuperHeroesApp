
var superman = new SuperHeroe();


superman.Id = 1;
superman.Name = "Batman";
superman.secretIdentity = "Bruce Wayne";
superman.City = "Gotrham City";
superman .Fly = false;
superman.Abilities = new[] {"Smart","Rich","superior Technology"};
class SuperHeroe
{

    public int Id;
    public string Name;
    public string secretIdentity;
    public string City;
    public string[] Abilities;
    public bool Fly;

}