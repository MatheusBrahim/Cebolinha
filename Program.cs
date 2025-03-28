string cebolinha;

Console.Clear();

Console.WriteLine("Exercico Cebolinha");

Console.WriteLine(@"Qual frase você deseja converter?");

cebolinha = Console.ReadLine();
cebolinha = cebolinha
.Replace("r", "l")
.Replace("R", "L");

Console.WriteLine(cebolinha);