namespace YeetAnotherTest
{
    class Obrero
    {
        public string MatriTrabajador { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public decimal Salario { get; set; }

        public Obrero (string MatTrabajador)
        {
            MatriTrabajador = MatTrabajador;
        }

        public Obrero(string MatTrabajador, string Nom) :this (MatTrabajador)
        {
            Nombre = Nom;
        }
        
        public Obrero(string MatTrabajador, string Nom, string Apel) :this (MatTrabajador, Nom)
        {
            Apellido = Apel;
        }
        public Obrero(string MatTrabajador, string Nom, string Apel, decimal Sala) : this (MatTrabajador, Nom, Apel)
        {
            Salario = Sala;
        }
        
        //Constructor Vacio
        public Obrero() { }
    }
}