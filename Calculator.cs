using System;

class Calculator {

    static double [] Valores = new double [2];
    static double [] ValoresUI = new double [2];
    static double Resultado;
    static char Calculo;
    static bool EntradaInvalida = false;

    static void Main () {

        int a = 0;

        while (a < 1) {
            
            Console.Clear ();

            Console.WriteLine ("Digite os valores da operação separadamente:");

            for(int i = 0; i < Valores.Length; i++) {

                Valores [i] = int.Parse (Console.ReadLine ());
                ValoresUI [i] = Valores [i];

            }

            Console.WriteLine ("Digite a operação desejada (+, -, * ou /):");

            Calculo = Char.Parse (Console.ReadLine ());

            Console.Clear ();

            switch (Calculo)
            {
                case '+' :
                    Resultado = Valores [0] += Valores [1];
                    break;
                case '-' :
                    Resultado = Valores [0] -= Valores [1];
                    break;
                case '*' :
                    Resultado = Valores [0] *= Valores [1];
                    break;
                case '/' :
                    Resultado = Valores [0] /= Valores [1];
                    break;
                default:
                    EntradaInvalida = true;
                    break;
            }

            if (EntradaInvalida == true) {

                Console.WriteLine ("Operação inválida, certifique-se que digitou corretamente ou se não digitou uma operação não suportada e tente novemente\nAperte qualquer tecla para executar uma nova operação...");
                Console.ReadLine ();
                EntradaInvalida = false;

            }else{

                Console.Write ("Resultado da operação:\n   {0}\n {1} {2}\n = {3}\n",ValoresUI [0], Calculo, ValoresUI [1], Resultado);

            }

            Console.WriteLine ("\t\t\tCalculadora programada em C# no modelo CMD por Rodrigo\nAperte qualquer tecla para executar uma nova operação...");
            Console.ReadLine ();

        }
    }
}