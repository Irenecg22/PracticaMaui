# Directorio de Empleados – Aplicación .NET MAUI

Aplicación multiplataforma desarrollada con **.NET MAUI** que permite consultar el directorio de empleados de una organización mediante el consumo de una API REST.
La aplicación muestra diferentes colecciones de datos, permite navegar entre vistas de listado y detalle, e incluye funcionalidades adicionales como configuración y pantalla de detalles.

---

## Descripción del Proyecto

Esta aplicación permite consultar información de empleados y departamentos de una organización a través de una API desarrollada previamente.
El objetivo principal es demostrar el desarrollo de una aplicación **multiplataforma** utilizando arquitectura moderna y buenas prácticas en .NET MAUI.

---

##  Funcionalidades Principales

-  Consulta de empleados desde API REST.
-  Consulta de departamentos.
-  Visualización de colecciones con tarjetas personalizadas.
-  Vista de detalle de empleado.
-  Vista de detalle de departamento.
-  Navegación entre vistas mediante Shell.
-  Pantalla de configuración (Settings).
-  Pantalla About con información de la aplicación.
-  Interfaz adaptada a criterios de UX y usabilidad.

---

##  Tecnologías Utilizadas

- .NET MAUI
- C#
- XAML
- API REST
- HttpClient
- System.Text.Json
- Patrón MVVM
- Shell Navigation
- Data Binding
- CommunityToolkit.Mvvm (ObservableProperty)

---

##  Arquitectura

La aplicación sigue el patrón **MVVM (Model - View - ViewModel)** para separar la lógica de negocio de la interfaz de usuario.

###  Estructura básica del proyecto

MauiPractica/
│
├── Models/
│ ├── Empleado.cs
│ └── Departamento.cs
│
├── Services/
│ ├── EmpleadoService.cs
│ ├── DepartamentoService.cs
│ └── IRestService.cs
│
├── View/
│ ├── MainView.xaml
│ ├── MainDetalleView.xaml
│ ├── DepartamentoView.xaml
│ ├── DepartamentoDetalleView.xaml
│ └── SettingsView.xaml
│
├── ViewModels/
│ ├── MainViewModel.cs
│ ├── MainDetalleViewModel.cs
│ ├── DepartamentoViewModel.cs
│ ├── DepartamentoDetalleViewModel.cs
│ └── SettingsViewModel.cs
│
├── AppShell.xaml
├── App.xaml
└── MauiProgram.cs


---

## Navegación

Se utiliza **Shell Navigation** con al menos tres elementos de primer nivel:

-  Empleados
-  Departamentos
-  Settings

La navegación entre vistas de listado y detalle se realiza mediante rutas registradas en `AppShell.xaml`.
También navegacion interna entre pantallas.

---

##  Diseño y UX

- Uso de **Cards / DataTemplates personalizados** para mostrar empleados y departamentos.
- Diseño coherente con la temática corporativa.
- Navegación intuitiva.
- Separación clara entre colecciones y vistas de detalle.
- Uso adecuado de márgenes, espaciados y jerarquía visual.

---
###  Requisitos

- Visual Studio 2022 o superior
- .NET 8 SDK
- Workload de .NET MAUI instalado
- API en ejecución (local o remota)
### **Visión de la app**
<img width="1404" height="647" alt="image" src="https://github.com/user-attachments/assets/a7760064-0400-4b92-97c7-ef27f0fd316f" />
<img width="1409" height="593" alt="image" src="https://github.com/user-attachments/assets/da7c952c-7a90-4539-b029-b8454a10944b" />
<img width="1405" height="715" alt="image" src="https://github.com/user-attachments/assets/2b8c8076-e4f3-495d-9d0e-3f68e9a64260" />
<img width="1403" height="499" alt="image" src="https://github.com/user-attachments/assets/3540786f-2463-4cd9-862e-3c4eb6c5fbda" />
<img width="1407" height="650" alt="image" src="https://github.com/user-attachments/assets/c3292295-1651-46a4-aaf0-ab0fc40b586a" />
<img width="1414" height="536" alt="image" src="https://github.com/user-attachments/assets/2903ae2f-9453-401d-a6aa-69b37a9e075e" />




### **Pasos para ejecutar**

1. Clonar el repositorio:

```bash
git clone https://github.com/usuario/MauiPractica.git

2. Abrir la solución en Visual Studio.

3. Verificar que la API esté en ejecución (por ejemplo):

http://127.0.0.1:8000/empleados/

4. Seleccionar el dispositivo de destino:

Windows

Android Emulator

Dispositivo físico

AUTOR
Irene Cañada Gómez
