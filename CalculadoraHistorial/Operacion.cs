namespace EspacioOperaciones
{
    public class Operacion
    {
        private double resultadoAnterior;
        private double nuevoValor;
        private TipoOperacion operacion;

        public Operacion(double resultadoAnterior ,double nuevoValor, int operacion)
        {
            this.resultadoAnterior = resultadoAnterior;
            this.nuevoValor = nuevoValor;
            this.operacion = (TipoOperacion)operacion;
        }

        public double Resultado()
        {
            double salida = 0; 
            switch (operacion)
            {
                case TipoOperacion.Suma:
                   salida= (nuevoValor - resultadoAnterior);
                break; 
            }

            return salida;
        }

        public double NuevoValor{
            get => nuevoValor;
        }


    }


    public enum TipoOperacion
    {
        Suma,
        Resta,
        Multiplicacion,
        Division,
        Limpiar
    }
}