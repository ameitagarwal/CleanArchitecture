using AutoMapper;
using HR.LeaveManagement.Application.Exceptions;
using HR.LeaveManagement.Application.Features.LeaveAllocations.Requests.Commands;
using HR.LeaveManagement.Application.Persistence.Contracts;
using HR.LeaveManagement.Domain;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Features.LeaveAllocations.Handlers.Commands
{
    public class DeleteLeaveAllocationCommandHandler : IRequestHandler<DeleteLeaveAllocationCommand, Unit>
    {
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        private readonly IMapper _mapper;

        public DeleteLeaveAllocationCommandHandler(ILeaveAllocationRepository leaveAllocationRepository, IMapper mapper)
        {
            _leaveAllocationRepository = leaveAllocationRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(DeleteLeaveAllocationCommand request, CancellationToken cancellationToken)
        {
            var leaveAllocation = _leaveAllocationRepository.Get(request.Id);
            if (leaveAllocation is null)
                throw new NotFoundException(nameof(LeaveAllocation), request.Id);

            await _leaveAllocationRepository.Delete(_mapper.Map<LeaveAllocation>(leaveAllocation));
            return Unit.Value;
        }
    }
}
