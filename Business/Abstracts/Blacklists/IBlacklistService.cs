﻿using Business.Requests.Blacklists;
using Business.Responses.Blacklists;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts.Blacklists;

public interface IBlacklistService
{
    Task<IDataResult<CreatedBlacklistResponse>> AddAsync(CreateBlacklistRequest request);
    Task<IDataResult<UpdatedBlacklistResponse>> UpdateAsync(UpdateBlacklistRequest request);
    Task<IResult> DeleteAsync(DeleteBlacklistRequest request);
    Task<IDataResult<List<GetAllBlacklistResponse>>> GetAllAsync();
    Task<IDataResult<GetByIdBlacklistResponse>> GetByIdAsync(int id);
    Task<IDataResult<GetByIdBlacklistResponse>> GetByApplicantIdAsync(int id);
}
