namespace ConsoleAppTestingpProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    
    public class Sorter
    {
        public  char[] Sort(char[] unsorted)
        {
            for (int i = 0; i < unsorted.Length - 1; i++)

            {
                for (int j = 0; j < unsorted.Length - i - 1; j++)
                {
                    int l = (int)unsorted[j];
                    int n = (int)unsorted[j + 1];

                    if (l > n)
                    {
                        char temp = unsorted[j];
                        unsorted[j] = unsorted[j + 1];
                        unsorted[j + 1] = temp;
                    }
                }

            }
            return unsorted;
        }


        public int[] Sorting(int[] unsortedd)
        {
            
            for (int i = 0; i < unsortedd.Length - 1; i++)

            {
                for (int j = 0; j < unsortedd.Length - i - 1; j++)
                {

                    if (unsortedd[j] > unsortedd[j + 1])
                    {
                        int temp = unsortedd[j];
                        unsortedd[j] = unsortedd[j + 1];
                        unsortedd[j + 1] = temp;
                    }
                }

            }
            return unsortedd;


        }
        public string SortString(string[] word)
        {
            string value = Console.ReadLine();
            var letters = value.ToCharArray();
            Array.Sort(letters);
            string result = new string(letters);
           return  result;
        }
    }    
}