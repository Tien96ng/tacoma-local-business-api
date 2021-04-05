# <div align="center"> **Tacoma Local Business API** </div>
### <div align="center"> An API that functions as a current directory for Local Businesses from in Tacoma, Washington. </div>


### _Contributor(s) and Contact Info_ 
> Tien Nguyen [GitHub](https://github.com/Tien96ng)

---

## _Technologies Used_ ⚙

* **C# 9.0**
* **.NET 5.0.102**
* **My SQL 8.0.19 / WorkBench 8.0.19**
* **Entity Framework**
* **Postman**

---

## _Description_ 📃
An API that functions as a current directory for Local Businesses from in Tacoma, Washington. It utilizes RESTful principles and has integrated authentication via JWT Bearer to keep the API Read-Only for all users except administrators. The user is able to see / use the GET method to fetch API JSON data when using Postman or any API Viewer.

---

## _Installation Guide_ 💻 

<details>
<summary>Open for full Guide</summary>

### _Cloning and Initial Setup_

> Repository: 
1. In your terminal of choice or [GitHub's Desktop Application](https://desktop.github.com/), clone the above repository from Github. For further explanation on how to clone this repository, please visit [GitHub's Documentation](https://docs.github.com/en/github/using-git/which-remote-url-should-i-use).
2. Ensure you are running .NET Core SDK by using the command dotnet --version in your terminal. If a version number is not presented, please visit [this download page for .NET 5 and install the applicable software for your OS](https://dotnet.microsoft.com/download/dotnet/5.0). 
3. Once you verify you are running a .NET 5, navigate in your terminal to ***Local Business API*** directory within the ***Tacoma-Local-Business-Api*** directory you just cloned. Once there, run "dotnet build" in your terminal to build application within directory. 
4. In your terminal, while still in LocalBusinessApi directory, run "dotnet restore."
5. You will require a text or code editor to complete the following steps. [VS Code is recommended](https://code.visualstudio.com/)


### _Installation: Database Recreation_

1. Ensure you are running MySQL Server 8 and MySQL WorkBench 8. If you are running windows, use the [Windows Installer ](https://dev.mysql.com/downloads/installer/) for MySQL and follow the instructions provided by the installer. For Macs, visit [MySQL Commuinity Downloads](https://dev.mysql.com/downloads/mysql/) and select macOS from the Operation Systems. This will be a manual installation. If you need additonal assistance on this, please visit Epicodus's [Learn How to Program Article](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql).
2. Once you verify you have SQL installed, create a file called "appsettings.json" in the root directory LocalBusinessApi. Paste the following into this file.
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port={PORT OF SERVER};database=local_business_api;uid=root;pwd={PASSWORD OF SERVER};"
  }
}
```
3. In your terminal, run "dotnet ef database update".

</details>

---

## _API Use Guide_

<details>
<summary> Open for full Guide </summary>

### Install Postman
> (Optional) [Download and install Postman](https://www.postman.com/downloads/).

### Launch the API
1) Navigate to tacoma-local-business-api/LocalBusinessApi directory using the MacOS Terminal or Windows Powershell (e.g. **cd Desktop/tacoma-local-business-api/LocalBusinessApi**).
2) Run the command **dotnet run** to have access to the API in Postman or browser.

### Using the JSON Web Token
> In order to be authorized to use the POST, PUT, DELETE functionality of the API, please authenticate yourself through Postman.
1. Open Postman and create a POST request using the URL: `http://localhost:5000/api/businesses/authenticate`
2. Add the following query to the request as raw data in the Body tab:
```
{
    "UserName": "Admin",
    "Password": "epicodus"
}
```
3. The token will be generated in the response.
4. Copy the Token from the response (2 hour TTL).
5. Switch to the **authorization** tab in Postman.
6. Choose the type: **Bearer Token** and paste the copied Token into the **Token** field.
7. Run a request for any authorize route request (Ex. POST, PUT, or DELETE).

### Endpoints
> Base URL: `https://localhost:5000`

#### HTTP Request Structure
```
GET /api/businesses
POST /api/businesses
GET /api/businesses/{id}
PUT /api/businesses/{id}
DELETE /api/businesses/{id}
```

#### Example Query
```
https://localhost:5000/api/businesses/30
```

#### Sample JSON Response
```
{
    "Id": 131,
    "Name": "Spiced Cold Brew",
    "Ingredient": "Cinnamon, Nutmeg, Cayenne",
    "Recipe Text: "Coffee is the answer to all solutions in the known universe as proven by leading scientists.",
}
```

</details>

---

## _Known Bugs_ 🩹
* No known bugs at this time (4/02/2021). Please contact a contributor to report any bugs found during use.

---

## _Future Updates_ 🛠
* Add a RANDOM endpoint that randomly returns a business
* Add API pagination.
* Add API Versioning.
* Add CORS to API

---

## _License_ ⚖️

[![MIT license](https://img.shields.io/badge/License-MIT-blue.svg)](https://opensource.org/licenses/MIT)

Copyright (c) 2021 Tien Nguyen.

Please contact Contributor for further use information or if you would like to make a contribution.