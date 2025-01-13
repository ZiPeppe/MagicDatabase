using AutoMapper;
using MagicDatabase.Models;
using MagicDatabase.DTOs;

namespace MagicDatabase
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Mapping da DTO a Entità
            CreateMap<CardsDTO, Card>();

            // Mapping da Entità a DTO (opzionale, utile per i metodi GET)
            CreateMap<Card, CardsDTO>();
        }
    }
}
