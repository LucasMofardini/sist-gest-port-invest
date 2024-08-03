using FluentValidation;
using InvestmentManagementSystem.Application.DTOs;
using InvestmentManagementSystem.Application.DTOs.Customer;

namespace InvestmentManagementSystem.Application.Validations;

public class CreateCustomerDTOValidator : AbstractValidator<CreateCustomerDTO>
{
    public CreateCustomerDTOValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("O Nome é obrigatório");

        RuleFor(x => x.PhoneNumber)
            .MaximumLength(14).WithMessage("O Número de Telefone deve ter até 14 caracteres");

        RuleFor(x => x.IdentificationNumber)
            .NotEmpty().WithMessage("O CPF/CNPJ é obrigatório")
            .MaximumLength(14).WithMessage("O CPF/CNPJ deve ter até 14 caracteres");

        RuleFor(x => x.PostalCode)
            .MaximumLength(8).WithMessage("O CEP deve ter até 8 caracteres");

        RuleFor(x => x.Email)
            .MaximumLength(65).WithMessage("O Email deve ter até 65 caracteres");

        RuleFor(x => x.Balance)
            .NotEmpty().WithMessage("O Saldo é obrigatório");
    }
}