namespace Intro_till_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {     
            var circle1 = new Circle(5);
            Console.WriteLine($"Area för cirkel med radie 5 = {circle1.GetArea()}");
            Console.WriteLine($"Omkrets för cirkel med radie 5 = {circle1.GetCircumference()}");
            Console.WriteLine($"Volym för klot med radie 5 = {circle1.GetSphereVolume()}");

            circle1.Radius = 6;
            Console.WriteLine($"Area för cirkel med radie 6 = {circle1.GetArea()}");
            Console.WriteLine($"Omkrets för cirkel med radie 6 = {circle1.GetCircumference()}");
            Console.WriteLine($"Volym för klot med radie 6 = {circle1.GetSphereVolume()}");
        }
    }
    internal class Circle
    {
        public float Radius { get; set; }

        private readonly float _pi = 3.141f;

        public Circle(float radius)
        {
            Radius = radius;
        }

        public float GetArea()
        {
            float area = Radius * Radius * _pi;

            return area;
        }

        public float GetCircumference()
        {
            float circ = (Radius + Radius) * _pi;

            return circ;
        }

        public float GetSphereVolume()
        {
            float sphere = ((4 * _pi) * Power(Radius, 3)) / 3;

            return sphere;
        }

        static float Power(float x, float y)
        {
            float power = x;

            for (int i = 1; i < y; i++)
            {
                power *= x;
            }

            return power;
        }
    }
}
