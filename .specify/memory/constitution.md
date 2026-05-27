<!--
Sync Impact Report
Version change: none → 1.0.0
Modified principles: added all principles for project-specific governance
Added sections: Additional Constraints, Development Workflow
Removed sections: none
Templates requiring updates: .specify/templates/plan-template.md ✅ checked, .specify/templates/spec-template.md ✅ checked, .specify/templates/tasks-template.md ✅ checked
Follow-up TODOs: none
-->

# TrainingProjectsRSSFeedReader Constitution

## Core Principles

### I. MVP First, No Feature Bloat
The project MUST focus on the minimal subscription-management MVP. Every design decision is evaluated by whether it directly supports adding a feed URL and showing the subscription list.
- Keep the first delivery local-only and in-memory.
- Defer feed fetching, persistence, and item rendering until Extended-MVP.
- Reject complexity that is not required for the current MVP scope.

### II. Secure-by-Default Local Execution
The app MUST minimize its attack surface and avoid unsafe defaults while running locally.
- The backend MUST only expose the API needed for subscription create/read operations.
- CORS and frontend configuration MUST be explicit and limited to the local development origins in use.
- Data handling MUST avoid injecting or executing untrusted content from external feeds in the MVP.

### III. Maintainable Separation of Concerns
The architecture MUST remain clean, explicit, and easy to change as the project evolves.
- Frontend and backend responsibilities MUST be clearly separated: UI and user interaction in Blazor, subscription management logic in ASP.NET Core API.
- Business logic MUST be isolated from presentation, enabling future persistence and feed-fetching changes without UI rewrite.
- The codebase MUST avoid deep coupling between layers and prefer simple abstractions over premature generalization.

### IV. Quality Through Verification
The project MUST validate behavior through automated checks and repeatable local verification.
- Build and run the frontend/backend before merging changes.
- Add unit or component-level tests for any non-trivial service or API behavior introduced during MVP development.
- Document the verification steps needed to confirm working subscription add/list behavior.

### V. Clear Code and Documentation
All code and documentation MUST remain readable, purposeful, and sufficient for future extension.
- Code MUST use descriptive names, consistent style, and minimal ceremony.
- Comments and docs MUST explain why a choice was made, not just what the code does.
- Stakeholder and setup documentation MUST reflect the current MVP assumptions and any deferred work.

## Additional Constraints
The project MUST follow these constraints for the current phase:
- Use ASP.NET Core Web API for backend and Blazor WebAssembly for frontend.
- MVP storage MUST be in-memory only; no database or persistent storage is required for initial delivery.
- No feed HTTP fetching or RSS/Atom parsing in MVP; the first release is subscription list management only.
- The frontend MUST use only one root route for the MVP page and remove default Blazor demo pages before implementation.
- Port configuration and CORS policies MUST be coordinated between backend launch settings, frontend appsettings, and local development origins.

## Development Workflow
The team MUST follow a disciplined workflow for changes and reviews:
- Every change MUST be made through a pull request with a clear description of the scope and testing performed.
- PRs MUST include verification steps for the feature, such as running the app locally and confirming the subscription list updates.
- Code review MUST verify that the change respects the MVP scope, maintains the separation of concerns, and does not add unnecessary complexity.
- Documentation updates in README or stakeholder docs MUST accompany any deviation from the current MVP assumptions.

## Governance
This constitution supersedes informal practices for this project. Amendments require a documented PR and explicit approval from the project owner.
- Any change to a principle or core constraint MUST be recorded in this file and versioned.
- Version bumps MUST follow semantic versioning: 1.0.0 for initial adoption, minor increments for added principles or sections, patch increments for wording clarifications.
- The constitution MUST be reviewed whenever the project expands beyond the current MVP or adds persistence, background processing, or feed-fetching behavior.

**Version**: 1.0.0 | **Ratified**: 2026-05-27 | **Last Amended**: 2026-05-27
