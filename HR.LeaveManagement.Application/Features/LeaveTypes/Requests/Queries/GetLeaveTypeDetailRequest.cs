using HR.LeaveManagement.Application.DTOs.LeaveAllocation;
using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveTypes.Requests.Queries
{
    public class GetLeaveAllocationDetailRequest : IRequest<LeaveAllocationDto>
    {
        public int Id { get; set; }
    }
}
