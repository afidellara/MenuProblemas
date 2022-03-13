using System;

namespace MenuProblemas
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion = "S";
            while (opcion.Equals('S'))
            {
                switch (Menu())
                {
                    case 1:
                        Logica.Calculos menuBasico = new Logica.Calculos();
                        switch (MenuBasico())
                        {
                            case 1:
                                Console.WriteLine(menuBasico.sumar());
                                Console.ReadKey();
                                break;
                        }
                        break;
                    case 2:
                        switch (MenuIntermedio())
                        {
                            case 1:

                                break;
                        }
                        break;
                    case 3:
                        switch (MenuaAvanzados())
                        {
                            case 1:

                                break;
                        }
                        break;
                }
            }
        }

        //MENU 
        private static int Menu()
        {
            Console.WriteLine("M E N U   P R I N C I P A L");
            Console.WriteLine("1. PROBLEMAS BASICOS");
            Console.WriteLine("2. PROBLEMAS INTERMEDIOS");
            Console.WriteLine("3. PROBLEMAS AVANZADOS");
            Console.Write("Seleccione: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        //SUB MENU
        private static int MenuBasico()
        {
            Console.WriteLine("PROBLEMAS BASICOS");
            Console.WriteLine("1. SUMA");
            Console.WriteLine("2. RESTA");
            Console.WriteLine("3. MULTIPLICACION");
            Console.WriteLine("4. DIVISION");
            Console.WriteLine("5. MODULADOR");
            Console.Write("Seleccione: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        private static int MenuIntermedio()
        {
            Console.WriteLine("PROBLEMAS INTERMEDIOS");
            Console.WriteLine("1. NUMERO MAYOR");
            Console.WriteLine("2. MOSTRAR LOS NUMEROS DEL 1 AL 100");
            Console.WriteLine("3. MOSTRAR LOS NUMEROS PARES DEL 1 AL 100");
            Console.WriteLine("4. CALCULAR PROMEDIO DE 3 NOTAS");
            Console.WriteLine("5. CONSULTAR EL ESTADO DE UNA MATERIA");
            Console.Write("Seleccione: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        private static int MenuaAvanzados()
        {
            Console.WriteLine("PROBLEMAS INTERMEDIOS");
            Console.WriteLine("1. ECUACION GENERAL");
            Console.WriteLine("2. NUMEROS PRIMOS DEL 1 AL 100");
            Console.WriteLine("3. CALCULAR TIEMPO DE UN VEHICULO");
            Console.WriteLine("4. CALCULAR VELOCIDAD DE UN VEHICULO");
            Console.WriteLine("5. CALCULAR DISTANCIA DE UN VEHICULO");
            Console.Write("Seleccione: ");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
