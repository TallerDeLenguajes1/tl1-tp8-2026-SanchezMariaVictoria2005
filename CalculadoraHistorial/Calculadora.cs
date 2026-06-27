using EspacioOperaciones;
namespace EspacioCalculadora
{
    public class Calculadora
    {
        private double dato;
        private List<Operacion> listaOperacion ;
        public void Sumar (double termino)
        {
            Operacion nuevaOperacion = new Operacion(dato, dato+termino, 1);
            dato = dato + termino;
            listaOperacion.Add(nuevaOperacion);
        }

        public void Restar(double termino)
        {
            Operacion nuevaOperacion = new Operacion(dato, dato-termino, 2);
            dato = dato - termino;
            listaOperacion.Add(nuevaOperacion);
        }

        public void Multiplicar(double termino)
        {
            Operacion nuevaOperacion = new Operacion(dato, dato*termino,3);
            dato = dato * termino; 
            listaOperacion.Add(nuevaOperacion);
        }

        public void Dividir(double termino)
        {
            if (termino != 0)
            {
                Operacion nuevaOperacion = new Operacion(dato, dato / termino, 4);
                dato = dato / termino;
                listaOperacion.Add(nuevaOperacion);
            }
        }

        public void Limpiar() //funcionando
        {
            dato = 0 ;
        }
        public Calculadora()
        {
            dato = 0 ;
            listaOperacion = new List<Operacion>();
        }

        public double Resultado //fumcionando
        {
            get => dato;
        }

    }

}