namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp){
            nomeApp = "Instagram";
            Console.WriteLine($"Instalando o app {nomeApp}");
        }
    }
}