using Ministranci.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ministranci.Builder
{
    public class DailyHolyMassCreator
    {
        public DateTime BeginDate { get; private set; }

        public DailyHolyMassCreator(DateTime begindate)
        {
            BeginDate = begindate;
        }

        public List<Day> GetWeekHolyMassShifts(Dictionary<int, List<HolyMass>> daysWithHolyMassDictionary)
        {
            var dayList = new List<Day>();

            for (int i = 0; i < daysWithHolyMassDictionary.Count; i++)
            {
                dayList.Add(new Day { Date= BeginDate.AddDays(i),HolyMassList = daysWithHolyMassDictionary[i] });
            }

            return dayList;
        }
    }
}