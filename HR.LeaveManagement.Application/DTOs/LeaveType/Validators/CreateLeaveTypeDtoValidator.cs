using FluentValidation;

namespace HR.LeaveManagement.Application.DTOs.LeaveType.Validators
{
    public class CreateLeaveTypeDtoValidator : AbstractValidator<ILeaveTypeDto>
    {
        public CreateLeaveTypeDtoValidator()
        {
            Include(new ILeaveTypeDtoValidator());


        }
    }
}
