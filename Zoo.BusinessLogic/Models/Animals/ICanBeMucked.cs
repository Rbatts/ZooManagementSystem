using System.Runtime.Serialization.Formatters;

namespace Zoo.BusinessLogic.Models.Animals
{
    public interface ICanBeMucked
    {
        bool NeedsMucking();
        void Muck();
    }
}