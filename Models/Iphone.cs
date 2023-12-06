namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public string Cor { get; set; }
        public Iphone(string numero, string modelo, string imei, int memoria, string cor) : base(numero, modelo, imei, memoria)
        {
            Cor = cor;
        }
        public void FazerChamadaEmGrupo(string phone1, string phone2, string phone3 )
        {
            Console.WriteLine($"Chamada em grupo iniciada com contatos: {phone1} / {phone2} / {phone3}");
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            if(nomeApp != ""){
                Console.WriteLine($"Aplicativo {nomeApp} instalado com sucesso no seu Iphone!");
            } else {
                Console.WriteLine("É preciso fornecer o nome do App a ser instalado");
            }
            
        }

        public override void ExibirConfiguracoes()
        {
            Console.WriteLine($"Ficha Técnica do seu Iphone:\nModelo:{Modelo}\nImei:{Imei}\nMemória:{Memoria}\nCor:{Cor}");
        }
    }
}