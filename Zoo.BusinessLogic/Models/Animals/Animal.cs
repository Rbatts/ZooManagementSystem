using System;

namespace Zoo.BusinessLogic.Models.Animals
{
    public abstract class Animal : IAnimal
    {
        private readonly DateTime dateOfBirth;
        private DateTime lastFed;
        private DateTime lastMucked;
        private DateTime lastGroomed;

        protected Animal(DateTime dateOfBirth)
        {
            this.dateOfBirth = dateOfBirth;
        }

        public TimeSpan Age
        {
            get { return DateTime.Today - dateOfBirth; }
        }

        public DateTime LastFed
        {
            get { return lastFed; }
        }

        public virtual void Food()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"<munch, munch> {GetType().Name}");
            Console.ResetColor();
            lastFed = DateTime.Now;

        }

        public bool NeedsMucking()
        {
            return (DateTime.Now - lastMucked).TotalSeconds > Config.MuckingFrequency;
        }
        public bool IsHungry()
        {
            return (DateTime.Now - lastFed).TotalSeconds > Config.FeedingFrequency;
        }

        public bool NeedsGrooming()
        {
            return (DateTime.Now - lastGroomed).TotalSeconds > Config.GroomingFrequency;
        }

        public void Groom()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"<Groomed> {GetType().Name}");
            Console.ResetColor();
            lastGroomed = DateTime.Now;
        }

        public override string ToString()
        {
            var isAnimal = this is IAnimal;
            var isMucked = this is ICanBeMucked;
            var isGroomed = this is ICanBeGroomed;

            var result = $"{this.GetType().Name}";

            if (isAnimal)
            {
                result += $"  last fed {this.lastFed}";
            }
            if (isGroomed)
            {
                result += $"    Last Groomed {this.lastGroomed}";
            }
            if (isMucked)
            {
                result += $"    Last Mucked {this.lastMucked}";
            }

            return result;
        }

        public virtual void Muck()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"<Mucked> {GetType().Name}");
            Console.ResetColor();
            lastMucked = DateTime.Now;
        }
    }
}