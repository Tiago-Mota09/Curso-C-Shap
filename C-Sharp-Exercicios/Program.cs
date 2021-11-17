using System;

namespace C_Sharp_Exercicios
{
    //class Program
    //{
    //static void Main(string[] args)
    //{
    //====================================================
    //			Padrão C# Puro
    //====================================================
    // Using System;

    // class Program //Aula01
    // 	{
    // 		static void Main(string[] args){
    // 		Console.WriteLine("Olá Mundo!");		
    // 	}
    // }
    //====================================================
    //			Padrão .NET
    //====================================================
    //namespace Aula02 //padrão .NET
    //class Program
    //	{
    //		static void Main(string[] args)
    //			{
    //Console.WriteLine("Olá Mundo!");
    //if (args.GetLength(0) > 0)
    //{
    //    Console.Write(args.GetValue(0));
    //}
    //			}
    //		}
    //	}
    //====================================================
    //			Variáveis
    //====================================================
    // using System;

    // class aula03{
    // 	static void Main(){
    //byte n1 = 10;      //0 e 255
    //int num = 0;       //tipo primitivo
    //char letra = 'c';  //tipo primitivo
    //float valor = 5.3f; //tipo primitivo

    //         string nome = "Tiago";  //tipo referência


    //         var aux = nome;

    //Console.WriteLine("Valor da variável: " + aux);
    // 	}
    // }
    //====================================================
    //			Variáveis
    //====================================================
    //using System;

    //class aula04
    //{
    //    static int num = 9;

    //    static void Main()
    //        {
    //            int num2 = 0;       //tipo primitivo
    //        Console.WriteLine(num);

    //    }

    //}
    //====================================================
    //			Operadores
    //====================================================
    //using System;

    //class aula05
    //{

    //    static void Main()
    //       {
    //        int res = (9 + 5) * 9;  //tipo primitivo
    //        Console.WriteLine(res);

    //        bool res1 = (5>3)&(10<5);
    //        Console.WriteLine(res1);

    //        int num = 10;
    //        num*=2;
    //        Console.WriteLine(num);
    //    }
    //}
    //====================================================
    //			Formatações de Saída
    //====================================================
    //using System;

    //class aula06
    //{

    //    static void Main()
    //    {
    //        int n1, n2, n3;
    //        n1 = 10; n2 = 20; n3 = 30;
    //        Console.WriteLine("\nn1=\t{0}\nn2=\t{1}\nn3=\t{2}\n", n1, n2, n3);// \n = enter \t=tabulação

    //        double valorCompra = 5.50;
    //        double valorVenda;
    //        double lucro = 0.1;
    //        string produto = "Pastel";

    //        valorVenda = valorCompra + (valorCompra * lucro);

    //        Console.WriteLine("Produto........:{0,15}", produto); //{0=Indice da váriavel/ 15= espaçamento}
    //        Console.WriteLine("Val.Compra.....:{0,15:c}", valorCompra);//{:c = formatação monetária R$}
    //        Console.WriteLine("Lucro..........:{0,15:p}", lucro);//{:p= formatação percentual %}
    //        Console.WriteLine("ValVenda.......:{0,15:c}", valorVenda);
    //    }

    //}
    //====================================================
    //			Constantes
    //====================================================
    //class aula07
    //{

    //    static void Main()
    //    {
    //        int n1, n2, n3;
    //        n1 = 10; n2 = 20; n3 = 30;
    //        Console.WriteLine("\nn1=\t{0}\nn2=\t{1}\nn3=\t{2}\n", n1, n2, n3);// \n = enter \t=tabulação

    //        double valorCompra = 5.50;
    //        double valorVenda;
    //        double lucro = 0.1;
    //        string produto = "Pastel";

    //        valorVenda = valorCompra + (valorCompra * lucro);

    //        Console.WriteLine("Produto........:{0,15}", produto); //{0=Indice da váriavel/ 15= espaçamento}
    //        Console.WriteLine("Val.Compra.....:{0,15:c}", valorCompra);//{:c = formatação monetária R$}
    //        Console.WriteLine("Lucro..........:{0,15:p}", lucro);//{:p= formatação percentual %}
    //        Console.WriteLine("ValVenda.......:{0,15:c}", valorVenda);
    //    }

    //}
    //===============================================================================
    //using System;
    //class Aula07
    //{
    //    static void Main()
    //    {
    //        const string canal = "CFB Cursos";
    //        const double pi = 3.1415;

    //        Console.WriteLine("Canal: {0}\nPi: {1}", canal, pi);
    //    }
    //}
    //===============================================================================
    //Aula08-C#
    //using System;
    //class Aula08
    //{
    //    static void Main()
    //    {
    //        int v1, v2, soma;
    //        string nome;

    //        Console.Write("Digite seu nome: ");
    //        nome = Console.ReadLine();
    //        Console.WriteLine("Nome digitado: {0}", nome);
    //    }
    //}
    //===============================================================================
    //Aula08b-C#
    //using System;
    //class Aula08b
    //{
    //    static void Main()
    //    {
    //        int v1, v2, soma;
    //        string nome;

    //        Console.Write("Digite o primeiro valor: ");
    //        v1 = int.Parse(Console.ReadLine());
    //        Console.Write("Digite o segundo valor: ");
    //        v2 = int.Parse(Console.ReadLine());
    //        soma = v1 + v2;
    //        Console.WriteLine("A soma de {0} + {1} é = {2}", v1, v2, soma);
    //    }
    //}
    //====================================================
    //			Bitwise
    //====================================================
    //using System;
    //class Aula09
    //{
    //    static void Main()
    //    {
    //        int num = 20;
    //        num = num << 2;
    //        Console.WriteLine(num);
    //    }
    //}
    //====================================================
    //			Enumeradores
    //====================================================
    //using System;
    //class Aula10
    //{

    //    enum DiasSemana { Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado };

    //    static void Main (){
    //        DiasSemana ds = (DiasSemana)3;

    //        Console.WriteLine(ds);
    //    }
    //}
    //====================================================
    //			Typecast
    //====================================================
    //using System;
    //class Aula11
    //{

    //    static void Main()
    //    {
    //        float n1 = 10.5f;
    //        int n2 = (int)n1; //typecast

    //        Console.WriteLine(n2);
    //    }
    //}
    //====================================================
    //using System;
    //class Aula11b
    //{

    //    static void Main()
    //    {
    //        int vInt=10;
    //        short vShort = (short)vInt; //typecast

    //        Console.WriteLine(vShort);
    //    }
    //}
    //====================================================
    //			IF
    //====================================================
    //using System;
    //class Aula12
    //{

    //    static void Main()
    //    {
    //        int n1, n2, n3, n4, res; 
    //        string resultado = "Reprovado";

    //        Console.WriteLine("Digite sua 1ª Nota: ");
    //        n1 = int.Parse(Console.ReadLine());

    //        Console.WriteLine("Digite sua 2ª Nota: ");
    //        n2 = int.Parse(Console.ReadLine());

    //        Console.WriteLine("Digite sua 3ª Nota: ");
    //        n3 = int.Parse(Console.ReadLine());

    //        Console.WriteLine("Digite sua 4ª Nota: ");
    //        n4 = int.Parse(Console.ReadLine());

    //        res = (n1 + n2 + n3 + n4) / 4;

    //        if (res >= 60)
    //        {
    //            Console.WriteLine("Parabéns! sua nota é {0}, você está Aprovado!", res);
    //        }else{
    //            Console.WriteLine("Resultado {0}, você está {1} ",res, resultado);
    //        };
    //    }
    //}
    //====================================================
    //			If Else
    //====================================================
    //using System;
    // class Aula13
    // {

    //     static void Main()
    //     {
    //         int n1, n2, n3, n4, res;
    //         string resultado = "Reprovado";

    //         Console.WriteLine("Digite sua 1ª Nota: ");
    //         n1 = int.Parse(Console.ReadLine());

    //         Console.WriteLine("Digite sua 2ª Nota: ");
    //         n2 = int.Parse(Console.ReadLine());

    //         Console.WriteLine("Digite sua 3ª Nota: ");
    //         n3 = int.Parse(Console.ReadLine());

    //         Console.WriteLine("Digite sua 4ª Nota: ");
    //         n4 = int.Parse(Console.ReadLine());

    //         res = (n1 + n2 + n3 + n4) / 4;

    //         if (res >= 60)
    //         {
    //             Console.WriteLine("Parabéns! Sua nota é {0}, você está Aprovado!", res);
    //         }else if (res >= 40)
    //         {
    //             Console.WriteLine("Sua nota é {0}, você está de Recuperação!", res);

    //         }
    //         else
    //         {
    //             Console.WriteLine("Sua Nota é {0}, você está {1} ", res, resultado);
    //         };
    //     }
    // }
    //====================================================
    //			Switch Case
    //====================================================
    //using System;
    // class Aula15
    // {
    //     static void Main()
    //     {
    //         int tempo = 0;
    //         char escolha;

    //         Console.WriteLine("Belo Horizonte/MG a Votória/ES");
    //         Console.WriteLine("Escolha o transporte: [a]Avião | [c]Carro | [o]Ônibus ");
    //         escolha = char.Parse(Console.ReadLine());

    //         switch(escolha){
    //             case 'a': tempo = 50 ; break;
    //             case 'A': tempo = 50 ; break;
    //             case 'c': tempo = 480; break;
    //             case 'C': tempo = 480; break;
    //             case 'o': tempo = 660; break;
    //             case 'O': tempo = 660; break;
    //             default:  tempo = -1; break;
    //         }
    //         if(tempo < 0)
    //         {
    //             Console.WriteLine("Transporte indísponivel");
    //         }
    //         else
    //         {
    //             Console.WriteLine("Para o transporte escolhido o tempo é: {0} minutos", tempo);
    //         }
    //     }
    // }
    //====================================================
    //			GoTo
    //====================================================
    //using System;
    // class Aula16
    // {
    //     static void Main()
    //     {
    //         int tempo = 0;
    //         char escolha;

    //     inicio:

    //         Console.Clear();

    //         Console.WriteLine("Belo Horizonte/MG a Votória/ES");
    //         Console.WriteLine("Escolha o transporte: [a]Avião | [c]Carro | [o]Ônibus ");
    //         escolha = char.Parse(Console.ReadLine());

    //         switch (escolha)
    //         {
    //             case 'a': tempo = 50; break;
    //             case 'A': tempo = 50; break;
    //             case 'c': tempo = 480; break;
    //             case 'C': tempo = 480; break;
    //             case 'o': tempo = 660; break;
    //             case 'O': tempo = 660; break;
    //             default: tempo = -1; break;
    //         }
    //         if (tempo < 0)
    //         {
    //             Console.WriteLine("Transporte indísponivel");
    //         }
    //         else
    //         {
    //             Console.WriteLine("Para o transporte escolhido o tempo é: {0} minutos", tempo);
    //         }
    //         Console.WriteLine("\nCalcular outro transporte? [s/n]: ");
    //         escolha = char.Parse(Console.ReadLine());
    //         if (escolha == 's' || escolha == 'S')
    //         {
    //             goto inicio;
    //         }
    //         else
    //         {
    //             Console.Clear();
    //             Console.WriteLine("Fim do Programa");
    //         }
    //     }
    // }
    //====================================================
    //			Array / Vetor - Unidimensionais
    //=====================================================
    //using System;
    // class Aula17
    // {
    //     static void Main()
    //     {
    //         //int n1, n2, n3, n4, n5; = ao de baixo
    //         int [] n = new int [5]; // 0, 1 , 2 , 3 , 4 

    //         n[0] = 11;
    //         n[1] = 22;
    //         n[2] = 33;
    //         n[3] = 44;
    //         n[4] = 55;

    //         Console.WriteLine(n[0]);
    //     }
    // }
    //=====================================================
    //using System;
    //class Aula17b
    //{
    //    static void Main()
    //    {
    //        //int n1, n2, n3, n4, n5; = ao de baixo
    //        int[] n = new int[5]; // 0, 1 , 2 , 3 , 4 
    //        int[] num = new int[3] {55, 77, 99};//com valores já declarados
    //        int[] num2 = {55, 77, 99};//com valores já declarados diretamente na cadeia de valores
    //        string[] veiculos = new string[3];

    //        veiculos[0] = "Ferrari";
    //        veiculos[1] = "Lamborguini";
    //        veiculos[2] = "Mercedez";
    //        n[0] = 11;
    //        n[1] = 22;
    //        n[2] = 33;
    //        n[3] = 44;
    //        n[4] = 55;

    //        Console.WriteLine(veiculos[0]);
    //    }
    //}
    //====================================================
    //			Array / Vetor Bi-Dimensionais
    //=====================================================
    //using System;
    // class Aula18
    //{
    //    static void Main()
    //    {
    //        //int n1, n2, n3, n4, n5; = ao de baixo
    //        int[,] n = new int[3, 5]; // 3 = linhas, 5 = colunas
    //        //int[,] num = new int [2,2]{{10,20},{30,40}}; com valores já declarados

    //            //10,20,30,40,50
    //            //60,70,80,90,15
    //            //25,35,45,55,65

    //        n[0,0] = 10;
    //        n[0,1] = 20;
    //        n[0,2] = 30;
    //        n[0,3] = 40;
    //        n[0,4 ]= 50;

    //        n[1, 0] = 60;
    //        n[1, 1] = 70;
    //        n[1, 2] = 80;
    //        n[1, 3] = 90;
    //        n[1, 4] = 15;

    //        n[2, 0] = 25;
    //        n[2, 1] = 35;
    //        n[2, 2] = 45;
    //        n[2, 3] = 55;
    //        n[2, 4] = 65;


    //        Console.WriteLine(n[1,3]);
    //    }
    //}
    //====================================================
    //			Loop For
    //=====================================================
    //using System;
    // class Aula19
    //{
    //    static void Main()
    //    {
    //        int num;
    // //(Com quanto começa ; Até onde vai ; Incremento/decremento )
    //        for (num = 8; num < 10; num ++)
    //        {
    //            Console.WriteLine(num);
    //        }
    //    }
    //}
    ////================LOOP FOR COM ARRAY=====================
    //using System;
    // class Aula19b
    //{
    //    static void Main()
    //    {
    //        int[] num = new int[10];

    //        //(Com quanto começa ; Até onde vai ; Incremento/decremento )
    //        for (int i = 0; i < num.Length; i++)
    //        {
    //            num[i] = i;
    //        }
    //        for(int i = 0; i < num.Length; i++)
    //        Console.WriteLine("Valor de NUM na posição{0}: {1}", i, num[i]);
    //    }
    //}
    //====================================================
    //			Loop While
    //=====================================================
    //using System;
    //class Aula20
    //{
    //    static void Main()
    //    {
    //        int[] num = new int[10];

    //        int i = 0;
    //        while (i < 10)
    //        {
    //            Console.WriteLine("Tiago Mota");
    //            i++;
    //        }
    //        Console.WriteLine("Fim do Loop While");
    //    }
    //}
    //====================================================
    //			Loop DoWhile
    //=====================================================
    //using System;
    //class Aula20
    //{
    //    static void Main()
    //    {
    //        int num = 8;
    //        do
    //        {
    //            Console.WriteLine("Tiago Mota");
    //            num++;
    //        }
    //        while (num < 10);
    //    }
    //}
    //=================Loop DoWhile=========================
    //using System;
    //class Aula20b
    //{
    //    static void Main()
    //    {
    //        string senha = "123";
    //        string senhauser;
    //        int tentativas = 0;
    //        do
    //        {
    //            Console.Clear();
    //            Console.WriteLine("Digite a senha: ");
    //            senhauser = Console.ReadLine();
    //            tentativas++;
    //        }
    //        while (senha != senhauser);
    //        Console.Clear();
    //        Console.WriteLine("Senha Correta, Tentativas: {0}", tentativas);
    //    }
    //}
    //====================================================
    //			Loop Foreach
    //=====================================================
    //using System;
    //class Aula22
    //{
    //    static void Main()
    //    {
    //        int[] num = new int[5] {11,22,33,44,55};

    //        //for (int i = 0; i < num.Length; i++)
    //        //{
    //        //    Console.WriteLine(num[i]);
    //        //} OU 

    //        foreach(int n in num)
    //        {
    //            Console.WriteLine(n);
    //        }
    //    }
    //}
    //====================================================
    //			Métodos
    //=====================================================
    //using System;
    //class Aula24
    //{
    //    static void Main()//Void = não retorna nada
    //    {
    //        Tiago();// chamada do metodo
    //    }
    //    static void Tiago()// metodo
    //    {
    //        Console.WriteLine("Tiago Mota");
    //        Console.WriteLine("Curso de C#");
    //        Console.WriteLine("36 anos");
    //    }
    //}
    //===================Métodos=============================
    //using System;
    //class Aula24
    //{
    //    static void Main()//Void = não retorna nada
    //    {
    //        soma(10,5);// chamada do metodo
    //    }
    //    static void soma(int n1, int n2)// metodo
    //    {
    //        int res = n1 + n2;
    //        Console.WriteLine("A Soma de {0} e {1} é: {2}", n1, n2, res);
    //    }
    //}
    //===========Métodos recebendo parâmetro do teclado=======================
    //using System;
    //class Aula24
    //{
    //    static void Main()//Void = não retorna nada
    //    {
    //        int v1 , v2;
    //        v1 = Convert.ToInt32(Console.ReadLine());
    //        v2 = Convert.ToInt32(Console.ReadLine());
    //        soma(v1, v2);// chamada do metodo
    //    }
    //    static void soma(int n1, int n2)// metodo
    //    {
    //        int res = n1 + n2;
    //        Console.WriteLine("A Soma de {0} e {1} é: {2}", n1, n2, res);
    //    }
    //}
    //===========Métodos recebendo parâmetro do teclado Com retorno==================
    //using System;
    //class Aula25
    //{
    //    static void Main()//Void = não retorna nada
    //    {
    //        int v1, v2,recebe;
    //        v1 = Convert.ToInt32(Console.ReadLine());
    //        v2 = Convert.ToInt32(Console.ReadLine());
    //        recebe = soma(v1, v2);// chamada do metodo
    //        Console.WriteLine("A Soma de {0} e {1} é: {2}", v1, v2, recebe);

    //    }
    //    static int soma(int n1, int n2)// metodo
    //    {
    //        int res = n1 + n2;
    //        return res;
    //    }
    //}
    //====================================================
    //  Métodos - passagem por valor
    //=====================================================
    //using System;
    //class Aula25b
    //{
    //    static void Main()//Void = não retorna nada
    //    {
    //        int num = 10;
    //        dobrar(num);
    //        Console.WriteLine(num);// chamada do metodo
    //    }
    //    static void dobrar(int valor)// metodo
    //    {
    //        valor *= 2; // retornaria 10, pois Dobrar não afeta a variável NUM
    //    }
    //}
    //====================================================
    //  Métodos - passagem por referência
    //=====================================================
    //using System;
    //class Aula25
    //{
    //    static void Main()//Void = não retorna nada
    //    {
    //        int num = 10;
    //        dobrar(ref num);
    //        Console.WriteLine(num);// chamada do metodo
    //    }
    //    static void dobrar(ref int valor)// metodo
    //    {
    //        valor *= 2; // retornaria 20, pois está usando a mesma referencia endereço de NUM
    //    }
    //}
    //====================================================
    //  Métodos - params
    //=====================================================
    //using System;
    //class Aula27
    //{
    //    static void Main()//Void = não retorna nada
    //    {
    //        soma(9, 5, 4, 6);// valores passados aqui, mas sem tipagem
    //    }
    //    //static void soma(int n1, int n2)// metodo
    //    static void soma(params int[]n)// metodo params não precisa colocar todos os N's valores aqui, apenas a quantia de valores
    //    {
    //        int res = 0;
    //        if(n.Length < 1) // se minha matriz for menor que 1
    //        {
    //            Console.WriteLine("Não existem valores a serem somados");
    //        }else if(n.Length < 2)
    //        {
    //            Console.WriteLine("Valores insufucuentes para soma: {0}", n[0]);
    //        }
    //        else
    //        {
    //            for (int i = 0;  i < n.Length; i++)
    //            {
    //                res+=n[i];
    //            }
    //            Console.WriteLine("A soma dos valores é: {0}", res);
    //        }
    //    }
    //}
    //====================================================
    //     ***** CLASSE E OBJETOS *****MODELO
    //=====================================================
    //  [ModificadorClasse] class Nome_Da_Classe{
    //          Variáveis = propriedades
    //          [EspecificadorAcesso] tipo Nome_Propriedade;

    //      Métodos
    //      [EspecificadorAcesso] retorno Nome_método([arg1,...]){
    //          Corpo do Método
    //      }
    //  }

    //  ModificadorClasse: Define a cvisibilidade da classe
    //          puplic: Pública sem restrições de visualização
    //          abstratic:Classe-Base para outras classes, não podem ser instanciados objeots desta classe
    //          sealed: Classe não pode ser herdada
    //          static: Claasse não permite a instanciaçãode objetos

    //  EspecificadorAcesso: Onde um membro da classe pode ser acessado
    //          public: Sem restrição de acesso
    //          private: Só podem ser acessados pela própria classe
    //          protected: Podem ser acessados na própria classe e nas classes derivadas
    //          abstract: Os métodos não tem implementação somente os cabeçalhos
    //          sealed: O método não pode ser redefinido
    //          virtual: Ométodo pode sser redefinido
    //          static: O método pode ser chamado sem a instnaciação de um objeto
    //====================================================
    //     ***** CLASSE E OBJETOS *****EXEMPLOS
    //=====================================================
    //using System;
    //public class Jogador // se não usar nenhum Modificador, automaticamente é pública
    //{
    //    public int energia = 100; // se não usar nenhum Modificador, automaticamente é pública
    //    public string estado = "Morreu";
    //    public bool vivo = true; // se não usar nenhum Modificador, automaticamente é pública
    //}
    //class Aula28
    //{
    //    static void Main()
    //    {
    //        Jogador j1 = new Jogador();// instanciei novo objeto da classe Jogador com o nome j1 / NEW = reserva memória para j1
    //        Jogador j2 = new Jogador();// instanciei novo objeto da classe Jogador com o nome j2 / NEW = reserva memória para j2
    //        Jogador j3 = new Jogador();// instanciei novo objeto da classe Jogador com o nome j3 / NEW = reserva memória para j3
    //        Jogador j4 = new Jogador();

    //        j1.energia = 50;
    //        j2.energia = 90;
    //        j3.energia = 0;

    //        Console.WriteLine("Energia do jogagor 1: {0}%", j1.energia);
    //        Console.WriteLine("Energia do jogagor 2: {0}%", j2.energia);
    //        Console.WriteLine("Energia do jogagor 3: {0}% {1}", j3.energia, j3.estado);
    //        Console.WriteLine("Energia do jogagor 3: {0}%", j4.energia);
    //    }
    //}
    //=================================================================
    //     *** CLASSE E OBJETOS *** Métodos Construtores e Destrutores
    //=================================================================
    //Aula29

    //using System;
    //public class Desenvolvedor // se não usar nenhum Modificador, automaticamente é pública
    //{
    //    public int energia = 100; // se não usar nenhum Modificador, automaticamente é pública
    //    public string estado = "Morreu";
    //    public string nome;
    //    public bool vivo = true; // se não usar nenhum Modificador, automaticamente é pública

    //    public Desenvolvedor()
    //    {
    //    }

    //    public Desenvolvedor(int energia, string estado, bool vivo, string nome)
    //    {
    //        this.energia = energia;
    //        this.estado = estado;
    //        this.vivo = vivo;
    //        this.nome = nome;
    //    }
    //}
    //class Aula29
    //{
    //    static void Main()
    //    {
    //        Desenvolvedor dev1 = new Desenvolvedor();// instanciei novo objeto da classe Jogador com o nome j1 / NEW = reserva memória para j1
    //        Desenvolvedor dev2 = new Desenvolvedor();// instanciei novo objeto da classe Jogador com o nome j2 / NEW = reserva memória para j2
    //        Desenvolvedor dev3 = new Desenvolvedor();// instanciei novo objeto da classe Jogador com o nome j3 / NEW = reserva memória para j3
    //        Desenvolvedor dev4 = new Desenvolvedor();

    //        dev1.energia = 80;
    //        dev1.nome = "Matheus";
    //        dev2.energia = 75;
    //        dev2.nome = "Diego";
    //        dev3.energia = 0;
    //        dev3.nome = "Tiago";
    //        dev4.nome = "Napoleão";

    //        Console.WriteLine("Energia do Desenvolvedor 1: \n\tNome: {0}, energia: {1}%\n", dev1.nome, dev1.energia, dev1.estado);
    //        Console.WriteLine("Energia do Desenvolvedor 2: \n\tNome: {0}, energia: {1}%\n", dev2.nome, dev2.energia, dev2.estado);
    //        Console.WriteLine("Energia do Desenvolvedor 3: \n\tNome: {0}, energia: {1}%, {2}\n", dev3.nome, dev3.energia, dev3.estado);
    //        Console.WriteLine("Energia do Desenvolvedor 4: \n\tNome: {0}, energia: {1}%\n", dev4.nome, dev4.energia, dev4.estado);
    //    }
    //}
    //=================================================================
    //     *** CLASSE E OBJETOS *** Classe static
    //=================================================================
    //Aula31
    //Class Static não permite o uso de construtores, poi usa uma posição fixa na memória, então
    // não daria pra usar o NEW pra alocar outro espaço na memória
    //=================================================================
    //     *** CLASSE E OBJETOS *** This
    //=================================================================
    //Aula32
    //using System;
    //public class Calculos // se não usar nenhum Modificador, automaticamente é pública
    //{
    //    public int v1;
    //    public int v2;

    //    public Calculos(int v1, int v2)//Construtor
    //    {
    //        this.v1 = v1;//O This especifíca que esse V1 faz referencia a classe pai Calculos a cima 
    //        this.v2 = v2;
    //    }

    //    public int Somar()
    //    {
    //        return v1 + v2;
    //    }
    //}
    //class Aula32
    //{
    //    static void Main()
    //    {
    //        Calculos c = new Calculos(10, 2);

    //        Console.WriteLine(c.Somar());
    //    }
    //}
    //=================================================================
    //     *** CLASSE E OBJETOS *** HERANÇA
    //=================================================================
    //Aula33
    //using System;
    //class Veiculo // Classe BASE
    //{
    //    public int rodas;
    //    public int velMax;
    //    public bool ligado;

    //    public void ligar()
    //    {
    //        ligado = true;
    //    }
    //    public void desligar()
    //    {
    //        ligado = false;
    //    }
    //    public string getLigado()
    //    {
    //        if (ligado)
    //        {
    //            return "sim";
    //        }
    //        else
    //        {
    //            return "não";
    //        }
    //    }
    //}
    //class Carro : Veiculo // Classe Derivada
    //{
    //    public string nome;
    //    public string cor;
    //    public Carro(string nome, string cor)
    //    {
    //        desligar();
    //        rodas = 4;
    //        velMax = 120;
    //        this.nome = nome;
    //        this.cor = cor;
    //    }
    //}
    //class Aula34
    //{
    //    static void Main()
    //    {
    //        Carro c1 = new Carro("Rapidão", "Vermelho");

    //        Console.WriteLine("Cor..........: {0}", c1.cor);
    //        Console.WriteLine("Nome.........: {0}", c1.nome);
    //        Console.WriteLine("Rodas........: {0}", c1.rodas);
    //        Console.WriteLine("Vel.Máxima...: {0} Km/h", c1.velMax);
    //        Console.WriteLine("Ligado.......: {0} Km/h", c1.getLigado());
    //    }
    //}
    //=======================================================================
    //*** CLASSE E OBJETOS *** CADEIA DE HERANÇA E CONSTRUTOR DA CLASSE BASE e private????
    //=======================================================================
    //Aula35
    //using System;
    //class Veiculo // Classe BASE
    //{
    //    private int rodas;
    //    public int velMax;
    //    public bool ligado;

    //    public Veiculo(int rodas)
    //    {
    //        this.rodas = rodas;
    //    }
    //    public void ligar()
    //    {
    //        ligado = true;
    //    }
    //    public void desligar()
    //    {
    //        ligado = false;
    //    }
    //    public string getLigado()
    //    {
    //        return (ligado ? "Sim" : "Não");
    //    }
    //    public int getRodas()
    //    {
    //        return rodas;
    //    }
    //    public void setRodas(int rodas)
    //    {
    //        if(rodas < 0)
    //        {
    //            this.rodas = 0;
    //        }
    //        if (rodas > 40)
    //        {
    //            this.rodas = 40;
    //        }
    //        else
    //        {
    //            this.rodas = rodas;
    //        }
    //    }
    //}
    //class Carro : Veiculo // Classe Derivada
    //{
    //    public string nome;
    //    public string cor;

    //    public Carro(string nome, string cor): base(4)
    //    {
    //        desligar();
    //        velMax = 120;
    //        this.nome = nome;
    //        this.cor = cor;
    //    }
    //}
    //class CarroCombate : Carro
    //{
    //    public int municao;
    //    public CarroCombate():base("Carro de Combate", "Verde")
    //    {
    //        municao = 100;
    //        setRodas(6);
    //    }
    //}
    //class Aula35
    //{
    //    static void Main()
    //    {
    //        Carro c1 = new Carro("Rapidão", "Vermelho");
    //        CarroCombate cc1 = new CarroCombate();

    //        c1.ligar();

    //        Console.WriteLine("Cor..........: {0}", c1.cor);
    //        Console.WriteLine("Nome.........: {0}", c1.nome);
    //        Console.WriteLine("Rodas........: {0}", c1.getRodas());
    //        Console.WriteLine("Vel.Máxima...: {0} Km/h", c1.velMax);
    //        Console.WriteLine("Ligado.......: {0}", c1.getLigado());

    //        Console.WriteLine("-----------------------------------------");

    //        Console.WriteLine("Cor..........: {0}", cc1.cor);
    //        Console.WriteLine("Nome.........: {0}", cc1.nome);
    //        Console.WriteLine("Rodas........: {0}", cc1.getRodas());
    //        Console.WriteLine("Vel.Máxima...: {0} Km/h", cc1.velMax);
    //        Console.WriteLine("Ligado.......: {0}", cc1.getLigado());
    //        Console.WriteLine("Munição......: {0}", cc1.municao);
    //    }
    //}
    //=======================================================================
    //*** CLASSE E OBJETOS *** CADEIA DE HERANÇA E CONSTRUTOR DA CLASSE BASE e private????
    //=======================================================================
    //Aula36
    //using System;
    //class Veiculo // Classe BASE
    //{
    //    public int velAtual;
    //    private int velMax;
    //    protected bool ligado;
    //    public Veiculo(int velMax)
    //    {
    //        velAtual = 0;
    //        this.velMax = velMax;
    //        ligado = false;
    //    }
    //    public bool getLigado()
    //    {
    //        return ligado;
    //    }
    //    public int getVelmax()
    //    {
    //        return velMax;
    //    }
    //}
    //class Carro:Veiculo // Classe Derivada
    //{
    //    public string nome;
    //    public Carro(string nome, int vm): base(vm)
    //    {
    //        this.nome = nome;
    //        ligado = true;
    //    }
    //}
    //class Aula36
    //{
    //    static void Main()
    //    {
    //        Carro carro = new Carro("Bonitão", 120);
    //        Console.WriteLine("Nome do carro...: {0}", carro.nome);
    //        Console.WriteLine("Vel.Máxima......: {0}", carro.getVelmax());
    //        Console.WriteLine("Ligado..........: {0}", carro.getLigado());
    //    }
    //}
    //=======================================================================
    //*** CLASSE E OBJETOS *** HERANÇA - Ordem de execução dos Construtores
    //=======================================================================
    //Aula37
    //using System;
    //class Base // Classe BASE
    //{
    //    public int velAtual;

    //    public Base()
    //    {
    //        Console.WriteLine("Construtor da classe base");
    //    }
    //    class Derivada1:Base
    //    {
    //        public Derivada1()
    //        {
    //            Console.WriteLine("Construtor da classe base Derivada 1");
    //        }
    //    }
    //    class Derivada2 : Derivada1
    //    {
    //        public Derivada2()
    //        {
    //            Console.WriteLine("Construtor da classe base Derivada 2");
    //        }
    //    }
    //    class Aula37
    //    {
    //        static void Main()
    //        {
    //            Derivada2 derivada2 = new Derivada2();
    //        }
    //    }
    //}
    //=======================================================================
    //*** CLASSE E OBJETOS *** HERANÇA - Métodos Virtuais
    //=======================================================================
    //Aula38
    //using System;
    //class Base // Classe BASE
    //{
    //    public int velAtual;

    //    public Base()
    //    {
    //        Console.WriteLine("Construtor da classe base");
    //    }
    //    virtual public void info()
    //    {
    //        Console.WriteLine("Base");
    //    }
    //    class Derivada1 : Base
    //    {
    //        public Derivada1()
    //        {
    //            Console.WriteLine("Construtor da classe base Derivada 1");
    //        }
    //        override public void info()// Override, pois o método já esxiste na clase base e está sendo sobrescrito aqui
    //        {
    //            Console.WriteLine("Derivada 1");
    //        }
    //    }
    //    class Derivada2 : Derivada1
    //    {
    //        public Derivada2()
    //        {
    //            Console.WriteLine("Construtor da classe base Derivada 2");
    //        }
    //        override public void info()// Override, pois o método já esxiste na clase base e está sendo sobrescrito aqui
    //        {
    //            Console.WriteLine("Derivada 2");
    //        }
    //    }
    //    class Aula38
    //    {
    //        static void Main()
    //        {
    //            Base Ref;
    //            Derivada1 derivada1 = new Derivada1();
    //            Derivada2 derivada2 = new Derivada2();
    //            Ref = derivada2;
    //            Ref.info();
    //        }
    //    }
    //}
    //=======================================================================
    //*** CLASSE E OBJETOS *** HERANÇA - Classes e Métodos Abstratos
    //=======================================================================
    //Aula39
    //using System;
    //abstract class Veiculo // Classe Abstrata só se usa em herança
    //{
    //    protected int velMaxima;
    //    protected int velAtual;
    //    protected bool ligado;

    //    protected Veiculo()
    //    {
    //        velAtual = 0;
    //        ligado = false;
    //    }
    //    public void setligado(bool ligado)//por naão ser abstrato é obrigado informa a funcionalidade
    //    {
    //        this.ligado = ligado;
    //    }
    //    public int getVelAtual()//por naão ser abstrato é obrigado informa a funcionalidade
    //    {
    //        return velAtual;
    //    }
    //    abstract public void aceleracao(int mult);

    //}
    //class Carro : Veiculo  {
    //    public Carro()
    //    {
    //        velMaxima = 120;
    //    }
    //    override public void aceleracao(int mult)
    //    {
    //        velAtual += 10 * mult;
    //    }
    //}
    //class Aula39
    //{
    //    static void Main()
    //    {
    //        Carro carro1 = new Carro();
    //        carro1.aceleracao(1);
    //        carro1.aceleracao(-1);
    //        Console.WriteLine(carro1.getVelAtual());
    //    }
    //}
    //=======================================================================
    //*** CLASSE E OBJETOS *** HERANÇA - Classe Sealed
    //=======================================================================
    //Aula40
    //using System;

    //sealed class Veiculo // Classe selada não pode ser herdada
    //{

    //}
    //class Carro
    //{
    //    public Carro()
    //    {

    //    }
    //}
    //class Aula40
    //{
    //    static void Main()
    //    {
    //        Carro c1 = new Carro();
    //    }
    //}
    //=======================================================================
    //*** CLASSE E OBJETOS *** Acessors GET e SET
    //=======================================================================
    //Aula41
    //using System;

    //class Carro // Classe Base
    //{
    //    private int velMax;

    //    public int vm
    //    {
    //        get
    //        {
    //            return velMax;
    //        }
    //        set
    //        {
    //            if(value < 0)
    //            {
    //                velMax = 0;
    //            }else if(value > 300)
    //            {
    //                velMax = 300;
    //            }
    //            else
    //            {
    //                velMax = value;
    //            }
    //        }
    //    }
    //    public Carro()
    //    {
    //        vm = 120;
    //    }
    //}
    //class Aula41
    //{
    //    static void Main()
    //    {
    //        Carro c1 = new Carro();
    //        c1.vm = 200;
    //        Console.WriteLine("Velocidade: {0}", c1.vm);
    //    }
    //}
    //=======================================================================
    //*** CLASSE E OBJETOS *** Indexadores de Classes
    //=======================================================================
    //Aula42
    //using System;

    //class Carro // Classe Base
    //{
    //    private int[] velMax = new int[5] { 80, 120, 160, 240, 300 };

    //    public int this[int i]
    //    {
    //        get
    //        {
    //            return velMax[i];
    //        }
    //        set
    //        {
    //            if (value < 0)
    //            {
    //                velMax[i] = 0;
    //            }
    //            else if (value > 300)
    //            {
    //                velMax[i] = 300;
    //            }
    //            else
    //            {
    //                velMax[i] = value;
    //            }
    //        }
    //    }
    //    public Carro()
    //    {
    //    }
    //}
    //class Aula42
    //{
    //    static void Main()
    //    {
    //        Carro c1 = new Carro();
    //        //c1[4] = 200;
    //        Console.WriteLine("Velocidade: {0}", c1[4]);
    //    }
    //}
    ////=======================================================================
    ////*** CLASSE E OBJETOS *** Interfaces
    ////=======================================================================
    ////Aula43
    //using System;

    //public interface Veiculo // interface
    //{
    //    void ligar();
    //    void desligar();
    //    void info();
    //}
    //public interface Combate
    //{
    //    void disparar();
    //}
    //class Carro : Veiculo, Combate // usando duas intfaces
    //{
    //    public bool ligado;
    //    private int municao;
    //    public Carro()
    //    {
    //        setMunicao(100);
    //    }
    //    public void setMunicao(int qtde)
    //    {
    //        this.municao = qtde;
    //    }

    //    public void ligar()
    //    {
    //        this.ligado = true;
    //    }
    //    public void desligar()
    //    {
    //        this.ligado = false;
    //    }
    //    public void disparar()
    //    {

    //    }
    //    public void info()
    //    {

    //    }
    //}
    //class Aula43
    //{
    //    static void Main()
    //    {
    //        Carro c1 = new Carro();
    //    }
    //}
    ////=======================================================================
    ////*** CLASSE E OBJETOS *** Struct
    ////=======================================================================
    ////Aula44
    //using System;

    //struct Carro
    //{
    //    public string marca;
    //    public string modelo;
    //    public string cor;

    //    public Carro(string marca, string modelo, string cor)
    //    {
    //        this.marca = marca;
    //        this.modelo = modelo;
    //        this.cor = cor;
    //    }
    //    public void info()
    //    {
    //        Console.WriteLine("Marca.....: {0}", this.marca);
    //        Console.WriteLine("Modelo....: {0}", this.modelo);
    //        Console.WriteLine("Cor.......: {0}", this.cor);
    //        Console.WriteLine("============================");
    //    }
    //}
    //class Aula44
    //{
    //    static void Main()
    //    {
    //        Carro c1 = new Carro("Hyundai", "HB20", "Vermelho");
    //        Carro c2 = new Carro("Volkswagen", "Gol", "Azul");

    //        //c1.marca = "Volkswagen";
    //        //c1.modelo = "Golf";
    //        //c1.cor = "Azul";

    //        //Carro c2;
    //        //c2.marca = "Hyundai";
    //        //c2.modelo = "HB20";
    //        //c2.cor = "Vermelho";

    //        c1.info();
    //        c2.info();
    //        //Console.WriteLine("Marca.....: {0}", c2.marca);
    //        //Console.WriteLine("Modelo....: {0}", c2.modelo);
    //        //Console.WriteLine("Cor.......: {0}", c2.cor);
    //    }
    //}
    ////=======================================================================
    ////*** CLASSE E OBJETOS ***  Array de Estruturas
    ////=======================================================================
    ////Aula45
    //using System;

    //struct Carro
    //{
    //    public string marca;
    //    public string modelo;
    //    public string cor;

    //    public void info()
    //    {
    //        Console.WriteLine("==============================");
    //        Console.WriteLine("Marca.....: {0}", this.marca);
    //        Console.WriteLine("Modelo....: {0}", this.modelo);
    //        Console.WriteLine("Cor.......: {0}", this.cor);
    //        Console.WriteLine("==============================");
    //    }
    //}
    //class Aula45
    //{
    //    static void Main()
    //    {
    //        int[] numeros = new int[10];

    //        Carro[] carros = new Carro[3];

    //        carros[0].marca="Hyundai";       
    //        carros[0].modelo="HB20";
    //        carros[0].cor="Vermelho";

    //        carros[1].marca="Volkswagen";
    //        carros[1].modelo = "HB20";
    //        carros[1].cor = "Azul";

    //        carros[2].marca = "Ford";
    //        carros[2].modelo = "Scort";
    //        carros[2].cor = "Preto";

    //        for(int i = 0; i < carros.Length; i++)
    //        carros[i].info();
    //    }
    //}
    ////=======================================================================
    ////*** CLASSE E OBJETOS ***  Métodos que retornam objetos
    ////=======================================================================
    ////Aula46
    //using System;

    //class Galinha
    //{
    //    private string nomeGalinha;
    //    private int numOvo;

    //    public Galinha(string nomeGalinha)
    //    {
    //        this.nomeGalinha = nomeGalinha;
    //        this.numOvo = 0;
    //    }
    //    public Ovo botar()
    //    {
    //        numOvo++;
    //        return new Ovo(numOvo, nomeGalinha);
    //    }
    //}
    //class Ovo
    //{
    //    private int numOvo;
    //    private string minhaGalinha;

    //    public Ovo(int numOvo, string minhaGalinha)
    //    {
    //        this.numOvo = numOvo;
    //        this.minhaGalinha = minhaGalinha;
    //        Console.WriteLine("Ovo criado: {0} - por: {1}", this.numOvo, this.minhaGalinha);
    //        Console.WriteLine("_______________________________________");
    //    }
    //    class Aula46
    //    {
    //        static void Main()
    //        {
    //            Galinha g1 = new Galinha("Beneditasgildimar");
    //            Galinha g2 = new Galinha("Felizbertaniazilda");
    //            Galinha g3 = new Galinha("Marisgertrudeszela");

    //            g1.botar();
    //            g1.botar();
    //            g1.botar();

    //            g2.botar();

    //            g3.botar();
    //            g3.botar();

    //        }
    //    }
    //}
    ////=======================================================================
    ////*** CLASSE E OBJETOS ***  Sobrecarga de Métodos
    ////=======================================================================
    ////Aula47
    //using System;

    //class Calc
    //{
    //    public double soma(params int[]n)
    //    {
    //        int s = 0;
    //        for(int i = 0; i < n.Length; i++)
    //        {
    //            s += n[i];
    //        }
    //        return s;
    //    }
    //    public double soma(params double[]n)
    //    {
    //        double s = 0;
    //        for (int i = 0; i < n.Length; i++)
    //        {
    //            s += n[i];
    //        }
    //        return s;
    //    }
    //}

    //    class Aula47
    //    {
    //        static void Main()
    //        {

    //        Calc calc = new Calc();
    //            {
    //         var res = calc.soma(10.9, 5.1, 3, 4, 9.9, 2.7);

    //            Console.WriteLine(res);
    //            }

    //        }
    //    }
    ////=======================================================================
    ////*** CLASSE E OBJETOS ***  Recursividade
    ////=======================================================================
    ////Aula48
    ////Classe que chama ela mesma até que pessamos para parar(Ideal para fatorial)
    //using System;

    //class Calc
    //{
    //    public double soma(params int[] n)
    //    {
    //        int s = 0;
    //        for (int i = 0; i < n.Length; i++)
    //        {
    //            s += n[i];
    //        }
    //        return s;
    //    }
    //    public double soma(params double[] n)
    //    {
    //        double s = 0;
    //        for (int i = 0; i < n.Length; i++)
    //        {
    //            s += n[i];
    //        }
    //        return s;
    //    }
    //    public int fat(int n)
    //    {
    //        int res;
    //        if(n <= 1)
    //        {
    //            res = 1;
    //        }
    //        else
    //        {
    //            res = n * fat (n - 1);//fat= 5 -1 = 4/fat= 4 -1 = 3..
    //        }
    //        return res;
    //    }
    //}

    //class Aula48
    //{
    //    static void Main()
    //    {

    //        Calc calc = new Calc();
    //        {
    //            var res = calc.fat(10);

    //            Console.WriteLine(res);
    //        }

    //    }
    //}
    ////=======================================================================
    ////*** CLASSE E OBJETOS ***  Membros e Variáveis Static
    ////=======================================================================
    ////Aula49
    ////
    //using System;

    //class Mat
    //{
    //    public static double pi = 3.14;

    //    public static int dobro(int n)
    //    {
    //        return n * 2;
    //    }
    //}


    //class Aula49
    //{
    //    static void Main()
    //    {
    //        double vpi = Mat.pi;//pi está vindo da clsse Mat
    //        int num = 10;
    //        Console.WriteLine(vpi);
    //        Console.WriteLine(Mat.dobro(num));
    //    }
    //}
    ////=======================================================================
    ////*** CLASSE E OBJETOS ***  Delegate
    ////=======================================================================
    ////Aula50
    ////

    //delegate int Op(int n1, int n2);
    //class Mat
    //{
    //    public static int soma(int n1, int n2)
    //    {
    //        return n1 + n2;
    //    }

    //    public static int mult(int n1, int n2)
    //    {
    //        return n1 * n2;
    //    }

    //    class Aula50
    //    {
    //        static void Main()
    //        {
    //            int res;

    //            Op d1 = new Op(soma);

    //            res = d1(10, 50);

    //            Console.WriteLine("Soma: {0}", res);

    //            d1 = new Op(mult);

    //            res = d1(10, 50);

    //            Console.WriteLine("Multiplicação: {0}", res);
    //        }
    //    }

    //}
    ////=======================================================================
    ////*** CLASSE E OBJETOS ***  Argumentos de entrada do Programa
    ////=======================================================================
    ////Aula51
    ////Testar no terminal do CODE
    //using System;

    //class Aula51
    //{
    //    static void Main(string[] args)
    //    {
    //        int res = 0;

    //        if (args.Length > 0)
    //        {
    //            Console.WriteLine("Qtde de argumentos {0}", args.Length);
    //            for(int i = 0; i < args.Length; i++)
    //            {
    //                res += Int32.Parse(args[i]);
    //                Console.WriteLine("Argumento {0}:{1}", i, args[i]);
    //            }
    //            Console.WriteLine("Soma: {0}", res);
    //        }
    //        else
    //        {
    //            Console.WriteLine("não foram passados nenhum argumento");
    //        }
    //    }

    //}
    ////=======================================================================
    ////*** CLASSE E OBJETOS *** EXCEÇÔES
    ////=======================================================================
    ////Aula52 PARTE1
    ////
    //using System;

    //class Aula52
    //{
    //    static void Main()
    //    {
    //        int n1, n2, res;
    //        res = n1 = n2 = 0;

    //        n1 = 10;
    //        n2 = 0;

    //        try
    //        {
    //            res = n1 / n2;
    //            Console.WriteLine("{0} / {1} = {2}", n1, n2, res);

    //        }
    //        catch (Exception e)//Exception é a exceção genérica
    //        {
    //            Console.WriteLine("ERRO: {0}", e.Message);
    //            Console.WriteLine("EXCEÇÃO: {0}", e.GetType());
    //        }
    //    }

    //}
    ////=======================================================================
    ////*** CLASSE E OBJETOS *** EXCEÇÔES
    ////=======================================================================
    ////Aula52 PARTE2
    ////
    //using System;
    //class Area
    //{
    //    public static float Quad(float bas, float alt)
    //    {
    //        if(bas == 0 || alt == 0)
    //        {
    //            throw new Exception("Base ou Altura não podem ser igual a 0(Zero)");
    //        }
    //        return bas * alt;
    //    }
    //}
    //class Aula52
    //{
    //    static void Main()
    //    {
    //        float area = 0;

    //        try
    //        {
    //            area = Area.Quad(0, 5f);
    //            Console.WriteLine("Área do Quadrado: {0}", area);
    //        }
    //        catch (Exception e)//Exception é a exceção genérica
    //        {
    //            Console.WriteLine("ERRO: {0}", e.Message);
    //        }
    //        finally //Será excecutado independentemente de erro
    //        {
    //            Console.WriteLine("Fim do processo");
    //        }
    //    }
    //}
    // //=======================================================================
    ////*** CLASSE E OBJETOS *** Namespaces
    ////=======================================================================
    ////Aula54
    ////
    //using System;
    //namespace Calc1
    //{
    //    class Area
    //    {
    //        public static float Quad(float bas, float alt)
    //        {
    //            if (bas == 0 || alt == 0)
    //            {
    //                throw new Exception("Base ou Altura não podem ser igual a 0(Zero)");
    //            }
    //            return bas * alt;
    //        }
    //    }
    //}
    //namespace Calc2
    //{
    //    class Area //podee-se repetir a Classe se esta pertencer a um namespace diferente
    //    {
    //        public static float Quad(float bas, float alt)
    //        {
    //            if (bas == 0 || alt == 0)
    //            {
    //                throw new Exception("Base ou Altura não podem ser igual a 0(Zero)");
    //            }
    //            return bas * alt;
    //        }
    //    }
    //}

    //class Aula54
    //{
    //    static void Main()
    //    {
    //        float area = 0;

    //        try
    //        {
    //            area = Calc1.Area.Quad(0, 5f);//Calc1 = o namespace 
    //            Console.WriteLine("Área do Quadrado: {0}", area);
    //        }
    //        catch (Exception e)//Exception é a exceção genérica
    //        {
    //            Console.WriteLine("ERRO: {0}", e.Message);
    //        }
    //        finally //Será excecutado independentemente de erro
    //        {
    //            Console.WriteLine("Fim do processo");
    //        }
    //    }
    //}
    ////=======================================================================
    ////*** CLASSE E OBJETOS *** Dictionary
    ////=======================================================================
    ////Aula55
    ////
    //using System;
    //using System.Collections.Generic;

    //namespace Calc1
    //{
    //    class Area
    //    {
    //        public static float Quad(float bas, float alt)
    //        {
    //            if (bas == 0 || alt == 0)
    //            {
    //                throw new Exception("Base ou Altura não podem ser igual a 0(Zero)");
    //            }
    //            return bas * alt;
    //        }
    //    }
    //}


    //class Aula55
    //{
    //    static void Main()
    //    {
    //        Dictionary<int, string> veiculos = new Dictionary<int, string>();//< TIPO, VALOR>

    //        veiculos.Add(10, "Carro");//Chave/TIPO, Valor
    //        veiculos.Add(5, "Avião");//Chave/TIPO, Valor
    //        veiculos.Add(0, "Navio");//Chave/TIPO, Valor
    //        veiculos.Add(20, "Moto");//Chave/TIPO, Valor
    //        veiculos.Add(15, "Patinete");//Chave/TIPO, Valor

    //        //veiculos.Clear();Para limpar toda a coleção
    //        //veiculos.Remove(20); Para remover o item 20 da Coleção

    //        Console.WriteLine("Tamanaho do Dictionary: {0}", veiculos.Count);
    //        int chave = 10;
    //        if (veiculos.ContainsKey(chave))
    //        {
    //            Console.WriteLine("Achave {0} está na coleção", chave);
    //        }
    //        else
    //        {
    //            Console.WriteLine("A chave {0} Não está na coleção", chave);
    //        }

    //        //veiculos[15] = "Patins";

    //        string valor = "Patins";
    //        if (veiculos.ContainsValue(valor))
    //        {
    //            Console.WriteLine("O valor {0} está na coleção", valor);
    //        }
    //        else
    //        {
    //            Console.WriteLine("O valor {0} Não está na coleção", valor);
    //        }

    //        foreach(KeyValuePair<int, string> v in veiculos)
    //        {
    //            Console.WriteLine(v);//Traz tudo
    //            Console.WriteLine(v.Value);//Traz só os valores
    //            Console.WriteLine(v.Key);//Traz só as chaves
    //        }
    //    }
    //}
    ////=======================================================================
    ////*** CLASSE E OBJETOS *** LinkedList
    ////=======================================================================
    ////Aula56
    ////Lista duplamente encadeada
    //using System;
    //using System.Collections.Generic;

    //class Aula56
    //{
    //    static void Main()
    //    {
    //        LinkedList<string> transp = new LinkedList<string>();

    //        transp.AddFirst("Carro");//AddFirst Adicionará cada item ao inicio
    //        transp.AddFirst("Avião");
    //        transp.AddFirst("Navio");
    //        transp.AddFirst("Motocicleta");

    //        transp.AddLast("Bicicleta");//AddLast Adicionará cada item ao final

    //        LinkedListNode<string> no;
    //        no = transp.FindLast("Navio");
    //        transp.AddAfter(no, "Patinete");//AddAfter para adicionar Patinete depois de Navio
    //        no = transp.FindLast("Navio");
    //        transp.AddBefore(no, "Patins");//AddAfter para adicionar Patinete depois de Navio

    //        //transp.Clear();//Para remover todos os elementos da lista
    //        if(transp.Find("Carro") == null)
    //        {
    //            Console.WriteLine("Não encontrado");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Elemento encontrado");
    //        }
    //        //transp.Remove("Navio"); = Remove o elemento Navio
    //        //transp.RemoveFirst("Navio");Remove o primeiro elemento
    //        //transp.RemovLast("Navio");Remove o último elemento

    //        foreach (string t in transp)
    //        {
    //            Console.WriteLine("Transporte: {0}",t);
    //        }
    //    }
    //}
    ////=======================================================================
    ////*** CLASSE E OBJETOS *** LIST - PART1
    ////=======================================================================
    ////Aula57
    ////Coleção List P1
    //using System;
    //using System.Collections.Generic;

    //class Aula57
    //{
    //    static void Main()
    //    {
    //        List<string> carros = new List<string>();
    //        string[] carros2 = new string[6];

    //        carros.Add("Golf");
    //        carros.Add("HRV");
    //        carros.Add("Focus");
    //        carros.Add("Argo");

    //        //carros2.AddRange(carros);//Usa os elementos de Carros

    //        //carros.Clear();
    //        if (carros.Contains("Golf"))
    //        {
    //            Console.WriteLine("Está na lista");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Não encontrado");
    //        }
    //        carros.CopyTo(carros2, 2);
    //        foreach (string c in carros2)
    //        {
    //            Console.WriteLine("Carro: {0}", c);
    //        }
    //        string ca = "HRV";
    //        int pos = 0;
    //        pos = carros.IndexOf(ca);
    //        Console.WriteLine("Carro {0} está na posição: {1}", ca, pos);
    //    }
    //}
    ////=======================================================================
    ////*** CLASSE E OBJETOS *** LIST - PART2
    ////=======================================================================
    ////Aula58
    ////Coleção List P2
    //using System;
    //using System.Collections.Generic;

    //class Aula58
    //{
    //    static void Main()
    //    {
    //        List<string> carros = new List<string>();
    //        string[] carros2 = new string[7];

    //        carros.Add("Golf");
    //        carros.Add("HRV");
    //        carros.Add("Focus");
    //        carros.Add("Argo");
    //        carros.Add("HRV");

    //        //carros2.AddRange(carros);//Usa os elementos de Carros

    //        //carros.Clear();
    //        if (carros.Contains("Golf"))
    //        {
    //            Console.WriteLine("Está na lista");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Não encontrado");
    //        }
    //        carros.CopyTo(carros2, 2);

    //        carros.Insert(1, "Cruze");//Insere um elemento na posição determinada

    //        //carros.RemoveAt(0);//Remove elemento de posição determinada

    //        //carros.Remove("Argo");

    //        //carros.Reverse();//Inverte a lista

    //        carros.Sort();//Ordena a lista por ordem alfabética

    //        int tamanho = carros.Count;//Conta os carros da lista
    //        carros.Capacity = 15;
    //        int capac = carros.Capacity;// Informa a capacidade de carros na lista

    //        Console.WriteLine("Quantidade de carros é: {0}", tamanho);
    //        Console.WriteLine("Capacidade de carros é: {0}",capac);

    //        int pos2 = carros.LastIndexOf("HRV");
    //        //Apontará para a última posição do elemento
    //        foreach (string c in carros)
    //        {
    //            Console.WriteLine("Carro: {0}", c);
    //        }

    //        string ca = "HRV";

    //        int pos = 0;
    //        pos = carros.IndexOf(ca);
    //        Console.WriteLine("Carro {0} está na posição: {1}", ca, pos);
    //        Console.WriteLine("Último HRV está na posição {0}", pos2);
    //    }
    //}
    ////=======================================================================
    ////*** CLASSE E OBJETOS *** QUEUE - Fila
    ////=======================================================================
    ////Aula59
    ////Queue - FILA
    //using System;
    //using System.Collections.Generic;

    //class Aula59
    //{
    //    static void Main()
    //    {
    //        //string[] vs = { "Carro", "Moto", "Navio", "Avião" };
    //        Queue<string> veiculos = new Queue<string>();
    //        veiculos.Enqueue("Carro");//Queue adiciona ao final da fila
    //        veiculos.Enqueue("Moto");
    //        veiculos.Enqueue("Navio");
    //        veiculos.Enqueue("Avião");

    //        string v = "Patins";
    //        if (veiculos.Contains(v))
    //        {
    //            Console.WriteLine("Veiculo " + v + " encontrado");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Veiculo " + v + " não encontrado");
    //        }
    //        //Console.WriteLine("Tamanho da fila é: {0}", veiculos.Dequeue());//Dequeue retorna e tira o primeiro elemento da fila
    //        //Console.WriteLine("Tamanho da fila é: {0}", veiculos.Peek());//Peek retorna o primeiro elemento da fila, mas não remove

    //        //foreach (string veic in veiculos)
    //        //{
    //        //    Console.WriteLine("Veiculos " + veic);
    //        //}
    //        Console.WriteLine("Tamanho da fila é: {0}", veiculos.Count);
    //        //Console.WriteLine(veiculos[2]);

    //        while (veiculos.Count > 0)
    //        {
    //            Console.WriteLine(veiculos.Dequeue());
    //        }
    //        Console.WriteLine("Tamanho da fila é: {0}", veiculos.Count);
    //    }
    //}
    ////=======================================================================
    ////*** CLASSE E OBJETOS *** QUEUE - Fila
    ////=======================================================================
    ////Aula59
    ////Queue - FILA
    //using System;
    //using System.Collections.Generic;

    //class Aula59
    //{
    //    static void Main()
    //    {

    //    }
    //}

    ////=======================================================================
    ////*** COMPONENTES *** AULAS 60 a diante
    ////=======================================================================
    ////Aula60
    ////IMPORTANTE para trabalhar com datas e campos correlatos
    ///
    /// https://www.youtube.com/watch?v=owySYPEyyYw&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=62
    /// 
    ////=======================================================================
    ////*** COMPONENTES *** DateTimePiker
    ////=======================================================================
    ////Aula70
    ////IMPORTANTE para trabalhar com datas e campos correlatos
    ///
    /// https://www.youtube.com/watch?v=yF2ebi6ubIg&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=72
    /// 
    ////=======================================================================
    ////*** Componentes ***  LABEL / LINKLABEL
    ////=======================================================================
    ////Aula71
    ////LABEL = IMPORTANTE para Etiquetar um campo
    ////LABEL = IMPORTANTE para Etiquetar um campo e atribuir um link WEB ou parte de um programa
    ///
    /// https://www.youtube.com/watch?v=yF2ebi6ubIg&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=73
    /// 
    ////=======================================================================
    ////*** Componentes ***  ListBox
    ////=======================================================================
    ////Aula72
    ////
    ////
    /// https://www.youtube.com/watch?v=yF2ebi6ubIg&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=74
    ///
    ////=======================================================================
    ////*** Componentes ***  ListView PT1
    ////=======================================================================
    ////Aula73
    ////ListView = Mostra conteúdo como tabela
    ////
    /// https://www.youtube.com/watch?v=yF2ebi6ubIg&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=75
    ///
    ////=======================================================================
    ////*** Componentes ***  ListView PT2
    ////=======================================================================
    ////Aula74
    ////
    ////
    /// https://www.youtube.com/watch?v=yF2ebi6ubIg&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=76
    ///
    ////=======================================================================
    ////*** Componentes ***  ListView PT3
    ////=======================================================================
    ////Aula75
    ////
    ////
    /// https://www.youtube.com/watch?v=yF2ebi6ubIg&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=77
    ///
    ////=======================================================================
    ////*** Componentes ***  MaskedTextBox
    ////=======================================================================
    ////Aula76
    ////MaskedTextBox = ajuda na construção de padrões como CEP, CPF, RG...
    ////
    /// https://www.youtube.com/watch?v=yF2ebi6ubIg&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=78
    ///
    ////=======================================================================
    ////*** Componentes ***  MonthCalendar 
    ////=======================================================================
    ////Aula77
    ////MonthCalendar 
    /// https://www.youtube.com/watch?v=yF2ebi6ubIg&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=79
    ///
    ////=======================================================================
    ////*** Componentes ***  Notifylcon e ContextMenuStrip
    ////=======================================================================
    ////Aula78
    ////Notifylcon e ContextMenuStrip
    ////
    /// https://www.youtube.com/watch?v=yF2ebi6ubIg&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=80
    ///
    ////=======================================================================
    ////*** Componentes ***  NumericUpDown
    ////=======================================================================
    ////Aula79
    ////NumericUpDown
    ////
    /// https://www.youtube.com/watch?v=yF2ebi6ubIg&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=81
    ///
    ////=======================================================================
    ////*** Componentes ***  PictureBox
    ////=======================================================================
    ////Aula80
    ////PictureBox
    ////
    /// https://www.youtube.com/watch?v=yF2ebi6ubIg&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=82
    ///


    ////=======================================================================
    ////*** Componentes ***  Progressbar
    ////=======================================================================
    ////Aula81
    ////Progressbar
    ////
    /// https://www.youtube.com/watch?v=yF2ebi6ubIg&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=83
    ///
    ////=======================================================================
    ////*** Componentes ***  RadioButton
    ////=======================================================================
    ////Aula82
    ////PictureBox
    ////
    /// https://www.youtube.com/watch?v=yF2ebi6ubIg&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=84
    ///
    ////=======================================================================
    ////*** Componentes ***  EDITOR DE TEXTO PT-1, PT-2, PT-3, PT-4, PT-5
    ////=======================================================================
    ////Aula83
    ////EDITOR DE TEXTO
    ////
    /// https://www.youtube.com/watch?v=yF2ebi6ubIg&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=85
    /// https://www.youtube.com/watch?v=yF2ebi6ubIg&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=86
    /// https://www.youtube.com/watch?v=yF2ebi6ubIg&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=87
    /// https://www.youtube.com/watch?v=yF2ebi6ubIg&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=88
    /// https://www.youtube.com/watch?v=yF2ebi6ubIg&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=89
    /// 
    /// 
    /// 
    ///
    ////=======================================================================
    ////*** Componentes ***  trackbar
    ////=======================================================================
    ////Aula88
    ////trackbar
    ////
    /// https://www.youtube.com/watch?v=yF2ebi6ubIg&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=90
    ///
    ////=======================================================================
    ////*** Componentes ***  treeview
    ////=======================================================================
    ////Aula89
    ////PictureBox
    ////
    /// https://www.youtube.com/watch?v=yF2ebi6ubIg&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=91
    ///
    ////=======================================================================
    ////*** Componentes ***  Criando Browser
    ////=======================================================================
    ////Aula90
    ////Criando Browser
    ////
    /// https://www.youtube.com/watch?v=yF2ebi6ubIg&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=92
    ///
    ////=======================================================================
    ////*** Componentes ***  SplitContainer
    ////=======================================================================
    ////Aula91
    ////SplitContainer
    ////
    /// https://www.youtube.com/watch?v=yF2ebi6ubIg&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=93
    ///
    ////=======================================================================
    ////*** Componentes ***  TabControl
    ////=======================================================================
    ////Aula92
    ////TabControl
    ////
    /// https://www.youtube.com/watch?v=yF2ebi6ubIg&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=94
    ///
    ////=======================================================================
    ////*** Componentes ***  TableLayoutPanel
    ////=======================================================================
    ////Aula93
    ////TableLayoutPanel
    ////
    /// https://www.youtube.com/watch?v=yF2ebi6ubIg&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=95
    ///
    ////=======================================================================
    ////*** Componentes ***  TollStripContainer
    ////=======================================================================
    ////Aula94
    ////TollStripContainer
    ////
    /// https://www.youtube.com/watch?v=yF2ebi6ubIg&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=96
    ///
    ////=======================================================================
    ////*** Componentes ***  Componente Backgroundworker
    ////=======================================================================
    ////Aula95
    ////Componente Backgroundworker
    ////
    /// https://www.youtube.com/watch?v=yF2ebi6ubIg&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=97
    ///
    ////=======================================================================
    ////*** Componentes *** Componente Timer
    ////=======================================================================
    ////Aula96
    ////Componente Timer
    ////
    /// https://www.youtube.com/watch?v=yF2ebi6ubIg&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=98
    ///
    ////=======================================================================
    ////*** Componentes ***  Adicionando SQLite
    ////=======================================================================
    ////Aula97
    ////Adicionando SQLite
    ////
    /// https://www.youtube.com/watch?v=yF2ebi6ubIg&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=99
    ///
    ////=======================================================================
    ////*** Componentes ***  Banco de dados e tabelas
    ////=======================================================================
    ////Aula98
    ////Banco de dados e tabelas
    ////
    /// https://www.youtube.com/watch?v=yF2ebi6ubIg&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=100
    ///
    ////=======================================================================
    ////*** Componentes *** Classes para funções de Bancos de dados
    ////=======================================================================
    ////Aula99
    ////Classes para funções de Bancos de dados
    ////
    /// https://www.youtube.com/watch?v=yF2ebi6ubIg&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=101
    ///
    ////=======================================================================
    ////*** Componentes ***  Formulario de Login PT-1 e PT-2
    ////=======================================================================
    ////Aula100
    ////PictureBox
    ////
    /// https://www.youtube.com/watch?v=yF2ebi6ubIg&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=102
    /// https://www.youtube.com/watch?v=yF2ebi6ubIg&list=PLx4x_zx8csUglgKTmgfVFEhWWBQCasNGi&index=103
    ///

    ///CONTINUA ATÉ AULA 130























    //=================================================================
    // Teste Mestre dos Magos
    //=================================================================
    //using System;
    //class Program
    //{
    //    static void Main()
    //    {
    //        string login = "";
    //        string senha = "";

    //        Console.Write("Digite seu Login: ");
    //        login = Console.ReadLine();

    //        Console.Write("Digite sua senha: ");
    //        senha = Console.ReadLine();

    //        if (validaLogin(login, senha).Equals(true))
    //        {
    //            Menu();
    //        }
    //        else
    //        {
    //            Main();
    //        }
    //    }


    //    static Boolean validaLogin(string login, string senha)
    //    {
    //        if (login == "" | senha == "")
    //        {
    //            Console.WriteLine("Login ou senha não podem ser vazio\n");
    //            return false;
    //        }
    //        else
    //        {
    //            if (login.Contains("Diego") & senha.Contains("1111"))
    //            {
    //                Console.WriteLine("Usuario Logado com sucesso");
    //                return true;
    //            }
    //            else
    //            {
    //                Console.WriteLine("Usuario não tem acesso\n");
    //            }
    //            return false;
    //        }
    //    }

    //    static void Menu()
    //    {
    //        int escolha = 0;
    //        while (escolha != 3)
    //        {
    //            Console.WriteLine("Menu\n" +
    //                            "1 - Soma simples\n" +
    //                            "2 - Surpresa\n" +
    //                            "3 - Sair\n");
    //            Console.Write("Escolha o que deseja fazer: ");
    //            escolha = int.Parse(Console.ReadLine());
    //            switch (escolha)
    //            {
    //                case 1:
    //                    Calculadora();
    //                    break;
    //                case 2:
    //                    Console.WriteLine("Tem nada aqui não!");
    //                    break;
    //                case 3:
    //                    Console.WriteLine("Fechando o programa");
    //                    Console.Clear();
    //                    break;
    //                default:
    //                    Console.WriteLine("Tipo de operação Invalida\n");
    //                    break;
    //            }
    //        }
    //    }

    //    static void Calculadora()
    //    {
    //        int v1, v2, resultado;
    //        string opcao = "";

    //        Console.WriteLine("Calculadora simples");
    //        Console.Write("Digite o primeiro valor: ");
    //        v1 = int.Parse(Console.ReadLine());
    //        Console.WriteLine("Valor digitado:{0}", v1);

    //        Console.Write("Digite o segundo valor: ");
    //        v2 = Convert.ToInt32(Console.ReadLine());
    //        Console.WriteLine("Valor digitado:{0}", v2);
    //        while (opcao != "sair")
    //        {
    //            Console.Write("a - Adição\n" +
    //                        "s - Subtração\n" +
    //                        "m - Multiplicação\n" +
    //                        "d - Divisão\n" +
    //                        "sair - Sair do programa\n" +
    //                        "Escoha a operação que deseja realizar: ");
    //            opcao = Console.ReadLine();

    //            switch (opcao)
    //            {
    //                case "a":
    //                    resultado = v1 + v2;
    //                    Console.WriteLine("A soma de {0} + {1} é:{2}", v1, v2, resultado);
    //                    break;
    //                case "s":
    //                    resultado = v1 - v2;
    //                    Console.WriteLine("A subtração de {0} - {1} é:{2}", v1, v2, resultado);
    //                    break;
    //                case "m":
    //                    resultado = v1 * v2;
    //                    Console.WriteLine("A multiplicação de {0} * {1} é:{2}", v1, v2, resultado);
    //                    break;
    //                case "d":
    //                    resultado = v1 / v2;
    //                    Console.WriteLine("A divisão de {0} / {1} é:{2}", v1, v2, resultado);
    //                    break;
    //                case "sair":
    //                    Console.WriteLine("Retornado para o menu");
    //                    Console.Clear();
    //                    Menu();
    //                    break;
    //                default:
    //                    Console.WriteLine("Tipo de operação Invalida\n");
    //                    break;
    //            }
    //        }
    //    }
    //}
    //using System;

    //class Program
    //{
    //    static void Main()
    //    {
    //        //string nome;

    //        string[] nomes = new string[] { "Tiago", "Diego", "Matheus" };
    //        foreach (string nome in nomes)
    //        {
    //            if (nome == "Diego")
    //                //break;
    //            Console.WriteLine(nome);
    //        }
    //    }
    //}
    //using System;

    //class Program
    //{
    //    static void Main()
    //    {
    //int num1, num2;
    //int resultado;

    //Console.Write("Digite o 1º número: ");
    //num1 = int.Parse(Console.ReadLine());
    //Console.Write("Digite o 2º número: ");
    //num2 = int.Parse(Console.ReadLine());

    //resultado = num1 + num2;
    //Console.WriteLine(resultado);

    //        int resultado;

    //        resultado = 1 + 2;

    //        Console.WriteLine(resultado);

    //        int num = 3;
    //        int numero = 4;

    //        resultado = num + numero;

    //        Console.WriteLine(resultado);
    //    }
    //}

    using System;

    namespace Program
    {

        public static void Main()
        {
            string nome = "Tiago";
            int senha = 123;
        }
        public static void Login(string nome, int senha)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("\tQuer entrar na minha festa?");
            Console.WriteLine("\tEntão faça seu Login");
            Console.WriteLine("========================================");


            Console.WriteLine("\nDigite seu Nome: ");
            nome(Console.ReadLine());

            Console.WriteLine("\nDigite sua Senha: ");
            senha(Console.ReadLine());

            if (nome == "Tiago" && senha == 123)
            {
                Console.WriteLine("\nBem vindo a Festa, {0}", nome);
            }
            else
            {
                Console.WriteLine("\nVai pra casa, ninguém te chamou aqui!");
            }
        }

    }

}



