using PerifaFlow.Domain.Entities;

namespace PerifaFlowReal.Application.Dtos.java;

public class SugestaoMissaoResponse
{
    public Guid MissaoId { get; set; } 
    public string Complexidade { get; set; } = default!; // "CURTA" | "NORMAL"
    public bool Offline { get; set; }
    public string Mensagem { get; set; } = default!;
    
    public static SugestaoMissaoResponse FromEntity(Missao missao)
    {
        return new SugestaoMissaoResponse
        {
            MissaoId = missao.Id,
            Complexidade = "CURTA",
            Offline = false,
            Mensagem = "Missão carregada com sucesso"
        };
    }
}