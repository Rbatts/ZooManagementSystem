using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.BusinessLogic.Models;
using Zoo.BusinessLogic.Models.Animals;

namespace Zoo.BusinessLogic.Services
{
    public class MuckingScheduler
    {
        private static MuckingScheduler instance;

        public static MuckingScheduler Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MuckingScheduler();
                }

                return instance;
            }
        }

        private MuckingScheduler()
        {
        }

        public void AssignJobs(IEnumerable<IKeeper> keepers)
        {
            foreach (var keeper in keepers)
            {
                foreach (var animal in keeper.GetResponsibleAnimals<ICanBeMucked>())
                {
                    if (animal.NeedsMucking())
                    {
                        keeper.MuckAnimal(animal);
                    }
                }
            }
        }
    }
    
}

