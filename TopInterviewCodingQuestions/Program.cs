// See https://aka.ms/new-console-template for more information

using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Program
{
    //hackerrank 1 week prep
    public static void plusMinus(List<int> arr)
    {
        int len = arr.Count();
        decimal pos = (decimal)arr.Where(x => x > 0).Count() / len;
        decimal neg = (decimal)arr.Where(x => x < 0).Count() / len;
        decimal zero = (decimal)arr.Where(x => x == 0).Count() / len;

        Console.WriteLine(pos.ToString("N6"));
        Console.WriteLine(neg.ToString("N6"));
        Console.WriteLine(zero.ToString("N6"));
    }

    public static void miniMaxSum(List<int> arr)
    {
        long minSum = arr.OrderBy(x => x).Take(4).Select(x => Convert.ToInt64(x)).Sum();

        long maxSum = arr.OrderByDescending(x => x).Take(4).Select(x => Convert.ToInt64(x)).Sum();

        Console.WriteLine(minSum + " " + maxSum);
    }

    public static string timeConversion(string s)
    {

        string hour = s.Substring(0, 2);

        if (hour == "12" && s[8] == 'A')
        {
            hour = "00";
        }
        else if (hour == "12" && s[8] == 'P')
        {
            hour = "12";
        }
        else if (s[8] == 'P')
        {
            hour = (Convert.ToInt32(hour) + 12).ToString();
        }

        return hour + s.Substring(2,6);
    }

    public static int findMedian(List<int> arr)
    {
        int middleIndex = arr.Count / 2;

        return arr.OrderBy(x => x).ToList()[middleIndex];
    }

    public static int lonelyinteger(List<int> a)
    {
        return a.GroupBy(x => x).First(g => g.Count() == 1).Select(x => x).ToList()[0];
        
    }

    public static int diagonalDifference(List<List<int>> arr)
    {
        int len = arr[0].Count;
        int sumA = 0, sumB = 0;

        for (int i = 0, j = len - 1; i < len; i++, j--)
        {
            sumA += arr[i][i];
            sumB += arr[i][j];
        }

        return Math.Abs(sumA - sumB);

    }

    public static List<int> countingSort(List<int> arr)
    {
        int len = arr.Count;

        List<int> returnList = new List<int>();

        returnList.AddRange(Enumerable.Repeat(0, 100));

        for (int i = 0; i < len; i++)
        {
            returnList[arr[i]] += 1;
        }
        
        return returnList;
    }

    //yet to be tested
    public static List<int> minimalHeaviestSetA(List<int> arr)
    {
        //not yet tested completed
        int sumA = 0, sumB = 0;

        int len = arr.Count;

        int sum = arr.Sum();
        List<int> newList = new List<int>();
        for (int i = 1; i <= len / 2; i++)
        {
            newList.Clear();
            newList = arr.GroupBy(x => x).Where(g => g.Count() == 1).Select(x => x.Key).
                OrderByDescending(x => x).Take(i).OrderBy(x => x).ToList();
            sumA = newList.Sum();

            sumB = sum - sumA;
            if (sumA > sumB)
            {
                return newList;
            }
        }

        return arr;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //List<List<int>> a = new List<List<int>>
        //{
        //    new List<int>{ 1, 2, 3 },
        //    new List<int>{ 4, 5, 6 },
        //    new List<int>{ 7, 8, 9 }
        //};

        List<int> a = new List<int> { 1, 1, 2, 3 };
        Program.countingSort(a);
    }
}

