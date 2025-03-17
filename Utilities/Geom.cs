namespace hello_world.Utilities;

public class Geom
{
    static double AreaTrianguloEquilatero(double lado)
    {
        return (Math.Sqrt(3) / 4) * Math.Pow(lado, 2);
    }

    static double AreaRectangulo(double lado, double altura)
    {
        return lado * altura;
    }

    public static double AreaSuperficialPrismaTriangular(double lado, double altura)
    {
        double areaTriangulo = 2 * AreaTrianguloEquilatero(lado);
        double areaLateral = 3 * AreaRectangulo(lado, altura);
        
        return areaTriangulo + areaLateral;
    }

    public static double VolumenPrismaTriangular(double lado, double altura)
    {
        return AreaTrianguloEquilatero(lado) * altura;
    }
    
    public static double VolumenPrismaRectangular(double largo, double ancho, double altura)
    {
        return largo * ancho * altura;
    }

    public static double AreaSuperficialPrismaRectangular(double largo, double ancho, double altura)
    {
        return 2 * (largo * ancho + largo * altura + ancho * altura);
    }
}