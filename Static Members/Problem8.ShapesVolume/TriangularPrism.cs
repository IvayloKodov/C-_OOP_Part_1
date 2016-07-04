namespace Problem8.ShapesVolume
{
    public class TriangularPrism
    {
        private double baseSide;
        private double height;
        private double length;

        public TriangularPrism(double baseSide, double height, double length)
        {
            this.BaseSide = baseSide;
            this.Height = height;
            this.Length = length;
        }

        public double BaseSide
        {
            get { return baseSide; }
            set { baseSide = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double Length
        {
            get { return length; }
            set { length = value; }
        }
    }
}