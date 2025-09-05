# 📚 CRUD Biblioteca

Sistema de gestión de libros desarrollado en **C# .NET 8** con **Windows Forms** y **MySQL**.

## 🚀 Características

- Agregar, actualizar, eliminar y listar libros
- Interfaz gráfica intuitiva
- Arquitectura MVC

## 📋 Requisitos

- **Visual Studio 2022** (con .NET Desktop Development)
- **MySQL Server 8.0+**
- **Puerto 3306** habilitado

## ⚡ Instalación Rápida

### 1. Configurar MySQL
```sql
CREATE DATABASE BibliotecaSena;
```

### 2. Configurar Conexión
Si tu MySQL no usa usuario `root` sin contraseña, edita `Modelo/Conexion.cs`:
```csharp
UserID = "tu_usuario",
Password = "tu_contraseña",
```

### 3. Ejecutar Aplicación
1. Abrir `MVC.sln` en Visual Studio
2. Clic derecho en proyecto `MVC` → "Establecer como proyecto de inicio"
3. Presionar `F5`

## 📖 Uso

1. **Agregar**: Llenar campos y clic "Agregar"
2. **Actualizar**: Seleccionar fila, modificar datos, clic "Actualizar"  
3. **Eliminar**: Seleccionar fila y clic "Eliminar"
4. **Limpiar**: Clic "Limpiar" para vaciar campos

## 🏗️ Estructura

```
MVC/              # Vista (Windows Forms)
Controlador/      # Lógica de negocio
Modelo/           # Base de datos y entidades
```

## ❌ Problemas Comunes

- **Error de conexión**: Verificar que MySQL esté ejecutándose
- **Tabla no existe**: La app la crea automáticamente
- **Paquetes NuGet**: Ejecutar `dotnet restore`

## 🎯 Configuración por Defecto

- **Servidor**: localhost:3306
- **Base de datos**: BibliotecaSena
- **Usuario**: root (sin contraseña)
