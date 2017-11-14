using System;

namespace Zoo.BusinessLogic.Models.Animals
{
  public class Rabbit : Animal, ICanBeGroomed, ISmallAnimal
  {
    private DateTime lastGroomed;

    public Rabbit(DateTime dateOfBirth) : base(dateOfBirth)
    {
    }

    public void Feed()
    {
      Console.WriteLine("<Munch, munch>");
      base.Food();
    }

    public void Groom()
    {
      lastGroomed = DateTime.Now;
    }

    public override string ToString()
    {
      return base.ToString() + $"  Last Groomed {lastGroomed}";
    }
  }
}