using System; 

public class Program {

  public static void Main(string[] args) {
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    if (a > b) Console.WriteLine(a);
    if (a < b) Console.WriteLine(b);
    else Console.WriteLine("os numeros são iguais");
  }
}