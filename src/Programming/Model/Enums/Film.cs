using System;
namespace Programming.Model.Enums
{
    class Film
    {
        private int _yearRelease;
        private double _rating;
        private int _durationMinutes;

        public Film()
        {
                
        }

        public Film(int yearRelease,int durationMinutes,int rating,string name,string genre)
        {
            YearRelease = yearRelease;
            DurationMinutes = durationMinutes;
            Rating = rating;
            Name = name;
            Genre = genre;
        }

        public string Name { get; set; }

        public string Genre { get; set; }

        public int DurationMinutes
        {
            get
            {
                return _durationMinutes;
            }
            set
            {
                if (value <= 0)
                {
                    throw new System.ArgumentException("duration field must be highest than 0");
                }
                _durationMinutes = value;
            }
        }

        public int YearRelease
        {
            get
            {
                return _yearRelease;
            }
            set
            {
                if (1900 > value || value > DateTime.Now.Year)
                {
                    throw new System.ArgumentException($"release year must be in range from 1900 to {DateTime.Now.Year}");
                }
                _yearRelease = value;
            }
        }

        public double Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                if (0 > value || value > 10)
                {
                    throw new System.ArgumentException("rating must be in range from 0 to 10");
                }
                _rating = value;
            }
        }
    }
}
