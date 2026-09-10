using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_And_Overriding_EX2
{
    public class Grade
    {
        private int studentID, grade;

        public Grade(int _studentID, int _grade)
        {
            if (_studentID < 1 || _studentID > 1000)
            {
                studentID = 0;
            }
            else
            {
                studentID = _studentID;
            }

            if (_grade < 1 || _grade > 5)
            {
                grade = -1;
            }
            else
            {
                grade = _grade;
            }
        }

        public int GetStudentID()
        {
            return studentID;
        }

        public int GetGrade()
        {
            return grade;
        }
    }
}
