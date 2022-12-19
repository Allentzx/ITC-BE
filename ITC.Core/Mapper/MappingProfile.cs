using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITC.Core.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region Nullable type
            CreateMap<int?, int>().ConvertUsing((src, des) => src ?? des);
            CreateMap<bool?, bool>().ConvertUsing((src, des) => src ?? des);
            CreateMap<Guid?, Guid>().ConvertUsing((src, des) => src ?? des);
            CreateMap<DateTime?, DateTime>().ConvertUsing((src, des) => src ?? des);
            #endregion

            #region User
            //CreateMap<User, UserViewModel>();

            #endregion

            #region Role
            //CreateMap<Role, RoleViewModel>();
            //CreateMap<RoleCreateModel, Role>();
            //CreateMap<RoleUpdateModel, Role>();
            #endregion

            
        }
    }
}
