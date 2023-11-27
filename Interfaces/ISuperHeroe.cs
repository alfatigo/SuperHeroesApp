using System;
using System.Collections.Generic;

namespace SuperHeroesApp.Interfaces
{
    internal interface ISuperHeroe
    {
        int Id { get; set; }
        string Name { get; set; }
        string secretIdentity {get; set; }
    }
} 