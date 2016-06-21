namespace StudentGroups
{
    using StudentGroup;
    using System.Collections.Generic;
    using System.Linq;

    class Startup
    {
        static void Main()
        {
            List<Student> students = new List<Student>();
            var studentsFromGroup2 = students.Where(x => x.GroupNumber == 2).ToList();

            //Problem 9
            var orderedStudents = students.OrderBy(x => x.FirstName).ToList();

            //Problem 11
            var studentsWithEmailInAbv = students.Where(x => x.Email.EndsWith("@abv.bg")).ToList();

            //Problem 13
            var studetnsWithAtLEastOneGrade6 = students.Where(x => x.Marks.Any(y => y.MarkValue == 6));
            var anonType =
                new
                {
                    FullName = studetnsWithAtLEastOneGrade6.Select(x => x.FirstName + " " + x.LastName),
                    Marks = studetnsWithAtLEastOneGrade6.Select(x => x.Marks)
                };

            //Problem 14
            var studentsWith2Marks2 = students.Where(x => x.Marks.Where(y => y.MarkValue == 2).ToList().Count == 2);

            //Problem 15
            List<List<Mark>> allMarksOf2006Students = students.
                Where(x => x.Fn.ToString().Substring(5, 2) == "06").ToList().
                Select(x => x.Marks).ToList();

            // Problem 19
            var groupedStudentsByGroupNumberWithExtensionMEthods = students.GroupBy(x => x.GroupNumber);
        }
    }
}
