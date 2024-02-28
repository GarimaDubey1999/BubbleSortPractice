
    public class Program
    {
        static void Main(string[] args)
        {
            int[] returnedArray = BubbleSort([5,72,3,14,7,1]);

            // Printing the returned array
            foreach (int num in returnedArray)
            {
                Console.WriteLine(num + " ");
            }
        }
    

        public static int[] BubbleSort(int[] array_to_be_sorted)
        {
            for (int i = 0;i< array_to_be_sorted.Length; i++)
            {
                for(int j = 0; j < array_to_be_sorted.Length - 1; j++)
                {
                    if (array_to_be_sorted[j] > array_to_be_sorted[j+1] && j != array_to_be_sorted.Length - 1)
                    {   
                        int temp = array_to_be_sorted[j];
                        array_to_be_sorted[j] = array_to_be_sorted[j + 1];
                        array_to_be_sorted[j + 1] = temp;
                    }
                }
            }

            return array_to_be_sorted;
        }
    }

