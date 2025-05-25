using System;
using hello_world.Miscellaneous;
using hello_world.Utilities;
using System.Data;
using System.Data.OleDb;
using System.Xml.Serialization;

public struct Device
{
   public string Type { get; set; } 
   public string Brand { get; set; }
   public string Model { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Device> devices = new List<Device>
        {
            new Device{ Type="LAPTOP", Brand = "ACER", Model = "AC1010D"},
            new Device{ Type="ROUTER", Brand = "AZUS", Model = "ROU233T"},
            new Device{ Type="TABLET", Brand = "SAMSUNG", Model = "SAM123H"},
            new Device{ Type="CELULAR", Brand = "HUAWEI", Model = "HU1234G"},
        };
        
        //XML
        XmlSerializer serializer = new XmlSerializer(typeof(List<Device>), new XmlRootAttribute("Devices"));
        string xmlFilePath = "dispositivosElectronicos.xml";

        //Un espacio seguro para errores
        try
        {
            using (StreamWriter sw = new StreamWriter(xmlFilePath))
            {
                serializer.Serialize(sw, devices);
            } 
            
            Console.WriteLine("XML file generated successfully");
        }
        catch (Exception ex)
        {
           Console.WriteLine($"Something went wrong: {ex.Message}"); 
        }
        
        //Mostrar el contenido en el orden solicitado
        Console.WriteLine("SHOWING THE CONTENT OF DEVICES");
        foreach (Device d in devices)
        {
            //tipo
            //marca
            //modelo
           Console.WriteLine(d.Type); 
           Console.WriteLine(d.Brand); 
           Console.WriteLine(d.Model); 
        }
        
    }
}