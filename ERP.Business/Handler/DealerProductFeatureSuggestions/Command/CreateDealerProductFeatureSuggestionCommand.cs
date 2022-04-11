using ERP.Core.Wrappers;
using ERP.DAL.Abstract;
using ERP.Entities.DTOs;
using ERP.Entities.Models;
using MediatR;

namespace ERP.Business.Handler.DealerProductFeatureSuggestions.Command;

public class CreateDealerProductFeatureSuggestionCommand : IRequest<IResponse>
{
    public int DealerProductDemandId { get; set; }

    public ProductFeatureDto ProductFeature { get; set; }


    public class
        CreateDealerProductFeatureSuggestionCommandHandler : IRequestHandler<CreateDealerProductFeatureSuggestionCommand
            , IResponse>
    {
        private readonly IDealerProductFeatureSuggestionRepository _dealerProductFeatureSuggestionRepository;

        public CreateDealerProductFeatureSuggestionCommandHandler(
            IDealerProductFeatureSuggestionRepository dealerProductFeatureSuggestionRepository)
        {
            _dealerProductFeatureSuggestionRepository = dealerProductFeatureSuggestionRepository;
        }

        public async Task<IResponse> Handle(CreateDealerProductFeatureSuggestionCommand request,
            CancellationToken cancellationToken)
        {
            request.ProductFeature.CriterionNote = (request.ProductFeature.Appearance + request.ProductFeature.Availabiliyt +
                                                   request.ProductFeature.Functionality + request.ProductFeature.Innovation +
                                                   request.ProductFeature.PriceAdvantage) / 5;
            DealerProductFeatureSuggestion addDealerProductFeatureSuggestion = new DealerProductFeatureSuggestion
            {
                DealerProductDemandId = request.DealerProductDemandId,
                
                ProductFeatures =
                {
                    Appearance = request.ProductFeature.Appearance.ToString(),
                    Availabiliyt = request.ProductFeature.Availabiliyt.ToString(),
                    Functionality = request.ProductFeature.Functionality.ToString(),
                    Innovation = request.ProductFeature.Innovation.ToString(),
                    PriceAdvantage = request.ProductFeature.PriceAdvantage.ToString(),
                    CriterionNote = request.ProductFeature.CriterionNote
                }
            };
            _dealerProductFeatureSuggestionRepository.Add(addDealerProductFeatureSuggestion);
            await _dealerProductFeatureSuggestionRepository.SaveChangesAsync();

            return new Response<DealerProductFeatureSuggestion>(addDealerProductFeatureSuggestion);
        }
    }
}