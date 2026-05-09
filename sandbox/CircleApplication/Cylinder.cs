using System.Reflection.Metadata;
class Cylinder
{
    public Circle _circle;

    public double _height;

    public double GetCylinderVolume()
    {
        return Math.PI * _circle.GetArea() * _height;
    }
}