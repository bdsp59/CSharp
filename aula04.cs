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

Tipos de modificadores de classe(Define a visibilidade da classe):
-public: Pública, sem restrição de visualização. Qualquer outra classe, método, programa pode acessar esse tipo.
-abstract: Classe-base para outras classes, não pode instanciar objetos dessa classe. Não podemos criar objetos
a partir de uma classe abstract.
-sealed: Classe não pode ser herdada.
-static: Classe não permite a instanciação de objetos e seus membros devem ser static. Podemos acessar as pro-
priedades e os membros dessas classes.

Tipos de especificadores de classes(Onde um membro da classe pode ser acessado):
-public: Sem restrição de acesso;
-private: Só podem ser acessados pela própria classe
-protected: Podem ser acessados na própria classe e nas classes derivadas(filhas)
-abstract: Os métodos não tem implementações, somente os cabeçalhos. Usadas em classes pais para definir os 
métodos que devem existir, mas somente serão implementados em métodos nas classes filhos.
-sealed: O método não pode ser redefinido. Não pode ter overwrite(sobreposição), não permite polimorfismo.
-virtual: O método pode ser redefinido em uma classe derivada
-static: O método pode ser chamado mesmo sem a instanciação de um objeto

using System;

public class Jogador{
    public int energia = 100;
    public bool vivo = true;
}

public class Aula28{
    static void Main(){
        Jogador j1 = new Jogador();
        Jogador j2 = new Jogador();
        Jogador j3 = new Jogador();

        j1.energia = 50;->Alteramos o valor da energia do objeto jogador 1
        Console.WriteLine("Energia do jogador 1: {0}", j1.energia);
        Console.WriteLine("Energia do jogador 2: {0}", j2.energia);->A energia que está ligada a jogador 2 independe 
        do que acontece com a dos outros objetos jogador
    }
}
*/

/*
Métodos Construtores
Tem como objetivo inicializar as variáveis contidas dentro do classe para reservar o espaço de memória necessário 
para a utilização desse método ao longo do programa. Mesmo que não seja iniciado pelo programa, o próprio c# cria
um construtor default responsável por separar a memória. Para criar um método construtor devemos apenas criar 
um método com o mesmo nome da classe. E por padrão não declaramos valores ao iniciar a classe, mas sim ao chamar
o método construtor.
Declaramos os métodos construtores dentro das classes para que as classes quando forem inicializadas, as suas
variavéis já sejam atribuídas. Podemos ter paramêtros que devem ser atribuidos na hora de instanciar as classes.

using System;

public class Jogador{
    public int energia;
    public bool vivo;
    public string nome;

    public Jogador(string nome){
        energia = 100;
        vivo = true;
        this.nome = nome;
    }
}

public class Aula28{
    static void Main(){
        Jogador j1 = new Jogador("Bruno");
        Jogador j2 = new Jogador("Lucas");

        Console.WriteLine("Nome/Energia do jogador 1: {0} {1}", j1.nome, j1.energia);
        Console.WriteLine("Nome/Energia do jogador 2: {0} {1}", j2.nome, j2.energia);
    }
}

Método destrutor
É um método que é executado quando a classe for destruído, ele é chamado antes do objeto ser destruído pelo 
garbage collector. Quando o programa ver que não precisa mais do objeto e for descartar o objeto é quando o 
método destrutor vai ser chamado. Para criar um método destrutor temos apenas que criar um método com um nome 
da classe, mas colocando um til na frente do nome.

using System;

public class Jogador{
    public int energia;
    public bool vivo;
    public string nome;

    public Jogador(string nome){
        energia = 100;
        vivo = true;
        this.nome = nome;
    }

    ~Jogador(){
        Console.WriteLine("Jogador {0} foi destruído", this.nome);
    }
}

public class Aula28{
    static void Main(){
        Jogador j1 = new Jogador("Bruno");
        Jogador j2 = new Jogador("Lucas");

        Console.WriteLine("Nome/Energia do jogador 1: {0} {1}", j1.nome, j1.energia);
        Console.WriteLine("Nome/Energia do jogador 2: {0} {1}", j2.nome, j2.energia);
    }
}
*/

/*
Sobrecarga de construtores
É quando criamos mais construtores de uma mesma classe, mas com diferentes quantidade e tipos de parametros para
que possam sobreescrever o outro construtor. Permitindo assim diferentes métodos de implementar uma mesma classe.

using System;

public class Jogador{
    public int energia;
    public bool vivo;
    public string nome;

    public Jogador(){
        energia = 100;
        vivo = true;
        nome = "Jogador";
    }
    public Jogador(string nome){
        energia = 100;
        vivo = true;
        this.nome = nome;
    }
    public Jogador(string nome, int energia){
        this.nome = nome;
        this.energia = energia;
        vivo = true;
    }
    public Jogador(string nome, int energia, bool vivo){
        this.nome = nome;
        this.energia = energia;
        this.vivo = vivo;
    }

    public void info(){
        Console.WriteLine("Nome do jogador: {0}", nome);
        Console.WriteLine("Energia do jogador: {0}", energia);
        Console.WriteLine("Estado jogador: {0}", vivo);
        Console.WriteLine("");
    }

    ~Jogador(){
        Console.WriteLine("Jogador {0} foi destruído", this.nome);
    }
}

public class Aula30{
    static void Main(){
        Jogador j1 = new Jogador();
        Jogador j2 = new Jogador("Lucas");
        Jogador j3 = new Jogador("Bruno", 100);
        Jogador j4 = new Jogador("Theo", 100, true);
        Jogador j5 = new Jogador("Matheus", 0, false);

        j1.info();
        j2.info();
        j3.info();
        j4.info();
        j5.info();
    }
}
*/

/*
Classe Static
Não permitem a instanciação de objetos da classe que for static. Como não podemos declarar objetos, não temos 
métodos construtores, a classe não permite. Ele tem essa característica, pois ele tem um espaço fixo na memória.
Como ele já cria um espaço fixo na memória não há necessicidade de se instaciar o objeto para separar o espaço
da memória. Todos os membros de uma classe static tem que ser do tipo static(propriedades e métodos).
Uma classe não static pode ter uma classe static.
using System;

static public class Jogador{
    static public int energia;
    static public bool vivo;
    static public string nome;

    static public void iniciar(string n){
        energia = 100;
        vivo = true;
        nome = n;
    }

    static public void info(){
        Console.WriteLine("Nome do jogador: {0}", nome);
        Console.WriteLine("Energia do jogador: {0}", energia);
        Console.WriteLine("Estado jogador: {0}", vivo);
        Console.WriteLine("");
    }
}

class Inimigo{
    static public bool alerta;
    public string nome;

    public Inimigo(String n){
        alerta = false;
        nome = n;
    }
    public void info(){
        Console.WriteLine(nome);
        Console.WriteLine(alerta);
        Console.WriteLine("-----------------------------------");
    }
}

public class Aula30{
    static void Main(){

        Jogador.iniciar("Bruno");
        Jogador.info();

        Inimigo i1 = new Inimigo("Goblin");
        Inimigo i2 = new Inimigo("Esqueleto");
        Inimigo i3 = new Inimigo("Gosma");

        Inimigo.alerta = true;//Como o alerta é do tipo static quando trocamos o valor nessa linha troca o valor
        de todos os objetos inimigos, já que eles ocupam o mesmo espaço de memória.

        i1.info();
        i2.info();
        i3.info();
    }
}
*/

/*
Operador this
Serve para referenciar uma variável global dentro de um método que possua uma variável local com o mesmo nome.
*/

/*
Herança
É quando temos classes que derivam, ou seja, classes que herdam as características de uma outra classe. A classe
filha tem as mesmas características da classe pai só que, dependendo do modificador de acesso, podem alterar o 
valor das variáveis que vem da classe pai e permite que sejam criados novas variáveis para atender as caracterís-
ticas especifícas da classe filho.
using System;

class Veiculo{
    public int velMax, rodas;
    private bool ligado;

    public void ligar(){
        ligado = true;
    }
    public void desligar(){
        ligado = false;
    }
    public string getLigado(){
        if(ligado){
            return "Sim";
        }else{
            return "Não";
        }
    }
}

class Carro:Veiculo{
    public String nome, cor;

    public Carro(String nome, String cor){
        desligar();
        rodas = 4;
        velMax = 120;
        this.nome = nome;
        this.cor = cor;
    }
}

class Aula34{
    static void Main(){
        Carro c1 = new Carro("C4", "Vermelho");
        Console.WriteLine("Nome do carro: {0}\nCor do carro: {1}\nRodas: {2}\nVelocidade Máxima: {3}\nEstá ligado: {4}", c1.nome, c1.cor, c1.rodas,c1.velMax,c1.getLigado());
    }
}
*/

/*
Construtor da classe base
Quando a classe base tem um construtor e temos que utiliza-lo na classe filho temos que ao fazer o construtor da classe filho temos que colocar : e "base", assim dizemos que é uma 
referência ao construtor da classe pai e por onde podemos passar valores a qualquer paramêtro que o construtor da classe pai tenha.

using System;

class Veiculo{
    public int velMax;
    private int rodas;
    private bool ligado;

    public Veiculo(int rodas){
        this.rodas = rodas;
    }

    public void ligar(){
        ligado = true;
    }
    public void desligar(){
        ligado = false;
    }
    public string getLigado(){
        //Podemos reduzir o código desse método usando o operador ternário, que seria colocar a expressão de if como uma linha única que vai realizar todo o teste.
        //A estrutura do operador é: (teste?valor_verdadeiro:valor_falso)
        return (ligado?"Sim":"Não");
    }
    public int getRodas(){
        return rodas;
    }
}

class Carro:Veiculo{
    public String nome, cor;

    public Carro(String nome, String cor):base(4){       
        ligar();
        velMax = 120;
        this.nome = nome;
        this.cor = cor;
    }
}

class Aula35{
    static void Main(){
        Carro c1 = new Carro("C4", "Vermelho");
        Console.WriteLine("Nome do carro: {0}\nCor do carro: {1}\nRodas: {2}\nVelocidade Máxima: {3}\nEstá ligado: {4}", c1.nome, c1.cor, c1.getRodas(),c1.velMax,c1.getLigado());
    }
}

*/

/*
Cadeia de herança
É quando começamos a ter classes filho de uma classe que já é uma classe filho, ou seja, geramos uma classe neto. Quando isso ocorre podemos dizer que a classe avô é a base de tudo e
podemos usar e manipular(desde que seja autorizado pelo modificador de acesso) na classe neto qualquer variável da classe pai e da classe avô. 
Isso permite que agrupemos dados comuns em classes pais ou avôs e ir gerando mais classes filhos e netos com dados mais específicos, fazendo assim com que o programa tenha mais classes,
mas que podem cada vez ser mais especializadas e permitindo que somente se adicione uma nova classe e não que seja necessário a alteração de todo o código.
using System;

class Veiculo{
    public int velMax;
    private int rodas;
    private bool ligado;

    public Veiculo(int rodas){
        this.rodas = rodas;
    }

    public void ligar(){
        ligado = true;
    }
    public void desligar(){
        ligado = false;
    }
    public string getLigado(){
        //Podemos reduzir o código desse método usando o operador ternário, que seria colocar a expressão de if como uma linha única que vai realizar todo o teste.
        //A estrutura do operador é: (teste?valor_verdadeiro:valor_falso)
        return (ligado?"Sim":"Não");
    }
    public void setRodas(int rodas){
        if(rodas<0){
            this.rodas = 0;
        }else if(rodas>40){
            this.rodas = 40;
        }else{
            this.rodas = rodas;
        }
    }
    public int getRodas(){
        return rodas;
    }
}

class Carro:Veiculo{
    public String nome, cor;

    public Carro(String nome, String cor):base(4){       
        ligar();
        velMax = 120;
        this.nome = nome;
        this.cor = cor;
    }
}

class CarroCombate:Carro{
    public int municao;
    public CarroCombate():base("Monster", "Verde"){
        municao = 100;
        setRodas(6);
    }
}

class Aula35{
    static void Main(){
        Carro c1 = new Carro("C4", "Vermelho");
        Console.WriteLine("Nome do carro: {0}\nCor do carro: {1}\nRodas: {2}\nVelocidade Máxima: {3}\nEstá ligado: {4}", c1.nome, c1.cor, c1.getRodas(),c1.velMax,c1.getLigado());
        CarroCombate cc1 = new CarroCombate();
        Console.WriteLine("");
        Console.WriteLine("Nome do carro: {0}\nCor do carro: {1}\nRodas: {2}\nVelocidade Máxima: {3}\nEstá ligado: {4}\nMunição:{5}", cc1.nome, cc1.cor, cc1.getRodas(),cc1.velMax,cc1.getLigado(), cc1.municao);
    }
}
*/

/*
Membros Protected
Os membros declarados como protected indica que apenas a própria classe e as classes filhas(derivadas) que podem ter métodos que acessam essas variáveis, sendo assim somente as classes
que herdam outras podem alterar o valor sem a necessidade que a classe original tenha um método public para fazer essas alterações.

using System;

class Veiculo{
    public int velAtual;
    private int velMax;
    protected bool ligado;

    public Veiculo(int velMax){
        velAtual = 0;
        this.velMax = velMax;
        ligado = false;
    }

    public bool getLigado(){
        return ligado;
    }
    public int getVelMax(){
        return velMax;
    }
}

class Carro:Veiculo{
    public string nome;

    public Carro(string nome, int vm):base(vm){
        this.nome = nome;
        ligado = true;
    }

}

class Aula36{
    static void Main(){
        Carro c1 = new Carro("Vectra", 120);
        Console.WriteLine("Nome: {0} \nVelocidade Máxima: {1} \nLigado: {2}", c1.nome,c1.getVelMax(),c1.getLigado());
    }
}
*/

/*
Ordem de execução dos métodos construtores em herança
A ordem de execução sempre será da classe base até a classe derivada que estamos inicializando. 

using System;

class Base{
    public Base(){
        Console.WriteLine("Construtor da classe Base");
    }
}

class Derivada1:Base{
    public Derivada1(){
        Console.WriteLine("Construtor da Derivada 1");
    }
}

class Derivada2:Derivada1{
    public Derivada2(){
        Console.WriteLine("Construtor da Derivada 2");
    }
}

class Aula37{
    static void Main(){
        Derivada2 teste = new Derivada2();
    }
}
*/

/*
Métodos virtuais
São métodos que possuem o mesmo nome, mas em classes diferentes. Quando temos uma classe derivada que tem um método com o mesmo nome, mas que tem uma execução diferente da classe base
(podendo ser executar algo a mais ou alterar algo que o método fazia na classe base), então chamamos esse método de virtual. Basicamente, sobrescrevemos o método na classe derivada.
Para podermos usar esses métodos virtuais temos que indicar que o método na classe base é virtual e que na classe derivada ele deve sobrescrever o método da classe base(usando o 
override). Como podemos sobreescrever um método em mais de uma classe derivada da classe base, temos que ter uma maneira de conseguir imprimir apenas o que queremos daquela classe deri
vada, sem que seja sobrescrita por outra. Temos duas maneiras de fazer isso:
1-Criando um objeto para cada classe e chamando eles separadamente
static void Main(){
        Derivada1 derivada1 = new Derivada1();
        Derivada2 derivada2 = new Derivada2();
        derivada1.Info();
        derivada2.Info();
    }
2-Fazendo com que o objeto da classe base funcione como uma referência, ou seja, vamos fazer com que esse objeto receba o objeto da classe certa.
static void Main(){
        Base Ref;//Temos que usar Ref com letra maiúscula obrigatoriamente
        Derivada1 derivada1 = new Derivada1();
        Derivada2 derivada2 = new Derivada2();

        Ref = derivada2;
        Ref.Info();
    }

using System;

class Base{
    public Base(){
        Console.WriteLine("Construtor da classe Base");
    }

    virtual public void Info(){}//Como ele é um método que vai ser sobreescrito não precisamos implementa-lo
}

class Derivada1:Base{
    public Derivada1(){
        Console.WriteLine("Construtor da Derivada 1");
    }
    override public void Info(){
        Console.WriteLine("Derivada 1");
    }
}

class Derivada2:Derivada1{
    public Derivada2(){
        Console.WriteLine("Construtor da Derivada 2");
    }
    override public void Info(){
        Console.WriteLine("Derivada 2");
    }
}

class Aula37{
    static void Main(){
        Base Ref;//Temos que usar Ref com letra maiúscula obrigatoriamente
        Derivada1 derivada1 = new Derivada1();
        Derivada2 derivada2 = new Derivada2();

        Ref = derivada2;
        Ref.Info();
    }
}
*/

/*
Classes e métodos abstratos
Tanto a classe abstrata como o método abstrato servem como referência para outras classes, ou seja, servem como base para outras classes. Os métodos abstratos não são implementados, 
eles apenas servem como protótipos(referência), como são para que sejam implementados nas classes que herdam as classes abstratas. Dentro da classe abstrata podemos ter métodos abstratos e não 
abstratos, sendo assim os métodos não abstratos terão que ser implementados. Classes abstratas não podem ser instanciadas.

using System;

abstract class Veiculo{
    protected int velMax, velAtual;
    protected bool ligado;

    public Veiculo(){
        ligado = false;
        velAtual = 0;
    }

    public void setLigado(bool ligado){//Como não é um método abstract temos que implementa-lo na classe base
        this.ligado = ligado;
    }

    public int getVelAtual(){
        return velAtual;
    }
    abstract public void aceleracao(int mult);//Como é um método abstract temos que implementa-lo na classe derivada

}

class Carro:Veiculo{
    public Carro(){
        velMax = 120;
    }
    override public void aceleracao(int mult){
        velAtual += 10*mult;
    }
}

class Aula39{
    static void Main(){
        Carro c1 = new Carro();
        c1.aceleracao(1);
        c1.aceleracao(1);
        c1.aceleracao(-1);
        Console.WriteLine(c1.getVelAtual());
    }
}
*/