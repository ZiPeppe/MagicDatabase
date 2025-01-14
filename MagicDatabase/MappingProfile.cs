using AutoMapper;
using MagicDatabase.Models;
using MagicDatabase.API.DTOs;

namespace MagicDatabase
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Mapping da DTO a Entità
            CreateMap<CardDto, Card>();

            // Mapping da Entità a DTO (opzionale, utile per i metodi GET)
            CreateMap<Card, CardDto>();

            CreateMap<CardUpdateDto, Card>();

            CreateMap<Card, CardDetailsDto>()
            .ForMember(dest => dest.CardRarity, opt => opt.MapFrom(src => src.CardRarity.CardRarityName))
            .ForMember(dest => dest.CardStatus, opt => opt.MapFrom(src => src.CardStatus.CardStatusName))
            .ForMember(dest => dest.CardSubCategory, opt => opt.MapFrom(src => src.CardSubCategory.CardSubCategoryName))
            .ForMember(dest => dest.CardCategory, opt => opt.MapFrom(src => src.CardSubCategory.CardCategory.CardCategoryName))
            .ForMember(dest => dest.CardLanguage, opt => opt.MapFrom(src => src.CardLanguage.CardLanguageName))
            .ForMember(dest => dest.CardArtType, opt => opt.MapFrom(src => src.CardArtType.CardArtTypeName));
        }
    }
}
