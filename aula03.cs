using System;

class Aula03{
    static void Main(){
        /*A linguagem C# é fortemente tipada, ou seja, devemos declarar o tipo antes de indicar o nome e o valor
        Ao criar uma variável, ao inves de simplesmente apontar para o endereço que deve ser alocada a variável(o que
        poderia fazer com que recebe-se um lixo qualquer como valor) ele aponta o endereço e já atribui o valor vazio
        para o elemento. Mas ainda é um bom padrão declarar o valor ao inicializar, mesmo que seja zero, para evitar
        erros.
        */
        int num = 0;
        char letra = 'c';
        float valor = 5.3f;//Ao trabalhar com float temos que colocar um f no final para indicar que é float
        byte n1 = 10;//O tipo byte armazena dados de valores 0 a 255(sem sinal)
        String nome = "Bruno";

        var aux = 10;//O operador var não identifica qual o tipo da variável, ele apenas declara que a variável existe. O tipo é definido no momento da declaração.
        var aux2 = nome;

        Console.WriteLine("Valor da variável: " + aux);
    }
}