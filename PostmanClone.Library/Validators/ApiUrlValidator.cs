using FluentValidation;

namespace PostmanClone.Library.Validators;
public class ApiUrlValidator : AbstractValidator<string>
{
    public ApiUrlValidator()
    {
        RuleFor(url => url)
            .NotEmpty().WithMessage("URL cannot be empty.")
            .Must(BeAValidUri).WithMessage("Invalid URL format.")
            .Must(BeASecureConnection).WithMessage("The URL should be using HTTPS connection.");
    }

    private bool BeAValidUri(string url)
    {
        return Uri.TryCreate(url, UriKind.Absolute, out _);
    }

    private bool BeASecureConnection(string url)
    {
        if(string.IsNullOrWhiteSpace(url)) return false;

        return Uri.TryCreate(url, UriKind.Absolute, out Uri result) 
            && result?.Scheme == Uri.UriSchemeHttps;
    }
}