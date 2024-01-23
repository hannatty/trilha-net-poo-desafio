### Desafio Proposto
Criar um sistema em .NET, do tipo console, mapeando uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone. Programa desenvolvido com base em conceitos de POO utilizando C#.

### Classe Abstrata Smartphone
Atributos

- `Numero`: string
- `Modelo`: string
- `Imei`: string
- `Memoria`: int
  
Métodos:
- `Ligar`
- `InstalarAplicativo`
- `ExibirConfiguracoes`

### Classe Nokia
Herda da classe **Smartphone**. Não possui atributos extras, apenas os herdados.
  
Método extra:

- `JogarSnakeGame`

### Classe Iphone
Herda da classe **Smartphone**. 

Atributo extra:
- `Cor`: string

Método extra:

- `FazerChamadaEmGrupo`

Funcionalidade extra:
- `Testes unitários tanto da classe Nokia quanto da classe Iphone utilizando xUnit.`


## Tecnologias Utilizadas
<div style="display: inline_block">
  <img align="center" alt="JsIcon" height="30" width="40" src="https://github.com/devicons/devicon/blob/master/icons/csharp/csharp-plain.svg">
  <img align="center" alt="JsIcon" height="30" width="40" src="https://github.com/devicons/devicon/blob/master/icons/dotnetcore/dotnetcore-original.svg">
  
</div>
