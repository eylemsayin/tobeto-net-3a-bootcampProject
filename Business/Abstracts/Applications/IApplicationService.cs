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
        public Task<IDataResult<CreatedApplicationResponse>> AddAsync(CreateApplicationRequest request);
        public Task<IDataResult<UpdatedApplicationResponse>> UpdateAsync(UpdateApplicationRequest request);
        public Task<IDataResult<DeletedApplicationResponse>> DeleteAsync(DeleteApplicationRequest request);
        public Task<IDataResult<List<GetAllApplicationResponse>>> GetAllAsync();
        public Task<IDataResult<GetByIdApplicationResponse>> GetByIdAsync(int id);
    }
}
