# Quickstart: RSS Subscriptions MVP

## Prerequisites
- .NET SDK 8 or later installed
- Git installed (optional, but recommended for repository management)

## Setup
1. From the repository root, scaffold the backend and frontend projects if they are not present yet:

```bash
dotnet new webapi -o backend/RSSFeedReader.Api
dotnet new blazorwasm -o frontend/RSSFeedReader.UI
```

2. Configure the backend and frontend ports explicitly:
- Backend should listen on a local port such as `http://localhost:5151`
- Frontend should run on a local origin such as `http://localhost:5213`

3. Update the frontend API base URL in `frontend/RSSFeedReader.UI/wwwroot/appsettings.json`:

```json
{ "ApiBaseUrl": "http://localhost:5151/api/" }
```

4. Configure backend CORS to allow the frontend origin in `backend/RSSFeedReader.Api/Program.cs`.

## Run Locally
1. Start the backend:

```bash
dotnet run --project backend/RSSFeedReader.Api
```

2. Start the frontend:

```bash
dotnet run --project frontend/RSSFeedReader.UI
```

3. Open the frontend in the browser at the port shown by the Blazor app (for example, `http://localhost:5213`).

## Verify MVP Behavior
- Enter a feed URL into the add subscription input.
- Click Add.
- Confirm the list updates immediately with the entered URL.
- Repeat with additional URLs to verify the list is preserved in memory while the app runs.

## Notes
- Subscription data is stored in memory only and is lost when the backend restarts.
- The first MVP does not fetch or display feed items.
