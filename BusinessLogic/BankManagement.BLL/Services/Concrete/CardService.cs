using AutoMapper;
using BankManagement.BLL.DTOs.CardTypeDTOs;
using BankManagement.BLL.Services.Abstract;
using BankManagement.DAL.Contexts.Abstract;
using BankManagement.DAL.Entities;

namespace BankManagement.BLL.Services.Concrete
{
    public class CardService : ICardService
    {
        private readonly ICardRepository _repo;
        private readonly IMapper _mapper;
        public CardService(IMapper mapper,ICardRepository  repo)
        {
            _mapper = mapper;
            _repo = repo;
        }
        public IEnumerable<CardTypeByBankIdDto> GetByBankId(int id)
        {
            IEnumerable<CardType> entity = _repo.GetByBankId(id);
            IEnumerable<CardTypeByBankIdDto> dtos = _mapper.Map<IEnumerable<CardTypeByBankIdDto>>(entity);
            return dtos;
        }

        public CardTypeByIdDto GetById(int id)
        {
            CardType entity = _repo.GetById(id);
            CardTypeByIdDto dto = _mapper.Map<CardTypeByIdDto>(entity);
            return dto;
        }
    }
}
