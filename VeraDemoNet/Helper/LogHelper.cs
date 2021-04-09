namespace VeraDemoNet.Helper
{
    public static class LogHelper
    {
        public static string ToSafeLogMessage(this string value)
        {
            var maxLength = 100;
            if (value.Length > maxLength)
            {
                value = value.Substring(0, maxLength - 3) + "...";
            }
            return value.Replace("\n", "").Replace("\r", "");
        }
    }
}