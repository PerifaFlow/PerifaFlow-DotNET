using PerifaFlow.Application.Interfaces.Repositories.Mongo;
using PerifaFlow.Domain.Entities;

namespace PerifaFlow.Application.UseCases.Trilhas;

public class ListarTrilhaUseCase
{
    private readonly ITrilhaRepository _trilhaRepository;

    public ListarTrilhaUseCase(ITrilhaRepository trilhaRepository)
    {
        _trilhaRepository = trilhaRepository;
    }

    public async Task<IEnumerable<Trilha>> ExecuteAsync(int page = 1, int pageSize = 10)
    {
        if (page <= 0 || pageSize <= 0)
            throw new ArgumentException("Parâmetros de paginação inválidos.");

        var trilhas = await _trilhaRepository.ListarAsync(page, pageSize);

        if (trilhas == null || !trilhas.Any())
            throw new KeyNotFoundException("Nenhuma trilha encontrada.");

        return trilhas;
    }
}