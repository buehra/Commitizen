using Microsoft.EntityFrameworkCore.Migrations;

namespace Commitizen.Data.Migrations
{
    public partial class SeedChangeTypesAndScopesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            // Add default Change Types
            migrationBuilder
                .Sql("INSERT INTO ChangeType (Name, Description, Active) Values ('build', 'Changes that affect the build system or external dependencies (example scopes: gulp, broccoli, npm)', 1)");
            migrationBuilder
                .Sql("INSERT INTO ChangeType (Name, Description, Active) Values ('ci', 'Changes to our CI configuration files and scripts (example scopes: Travis, Circle, BrowserStack, SauceLabs)', 1)");
            migrationBuilder
                .Sql("INSERT INTO ChangeType (Name, Description, Active) Values ('docs', 'Documentation only changes', 1)");
            migrationBuilder
                .Sql("INSERT INTO ChangeType (Name, Description, Active) Values ('feat', 'A new feature', 1)");
            migrationBuilder
                .Sql("INSERT INTO ChangeType (Name, Description, Active) Values ('fix', 'A bug fix', 1)");
            migrationBuilder
                .Sql("INSERT INTO ChangeType (Name, Description, Active) Values ('perf', 'A code change that improves performance', 1)");
            migrationBuilder
                .Sql("INSERT INTO ChangeType (Name, Description, Active) Values ('refactor', 'A code change that neither fixes a bug nor adds a feature', 1)");
            migrationBuilder
                .Sql("INSERT INTO ChangeType (Name, Description, Active) Values ('style', 'Changes that do not affect the meaning of the code (white-space, formatting, missing semi-colons, etc)', 1)");
            migrationBuilder
                .Sql("INSERT INTO ChangeType (Name, Description, Active) Values ('test', 'Adding missing tests or correcting existing tests', 1)");
            migrationBuilder
                .Sql("INSERT INTO ChangeType (Name, Description, Active) Values ('revert', 'Revert code', 1)");
            migrationBuilder
                .Sql("INSERT INTO ChangeType (Name, Description, Active) Values ('chore', 'Needed tasks (example: update framework version)', 1)");

            // Add default Scopes
            migrationBuilder
                .Sql("INSERT INTO Scope (Name, Description, Active) Values ('gulp', 'Frontend build system', 1)");
            migrationBuilder
                .Sql("INSERT INTO Scope (Name, Description, Active) Values ('repository', 'Repositories', 1)");
            migrationBuilder
                .Sql("INSERT INTO Scope (Name, Description, Active) Values ('service', 'Services', 1)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM ChangeTypes");

            migrationBuilder.Sql("DELETE FROM Scopes");

        }
    }
}
