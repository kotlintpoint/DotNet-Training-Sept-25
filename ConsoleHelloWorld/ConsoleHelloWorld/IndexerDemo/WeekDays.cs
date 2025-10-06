using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHelloWorld.IndexerDemo
{
    enum Days { 
        SUNDAY, MONDAY, TUESDAY, WEDNESDAY, FRIDAY, SATURDAY
    }
    internal class WeekDays
    {
        private Days[] days = new Days[7];

        // Indexer
        public Days this[int index]
        {
            get
            {
                if (index < 0 || index >= days.Length)
                    throw new IndexOutOfRangeException("Invalid index");
                return days[index];
            }
            set
            {
                if (index < 0 || index >= days.Length)
                    throw new IndexOutOfRangeException("Invalid index");
                days[index] = value;
            }
        }
    }
}
