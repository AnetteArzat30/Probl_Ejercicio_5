
            Console.WriteLine("==================================================================");
            Console.WriteLine("EJERCICIO 5: Análisis de vibración de motores (Límite: 4.5 mm/s)");
            Console.WriteLine("==================================================================\n");

            int totalMotores = 0;
            int normales = 0;
            int mantenimiento = 0;
            string opcion = "S";

            // Ciclo while para iterar entre varios motores
            while (opcion.Equals("S", StringComparison.OrdinalIgnoreCase))
            {
                Console.Write("\nIngrese el nombre o identificador del motor: ");
                string nombreMotor = Console.ReadLine();

                double sumaVibracion = 0;
                const int MEDICIONES = 4;

                // Ciclo for para registrar 4 mediciones
                for (int i = 1; i <= MEDICIONES; i++)
                {
                    Console.Write($" Ingrese la medición de vibración #{i} (mm/s): ");
                    double vibracion = Convert.ToDouble(Console.ReadLine());
                    sumaVibracion += vibracion;
                }

                double promedio = sumaVibracion / MEDICIONES;
                totalMotores++;

                Console.WriteLine($"\n--- Estado del Motor: {nombreMotor} ---");
                Console.WriteLine($"Vibración promedio: {promedio:F2} mm/s");

                if (promedio <= 4.5)
                {
                    Console.WriteLine("Diagnóstico: FUNCIONAMIENTO NORMAL DEL MOTOR");
                    normales++;
                }
                else
                {
                    Console.WriteLine("Diagnóstico: EL MOTOR REQUIERE MANTENIMIENTO");
                    mantenimiento++;
                }

                Console.Write("\n¿Desea analizar otro motor? (S/N): ");
                opcion = Console.ReadLine();
            }

            // Resumen acumulado
            Console.WriteLine("\n================ INFORME GENERAL FINAL ================");
            Console.WriteLine($"Total de motores evaluados: {totalMotores}");
            Console.WriteLine($"Cantidad con funcionamiento normal: {normales}");
            Console.WriteLine($"Cantidad que requieren mantenimiento: {mantenimiento}");

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        