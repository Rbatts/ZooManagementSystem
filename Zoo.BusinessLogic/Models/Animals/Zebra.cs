using System;

namespace Zoo.BusinessLogic.Models.Animals
{
  public class Zebra : Animal, ILargeAnimal, ICanBeMucked, ICanBeGroomed
  {
    public Zebra(DateTime dateOfBirth) : base(dateOfBirth)
    {

    }
  }
}