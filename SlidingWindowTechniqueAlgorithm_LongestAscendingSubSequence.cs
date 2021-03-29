//2, 4, 7, 1, 14, 3, 5,   9, 23, 72, 14, 62, 10, 8, 103, 17, 11, 31, 50, 45, 101
using System;
//2, 4, 7, 1, 14, 3, 5,   9,

//PRINT longest subsequence in a given set of integers such that they are in ascending order.
//Slidingwindow technique is used in this algorithm

public class Test
{
    public static void Main(string[] args)
    {
        int[] arr = { 2, 4, 7, 1, 14, 3, 5, 9, 23, 72, 14, 62, 10, 8, 103, 17, 11, 31, 50, 45, 101 };



        int start = 0, end = 0, prev = arr[0], resultE = 0, resultS = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] >= prev)
            {
                if (end - start > resultE - resultS)
                {
                    resultS = start;
                    resultE = end + 1;
                }

                end++;
            }
            else
            {
                
                start = i;
                end = i;
            }
            prev = arr[i];
        }
        for (int i = resultS; i <= resultE; i++)
            Console.Write(arr[i] + " ");
    }
}
