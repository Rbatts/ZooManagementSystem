using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;
using System.Threading;
using System.Threading.Tasks;
using Zoo.BusinessLogic.Models;
using Zoo.BusinessLogic.Models.Animals;

namespace Zoo.BusinessLogic.Services
{
    public class FeedingScheduler
    {
        private static FeedingScheduler instance;

        public static FeedingScheduler Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FeedingScheduler();
                }

                return instance;
            }
        }

        private FeedingScheduler()
        {
        }

        public void AssignJobs(IEnumerable<IKeeper> keepers)
        {
            foreach (var keeper in keepers)
            {
                foreach (var animal in keeper.GetResponsibleAnimals<Animal>())
                {
                    if (animal.IsHungry())
                    {
                        keeper.FeedAnimal(animal);
                    }
                }
            }
        }
    }
}