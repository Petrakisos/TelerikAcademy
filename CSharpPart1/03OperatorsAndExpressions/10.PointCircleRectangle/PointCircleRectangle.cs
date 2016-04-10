//Input Output
//2.5
//2	outside circle outside rectangle
//0
//1	inside circle inside rectangle
//2.5
//1	inside circle inside rectangle
//1
//2	inside circle outside rectangle
using System;

class PointCircleRectangle
{
    static void Main()
    {
        double pointX = double.Parse(Console.ReadLine());
        double pointY = double.Parse(Console.ReadLine());

        double circleX = 1;
        double circleY = 1;
        double circleRadius = 1.5;

        double topRectangle = 1;
        double leftRectangle = -1;
        double widthRectangle = 6;
        double heightRectangle = 2;

        bool isInsideCircle = Math.Sqrt((pointX - circleX) + (pointY - circleY)) <= circleRadius * circleRadius;

        bool isInsideRectangle = (pointX >= leftRectangle) && (pointX <= (leftRectangle + widthRectangle)) && (pointY >= (topRectangle - heightRectangle)) && (pointY <= topRectangle);

        if (isInsideCircle == true)
        {
            Console.Write("inside circle ");
        }
        else
        {
            Console.Write("outside circle ");
        }
        if (isInsideRectangle == true)
        {
            Console.WriteLine("inside rectangle");
        }
        else
        {
            Console.WriteLine("outside rectangle");
        }

    }
}
