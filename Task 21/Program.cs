// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int[] coordinateA = new int[3];

System.Console.Write("X координата первой точки: ");
coordinateA[0] = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Y координата первой точки: ");
coordinateA[1] = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Z координата первой точки: ");
coordinateA[2] = Convert.ToInt32(Console.ReadLine());

int[] coordinateB = new int[3];

System.Console.Write("X координата второй точки: ");
coordinateB[0] = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Y координата второй точки: ");
coordinateB[1] = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Z координата второй точки: ");
coordinateB[2] = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((coordinateB[0] - coordinateA[0]), 2) + Math.Pow((coordinateB[1] - coordinateA[1]), 2) + Math.Pow((coordinateB[2] - coordinateA[2]), 2));

Convert.ToInt64(Math.Round(result));
System.Console.WriteLine(result);