using Business.Requests.Applicant;
using Business.Requests.Applications;
using Business.Requests.ApplicationStates;
using Business.Responses.Applicant;
using Business.Responses.Applications;
using Business.Responses.ApplicationStates;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts.Applications
{
    public interface IApplicationService
    {
        Task<IDataResult<CreatedApplicationResponse>> AddAsync(CreateApplicationRequest request);
        Task<IDataResult<UpdatedApplicationResponse>> UpdateAsync(UpdateApplicationRequest request);
        Task<IResult> DeleteAsync(DeleteApplicationRequest request);
        Task<IDataResult<List<GetAllApplicationResponse>>> GetAllAsync();
        Task<IDataResult<GetByIdApplicationResponse>> GetByIdAsync(int id);
    }
}
