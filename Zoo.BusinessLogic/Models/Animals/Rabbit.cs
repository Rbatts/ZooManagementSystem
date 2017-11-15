using System;

namespace Zoo.BusinessLogic.Models.Animals
{
  public class Rabbit : Animal, ISmallAnimal, ICanBeGroomed
  {
    public Rabbit(DateTime dateOfBirth) : base(dateOfBirth)
    {
    }
  }
}