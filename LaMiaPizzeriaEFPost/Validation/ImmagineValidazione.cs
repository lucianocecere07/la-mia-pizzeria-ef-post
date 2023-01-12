using System.ComponentModel.DataAnnotations;

namespace LaMiaPizzeriaEFPost.Validation
{
    public class ImmagineValidazione : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            string immagineFormato = (string)value;

            if(immagineFormato.EndsWith(".png") || immagineFormato.EndsWith(".jpg") || immagineFormato.EndsWith(".jpeg") || immagineFormato.EndsWith(".webp"))
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("Il formato dell'immagine non è coretto");
        }
    }
}
