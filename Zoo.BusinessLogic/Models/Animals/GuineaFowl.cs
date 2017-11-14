using System;

namespace Zoo.BusinessLogic.Models.Animals
{
    public class GuineaFowl : Animal, ICanBeGroomed, ISmallAnimal
    {
        private DateTime lastGroomed;

        public GuineaFowl(DateTime dateOfBirth) : base(dateOfBirth)
        {
        }

        public override void Food()
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
            return base.ToString() + $"   Last Groomed {lastGroomed}\n\n";
        }
    }
}