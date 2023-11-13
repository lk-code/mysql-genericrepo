namespace MySqlTest.Data;

public interface IAuthUserRepository
{
    Task<IReadOnlyCollection<AuthUser>> GetAllAsync(CancellationToken cancellationToken);
    Task<AuthUser?> GetByUsernameAsync(string username, CancellationToken cancellationToken);
    Task CreateOrUpdateAsync(AuthUser entity, CancellationToken cancellationToken);
}