## 🏫 School Management System
A simple Windows Forms application built with C# .NET Framework and SQL Server to manage students, teachers, attendance, and fees. Includes a dashboard for quick insights and a login system for secure access.

---

### Features
- Splash Screen & Login
- CRUD
  - Student Management 
  - Teacher Management 
  - Attendance Tracking
  - Fee Management
- Dashboard for quick insights

### Technologies
- C# .NET Framework (Windows Forms)
- SQL Server
- Visual Studio

### Getting Started

1. Clone the repository
   ```bash
   git clone https://github.com/farhanafaiz03/School-Management-System.git
   ```
2. Import `schooldb.sql` into SQL Server (SSMS 20)
3. Open the solution in Visual Studio
4. Restore packages:
     - Visual Studio will automatically restore required NuGet packages (from the packages/ folder or online).
     - If not, right-click the solution in Solution Explorer → Restore NuGet Packages.
   Update the connection string in Dashboard.cs, replace it with your SQL Server instance.
   For Example:
   ```bash
   SqlConnection Con = new SqlConnection(@"Data Source=FARHANA-FAIZ01;Initial Catalog=schooldb;Integrated Security=True;Encrypt=False");
   ```
5. Run the application

---

### Note
This is a **basic project** with limited features, aimed at demonstrating Windows Forms application development and database connectivity.
