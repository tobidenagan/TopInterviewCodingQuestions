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


}

class Solution
{
    public static void Main(string[] args)
    {
        List<int> a = new List<int> { 1, 2, 3, 77, 9, 5, 7};
        Program.findMedian(a);
    }
}

