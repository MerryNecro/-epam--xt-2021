using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperArray
{
    public static class NumberArrayExtensions
    {
        #region FOREACH_ACTION
        //public static void DoChosenAction(this byte[] arr, Func<byte, byte> chosenAction)
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        arr[i] = chosenAction(arr[i]);
        //    }
        //}

        //public static void DoChosenAction(this sbyte[] arr, Func<sbyte, sbyte> chosenAction)
        //{
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        arr[i] = chosenAction(arr[i]);
        //    }
        //}

        public static void DoChosenAction(this decimal[] arr, Func<decimal, decimal> chosenAction)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = chosenAction(arr[i]);
            }
        }

        public static void DoChosenAction(this double[] arr, Func<double, double> chosenAction)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = chosenAction(arr[i]);
            }
        }

        public static void DoChosenAction(this float[] arr, Func<float, float> chosenAction)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = chosenAction(arr[i]);
            }
        }

        public static void DoChosenAction(this int[] arr, Func<int, int> chosenAction)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = chosenAction(arr[i]);
            }
        }

        public static void DoChosenAction(this uint[] arr, Func<uint, uint> chosenAction)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = chosenAction(arr[i]);
            }
        }

        public static void DoChosenAction(this long[] arr, Func<long, long> chosenAction)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = chosenAction(arr[i]);
            }
        }

        public static void DoChosenAction(this ulong[] arr, Func<ulong, ulong> chosenAction)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = chosenAction(arr[i]);
            }
        }

        public static void DoChosenAction(this short[] arr, Func<short, short> chosenAction)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = chosenAction(arr[i]);
            }
        }

        public static void DoChosenAction(this ushort[] arr, Func<ushort, ushort> chosenAction)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = chosenAction(arr[i]);
            }
        }
        #endregion



        #region SUM
        public static byte Sum(this byte[] arr)
        {
            byte result = 0;
            foreach (byte item in arr)
            {
                result += item;
            }
            return result;
        }

        public static sbyte Sum(this sbyte[] arr)
        {
            sbyte result = 0;
            foreach (sbyte item in arr)
            {
                result += item;
            }
            return result;
        }

        public static decimal Sum(this decimal[] arr)
        {
            decimal result = 0;
            foreach (decimal item in arr)
            {
                result += item;
            }
            return result;
        }

        public static double Sum(this double [] arr)
        {
            double result = 0;
            foreach (double item in arr)
            {
                result += item;
            }
            return result;
        }

        public static float Sum(this float [] arr)
        {
            float result = 0;
            foreach (float item in arr)
            {
                result += item;
            }
            return result;
        }

        public static int Sum(this int [] arr)
        {
            int result = 0;
            foreach (int item in arr)
            {
                result += item;
            }
            return result;
        }

        public static uint Sum(this uint [] arr)
        {
            uint result = 0;
            foreach (uint item in arr)
            {
                result += item;
            }
            return result;
        }

        public static long Sum(this long [] arr)
        {
            long result = 0;
            foreach (long item in arr)
            {
                result += item;
            }
            return result;
        }

        public static ulong Sum(this ulong [] arr)
        {
            ulong result = 0;
            foreach (ulong item in arr)
            {
                result += item;
            }
            return result;
        }

        public static short Sum(this short [] arr)
        {
            short result = 0;
            foreach (short item in arr)
            {
                result += item;
            }
            return result;
        }

        public static ushort Sum(this ushort [] arr)
        {
            ushort result = 0;
            foreach (ushort item in arr)
            {
                result += item;
            }
            return result;
        }
        #endregion



        #region AVERAGE
        public static double Average(this byte[] array) => (double)array.Sum() / array.Length;

        public static double Average(this sbyte[] array) => (double)array.Sum() / array.Length;

        public static double Average(this decimal[] array) => (double)array.Sum() / array.Length;

        public static double Average(this double[] array) => (double)array.Sum() / array.Length;

        public static double Average(this float[] array) => (double)array.Sum() / array.Length;

        public static double Average(this int[] array) => (double)array.Sum() / array.Length;

        public static double Average(this uint[] array) => (double)array.Sum() / array.Length;

        public static double Average(this long[] array) => (double)array.Sum() / array.Length;

        public static double Average(this ulong[] array) => (double)array.Sum() / array.Length;

        public static double Average(this short[] array) => (double)array.Sum() / array.Length;

        public static double Average(this ushort[] array) => (double)array.Sum() / array.Length;
        #endregion



        #region MOST_REPEATABLE
        public static byte MostRepeatable(this byte[] array)
        {
            return   array
                    .GroupBy(item => item)
                    .OrderByDescending(item => item.Count())
                    .FirstOrDefault()
                    .Key;
        }

        public static sbyte MostRepeatable(this sbyte[] array)
        {
            return array
                    .GroupBy(item => item)
                    .OrderByDescending(item => item.Count())
                    .FirstOrDefault()
                    .Key;
        }

        public static decimal MostRepeatable(this decimal[] array)
        {
            return array
                    .GroupBy(item => item)
                    .OrderByDescending(item => item.Count())
                    .FirstOrDefault()
                    .Key;
        }

        public static double MostRepeatable(this double[] array)
        {
            return array
                    .GroupBy(item => item)
                    .OrderByDescending(item => item.Count())
                    .FirstOrDefault()
                    .Key;
        }

        public static float MostRepeatable(this float[] array)
        {
            return array
                    .GroupBy(item => item)
                    .OrderByDescending(item => item.Count())
                    .FirstOrDefault()
                    .Key;
        }

        public static int MostRepeatable(this int[] array)
        {
            return array
                    .GroupBy(item => item)
                    .OrderByDescending(item => item.Count())
                    .FirstOrDefault()
                    .Key;
        }

        public static uint MostRepeatable(this uint[] array)
        {
            return array
                    .GroupBy(item => item)
                    .OrderByDescending(item => item.Count())
                    .FirstOrDefault()
                    .Key;
        }

        public static long MostRepeatable(this long[] array)
        {
            return array
                    .GroupBy(item => item)
                    .OrderByDescending(item => item.Count())
                    .FirstOrDefault()
                    .Key;
        }

        public static ulong MostRepeatable(this ulong[] array)
        {
            return array
                    .GroupBy(item => item)
                    .OrderByDescending(item => item.Count())
                    .FirstOrDefault()
                    .Key;
        }

        public static short MostRepeatable(this short[] array)
        {
            return array
                    .GroupBy(item => item)
                    .OrderByDescending(item => item.Count())
                    .FirstOrDefault()
                    .Key;
        }

        public static ushort MostRepeatable(this ushort[] array)
        {
            return array
                    .GroupBy(item => item)
                    .OrderByDescending(item => item.Count())
                    .FirstOrDefault()
                    .Key;
        }
        #endregion
    }
}
