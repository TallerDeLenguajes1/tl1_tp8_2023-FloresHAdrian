namespace claseTarea;

public class Tarea{
    private int tareaID;
    private string descripcion;
    private int duracion;

    public int TareaId { get => tareaID; set => tareaID = value; }
    public string Descripcion { get => descripcion; set => descripcion = value; }
    public int Duracion { get => duracion; set => duracion = value; }

    
    public Tarea(int tareaID, string descripcion, int duracion){
        TareaId = tareaID;
        Descripcion = descripcion;
        Duracion = duracion;
    }

    public void mostrarTarea(){
        System.Console.WriteLine($"\nTareaId= {TareaId+1} \nDescripcion: {Descripcion}\nDuracion: {Duracion}");
    }

    public void mostrarTareas(){
        
    }
}