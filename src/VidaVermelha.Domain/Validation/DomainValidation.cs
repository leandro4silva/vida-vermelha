using VidaVermelha.Domain.Exceptions;

namespace VidaVermelha.Domain.Validation;

public class DomainValidation
{
    public static void NotNull(object? target, string fieldName)
    {
        if (target == null)
        {
            throw new EntityValidationException(
                $"{fieldName} não pode ser null"   
            );
        }
    }

    public static void NotNullOrEmpty(string? target, string fieldName)
    {
        if (string.IsNullOrWhiteSpace(target))
        {
            throw new EntityValidationException(
                    $"{fieldName} não pode ser vazio ou null"
            );
        }
    }

    public static void MinLength(string target, int minLength, string fieldName)
    {
        if(target.Length < minLength)
        {
            throw new EntityValidationException(
                $"{fieldName} não pode ser menor do que {minLength} caracteres"
            );
        }
    }

    public static void MaxLength(string target, int maxLength, string fieldName)
    {
        if(target.Length > maxLength)
        {
            throw new EntityValidationException(
                $"{fieldName} não pode ser maior do que {maxLength} caracteres"
            );
        }
    }
}
