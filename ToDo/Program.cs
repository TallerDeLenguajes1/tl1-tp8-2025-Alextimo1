// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using Estructuras;
List<Tarea> tareasPendientes = new List<Tarea>();
List<Tarea> tareasRealizadas = new List<Tarea>();
int ingresoTareas()
{
    int cantidadTareas;
    do
    {
        Console.WriteLine("Ingrese el numero de tareas a realizar: ");
    } while (!int.TryParse(Console.ReadLine(), out cantidadTareas));
    return cantidadTareas;
}

void moverTareas(List<Tarea> tareasPendientes, List<Tarea> tareasCompletadas)
{
    int operacion;
    bool operacionS; 
    do
    {
        Console.WriteLine("Escriba la ID de la tarea (Escriba 0 para salir)");
        operacionS = int.TryParse(Console.ReadLine(), out operacion);
        if (operacion > 0)
        {
            while(operacion > tareasPendientes.Count){}
            tareasCompletadas.Add(tareasPendientes[operacion - 1]);
            tareasPendientes.Remove(tareasPendientes[operacion - 1]);
        }
    } while (operacion > 0);
}

void mostrarLista(List<Tarea> Lista)
{
    foreach (var tarea in Lista)
    {
        mostrarTarea(tarea);
    }

}

void mostrarTarea(Tarea tarea)
{
    Console.WriteLine($"\nID: {tarea.TareaID} \nDescripción: {tarea.Descripcion} \nDuracion: {tarea.Duracion} hs");
}

int buscarTarea(List<Tarea> Lista)
{
    int encontrar;
    Console.WriteLine("Escriba una palabra clave para buscar una tarea: ");
    string buscado = Console.ReadLine();
    foreach (var tarea in Lista)
    {
        if (tarea.Descripcion.Contains(buscado))
        {
            encontrar = tarea.TareaID;
            return encontrar;
        }
    }
    Console.WriteLine("No se encontró una tarea con esa palabra clave");
    return -1;
}

int cantidadTareas, operacion;
bool operacionString;
cantidadTareas = ingresoTareas();
Random random = new Random();
for (int i = 0; i < cantidadTareas; i++)
{
    tareasPendientes.Add(new Tarea(Tarea.randomDesc(), random.Next(10, 100)));
}

do
{
    Console.WriteLine("Ingrese la operacion que desea realizar: ");
    Console.WriteLine(" 1. Mover tareas pendientes a realizadas. ");
    Console.WriteLine(" 2. Mostrar tareas. ");
    Console.WriteLine(" 3. Buscar tareas pendientes por descripción. ");
    Console.WriteLine(" 4. Salir. ");
    operacionString = int.TryParse(Console.ReadLine(), out operacion);
    switch (operacion)
    {
    case 1:
        moverTareas(tareasPendientes, tareasRealizadas);
        break;
    case 2:
        Console.WriteLine(" ############################### TAREAS PENDIENTES ############################### ");
        mostrarLista(tareasPendientes);
        Console.WriteLine(" ############################### TAREAS REALIZADAS ############################### ");
        mostrarLista(tareasRealizadas);
        Console.WriteLine(" ############################################################## ");
        break;
    case 3:
        int encontrar = buscarTarea(tareasPendientes);
        if (encontrar >= 0)
        {
            mostrarTarea(tareasPendientes[encontrar - 1]);
        }
        break;
    case 4:
        break;
    }
} while (operacion != 4);


// profe note un inconveniente nose si en mi forma de resolver o es normal pero cuando quiero pasar todas las tareas de pendientes a realizadas de una explota jaja


