namespace LinqMethodQuery
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("LINQ Query & Method Syntax Implementation\n");

            LinqQuery();
        }

        static void LinqQuery()
        {
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // Query syntax to get all the Student names and Method syntax to get all the Student names

            var studentNames = from student in QueryList.students
                               select student.FirstName;

            foreach(var student in studentNames)
            {
                Console.WriteLine($"{student}\n");
            }
                
         //////////////////////////////////////////////////////////////////////////////////////////

            var studentNamesM = QueryList.students.Select(student => student.FirstName);
            
            foreach (var student in studentNamesM)
            {
                Console.WriteLine($"{student}\n");
            }
            Console.WriteLine("==============");
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // Query syntax to get all the Candidate Numbers or Method syntax to get all the Candidate Numbers

            var candidateNumbers = from student in QueryList.students
                                   select student.CandidateNumber;

            foreach (var student in candidateNumbers)
            {
                Console.WriteLine($"{student}\n");
            }
            
         ////////////////////////////////////////////////////////////////////////////////////////////
            
            var candidateNumbersM = QueryList.students.Select(student => student.CandidateNumber);
            foreach (var student in candidateNumbersM)
            {
                Console.WriteLine($"{student}\n");
            }
            Console.WriteLine("==============");

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // Query syntax to get all the Foods OR Method syntax to get all the Foods

            var foods = from student in QueryList.students
                        from food in student.Foods
                        select food;

            foreach (var allfood in foods)
                Console.WriteLine($"{allfood}\n");

         ////////////////////////////////////////////////////////////////////////////////////////////
         
            var foodsM = QueryList.students.SelectMany(student => student.Foods);

            foreach (var allfood in foodsM)
                Console.WriteLine($"{allfood}\n");
            Console.WriteLine("==============");

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // Query syntax to get Student's first name and last name OR Method syntax to get Student's first name and last name

            var studentFLNames = from student in QueryList.students
                                 select new { student.FirstName, student.LastName };
            foreach (var student in studentFLNames)
                Console.WriteLine($"Full Name: {student.FirstName} {student.LastName}\n");
            Console.WriteLine();
         ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
         
            var studentFLNamesM = QueryList.students.Select(student => new { student.FirstName, student.LastName });

            foreach (var student in studentFLNamesM)
                Console.WriteLine($"Full Name: {student.FirstName} {student.LastName}\n");
            Console.WriteLine("==================================================");
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // Query syntax to get all the Student names who have Candidate Number greater than 3000 OR Method Syntax

            var studentNamesCN = from student in QueryList.students
                           where student.CandidateNumber > 3000
                           select student.FirstName;

            foreach (string name in studentNamesCN)
                Console.WriteLine(name);

    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    
            var studentNamesCNM = QueryList.students.Where(student => student.CandidateNumber > 3000).Select(student => student.FirstName);
            
            foreach (string name in studentNamesCNM)
                Console.WriteLine(name);

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // Query syntax to get all the Student names in descending order OR Method syntax

            var studentNamesDesc = from student in QueryList.students
                                   orderby student.FirstName descending
                                   select student.FirstName;
            foreach (string name in studentNamesDesc)
                Console.WriteLine(name);
            Console.WriteLine();

    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    
            var studentNamesDescM = QueryList.students.OrderByDescending(student => student.FirstName).Select(student => student.FirstName);
            foreach (string name in studentNamesDescM)
                Console.WriteLine(name);
            Console.WriteLine("==============");

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // Query syntax to get all the Student names who have Candidate Number greater than 3000 in descending order O Method Syntax

            var studentNamesG = from student in QueryList.students
                           where student.CandidateNumber > 3000
                           orderby student.FirstName descending
                           select student.FirstName;

            foreach(string name in studentNamesG)
                Console.WriteLine(name);
            Console.WriteLine();

    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    
            var studentNamesGM = QueryList.students.Where(student => student.CandidateNumber > 3000).OrderByDescending(student => student.FirstName).Select(student => student.FirstName);
            foreach (string name in studentNamesGM)
                Console.WriteLine(name);
            Console.WriteLine("=============");

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // Query syntax to get first Student name OR Method Syntax

            var firstNameQS = (from student in QueryList.students
                             select student.FirstName).FirstOrDefault();

            foreach (var name in firstNameQS)
                Console.WriteLine(name);

    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    
            var firstNameM = QueryList.students.Select(student => student.FirstName).FirstOrDefault();

            foreach (var name in firstNameM)
                Console.WriteLine(name);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            // Query syntax to get first Student name who have Candidate Number greater than 3000 OR Method Syntax

            var firstNameQ = (from student in QueryList.students
                         where student.CandidateNumber > 3000
                         select student.FirstName).FirstOrDefault();

            foreach (char firstN in firstNameQ)
                Console.WriteLine(firstN);

     /////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            var firstNameMS = QueryList.students.Where(student => student.CandidateNumber > 3000).Select(student => student.FirstName).FirstOrDefault();

            foreach (char firstN in firstNameMS)
                Console.WriteLine(firstN);

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Query syntax to get all the Foods in ascending order

            var foodsQ = from student in QueryList.students
                    from food in student.Foods
                    orderby food ascending
                    select food;

            foreach (var food in foodsQ)
                Console.WriteLine(food);

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////

            var foodsMS = QueryList.students.SelectMany(student => student.Foods).OrderBy(food => food);

            foreach (var food in foodsMS)
                Console.WriteLine(food);

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}