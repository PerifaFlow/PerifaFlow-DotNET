using System.ComponentModel.DataAnnotations;

namespace PerifaFlowReal.Application.Dtos.Request;

public class MissaoRequest
{
    [Required (ErrorMessage = "T")]
    public string Titulo { get; set; }
    public string Descricao { get; set; }
    public Guid TrilhaId { get; set; }
}