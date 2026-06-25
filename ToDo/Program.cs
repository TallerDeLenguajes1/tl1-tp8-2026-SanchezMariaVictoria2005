using espacioTareas;
Console.WriteLine("Hello, World!");

List<Tarea> TareasPendientes = new List<Tarea>();
List<Tarea> TareasRealizadas = new List<Tarea>();
TareasPendientes.Add(new (1, "lavar", 10));
TareasPendientes.Add(new (2, "borrar", 12));
TareasPendientes.Add(new (3, "limpiar", 14));

string opcionCadena ;
int opcion = 0 ;
string idCadena ;
int id = 0;
string descripcion  ;
string duracionCadena ;
int duracion = 0;

do
{
    Console.WriteLine("elija una opcion");
    Console.WriteLine("1-Agregar tarea"); //PRIMER COMMIT 
    Console.WriteLine("2- Mover tarea de lista pendiente a realizada"); //SEGUNDO COMMIT 
    Console.WriteLine("3-Encontrar tarea por descripcion"); //TERCER COMMIT
    Console.WriteLine("4-Listar lista de tareas pendientes y realizadas");
    opcionCadena = Console.ReadLine(); 
    
    if(int.TryParse(opcionCadena, out opcion)){
        if (opcion == 1)
        {
            //INGRESAR LOS DATOS DE LA TAREA
            Console.WriteLine("ingresar los datos de la tarea");
            Console.WriteLine("ingresar el id");
            idCadena = Console.ReadLine();
            if (int.TryParse(idCadena, out id))
            {
                Console.WriteLine("ingresar descripcion");
                descripcion = Console.ReadLine();
                Console.WriteLine("ingrese la duracion");
                duracionCadena = Console.ReadLine();
                if (int.TryParse(duracionCadena, out duracion) && 10 <= duracion && duracion <= 100 )
                {
                    Tarea tarea = new Tarea(id, descripcion, duracion);
                    TareasPendientes.Add(tarea);

                    //OTRA FORMA
                    //TareasPendientes.Add(new Tarea(id, descripcion, duracion));
                }
                else
                {
                    Console.WriteLine("la duracion no es un numero");
                }
            }
            else
            {
                Console.WriteLine("el id no es un numero");
            }

            //AGREGO LOS DATOS A LA LISTA TAREAS PENDIENTES
        }else if (opcion == 2)
        {
            Console.WriteLine("ingresar el id de la tarea");
            idCadena = Console.ReadLine();      
            if (int.TryParse(idCadena , out id))
            {
                var tarea = TareasPendientes.FirstOrDefault(tarea => tarea.TareaID == id);
                //Tarea tarea = TareasPendientes.Fir;
                if (tarea!=null)//COMPRUEBO SI EL ID EXISTE
                {
                    TareasRealizadas.Add(tarea);
                }
                else
                {
                    Console.WriteLine("la tarea que busca no existe");
                }
            }
            else
            {
                Console.WriteLine("el id no es un numero");
            }
        }else if (opcion == 3)
        {
            Console.WriteLine("ingrese una descripcion");
            string descripcionIngresada = Console.ReadLine();
            var tarea = TareasPendientes.FirstOrDefault(tarea => tarea.Descripcion == descripcionIngresada);
            if (tarea!=null)
            {
                Console.WriteLine($"id:{tarea.TareaID}");
                Console.WriteLine($"descripcion:{tarea.Descripcion}");
                Console.WriteLine($"duracion:{tarea.Duracion}");
            }
            else
            {
                Console.WriteLine("la descripcion ingresada no coincide con ninguna tarea");
            }
        }else if (opcion == 4)
        {
            Console.WriteLine("listado de lista de tareas pendientes");
            foreach (var tarea in TareasPendientes)
            {
                Console.WriteLine($"id:{tarea.TareaID}");
                Console.WriteLine($"descripcion:{tarea.Descripcion}");
                Console.WriteLine($"duracion:{tarea.Duracion}");
            }
            Console.WriteLine("listado de lista de tareas realizadas");
            
            if (TareasRealizadas!=null)
            {
                foreach (var tarea in TareasRealizadas)
                {
                    Console.WriteLine($"id:{tarea.TareaID}");
                    Console.WriteLine($"descripcion:{tarea.Descripcion}");
                    Console.WriteLine($"duracion:{tarea.Duracion}");
                }
            }
            
        }
    }

}while(opcion != 0);

