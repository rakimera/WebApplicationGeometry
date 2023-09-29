namespace WebApplication1
{
    public static class GeometryCalculator
    {
        public static double CalculateCircleArea(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("Радиус не может быть отрицательным.");
            
            return Math.PI * radius * radius;
        }

        public static double CalculateTriangleArea(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                throw new ArgumentException("Длины сторон треугольника должны быть положительными числами.");

            if (!IsTriangleValid(sideA, sideB, sideC))
                throw new ArgumentException("Треугольник с такими сторонами не существует.");

            double s = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
        }

        public static bool IsRightTriangle(double sideA, double sideB, double sideC)
        {
            double[] sides = { sideA, sideB, sideC };
            Array.Sort(sides);
            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
        }

        private static bool IsTriangleValid(double sideA, double sideB, double sideC)
        {
            return (sideA + sideB > sideC) && (sideA + sideC > sideB) && (sideB + sideC > sideA);
        }
    }
}