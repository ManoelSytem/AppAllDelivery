using Cliente.Model;
using Cliente.ModelResponse;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Cliente.Interface
{
    public interface IMesaService
    {
        [Get("/Mesa/ObterListaMesa")]
        Task<List<MesaModel>> ObterListaMesa();
        Task<ActionResultado> Post(MesaModel mesaModel);
        [Post("/Mesa/AbrirMesa")]
        Task<ActionResultado> AbrirMesa(int codMesa, int numeroMesa);
        [Post("/Mesa/FechamentoMesa")]
        Task<ActionResultado> FechamentoMesa(int codMesa, string seqAbreMesa, decimal totalFechamento);
        [Post("/Mesa/AdicionaConsumoMesa")]
        Task<ActionResultado> AdicionaConsumoMesa(ConsumoModel ConsumoModel);
        
    }
}
