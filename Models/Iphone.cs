namespace DesafioPOO.Models
{
  public class iPhone : Smartphone
  {
    public iPhone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
    {
    }
    public override void InstalarAplicativo(string aplicativo)
    {
      Console.WriteLine($"Instalando o aplicativo {aplicativo} no iPhone");
    }
  }
}
