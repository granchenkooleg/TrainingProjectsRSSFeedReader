# Feature: MVP RSS reader — RSS Subscriptions (rss-subscriptions)

**Feature Branch**: `[001-rss-subscriptions]`

**Created**: 2026-05-27

**Status**: Draft

**Input**: User description: "MVP RSS reader: a simple RSS/Atom feed reader that demonstrates the most basic capability (add subscriptions) without the complexity of a production-ready application."

## User Scenarios & Testing (mandatory)

### User Story 1 - Add Subscription (Priority: P1)
A single local user can add a feed subscription by pasting a URL into the UI and confirming it.

Why this priority: This is the core MVP value — managing a subscription list.

Independent Test: Run the frontend and backend locally; paste a feed URL and click Add; the subscription list updates immediately to include the new URL.

Acceptance Scenarios:
1. Given the app is running locally, when the user pastes a valid URL and presses Add, then the list of subscriptions includes that URL.
2. Given the app is running locally, when the user adds multiple URLs in sequence, then each appears in the list in insertion order.

---

### Edge Cases
- Adding the same URL twice: The system MAY allow duplicates in MVP or MAY deduplicate; this behavior is documented in Assumptions.
- Empty input: The Add action MUST be no-op and provide a user-visible validation message.

## Requirements (mandatory)

### Functional Requirements
- FR-001: System MUST accept a feed URL input and add it to the in-memory subscription list.
- FR-002: System MUST return the current list of subscriptions via an API endpoint.
- FR-003: System MUST display the current list of subscriptions in the UI.
- FR-004: System MUST validate that the input is a non-empty string before adding; no network validation required for MVP.
- FR-005: System MUST preserve subscriptions in memory until the app stops (no persistence required for MVP).

### Key Entities
- Subscription: Represents a subscribed feed URL. Attributes: `url` (string), `createdAt` (timestamp, optional for MVP).

## Success Criteria (mandatory)

### Measurable Outcomes
- SC-001: A user can add a subscription and see it appear in the list within 5 seconds of submitting (local verification).
- SC-002: Manual verification steps complete in under 5 minutes for a new developer to demonstrate the MVP.
- SC-003: 100% of acceptance scenarios listed above are reproducible in local testing.

## Assumptions
- The MVP targets a single local user; no authentication or multi-user concerns apply.
- Feed URLs are assumed valid by the user; no network fetching/validation or parsing occurs in MVP.
- Subscriptions are stored in-memory and lost on process restart.
- UI routing will be cleaned up to ensure only one `@page "/"` exists before implementation (see TechStack notes).


## Notes
- Extended-MVP will add feed fetching, parsing, persistence, and item display.
- This spec intentionally avoids implementation details (libraries, project layout) beyond the selected stack in `TechStack.md` which documents project-level choices.
