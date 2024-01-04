using FluentValidation.Results;
using System.Text;
namespace Business.Validations.Extension
{
    public static class FluentValidationExtension
    {
        public static string ToMessage(this IList<ValidationFailure> errors)
        {
            StringBuilder builder = new StringBuilder();
            foreach (var error in errors)
            {
                builder.AppendLine($"{error.ErrorMessage}");
            }
            return builder.ToString();
        }
        public static string ToMessageWithValue(this IList<ValidationFailure> errors)
        {
            StringBuilder builder = new StringBuilder();
            foreach (var error in errors)
            {
                builder.AppendLine($"{error.ErrorMessage} {error.AttemptedValue}");
            }
            return builder.ToString();
        }
    }
}
