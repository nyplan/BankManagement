using AutoMapper;
using BankManagement.BLL.DTOs.UserDTOs;
using BankManagement.BLL.Services.Abstract;
using BankManagement.DAL.Entities;
using BankManagement.DAL.Repositories.Abstract;

namespace BankManagement.BLL.Services.Concrete
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;
        public UserService(IUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public UserInfo Login(UserLogin dto)
        {
            User user = _repository.Get(dto.Username, dto.Password);
            return _mapper.Map<UserInfo>(user);
        }

        public void Register(UserRegister dto)
        {
            User user = _mapper.Map<User>(dto);
            _repository.Add(user);
        }
    }
}
