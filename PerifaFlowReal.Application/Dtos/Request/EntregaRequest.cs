using System.ComponentModel.DataAnnotations;
using PerifaFlow.Domain.Enum;

namespace PerifaFlowReal.Application.Dtos.Request;

public class EntregaRequest
{
    [Required(ErrorMessage = "Id do Usuario é necessário")]
    public Guid UseroId { get; set; }
    
    [Required(ErrorMessage = "Id da missão é necessário")]
    public Guid MissaoId { get; set; }
    
    [Required(ErrorMessage = "Tipo da Entrega é necessário")]
    public TipoEntrega Tipo {get; set;} 
    
    [Required(ErrorMessage = "Conteudo da Url é necessário")]
    public string ConteudoUrl {get; set;}  = string.Empty;
}