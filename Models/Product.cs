
using System.ComponentModel.DataAnnotations;

namespace apiAspNetCore.Models
{
  public class Product
  {
    [Key]
    public int Id {get; set;}

    [Required(ErrorMessage = "este campo é obrigatório")]
    [MaxLength(60, ErrorMessage = "este campo deve conter entre 3 e 60 caracteres")]
    [MinLength(3, ErrorMessage = "este campo deve conter entre 3 e 60 caracteres")]
    public string Title {get; set;}

    [MaxLength(60, ErrorMessage = "este campo deve conter entre 3 e 60 caracteres")]
    public string Description {get; set;}

    [Required(ErrorMessage = "este campo é obrigatório")]
    [Range(1, int.MaxValue, ErrorMessage = "O preço deve ser maior que zero")]
    public decimal Price {get; set;}

    [Required(ErrorMessage = "este campo é obrigatório")]
    [Range(1, int.MaxValue, ErrorMessage = "Categoria inválida")]
    public decimal CategoryId {get; set;}

    public Category Category {get; set;}

  }
}