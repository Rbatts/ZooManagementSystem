using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zoo.BusinessLogic.Models;
using Zoo.BusinessLogic.Models.Animals;

namespace Zoo.BusinessLogic.Services
{
  public class GroomingScheduler
  {
    private static GroomingScheduler instance;

    public static GroomingScheduler Instance
    {
      get
      {
        if (instance == null)
        {
          instance = new GroomingScheduler();
        }

        return instance;
      }
    }

    private GroomingScheduler()
    {
    }

    public void AssignJobs(IEnumerable<IKeeper> keepers)
    {
      foreach (var keeper in keepers)
      {
          foreach (var animal in keeper.GetResponsibleAnimals<ICanBeGroomed>())
          {
              if (animal.NeedsGrooming())
              {
                  keeper.GroomAnimal(animal);
              }
          }
      }
    }
  }
}