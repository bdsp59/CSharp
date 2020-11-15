/*Constantes -> Para declarar uma constante em c# temos que adicionar o const antes de declarar a variável

using System;

class aula04{
    static void Main(){
        const double pi = 3.1415;
        const String nome = "Bruno";

        Console.WriteLine("Nome {0} / Valor {1}", nome, pi);//O {0} indica que devemos trazer o primeiro elemento após a virgula. Cada elemento após a virgula será indexado.
    }
}
*/

/*
Lendo valores do teclado: Comandos e forma de ler valores pelo teclado

using System;

class Aula08{
    static void Main(){
        int v1, v2, soma;
        String nome;

        Console.Write("Digite seu nome: ");
        nome = Console.ReadLine();
        Console.WriteLine(nome);
        Console.Write("Digite o primeiro valor: ");
        v1 = int.Parse(Console.ReadLine()); -> Converte de String para inteiro
        Console.Write("Digite o segundo valor: ");
        v2 = Convert.ToInt32(Console.ReadLine()); -> Converte de String para inteiro
        Console.WriteLine("A soma de {0} com {1} é: {2}", v1, v2, soma);
    }
}
*/

/*
Operadores BitWise -> Operadores para mover os elementos do byte, de modo a alterar o valor binário. Se deslocar
mos para esquerda é o mesmo que dizer que dobramos o valor, já para a direita que dividimos o valor por 2.
<< - Deslocamento para a esquerda(Devemos colocar um número depois desse sinal para indicar quantas vezes ele quer deslocar)
>> - Deslocamento para a direita(Devemos colocar um número depois desse sinal para indicar quantas vezes ele quer deslocar)
*/

/*
Enum -> Usamos para criar um tipo próprio com valores pré-definifidos. O que estiver relacionado a esse elemento
somente poderá receber elementos que já tenham sido pré-definidos pelo programador como valores válidos. E faze
mos referência aos elementos usando os indices de cada um.

using System;

class Aula10{

    enum diasdasemana{Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado};

    static void Main(){
        diasdasemana ds = diasdasemana.Domingo;//Fizemos o elemento ds receber o valor Domingo
        Console.WriteLine(ds);

        diasdasemana ds2 = (diasdasemana)3;//Nesse caso estamos fazendo um typecast para passar um valor para ds2, ele vai receber o terceiro elemento da lista de valores possíveis em enum
        Console.WriteLine(ds2);

        int ds3 = (int)diasdasemana.Sexta;//Nesse caso convertemos o valor sexta do enum no indice relacionado a ele. 
        Console.WriteLine(ds3);
    }
}
*/

/*
Operações de typecast(conversão de tipos) -> Converte de um tipo para outro.
Algumas conversões são implicitas e não precisam do typecast, mas aquelas que não são implicitas precisam que 
seja especificado para qual tipo se deve converter, desde que seja possível. Mais utilizado quando começamos a 
trabalhar com formulários que aí precisamos converter para tipos diferentes dos primitivos.
using System;

class Aula11{
    static void Main(){
        float n1 = 15.6f;
        int n2 = (int)n1;

        Console.WriteLine(n2);
    }
}

*/

/*
Condicional IF -> 
if(condição){
    Bloco de comandos
}

Condicional IF...ELSE ->
if(condição){
    Bloco de comandos
}else if(condição){
    Bloco de comandos
}else{
    Bloco de comandos
}

Condicional IF aninhado-> Termo usado quando usamos um if dentro de outro if
*/

/*
Comando Switch...case-> O switch case funciona da sequinte maneira, ele tem um valor que ele vai receber dentro
do switch e que vai ser comparado com os valores que teremos nos cases. Aquele que tiver um valor correspondente
é o bloco de comandos que vamos executar.

using System;

class aula15{
    static void Main(){
        int tempo = 0;
        char escolha = ' ';
        Console.WriteLine("Belo Horizonte/MG a Vitória/ES");
        Console.WriteLine("Escolha o transporte: [(a)avião | (c)carro | (o)ônibus");
        escolha = char.Parse(Console.ReadLine());

        switch(escolha){
            case 'a':
            case 'A'://Caso seja digitado a letra maiúscula
                tempo = 50;
                break;//Temos sempre que terminar com o break para encerrar esse case
            case 'c':
            case 'C':
                tempo = 480;
                break;
            case 'o':
            case 'O':
                tempo = 660;
                break;
            default://Se inserir um valor que não está nos cases
                tempo = -1;
                break;
        }
        if(tempo<0){
            Console.WriteLine("Transporte inválido");
        }else{
            Console.WriteLine("Para o transporte escolhido o tempo é: " + tempo + " minutos");    
        }
    }
}

*/


/*
Comando goto: Comando responsável por indicar para onde a execução do programa deve seguir, temos que criar um
label e mandar, através do goto, que esse programa vá para esse label.

using System;

class aula15{
    static void Main(){
        int tempo = 0;
        char escolha = ' ';

        inicio:

        Console.Clear();//Comando responsável por limpar o console

        Console.WriteLine("Belo Horizonte/MG a Vitória/ES");
        Console.WriteLine("Escolha o transporte: [(a)avião | (c)carro | (o)ônibus");
        escolha = char.Parse(Console.ReadLine());

        switch(escolha){
            case 'a':
            case 'A'://Caso seja digitado a letra maiúscula
                tempo = 50;
                break;//Temos sempre que terminar com o break para encerrar esse case
            case 'c':
            case 'C':
                tempo = 480;
                break;
            case 'o':
            case 'O':
                tempo = 660;
                break;
            default://Se inserir um valor que não está nos cases
                tempo = -1;
                break;
        }
        if(tempo<0){
            Console.WriteLine("Transporte inválido");
        }else{
            Console.WriteLine("Para o transporte escolhido o tempo é: " + tempo + " minutos");    
        }
        Console.WriteLine("Calcular outro transporte?[s/n]");
        escolha = char.Parse(Console.ReadLine());
        if(escolha == 's' || escolha == 'S'){
            goto inicio;
        }else{
            Console.Clear();
            Console.WriteLine("Fim do programa");
        }
    }
}
*/

/*
Array
int[] n = new int[5];
int[] num = new int[3]{55,77,99}; -> Nessa linha temos uma outra maneira de inicializar um vetor e nesse formato
já declaramos que valores ele vai ter.
int[] num = {55,77,99}; -> Outra forma de declarar o vetor sem precisar inicializar, o tamanho do vetor vai ser
definido pela quantidade de elementos que nos declaramos ao cria-lo.

Matrizes
int[,] matriz = new int[5,3];
int[,] matriz = new int[2,2]{{10,20},{30,40}};
Para inserir elementos na matriz é necessário inserir tanto a posição da linha quanto da coluna. matriz[0,0]
*/

/*
For
for(inicio; fim; incrementação ou decrementação){
    bloco de comandos
}

While
while(condição){
    bloco de comandos
}

Do...While
do{
    bloco de comandos
}while(condição);

Foreach->Lê elementos de uma coleção
foreach(int n in num){//O elemento que ele vai receber tem que ser do mesmo tipo que a coleção que ele quer ler.
Somente com esse parâmetro ele faz a mesma coisa que o for, já que ele vai percorrer todos os elementos do 0 ao 
máximo dessa coleção.
    Comando para impressão
}
*/

/*
Classe Random:
Random random = new Random();
random.Next() -> retorna o próximo valor do Random
random.Next(50) -> retorna o próximo valor do Random entre 0 e 49
random.Next(50, 100) -> retorna o próximo valor do Random entre 50 e 99
*/

/*
Métodos da classe array(Para Vetores e Matrizes): Vou listar todos os métodos que podem ser utilizados por vetores
e matrizes para trabalhar com eles.
BinarySearch -> Retorna um inteiro que é a posição do elemento que estamos procurando. Se retornar o -1, então 
o elemento não está no array. Tem como parâmetros o array aonde vamos buscar e o valor que vamos procurar.
public static int BinarySearch(array, valor);
chamada: Array.BinarySearch(ARRAY, VALOR);

Copy -> Ele faz a cópia dos elementos de um vetor para outro vetor. Tem como parametros o array de onde vamos
copiar os elementos, o array para onde vamos copiar e a quantidade de elementos que desejamos copiar.
public static void Copy(Array_origem, Array_destino, Quantidade de elementos)
chamada: Array.Copy(Array_origem, Array_destino, Quantidade de elementos)

CopyTo -> Ele faz uma cópia dos elementos de um vetor, mas ele funciona de forma diferente do método Copy, ele 
vem do próprio array e não da classe Array. E ele tem como paramêtros o array de destino e a partir de qual 
elemento devemos copiar.
public void CopyTo(Array_destino, A_partir_de_qual_posição);
chamada: nome_vetor.CopyTo(vetor, posição)

GetLongLength -> Retorna a quantidade de elementos de um vetor ou de uma dimensão da matriz. Tem como parametro
a dimensão de onde desejamos obter a informação, se for um vetor a dimensão é 0, mas se for uma matriz indicamos 
de qual dimensão queremos saber a quantidade de elementos.
public long GetLongLength(dimensão);
chamada: nome_vetor.GetLongLength(0);
         nome_matriz.GetLongLength(dimensão);

GetLowerBound -> Retornar o menor indice do vetor ou matriz. Tem como parametro a dimensão da onde desejamos o 
obter a informação, se for um vetor sempre será dimensão 0, mas se for uma matriz indicamos de qual dimensão 
queremos tirar o menor indice.
public int GetLowerBound(dimensão);
chamada: nome_vetor.GetLowerBound(0);
         nome_matriz.GetLowerBound(dimensão);

GetUpperBound -> Retornar o maior indice do vetor ou matriz. Tem como parametro a dimensão da onde desejamos o 
obter a informação, se for um vetor sempre será dimensão 0, mas se for uma matriz indicamos de qual dimensão 
queremos tirar o maior indice.
public int GetUpperBound(dimensão);
chamada: nome_vetor.GetUpperBound(0);
         nome_matriz.GetUpperBound(dimensão);

GetValue -> Retorna um object, como podemos ter matrizes e vetores de elementos diferentes de valor temos que
usar o object, com o valor do indice indicado. Para podermos pegar como numeral temos que fazer um cast de 
valor na função. Tem como parametro o valor do índice que estamos buscando.
public object GetValue(long índice);
chamada: Convert.toInt32(nome_vetor.GetValue(indice));
         Convert.toInt32(nome_matriz.GetValue(indice_linha, indice_coluna));

IndexOf -> Retorna o índice do valor que for indicado como parâmetro, retorna a primeira ocorrência desse valor.
Tem como parametros um array e o valor que desejamos encontrar.
public static int IndexOf(array, valor);
chamada: Array.IndexOf(nome_vetor, valor_desejado); 

LastIndexOf -> Retorna o índice do valor que for indicado como parâmetro, retorna a última ocorrência desse 
valor. Tem como parametros um array e o valor que desejamos encontrar.
public static int LastIndexOf(array, valor);
chamada: Array.LastIndexOf(nome_vetor, valor_desejado); 

Reverse -> Ele inverte a ordem dos valores do vetor. Tem como parametro o array que desejamos inverter.
public static void Reverse(array);
chamada: Array.Reverse(nome_vetor);

SetValue -> Faz com que um valor seja setado, colocado na posição indicada do vetor. Tem como parametros o ele-
mento que se deseja inserir(que deve ser declarado como object) e a posição de onde inserir.
public void SetValue(object valor, posição);
chamada: nome_vetor.SetValue(valor, posição);

Sort -> Ordena em ordem crescente os elementos do vetor. Tem como parametro o vetor que se deseja ordenar.
public static void Sort(vetor);
chamada: Array.Sort(nome_vetor);
*/

/*
Métodos
É um bloco nomeado com um conjunto de instruções que realizam uma função específica e que podem ser chamados ao
longo do programa diversas vezes. Podem ser métodos que não precisam retornar nada, mas também existem métodos
que retornam alguma coisa. Caso o método main seja static todos os métodos que criarmos tem que ser static.
using System;

class aula24{
    static void Main(){
        escrever();
    }

    static void escrever(){
         Console.WriteLine("Estudos C#");
    }
}
*/

/*
Passagem por valor -> Passamos um valor que será usado no método, mas que não terá o seu valor alterado. Somente
serve para passar um valor.

class aula25{
    static void Main(){
        int num = 10;
        dobrar(num);
        Console.WriteLine(num);
    }

    static void dobrar(int valor){
        valor *= 2;
    }
}

Passagem por referência -> Funciona como se fosse um ponteiro. Temos que passar a referência ao valor como se 
fosse o endereço aonde está o valor. Para fazer um valor se tornar por referência temos que colocar um ref na 
frente da declaração da variável para que seja atribuido como endereço. Assim sendo o ref faz com que o que seja
enviado o endereço de memória que armazena o dado, assim quando realizar a operação dentro do método o valor da
variável será alterado.
using System;

class aula25{
    static void Main(){
        int num = 10;
        dobrar(ref num);
        Console.WriteLine(num);
    }

    static void dobrar(ref int valor){
        valor *= 2;
    }
}
*/

/*
Argumento Out
Esse argumento faz com que o método seja capaz de retornar mais de um valor. Temos que declarar o valor como um
paramento de saída, então usamos o argumento out antes de declarar a variável para que seja indicado que ele é 
de saída. Com isso podemos retornar vários elementos em um mesmo método, já que podemos criar quantos outs 
quisermos.

using System;

class aula26{
    static void Main(){
        int divid, divis, quoc, rest;
        divid = 10;
        divis = 5;
        quoc = divide(divid, divis, out rest);
        Console.WriteLine("{0}/{1}: Quociente = {2} e resto = {3}", divid, divis, quoc, rest);
    }
    static int divide(int dividendo, int divisor, out int resto){
        int quociente;
        quociente = dividendo/divisor;
        resto = dividendo%divisor;
        return quociente;
    }
}

Argumento params
O argumento params tem como objetivo resolver o problema de ter que toda vez que quiser adicionar um novo
parametro ter que digitar na entrada do método e ir adicionando dentro do método aonde ele deve ser alterado.
O params serve para indicar que o método pode receber nenhum ou n valores como parametros, ele funciona como um
vetor, tanto que temos que declara-lo como um vetor e o tipo dos elementos que ele vai receber. Ao se trabalhar
com o params é preciso tomar cuidado como manipula-lo dentro do método.

using System;

class aula27{
    static void Main(){
        soma(10, 5);
    }
    static void soma(params int[] n){
        int resp = 0;
        if(n.Length < 1){
            Console.WriteLine("Não existem valores a serem somados");
        }else if(n.Length < 2){
            Console.WriteLine("Não possuem elementos suficientes a serem somados.");
        }else{
            for(int i = 0; i<n.Length; i++){
                resp += n[i];
            }
            Console.WriteLine("A soma é: {0}", resp);
        }
    }
}

*/

/*
Classes
É um tipo de dado composto por membros: Propriedades, que são as variáveis, e Métodos, que são as funções da 
classe. A classe é a base do objeto, cada objeto vai ter suas características independentes, mas qualquer funcio
nalidade do objeto vai depender de como as classes que ele utiliza forem implementadas.
Forma padrão de uma classe:
    [ModificadorClasse] class NOME_DA_CLASSE{
        //Variáveis / propriedade
        [EspecificadorAcesso] tipo NOME_PROPRIEDADE;

        //Métodos
        [EspecificadorAcesso] retorno NOME_METODO([arg1,...]){
            //Corpo do método
        }
    }

Tipos de modificadores de classe que temos:
-public: Pública, sem restrição de visualização. Qualquer outra classe, método, programa pode acessar esse tipo.
-abstract: Classe-base para outras classes, não pode instanciar objetos dessa classe. Não podemos criar objetos
a partir de uma classe abstract.
-sealed: Classe não pode ser herdada.(Funciona como o private do Java)
-static: Classe não permite a instanciação de objetos e seus membros devem ser static. Podemos acessar as pro-
priedades e os membros dessas classes.

*/