using AutoMapper;
using BankManagement.BLL.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.BLL.Services.Concrete
{
    //internal class BankService:IBankService
    //{
    //    private readonly IMapper _mapper;
    //    private readonly IUserRepostory _userrepostory;
    //    public UserService(IMapper mapper, IUserRepostory userRepostory)
    //    {
    //        _mapper = mapper;
    //        _userrepostory = userRepostory;
    //    }
    //    public void Add(UserToAddDto dto)
    //    {
    //        User entity = _mapper.Map<User>(dto);
    //        _userrepostory.Add(entity);
    //    }

    //    public void Delete(int id)
    //    {
    //        User entity = _userrepostory.Get(id);
    //        _userrepostory.Delete(entity);
    //    }

    //    public List<UserToListDto> Get()
    //    {
    //        List<User> entities = _userrepostory.Get();
    //        return _mapper.Map<List<UserToListDto>>(entities);
    //    }
    //}
}
