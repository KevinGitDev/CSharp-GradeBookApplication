using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = Enums.GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {

            //In the RankedGradeBook class create an override for the GetLetterGrade method.
            //The GetLetterGrade method returns a char and accepts a double named "averageGrade".
            //If there are less than 5 students throw an InvalidOperationException. (Ranked-grading requires a minimum of 5 students to work)
            //Return 'F' at the end of the method.
            if (base.Students.Count < 5)
            {
                throw new InvalidOperationException("Ranked-grading requires a minimum of 5 staudents to work");
            }

            if (averageGrade >= 80)
                return 'A';
            else if (averageGrade >= 60)
                return 'B';
            else if (averageGrade >= 40)
                return 'C';
            else if (averageGrade >= 20)
                return 'D';
            else
                return 'F';
        }

        public override void CalculateStatistics()
        {
            //Create an override for the CalculateStatistics method in the RankedGradeBook class.
            //If there are less than 5 students write "Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade." to the Console, then return from the method.
            //In there were 5 or more students continue call the base class' method using base.CalculateStatistics();

            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");
                return;
            }
            else
            {
                base.CalculateStatistics();
            }
        }

        public override void CalculateStudentStatistics(string name)
        {
            //Create an override for CalculateStudentStatistics in the RankedGradeBook class.
            //If there are less than 5 students with grades in the class write "Ranked grading requires at least 5 students with grades in order 
            //to properly calculate a student's overall grade." to console than escape the method.
            //If there were at least 5 students then call the unoverriden method using base.CalculateStudentStatistics();.

            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");
                return;
            }
            else
            {
                base.CalculateStudentStatistics(name);
            }
        }
    }
}
