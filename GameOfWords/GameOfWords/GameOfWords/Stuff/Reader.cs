using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace GameOfWords
{
    public static class Reader
    {
        public static string[] Read(string fileName)
        {
            var result = string.Empty;
            var assembly = Assembly.GetExecutingAssembly();
            var resources = assembly.GetManifestResourceNames();
            var currentResource = resources.FirstOrDefault(x => x.Contains($"{fileName}.txt"));
            if (currentResource != null)
            {
                using (var stream = assembly.GetManifestResourceStream(currentResource))
                {
                    if (stream != null)
                    {
                        using (StreamReader reader = new StreamReader(stream))
                        {
                            result = reader.ReadToEnd();
                        }
                    }
                }
            }
            return result.Split(new [] {"\n", "\n\r", "\r\n"}, StringSplitOptions.RemoveEmptyEntries).ToArray();
        }
    }
}
