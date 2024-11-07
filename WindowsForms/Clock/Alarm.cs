using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    public class Alarm:IComparable
    {
        public static readonly string[] WeekDayNames = new string [7]{"Пн","Вт","Ср","Чт","Пт","Суб","Вс"};
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public bool[] Weekdays { get; private set; }
        public string Filename { get; set; } = "";

        public Alarm()
        {
            Weekdays = new bool[7];
        }
        public Alarm(string alarm_string)
        {
            string[] values = alarm_string.Split(',');
            Date = new DateTime(Convert.ToInt64(values[0]));
            Time = new DateTime(Convert.ToInt64(values[1]));
            Weekdays = WeekDaysFromString(values[2]);
            Filename = values[3];
        }
        bool[] WeekDaysFromString(string week_string)
        {
            bool[] weekdays = new bool[7];
            if(week_string.Contains("Пн")) weekdays[0] = true;
            if(week_string.Contains("Вт")) weekdays[1] = true;
            if(week_string.Contains("Ср")) weekdays[2] = true;
            if(week_string.Contains("Чт")) weekdays[3] = true;
            if(week_string.Contains("Пт")) weekdays[4] = true;
            if(week_string.Contains("Суб")) weekdays[5] = true;
            if(week_string.Contains("Вс")) weekdays[6] = true;
            return weekdays;
        }
        string WeekDaysToString()
        {
            string days = "";
            for (int i = 0; i < Weekdays.Length; i++)
            {
                if (Weekdays[i])days += WeekDayNames[i];
                //Console.Write(Weekdays[i]+"\t");
            }
            //Console.WriteLine();
            return days;
        }
        public override string ToString()
        {
            string result = "";
            if (Date != null && Date != DateTime.MinValue) result += $"{Date},";
            result += $"{Time.TimeOfDay}, {WeekDaysToString()}, {Filename.Split('\\').Last()}";
            return result;

        }
        public string ToFileString()  //чтобы сгенерировать 
        {
            string result = "";
            //if(Date == DateTime.MinValue)result+=Date
            result += $"{Date.Ticks},";
            result += $"{Time.Ticks},";
            result += $"{WeekDaysToString()},";
            result += $"{Filename}";
            return result;
        }
        public int CompareTo(object other)
        {
            return this.Time.CompareTo((other as Alarm).Time);
            //Опретор "AS" преобразует значение слева в тип справа
        }
    }
}
