namespace MinimalAPI.Model
{
    public class PassageiroRequest
    {
        public PassageiroRequest()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string PrimeiroNome { get; set; }
        public string ultimoSobreNomeDoc { get; set; }
        public string Documento { get; set; }
        public string Datanascimento { get; set; }
        public string Genero { get; set; }
        public string Nacionalidade { get; set; }
    }


}
