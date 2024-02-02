namespace Which_section_did_you_scroll_to
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var scrolly1 = 1;
            var scrolly2 = 299;
            var scrolly3 = 300;
            var scrolly4 = 1599;
            var scrolly5 = 1600;

            var arr = new int[] { 300, 200, 400, 600, 100 };
            var arr2 = new int[] { 300, 200, 400, 600, 100 };
            var arr3 = new int[] { 300, 200, 400, 600, 100 };
            var arr4 = new int[] { 300, 200, 400, 600, 100 };
            var arr5 = new int[] { 300, 200, 400, 600, 100 };


            //var sectionId1 = GetSectionId(scrolly1, arr);
            //var sectionId2 = GetSectionId(scrolly2, arr2);
            //var sectionId3 = GetSectionId(scrolly3,  arr3);
            //var sectionId4 = GetSectionId(scrolly4, arr4);
            var sectionId5 = GetSectionId(scrolly5, arr5);


            //  Console.WriteLine(sectionId1);
            //Console.WriteLine(sectionId2);
            //Console.WriteLine(sectionId3);
            //Console.WriteLine(sectionId4);
            Console.WriteLine(sectionId5);

        }
        public static int GetSectionId(int n, int[] a)
        {
            var answer = 0; 
            for(var i = 0; i < a.Length; i++)
            {
                if (i == 0 && a[0] - 1 >= n)
                {
                    return i;
                }
                if( i == 0)
                {
                    answer = a[i] - 1;
                }

                if(i != 0)
                {
                    answer += a[i];

                    if (answer >= n)
                    {
                        return i;
                    }
                }
            }

            return -1;
        }
    }
}