namespace UserApp.Application.Common.Interfaces.Persistance;

public interface IAuthManager
{
    Task<bool> ValidateUser(string userName, string password);
}