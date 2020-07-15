using System.Collections.Generic;
using System.Linq;

namespace ScenarioGenerator
{
    public static class ScenarioBuilder
    {
        public static IEnumerable<string> Combine(this IEnumerable<IEnumerable<string>> listOfLists)
        {
            IEnumerable<string> combinations = new List<string> { null };
            listOfLists.ToList().ForEach(scenario => combinations = combinations.SelectMany(x => scenario.Select(y => x + y + ",")));
            return combinations.Formatted();
        }

        private static IEnumerable<string> Formatted(this IEnumerable<string> combinations)
        {
            return combinations.Select(item => item.TrimEnd(','));
        }
    }
}
