namespace FirstBeforeLast
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Startup
    {
        static void Main()
        {
            List<Student> students = new List<Student>();
            var studentsWhoseFirstNameIsBeforeTheirLast = students.Where(x => String.Compare(x.FirstName, x.LastName, StringComparison.Ordinal) < 0).ToList();
            var studentsBetween18And24 = students.Where(x => x.Age >= 18 && x.Age < 24).ToList();
            var sortedStudents = students.OrderByDescending(x => x.FirstName).ThenBy(x => x.LastName).ToList();
        }
    }
}
