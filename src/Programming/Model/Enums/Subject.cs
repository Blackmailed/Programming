using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Enums
{
    class Subject
    {
        private int _mark;
        
        public Subject()
        {
        }

        public Subject(string name, string teacherName, int mark)
        {
            Name = name;
            TeacherName = teacherName;
            Mark = mark;
        }

        public string Name { get; set; }
        public string TeacherName { get; set; }
        public int Mark
        {
            get
            {
                return _mark;
            }
            set
            {
                if (value > 5 || value < 2)
                {
                    throw new System.ArgumentException("the value of the grade field should be between 2 and 5");
                }
                _mark = value;
            }
        }
    }
}
