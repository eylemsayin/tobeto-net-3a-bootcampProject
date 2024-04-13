using Business.Requests.Applicant;
using Business.Requests.Employee;
using Business.Responses.Applicant;
using Business.Responses.Employee;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts.Employee;

public interface IEmployeeService
{
    Task<IDataResult<CreatedEmployeeResponse>> AddAsync(CreateEmployeeRequest request);
    Task<IDataResult<UpdatedEmployeeResponse>> UpdateAsync(UpdateEmployeeRequest request);
    Task<IResult> DeleteAsync(DeleteEmployeeRequest request);
    Task<IDataResult<List<GetAllEmployeeResponse>>> GetAllAsync();
    Task<IDataResult<GetByIdEmployeeResponse>> GetByIdAsync(int id);
}
