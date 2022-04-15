namespace Programming.Model
{
    public static class Validator
    {
        public static void AssertOnPositiveValue(string stringProperty, int value)
        {
            if (value <= 0)
            {
                throw new System.ArgumentException($"{stringProperty} must be greater than zero");
            }
        }

        public static void AssertOnPositiveValue(string stringProperty, double value)
        {
            if (value <= 0)
            {
                throw new System.ArgumentException($"{stringProperty} must be greater than zero");
            }
        }

        public static void AssertValueInRange(string stringProperty, int value, int min, int max)
        {
            if (value < min || value > max)
            {
                throw new System.ArgumentException($"{value} should be between {min} and {max}");
            }
        }

        public static void AssertValueInRange(string stringProperty, double value, double min, double max)
        {
            if (value < min || value > max)
            {
                throw new System.ArgumentException($"{value} should be between {min} and {max}");
            }
        }
    }
}
