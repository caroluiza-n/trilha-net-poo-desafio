using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Iphone iphone = new Iphone("(31)991872836", "11", "67AC7D", 256);
iphone.MostrarInformacoes();
iphone.InstalarAplicativo("Whatsapp");

Nokia nokia = new Nokia("(31)985523491", "Tijolão", "83JD8A", 128);
nokia.MostrarInformacoes();
nokia.InstalarAplicativo("Instagram");