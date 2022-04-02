using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Enums
{
    class Route
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
                if (value <= 0)
                {
                    throw new System.ArgumentException("flight time of minutes must be highest than 0");
                }
                _flightTimeOfMinutes = value;
            }
        }
    }
}
