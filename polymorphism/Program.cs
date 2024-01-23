namespace polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Polimorfismo == palavra grega que significa "tem várias formas";
            //  Objetos podem ser identificados por mais de um tipo;
            //  Ex: Cachorro também é: Animal, Organismo, Canino;
            //

            Bicicleta bicicleta = new Bicicleta();
            Barco barco = new Barco();
            Carro carro = new Carro();

            Veiculo[] veiculos = {carro, bicicleta,barco};

            foreach (Veiculo veiculo in veiculos)
            {
                veiculo.ir();
            }

            Console.ReadKey();
            Console.Beep();
        }
    }
    class Veiculo
    {
        public virtual void ir()
        {

        }
    }
    class Carro : Veiculo
    {
        public override void ir()
        {
            Console.WriteLine("O carro está em movimento");
        }
    }
    class Bicicleta : Veiculo
    {
        public override void ir()
        {
            Console.WriteLine("A bicicleta está em movimento");
        }
    }
    class Barco : Veiculo
    {
        public override void ir()
        {
            Console.WriteLine("O barco está em movimento");
        }
    }
}
