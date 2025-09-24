using System;
namespace Veterinaria.Models;
using Veterinaria.Validaciones;
using System.ComponentModel.DataAnnotations;

public class Contacto
{
	[Required(ErrorMessage = "El campo {0} es requerido")]
	[NoCaracteresEspeciales]
	public string Nombre { get; set; }
	[EmailAddress(ErrorMessage ="El campo {0} es requerido")]
	public string Correo { get; set; }
    [Required(ErrorMessage = "El campo {0} es requerido")]
	[Phone(ErrorMessage ="El campo {0} es requerido")]
    public string Telefono { get; set; }
	public Contacto()
	{
	}
}

