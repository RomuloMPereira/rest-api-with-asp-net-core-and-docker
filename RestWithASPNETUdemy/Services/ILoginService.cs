using RestWithASPNETUdemy.Data.VO;

namespace RestWithASPNETUdemy.Services
{
    public interface ILoginService
    {
        TokenVO ValidateCredentials(UserVO user);
    }
}
