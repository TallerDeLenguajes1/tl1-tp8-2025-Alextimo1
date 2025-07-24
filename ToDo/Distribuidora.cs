namespace Estructuras
{
    public class Tarea
    {
        private int tareaID;
        private string descripcion;
        private int duracion;

        public int TareaID { get => tareaID; set => tareaID = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Duracion { get => duracion; set => duracion = value; }               // Validar que esté entre 10 y 100 
        static int contadorID = 1;                                                      // Puedes añadir un constructor y métodos auxiliares si lo consideras necesario
        public Tarea(string Descripcion, int Duracion)
        {
            TareaID = contadorID;
            contadorID++;
            this.Descripcion = Descripcion;
            this.Duracion = Duracion;
        }

        public static string randomDesc()
        {
            string descripcionRandom = "";
            Random random = new Random();
            switch (random.Next(0, 12))
            {
                case 0:
                    descripcionRandom = "Hacer control de caja";
                    break;
                case 1:
                    descripcionRandom = "Reponer stock faltante";
                    break;
                case 2:
                    descripcionRandom = "Revisar camara seguridad";
                    break;
                case 3:
                    descripcionRandom = "Limpiar pasillo";
                    break;
                case 4:
                    descripcionRandom = "Hablar con proveedores";
                    break;
                case 5:
                    descripcionRandom = "Subir publicidad a redes";
                    break;
                case 6:
                    descripcionRandom = "Rehacer inventario";
                    break;
                case 7:
                    descripcionRandom = "Subir precios finales";
                    break;
                case 8:
                    descripcionRandom = "Bajar precios finales";
                    break;
                case 9:
                    descripcionRandom = "Hacer ofertas";
                    break;
                case 10:
                    descripcionRandom = "Aumentar productos";
                    break;
                case 11:
                    descripcionRandom = "Liquidar productos";
                    break;
                case 12:
                    descripcionRandom = "Cerrar local y apagar equipos";
                    break;
            }
            return descripcionRandom;
        }
    }                                         
}
                                           
                                                


                                            