namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp){
            nomeApp = "Whatsapp";
            Console.WriteLine($"Instalando o app {nomeApp}");
        }
    }
}