using System;

namespace Password_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var password =  new int[] { 0 };

            var res = HelpZoom(password);
            Console.WriteLine(res);
        }
        public static string HelpZoom(int[] key)
        {
            var length = key.Length;
            if (length == 1)
            {
                return "No";
            }
            if (length % 2 == 1)
            {
                var half = length / 2;
                var firstPart = key[0..(half)].ToArray();
                var secondPart = key[(half+1)..length].Reverse().ToArray();
                if (firstPart.SequenceEqual(secondPart))
                {
                    return "Yes";
                }
                return "No";
            }
            else
            {
                var half = length / 2;
                var firstPart = key[0..half];
                var secondPart = key[half..length].Reverse().ToArray();


                if (firstPart.SequenceEqual(secondPart))
                {
                    return "Yes";
                }
                return "No";
            }
        }
        public static string HelpZoomV2(int[] a)
        {
            return a.Reverse().SequenceEqual(a) ? "Yes" : "No";
        }

    }
}