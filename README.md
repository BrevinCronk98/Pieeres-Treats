# **Pieeres Treats**

#### Author: **_Brevin Cronk_**
#### June 5, 2020



### Description

_The purpose of this project is to create a C# web application and employ database basics with MySQL, Entity, and Identity. It also demonstrates the use of MVC routes that follow RESTful convention. This application takes user input to display different Treats and Flavors that belong to in a many to many relationship._

### Instructions for use:

1. Open Terminal (macOS) or PowerShell (Windows)
2. To download the project directory to your desktop enter the following commands:
```
cd Desktop
git clone https://github.com/.git
cd Pierres-Treats (or the file name you created for the main directory of the download)
```
3. To view the downloaded files, open them in a text editor or IDE of your choice.
* if you have VSCode for example, when your terminal is within the main project directory you can open all of the files with the command:
```
code .
```
4. Create a file within the Pieeres folder named appsettings.json.
5. Add the following code:
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=pieeres;uid=root;pwd=YOURMYSQLPASSWORDHERE;"
  }
}
```
* Make any other changes needed if you have an alternative server, port, or uid selected. These are the default settings.

5. If you need to install the REPL dotnet script enter the following command in your terminal: 
```
dotnet tool install -g dotnet-script
```
6. To install the necessary dependencies and start a local host, after replicating the database steps below run the following commands:
```
dotnet restore
dotnet build
dotnet run
```

#### If you need to install and configure MySQL:
1. Download the MySQL Community Server DMG file [here](https://dev.mysql.com/downloads/file/?id=484914) with the "No thanks, just start my download" link.
2. On the configuration page of the installer select the following options:
* Use legacy password encryption
* Set your password
3. Open the terminal and enter the command:
*'export PATH="/usr/local/mysql/bin:$PATH"' >> ~/.bash_profile
4. Download the MySQL Workbench DMG file [here](https://dev.mysql.com/downloads/file/?id=484391)
5. Open Local Instance 3306 with the password you set.

#### To create a local version of the database:
1. Open MySQL Workbench and Local Instance 3306.
2. Select the SQL + button in the top left of the navigation bar.
3. Paste the following in the query section to create the database:

```
CREATE DATABASE `pieeres_treats`;

USE `pieeres_treats`;

CREATE TABLE `flavors` (
  `FlavorId` int(11) NOT NULL AUTO_INCREMENT,
  `TreatId` int(11) NOT NULL DEFAULT '0',
  `Name` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`FlavorId`)
);

CREATE TABLE `treats` (
  `TreatId` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`TreatId`)
);

```

4. Press the lightning bolt button to run this command.
5. If the database does not appear, right click in the schemas bar and select Refresh All.

### Known Bugs

No bugs have been identified at the time of this update.

### Support and Contact Information

Please contact me with any suggestions or questions at cronkbrevin98@gmail.com Thank you for your input!  
_Have a bug or an issue with this application? [Open a new issue](https://github.com) here on GitHub._

### Technologies Used

* C#
* `ASP.NET` Core
* `ASP.NET` Core MVC
* Entity Framework Core
* `ASP.NET` Core Identity
* MySQL
* Git and GitHub

### Specs
| Spec | Input | Output |
| :------------- | :------------- | :------------- |
| **User enters home page** | User Input:"URL: localhost:5000/" | Output: “Welcome!” |
| **User can navigate to a page that lists treats** | User Input:"Click: View Treats" | Output: “Snickers, Candy Apples” |
| **If no directors have been added a message appears** | User Input:"Click: View treats" | Output: “You have no treats listed! Add a few.” |
| **User can navigate to an add directors page** | User Input:"Click: Add treats" | Output: “Create a new treat.” |
| **Users who login can fill out the Add treats form** | User Input:"Enter New Teeat Name: Jelly Doughnut" | Output: “Treats: Jelly Doughnut ” |
| **Users who don't login can't fill out Treat form** | User Input: "Click: Add treats" | Output: "You must be signed in to do that!" |
| **If no flavors have been added a message appears** | User Input:"Click: View flavors" | Output: “You have no flavors listed.” |
| **User who signs in can navigate to a create new flavors page for each treat** | User Input:"Click: Jelly Doughnut Click: Add flavor" | Output: “Flavor Form" |
| **Users who don't login can't fill out Flavor form** | User Input: "Click: Add flavors" | Output: "You must be signed in to do that!" |
| **User who is signed in can delete a treat** | User Input:"Click: Delete Treat" | Output: “You have removed this treat!” |
| **User who is signed in can delete a flavor** | User Input:"Click: Delete flavor" | Output: “You have removed this flavor!” |

### Stretch Goals
N/A at the moment

<!-- &#9745; -->

### Resources


#### License

This software is licensed under the MIT license.

Copyright © 2020 **_Brevin Cronk_**