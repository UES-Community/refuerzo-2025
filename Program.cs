using System;
using hello_world.Miscellaneous;
using hello_world.Utilities;
using System.Data;
using System.Data.OleDb;

class Program
{
    static void Main(string[] args)
    {
        const string FILE_PATH = @"C:\Users\kevin\3D Objects\development\refuerzo-2025\Content\IO-IAI115-OLEDB.xlsx";
        const string CONNECTION_STRING =
            $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={FILE_PATH};Extended Properties='Excel 12.0 Xml;HDR=YES;'";

        using (OleDbConnection conn = new OleDbConnection(CONNECTION_STRING))
        {
            conn.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM [Hoja1$]", conn);
            DataTable table = new DataTable();
            adapter.Fill(table);

            table.Columns.Add("Monto calculado", typeof(double)); // salary * 0.3
            table.Columns.Add("Monto a depositar", typeof(double)); // salary * 0.3 + salarySplited

            foreach (DataRow row in table.Rows)
            {
                //lectura
                double salary = Convert.ToDouble(row["salary"]);
                double year = Convert.ToDouble(row["years"]);


                //operaciones
                double salarySplited = salary / 2;
                double salaryMultplied = 0;

                if (year > 3)
                {
                    salaryMultplied = salary * 0.30;
                }

                double amountTotal = salaryMultplied + salarySplited;

                row["Monto calculado"] = salaryMultplied;
                row["Monto a depositar"] = amountTotal;
            }

            foreach (DataRow row in table.Rows)
            {
                Console.WriteLine(
                    $"salario: {row["salary"]}, anios: {row["years"]}, porcentaje: {row["Monto calculado"]}, total: {row["Monto a depositar"]}");
            }
        }
    }
}