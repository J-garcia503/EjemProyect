namespace EjemProyect
{
    public class ServicesDemo
    {
        public int Contador {  get; set; }
        public ServicesDemo() 
        {
            Contador = 0;
            Console.WriteLine("Se creo un servicio DEMO");
        }
        public void ExecContador()
        {
            Contador++;
            Console.WriteLine($"Contador{ Contador}");
        }
    }
}
