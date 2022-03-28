using ERP.Core.Wrappers;
using ERP.DAL.Abstract;
using ERP.Entities.Models;
using MediatR;

namespace ERP.Business.Handler.Dealers.Command;

public class UpdateDealerCommand : IRequest<IResponse>
{
    public int DealerId { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }

    public class UpdateDealerCommandHandler : IRequestHandler<UpdateDealerCommand, IResponse>
    {
        private readonly IDealerRepository _dealerRepository;

        public UpdateDealerCommandHandler(IDealerRepository dealerRepository)
        {
            _dealerRepository = dealerRepository;
        }

        public async Task<IResponse> Handle(UpdateDealerCommand request, CancellationToken cancellationToken)
        {
            Dealer updateDealer = _dealerRepository.Get(_ => _.DealerId == request.DealerId);
            updateDealer.Name = request.Name;
            updateDealer.Address = request.Address;
            updateDealer.PhoneNumber = request.PhoneNumber;

            _dealerRepository.Update(updateDealer);
            await _dealerRepository.SaveChangesAsync();

            return new Response<Dealer>(updateDealer);
        }
    }
}