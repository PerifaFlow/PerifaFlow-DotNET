using System.ComponentModel.DataAnnotations;

namespace PerifaFlowReal.Application.Dtos.Request;

public class MissaoRequest
{
    [Required (ErrorMessage = "Titulo e Obrigatório")]
    public string Titulo { get; set; }
    
    [Required(ErrorMessage = "Descrição é obrigatório")]
    public string Descricao { get; set; }
    
    [Required(ErrorMessage = "O Id da trilha é obrigatório")]
    public Guid TrilhaId { get; set; }
}