using AutoMapper;
using BankManagement.BLL.DTOs.BankDtos;
using BankManagement.BLL.Services.Abstract;
using BankManagement.DAL.Entities;
using BankManagement.DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.BLL.Services.Concrete
{
    public class BankService : IBankService
    {
        private readonly IMapper _mapper;
        private readonly IBankRepository _bankrepository;
        public BankService(IMapper mapper, IBankRepository bankRepository)
        {
            _mapper = mapper;
            _bankrepository = bankRepository;
        }

        public List<BankToListDto> Get()
        {
            List<Bank> entities = _bankrepository.Get();
            return _mapper.Map<List<BankToListDto>>(entities);
        }

        public BankByIdDto Get(int id)
        {
            Bank entity = _bankrepository.Get(id);
            return _mapper.Map<BankByIdDto>(entity);
        }
    }
}
