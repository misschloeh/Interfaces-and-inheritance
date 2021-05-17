// Storm.cs
using System;

namespace MagicalInheritance
{
  class Storm {
    public string Essence {get; private set;}
    public bool IsStrong {get; private set;}
    public string Caster {get; private set;}

    //constructor
    public Storm (string Essence, bool IsStrong, string Caster) {
      this.Essence = Essence;
      this.IsStrong = IsStrong;
      this.Caster = Caster;
    }

    //methods
    public string Announce() {
      if (!IsStrong) { 
        return $"{Caster} cast a weak {Essence} storm!";
      } else {
        return $"{Caster} cast a strong {Essence} storm!";
      }
    }
  }
}
