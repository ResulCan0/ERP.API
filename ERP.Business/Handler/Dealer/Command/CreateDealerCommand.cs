using Core.Constants;
using ERP.Business.Helper;
using ERP.Core.Wrappers;
using ERP.DAL.Abstract;
using ERP.Entities.Models;
using MediatR;

namespace ERP.Business.Handler.Dealers.Command;

public class CreateDealerCommand : IRequest<IResponse>
{
    public string Name { get; set; }

    public string Address { get; set; }

    public string PhoneNumber { get; set; }

    public class CreateDealerCommandHandler : IRequestHandler<CreateDealerCommand, IResponse>
    {
        private readonly IDealerRepository _dealerRepository;

        public CreateDealerCommandHandler(IDealerRepository dealerRepository)
        {
            _dealerRepository = dealerRepository;
        }

        public async Task<IResponse> Handle(CreateDealerCommand request, CancellationToken cancellationToken)
        {
            Dealer addDealer = new Dealer();
            addDealer.Name = request.Name;
            addDealer.Address = request.Address;
            addDealer.PhoneNumber = request.PhoneNumber;
            if (!RegularEx.IsString(addDealer.Name))
            {
                throw new UserFriendlyException(Messages.OnlyString,
                    new List<string>()
                    {
                        $"Sadece Metinsel Değer Girilmelidir."
                    });
            }
            if (addDealer.Name == "" || addDealer.Name=="string")
            {
                throw new UserFriendlyException(Messages.NotEmpty,
                    new List<string>()
                    {
                        $"Alan Boş Bırakılamaz."
                    });
            }
            if (addDealer.Address == "" || addDealer.Address=="string")
            {
                throw new UserFriendlyException(Messages.NotEmpty,
                    new List<string>()
                    {
                        $"Alan Boş Bırakılamaz."
                    });
            }
            if (addDealer.PhoneNumber == "" || addDealer.PhoneNumber=="string")
            {
                throw new UserFriendlyException(Messages.NotEmpty,
                    new List<string>()
                    {
                        $"Alan Boş Bırakılamaz."
                    });
            }
            if (!RegularEx.IsNumeric(addDealer.PhoneNumber))
            {
                throw new UserFriendlyException(Messages.OnlyInt,
                    new List<string>()
                    {
                        $"Sadece Rakamsal Değer Girilmelidir."
                    });
            }
            _dealerRepository.Add(addDealer);
            await _dealerRepository.SaveChangesAsync();
            
            throw new UserFriendlyException(Messages.Added,new List<string>()
                {
                   $"{request.Name} Bayiniz Sisteme Eklendi." 
                });
        }
    }
}