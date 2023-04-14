using ConsoleAppTestingpProject;

namespace TestProjectConsoleApp
{
   public class SorterTests
    {
        [TestCase]
        public void Sort()
        {
            Sorter sorter = new Sorter();
            char[] unsorted = { 'b', 'm', 'a' };
            sorter.Sort(unsorted);
            Assert.IsTrue(unsorted[0] == 'a');
        }
        [TestCase]
        public void Sort2()
        {
            Sorter sorter = new Sorter();
            int[] unsorted = { 7, 2, 3 };
            sorter.Sorting(unsorted);
            Assert.IsTrue(unsorted[0] == 2);

        }

        [TestCase]
        public void SortString() 
        {
            Sorter sorter = new Sorter();
            string[] word = { "Beatiful" };
            sorter.SortString(word);
            Assert.IsTrue(word[0]== "a");
        }
    }
}