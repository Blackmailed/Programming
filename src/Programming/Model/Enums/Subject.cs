using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Enums
{
    class Subject
    {
        private int _grade;
        
        public Subject()
        {
        }

        public Subject(string nameSubject, string teacherName, int grade)
        {
            NameSubject = nameSubject;
            TeacherName = teacherName;
            Grade = grade;
        }
        public string NameSubject { get; set; }
        public string TeacherName { get; set; }
        public int Grade
        {
            get
            {
                return _grade;
            }
            set
            {
                if (value > 5 || value < 2)
                {
                    throw new System.ArgumentException("the value of the grade field should be between 2 and 5");
                }
                _grade = value;
            }
        }
    }
}
