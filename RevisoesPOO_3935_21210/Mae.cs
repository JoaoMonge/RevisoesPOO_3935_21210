namespace RevisoesPOO_3935_21210;

public class Mae
{
    //Field -> Refere-se a uma variavel
    private string nome;
    private int idade;

    //Variável que pertence à classe e não ás instâncias. Está variavel uma vez modificada irá ser modificada para todas as instâncias.  
    public static string partilhada = "";
    
    public Mae(string nome,int idade)
    {
        //O this refere-se à instância a ser criada
        this.nome = nome;
        this.idade = idade;
    }
    
    public Mae()
    {
        //Exemplo de polimorfismo
    }


    //Properties -> refere-se ao GET e SET
    public string Nome
    {
        get => nome;
        set => nome = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Idade => idade;

    public string Partilhada => partilhada;

    //Methods -> Métodos/Funções da classe
    public void alterarPartilhada(string texto)
    {
        partilhada = texto;
    }

    public void polimorfismo(string nome)
    {
        Console.WriteLine(nome);
    }
    
    public void polimorfismo(int idade)
    {
        Console.WriteLine(idade);
    }


    public virtual void teste()
    {
        Console.WriteLine("Eu sou a mãe");
    }

}