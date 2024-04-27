using System;

public class Pentagon : Poligon
{
    [Serializable]
    public class Pentagon : Poligon
    {
        public static new string name { get => "Пятиугольник"; }
        public override int PointsNumber { get => 5; }
        public Pentagon(Color color, int Thicknes, PointF[] Points)
        {
            _PenColor = color;
            _PenThickness = Thicknes;
            _Points = new PointF[PointsNumber];
            _Points[0] = Points[0];
            _Points[1] = Points[1];
            _Points[2] = Points[2];
            _Points[3] = Points[3];
            _Points[4] = Points[4];
        }
        public Pentagon() : base() { }
        public Pentagon(Color color, int Thicknes, PointF Point1, PointF Point2, PointF Point3, PointF Point4, PointF Point5)
        {
            _PenColor = color;
            _PenThickness = Thicknes;
            _Points = new PointF[PointsNumber];
            _Points[0] = Point1;
            _Points[1] = Point2;
            _Points[2] = Point3;
            _Points[3] = Point4;
            _Points[4] = Point5;
        }
    }
}
