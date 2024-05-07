using MotorizedMarvels.Models;

namespace MotorizedMarvels.Services
{
    public class LoginService : ILoginService
    {
        private readonly LoginDetails _dummyLoginDetails = new LoginDetails
        {
            UserName = "brajesh",
            Password = "brajesh@123",
            Email = "brajesh@gmail.com",
            Phone = 987654321,
            PhoneNumber = 00098765432
        };
        public async Task<LoginDetails> GetLoginDetails()
        {
            //await Task.Delay(100);
            return _dummyLoginDetails;
        }
    }
}
