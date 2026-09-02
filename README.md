# 🚗 RentCar Manager

[![.NET](https://img.shields.io/badge/.NET-C%23-512BD4?style=flat&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![Windows Forms](https://img.shields.io/badge/UI-Windows%2520Forms-0078D7?style=flat&logo=windows&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/desktop/winforms/)
[![EF Core](https://img.shields.io/badge/ORM-EF%20Core-512BD4?style=flat)](https://learn.microsoft.com/en-us/ef/core/)
[![SQL Server](https://img.shields.io/badge/Database-SQL%2520Server%2520Express-CC2927?style=flat&logo=microsoft-sql-server&logoColor=white)](https://www.microsoft.com/sql-server)

Aplicación de escritorio desarrollada en **Windows Forms** utilizando **Entity Framework Core (Code First)** y **SQL Server Express**. El sistema está diseñado para que una empresa de alquiler de vehículos gestione de forma eficiente su flota, el registro de clientes, la asignación de rentas (alquileres) y el control de devoluciones y pagos

---

## 🛠️ Tecnologías Utilizadas

| Componente | Tecnología / Herramienta |
| :--- | :--- |
| **Plataforma / Lenguaje** | .NET / C# |
| **Interfaz Gráfica (UI)** | Windows Forms |
| **Mapeo Objeto-Relacional (ORM)** | Entity Framework Core (Enfoque Code First) |
| **Base de Datos** | SQL Server Express |

---

## ⚙️ Enfoque de Desarrollo: Code First

Este proyecto se construye bajo el enfoque **Code First** (Código Primero). Esto significa que el modelo de datos y las reglas de negocio se estructuraron primero mediante clases en C#, permitiendo que la base de datos relacional en SQL Server Express se genere y sincronice directamente a partir del código de la aplicación.

---

## 📊 Modelo de Datos y Entidades

Las siguientes entidades estructuran el sistema relacional, aplicando validaciones y restricciones mediante `Data Annotations`:

*   **👤 Entidad Cliente:** Gestiona la información personal y de contacto (ID, Nombre, Apellido, Cédula única, Licencia de Conducir, Teléfono y Correo).
*   **🚗 Entidad Vehículo:** Administra el catálogo de la flota (ID, Marca, Modelo, Año, Placa, Tipo de vehículo como SUV/Sedán, Tarifa por día y Estado operativo)
*   **📋 Entidad Alquiler (Transacción Principal):** Controla el ciclo de vida de la renta relacionando clientes y vehículos, registrando fechas, montos calculados y el estado actual

---

## 💻 Módulos y Pantallas (UI)

1.  **🔐 Formulario de Login:** Validación segura de credenciales de acceso para los empleados del negocio
2.  **📦 Mantenimientos (CRUDs):** Gestión de Clientes y Vehículos mediante `DataGridView` configurados con selección por fila completa y ajuste automático de columnas
3.  **📝 Gestión de Alquileres (Núcleo):** Formulario dinámico para seleccionar clientes, filtrar exclusivamente vehículos con estado *"Disponible"* y calcular automáticamente el monto total según los días seleccionados. Al guardar, actualiza de manera transaccional el estado del vehículo a *"Alquilado"* utilizando el *Change Tracking* de EF Core.
4.  **🔄 Módulo de Devoluciones:** Listado de alquileres activos para procesar la entrega y retornar el vehículo al estado *"Disponible"*

---

## 🚀 Retos Técnicos y Buenas Prácticas

*   **Validaciones Robustas:** Implementación de `Data Annotations` (`[Key]`, `[Required]`, `[StringLength]`, `[Column]`) para asegurar la integridad de los datos desde el código
*   **Consultas Eficientes:** Manejo de consultas compuestas con **LINQ** y aprovechamiento de las propiedades de navegación de EF Core
*   **Control Transaccional:** Sincronización precisa de los estados de las entidades en la base de datos local mediante el mecanismo de seguimiento de cambios (*Change Tracking*)

