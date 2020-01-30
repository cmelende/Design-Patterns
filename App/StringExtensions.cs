namespace App
{
    public static class StringExtensions
    {
        public static string PadBoth(this string s, int amount, char c)
        {
            var filler = new string(c, amount);
            return $"{filler}{s}{filler}";
        }
    }
}