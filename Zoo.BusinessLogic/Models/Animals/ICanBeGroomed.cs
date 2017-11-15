namespace Zoo.BusinessLogic.Models.Animals
{
  public interface ICanBeGroomed
  {
      void Groom();
      bool NeedsGrooming();
  }
}