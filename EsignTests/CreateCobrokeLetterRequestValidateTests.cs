using FluentValidation.TestHelper;
using Esigning.Service;

namespace EsignTests
{
    /// <summary>
    /// 建立同業合作契約請求參數驗證測試
    /// </summary>
    [TestClass]
    public class CreateCobrokeLetterRequestValidateTests
    {
        /// <summary>
        /// 情境一、驗證建立契據人編號必為6碼
        /// </summary>
        [TestMethod]
        public void CreatedUserId_Not_Six_Number_Is_Invalid()
        {
            // Arrange
            // 加入一個建立契據人編號不為6碼的請求
            var request = new CreateCobrokeLetterRequest
            {
                CreatedUserId = "12345"
            };
            // 建立驗證器
            var validator = new CreateCobrokeLetterRequestValidator();

            // Act 執行驗證
            var validateResult = validator.TestValidate(request);

            // Assert 驗證結果
            validateResult.ShouldHaveValidationErrorFor(x => x.CreatedUserId)
                .WithErrorMessage("CreatedUserId must be 6 digits in length.");
        }
    }
}