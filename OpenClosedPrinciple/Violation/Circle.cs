namespace SolidExamples.OpenClosedPrinciple.Violation
{
    class Circle : IShape
    {
        public int Radius  { get; }

        private readonly int _radius;

        public Circle(int radius)
        {
            _radius = radius;
        }
    }
}