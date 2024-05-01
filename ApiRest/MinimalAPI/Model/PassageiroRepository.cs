namespace MinimalAPI.Model
{
    public class PassageiroRepository
    {
        private List<PassageiroRequest> ListPassageiro { get; set; }

        public PassageiroRepository(bool dados)
        {
            if (dados)
            {
                CriarDadosEmMemoria();
            }
            else
            {
                ListPassageiro = new List<PassageiroRequest>();
            }
        }

        private void CriarDadosEmMemoria()
        {

            this.ListPassageiro = new List<PassageiroRequest>()
            {

               
            };

        }
        public PassageiroRequest SalvarPassageiro(PassageiroRequest p)
        {
            p.Id = Guid.NewGuid();
            ListPassageiro.Add(p);
            return p;
        }

        public bool Delete(Guid id)
        {
            var PassageiroRequestTemp = (from Passageiro in this.ListPassageiro
                                     where Passageiro.Id == id
                                     select Passageiro).SingleOrDefault();
            if (PassageiroRequestTemp == null)
            {
                return false;
            }
            var removido = ListPassageiro.Remove(PassageiroRequestTemp);
            return removido;
        }

        public List<PassageiroRequest> ListPassagiero()
        {
           
            return this.ListPassageiro;
        }

        public PassageiroRequest SelecionarPasssagiero(Guid id)
        {
            var PassageiroRequestTemp = (from Passageiro in this.ListPassageiro
                                     where Passageiro.Id == id
                                     select Passageiro).SingleOrDefault();
            if (PassageiroRequestTemp == null)
            {
                return new PassageiroRequest();
            }
            return PassageiroRequestTemp;
        }

        public bool AtualizarPassageiro(PassageiroRequest p)
        {
            var PassageiroRequestTemp = (from Passageiro in this.ListPassageiro
                                     where Passageiro.Id == p.Id
                                     select Passageiro).SingleOrDefault();
            if (PassageiroRequestTemp == null)
            {
                return false;
            }

            PassageiroRequestTemp = new PassageiroRequest
            {
                    PrimeiroNome = PassageiroRequestTemp.PrimeiroNome,
                    ultimoSobreNomeDoc = PassageiroRequestTemp.ultimoSobreNomeDoc,
                    Documento = PassageiroRequestTemp.Documento,
                    Datanascimento = PassageiroRequestTemp.Datanascimento,
                    Genero = PassageiroRequestTemp.Genero,
                    Nacionalidade = PassageiroRequestTemp.Nacionalidade,
            };

            this.ListPassageiro.Add(PassageiroRequestTemp);

            return true;
        }
}
}
