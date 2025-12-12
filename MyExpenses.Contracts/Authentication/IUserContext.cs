namespace MyExpenses.Contracts.Authentication
{
    public interface IUserContext
    {
        Guid GetCurrentUserId();
    }
}
