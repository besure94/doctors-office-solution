## Doctors Office

#### A web application that allows users to create medical specialties, doctors, and patients with many-to-many relationships.

#### By Brian Scherner

## Technologies Used

* C#
* .NET
* ASP.NET MVC
* MySQL
* EF Core
* EF Migrations

## Description

This application presents users with a home page for a Doctor's Office, where they can view a list of patients and a list of medical specialties. To add a doctor to the office's system, they must first create a specialty. Users can navigate to the specialties list, and then to a form where they can create a specialty to add to the list. Once a specialty is added, they can select it, and navigate to a form to create a new doctor for that specific specialty.

Since a specialty can contain many doctors, users can also navigate to a form where they can select an existing doctor and add it to a specific specialty. Users can navigate to a list of doctors, and then to a form where they can add more doctors. When a user views a list of the doctors, they can see how many patients each doctor is currently seeing, if there currently are any.

Users can also view the patients list and then add new patients to it by filling out a form. When a user selects a patients details, they can see a list of all the doctors that specific patient sees.

## Setup Instructions

### Install Tools

Install the tools that are introduced in [this series of lessons on LearnHowToProgram.com](https://old.learnhowtoprogram.com/fidgetech-3-c-and-net/3-0-lessons-1-5-getting-started-with-c/3-0-0-01-welcome-to-c).

### Set Up and Run Project

1. Clone this repository to your desktop.
2. Open the terminal and navigate to this project's production directory called `DoctorsOffice`.
3. Within the production directory `DoctorsOffice`, create a new file called `appsettings.json`.
4. Within `appsettings.json`, put in the following code, replacing the `uid` and `pwd` values with your own username and password for MySQL. For the LearnHowToProgram.com lessons, always assume the `uid` is `root` and the `pwd` is `epicodus`.

```json
{
    "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=doctors_office_with_many_to_many;uid=root;pwd=epicodus;"
    }
}
```

5. Create the database using the migrations in the Doctors Office project. Open your terminal to the production directory called `DoctorsOffice`, and run `dotnet ef database update`.
    * If you need to create your own migration, run the command `dotnet ef migrations add MigrationName`, where `MigrationName` is your custom name for the migration in UpperCamelCase format.

6. Within the production directory called `DoctorsOffice`, run `dotnet watch run` in the command line to start the project in development mode with a watcher.
7. Open the browser to [https://localhost:5001](https://localhost:5001). If you cannot access localhost:5001 it is likely because you have not configured a .NET developer security certificate for HTTPS. To learn about this, review this LearnHowToProgram lesson: [Redirecting to HTTPS and Issuing a Security Certificate](https://old.learnhowtoprogram.com/fidgetech-3-c-and-net/3-2-basic-web-applications/3-2-0-17-redirecting-to-https-and-issuing-a-security-certificate).

## Known Bugs

Application is fully functional. I think I could update the organization of the route links in the views later on, though.

## License

MIT

Copyright(c) 2023 Brian Scherner