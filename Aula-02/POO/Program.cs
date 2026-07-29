using System.Reflection;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        //comentário de linha
        /*
            Comentário de Bloco
            Pode ter várias linhas
        */

        // Escreve uma Linha de Texto na tela
        Console.WriteLine("Programação orienta a objetos\n");
        Console.WriteLine("Abstração - 1º pilar da POO");

        /* Criar uma classe em C# 
        a classe deve ser declarada fora do bloco do programa
        */
        /* Criar um objeto a partir de uma classe*/
    
        Pet pet1 = new Pet();
        pet1.nome = "Totó";
        pet1.tipo = "Cachorro";
        pet1.idade = 12;
        pet1.MostrarNome();

         Pet pet2 = new Pet();
        pet2.nome = "thomatinho";
        pet2.tipo = "Gato";
        pet2.idade = 12;
        pet2.MostrarNome();
    }    
        
        public class Pet // Sempre inicia com letras maiúsculas
    {
        // Declaração dos atributos
        public string nome;

        public string tipo;

        public int idade;
        //Declaração dos Métodos
        public  void MostrarNome()
        {
            Console.WriteLine("Meu nome é " + this.nome);
        }

    }
    
}