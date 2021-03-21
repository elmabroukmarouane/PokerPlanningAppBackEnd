using AutoMapper;
using PokerPlanningApp.DtoModel.Models;
using Infrastructure.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokerPlanningApp.DtoModel.Profiles
{
    public class Profiles : Profile
    {
        public Profiles()
        {
            CreateMap<Role, RoleViewModel>();
            CreateMap<RoleViewModel, Role>();
            CreateMap<User, UserViewModel>();
            CreateMap<UserViewModel, User>();
            CreateMap<Person, PersonViewModel>();
            CreateMap<PersonViewModel, Person>();
            CreateMap<Duration, DurationViewModel>();
            CreateMap<DurationViewModel, Duration>();
            CreateMap<Group, GroupViewModel>();
            CreateMap<GroupViewModel, Group>();
            CreateMap<Issue, IssueViewModel>();
            CreateMap<IssueViewModel, Issue>();
        }
    }
}
