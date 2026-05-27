using Microsoft.AspNetCore.Mvc;
using RSSFeedReader.Api.Models;
using RSSFeedReader.Api.Services;

namespace RSSFeedReader.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public sealed class SubscriptionsController : ControllerBase
{
    private readonly SubscriptionStore _store;

    public SubscriptionsController(SubscriptionStore store)
    {
        _store = store;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Subscription>> Get()
    {
        return Ok(_store.GetAll());
    }

    [HttpPost]
    public ActionResult<Subscription> Post([FromBody] SubscriptionRequest? request)
    {
        if (request is null || string.IsNullOrWhiteSpace(request.Url))
        {
            return BadRequest(new { error = "Subscription URL is required." });
        }

        var subscription = _store.Add(request.Url);
        return CreatedAtAction(nameof(Get), subscription);
    }
}

public sealed class SubscriptionRequest
{
    public string? Url { get; set; }
}
