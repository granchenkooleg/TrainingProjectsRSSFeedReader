using RSSFeedReader.Api.Models;

namespace RSSFeedReader.Api.Services;

public sealed class SubscriptionStore
{
    private readonly List<Subscription> _items = new();
    private readonly object _lock = new();

    public Subscription Add(string url)
    {
        var subscription = new Subscription(url.Trim(), DateTime.UtcNow);
        lock (_lock)
        {
            _items.Add(subscription);
        }
        return subscription;
    }

    public IReadOnlyCollection<Subscription> GetAll()
    {
        lock (_lock)
        {
            return _items.ToList().AsReadOnly();
        }
    }
}
