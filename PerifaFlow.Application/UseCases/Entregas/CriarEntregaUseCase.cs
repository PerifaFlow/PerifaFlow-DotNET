using PerifaFlow.Application.DTOs.Request.Entregas;
using PerifaFlow.Application.DTOs.Response.Entrega;
using PerifaFlow.Application.Interfaces.Repositories.Mongo;

namespace PerifaFlow.Application.UseCases.Entregas;

public class CriarEntregaUseCase : ICriarEntregaUseCase
{
    private readonly IEntregaRepository _entregaRepository;

    public CriarEntregaUseCase(IEntregaRepository entregaRepository)
    {
        _entregaRepository = entregaRepository;
    }

    public async Task<EntregaResponse> ExecuteAsync(CriarEntregaRequest request)
    {
        var entrega = new Domain.Entities.Entrega(
            request.UsuarioId,
            request.MissaoId,
            request.TipoEntrega,
            request.Conteudo
        );

        await _entregaRepository.CriarAsync(entrega);

        return new EntregaResponse
        {
            Id = entrega.Id,
            UsuarioId = entrega.UsuarioId,
            MissaoId = entrega.MissaoId,
            TipoEntrega = entrega.Tipo,
            Conteudo = entrega.Conteudo,
            EnviadaEm = entrega.DataEnvio
        };
    }
}