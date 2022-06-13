Development - Code, unit tests
QA/Tst - Testers (Manual, Automated)
UAT - User Acceptance Testing
Prod - Live version

## ORM tool
EF Core --> Entity Framework Core tool

#Database Access
* EF CORE
	* Database-first approach
	* Code-first approach - I have used this one with migrations commands


packet manager: nuget.org

1. Install 3 packages
EF framework
EF core sql
EF Core design

2. Add dbcontect class
3. In program.cs
'''
builder.Services.AddDbContext<AssignmentMgmtDb>(options => 
			options.UseSqlite("Data Source=AssignmentDb.db")
		);
'''

	• dotnet ef migrations add InitialDbCreation
	• Dotnet ef database update
