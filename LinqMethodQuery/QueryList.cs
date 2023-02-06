

namespace LinqMethodQuery
{
    internal class QueryList
    {
        public static List<Student> students = new List<Student>
        {
            new Student { FirstName = "John", LastName = "Smith", CandidateNumber = 1234, Foods = new string[] { "Pizza", "Pasta", "Salad" } },
            new Student { FirstName = "Sara", LastName = "Johnson", CandidateNumber = 2345, Foods = new string[] { "Hamburger", "Fries", "Milkshake" } },
            new Student { FirstName = "David", LastName = "Williami", CandidateNumber = 3456, Foods = new string[] { "Salad", "Burritos", "Fries" } }
        };
    }

    internal class Student
    {
        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
        public int CandidateNumber { get; internal set; }
        public string[] Foods { get; internal set; }
    }
}
