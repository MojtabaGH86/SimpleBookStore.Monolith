using Common.Application;
using FluentValidation;
using Microsoft.AspNetCore.Http;

namespace BookStore.Application.Contract.Books.Commands
{
    public class DefineBookCommand : ICommand
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Isbn { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public int PublishYear { get; set; }
        public IFormFile Image { get; set; }
        public string Description { get; set; }
    }

    public class DefineBookCommandValidator: AbstractValidator<DefineBookCommand>
    {
        public DefineBookCommandValidator()
        {
            RuleFor(cmd => cmd.CategoryId)
                .NotEqual(0);
            RuleFor(cmd => cmd.Name)
                .NotEmpty();
            RuleFor(cmd => cmd.Code)
                .NotEmpty();
            RuleFor(cmd => cmd.Isbn)
                .NotEmpty();
            RuleFor(cmd => cmd.Author)
                .NotEmpty();
            RuleFor(cmd => cmd.Price)
                .NotEqual(0);
            RuleFor(cmd => cmd.Image)
                .NotNull();
        }
    }
}
