namespace Programming.Model
{
    public class Song
    {
        private int _duration;

        public Song()
        {
        }

        public Song(string author, string name, int duration)
        {
            Author = author;
            Name = name;
            Duration = duration;
        }
        public string Author { get; set; }
        
        public string Name { get; set; }

        public int Duration
        {
            get
            {
                return _duration;
            }
            set
            {
                Validator.AssertOnPositiveValue("Song duration", value);
                _duration = value;
            }
        }

    }
}
