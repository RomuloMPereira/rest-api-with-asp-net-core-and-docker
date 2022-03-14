using RestWithASPNETUdemy.Data.VO;
using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Repositories
{
    public interface IUserRepository
    {
        User ValidateCredentials(UserVO user);
        User RefreshUserInfo(User user);
    }
}
