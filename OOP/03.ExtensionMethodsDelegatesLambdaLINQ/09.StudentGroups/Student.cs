﻿namespace StudentGroup
{
    using StudentGroups;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public int Fn { get; set; }

        public string Email { get; set; }

        public List<Mark> Marks { get; set; }

        public int GroupNumber { get; set; }

        public Group Group { get; set; }
    }
}
