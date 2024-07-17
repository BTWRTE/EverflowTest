-Setup Instructions-
Change the default connection in EverflowTest/appsettings.json to point to your local server
From the Package Manager Console, select the 'DAL' project and run 'update-database'
Run the solution via IIS Express

-API Documentation-
The solution is made up of two assemblies, containing the following:
- DAL
	- Migrations
	- Entities
	- Entity Configurations
	- Repositories
	- Repository Interfaces
	- Models
	- AutoMapper Profiles

- EverflowTest
	- Services
	- Service Interfaces
	- View Models
	- Blazor Pages & Components
	- appsettings.json

Routing is handled by the Blazor components, which make calls to the services
The services then call the repositories, which perform CRUD methods against an SQL database

-Security and Scalability-
Security will be handled via [Authorisation] attributes set to the Blazor pages & services
User permissions/roles will be added to restrict add/edit/delete functions to the appropriate users
New pages and features can be added with minimal changes to existing code, by simply adding new entities, repositories, services & components
