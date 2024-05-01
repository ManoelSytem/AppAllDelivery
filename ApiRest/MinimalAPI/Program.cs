using Microsoft.AspNetCore.Builder;
using MinimalAPI.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Habilitando o swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//instanciando o repositório em memória.
var repositorio = new TicketRequestRepository(true);
var passageiroRepository = new PassageiroRepository(true);

app.UseSwagger();// Ativando o Swagger

// Endpoints da solução
app.MapGet("/", () => "Hello World!");

#region Controllers Ticket
// Listar TicketRequest.
app.MapGet("/ListaTicket", () =>
{
    return repositorio.TicketList();
});

//Buscar TicketRequest por id.
app.MapGet("/ListaTicket/{Id}", (Guid Id) =>
{
    return repositorio.SelecionarTicket(Id);
});

//cancelar TicketRequest.
app.MapDelete("/ListaTicket/cancelar/{Id}", (Guid Id) =>
{
    return repositorio.CancelarTicket(Id);
});

#endregion Controllers Ticket

#region Controllers Passageiro

// Listar TicketRequest.
app.MapGet("/ListPassageiro", () =>
{
    return passageiroRepository.ListPassagiero();
});

//Buscar TicketRequest por id.
app.MapGet("/Passageiro/{Id}", (Guid Id) =>
{
    return passageiroRepository.SelecionarPasssagiero(Id);
});

//Adicionar TicketRequest.
app.MapPost("/Passageiro/adicionar", (PassageiroRequest passageiroRequest) =>
{
    return passageiroRepository.SalvarPassageiro(passageiroRequest);
});

//Atualizar TicketRequest.
app.MapPut("/Passageiro/atualizar", (PassageiroRequest passageiroReques) =>
{
    return passageiroRepository.AtualizarPassageiro(passageiroReques);
});

//cancelar TicketRequest.
app.MapDelete("/Passageiro/Delete/{Id}", (Guid Id) =>
{
    return passageiroRepository.Delete(Id);
});

#endregion Controllers Passageiro

app.UseSwaggerUI();// Ativando a interface Swagger

app.Run();