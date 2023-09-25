using System;

class Program {
  //Questão 1
  public static int Fatorial(int x)
  {
    if(x == 0)
    {
      return 1;
    }
    return x * Fatorial(x - 1);
  }
  //Questão 2
  public static int Fibonacci(int x)
  {
    if(x <= 1)
    {
      return x;
    }
    return Fibonacci(x - 1) + Fibonacci(x - 2);
  }
  //Questão 3
  public static int somaVetor(int[] x, int posicao)
  {
    if(posicao >= x.Length)
    {
      return 0;
    }
    return x[posicao] + somaVetor(x, posicao + 1);
  }
  //Questão 4
  public static int posicao(int[] v,int pos, int n)
  {
    if(pos == v.Length)
    {
      return(-1);
    }
    if(v[pos] == n)
    {
     return(pos);
    }
    return(posicao(v, pos+1, n));
  }
  //Questão 5
  public static int multiplicar(int x, int y)
  {
    if(x == 0 || y ==0)
    {
      return 0;
    }
    if(x == 1)
    {
      return y;
    }
    if(y == 1)
    {
      return x;
    }
    return x + multiplicar(x, y - 1);
  }
  //Questão 6
  public static int potencia(int operador, int expoente)
  {
    if(expoente == 0)
    {
      return 1;
    }
    return operador * potencia(operador, expoente - 1);
  }
  //Questão 7
  public static int procuraLetra(string frase, char letra)
  {
    if(frase.Length == 0)//Verifica se a frase está vazia.
    {
      return 0;
    }
    else
    {
      int qtd = procuraLetra(frase.Substring(1), letra);
      //O método Substring() é utilizado em C# para obter parte de um texto a partir de uma posição inicial.
      if(frase[0] == letra)
      {
        qtd++;
      }
      return qtd;
    }
  }
  //Questão 8
  public static int somaPar(int[] vetor, int pos)
  {
    if(vetor[pos] % 2 != 0)
    {
      return 0;
    }
    if(pos >= vetor.Length)
    {
      return 0;
    }
    return vetor[pos] + somaPar(vetor, pos + 1);
  }
  //Questão 9
  static string RemoverVogais(string input)
  {
    if (string.IsNullOrEmpty(input))
    {
      return input;
    }
    char primeiroCaractere = input[0];
    string restante = input.Substring(1);
    if (IsVogal(primeiroCaractere))
    {
      return RemoverVogais(restante);
    }
    else
    {
      return primeiroCaractere + RemoverVogais(restante);
    }
  }
  public static bool IsVogal(char c)
  {
    char[] vogais = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
    return Array.IndexOf(vogais, c) >= 0;
  }
  //Questão 10
  public static string binario(int num)
  {
    if (num == 0)
    {
      return "0";
    }
    else if (num == 1)
    {
      return "1";
    }
    else
    {
      int resto = num % 2;
      int quociente = num / 2;
      return binario(quociente) + resto;
    }
  }
  
  public static void Main (string[] args) {
    //Questão 1
    int fatorial = 0;
    Console.Write("Insira um número: ");
    fatorial = int.Parse(Console.ReadLine());
    Console.WriteLine($"O fatorial de {fatorial} é: {Fatorial(fatorial)}");
    //Questão 2
    int fibo = 0;
    Console.Write("Insira um número:");
    fibo = int.Parse(Console.ReadLine());
    Console.WriteLine($"O fibonnacci de {fibo} é: {Fibonacci(fibo)}");
    //Questão 3
    int[] vetor = new int[5];
    for (int i = 0; i < 5; i++)
    {
      Console.Write($"Insira o {i+1}º número do vetor: ");
      vetor[i] = int.Parse(Console.ReadLine());
    }
    Console.WriteLine("A soma do vetor é: " + somaVetor(vetor, 0));
    //Questão 4
    int[] vetorPos = new int[5];
    int num4 = 0;
    for (int i = 0; i < 5; i++)
    {
      Console.Write($"Insira o {i+1}º número do vetor: ");
      vetorPos[i] = int.Parse(Console.ReadLine());
    }
    Console.Write("Insira qual número que deseja encontrar no vetor: ");
    num4 = int.Parse(Console.ReadLine());
    Console.WriteLine($"A posição do número {num4}");
    //Questão 5
    int x5 = 0, y5 = 0;
    Console.Write("Insira o valor de X: ");
    x5 = int.Parse(Console.ReadLine());
    Console.Write("Insira o valor de Y: ");
    y5 = int.Parse(Console.ReadLine());
    Console.WriteLine($"O resultado de {x5} * {y5} é: {multiplicar(x5, y5)}");
    //Questão 6
    int a6 = 0, b6 = 0;
    Console.Write("Insira o valor de A: ");
    a6 = int.Parse(Console.ReadLine());
    Console.Write("Insira o valor de B: ");
    b6 = int.Parse(Console.ReadLine());
    Console.WriteLine($"O resultado de {a6} elevado a {b6} é: {potencia(a6, b6)}");
    //Questão 7
    char letra;
    string frase;
    Console.Write("Insira uma frase: ");
    frase = Console.ReadLine();
    Console.Write("Insira uma letra: ");
    letra = char.Parse(Console.ReadLine());
    Console.WriteLine($"A letra {letra} aparece {procuraLetra(frase, letra)} vez/vezes na frase inserida.");
    //Questão 8
    int[] nums = new int[5];
    for (int i = 0; i < 5; i++)
    {
      Console.Write($"Insira o {i+1}º número do vetor: ");
      nums[i] = int.Parse(Console.ReadLine());
    }
    Console.WriteLine($"A soma dos elementos pares do vetor resulta em: {somaPar(nums, 0)}");
    //Questão 9
    string input;
    Console.Write("Insira uma frase: ");
    input = Console.ReadLine();
    Console.WriteLine("Frase sem vogais: " + RemoverVogais(input));
    //Questão 10
    int bin = 0;
    Console.Write("Insira um número:");
    bin = int.Parse(Console.ReadLine());
    Console.WriteLine($"O binário de {binario} é: {binario(bin)}.");
  }
}