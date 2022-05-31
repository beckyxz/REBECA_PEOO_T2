using System; 

public class Program {

  public static void Main(string[] args) {
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
    int d = int.Parse(Console.ReadLine());
    int media = (a + b + c + d)/4;
    Console.WriteLine("Média = " + media);

    Console.WriteLine("Numeros menores que a media:");

    if (a<media)Console.WriteLine(a);
    if (b<media)Console.WriteLine(b);
    if (c<media)Console.WriteLine(c);
    if (d<media)Console.WriteLine(d);

    Console.WriteLine("Numeros maiores ou iguais a media:");
    
    if (a>=media)Console.WriteLine(a);
    if (b>=media)Console.WriteLine(b);
    if (c>=media)Console.WriteLine(c);
    if (d>=media)Console.WriteLine(d);
  }
}