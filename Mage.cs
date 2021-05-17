// Mage.cs
using System;

namespace MagicalInheritance
{
  class Mage : Pupil {
    public Mage(string Title) : base (Title) {
      
    }
    //methods
    public virtual Storm CastRainStorm() {
      Storm rain = new Storm("rain", false, Title);
      return rain;
    }
  }
}
