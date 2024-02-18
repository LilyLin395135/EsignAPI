using FluentValidation;

namespace Esigning.Service
{
    /// <summary>
    /// 建立同業合作契約請求參數驗證器
    /// </summary>
    public class CreateCobrokeLetterRequestValidator : AbstractValidator<CreateCobrokeLetterRequest>
    {
        /// <summary>
        /// 建構式
        /// </summary>
        public CreateCobrokeLetterRequestValidator()
        {
            //CreatedUserId長度不是6碼&沒有填寫就會出現錯誤訊息
            RuleFor(x => x.CreatedUserId).Length(6).WithMessage("CreatedUserId must be 6 digits in length.")
            .NotNull().NotEmpty().WithMessage("EmployeeNumber cannot be null and empty.");
        }
    }
}