using Business.Requests.Applicant;
using Business.Requests.Applications;
using Business.Responses.Applicant;
using Business.Responses.Applications;
using Core.Utilities.Results;
using Entities.Concretes;

namespace Business.Abstracts;

public interface IApplicantService
{
    Task<IDataResult<CreatedApplicantResponse>> AddAsync(CreateApplicantRequest request);
    Task<IDataResult<UpdatedApplicantResponse>> UpdateAsync(UpdateApplicantRequest request);
    Task<IResult> DeleteAsync(DeleteApplicantRequest request);
    Task<IDataResult<List<GetAllApplicantResponse>>> GetAllAsync();
    Task<IDataResult<GetByIdApplicantResponse>> GetByIdAsync(int id);

}
