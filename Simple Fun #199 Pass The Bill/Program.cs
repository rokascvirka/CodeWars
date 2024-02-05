using NUnit.Framework;

namespace Simple_Fun__199_Pass_The_Bill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            var answer = program.PassTheBill(13, 4, 7);
            Console.WriteLine(answer);
        }
        public int PassTheBill(int TotalMembers, int ConservativePartyMembers, int ReformistPartyMembers)
        {
            var majority = TotalMembers / 2;
            var independents = TotalMembers - ConservativePartyMembers - ReformistPartyMembers;
            if (majority < ConservativePartyMembers)
            {
                return 0;
            }
            if (majority > (ConservativePartyMembers + independents) && independents > 0)
            {
                return -1;
            }

            var minimumVotesNeeded = majority - ConservativePartyMembers + 1;
            var independetsNeeded = independents - minimumVotesNeeded;
            if(minimumVotesNeeded < independents)
            {
                return -1;
            }
            return minimumVotesNeeded;
        }

        [TestFixture]
        public class myjinxin
        {

            [Test]
            public void BasicTests()
            {
                var kata = new Program();
                Assert.That(kata.PassTheBill(8, 3, 3), Is.EqualTo(2));

                Assert.That(kata.PassTheBill(13, 4, 7), Is.EqualTo(-1));

                Assert.That(kata.PassTheBill(7, 4, 3), Is.EqualTo(0));

                Assert.That(kata.PassTheBill(11, 4, 1), Is.EqualTo(2));

                Assert.That(kata.PassTheBill(11, 5, 1), Is.EqualTo(1));

                Assert.That(kata.PassTheBill(11, 6, 1), Is.EqualTo(0));

                Assert.That(kata.PassTheBill(11, 4, 4), Is.EqualTo(2));

                Assert.That(kata.PassTheBill(11, 5, 4), Is.EqualTo(1));

                Assert.That(kata.PassTheBill(11, 5, 5), Is.EqualTo(1));

                Assert.That(kata.PassTheBill(11, 4, 6), Is.EqualTo(-1));

                Assert.That(kata.PassTheBill(11, 4, 5), Is.EqualTo(2));

                Assert.That(kata.PassTheBill(15, 9, 3), Is.EqualTo(0));
            }
        }
    }
}