# Data Model for RSS Subscriptions MVP

## Entities

### Subscription
Represents a single RSS/Atom feed subscription entry.

- `url` (string): The feed URL provided by the user. Required.
- `createdAt` (datetime, optional): Timestamp when the subscription was added. Useful for display and future sorting, but optional for MVP.

## Validation Rules
- `url` must be a non-empty string.
- The backend should reject empty or missing `url` values with a 400 Bad Request.
- No URL format validation or network validation is required in MVP.

## Behavior
- New subscriptions are appended to an in-memory list.
- The frontend can request the full current list at any time.
- No delete, update, or persistence behavior is required for MVP.

## Relationships
- No additional entity relationships are needed for this MVP.
