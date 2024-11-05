using System;

namespace Exam
{
    public class DateClass
    {
        public int Year { get; private set; }
        public int Month { get; private set; }
        public int Day { get; private set; }

        public DateClass(int year, int month, int day)
        {
            if (IsValidDate(year, month, day))
            {
                Year = year;
                Month = month;
                Day = day;
            }
            else
            {
                throw new ArgumentException("Invalid date");
            }
        }

        public void SetDate(int year, int month, int day)
        {
            if (IsValidDate(year, month, day))
            {
                Year = year;
                Month = month;
                Day = day;
            }
            else
            {
                throw new ArgumentException("Invalid date");
            }
        }

        public void AddDays(int days)
        {
            DateTime currentDate = new DateTime(Year, Month, Day).AddDays(days);
            Year = currentDate.Year;
            Month = currentDate.Month;
            Day = currentDate.Day;
        }

        public void AddMonths(int months)
        {
            DateTime currentDate = new DateTime(Year, Month, Day).AddMonths(months);
            Year = currentDate.Year;
            Month = currentDate.Month;
            Day = currentDate.Day;
        }

        public void AddYears(int years)
        {
            DateTime currentDate = new DateTime(Year, Month, Day).AddYears(years);
            Year = currentDate.Year;
            Month = currentDate.Month;
            Day = currentDate.Day;
        }

        public override string ToString()
        {
            return $"{Day:D2}-{Month:D2}-{Year}";
        }

        private bool IsValidDate(int year, int month, int day)
        {
            return year > 0 && month > 0 && month <= 12 && day > 0 && day <= DateTime.DaysInMonth(year, month);
        }
    }

    public class DateWithDayOfWeek : DateClass
    {
        public DateWithDayOfWeek(int year, int month, int day) : base(year, month, day) { }

        public DayOfWeek GetDayOfWeek()
        {
            DateTime date = new DateTime(Year, Month, Day);
            return date.DayOfWeek;
        }
    }
}
