using claseTarea;
internal class Program
{
    private static void Main(string[] args)
    {
        List<Tarea> tareasPendientes = new List<Tarea>();
        List<Tarea> tareasRealizadas = new List<Tarea>();

        int op;
        int contId = 1; //Contador para el id
        do
        {
            Console.WriteLine();
            Console.WriteLine("\n\n<<<<<<<<<<<  MENU  >>>>>>>>>>\n");
            Console.WriteLine("Selecione una opcion:");
            Console.WriteLine("  1.Cargar Tarea");
            Console.WriteLine("  2.Mostrar Tareas");
            Console.WriteLine("  3.Modificar estado de tarea");
            Console.WriteLine("  4.Busqueda de Tareas Pendientes");
            Console.WriteLine("  0.Salir\n\n");
            int.TryParse(Console.ReadLine(), out op);
            // while (!int.TryParse(Console.ReadLine(),out op) || op < 0 || op > 5);
            if (op != 0)
            {
                switch (op)
                {
                    case 1:
                    int  op2;
                        Console.WriteLine("\n----Menu cargar de tareas----\n");
                        do
                        {
                            Console.WriteLine("Ingrese La Descripcion");
                            string descripcion = Console.ReadLine();
                            Console.WriteLine("Ingrese la duracionde la tarea");
                            int duracion;
                            int.TryParse(Console.ReadLine(), out duracion);
                            Tarea nuevaTarea = new Tarea(contId, descripcion, duracion);
                            contId++;
                            tareasPendientes.Add(nuevaTarea);
                            Console.WriteLine("\n<< ¿Desea ingresar otra tarea? >>");
                            Console.WriteLine("1.Si\n0.No\n");
                        } while (!int.TryParse(Console.ReadLine(), out op2) || op2!=0);
                        break;
                    case 2:
                        Console.WriteLine("----Tareas Pendientes----");
                        foreach (Tarea item in tareasPendientes)
                        {
                            item.mostrarTarea();
                        }
                        // mostrarTareas(tareasPendientes);
                        Console.WriteLine("\n<<<<<<  Tareas Realizadas  >>>>>>");
                        foreach (Tarea item in tareasRealizadas)
                        {
                            item.mostrarTarea();
                        }
                        break;

                    case 3:
                        Console.WriteLine("<<<<<<  Control de tareas  >>>>>>");
                        int op3;
                        for (int i = 0 ; i < tareasPendientes.Count; i++ ){
                            // Console.WriteLine("Tarea "+ i);
                            tareasPendientes[i].mostrarTarea();
                            Console.WriteLine("Esta la tarea realizada: [1]Si - [0]No");
                            int.TryParse(Console.ReadLine(),out op3);
                            if(op3==1){
                                tareasRealizadas.Add(tareasPendientes[i]);
                                tareasPendientes.RemoveAt(i);
                                i--;
                            }

                            
                        }
                        break;

                    case 4:
                        System.Console.WriteLine("<<<<<< Busqueda de Tareas Pendientes  >>>>>>");
                        string? busqueda = Console.ReadLine();
                        int flag=0;
                        foreach (var item in tareasPendientes)
                        {
                            if(item.Descripcion.Contains(busqueda)){
                                item.mostrarTarea();
                                flag=1;
                                break;
                            }
                        }
                        if(flag==0){
                            System.Console.WriteLine("***  No se encontro ninguna tarea con esa descripcion  ***");
                        }
                        break;

                    case 5: 
                        System.Console.WriteLine("<<<<<< Guardar horas trabajadas  >>>>>>");
                        string nombArchivo = "horasTrabajadas.txt";
                        int horas=0;
                        StreamWriter str =  new StreamWriter(nombArchivo, true); //Este constructor agrega al final en el archivo
                        foreach (var item in tareasRealizadas)
                        {
                            horas += item.Duracion;
                        }
                        str.WriteLine("Horas trabajadas: "+horas); 
                        str.Close();
                        str.Dispose();
                        break;    
                    case 0:
                        // Console.WriteLine("\n\n----ADIOS----\n\n");
                        break;
                    default:
                        // Console.WriteLine("\n---Opcion no valida---\n");
                        break;
                }

            }

        } while (op != 0);
    }
}

/*






*/