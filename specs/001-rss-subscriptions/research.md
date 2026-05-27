# Research for RSS Subscriptions MVP

## Decision
Use ASP.NET Core Web API for the backend and Blazor WebAssembly for the frontend. Implement the MVP as an in-memory subscription manager that accepts feed URLs and returns the current list.

## Rationale
- The stakeholder documents define a minimal, local POC and explicitly call for ASP.NET Core + Blazor.
- In-memory storage keeps the MVP simple and reduces implementation risk.
- Delaying feed fetching and parsing keeps the first delivery focused on the primary user value: managing subscriptions.
- Explicit local CORS and port coordination is required for the frontend/backend development workflow.

## Alternatives Considered
1. Add persistence now with a database or file storage.
   - Rejected: The MVP is scoped to in-memory subscription management; persistence is deferred to Extended-MVP.

2. Add feed fetching/parsing in MVP.
   - Rejected: The project goals clearly state that the first release should demonstrate subscription management only.

3. Use a single Blazor Server or all-in-one project.
   - Rejected: The chosen architecture emphasizes separation of concerns and future extensibility with a dedicated API backend.

## Best Practices
- Keep the API contract small and stable: one endpoint to POST subscriptions, one endpoint to GET subscriptions.
- Validate only the input presence and type in MVP; avoid network validation of URLs.
- Remove Blazor template demo pages and verify only one `@page "/"` route exists before implementing the UI.
