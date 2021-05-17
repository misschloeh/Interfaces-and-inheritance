using System;

namespace MagicalInheritance
{
  class Program
  {
    static void Main(string[] args)
    {
     Storm s = new Storm("wind", false,"Zul'rajas");
     s.Announce();
     Console.WriteLine(s.Announce()); 
     //pupil
     Pupil p = new Pupil("Mezil-kree");
      Storm pupilAnnounce = p.CastWindStorm();
     pupilAnnounce.Announce(); 
     Console.WriteLine(pupilAnnounce.Announce());       
     //mage
     Mage m = new Mage("Gul'dan");
     Storm mageAnnounce = m.CastRainStorm();
     Console.WriteLine(mageAnnounce.Announce());
     //archmage
     Archmage a = new Archmage("Nielas Aran");
     Storm aRain = a.CastRainStorm();
     Storm aLight = a.CastLightningStorm();
     Console.WriteLine(aRain.Announce());
     Console.WriteLine(aLight.Announce());
    }
  }
}