namespace RevisoesPOO_3935_21210;

public class Filho : Mae
{
    
    public Filho(string nome, int idade) : base(nome, idade)
    {
        
    }
    
    //Quando queremos modificar o comportamento de um método que já existe na classe mãe devemos fazer o override

    override public void teste()
    {
        Console.WriteLine("Eu sou um filho");
    }

   
}