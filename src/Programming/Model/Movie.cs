using System;

namespace Programming.Model
{
    public class Movie
    {
        private int _releaseYear;

        private double _rating;

        private int _durationMinutes;

        public Movie()
        {        
        }

        public Movie(int releaseYear, int durationMinutes, int rating,string name,string genre)
        {
            ReleaseYear = releaseYear;
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
                Validator.AssertOnPositiveValue("duration", value);
                _durationMinutes = value;
            }
        }

        public int ReleaseYear
        {
            get
            {
                return _releaseYear;
            }
            set
            {
                Validator.AssertValueInRange("release year", value, 1950, DateTime.Now.Year);
                _releaseYear = value;
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
                Validator.AssertValueInRange("rating must be in range", value, 0, 10);
                _rating = value;
            }
        }
    }
}
