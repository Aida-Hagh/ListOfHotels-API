# 🏨 Hotel Listing API

## یک پروژه تمرینی Web API
---
## 🚀 تکنولوژی‌ها

ASP.NET Core 8 · EF Core 8 · SQL Server · JWT + Identity · Serilog · AutoMapper · FluentValidation · Swagger · EPPlus · Rate Limiting · Caching

---

## 📡 API Endpoints

**شهرها (`/api/City`)**
- `GET /api/City` — لیست شهرها
- `GET /api/City/{id}` — یک شهر با هتل‌هایش
- `GET /api/City/{cityId}/hotels` — هتل‌های یک شهر (با فیلتر، جستجو، مرتب‌سازی و صفحه‌بندی)
- `POST /api/City` — ایجاد شهر
- `POST /api/City/upload` — آپلود اکسل
- `PUT /api/City/{id}` — ویرایش
- `DELETE /api/City/{id}` — حذف

**هتل‌ها (`/api/Hotel`)**
- `GET /api/Hotel` — لیست هتل‌ها (فیلتر، جستجو، مرتب‌سازی، صفحه‌بندی)
- `GET /api/Hotel/{id}` — یک هتل
- `GET /api/Hotel/report` — گزارش JSON
- `GET /api/Hotel/report/excel` — گزارش Excel
- `POST /api/Hotel` — ایجاد
- `PUT /api/Hotel/{id}` — ویرایش
- `PATCH /api/Hotel/{id}` — ویرایش جزئی
- `DELETE /api/Hotel/{id}` — حذف

**احراز هویت (`/api/Account`)**
- `POST /api/Account/Register` — ثبت‌نام
- `POST /api/Account/Login` — ورود و دریافت JWT

---

## 🔧 قابلیت‌ها

- ✅ CRUD کامل
- ✅ JWT + Identity (Admin/User)
- ✅ Exception Handling + Serilog
- ✅ Caching + Rate Limiting
- ✅ صفحه‌بندی، جستجو، فیلتر، مرتب‌سازی
- ✅ FluentValidation
- ✅ آپلود و گزارش Excel
- ✅ Repository + UnitOfWork

---

## 🛠️ اجرا

### ۱. تنظیم Connection String
در فایل `appsettings.json` پروژه‌ی `ListOfHotels-API`:

```json
"ConnectionStrings": {
  "sqlConnection": "Data Source=.; database=ListOfHotels_db; integrated security=true;TrustServerCertificate=True;"
}
```

### ۲. اجرای Migration
در **Package Manager Console** ویژوال استادیو:

```powershell
Update-Database -Project ListOfHotels-Data -StartupProject ListOfHotels-API
```

### ۳. اجرای پروژه
- پروژه‌ی `ListOfHotels-API` رو **Set as Startup Project** کن.
- دکمه‌ی **F5** یا **Ctrl+F5** رو بزن.

### ۴. دسترسی به Swagger
```
https://localhost:7224/swagger
```

---

## 📄 مجوز

MIT
