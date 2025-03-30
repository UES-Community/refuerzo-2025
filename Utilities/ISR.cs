namespace hello_world.Utilities;

public class ISR
{
    public static double porcentage1 = 0.10;
    public static double percentage2 = 0.20;
    public static double percentage3 = 0.30;

    public static double MonthlyTable(double salary)
    {
        double retentionCalculated;
        double retention1, retention2, retention3;
        double fixed1, fixed2, fixed3;

        retention1 = 472.00;
        retention2 = 895.24;
        retention3 = 2038.10;
        
        fixed1 = 17.67;
        fixed2 = 60.00;
        fixed3 = 288.57;
        
        // Esto podria ser un metodo que reciba los n retenciones, porcentajes y montos fijos
        // Con base al salario, escojo el tramo sobre el cual trabajar
        switch (salary)
        {
            
            case double n when (salary > retention1 && salary <= retention2): //700 - 472 = 228 * 10% = 22.8 + 17.67 = 40.47
                retentionCalculated = ((salary - retention1) * porcentage1) + fixed1;
                break;
            case double n when (salary > retention2 && salary <= retention3):
                retentionCalculated = ((salary - retention2) * percentage2) + fixed2;
                break;
            case double n when (salary > retention3):
                retentionCalculated = ((salary - retention3) * percentage3) + fixed3;
                break;
            default:
                retentionCalculated = 0;
                break;
        }

        return retentionCalculated;

    }
    
    public static double BiweeklyTable(double salary)
    {
        double retentionCalculated;
        double retention1, retention2, retention3;
        double fixed1, fixed2, fixed3;

        retention1 = 236.00;
        retention2 = 447.62;
        retention3 = 1019.05;
        
        fixed1 = 8.83;
        fixed2 = 30.00;
        fixed3 = 144.28;
        
        // Esto podria ser un metodo que reciba los n retenciones, porcentajes y montos fijos
        // Con base al salario, escojo el tramo sobre el cual trabajar
        switch (salary)
        {
            
            case double n when (salary > retention1 && salary <= retention2): 
                retentionCalculated = ((salary - retention1) * porcentage1) + fixed1;
                break;
            case double n when (salary > retention2 && salary <= retention3):
                retentionCalculated = ((salary - retention2) * percentage2) + fixed2;
                break;
            case double n when (salary > retention3):
                retentionCalculated = ((salary - retention3) * percentage3) + fixed3;
                break;
            default:
                retentionCalculated = 0;
                break;
        }

        return retentionCalculated;

    }
    
    
    public static double WeeklyTable(double salary)
    {
        double retentionCalculated;
        double retention1, retention2, retention3;
        double fixed1, fixed2, fixed3;

        retention1 = 118.00;
        retention2 = 223.81;
        retention3 = 509.52;
        
        fixed1 = 4.42;
        fixed2 = 15.00;
        fixed3 = 72.14;
        
        // Esto podria ser un metodo que reciba los n retenciones, porcentajes y montos fijos
        // Con base al salario, escojo el tramo sobre el cual trabajar
        switch (salary)
        {
            
            case double n when (salary > retention1 && salary <= retention2): 
                retentionCalculated = ((salary - retention1) * porcentage1) + fixed1;
                break;
            case double n when (salary > retention2 && salary <= retention3):
                retentionCalculated = ((salary - retention2) * percentage2) + fixed2;
                break;
            case double n when (salary > retention3):
                retentionCalculated = ((salary - retention3) * percentage3) + fixed3;
                break;
            default:
                retentionCalculated = 0;
                break;
        }

        return retentionCalculated;

    }
}