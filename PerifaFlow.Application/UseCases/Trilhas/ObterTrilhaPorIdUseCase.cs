using PerifaFlow.Application.Interfaces.Repositories.Mongo;
using PerifaFlow.Domain.Entities;

namespace PerifaFlow.Application.UseCases.Trilhas;

public class ObterTrilhaPorIdUseCase
{
    private readonly ITrilhaRepository _trilhaRepository;

    public ObterTrilhaPorIdUseCase(ITrilhaRepository trilhaRepository)
    {
        _trilhaRepository = trilhaRepository;
    }

    public async Task<Trilha> ExecuteAsync(Guid id)
    {
        var trilha = await _trilhaRepository.ObterPorIdAsync(id);

        if (trilha == null)
            throw new KeyNotFoundException($"Trilha com ID {id} não encontrada.");

        return trilha;
    }
}