using System.Globalization;

namespace WebUtils.Convertors;

public static class Convertor
{
    public static string ConvertDateTimeToShamsi(DateTime dateTime)
    {
        var persianCal = new PersianCalendar();

        var day = persianCal.GetDayOfMonth(dateTime);
        var month = persianCal.GetMonth(dateTime);
        var year = persianCal.GetYear(dateTime);

        return string.Format(
            "{0}/{1}/{2}",
            year,
            month,
            day
        );
    }
}
