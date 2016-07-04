namespace Problem8.ShapesVolume
{
    public class Cylinder
    {
        private double radius;
        private double height;

        public Cylinder(double radius, double height)
        {
            this.Radius = radius;
            this.Height = height;
        }

        public double Radius { get; set; }
        public double Height { get; set; }
    }
}