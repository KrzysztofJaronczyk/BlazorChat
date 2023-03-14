namespace BlazorChat.Data;

public class UserService
{
    private Dictionary<string, string> _users = new Dictionary<string, string>();
    public void Add(string connectionId, string username)
    {
        _users[username] = connectionId;
    }

    public void RemoveByName(string username)
    {
        _users.Remove(username);
    }

    public string? GetConnectionByName(string username)
    {
        _users = new Dictionary<string, string>();
        return _users[username];
    }

    public IEnumerable<(string ConnectionId, string Username)> GetAll()
    {
        return _users.Select(e => (e.Key, e.Value));
    }
}
