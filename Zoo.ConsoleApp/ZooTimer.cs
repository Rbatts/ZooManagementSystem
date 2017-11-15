using System;
using System.Threading;

namespace Zoo.ConsoleApp
{
  public class ZooTimer
  {
    public event Action Tick;

    public void Run()
    {
      while (true)
      {
        Tick?.Invoke();

        Thread.Sleep(1000);
      }
    }
  }
}