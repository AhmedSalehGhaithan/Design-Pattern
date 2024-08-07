using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Management_Company.ConferenceScheduleExample
{
    public class ConferenceSchedule : ISchedulePrototype
    {
        public List<string> Sessions { get; set; } = new List<string>();
        public List<string> Speakers { get; set; } = new List<string>();
        public ISchedulePrototype Clone()
        {
            // Deep copying is important here since Lists are reference types.
            return new ConferenceSchedule
            {
                Sessions = new List<string>(this.Sessions),
                Speakers = new List<string>(this.Speakers)
            };
        }
        public void DisplaySchedule()
        {
            Console.WriteLine("Conference Schedule:");
            for (int i = 0; i < Sessions.Count; i++)
            {
                Console.WriteLine($"Session {i + 1}: {Sessions[i]} by {Speakers[i]}");
            }
            Console.WriteLine();
        }
    }
}
