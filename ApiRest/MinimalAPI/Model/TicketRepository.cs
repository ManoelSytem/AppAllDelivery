using System.Collections.Generic;
using System.Security.Cryptography;

namespace MinimalAPI.Model
{
    public class TicketRequestRepository
    {
        public List<TicketRequest> ListTicketRequest { get; set; }

        public TicketRequestRepository(bool dados)
        {
            if (dados)
            {
                CriarDadosEmMemoria();
            }
            else
            {
                ListTicketRequest = new List<TicketRequest>();
            }
        }

        private void CriarDadosEmMemoria()
        {

            this.ListTicketRequest = new List<TicketRequest>()
            {
               
                new TicketRequest {  Origin = "TESTE", Destiny = "SSA", Departure = DateTime.Now, Returns = DateTime.Now, BoxColor = "#03a9f4" },
                new TicketRequest {  Origin = "CGH", Destiny = "FLN", Departure = DateTime.Now, Returns = DateTime.Now,  BoxColor = "#e91e63"},
                new TicketRequest {  Origin = "REC", Destiny = "SDU", Departure = DateTime.Now, Returns = DateTime.Now,  BoxColor = "#673ab7"},
                new TicketRequest {  Origin = "CGB", Destiny = "SBCY", Departure = DateTime.Now, Returns = DateTime.Now, BoxColor = "#3f51b5" },
                new TicketRequest {  Origin = "MCP", Destiny = "GYN", Departure = DateTime.Now, Returns = DateTime.Now,  BoxColor = "#f44336" }
            };
       
        }
        public TicketRequest AdicionarTicket(TicketRequest t)
        {
            ListTicketRequest.Add(t);
            return t;
        }

        public bool CancelarTicket(Guid id)
        {
            var TicketRequestTemp = (from TicketRequest in this.ListTicketRequest
                              where TicketRequest.Id == id
                              select TicketRequest).SingleOrDefault();
            if (TicketRequestTemp == null)
            {
                return false;
            }
            var removido = ListTicketRequest.Remove(TicketRequestTemp);
            return removido;
        }

        public List<TicketRequest> TicketList()
        {
            Console.WriteLine("Eu passei por aqui ListPassageiro");
            return this.ListTicketRequest;
        }

        public TicketRequest SelecionarTicket(Guid id)
        {
            var TicketRequestTemp = (from TicketRequest in this.ListTicketRequest
                              where TicketRequest.Id == id
                              select TicketRequest).SingleOrDefault();
            if (TicketRequestTemp == null)
            {
                return new TicketRequest();
            }
            return TicketRequestTemp;
        }

        public bool AtualizarTicket(TicketRequest t)
        {
            var TicketRequestTemp = (from TicketRequest in this.ListTicketRequest
                              where TicketRequest.Id == t.Id
                              select TicketRequest).SingleOrDefault();
            if (TicketRequestTemp == null)
            {
                return false;
            }

            TicketRequestTemp = new TicketRequest { Origin = TicketRequestTemp.Origin,
                                        Destiny = TicketRequestTemp.Destiny,
                                        Departure = DateTime.Now,
                                        Returns = DateTime.Now,
                                        BoxColor = "#03a9f4" };

            this.ListTicketRequest.Add(TicketRequestTemp);

            return true;
        }
    }
}
