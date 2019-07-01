namespace Lab2PointInRectangle
{
    public class Rectangle
    {        
        public Point TopLeft { get; set; }
        public Point BottomRight { get; set; }

        public Rectangle(Point topLeft, Point bottamRight)
        {
            TopLeft = topLeft;
            BottomRight = bottamRight;
        } 

        public bool Contains(Point point)
        {
            bool insideX = this.TopLeft.X <= point.X && this.BottomRight.X >= point.X;
            bool insideY = this.TopLeft.Y <= point.Y && this.BottomRight.Y >= point.Y;
            
                return insideX&&insideY;
        }
    }
}
