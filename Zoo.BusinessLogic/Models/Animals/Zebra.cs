using System;

namespace Zoo.BusinessLogic.Models.Animals
{
  public class Zebra : Animal, ICanBeGroomed, ILargeAnimal, ICanBeMucked
  {
    private DateTime lastGroomed;
    private DateTime lastMucked;

    public Zebra(DateTime dateOfBirth) : base(dateOfBirth)
    {

    }
      public void Muck()
      {
          lastMucked = DateTime.Now;
      }
      void ICanBeMucked.Muck()
      {
          lastMucked = DateTime.Now;
        }

      bool ICanBeMucked.NeedsMucking()
      {
          throw new NotImplementedException();
      }
      public void Groom()
      {
          lastGroomed = DateTime.Now;
      }

    public override string ToString()
    {
      return base.ToString() + $"  Last Groomed {lastGroomed} Last Mucked {lastMucked}";
    }
  }
}