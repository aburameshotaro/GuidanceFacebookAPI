using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuidanceFacebookAPI
{
    internal class FileReader
    {
        public static string GuidanceForGivenDate(int month, int day)
        {
            string text = File.ReadAllText($"porady/porada{month:00}{day:00}.txt");
            return text;
        }
    }
}
