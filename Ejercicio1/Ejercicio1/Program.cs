using System;
using System.Threading;

class ProbadorSubprocesos
{
    static void Main(string[] args)
    {
        ImpresoraMensajes impresora1 = new ImpresoraMensajes();
        Thread subproceso1 = new Thread(new ThreadStart(impresora1.Imprimir));
        subproceso1.Name = "subproceso1";  

        ImpresoraMensajes impresora2 = new ImpresoraMensajes();
        Thread subproceso2 = new Thread(new ThreadStart(impresora2.Imprimir));
        subproceso2.Name = "subproceso2";

        ImpresoraMensajes impresora3 = new ImpresoraMensajes();
        Thread subproceso3 = new Thread(new ThreadStart(impresora3.Imprimir));
        subproceso3.Name = "subproceso3";

        Console.WriteLine("Iniciando subprocesos");

        subproceso1.Start();
        subproceso2.Start();
        subproceso3.Start();

        Console.WriteLine("Subprecesos iniciados\n");
    }
}

 class ImpresoraMensajes
{
    private int tiempoInactividad;
    private static Random aleatorio = new Random();

    public ImpresoraMensajes()
    {
        tiempoInactividad = aleatorio.Next(5001);
    }

    public void Imprimir()
    {
        Thread actual = Thread.CurrentThread;
        Console.WriteLine("{0} Va estar inactivo duramte {1} milisegundo", actual.Name, tiempoInactividad);

        Thread.Sleep(tiempoInactividad);

        Console.WriteLine("{0} dejo de estar inactivo", actual.Name);
    }
}