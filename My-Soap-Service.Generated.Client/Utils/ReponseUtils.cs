using System.Linq;

namespace My_Soap_Service.Manual.Client.Utils
{
    public static class ReponseUtils
    {
        public static string Format<T>(T response) where T : class
        {
            var properties = typeof(T).GetProperties();

            return $"{typeof(T).Name} {{ " +
                string.Join(", ", properties.Select(p => $"{p.Name} = {p.GetValue(response)}")) + " }}";
        }
    }
}
