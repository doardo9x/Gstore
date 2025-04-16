using System.ComponentModel.DataAnnotations;
namespace GStore.ViewModels;

public class LoginVM
{
    [Display(Name = "Email ou Nome do Usuário", Prompt = "informe seu Email ou Nome de Usuário")]
    [Required(ErrorMessage = "Por favor, informe seu email ou nome de usuário")]
    public string Email { get; set; }
}
