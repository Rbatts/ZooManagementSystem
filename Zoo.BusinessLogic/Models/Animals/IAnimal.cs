﻿namespace Zoo.BusinessLogic.Models.Animals
{
    public interface IAnimal
    {
        void Food();
        bool IsHungry();
        bool NeedsMucking();
    }
}