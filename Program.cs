using DesafioPOO.Models;
class Program
{
   public static void Main(string[] args)
    {
        Console.WriteLine("Smartphone Nokia:");
        Smartphone nokia = new Nokia(numero:"1234567890", modelo: "Nokia 3310", imei: "1234", memoria:16);
        nokia.InstalarAplicativo("WhatsApp");
        nokia.Ligar();

        Console.WriteLine("\n");

        Console.WriteLine("Smartphone iPhone:");
        Smartphone iphone = new iPhone(numero:"0987654321", modelo:"iPhone 12", imei:"5678", memoria:64);
        iphone.InstalarAplicativo("Instagram");
        iphone.ReceberLigacao();
    }
}
    
