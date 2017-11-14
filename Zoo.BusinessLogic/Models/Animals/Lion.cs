using System;

namespace Zoo.BusinessLogic.Models.Animals
{
  public class Lion : Animal, ILargeAnimal, ICanBeMucked
  {
        private DateTime lastMucked;

        public Lion(DateTime dateOfBirth) : base(dateOfBirth)
        {
        }
      public void Muck()
      {
          lastMucked = DateTime.Now;
      }
      public override string ToString()
      {
          return base.ToString() + $"   Last Mucked {lastMucked}";
      }
      void ICanBeMucked.Muck()
      {
          lastMucked = DateTime.Now;
      }

      bool ICanBeMucked.NeedsMucking()
      {
          throw new NotImplementedException();
      }
  }
}
