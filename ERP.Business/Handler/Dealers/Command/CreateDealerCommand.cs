using Core.Constants;
using ERP.Business.Helper;
using ERP.Core.Wrappers;
using ERP.DAL.Abstract;
using ERP.Entities.Models;
using MediatR;

namespace ERP.Business.Handler.Dealers.Command;

public class CreateDealerCommand : IRequest<IResponse>
{
    public string DealerName { get; set; }

    public string DealerAddress { get; set; }

    public string DealerPhoneNumber { get; set; }

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
            addDealer.Name = request.DealerName;
            addDealer.Address = request.DealerAddress;
            addDealer.PhoneNumber = request.DealerPhoneNumber;

            var dealerControl = await _dealerRepository.GetByUsername(addDealer.Name);

            if (addDealer.Name == "string" || addDealer.Address == "string" || addDealer.PhoneNumber == "string")
            {
                throw new UserFriendlyException(Messages.NotEmpty, new List<string>()
                {
                    $"Alanı Boş Bırakmayınız. (string) Kabul Edilmez."
                });
            }

            if (dealerControl.Count() != 0)
            {
                throw new UserFriendlyException(Messages.NameAlreadyExist, new List<string>()
                {
                    $"{addDealer.Name} İsimli Bayi Sistemde Kayıtlıdır."
                });
            }

            _dealerRepository.Add(addDealer);
            await _dealerRepository.SaveChangesAsync();

            return new Response<Dealer>(addDealer);
        }
    }
}