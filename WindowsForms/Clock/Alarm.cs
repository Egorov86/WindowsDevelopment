using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    public class Alarm
    {
        public static readonly string[] WeekDayNames = new string [7]{"Пн","Вт","Ср","Чт","Пт","Суб","Вс"};
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public bool[] Weekdays { get; private set; } = new bool[7];
        public string Filename { get; set; }

        public Alarm()
        {
            Weekdays = new bool[7];
        }
        string WeekDaysToString()
        {
            string days = "";
            //bool present = false;
            //for (int i = 0; i < Weekdays.Length; i++)
            //{
            //    present = Weekdays[i];
            //    break;
            //}
            //if (!present) return days;
            for (int i = 0; i < Weekdays.Length; i++)
            {
                if (Weekdays[i])days += WeekDayNames[i];
                Console.Write(Weekdays[i]+"\t");
            }
            return days;
        }
        public override string ToString()
        {
            string result = "";
            if (Date != null && Date != DateTime.MinValue) result += $"{Date},";
            result += $"{Time.TimeOfDay}, {WeekDaysToString()}, {Filename.Split('\\').Last()}";
            return result;

        }
    }
}
