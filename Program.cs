double tempo, distancia, velocidade;

Console.Write("\nDistância Percorrida (m): ");
distancia = Convert.ToDouble(Console.ReadLine());

Console.Write("Tempo Gasto (s): ");
tempo = Convert.ToDouble(Console.ReadLine());

velocidade = (distancia / tempo);

Console.Write("\nVelocidade Média: ");

Console.ForegroundColor = ConsoleColor.Green;

Console.WriteLine($"{velocidade:N2} m/s\n");

Console.ResetColor();
