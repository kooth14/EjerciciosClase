using System;
using System.Threading;

public class Productor
{
    private Bufer UbicacionCompartida;
    private Random tiempoInactividadAleatorio;

    public Productor (Bufer compartido, Random aleatorio)
    {
        UbicacionCompartida = compartido;
        tiempoInactividadAleatorio = aleatorio;
    }

    public void Producir()
    {
        for(int cuenta = 1; cuenta <= 10; cuenta++)
        {
            Thread.Sleep(tiempoInactividadAleatorio.Next(1, 3001));
        }

        Console.WriteLine("{0} termino de producir.\n Terminando {0}",
            Thread.CurrentThread.Name);
    }
}
