using Shared.Models;

namespace Shared.DTOs;

public interface IUserLogic
{
    Task<User> CreateAsync(UserCreationDto userToCreate);
}
