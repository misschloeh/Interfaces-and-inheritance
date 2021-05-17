// Pupil.cs
using System;

namespace MagicalInheritance
{
  class Pupil {
    public string Title {get; private set;}

    //constructor
    public Pupil(string Title) {
      this.Title = Title;
    }

    //methods
    public Storm CastWindStorm() {
      Storm pupilStorm = new Storm("wind", false, Title);
      return pupilStorm;
    }
  }
}
