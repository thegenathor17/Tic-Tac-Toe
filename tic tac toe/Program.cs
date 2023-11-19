namespace tic_tac_toe123
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte numeroParaElWhileGeneral = 1;
            while (numeroParaElWhileGeneral == 1)
            {
                string[,] ticTacToe = { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } };
                sbyte numeroParaElWhile = 1;
                while (numeroParaElWhile == 1)
                {
                    int numero = 1;
                    Console.Write($"{ticTacToe[0, 0]} ");
                    Console.Write($"{ticTacToe[0, 1]} ");
                    Console.WriteLine($"{ticTacToe[0, 2]} ");
                    Console.Write($"{ticTacToe[1, 0]} ");
                    Console.Write($"{ticTacToe[1, 1]} ");
                    Console.WriteLine($"{ticTacToe[1, 2]} ");
                    Console.Write($"{ticTacToe[2, 0]} ");
                    Console.Write($"{ticTacToe[2, 1]} ");
                    Console.WriteLine($"{ticTacToe[2, 2]} ");
                    sbyte numeroParaElWhileDeLosJugadores = 1;
                    while (numeroParaElWhileDeLosJugadores == 1)
                    {
                        Tuple<int, int> coordenadasJugador1 = Jugador1();
                        if (ticTacToe[coordenadasJugador1.Item1, coordenadasJugador1.Item2] != "X")
                        {
                            ticTacToe[coordenadasJugador1.Item1, coordenadasJugador1.Item2] = "O";
                            numeroParaElWhileDeLosJugadores++;
                        }
                        else
                        {
                            Console.WriteLine("No puedes poner tu O en la X del jugador 2");
                        }
                    }
                    //La X es la mejor
                    if (ticTacToe[0, 0] == "O" && ticTacToe[0, 1] == "O" && ticTacToe[0, 2] == "O")
                    {
                        Console.WriteLine("El jugador 1 ha ganado");
                        Console.WriteLine("Quieren empezar otro juego? 1. Si 2. No");
                        string siONoPendejo = Console.ReadLine();
                        if (siONoPendejo == "1")
                        {
                            numeroParaElWhile++;
                        }
                        else
                        {
                            numeroParaElWhile++;
                            numeroParaElWhileGeneral++;
                        }
                    }
                    else if (ticTacToe[1, 0] == "O" && ticTacToe[1, 1] == "O" && ticTacToe[1, 2] == "O")
                    {
                        Console.WriteLine("El jugador 1 ha ganado");
                        Console.WriteLine("Quieren empezar otro juego? 1. Si 2. No");
                        string siONoPendejo = Console.ReadLine();
                        if (siONoPendejo == "1")
                        {
                            numeroParaElWhile++;
                        }
                        else
                        {
                            numeroParaElWhile++;
                            numeroParaElWhileGeneral++;
                        }
                    }
                    else if (ticTacToe[2, 0] == "O" && ticTacToe[2, 1] == "O" && ticTacToe[2, 2] == "O")
                    {
                        Console.WriteLine("El jugador 1 ha ganado");
                        Console.WriteLine("Quieren empezar otro juego? 1. Si 2. No");
                        string siONoPendejo = Console.ReadLine();
                        if (siONoPendejo == "1")
                        {
                            numeroParaElWhile++;
                        }
                        else
                        {
                            numeroParaElWhile++;
                            numeroParaElWhileGeneral++;
                        }
                    }
                    else if (ticTacToe[0, 0] == "O" && ticTacToe[1, 0] == "O" && ticTacToe[2, 0] == "O")
                    {
                        Console.WriteLine("El jugador 1 ha ganado");
                        Console.WriteLine("Quieren empezar otro juego? 1. Si 2. No");
                        string siONoPendejo = Console.ReadLine();
                        if (siONoPendejo == "1")
                        {
                            numeroParaElWhile++;
                        }
                        else
                        {
                            numeroParaElWhile++;
                            numeroParaElWhileGeneral++;
                        }
                    }
                    else if (ticTacToe[1, 1] == "O" && ticTacToe[2, 1] == "O" && ticTacToe[0, 1] == "O")
                    {
                        Console.WriteLine("El jugador 1 ha ganado");
                        Console.WriteLine("Quieren empezar otro juego? 1. Si 2. No");
                        string siONoPendejo = Console.ReadLine();
                        if (siONoPendejo == "1")
                        {
                            numeroParaElWhile++;
                        }
                        else
                        {
                            numeroParaElWhile++;
                            numeroParaElWhileGeneral++;
                        }
                    }
                    else if (ticTacToe[2, 2] == "O" && ticTacToe[1, 2] == "O" && ticTacToe[0, 2] == "O")
                    {
                        Console.WriteLine("El jugador 1 ha ganado");
                        Console.WriteLine("Quieren empezar otro juego? 1. Si 2. No");
                        string siONoPendejo = Console.ReadLine();
                        if (siONoPendejo == "1")
                        {
                            numeroParaElWhile++;
                        }
                        else
                        {
                            numeroParaElWhile++;
                            numeroParaElWhileGeneral++;
                        }
                    }
                    else if (ticTacToe[0, 0] == "O" && ticTacToe[1, 1] == "O" && ticTacToe[2, 2] == "O")
                    {
                        Console.WriteLine("El jugador 1 ha ganado");
                        Console.WriteLine("Quieren empezar otro juego? 1. Si 2. No");
                        string siONoPendejo = Console.ReadLine();
                        if (siONoPendejo == "1")
                        {
                            numeroParaElWhile++;
                        }
                        else
                        {
                            numeroParaElWhile++;
                            numeroParaElWhileGeneral++;
                        }
                    }
                    else if (ticTacToe[0, 2] == "O" && ticTacToe[1, 1] == "O" && ticTacToe[2, 0] == "O")
                    {
                        Console.WriteLine("El jugador 1 ha ganado");
                        Console.WriteLine("Quieren empezar otro juego? 1. Si 2. No");
                        string siONoPendejo = Console.ReadLine();
                        if (siONoPendejo == "1")
                        {
                            numeroParaElWhile++;
                        }
                        else
                        {
                            numeroParaElWhile++;
                            numeroParaElWhileGeneral++;
                        }
                    }
                    Console.Write($"{ticTacToe[0, 0]} ");
                    Console.Write($"{ticTacToe[0, 1]} ");
                    Console.WriteLine($"{ticTacToe[0, 2]} ");
                    Console.Write($"{ticTacToe[1, 0]} ");
                    Console.Write($"{ticTacToe[1, 1]} ");
                    Console.WriteLine($"{ticTacToe[1, 2]} ");
                    Console.Write($"{ticTacToe[2, 0]} ");
                    Console.Write($"{ticTacToe[2, 1]} ");
                    Console.WriteLine($"{ticTacToe[2, 2]} ");
                    while (numeroParaElWhileDeLosJugadores == 2)
                    {
                        Tuple<int, int> coordenadasJugador1 = Jugador2();
                        if (ticTacToe[coordenadasJugador1.Item1, coordenadasJugador1.Item2] != "O")
                        {
                            ticTacToe[coordenadasJugador1.Item1, coordenadasJugador1.Item2] = "X";
                            numeroParaElWhileDeLosJugadores++;
                        }
                        else
                        {
                            Console.WriteLine("No puedes poner tu X en la O del jugador 1");
                        }
                    }
                    if (ticTacToe[0, 0] == "X" && ticTacToe[0, 1] == "X" && ticTacToe[0, 2] == "X")
                    {
                        Console.WriteLine("El jugador 2 ha ganado");
                        Console.WriteLine("Quieren empezar otro juego? 1. Si 2. No");
                        string siONoPendejo = Console.ReadLine();
                        if (siONoPendejo == "1")
                        {
                            numeroParaElWhile++;
                        }
                        else
                        {
                            numeroParaElWhile++;
                            numeroParaElWhileGeneral++;
                        }
                    }
                    else if (ticTacToe[1, 0] == "X" && ticTacToe[1, 1] == "X" && ticTacToe[1, 2] == "X")
                    {
                        Console.WriteLine("El jugador 2 ha ganado");
                        Console.WriteLine("Quieren empezar otro juego? 1. Si 2. No");
                        string siONoPendejo = Console.ReadLine();
                        if (siONoPendejo == "1")
                        {
                            numeroParaElWhile++;
                        }
                        else
                        {
                            numeroParaElWhile++;
                            numeroParaElWhileGeneral++;
                        }
                    }
                    else if (ticTacToe[2, 0] == "X" && ticTacToe[2, 1] == "X" && ticTacToe[2, 2] == "X")
                    {
                        Console.WriteLine("El jugador 2 ha ganado");
                        Console.WriteLine("Quieren empezar otro juego? 1. Si 2. No");
                        string siONoPendejo = Console.ReadLine();
                        if (siONoPendejo == "1")
                        {
                            numeroParaElWhile++;
                        }
                        else
                        {
                            numeroParaElWhile++;
                            numeroParaElWhileGeneral++;
                        }
                    }
                    else if (ticTacToe[0, 0] == "X" && ticTacToe[1, 0] == "X" && ticTacToe[2, 0] == "X")
                    {
                        Console.WriteLine("El jugador 2 ha ganado");
                        Console.WriteLine("Quieren empezar otro juego? 1. Si 2. No");
                        string siONoPendejo = Console.ReadLine();
                        if (siONoPendejo == "1")
                        {
                            numeroParaElWhile++;
                        }
                        else
                        {
                            numeroParaElWhile++;
                            numeroParaElWhileGeneral++;
                        }
                    }
                    else if (ticTacToe[1, 1] == "X" && ticTacToe[2, 1] == "X" && ticTacToe[0, 1] == "X")
                    {
                        Console.WriteLine("El jugador 2 ha ganado");
                        Console.WriteLine("Quieren empezar otro juego? 1. Si 2. No");
                        string siONoPendejo = Console.ReadLine();
                        if (siONoPendejo == "1")
                        {
                            numeroParaElWhile++;
                        }
                        else
                        {
                            numeroParaElWhile++;
                            numeroParaElWhileGeneral++;
                        }
                    }
                    else if (ticTacToe[2, 2] == "X" && ticTacToe[1, 2] == "X" && ticTacToe[0, 2] == "X")
                    {
                        Console.WriteLine("El jugador 2 ha ganado");
                        Console.WriteLine("Quieren empezar otro juego? 1. Si 2. No");
                        string siONoPendejo = Console.ReadLine();
                        if (siONoPendejo == "1")
                        {
                            numeroParaElWhile++;
                        }
                        else
                        {
                            numeroParaElWhile++;
                            numeroParaElWhileGeneral++;
                        }
                    }
                    else if (ticTacToe[0, 0] == "X" && ticTacToe[1, 1] == "X" && ticTacToe[2, 2] == "X")
                    {
                        Console.WriteLine("El jugador 2 ha ganado");
                        Console.WriteLine("Quieren empezar otro juego? 1. Si 2. No");
                        string siONoPendejo = Console.ReadLine();
                        if (siONoPendejo == "1")
                        {
                            numeroParaElWhile++;
                        }
                        else
                        {
                            numeroParaElWhile++;
                            numeroParaElWhileGeneral++;
                        }
                    }
                    else if (ticTacToe[0, 2] == "X" && ticTacToe[1, 1] == "X" && ticTacToe[2, 0] == "X")
                    {
                        Console.WriteLine("El jugador 2 ha ganado");
                        Console.WriteLine("Quieren empezar otro juego? 1. Si 2. No");
                        string siONoPendejo = Console.ReadLine();
                        if (siONoPendejo == "1")
                        {
                            numeroParaElWhile++;
                        }
                        else
                        {
                            numeroParaElWhile++;
                            numeroParaElWhileGeneral++;
                        }
                    }
                }
            }
        }
        static Tuple<int, int> Jugador1()
        {
            Console.WriteLine("Jugador 1, seleccione el numero de casilla en la que quiera poner su O");
            string respuesta = Console.ReadLine();
            switch (respuesta)
            { 
                case ("1"):
                    return Tuple.Create(0, 0);
                    break;
                case ("2"):
                    return Tuple.Create(0, 1);
                    break;
                case ("3"):
                    return Tuple.Create(0, 2);
                    break;
                case ("4"):
                    return Tuple.Create(1, 0);
                    break;
                case ("5"):
                    return Tuple.Create(1, 1);
                    break;
                case ("6"):
                    return Tuple.Create(1, 2);
                    break;
                case ("7"):
                    return Tuple.Create(2, 0);
                    break;
                case ("8"):
                    return Tuple.Create(2, 1);
                    break;
                case ("9"):
                    return Tuple.Create(2, 2);
                    break;
                default:
                    Console.WriteLine("Perdon pero has introducido un valor invalido");
                    return Jugador1();
                    break;
            }
        }
        static Tuple<int, int> Jugador2()
        {
            Console.WriteLine("Jugador 2, seleccione el numero de casilla en la que quiera poner su X");
            string respuesta = Console.ReadLine();
            switch (respuesta)
            {
                case ("1"):
                    return Tuple.Create(0, 0);
                    break;
                case ("2"):
                    return Tuple.Create(0, 1);
                    break;
                case ("3"):
                    return Tuple.Create(0, 2);
                    break;
                case ("4"):
                    return Tuple.Create(1, 0);
                    break;
                case ("5"):
                    return Tuple.Create(1, 1);
                    break;
                case ("6"):
                    return Tuple.Create(1, 2);
                    break;
                case ("7"):
                    return Tuple.Create(2, 0);
                    break;
                case ("8"):
                    return Tuple.Create(2, 1);
                    break;
                case ("9"):
                    return Tuple.Create(2, 2);
                    break;
                default:
                    Console.WriteLine("Perdon pero has introducido un valor invalido");
                    return Jugador2();
                    break;
            }
        }
    }
}
/* Mira wey
 * Primero contigo
 * No te vamos a firmar ahorita el convenio de conexion de plaza *inaudible*
 * ¿Si?
 * Porque están 
 * Cállate el hozico porque te pongo unos chingadazos, entonces no contestes asi pendejo para que se den cuenta tus abogados lo pendejo y lo puñetas que estas
 * ¿Okay?
 * Aquí no hay huevos
 * Los huevos estan de este lado
 * Entonces (Otra persona dice y los van a ver) nosotros no entendemos de manera legal lo que ustedes deman... (se interrumpe solo) tu demandas algo
 * Yo no goa contestar, esto se arregla de otra manera
 * Entonces, esto es un tema familiar
 * Porque nos robaron más de 70 millones de dólares, no se si el señor ya se los comentó, nos robó más (otra persona dice a su mamá) y a su mamá y a todos nos robó más de 70 millones de dólares ¿Okay?
 * Entonces, *Inaudible*, por muchas veces otra vez cabrón, NO te vamos a firmar hoy el convenio de conexión entre las plazas, está fuera del convenio de separación ¿Si o No?
 * *alguien dice algo inaudible*
 * (Otra persona grita ¡SI O NO PENDEJO! y el protagonista golpea la mesa mientras grita ¡SI O NO!)
 * (Empiezan a discutir)
 */ 