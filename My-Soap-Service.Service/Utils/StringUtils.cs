namespace My_Soap_Service.Service.Utils
{
    public static class StringUtils
    {
        public static string Unformat(string str)
        {
            return str
                .Trim()
                .Replace(".", "")
                .Replace("-", "")
                .Replace("/", "");
        }
    }
}
