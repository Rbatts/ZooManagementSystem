using System.Collections.Generic;
using System.Linq;
using Zoo.BusinessLogic.Models.Animals;

namespace Zoo.BusinessLogic.Models
{
    public interface IKeeper
    {
        IEnumerable<T> GetResponsibleAnimals<T>();

        void FeedAnimal(Animal animalToFeed);

        void GroomAnimal(ICanBeGroomed animalToGroom);

        void MuckAnimal(ICanBeMucked animalToMucked);
    }

    public interface IKeeper<in TAnimal> : IKeeper where TAnimal : IAnimal
    {
        void StartLookingAfter(TAnimal newAnimal);
    }

    public class Keeper<TAnimal> : IKeeper<TAnimal> where TAnimal : IAnimal
    {
        public List<TAnimal> Animals;

        public Keeper(IEnumerable<TAnimal> animals)
        {
            this.Animals = new List<TAnimal>(animals);
        }

        public IEnumerable<T> GetResponsibleAnimals<T>()
        {
            return Animals.OfType<T>();
        }

        public void FeedAnimal(Animal animalToFeed)
        {
            animalToFeed.Food();
        }
        public void MuckAnimal(ICanBeMucked animalToMucked)
        {
            animalToMucked.Muck();
        }

        public void GroomAnimal(ICanBeGroomed animalToGroom)
        {
            animalToGroom.Groom();
        }

        public void StartLookingAfter(TAnimal newAnimal)
        {
            Animals.Add(newAnimal);
        }
    }
}