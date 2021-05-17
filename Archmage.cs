// Archmage.cs
using System;

namespace MagicalInheritance
{
  class Archmage : Mage {
    public Archmage (string Title) : base (Title) {

    }
    //method
    public override Storm CastRainStorm() {
      Storm archmage = new Storm("rain", true, Title);
      return archmage;
    }

    public Storm CastLightningStorm() {
      Storm lightning = new Storm("lightning", true, Title);
      return lightning;
    }
  }
}
