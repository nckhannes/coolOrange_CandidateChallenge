using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Policy;

namespace coolOrange_CandidateChallenge
{
	public class Array
	{



		public static int FindMaxValue(int[] array, int position1, int position2)
		{
			int max = int.MinValue;

			for (int i = Math.Min(position1, position2); i <= Math.Max(position1, position2); i++)
			{
				if (array[i] > max)
				{
					max = array[i];
				}
			}

			return max;
		}
	
		public static int FindMinPosition(int[] array, int position1, int position2)
		{
			int value = int.MaxValue;
            int ret = -1;
            for (int i = Math.Min(position1, position2); i <= Math.Max(position1, position2); i++)
            {
				if (array[i] < value)
				{
					ret = i;
					value = array[position1];
				}
			}
			return ret;
        }

		public static void Swap(int[] array, int position1, int position2)
		{
			int tmp;
			tmp = array[position1];
			array[position1] = array[position2];
			array[position2] = tmp;	
		}


        public static void ShiftLeftByOne(int[] array, int position1, int position2)
		{
            int temp = array[position1];
            for (int i = position1; i < position2; i++)
            {
                array[i] = array[i + 1];
            }
            array[position2 - 1] = temp;
        }

		public static int[] CreateRandomArray(int size, int minValue, int maxValue)
		{
            Random rand = new Random();
            int[] array = new int[size];
			for (int i = 0; i < size; i++)
			{
                array[i] = rand.Next(minValue, maxValue + 1);
            }
			return array;
		}

		public static int[][] CreateRandomMatrix(int rows, int columns, int minValue, int maxValue)
		{
            if (rows <= 0 || columns <= 0)
            {
                throw new ArgumentException("Number of rows and columns must be greater than zero.");
            }

            Random rand = new Random();
			int[][] matrix = new int[rows][];
			for (int i = 0; i < rows; i++)
			{
				matrix[i] = new int[columns];
				for (int j = 0; j < columns; j++)
				{
                    matrix[i][j] = rand.Next(minValue, maxValue + 1);
                }
			}

			return matrix;
		
        }

        public static int[,] CopyArray(int[] array)
        {
            int[,] copy = new int[2, array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                copy[0, i] = array[i];
                copy[1, i] = array[i];
            }
            return copy;
        }

        public static int FindInSortedArray(int[] array, int number)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == number)
                {
                    return mid;
                }
                else if (array[mid] < number)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return -1;
        }
    }
}
