using System.Security.Cryptography.X509Certificates;

namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public string MyProperty { get; set; }
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria){}

        public void JogarSnakeGame(){
            Console.WriteLine("******* SNAKE GAME INICIANDO *******");
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            if (nomeApp != ""){
            Console.WriteLine($"Aplicativo {nomeApp} instalado com sucesso no seu Nokia!");
            } else {
                Console.WriteLine("É preciso fornecer o nome do App a ser instalado.");
            }
        }

        public override void ExibirConfiguracoes()
        {
            Console.WriteLine($"Ficha Técnica do seu Aparelho Nokia:\nModelo:{Modelo}\nImei:{Imei}\nMemória:{Memoria}");
        }
    }
}