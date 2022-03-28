using Core.Constants;
using ERP.Business.Handler.Dealers.Command;
using FluentValidation;

namespace ERP.Business.Handler.Dealers.Validator;

public class CreateDealerCommandValidator : AbstractValidator<CreateDealerCommand>
{
    public CreateDealerCommandValidator()
    {
        RuleFor(_ => _.Name).NotEmpty().WithMessage(Messages.NotEmpty.ToString())
            .MaximumLength(64).WithMessage(Messages.CharacterOver.ToString())
            .Matches(@"^[A-Za-z\s]+$").WithMessage(Messages.OnlyString.ToString());

        RuleFor(_ => _.Address).NotEmpty().WithMessage(Messages.NotEmpty.ToString())
            .MaximumLength(200).WithMessage(Messages.CharacterOver.ToString());


        RuleFor(_ => _.PhoneNumber).NotEmpty().WithMessage(Messages.NotEmpty.ToString())
            .MaximumLength(10).WithMessage(Messages.CharacterOver.ToString())
            .Matches(@"^[0-9]+$").WithMessage(Messages.OnlyInt.ToString());
    }
}

public class UpdateDealerCommandValidator : AbstractValidator<UpdateDealerCommand>
{
    public UpdateDealerCommandValidator()
    {
        RuleFor(_ => _.DealerId).NotEmpty().WithMessage(Messages.NotEmpty.ToString());

        RuleFor(_ => _.Name).MaximumLength(64).WithMessage(Messages.CharacterOver.ToString())
            .Matches(@"^[A-Za-z\s]+$").WithMessage(Messages.OnlyString.ToString());

        RuleFor(_ => _.Address).MaximumLength(200).WithMessage(Messages.CharacterOver.ToString());


        RuleFor(_ => _.PhoneNumber).MaximumLength(10).WithMessage(Messages.CharacterOver.ToString())
            .Matches(@"^[0-9]+$").WithMessage(Messages.OnlyInt.ToString());
    }
}

public class DeleteDealerCommandValidator : AbstractValidator<DeleteDealerCommand>
{
    public DeleteDealerCommandValidator()
    {
        RuleFor(_ => _.DealerId).NotEmpty().WithMessage(Messages.NotEmpty.ToString());
    }
}