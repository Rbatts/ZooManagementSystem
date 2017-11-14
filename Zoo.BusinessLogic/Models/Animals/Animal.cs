using System;

namespace Zoo.BusinessLogic.Models.Animals
{
    public abstract class Animal : IAnimal
    {
        private readonly DateTime dateOfBirth;
        private DateTime lastFed;
        private DateTime lastMucked;

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

        public override string ToString()
        {
            return $"\n{GetType().Name}, last fed {lastFed}";
        }

        public virtual void Muck()
        {
            lastMucked = DateTime.Now;
        }
    }
}