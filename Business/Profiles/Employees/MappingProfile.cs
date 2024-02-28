using AutoMapper;
using Business.Requests.Employee;
using Business.Responses.Employee;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles.Employees;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Employee, CreateEmployeeRequest>().ReverseMap();
        CreateMap<Employee, DeleteEmployeeRequest>().ReverseMap();
        CreateMap<Employee, UpdateEmployeeRequest>().ReverseMap();

        CreateMap<Employee, CreatedEmployeeResponse>().ReverseMap();
        CreateMap<Employee, DeletedEmployeeResponse>().ReverseMap();
        CreateMap<Employee, UpdatedEmployeeResponse>().ReverseMap();
        CreateMap<Employee, GetAllEmployeeResponse>().ReverseMap();
        CreateMap<Employee, GetByIdEmployeeResponse>().ReverseMap();
    }
}
