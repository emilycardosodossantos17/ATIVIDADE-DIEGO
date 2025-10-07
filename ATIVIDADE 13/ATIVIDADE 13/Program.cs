
Console.Write("Digite o prmeiro valor: ");
double a = double.Parse(Console.ReadLine() ?? "0");

Console.Write("Digite o segundo valor: ");
double b = double.Parse(Console.ReadLine() ?? "0");

Console.Write("Digite o terceiro valor: ");
double c = double.Parse(Console.ReadLine() ?? "0");

double[] arr = new double[] { a, b, c };
Array.Sort(arr);

Console.WriteLine("valores em ordem crescente");
Console.WriteLine($"{arr[0]}, {arr[1]}, {arr[2]}");
Console.WriteLine("Pressione Enter para sair..");
Console.ReadLine();