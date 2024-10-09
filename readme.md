# GitHub Activity Console Application

Project Task URL: https://roadmap.sh/projects/github-activity

.NET 8.0 Console app solution for the GitHub Activity [challenge](https://roadmap.sh/projects/github-user-activity) from [roadmap.sh](https://roadmap.sh/).

GitHub Activity Console Application is a simple tool designed to help you fetch and display GitHub activities for any user. This application interacts with the GitHub API to retrieve and categorize recent events related to a user's repositories.

## Features

- **Fetch GitHub Activity**: Retrieve recent GitHub activities for a specified user.
- **Activity Categorization**: Display activities categorized by type:
    - Repository creation
    - Push events
    - Pull requests
    - Issue comments
    - Issues opened
## Installation

To run this application, follow these steps:

1. Clone this repository:
    ```bash
    git clone https://github.com/Mohamed2Sherif/GitHub-User-Activity.git
    ```

2. Navigate to the project directory:
    ```bash
    cd GitHubActivity
    ```

3. Restore dependencies:
    ```bash
    dotnet restore
    ```

4. Build the project:
    ```bash
    dotnet build
    ```

5. Run the application:
    ```bash
    dotnet run <UserName>
    ```

### Example Usage

```bash
Enter Command: dotnet run damonsahil26
Created 2 new repositories called Hello-World & Spoon-Knife
Pushed 3 new changes in repositories Hello-World & Spoon-Knife
Opened 1 new pull request in repository Spoon-Knife
Added 4 new comments in repositories Hello-World & Spoon-Knife
Starred Hello-World & Spoon-Knife
