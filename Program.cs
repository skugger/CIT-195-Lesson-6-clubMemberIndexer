using System.Net;

namespace CIT_195_Lesson_6_clubMemberIndexer
{
    internal class Program
    {
        public const int Size = 10;
        class ClubMembers
        {
            private string[] Members = new string[Size];
            public string ClubType { get; set; }
            public string ClubLocation { get; set; }
            public string MeetingDate { get; set; }

            // constructor
            public ClubMembers()
            {
                for (int i = 0; i < Size; i++)
                {
                    Members[i] = string.Empty;
                    ClubType = string.Empty;
                    ClubLocation = string.Empty;
                    MeetingDate = string.Empty;
                }
            }
            // indexer get and set methods
            public string this[int index]
            {
                get
                {
                    string tmp;
                    if (index >= 0 && index <= Size - 1)
                    {
                        tmp = Members[index];
                    }
                    else
                    {
                        tmp = "";
                    }
                    return (tmp);
                }
                set
                {
                    if (index >= 0 && index <= Size - 1)
                    {
                        Members[index] = value;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            {
                ClubMembers Member = new  ClubMembers();
                Member[0] = "Milo Bloom";
                Member[1] = "Steve Dallas";
                Member[2] = "Michael Binkley";
                Member[3] = "Opus";
                Member[4] = "Bill the Cat";
                Member[5] = "Cutter John";
                Member[6] = "Hodge Podge";
                Member[7] = "Portnoy";
                Member[8] = "Quiche Lorraine";
                Member[9] = "Lola Granola";
                Member[10] = "Milqutoast";

                Member.ClubLocation = "Bloom County, America";
                Member.ClubType = "imaginary";
                Member.MeetingDate = "12th of Never, 2024";

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(Member[i]);
                }
                Console.WriteLine($"Meeting location:  {Member.ClubLocation}");
                Console.WriteLine($"Meeting type:  {Member.ClubType}");
                Console.WriteLine($"Meeting date:  {Member.MeetingDate}");
            }
        }
    }
}
