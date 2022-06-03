namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о дисциплине.
    /// </summary>
    public class Subject
    {
        /// <summary>
        /// Оценка по дисциплине.
        /// </summary>
        private int _mark;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Subject"/>.
        /// </summary>
        public Subject()
        {
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Subject"/>.
        /// </summary>
        /// <param name="name">Название дисциплины.</param>
        /// <param name="teacherName">Количество академических часов дисциплины. Должно быть положительным числом.</param>
        /// <param name="mark">Оценка по дисциплине. Должно быть в диапазоне от 2 до 5 (включительно).</param>
        public Subject(string name, string teacherName, int mark)
        {
            Name = name;
            TeacherName = teacherName;
            Mark = mark;
        }

        /// <summary>
        /// Возвращает и задаёт название дисциплины.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и задаёт имя преподавателя.
        /// </summary>
        public string TeacherName { get; set; }

        /// <summary>
        /// Возвращает и задаёт оценку по дисциплине. Должно быть в диапазоне от 2 до 5 (включительно).
        /// </summary>
        public int Mark
        {
            get
            {
                return _mark;
            }
            set
            {
                Validator.AssertValueInRange(nameof(Mark), value, 2, 5);
                _mark = value;
            }
        }
    }
}
