namespace AdhocManager
{
    public static class StringUtils
    {
        public static string UppercaseFirst(string str)
        {
            if (str == null) return null;
            if (str.Length <= 1) return str.ToUpper();

            var first = char.ToUpper(str[0]);
            var remaining = str.Substring(1).ToLower();
            return first + remaining;
        }

        public static string ReadableFileSize(double size, int unit = 0, bool isBytes = true)
        {
            string[] units = {"B", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB"};

            var divider = isBytes ? 1024 : 1000;

            while (size >= divider)
            {
                size /= divider;
                ++unit;
            }

            return string.Format("{0:0.#} {1}", size, isBytes ? units[unit] : UppercaseFirst(units[unit]));
        }
    }
}