/*
    Name:Garima Dubey
    Deparment:Business Analytics & Information Systems
*/
public class Program
    {
        static void Main(string[] args)
        {
            // Calling the Bubble Sort  Function
            int[] returnedArray = BubbleSort([5,72,3,14,7,1]);

            // Printing the returned array
            foreach (int num in returnedArray)
            {
                Console.WriteLine(num + " ");
            }
        }
    
        // bubbleSort
         static int[] BubbleSort(int[] array_to_be_sorted)
        {
            for (int i = 0;i< array_to_be_sorted.Length; i++)
            {
                for(int j = 0; j < array_to_be_sorted.Length - 1-i; j++)
                {
                    if (array_to_be_sorted[j] > array_to_be_sorted[j+1] )
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

