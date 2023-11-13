using TanvirArjel.EFCore.GenericRepository;

namespace MySqlTest.Data;

public class AuthUserRepository : IAuthUserRepository
{
    private readonly IRepository _repository;
    private readonly DatabaseContext _databaseContext;

    public AuthUserRepository(IRepository<DatabaseContext> repository,
        DatabaseContext databaseContext)
    {
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        _databaseContext = databaseContext ?? throw new ArgumentNullException(nameof(databaseContext));
    }

    public Task<IReadOnlyCollection<AuthUser>> GetAllAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<AuthUser?> GetByUsernameAsync(string username, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task CreateOrUpdateAsync(AuthUser entity, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}