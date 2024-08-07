using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Management_Company.ConferenceScheduleExample
{
    public interface ISchedulePrototype
    {
        ISchedulePrototype Clone();
    }
}
