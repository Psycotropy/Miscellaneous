using System;


namespace IngresosTarea
{
    class Program
    {
        static void Main(string[] args)
        {
            Datos ingresos = new Datos();
            string informacion = ingresos.GetInfoIngresos();
            string nombreBusq;
            string fecha;
            string Opcion;
            while (true)
            {
                Console.Write("¿Que va a ingresar nombre(1)/fecha(2): ");
            Opcion = Console.ReadLine();
           
                switch (Opcion)
                {
                    case "1":
                        Console.Write("Ingrese el nombre: ");
                        nombreBusq = Console.ReadLine() + ",";
                        HorasIngresos(informacion, nombreBusq, "");
                        break;
                    case "2":
                        Console.Write("Ingrese la fecha: ");
                        fecha = Console.ReadLine();
                        IngresosenDia(informacion, fecha);
                        break;
                    default:
                        Console.WriteLine("Ingrese un valor valido porfavor...");
                        break;

                }
            }
            
            
            
        }
           
        public static void HorasIngresos(string Ingresos, string nombre, string Fecha)
        {
            
            char[] delimitador = { ';'};
            char[] delimitador2 = { ',' };
            int nombreBusqLarg = nombre.Length +11;
            
            string[] ingresosSplit = Ingresos.Split(delimitador);

            if (Ingresos.Contains(nombre) == true)
            {
                for(int i = 0; i < ingresosSplit.Length; i++)
                {
                    string var = ingresosSplit[i]; 
                    
                    
                    
                    if (var.Contains(nombre) == true)
                    {
                        for (int x = 0; x < 1; x++)
                        {
                            string[] BusqFecha = var.Split(delimitador2);
                            
                            if (x % 3 == 0) Console.WriteLine(" La hora fue: {0}", var.Substring(nombreBusqLarg, 5), " ");
                        }

                    }

                }
            }
            else
            {
                Console.WriteLine("");
            }
           
        }
        public static void IngresosenDia(string Ingresos, string Fecha)
        {
            char[] delimitador = { ';' };
            char[] delimitador2 = { ',' };
            string[] ingresosSplit = Ingresos.Split(delimitador);
            

            if (Ingresos.Contains(Fecha) == true)
            {
                for (int i = 0; i < ingresosSplit.Length; i++)
                {
                    string var = ingresosSplit[i];
                    int nombreBusqLarg = var.Length - 17;
                    
                    if (var.Contains(Fecha) == true)
                    {
                        for (int x = 0; x < 1; x++)
                        {
                            string[] BusqNombre = var.Split(delimitador2);
                            
                            if (var.Contains(Fecha)) Console.WriteLine(" Ese dia ingreso: {0}", var.Substring(0, nombreBusqLarg), " ");
                        }

                    }
                }
            }
            else
            {
                Console.WriteLine("");
            }

        }
        
    }



        class Datos
        {
            private string ingresos;

            public Datos()
            {
                ingresos = "Juan Gallardo,2020-04-01,08:30;Ana Carmona,2020-04-02,08:35;Juan Gallardo,2020-04-01,10:15,";
            }
            public String GetInfoIngresos()
            {
                return ingresos;
            }



        }
    }


