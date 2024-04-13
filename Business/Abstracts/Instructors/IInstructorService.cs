using Business.Requests.Employee;
using Business.Requests.Instructor;
using Business.Responses.Employee;
using Business.Responses.Instructor;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts.Instructor;

public interface IInstructorService
{
    Task<IDataResult<CreatedInstructorResponse>> AddAsync(CreateInstructorRequest request);
    Task<IDataResult<UpdatedInstructorResponse>> UpdateAsync(UpdateInstructorRequest request);
    Task<IResult> DeleteAsync(DeleteInstructorRequest request);
    Task<IDataResult<List<GetAllInstructorResponse>>> GetAllAsync();
    Task<IDataResult<GetByIdInstructorResponse>> GetByIdAsync(int id);
}
