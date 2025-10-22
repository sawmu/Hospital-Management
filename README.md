# 🏥 Hospital Management System (ASP.NET Core MVC)

A modern **Hospital Management System (HMS)** built with **ASP.NET Core MVC (.NET 9)** and **Entity Framework Core**.  
This project provides a complete solution to manage patients, doctors, appointments, billing, and authentication within a healthcare environment.

---

## 🚀 Features

- 🧑‍⚕️ **Patient Management** — Add, edit, view, and delete patient records.  
- 👨‍⚕️ **Doctor Management** — Manage doctor profiles, specialties, and schedules.  
- 📅 **Appointment Scheduling** — Book and track appointments between doctors and patients.  
- 💰 **Billing & Payments** — Generate invoices and handle payments efficiently.  
- 🔐 **User Authentication** — Secure login and role-based access with ASP.NET Core Identity.  
- 📊 **Dashboard Overview** — Visual summary of hospital statistics (patients, doctors, revenue, etc).  
- 🧾 **Reporting System** — Generate and export patient and appointment reports.

---

## 🛠️ Technology Stack

| Component | Technology |
|------------|-------------|
| **Frontend** | ASP.NET Core MVC, Razor Views, Bootstrap 5 |
| **Backend** | ASP.NET Core (.NET 9) |
| **Database** | SQL Server / Azure SQL Database |
| **ORM** | Entity Framework Core |
| **Authentication** | ASP.NET Core Identity |
| **Deployment** | Azure App Service / Docker |

---

## 📂 Project Structure

```
Hospital-Management/
│
├── Hms.Web/                   # Main ASP.NET Core MVC Web App
│   ├── Controllers/           # MVC Controllers
│   ├── Models/                # Entity Models (EF Core)
│   ├── Views/                 # Razor Views (UI)
│   ├── Data/                  # DbContext, Migrations, and Seed Data
│   ├── wwwroot/               # Static assets (CSS, JS, images)
│   └── Program.cs             # Application entry point
│
└── README.md                  # Project documentation
```

---

## ⚙️ Getting Started

### 1️⃣ Clone the Repository
```bash
git clone https://github.com/sawmu/Hospital-Management.git
cd Hospital-Management/src/Hms.Web
```

### 2️⃣ Configure the Database
Open `appsettings.json` and update the connection string:
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost,1433;Database=HmsDb;User Id=sa;Password=S3curePwd123*;Encrypt=True;TrustServerCertificate=True;"
}
```

### 3️⃣ Apply Migrations
```bash
dotnet tool install --global dotnet-ef
dotnet ef database update
```

### 4️⃣ Run the Application
```bash
dotnet run
```

Access the app at: **https://localhost:5001**

---

## 👥 Default Accounts (for testing)

| Role | Email | Password |
|------|--------|-----------|
| Admin | admin@hms.local | Admin@123 |
| Doctor | doctor@hms.local | Doctor@123 |
| Receptionist | reception@hms.local | Reception@123 |

---

## 🌐 Deployment (Azure)

1. Create an **App Service** and **Azure SQL Database**.  
2. Update your connection string in Azure → Configuration → Connection Strings.  
3. Push code to GitHub → GitHub Actions will automatically deploy to Azure (see `.github/workflows/deploy.yml`).

---

## 🧰 Future Enhancements

- 🧾 Insurance & claims module  
- 📧 Email/SMS appointment notifications  
- 💉 Pharmacy & inventory management  
- 📊 Data analytics & Power BI dashboard integration  

---

## 🧑‍💻 Author

**Saw Mu**  
📧 [sawmu@example.com](mailto:sawmu@example.com)  
🌐 [https://github.com/sawmu](https://github.com/sawmu)

---

## 📝 License

This project is licensed under the [MIT License](LICENSE).

---

### ⭐ If you like this project, please give it a star on GitHub! ⭐
