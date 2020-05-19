
using System;

namespace HRDay11_2DArrays
{
    class Program
    {

        static void Main(string[] args)
        {
            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }
            int max = 0;
            int sum = 0;
            for (int i = 0;i < 4; i++)
            {
                for (int j = 0; j < arr[i].Length - 2; j++)
                {
                    sum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] + arr[i + 1][j + 1] + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
                    if ((i== 0 && j == 0) || max < sum)
                    {
                        max = sum;
                    }
                }
            }
            Console.WriteLine(max) ;
        }
    }
}
