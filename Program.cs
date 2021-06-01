using System;

namespace d
{
    class Program
    {
        static void Main(string[] args)
        {
            int op,a,di,oo,eg,go,g,ff,q,p,tt,qq,zx;
            try
            {
                do
                {
                    //Console.BackgroundColor = ConsoleColor.Blue;

                    Console.WriteLine("dame un numero");
                    int o = int.Parse(Console.ReadLine());

                    switch (o)
                    {
                        case 1:
                            do
                            {
                                string[] n = new string[100];

                                Console.WriteLine("dame tu nombre:  ");
                                string nom = Console.ReadLine();

                                for (int i = 0; i < 10; i++)
                                {
                                    n[i] = nom;
                                    //                                Console.BackgroundColor = ConsoleColor.Green;
                                    Console.WriteLine("tus nombres son:          " + nom);
                                }
                                Console.WriteLine("quieres repetir el numero 1");
                                a = int.Parse(Console.ReadLine());

                            } while (a == 1);
                            break;
                        case 2:
                            Console.BackgroundColor = ConsoleColor.Blue;

                            do
                            {
                                int z, b, c, s = 0;

                                Console.WriteLine("dame un numero de dos sifras:  ");
                                int d = int.Parse(Console.ReadLine());

                                z = d / 10;
                                c = d % 10;
                                b = c * 10;
                                s = b + z;

                                Console.WriteLine("tu numero ahora es:  " + s);

                                Console.WriteLine("quieres repetir (1.si,otro numero no)");
                                di = int.Parse(Console.ReadLine());

                            } while (di == 1);
                            break;
                        case 3:
                            do
                            {
                                Console.BackgroundColor = ConsoleColor.Blue;

                                Console.WriteLine("dame uuna letrs");

                                string j = Console.ReadLine();

                                int[] x = new int[100];
                                x[1] = 9;

                                Console.WriteLine("tu arreglo es" + x[1]);
                                /* x[2] = 7;
                                 x[3] = 9;
                                 x[4] = 4;
                                x[5] = 3;
                             
                                for (int i = 10; i > x[1]; i++)
                                {
                                    Console.WriteLine("bien");
                                }
                                */
                                Console.WriteLine("quieres repetir(1.si, no otro numero)");
                                eg = int.Parse(Console.ReadLine());

                            } while (eg == 1);
                            break;

                        case 4:
                            do
                            {
                                //Console.BackgroundColor = ConsoleColor.Gray;
                                Console.WriteLine("hol");
                                Console.WriteLine("quieres repetir numero 4 (1.si)");
                                a = int.Parse(Console.ReadLine());

                            } while (a == 1);
                            break;

                        case 5:

                            int sum;

                            Console.WriteLine("dame un numero:  ");
                            int num1 = int.Parse(Console.ReadLine());

                            Console.WriteLine("dame otro numero:  ");
                            int num2 = int.Parse(Console.ReadLine());

                            sum = num1 + num2;

                            Console.WriteLine("tu suma es:   " + sum);

                            break;

                        case 6:

                            for (int i = 0; i <= 500; i++)
                            {
                                Console.WriteLine("diego");
                            }
                            break;

                        case 10:
                            do
                            {

                                const double pi = 3.1416;
                                double r, ñ;

                                Console.WriteLine("dame un numero:");
                                r = double.Parse(Console.ReadLine());

                                ñ = pi * Math.Pow(r, 2);

                                Console.WriteLine("tu raio es:   " + ñ);

                                Console.WriteLine("quieres repetir (1.si, no otro numero)");
                                go = int.Parse(Console.ReadLine());
                            } while (go == 1);
                            break;

                        case 11:
                            do
                            {

                                Console.WriteLine("quieres repetir(1.si,no otro numero)");
                                q = int.Parse(Console.ReadLine());

                            } while (q == 1);
                            break;

                        case 12:

                            do
                            {


                                Console.BackgroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("tienes virus");
                                string v = Console.ReadLine();

                                if (v == "no")
                                {

                                    Console.WriteLine("eres de tercera edad ");
                                    string s = Console.ReadLine();

                                    if (s == "si")
                                    {
                                        Console.WriteLine("cuidate ");
                                    }

                                    else
                                    {
                                        Console.WriteLine("cuidate algo");
                                    }



                                }

                                else
                                {
                                    Console.WriteLine("estas muerto");
                                }
                                Console.WriteLine("quieres repetir (1.si, no.otro numero )");
                                zx = int.Parse(Console.ReadLine());
                            } while (zx == 1);
                            break;

                        case 13:
                            do
                            {
                                Console.WriteLine("dame un numero que coresponda al dia de la 1-7");
                                int d = int.Parse(Console.ReadLine());

                                switch (d)
                                {

                                    case 1:
                                        Console.WriteLine("es lunes");
                                        break;

                                    case 2:
                                        Console.WriteLine("es martes");
                                        break;
                                    case 3:
                                        Console.WriteLine("es miercoles");
                                        break;
                                    case 4:
                                        Console.WriteLine("es jueves");
                                        break;
                                    case 5:
                                        Console.WriteLine("es viernes");
                                        break;
                                    case 6:
                                        Console.WriteLine("es sabado");
                                        break;

                                    case 7:
                                        Console.WriteLine("es domingo");
                                        break;
                                }

                                Console.WriteLine("quieres repetir (1.si, no otro numero )");
                                ff = int.Parse(Console.ReadLine());
                            } while (ff == 1);
                            break;

                        case 14:

                            int F = 0;
                            int C = 0;
                            int N = 0;
                            int MAY = 0;
                            int MEN = 0;
                            string linea;
                            // INGRESO
                            // PARA COMODIDAD GENERAMOS VALORES PARA LA MATRIZ
                            Console.Write("TAMAÑO DE LA MATRIZ:");
                            Random rnd = new Random();
                            linea = Console.ReadLine();
                            N = int.Parse(linea);
                            int[,] MAT = new int[N + 1, N + 1];
                            for (F = 1; F <= N; F++)
                            {
                                for (C = 1; C <= N; C++)
                                {
                                    MAT[F, C] = rnd.Next(0, 99);
                                    Console.SetCursorPosition(C * 4, F + 1);
                                    Console.Write(MAT[F, C]);
                                }
                            }
                            // PROCESO

                            MAY = MAT[1, 1];
                            MEN = MAT[1, 1];
                            for (F = 1; F <= N; F++)
                            {
                                for (C = 1; C <= N; C++)
                                {
                                    if ((MAT[F, C] > MAY))
                                        MAY = MAT[F, C];
                                    if ((MAT[F, C] < MEN))
                                        MEN = MAT[F, C];
                                }
                            }
                            // SALIDA
                            Console.WriteLine();
                            Console.WriteLine("NÚMERO MAYOR ES: " + MAY);
                            Console.WriteLine("NÚMERO MENOR ES: " + MEN);
                            Console.Write("Pulse una Tecla:");
                            Console.ReadLine();
                            break;

                        case 15:

                            int su, faltas;
                            do
                            {
                                Console.WriteLine("daame una calificacion");
                                int num = int.Parse(Console.ReadLine());

                                Console.WriteLine("dame una calificacion");
                                int nu1 = int.Parse(Console.ReadLine());

                                Console.WriteLine("dame una calificacion ");
                                int nu2 = int.Parse(Console.ReadLine());

                                su = (num + nu2 + nu1) / 3;

                                Console.WriteLine("daame las faltas");
                                int f = int.Parse(Console.ReadLine());

                                Console.WriteLine("dame faltas");
                                int f1 = int.Parse(Console.ReadLine());

                                Console.WriteLine("dame las faltas ");
                                int f2 = int.Parse(Console.ReadLine());

                                faltas = f + f1 + f2;

                                if (su >= 7 && faltas < 3)
                                {
                                    Console.BackgroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("APROBADO");

                                }
                                else
                                {
                                    Console.BackgroundColor = ConsoleColor.Red;
                                    Console.WriteLine("REPROBADO");
                                 }

                                Console.WriteLine("tus calificacion es:   " + su);
                                Console.WriteLine("tus faltas son:      " + faltas);



                                Console.BackgroundColor = ConsoleColor.Blue;
                                Console.WriteLine("quieres repetir (1.si, no otro numero)");
                                oo = int.Parse(Console.ReadLine());

                            } while (oo == 1);
                            break;

                        case 16:
                            do {

                                
                                int[] n = new int[10];

                                for (int i = 0 ;i < 10 ; i++)
                                {
                                    Console.BackgroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("dame los arreglos ");
                                   n[i] = int.Parse(Console.ReadLine());

                                }
                                
                                for (int x = 0;x < 10;x++ )
                                {
                                    Console.BackgroundColor = ConsoleColor.Red;
                                    Console.WriteLine(n[x]);
                                }
                                Console.WriteLine("quieres repetir el programa (1.si, no otor numero)");
                                g = int.Parse(Console.ReadLine());
                            }while(g == 1);
                            break;


                        case 17:

                            do
                            {
                                int s = 0, fila = 0, columna = 0;
                                int[,] n = new int[4, 4];


                                for (fila = 0; fila < 2; fila++)
                                {
                                    for (columna = 0; columna < 2; columna++)
                                    {
                                        Console.WriteLine(      "dame los arreglos");
                                        n[fila, columna] = int.Parse(Console.ReadLine());

                                        

                                        
                                    }


                                }
                               




                                Console.Clear();
                                
                                //for (fila = 0; fila < 2; fila++)
                                {
                                    for (columna = 0; columna < 2; columna++)
                                    {


                                        Console.Write("" + n[fila,columna]);

                                        s = n[fila, columna] + n[fila, columna];
                                        Console.WriteLine("   " + s);

                                    }

                                    Console.WriteLine(      );
                                }
                                
                                


                                Console.WriteLine("quieres repetir(1.si, no otro numero)");
                                 p = int.Parse(Console.ReadLine());

                            } while (p == 1);
                            break;

                        case 18:
                            do {

                                string [,] n = new string[4,4];

                                
                                for (int f = 0; f < 2;f++)
                                {
                                    for (int c = 0; c < 2; c++)
                                    {
                                        Console.WriteLine("dame los arreglos (nombres o letras)");
                                        string nom = Console.ReadLine();

                                        n[f, c] = nom;

                                     
                                    }
                                
                                }

                                Console.Clear();

                                for (int f = 0;f < 2;f++)
                                {
                                    for (int c = 0;c < 2;c++)
                                    {
                                        Console.Write("     " + n[f,c]);
                                    }

                                    Console.WriteLine(      );

                                
                                }
                                Console.WriteLine("quieres repetir(1.si,NonSerializedAttribute dame otro numero)");
                                tt = int.Parse(Console.ReadLine());
                            } while (tt == 1);


                            break;



                        case 19:

                            int rango,mul, e;

                            Console.Write("dame un rango");
                            rango = int.Parse(Console.ReadLine());

                            Console.WriteLine("dame un numero para multiplicar");
                            e = int.Parse(Console.ReadLine());

                            for (int i = 0;i<rango;i++) 
                            {
                               
                                    mul = i * e;
                                    Console.WriteLine(i + " x " + rango + " = " + mul);

                                

                            }
                            break;

                        default:
                            Console.WriteLine("ERROR no diste ningun numero o un numero valido");

                            break;

                    }
                            //Console.BackgroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("quieres repetir(1.si,2.no)");
                            op = int.Parse(Console.ReadLine());

                    } while (op == 1) ;

                }
            catch(Exception ex)
                {
                Console.WriteLine("error:    " + ex.Message );
            }
            
            Console.ReadLine();
        }
    }
}
