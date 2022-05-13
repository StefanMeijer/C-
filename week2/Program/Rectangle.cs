namespace Program
{
    class Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double l, double w)
        {
            this.Length = l;
            this.Width = w;
        }

        public double GetArea()
        {
            return this.Length * this.Width;
        }
    }
}