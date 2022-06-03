namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о маршруте.
    /// </summary>
    public class Route
    {
        /// <summary>
        /// Время полета в минутах.
        /// </summary>
        private int _flightTimeOfMinutes;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Route"/>.
        /// </summary>
        public Route()
        {
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Route"/>.
        /// </summary>
        /// <param name="sendingPoint">Место отправления.</param>
        /// <param name="arrivingPoint">Место прибытия.</param>
        /// <param name="flightTimeOfMinutes">Время полёта в минутах. Должно быть положительным числом.</param>
        public Route(string sendingPoint, string arrivingPoint, int flightTimeOfMinutes)
        {
            SendingPoint = sendingPoint;
            ArrivingPoint = arrivingPoint;
            FlightTimeOfMinutes = flightTimeOfMinutes;
        }

        /// <summary>
        /// Возвращает и задаёт место отправления.
        /// </summary>
        public string SendingPoint { get; set; }

        /// <summary>
        /// Возвращает и задаёт место прибытия.
        /// </summary>
        public string ArrivingPoint { get; set; }

        /// <summary>
        /// Возвращает и задаёт время полёта в минутах. Должно быть положительным числом.
        /// </summary>
        public int FlightTimeOfMinutes
        {
            get
            {
                return _flightTimeOfMinutes;
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(FlightTimeOfMinutes), value);
                _flightTimeOfMinutes = value;
            }
        }
    }
}
