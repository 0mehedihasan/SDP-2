# 🩸 Blood Bank Management System

> A desktop application built with **C# Windows Forms** and **MS SQL Server** for managing blood bank operations — including donor registration, user administration, blood inventory tracking, and a real-time dashboard.

[![License: MIT](https://img.shields.io/badge/License-MIT-red.svg)](LICENSE)
[![.NET Framework](https://img.shields.io/badge/.NET_Framework-4.8-blue.svg)](https://dotnet.microsoft.com/download/dotnet-framework/net48)
[![SQL Server](https://img.shields.io/badge/SQL_Server-2014+-orange.svg)](https://www.microsoft.com/en-us/sql-server)
[![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg)](CONTRIBUTING.md)

---

## 📋 Table of Contents

- [About the Project](#-about-the-project)
- [Features](#-features)
- [Technology Stack](#-technology-stack)
- [Architecture](#-architecture)
- [Project Structure](#-project-structure)
- [Database Schema](#-database-schema)
- [Getting Started](#-getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
  - [Database Setup](#database-setup)
  - [Configuration](#configuration)
  - [Running the Application](#running-the-application)
- [Usage Guide](#-usage-guide)
- [Contributing](#-contributing)
- [License](#-license)
- [Acknowledgements](#-acknowledgements)

---

## 📖 About the Project

The **Blood Bank Management System** is a Windows Forms desktop application that simplifies blood bank operations. It helps blood bank staff manage donor information, track blood inventory by blood group, administer system users, and view real-time statistics — all through an intuitive graphical interface.

This project follows a clean **3-Tier Architecture** (UI → BLL → DAL) to separate concerns between the user interface, business logic, and data access layers.

**Developed by:** Group-02 | Software Development Project-2 (SDP-2)

---

## ✨ Features

| Module | Capabilities |
|---|---|
| **🔐 Authentication** | Secure login system with username/password validation |
| **👤 User Management** | Add, update, delete, and search system users (staff/admins) |
| **🩸 Donor Management** | Register donors with personal details, blood group, and contact info |
| **📦 Blood Inventory** | Track blood stock quantities across all 8 blood groups |
| **📊 Dashboard** | Real-time donor counts by blood group (O+, O−, A+, A−, B+, B−, AB+, AB−) |
| **🔍 Search** | Search donors and users by name, ID, email, blood group, and more |
| **🎬 Splash Screen** | Animated loading screen on application startup |
| **📝 Audit Trail** | Tracks which user added each donor record |

---

## 🛠 Technology Stack

| Layer | Technology |
|---|---|
| **Language** | C# (C Sharp) |
| **UI Framework** | Windows Forms (WinForms) |
| **Runtime** | .NET Framework 4.8 |
| **Database** | Microsoft SQL Server 2014+ |
| **Authentication** | Windows Integrated Security |
| **IDE** | Microsoft Visual Studio 2015+ |
| **DB Management** | SQL Server Management Studio (SSMS) |
| **Version Control** | Git & GitHub |

---

## 🏗 Architecture

This project implements the **3-Tier Architecture** pattern, ensuring a clean separation of concerns:

```
┌─────────────────────────────────────────────────────┐
│                  PRESENTATION LAYER                  │
│              (UI - Windows Forms)                    │
│                                                     │
│  frmSplash → frmLogin → frmHome ─┬─ frmUsers       │
│                                   ├─ frmDonors      │
│                                   └─ frmInventory   │
└──────────────────────┬──────────────────────────────┘
                       │
┌──────────────────────▼──────────────────────────────┐
│               BUSINESS LOGIC LAYER                   │
│                  (BLL - Models)                      │
│                                                     │
│        userBLL    donorBLL    loginBLL               │
│                 inventoryBLL                         │
└──────────────────────┬──────────────────────────────┘
                       │
┌──────────────────────▼──────────────────────────────┐
│                DATA ACCESS LAYER                     │
│            (DAL - Database Operations)              │
│                                                     │
│        userDAL    donorDAL    loginDAL               │
│                 inventoryDAL                         │
└──────────────────────┬──────────────────────────────┘
                       │
┌──────────────────────▼──────────────────────────────┐
│              MS SQL SERVER DATABASE                   │
│                                                     │
│    tbl_users    tbl_donors    tbl_inventory          │
└─────────────────────────────────────────────────────┘
```

**Layer Responsibilities:**

- **UI (Presentation):** Windows Forms with DataGridView controls, input validation, and navigation
- **BLL (Business Logic):** Entity/model classes that define properties for each data type
- **DAL (Data Access):** SQL Server queries using `SqlConnection`, `SqlCommand`, and `SqlDataAdapter`

---

## 📁 Project Structure

```
SDP-2/
│
├── Code/                              # Version 1 — Core application (login, users, donors)
│   └── BloodBankManagementSystem/
│       ├── BloodBankManagementSystem.sln
│       ├── database.zip               # Database backup
│       └── BloodBankManagementSystem/
│           ├── BLL/                    # Business Logic Layer
│           │   ├── userBLL.cs
│           │   ├── donorBLL.cs
│           │   └── loginBLL.cs
│           ├── DAL/                    # Data Access Layer
│           │   ├── userDAL.cs
│           │   ├── donorDAL.cs
│           │   └── loginDAL.cs
│           ├── UI/                     # User Interface
│           │   ├── frmSplash.cs        # Splash screen
│           │   ├── frmLogin.cs         # Login form
│           │   ├── frmHome.cs          # Dashboard
│           │   ├── frmUsers.cs         # User management
│           │   └── frmDonors.cs        # Donor management
│           ├── App.config              # Connection string configuration
│           └── Program.cs              # Application entry point
│
├── Extra-Life Saver Code/             # Version 2 — Added donation tracking
│   └── BloodBankManagementSystem-master/
│       ├── BloodBankManagementSystem/  # (same structure as Code/)
│       │   └── UI/frmDonate.cs         # NEW: Donation tracking form
│       └── Database/                   # Database files (.mdf + .ldf)
│
├── new with inventory/                 # Version 3 — Added blood inventory management
│   └── BloodBankManagementSystem-master/
│       ├── BloodBankManagementSystem/
│       │   ├── BLL/inventoryBLL.cs     # NEW: Inventory model
│       │   ├── DAL/inventoryDAL.cs     # NEW: Inventory data access
│       │   └── UI/frminventory.cs      # NEW: Inventory management form
│       └── Database/                   # Database files (.mdf + .ldf)
│
├── Form design/                        # Version 4 — .NET 6.0 modernization
│   └── Blood Bank Management system/
│       ├── Blood Bank Management system.sln
│       └── UI/                         # Redesigned forms for .NET 6.0
│
├── Final Code/                         # Release packages (.rar archives)
├── Final Submission/                   # Project report and presentation
├── Database lab project/               # Proposal drafts and documentation
├── project proposal/                   # Initial project proposals
├── LICENSE                             # MIT License
└── README.md                           # This file
```

---

## 🗄 Database Schema

The application uses **MS SQL Server** with the following tables:

### `tbl_users` — System Users

| Column | Type | Description |
|---|---|---|
| `user_id` | `INT` (PK) | Auto-increment primary key |
| `username` | `VARCHAR` | Unique login username |
| `email` | `VARCHAR` | User email address |
| `password` | `VARCHAR` | User password |
| `full_name` | `VARCHAR` | Full name of the user |
| `contact` | `VARCHAR` | Contact number |
| `address` | `VARCHAR` | Physical address |
| `added_date` | `DATETIME` | Account creation timestamp |

### `tbl_donors` — Blood Donors

| Column | Type | Description |
|---|---|---|
| `donor_id` | `INT` (PK) | Auto-increment primary key |
| `first_name` | `VARCHAR` | Donor's first name |
| `last_name` | `VARCHAR` | Donor's last name |
| `email` | `VARCHAR` | Donor email address |
| `contact` | `VARCHAR` | Phone number |
| `gender` | `VARCHAR` | Gender |
| `address` | `VARCHAR` | Physical address |
| `blood_group` | `VARCHAR` | Blood type (O+, O−, A+, A−, B+, B−, AB+, AB−) |
| `added_date` | `DATETIME` | Registration timestamp |
| `added_by` | `INT` (FK) | References `tbl_users.user_id` |

### `tbl_inventory` — Blood Stock

| Column | Type | Description |
|---|---|---|
| `Quantity_No` | `INT` (PK) | Record identifier |
| `O_positive` | `INT` | O+ blood units |
| `O_negative` | `INT` | O− blood units |
| `A_positive` | `INT` | A+ blood units |
| `A_negative` | `INT` | A− blood units |
| `B_positive` | `INT` | B+ blood units |
| `B_negative` | `INT` | B− blood units |
| `AB_positive` | `INT` | AB+ blood units |
| `AB_negative` | `INT` | AB− blood units |

---

## 🚀 Getting Started

### Prerequisites

Make sure you have the following installed on your Windows machine:

| Software | Version | Download |
|---|---|---|
| **Windows OS** | 10 or later | — |
| **Visual Studio** | 2015 or later | [Download](https://visualstudio.microsoft.com/downloads/) |
| **MS SQL Server** | 2014 or later | [Download](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) |
| **SSMS** | Latest | [Download](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms) |
| **.NET Framework** | 4.8 | [Download](https://dotnet.microsoft.com/download/dotnet-framework/net48) |

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/0mehedihasan/SDP-2.git
   cd SDP-2
   ```

2. **Open the solution**
   - Navigate to the version you want to use:
     - **Version 1 (Basic):** `Code/BloodBankManagementSystem/BloodBankManagementSystem.sln`
     - **Version 2 (+ Donations):** `Extra-Life Saver Code/BloodBankManagementSystem-master/BloodBankManagementSystem.sln`
     - **Version 3 (+ Inventory):** `new with inventory/BloodBankManagementSystem-master/BloodBankManagementSystem.sln`
     - **Version 4 (.NET 6.0):** `Form design/Blood Bank Management system/Blood Bank Management system.sln`
   - Double-click the `.sln` file to open in Visual Studio

### Database Setup

1. **Open SQL Server Management Studio (SSMS)**

2. **Create the database** — Run the following SQL script:
   ```sql
   CREATE DATABASE BloodBankManagementSystem;
   GO
   USE BloodBankManagementSystem;
   GO

   CREATE TABLE tbl_users (
       user_id     INT IDENTITY(1,1) PRIMARY KEY,
       username    VARCHAR(50)  NOT NULL,
       email       VARCHAR(100) NOT NULL,
       password    VARCHAR(100) NOT NULL,
       full_name   VARCHAR(100) NOT NULL,
       contact     VARCHAR(20)  NOT NULL,
       address     VARCHAR(200) NOT NULL,
       added_date  DATETIME DEFAULT GETDATE()
   );

   CREATE TABLE tbl_donors (
       donor_id    INT IDENTITY(1,1) PRIMARY KEY,
       first_name  VARCHAR(50)  NOT NULL,
       last_name   VARCHAR(50)  NOT NULL,
       email       VARCHAR(100) NOT NULL,
       contact     VARCHAR(20)  NOT NULL,
       gender      VARCHAR(10)  NOT NULL,
       address     VARCHAR(200) NOT NULL,
       blood_group VARCHAR(5)   NOT NULL,
       added_date  DATETIME DEFAULT GETDATE(),
       added_by    INT FOREIGN KEY REFERENCES tbl_users(user_id)
   );

   CREATE TABLE tbl_inventory (
       Quantity_No  INT IDENTITY(1,1) PRIMARY KEY,
       O_positive   INT DEFAULT 0,
       O_negative   INT DEFAULT 0,
       A_positive   INT DEFAULT 0,
       A_negative   INT DEFAULT 0,
       B_positive   INT DEFAULT 0,
       B_negative   INT DEFAULT 0,
       AB_positive  INT DEFAULT 0,
       AB_negative  INT DEFAULT 0
   );

   -- Insert a default admin user
   INSERT INTO tbl_users (username, email, password, full_name, contact, address)
   VALUES ('admin', 'admin@bloodbank.com', 'admin123', 'System Admin', '0000000000', 'Blood Bank HQ');
   ```

3. **Alternatively,** if using Version 2 or 3, attach the provided database files:
   - In SSMS, right-click **Databases** → **Attach**
   - Browse to the `Database/` folder inside the version directory
   - Select `BloodBankManagementSystem.mdf`
   - Click **OK**

### Configuration

1. Open `App.config` in the project root
2. Update the connection string to match your SQL Server instance:

   ```xml
   <connectionStrings>
     <add name="connstrng"
          connectionString="Data Source=(local);Initial Catalog=BloodBankManagementSystem;Integrated Security=True" />
   </connectionStrings>
   ```

   - **`Data Source`**: Change `(local)` to your SQL Server instance name if different (e.g., `.\SQLEXPRESS`)
   - **`Initial Catalog`**: Keep as `BloodBankManagementSystem`
   - **`Integrated Security`**: Set to `True` for Windows Authentication

### Running the Application

1. Press **F5** or click **Start** in Visual Studio
2. The splash screen will appear with a loading animation
3. Log in with default credentials:
   - **Username:** `admin`
   - **Password:** `admin123`
4. You will be taken to the dashboard

---

## 📖 Usage Guide

### Application Flow

```
Splash Screen → Login → Dashboard (Home)
                            │
                            ├── Users     → Add / Update / Delete / Search users
                            ├── Donors    → Add / Update / Delete / Search donors
                            └── Inventory → View / Manage blood stock levels
```

### Dashboard

- View all registered donors in a searchable data grid
- See real-time counts for each blood group
- Navigate to Users, Donors, or Inventory modules

### Managing Users

1. Go to **Users** from the dashboard menu
2. Fill in the form fields: Full Name, Email, Username, Password, Contact, Address
3. Click **Add** to create a new user, **Update** to modify, or **Delete** to remove
4. Use the search bar to filter users

### Managing Donors

1. Go to **Donors** from the dashboard menu
2. Fill in: First Name, Last Name, Email, Gender, Blood Group, Contact, Address
3. Select the correct **blood group** from the dropdown (O+, O−, A+, A−, B+, B−, AB+, AB−)
4. Click **Add** to register the donor
5. Click a row in the data grid to load donor details for editing

### Blood Inventory (Version 3+)

1. Go to **Inventory** from the dashboard menu
2. View current stock levels for all blood groups
3. Update quantities as blood is received or distributed

---

## 🤝 Contributing

Contributions are welcome! Here's how you can help:

1. **Fork** the repository
2. **Create** a feature branch
   ```bash
   git checkout -b feature/your-feature-name
   ```
3. **Make** your changes and commit
   ```bash
   git commit -m "Add: description of your changes"
   ```
4. **Push** to your fork
   ```bash
   git push origin feature/your-feature-name
   ```
5. **Open** a Pull Request

### Ideas for Contribution

- [ ] Add password hashing for secure storage
- [ ] Implement role-based access control (Admin vs. Staff)
- [ ] Add blood request/distribution tracking
- [ ] Create reports and export to PDF/Excel
- [ ] Add unit tests for DAL and BLL layers
- [ ] Implement input validation and sanitization
- [ ] Add patient management module
- [ ] Create a web-based version using ASP.NET

---

## 📄 License

This project is licensed under the **MIT License** — see the [LICENSE](LICENSE) file for details.

```
MIT License — Copyright (c) 2023 Md. Mehedi Hasan
```

---

## 🙏 Acknowledgements

- **Original Tutorial:** [Vijay Thapa — Blood Bank Management System](https://www.youtube.com/playlist?list=PLBLPjjQlnVXW18XGLC2yjimoNA6ugNBQQ)
- **Inventory Module Tutorial:** [Advance Teaching — Stock Management](https://www.youtube.com/playlist?list=PLdRq0mbeEBmwVaARH4TQVCC-s152eGgxq)
- **Written Guide:** [vijaythapa.com — Create Blood Bank Management System](https://www.vijaythapa.com.np/2019/06/create-blood-bank-management-system.html)

---

<p align="center">
  Made with ❤️ by <strong>Group-02</strong> — SDP-2 Project
</p>
