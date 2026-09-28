using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;

namespace Assignment
{
    public class StudentSolution : IAssignment
    {
        #region Lecture
        public int[] LCT01_SelectionSortAscending(int[] numbers)
        {
            int n = numbers.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (numbers[j] < numbers[minIndex])
                    {
                        minIndex = j;
                    }
                }
                //int temp = numbers[minIndex];
                //numbers[minIndex] = numbers[i];
                //numbers[i] = temp;
                (numbers[i], numbers[minIndex]) = (numbers[minIndex], numbers[i]);
            }

            foreach (var n_ in numbers)
            {
                Debug.Log(n_);
            }
            return numbers;
        }

        public int[] LCT02_BubbleSortAscending(int[] numbers)
        {

            int n = numbers.Length;
            for (int i = 0; i < n-1 ; i++)
            {
                for (int j = 0; j < n-i-1 ; j++)
                {
                    if (numbers[j] > numbers[j+1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers [j+1];
                        numbers[j + 1] = temp;
                    }
                }
                foreach (var n_ in numbers)
                {
                    Debug.Log(n_);
                }
            }

            return numbers;
        }

        public int[] LCT03_InsertionSortAscending(int[] numbers)
        {
            int n = numbers.Length;
            for (int i = 0; i< n; i++ )
            {
                int key = numbers[i];
                int j = i - 1;
                while (j >= 0 && numbers[j] > key)
                {
                    numbers[j + 1] = numbers[j];
                    j--;
                }
                numbers[j + 1] = key;
            }
            foreach (var n_ in numbers)
            {
                Debug.Log(n_);
            }

            return numbers;
        }

        #endregion

        #region Assignment

        public int[] AS01_SelectionSortDescending(int[] numbers)
        {
            int n = numbers.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int maxIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (numbers[j] > numbers[maxIndex])
                    {
                        maxIndex = j;
                    }
                }

                int temp = numbers[i];
                numbers[i] = numbers[maxIndex];
                numbers[maxIndex] = temp;
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            return numbers;
        }

        public int[] AS02_BubbleSortDescending(int[] numbers)
        {
            int n = numbers.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (numbers[j] < numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            return numbers;
        }

        public int[] AS03_InsertionSortDescending(int[] numbers)
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                int key = numbers[i];
                int j = i - 1;

                while (j >= 0 && numbers[j] < key)
                {
                    numbers[j + 1] = numbers[j];
                    j--;
                }

                numbers[j + 1] = key;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            return numbers;
        }

        public int AS04_FindTheSecondLargestNumber(int[] numbers)
        {
            Array.Sort(numbers);
            Array.Reverse(numbers);

            int largest = numbers[0];
            int secondLargest = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < largest)
                {
                    secondLargest = numbers[i];
                    break;
                }
            }

            Console.WriteLine(secondLargest);

            return secondLargest;
        }

        #endregion

        #region Extra

        public int EX01_FindLongestConsecutiveSequence(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                Console.WriteLine("The longest consecutive sequence is: 0");
                return 0;
            }

            Array.Sort(numbers);

            int maxStreak = 1;
            int currentStreak = 1;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    continue;
                }

                if (numbers[i + 1] == numbers[i] + 1)
                {
                    currentStreak++;
                }
                else
                {
                    currentStreak = 1;
                }

                if (currentStreak > maxStreak)
                {
                    maxStreak = currentStreak;
                }
            }

            Console.WriteLine($"The longest consecutive sequence is: {maxStreak}");
            return maxStreak;
        }

        #endregion
    }
}
