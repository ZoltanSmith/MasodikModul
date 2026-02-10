namespace KozosResz.extensions
{
    public static class DateExtension
    {
        public static string FormatDate(this DateTime date)
        {
            if (date.Hour == 0 && date.Minute == 0 && date.Second == 0)
                return date.ToString("yyyy-MM-dd");
            else
                return date.ToString();
        }

    }
}
