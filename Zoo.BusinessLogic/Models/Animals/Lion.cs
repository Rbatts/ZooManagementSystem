using System;

namespace Zoo.BusinessLogic.Models.Animals
{
  public class Lion : Animal, ILargeAnimal, ICanBeMucked
  {
        public Lion(DateTime dateOfBirth) : base(dateOfBirth)
        {
        }
  }
}
