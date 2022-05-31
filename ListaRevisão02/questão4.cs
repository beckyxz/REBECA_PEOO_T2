using System;
public class Program {
  public static void Main(string[] args) {

     Console.WriteLine("Digite o primeiro horário no formato hh:mm");
    string s = Console.ReadLine();
    string[] v = s.Split(":");

      Console.WriteLine("Digite o segundo horário no formato hh:mm");
    
    string h = Console.ReadLine();
    string[] w = h.Split(":");
    
    int a = int.Parse(v[0]);
    int b = int.Parse(v[1]);
    int c = int.Parse(w[0]);
    int d = int.Parse(w[1]);
    int resto = 0;

    int min = (b + d);
    if (min >=60) resto = min - 60 ;
    int hora = (a+c+(resto/10));
        
    Console.WriteLine(string.Format("Total de horas = {0:00}:{1:00}",hora, resto));
  }  
}