using System;
using System.Collections.Generic;
using System.Text;

namespace MenuProblemas.Logica
{
    class Calculos
    {
        //EJERCICIOS BASICOS 

        private void numeros(int num1, int num2)
        {
            Console.WriteLine("Digite un numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite un numero");
            num2 = Convert.ToInt32(Console.ReadLine());
        }

        int num1, num2;
        public int sumar()
        {
            numeros(num1, num2);
            return num1 + num2;
        }

        public int restar(int num1, int num2)
        {
            numeros(num1, num2);
            return num1 - num2;
        }

        public double multiplicacion(int num1, int num2)
        {
            numeros(num1, num2);
            return num1 * num2;
        }

        public int division(int num1, int num2)
        {
            numeros(num1, num2);
            return num1 / num2;
        }

        public int modulador(int num1, int num2)
        {
            numeros(num1, num2);
            return num1 % num2;
        }
    }
}
