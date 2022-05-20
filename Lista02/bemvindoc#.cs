using System; 

public class Program {

  public static void Main(string[] args) {
     Console.WriteLine("Digite seu nome completo: ");
           string nome = Console.ReadLine();
           string[] v = nome.Split();
           Console.WriteLine("Bem Vindo ao C#, " + v[0]);