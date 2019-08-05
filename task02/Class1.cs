using System;

public class Round
{
    private double radius;
    public Point Center { get; set; }
    public Round(Point Center, double Radius)
    {
        this.Center = Center;
        this.Radius = Radius;
    }


    public double Radius
    {
        get
        {
            return radius;
        }
        set
        {
            if (value > 0)
                radius = value;
            else
                throw new ArgumentException("Данные введены неккоректно! Радиус не может быть меньше или равен нулю.");
        }
    }
}