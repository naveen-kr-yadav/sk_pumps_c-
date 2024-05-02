using MotorizedMarvels.Models;

namespace MotorizedMarvels.Services
{
    public interface ILoginService
    {
        Task<LoginDetails> GetLoginDetails();
    }
}
