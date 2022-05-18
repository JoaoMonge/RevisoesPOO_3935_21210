

//Revisões

/*
    Programação orientada a objectos - 
    
        Simplifica o código e aproxima o mesmo do mundo real
        Reduz o código duplicado 
        Consegue garantir alguma segurança nos acessos das variáveis
        Organiza melhor todo código
        É flexivel a mudanças 
        
    4 Pilares da POO:
        
        Herança -> 
            Classe Mãe e filhas onde todos os filhos da classe herdam as propriedades e métodos da Mãe
            Exemplo: Ver classe Mae.cs e Filha.cs e Filho.cs
    
*/

using RevisoesPOO_3935_21210;

Mae mae = new Mae("Mae",30);
Mae mae2 = new Mae("Mae", 30);



Console.WriteLine("Classe1: {0} {1} {2} Classe2: {3} {4} {5}",mae.Nome,mae.Idade,mae.Partilhada,mae2.Nome,mae2.Idade,mae2.Partilhada);

mae.alterarPartilhada("Olá");

Console.WriteLine("Classe1: {0} {1} {2} Classe2: {3} {4} {5}",mae.Nome,mae.Idade,mae.Partilhada,mae2.Nome,mae2.Idade,mae2.Partilhada);
//QUAL O OUTPUT:
// Classe1: Mae 30 Classe2: Mae2 25

Filho f = new Filho("Filho", 10);
f.alterarPartilhada("Mudei através do filho");
Console.WriteLine("Classe1: {0} {1} {2} Classe2: {3} {4} {5} Classe3: {6} {7} {8}",mae.Nome,mae.Idade,mae.Partilhada,mae2.Nome,mae2.Idade,mae2.Partilhada,f.Nome,f.Idade,f.Partilhada);
f.teste();

mae.teste();
Mae fil = new Filho("J",30);
fil.teste();

/*
    Encapsulamento -> Serve para limitar os acessos a variáveis
    
        private   -> Apenas na própria classe é possivel o acesso
        public    -> Acesso disponivel a partir de qualquer lugar do código
        protected ->  Apenas na própria classe e filhos dessa classe é possivel o acesso
        internal  -> Acesso permitido apenas no assembly do método

    Polimorfismo -> Capacidade de ter várias formas
    
        Podemos guardar um filho na variável Mae
        Mae filho = new Filho()
        Isto permite então que uma lista de Mae possa receber qualquer dos filhos
        
    Abstração    -> 
    
        Uma classe abstrata não pode ser instânciada -> Não se pode criar objectos da classe Abstracta
        Um método declarado como abstrato não têm código na classe abstracta têm apenas a assinatura. 
        No entanto é obrigatório a sua implementação na classe que herdar a abstracta
*/