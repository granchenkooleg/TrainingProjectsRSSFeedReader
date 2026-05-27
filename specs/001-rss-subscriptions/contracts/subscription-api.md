# Subscription API Contract

## Endpoints

### GET /api/subscriptions
Returns the current list of subscriptions.

Response 200 OK

```json
[
  {
    "url": "https://example.com/feed.xml",
    "createdAt": "2026-05-27T14:00:00Z"
  }
]
```

### POST /api/subscriptions
Adds a new subscription to the in-memory list.

Request body

```json
{
  "url": "https://example.com/feed.xml"
}
```

Responses

- `201 Created`
  - Body: Created subscription object.
- `400 Bad Request`
  - Body: Error payload when `url` is missing or empty.

```json
{
  "error": "Subscription URL is required."
}
```

## API Contract Notes
- The backend must support JSON request and response payloads.
- The frontend should handle 400 responses and display a simple validation message.
- CORS must allow the frontend origin used during local development.
