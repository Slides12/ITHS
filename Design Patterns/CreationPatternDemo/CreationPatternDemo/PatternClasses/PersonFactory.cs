namespace CreationPatternDemo.PatternClasses
{
    public static class PersonFactory
    {
        public static Person? GetInstance(int value)
        {
            if(value == 1)
            {
                return new Teacher();
            }
            else if(value == 2)
            {
                return new Student();
            }
            else
            {
                return null;
            }
        }

    }
}
