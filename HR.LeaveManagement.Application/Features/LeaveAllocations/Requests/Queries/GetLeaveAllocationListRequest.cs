using HR.LeaveManagement.Application.DTOs.LeaveType;
using MediatR;
using System.Collections.Generic;

namespace HR.LeaveManagement.Application.Features.LeaveAllocations.Requests.Queries
{
    public class GetLeaveAllocationListRequest : IRequest<List<LeaveTypeDto>>
    {

    }
}
