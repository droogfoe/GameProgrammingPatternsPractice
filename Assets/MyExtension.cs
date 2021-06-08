using System.Collections;
using System.Collections.Generic;


namespace ExtensionMethods
{
    public static class MyExtension
    {
        public static int WordCount(this string str)
        {
            return str.Split(new char[] { ' ', '.', '?'},
                System.StringSplitOptions.RemoveEmptyEntries).Length;
        }
        public static string MaxValueString(this float _float)
        {
            return "MaxValue" + float.MaxValue.ToString();
        }
    }
}