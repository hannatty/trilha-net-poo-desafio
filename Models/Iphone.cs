namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public string Cor { get; set; }
        public Iphone(string numero, string modelo, string imei, int memoria, string cor) : base(numero, modelo, imei, memoria)
        {
            Cor = cor;
        }
        public string FazerChamadaEmGrupo(string phone1, string phone2, string phone3 )
        {
            string mensagem = $"Chamada em grupo iniciada com contatos: {phone1} / {phone2} / {phone3}";
            Console.WriteLine(mensagem);
            return mensagem;
        }
        public override string InstalarAplicativo(string nomeApp)
        {
            if(nomeApp != ""){
                string feedbackMessage = $"Aplicativo {nomeApp} instalado com sucesso no seu Iphone!";
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
            string mensagem = $"Ficha Técnica do seu Iphone:\nModelo:{Modelo}\nImei:{Imei}\nMemória:{Memoria}\nCor:{Cor}";
            Console.WriteLine(mensagem);
            return mensagem;
        }
    }
}