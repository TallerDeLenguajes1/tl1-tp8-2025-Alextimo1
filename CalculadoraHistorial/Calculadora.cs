namespace espacioCalculadora
{
    public class Calculadora
    {
        private double dato;
        private List<Operacion> operaciones;

        public double Resultado
        {
            get => dato;
        }
        public void Sumar(double termino)
        {

            operaciones.Add(new Operacion
            {
                Resultado = dato,
                NuevoValor = termino,
                OperacionGetSet = TipoOperacion.Suma,
            });
            dato = dato + termino;
        }
        public void Restar(double termino)
        {
            operaciones.Add(new Operacion
            {
                Resultado = dato,
                NuevoValor = termino,
                OperacionGetSet = TipoOperacion.Resta,
            });
            dato = dato - termino;
        }
        public void Multiplicar(double termino)
        {
            operaciones.Add(new Operacion
            {
                Resultado = dato,
                NuevoValor = termino,
                OperacionGetSet = TipoOperacion.Multiplicacion,
            });
            dato = dato * termino;
        }
        public void Dividir(double termino)
        {
            operaciones.Add(new Operacion
            {
                Resultado = dato,
                NuevoValor = termino,
                OperacionGetSet = TipoOperacion.Division,
            });
            dato = dato / termino;
        }
        public void Limpiar()
        {
            operaciones.Add(new Operacion
            {
                Resultado = dato,
                NuevoValor = 0,
                OperacionGetSet = TipoOperacion.Limpiar,
            });
            dato = 0;
        }

        public Calculadora()
        {
            dato = 0;
            operaciones = [];
        }
        public void MostrarHistorial()
        {
            Console.WriteLine("\n**** HISTORIAL DE OPERACIONES ****");

            if (operaciones.Count == 0)
            {
                Console.WriteLine("No hay operaciones registradas.");
                return;
            }

            foreach (var op in operaciones)
            {
                string simbolo = op.OperacionGetSet switch
                {
                    TipoOperacion.Suma => "+",
                    TipoOperacion.Resta => "-",
                    TipoOperacion.Multiplicacion => "*",
                    TipoOperacion.Division => "/",
                    TipoOperacion.Limpiar => "LIMPIAR",
                    _ => "?",
                };
                if (op.OperacionGetSet == TipoOperacion.Limpiar)
                {
                    Console.WriteLine($"[ LIMPIAR ] Resultado antes de limpiar: {op.Resultado}");
                }
                else
                {
                    Console.WriteLine($"{op.Resultado} {simbolo} {op.NuevoValor} = {CalcularResultado(op)}");
                }
            }
        }

        private double CalcularResultado(Operacion op)
        {
            return op.OperacionGetSet switch
            {
                TipoOperacion.Suma => op.Resultado + op.NuevoValor,
                TipoOperacion.Resta => op.Resultado - op.NuevoValor,
                TipoOperacion.Multiplicacion => op.Resultado * op.NuevoValor,
                TipoOperacion.Division => op.Resultado / op.NuevoValor,
                _ => 0
            };
        }
    }

    public class Operacion
    {
        private double resultadoAnterior;   // Almacena el resultado previo al cálculo actual
        private double nuevoValor;          // El valor con el que se opera sobre el resultadoAnterior 
        private TipoOperacion operacion;    // El tipo de operación realizada 
        public double Resultado { get => resultadoAnterior; set => resultadoAnterior = value; } /* Lógica para calcular o devolver el resultado */
        // Propiedad pública para acceder al nuevo valor utilizado en la operación 
        public double NuevoValor { get => nuevoValor; set => nuevoValor = value; }
        public TipoOperacion OperacionGetSet { get => operacion; set => operacion = value; }
        // Constructor u otros métodos necesarios para inicializar y gestionar la operación 
        // ... 
    } 
    public enum TipoOperacion
    {
    Suma,
    Resta,
    Multiplicacion,
    Division,
    Limpiar                          // Representa la acción de borrar el resultado actual o el historial 
    } 
}