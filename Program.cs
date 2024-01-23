using System.ComponentModel;
using DesafioPOO.Models;

Console.WriteLine("Configurando Smartphone Nokia");
Nokia nokia = new Nokia("998980909", "C2V3", "00012399", 99);
nokia.Ligar();
nokia.InstalarAplicativo("Digital Innovation One");
nokia.JogarSnakeGame();
nokia.ExibirConfiguracoes();
Console.WriteLine("--------------------------------");
Console.WriteLine("");

Console.WriteLine("############################################");

Console.WriteLine("Configurando Smartphone Iphone");
Iphone iphone = new Iphone("998980909", "Iphone 14 PRO", "55564756", 250, "Dourado");
iphone.Ligar();
iphone.InstalarAplicativo("Kindle App");
iphone.FazerChamadaEmGrupo("9980901010", "999999999", "990000000");
iphone.ExibirConfiguracoes();
Console.WriteLine("--------------------------------");
