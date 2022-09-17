Console.Write("Escreva seu nome: ");
string nomedigitado = Console.ReadLine()!;
string nomeninja = nomedigitado
            .ToUpper()
            .Replace("A" , "ka")
            .Replace("B" , "zu")
            .Replace("C" , "mi")
            .Replace("D" , "te")
            .Replace("E" , "ku")
            .Replace("F" , "lu")
            .Replace("G" , "ji")
            .Replace("H" , "ri")
            .Replace("I" , "ki")
            .Replace("J" , "zus")
            .Replace("K" , "me")
            .Replace("L" , "ta")
            .Replace("M" , "rin")
            .Replace("N" , "to")
            .Replace("O" , "mo")
            .Replace("P" , "no")
            .Replace("Q" , "ke")
            .Replace("R" , "shi")
            .Replace("S" , "ari")
            .Replace("T" , "shi")
            .Replace("U" , "do")
            .Replace("V" , "ru")
            .Replace("W" , "mei")
            .Replace("X" , "na")
            .Replace("Y" , "fu")
            .Replace("Z" , "zi");

      string nomeprimeiro = nomeninja.Substring(0,1).ToUpper();
      string nomeminusculo = nomeninja.Substring(1).ToLower();
      Console.Write($"Seu nome ninja é {nomeprimeiro}{nomeminusculo}");










