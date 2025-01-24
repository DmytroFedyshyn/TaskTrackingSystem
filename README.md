# Task Tracking System

A simple **Task Tracking System** built with **ASP.NET Core Web API** and **Angular**, designed as a basic Kanban board similar to Trello or Asana. This project demonstrates skills in backend development, JWT authentication, RESTful API design, frontend development, and integration with Angular Material for UI.

---

## Features

### Backend Features (ASP.NET Core Web API):
- **Task Management**:
  - Create, read, update, and delete (CRUD) tasks.
  - Support for task statuses: `To Do`, `In Progress`, `Done`.
  - Task sorting and filtering by priority, deadline, or status.
- **Authentication and Authorization**:
  - User authentication using JWT tokens.
  - Role-based access control (Admin/User).
- **Database Integration**:
  - Entity Framework Core with Code-First migrations.
  - Microsoft SQL Server (or SQLite for development).

### Frontend Features (Angular):
- **Kanban Board**:
  - Drag-and-drop support for tasks using Angular Material's `cdk-drag-drop`.
  - Dynamic columns (`To Do`, `In Progress`, `Done`).
- **Task Dialogs**:
  - Create and edit tasks using Angular Material dialog components.
  - Form validation for task fields.
- **User-Friendly UI**:
  - Responsive design with Angular Material components.

---

## Tech Stack

### Backend:
- **ASP.NET Core 8.0**
- **Entity Framework Core**
- **Microsoft SQL Server** (or SQLite for local development)
- **JWT Authentication**

### Frontend:
- **Angular 16**
- **Angular Material**
- **CDK Drag & Drop**

---

## Getting Started

### Prerequisites
Ensure you have the following installed:
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Node.js and npm](https://nodejs.org/)
- [SQL Server](https://www.microsoft.com/en-us/sql-server) or [SQLite](https://www.sqlite.org/index.html)
- [Angular CLI](https://angular.io/cli)

---

### Backend Setup

1. **Clone the repository**:
   ```bash
   git clone https://github.com/yourusername/TaskTrackingSystem.git
   cd TaskTrackingSystem/Backend
   ```

2. **Restore dependencies**:
   ```bash
   dotnet restore
   ```

3. **Configure the database**:
   Update the connection string in `appsettings.json`:
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=TaskTrackingDb;Trusted_Connection=True;"
   }
   ```

4. **Apply migrations**:
   ```bash
   dotnet ef database update
   ```

5. **Run the application**:
   ```bash
   dotnet run
   ```
   The API will be available at `http://localhost:5000`.

---

### Frontend Setup

1. **Navigate to the frontend directory**:
   ```bash
   cd ../Frontend
   ```

2. **Install dependencies**:
   ```bash
   npm install
   ```

3. **Run the application**:
   ```bash
   ng serve
   ```
   The frontend will be available at `http://localhost:4200`.

---

## Usage

1. **Run the backend API**:
   - Open a terminal and navigate to the backend directory.
   - Execute `dotnet run` to start the API server.

2. **Run the Angular frontend**:
   - Open a new terminal and navigate to the frontend directory.
   - Execute `ng serve` to start the Angular development server.

3. **Access the application**:
   - Open your browser and go to `http://localhost:4200`.

---

## API Endpoints

### **Auth Controller**
| Endpoint        | Method | Description              |
|-----------------|--------|--------------------------|
| `/api/auth/login` | POST   | Authenticate a user and generate a JWT token |

### **Tasks Controller**
| Endpoint           | Method | Description                     |
|--------------------|--------|---------------------------------|
| `/api/tasks`       | GET    | Get all tasks                  |
| `/api/tasks/{id}`  | GET    | Get a specific task by ID       |
| `/api/tasks`       | POST   | Create a new task               |
| `/api/tasks/{id}`  | PUT    | Update an existing task         |
| `/api/tasks/{id}`  | DELETE | Delete a task                   |

---

## Future Enhancements

- Add user registration functionality.
- Add notifications for task updates.
- Introduce advanced task filtering by tags.
- Implement real-time task updates using SignalR.
- Add unit tests for both frontend and backend.



