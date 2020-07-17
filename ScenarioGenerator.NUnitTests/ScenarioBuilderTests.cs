using System.Collections.Generic;
using NUnit.Framework;

namespace ScenarioGenerator.NUnitTests
{
    public class Tests
    {
        private IEnumerable<string> expected
        {
            get
            {
                yield return "item1,itemA";
                yield return "item1,itemB";
                yield return "item1,itemC";
                yield return "item2,itemA";
                yield return "item2,itemB";
                yield return "item2,itemC";
                yield return "item3,itemA";
                yield return "item3,itemB";
                yield return "item3,itemC";
            }
        }

        [Test]
        public void Test1()
        {
            // Arrange
            var list1 = new List<string> {
                "item1",
                "item2",
                "item3",
            };

            var list2 = new List<string> {
                "itemA",
                "itemB",
                "itemC",
            };

            IEnumerable<IEnumerable<string>> listOfLists = new List<List<string>> { list1, list2 };

            // Act
            var result = listOfLists.Combine();

            // Assert
            CollectionAssert.AreEquivalent(expected, result);
        }
    }
}