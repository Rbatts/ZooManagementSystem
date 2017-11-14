namespace Zoo.BusinessLogic.Models.Animals
{
    public interface ICanBeMucked
    {
        void Muck();
        bool NeedsMucking();
    }
}