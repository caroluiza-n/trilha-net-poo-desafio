namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        private string Modelo;
        private string IMEI;
        private int Memoria;

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            this.Modelo = modelo;
            this.IMEI = imei;
            this.Memoria = memoria;
        }

        public void MostrarInformacoes()
        {
            Console.WriteLine($"Número: {Numero}\nModelo: {Modelo}\nIMEI: {IMEI}\nMemória: {Memoria}");
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}