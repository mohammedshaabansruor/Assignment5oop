namespace Assignment5oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            ICircle circle = new Circle(5);
            circle.DisplayShapeInfo();  

          
            IRectangle rectangle = new Rectangle(9, 10);
            rectangle.DisplayShapeInfo();
            #endregion
        }
    }
}
