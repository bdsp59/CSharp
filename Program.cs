using System;//Biblioteca de entrada e saída padrão de dados para c#

namespace Aula02/*Local aonde será armazenado todos os objetos, classes, elementos do programa. É possível
criar mais de um namespace para ajudar na organização do programa.
*/
{
    class Program//Classe do programa
    {
        static void Main(string[] args)//Main da classe Program. Com entrada simples de um array de string(argumentos)
        {
            Console.WriteLine("Hello World!");//Comando para escrever no console, só que nesse caso ele pula uma linha ao acabar o texto
            if(args.GetLength(0)>0){
                Console.Write(args.GetValue(0));
            }
        }
    }
}
