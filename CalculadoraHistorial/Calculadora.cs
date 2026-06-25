namespace EspacioCalculadora
{
    public class Calculadora
    {
        private double dato;

        public void Sumar (double termino)
        {
            dato = dato + termino;
        }

        public void Restar(double termino)
        {
            dato = dato - termino;
        }

        public void Multiplicar(double termino)
        {
            dato = dato * termino; 
        }

        public void Dividir(double termino)
        {
            if (termino != 0)
            {
                dato = dato / termino;
            }
        }

        public void Limpiar() //funcionando
        {
            dato = 0 ;
        }
        public Calculadora()
        {
            dato = 0 ;
        }

        public double Resultado //fumcionando
        {
            get => dato;
        }

    }

}