using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.BusinessLogic.Services
{
    interface IScheduler
    {
        IEnumerable AnimalThatCanBeGroomed { get; }
        string SubjectArea { get; set; }

        void AddClassTitle(string title);
        void RemoveClassTitle(string title);
    }
}
