namespace Programming.Model
{
    public class Subject
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
                Validator.AssertValueInRange("the value of the mark", value, 2, 5);
                _mark = value;
            }
        }
    }
}
