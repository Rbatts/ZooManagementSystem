using System;

namespace Zoo.BusinessLogic.Models.Animals
{
    public class Guinea : Animal, ISmallAnimal, ICanBeGroomed
    {
        public Guinea(DateTime dateOfBirth) : base(dateOfBirth)
        {
        }
    }
}