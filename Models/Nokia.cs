namespace DesafioPOO.Models
{
    // IMPLEMENTADO 
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base (numero, modelo, imei, memoria)
        {

        }
        // IMPLEMENTADO 
        public string Nomeapp { get; set; }
        public override void InstalarAplicativo(string nomeApp)
        {
            Nomeapp = Nomeapp;
            Console.WriteLine($"Instalando o app {nomeApp} no Nokia");
        }
    }
}