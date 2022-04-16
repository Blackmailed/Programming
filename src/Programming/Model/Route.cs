namespace Programming.Model
{
    public class Route
    {
        private int _flightTimeOfMinutes;

        public Route()
        {
        }

        public Route(string sendingPoint, string arrivingPoint, int flightTimeOfMinutes)
        {
            SendingPoint = sendingPoint;
            ArrivingPoint = arrivingPoint;
            FlightTimeOfMinutes = flightTimeOfMinutes;
        }

        public string SendingPoint { get; set; }

        public string ArrivingPoint { get; set; }

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
