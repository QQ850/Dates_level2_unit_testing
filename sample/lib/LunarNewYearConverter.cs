using System;
using System.Globalization;

public static class LunarNewYearConverter
{
    public static DateTime ConvertToGregorian(int year)
    {
        ChineseLunisolarCalendar calendar = new ChineseLunisolarCalendar();
        DateTime newYearDate = calendar.ToDateTime(year, 1, 1, 0, 0, 0, 0);
        DateTime gregorianDate = newYearDate.AddDays(calendar.GetDaysInMonth(year, 1) - 1);
        return gregorianDate;
    }
}
