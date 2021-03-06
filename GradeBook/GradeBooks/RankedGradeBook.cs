﻿using System;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Ranked;
        }
        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
                throw new InvalidOperationsException("Ranked grading requires at least 5 students.");
            var threshold = (int)Math.Ceiling(Students.Count * 0.2);
            foreach(var student in Students)
            {

            }
            return 'F';
        }
    }
}
