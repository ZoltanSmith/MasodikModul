namespace KozosResz.extensions
{
    public static class StringExtension
    {
        public static bool Empty(this string str, object o = null)
        {
            return String.IsNullOrWhiteSpace(str) || str == "$";
        }

        public static bool IsValidEmail(string email) // belefér
        {
            return email.Contains("@");
        }

    }
}
