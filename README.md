# 📚 BookShop — Online Bookstore

A full-stack web application built with **ASP.NET Core MVC**, **MySQL** and **Bootstrap 5**.

---

## 🛠 Tech Stack

| Layer | Technology |
|---|---|
| Backend | ASP.NET Core 8 MVC (C#) |
| ORM | Entity Framework Core 8 |
| Database | MySQL 8 + Pomelo provider |
| Auth | ASP.NET Core Identity |
| Frontend | Bootstrap 5 + Razor (.cshtml) |

---

## ✨ Features

- 📖 **Book catalog** — browse all books with cover images, price, genre and stock
- 🔎 **Search & filter** — search by title/author, filter by genre
- 📄 **Book details page** — full description and individual book page
- 🛒 **Shopping cart** — add/remove books, adjust quantity, real-time stock check
- 💳 **Order placement** — stock decreases automatically after purchase
- 👤 **Authentication** — register, login, logout via ASP.NET Core Identity
- 🔒 **Authorization** — cart is protected, only logged-in users can buy
- ⚙️ **Admin panel** — add, edit, delete books and manage stock (Admin role only)
- 📦 **Seed data** — 15 books added automatically on first run

---

## 📁 Project Structure

```
BookShop/
├── Controllers/
│   ├── HomeController.cs       # Home, About, Contacts pages
│   ├── BooksController.cs      # Catalog, search, filter, details
│   ├── CartController.cs       # Cart CRUD + stock validation + order
│   ├── AccountController.cs    # Register, Login, Logout
│   └── AdminController.cs      # Admin panel (books + stock management)
├── Models/
│   ├── Book.cs                 # Book entity
│   ├── CartItem.cs             # Cart item entity
│   └── ViewModels/
│       ├── RegisterViewModel.cs
│       └── LoginViewModel.cs
├── Views/
│   ├── Home/                   # Index, About, Contacts
│   ├── Books/                  # Index (catalog), Details
│   ├── Cart/                   # Index (cart page)
│   ├── Account/                # Register, Login
│   ├── Admin/                  # Index, Create, Edit
│   └── Shared/                 # _Layout, _LoginPartial
├── Data/
│   └── AppDbContext.cs         # EF Core DbContext + seed data
├── wwwroot/
│   └── photo/                  # Book cover images
├── appsettings.json            # DB connection string
└── Program.cs                  # App configuration + middleware
```

---

## ⚙️ Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- [MySQL Server 8](https://dev.mysql.com/downloads/)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) or VS Code

### Installation

**1. Clone or download the project**

```bash
git clone https://github.com/yourname/BookShop.git
cd BookShop
```

**2. Configure the database connection**

Open `appsettings.json` and update the connection string:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=BookShopDb;User=root;Password=YOUR_PASSWORD;"
}
```

**3. Install dependencies**

```bash
dotnet restore
```

**4. Apply migrations (creates the database and tables)**

```bash
dotnet ef database update
```

**5. Run the application**

```bash
dotnet run
```

Open your browser at `https://localhost:7087`

---

## 🗄️ Database Schema

| Table | Description |
|---|---|
| `books` | Book catalog (title, author, price, genre, stock, image) |
| `cartitems` | Cart items linked to user and book |
| `aspnetusers` | Users managed by ASP.NET Core Identity |
| `aspnetroles` | Roles (Admin) |
| `aspnetuserroles` | User ↔ Role mapping |
| `__efmigrationshistory` | EF Core migration history |

---

## 👤 Default Admin Account

An admin account is created automatically on first run:

| Field | Value |
|---|---|
| Email | `admin@bookshop.com` |
| Password | `Admin123!` |

Admin has access to **⚙ Admin Panel** in the navigation bar where you can:
- Add new books
- Edit existing books (title, author, price, genre, description, image, stock)
- Delete books
- Update stock quantity

---

## 🔐 Authorization

| Page | Access |
|---|---|
| Home, Catalog, Details | Everyone |
| Cart, Place Order | Logged-in users only |
| Admin Panel | Admin role only |

---

## 📦 NuGet Packages

```xml
<PackageReference Include="Microsoft.EntityFrameworkCore" Version="8.0.2" />
<PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="8.0.2" />
<PackageReference Include="Microsoft.AspNetCore.Identity.EntityFrameworkCore" Version="8.0.2" />
<PackageReference Include="Microsoft.AspNetCore.Identity.UI" Version="8.0.2" />
<PackageReference Include="Pomelo.EntityFrameworkCore.MySql" Version="8.0.2" />
```

---

## 🖼️ Adding Book Images

Place your cover images in `wwwroot/photo/` and reference them with a leading slash:

```csharp
ImageUrl = "/photo/MyBook.jpg"
```

---

## 📝 Migrations Reference

```bash
# Create a new migration after model changes
dotnet ef migrations add MigrationName

# Apply migrations to the database
dotnet ef database update

# Revert last migration
dotnet ef migrations remove
```

---

## 🚀 Built for

University project demonstrating full-stack web development with ASP.NET Core MVC pattern, relational database design, user authentication and role-based authorization.
