namespace Ones__Complement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(OnesComplement("000"));
            Console.WriteLine(OnesComplement("0"));
            Console.WriteLine(OnesComplement("1"));
            Console.WriteLine(OnesComplement("1001"));


        }

        public static string OnesComplement(string n)
        {
            string a = "";
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] == '1')
                {
                    a += "0";
                }
                else 
                { 
                    a += "1"; 
                }
            }
            return a;
        }
    }
}