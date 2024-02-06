namespace Suzuki_needs_help_lining_up_his_students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var answer = LineupStudents("Tadashi Takahiro Takao Takashi Takayuki Takehiko Takeo Takeshi Takeshi");
            Console.WriteLine(answer);
        }
        public static String[] LineupStudents(String a)
        {
            var answer = a.Split(' ')
                .OrderByDescending(x => x.Length)
                .ThenByDescending(x => x)
                .ToArray();
            return answer;
        }
    }
}