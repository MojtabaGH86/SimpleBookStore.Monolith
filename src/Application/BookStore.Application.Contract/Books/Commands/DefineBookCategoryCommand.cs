using Common.Application;
using FluentValidation;

namespace BookStore.Application.Contract.Books.Commands;

public class DefineBookCategoryCommand : ICommand
{
    public string Title { get; set; }
}

public class DefineBookCategoryCommandValidator
    : AbstractValidator<DefineBookCategoryCommand>
{
    public DefineBookCategoryCommandValidator()
    {
        RuleFor(cmd => cmd.Title)
            .NotEmpty();
    }
}