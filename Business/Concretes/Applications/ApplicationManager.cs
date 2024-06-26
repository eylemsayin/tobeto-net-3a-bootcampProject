﻿using AutoMapper;
using Business.Abstracts.Applications;
using Business.Abstracts.Blacklists;
using Business.Constants;
using Business.Requests.Applications;
using Business.Responses.Applications;
using Business.Rules;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes.Applications;

public class ApplicationManager : IApplicationService
{
    private readonly IApplicationRepository _applicationRepository;
    private readonly IMapper _mapper;
    private readonly IBlacklistService _blacklistService;
    private readonly ApplicationBusinessRules _rules;

    public ApplicationManager(IApplicationRepository applicationRepository, IMapper mapper, IBlacklistService blacklistService, ApplicationBusinessRules rules)
    {
        _applicationRepository = applicationRepository;
        _mapper = mapper;
        _blacklistService = blacklistService;
        _rules = rules;

    }

    public async Task<IDataResult<CreatedApplicationResponse>> AddAsync(CreateApplicationRequest request)
    {
        await _rules.CheckIfApplicantIsBlacklisted(request.ApplicantId);

        Application application = _mapper.Map<Application>(request);
        await _applicationRepository.AddAsync(application);
        CreatedApplicationResponse response = _mapper.Map<CreatedApplicationResponse>(application);
        return new SuccessDataResult<CreatedApplicationResponse>(response, ApplicationMessages.ApplicationAdded);
    }

    public async Task<IResult> DeleteAsync(DeleteApplicationRequest request)
    {
        await _rules.CheckIdIfNotExist(request.Id);

        var item = await _applicationRepository.GetAsync(x => x.Id == request.Id);
        await _applicationRepository.DeleteAsync(item);

        return new SuccessResult(ApplicationMessages.ApplicationDeleted);
    }

    public async Task<IDataResult<List<GetAllApplicationResponse>>> GetAllAsync()
    {
        var list = await _applicationRepository.GetAllAsync();
        List<GetAllApplicationResponse> response = _mapper.Map<List<GetAllApplicationResponse>>(list);
        return new SuccessDataResult<List<GetAllApplicationResponse>>(response, ApplicationMessages.ApplicationListed);
    }

    public async Task<IDataResult<GetByIdApplicationResponse>> GetByIdAsync(int id)
    {
        await _rules.CheckIdIfNotExist(id);

        var item = await _applicationRepository.GetAsync(x => x.Id == id);

        GetByIdApplicationResponse response = _mapper.Map<GetByIdApplicationResponse>(item);
        return new SuccessDataResult<GetByIdApplicationResponse>(response, ApplicationMessages.ApplicationFound);


    }

    public async Task<IDataResult<UpdatedApplicationResponse>> UpdateAsync(UpdateApplicationRequest request)
    {
        await _rules.CheckIdIfNotExist(request.Id);

        var item = await _applicationRepository.GetAsync(p => p.Id == request.Id);

        _mapper.Map(request, item);
        await _applicationRepository.UpdateAsync(item);

        UpdatedApplicationResponse response = _mapper.Map<UpdatedApplicationResponse>(item);
        return new SuccessDataResult<UpdatedApplicationResponse>(response, ApplicationMessages.ApplicationUpdated);
    }




}