namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public Iphone(string numero, string modelo, string imei, int memoria): base(numero, modelo,imei, memoria)
        {
            //implementacao do construtor Iphone
        }
        public override void InstalarAplicativo(string nome)
        {
            System.Console.WriteLine($"Aplicativo {nome} instalado no Iphone");
        }
    }
}