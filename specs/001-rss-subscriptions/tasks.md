# Tasks: RSS Subscriptions

**Input**: Design documents from `specs/001-rss-subscriptions/`

**Prerequisites**: `plan.md`, `spec.md`, `research.md`, `data-model.md`, `contracts/subscription-api.md`

## Phase 1: Setup (Shared Infrastructure)

**Purpose**: Establish the web application structure and local development configuration.

- [X] T001 Create backend project structure in `backend/RSSFeedReader.Api/`
- [X] T002 Create frontend project structure in `frontend/RSSFeedReader.UI/`
- [X] T003 [P] Configure frontend appsettings in `frontend/RSSFeedReader.UI/wwwroot/appsettings.json`
- [X] T004 [P] Configure backend CORS and API base path in `backend/RSSFeedReader.Api/Program.cs`
- [X] T019 [P] Create backend launch settings in `backend/RSSFeedReader.Api/Properties/launchSettings.json`
- [X] T020 [P] Create frontend launch settings in `frontend/RSSFeedReader.UI/Properties/launchSettings.json`

---

## Phase 2: Foundational (Blocking Prerequisites)

**Purpose**: Build the shared backend/frontend infrastructure required before implementing the subscription story.

- [X] T005 Create `backend/RSSFeedReader.Api/Models/Subscription.cs` to model subscription data.
- [X] T006 Create `backend/RSSFeedReader.Api/Services/SubscriptionStore.cs` with in-memory add/list storage.
- [X] T007 Create `backend/RSSFeedReader.Api/Controllers/SubscriptionsController.cs` with `GET /api/subscriptions` and `POST /api/subscriptions` endpoints.
- [X] T008 Create `frontend/RSSFeedReader.UI/Program.cs` setup with `HttpClient` configured from appsettings.
- [X] T009 Create `frontend/RSSFeedReader.UI/Pages/Subscriptions.razor` as the only root page for the MVP.

---

## Phase 3: User Story 1 - Add Subscription (Priority: P1)

**Goal**: Enable a local user to add a feed URL and see it immediately in the subscription list.

**Independent Test**: Run the backend and frontend locally; add a URL in the UI; the list updates with the new subscription.

- [X] T010 [US1] Implement subscription input UI in `frontend/RSSFeedReader.UI/Pages/Subscriptions.razor`.
- [X] T011 [US1] Implement `SubscriptionForm` validation for non-empty URL input in `frontend/RSSFeedReader.UI/Pages/Subscriptions.razor`.
- [X] T012 [US1] Implement `GET /api/subscriptions` integration in `frontend/RSSFeedReader.UI/Pages/Subscriptions.razor`.
- [X] T013 [US1] Implement `POST /api/subscriptions` integration in `frontend/RSSFeedReader.UI/Pages/Subscriptions.razor`.
- [X] T014 [US1] Add frontend error handling and validation feedback in `frontend/RSSFeedReader.UI/Pages/Subscriptions.razor`.
- [X] T015 [US1] Add backend request validation and 400 response handling in `backend/RSSFeedReader.Api/Controllers/SubscriptionsController.cs`.

---

## Phase 4: Polish & Cross-Cutting Concerns

**Purpose**: Finalize the MVP with cleanup, documentation, and verification.

- [X] T016 [P] Remove any default Blazor demo pages and routes from `frontend/RSSFeedReader.UI/Pages/`
- [X] T017 [P] Update `README.md` or `specs/001-rss-subscriptions/quickstart.md` with exact run and verification steps.
- [X] T018 [P] Verify local end-to-end behavior using the feature quickstart in `specs/001-rss-subscriptions/quickstart.md`.

---

## Dependencies & Execution Order

- Setup (Phase 1) must complete before Foundational (Phase 2).
- Foundational (Phase 2) must complete before User Story 1 (Phase 3).
- Polish (Phase 4) depends on completion of the MVP behavior in Phase 3.

## Parallel Opportunities

- `T003` and `T004` can run in parallel because they configure separate frontend and backend files.
- `T006` and `T007` can run in parallel if the backend service and controller are developed independently.
- `T016`, `T017`, and `T018` can run in parallel as final cleanup and documentation tasks.

## Summary

- Total task count: 20
- User Story 1 task count: 6
- Suggested MVP scope: complete only Phase 1, Phase 2, and Phase 3 to deliver add/list subscription behavior.
- Independent test criteria: add a URL and verify the updated list in the UI, with memory-only storage until restart.
