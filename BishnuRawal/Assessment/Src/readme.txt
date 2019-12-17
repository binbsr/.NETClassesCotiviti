The Application Core holds the business model, which includes entities, services, and interfaces.
Application Core types: 
    Entities (business model classes that are persisted)
    Interfaces (abstractions for operations that will be performed using Infrastructure)
    Services
    DTOs

################################################################################################################

The Infrastructure project typically includes data access implementations. 
Infrastructure types:
    EF Core types (DbContext, Migration)
    Data access implementation types (Repositories)
    Infrastructure-specific services (for example, FileLogger or SmtpNotifier)

################################################################################################################

The Web/UI layer in an ASP.NET Core MVC application is the entry point for the application.
Web layer types:
    Controllers
    Filters
    Views
    ViewModels
    Startup

Interact with infrastructure strictly through interfaces defined in Application Core.
No direct instantiation of or static calls to the Infrastructure layer types should be allowed in the UI layer.

The Startup class is responsible for configuring the application, and for wiring up implementation types to 
interfaces, allowing dependency injection to work properly at run time.

#################################################################################################################

For monolithic applications the Application Core, Infrastructure, and UI projects are all run as a single application.
