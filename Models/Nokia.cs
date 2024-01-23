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

        public override string InstalarAplicativo(string nomeApp)
        {
            if(nomeApp != ""){
                string feedbackMessage = $"Aplicativo {nomeApp} instalado com sucesso no seu Nokia!";
                Console.WriteLine(feedbackMessage);
                return feedbackMessage;
            } else {
                string feedbackMessage = "É preciso fornecer o nome do App a ser instalado";
                Console.WriteLine(feedbackMessage);
                return feedbackMessage;
            }
            
        }

        public override string ExibirConfiguracoes()
        {
            string configMessage = $"Ficha Técnica do seu Aparelho Nokia:\nModelo:{Modelo}\nImei:{Imei}\nMemória:{Memoria}";
            Console.WriteLine(configMessage);
            return configMessage;
        }
    }
}