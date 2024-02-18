using FluentValidation.TestHelper;
using Esigning.Service;

namespace EsignTests
{
    /// <summary>
    /// �إߦP�~�X�@�����ШD�Ѽ����Ҵ���
    /// </summary>
    [TestClass]
    public class CreateCobrokeLetterRequestValidateTests
    {
        /// <summary>
        /// ���Ҥ@�B���ҫإ߫��ڤH�s������6�X
        /// </summary>
        [TestMethod]
        public void CreatedUserId_Not_Six_Number_Is_Invalid()
        {
            // Arrange
            // �[�J�@�ӫإ߫��ڤH�s������6�X���ШD
            var request = new CreateCobrokeLetterRequest
            {
                CreatedUserId = "12345"
            };
            // �إ����Ҿ�
            var validator = new CreateCobrokeLetterRequestValidator();

            // Act ��������
            var validateResult = validator.TestValidate(request);

            // Assert ���ҵ��G
            validateResult.ShouldHaveValidationErrorFor(x => x.CreatedUserId)
                .WithErrorMessage("CreatedUserId must be 6 digits in length.");
        }
    }
}