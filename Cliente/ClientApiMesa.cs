
using Cliente.Interface;
using Cliente.Model;
using Cliente.ModelResponse;
using Refit;

namespace Cliente
{
    public class ClientApiMesa : IMesaService
    {

        #region Service Mesa
        public async Task<List<MesaModel>> ObterListaMesa()
        {
            var IMesaService = RestService.For<IMesaService>(Servico.UrlBaseFoodService());
            var result = await IMesaService.ObterListaMesa();

            return result;
        }

        public Task<ActionResultado> AbrirMesa(int codMesa, int numeroMesa)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResultado> AdicionaConsumoMesa(ConsumoModel ConsumoModel)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResultado> FechamentoMesa(int codMesa, string seqAbreMesa, decimal totalFechamento)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResultado> Post(MesaModel mesaModel)
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
