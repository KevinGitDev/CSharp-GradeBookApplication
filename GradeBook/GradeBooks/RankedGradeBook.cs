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
    }
}
