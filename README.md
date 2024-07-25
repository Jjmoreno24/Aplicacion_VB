[![KRmj-Mz6-Qa-Um-P-1584-396.png](https://i.postimg.cc/HkXSSH13/KRmj-Mz6-Qa-Um-P-1584-396.png)](https://postimg.cc/Yv2f959m)

# PowerFit - Gestión de Gimnasios

![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91.svg?style=for-the-badge&logo=visual-studio&logoColor=white)  ![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white) ![MicrosoftSQLServer](https://img.shields.io/badge/Microsoft%20SQL%20Server-CC2927?style=for-the-badge&logo=microsoft%20sql%20server&logoColor=white)

## Descripción
<p align="justify">
PowerFit es una aplicación desarrollada en Visual Basic .NET y SQL Server para la gestión administrativa de gimnasios. Permite la automatización y optimización de procesos como el registro de clientes, la gestión de membresías, el control de acceso y más.
</p>

## Desarrollo
### Herramientas y Tecnologías Utilizadas
- **Lenguaje de Programación:** Visual Basic .NET 2022 en la versión 4.8
- **Framework:** .NET 6.0
- **Gestor de Base de Datos:** SQL Server 2022

### Estructura del Proyecto
El proyecto está organizado en varias fases, desde el análisis hasta la implementación:

#### Fase 1: Análisis
1. Definición de requisitos y funcionalidades.
2. Investigación y análisis de mercado.
3. Recolección de información sobre los procesos y necesidades del gimnasio.
4. Refinamiento de requisitos y funcionalidades.
5. Entrevistas con los stakeholders del gimnasio.
6. Definición de la estructura y relación de la base de datos.

#### Fase 2: Diseño
1. Creación del diseño de la interfaz gráfica de la aplicación.
2. Establecimiento de la arquitectura de la base de datos.
3. Elaboración de diagramas de flujo y clases.
4. Refinamiento del diseño de la interfaz gráfica.
5. Finalización del diseño de la base de datos.
6. Documentación del diseño general del sistema.

#### Fase 3: Desarrollo
1. Implementación de la funcionalidad de registro de nuevos clientes.
2. Desarrollo de la funcionalidad para visualizar los datos de los clientes.
3. Construcción de la lógica de negocio relacionada con los procesos del gimnasio.
4. Gestión de máquinas y equipos del gimnasio.
5. Asignación y registro de horarios de uso de las máquinas por parte de los clientes.
6. Pruebas unitarias y resolución de problemas de implementación.

#### Fase 4: Implementación
1. Integración de todas las funcionalidades y componentes.
2. Pruebas de integración y depuración.
3. Preparación de la documentación del proyecto.
4. Pruebas de aceptación y corrección de errores.
5. Capacitación del personal del gimnasio para el uso de la aplicación.
6. Entrega final del proyecto y despliegue de la aplicación.

### Desarrollo en Equipo
<p align="justify">
Este proyecto fue desarrollado en equipo como parte de un curso universitario en la Universidad Tecnológica de Panamá, en la Facultad de Ingeniería de Sistemas Computacionales. Agradecemos la colaboración y esfuerzo de cada integrante del equipo, así como el apoyo de nuestra profesora Anna Araba.
</p>

## Operación
### Funcionamiento del Programa
La aplicación desarrollada para la gestión de un gimnasio permite realizar diversas tareas administrativas de manera eficiente y automatizada. A continuación, se describen las principales funcionalidades y su operación:

#### Registro de Clientes
- **Funcionalidad:** Permite registrar nuevos clientes en la base de datos del gimnasio.
- **Proceso:** 
  1. El usuario ingresa los datos personales del cliente (nombre, cédula, fecha de nacimiento, etc.).
  2. Se selecciona la sucursal y el tipo de membresía.
  3. Se registran las condiciones médicas del cliente si las hay.

#### Gestión de Empleados
- **Funcionalidad:** Permite visualizar y actualizar la información de los empleados.
- **Proceso:** 
  1. Los empleados se registran en la base de datos con sus datos personales y posición.
  2. Se pueden realizar búsquedas y filtrados en la tabla de empleados.
  3. Los datos de los empleados, como el salario y la sucursal, se pueden actualizar mediante formularios específicos.

#### Control de Membresías
- **Funcionalidad:** Permite gestionar las membresías de los clientes.
- **Proceso:**
  1. La aplicación controla la vigencia de las membresías y alerta sobre próximas expiraciones.
  2. Los clientes con membresías vencidas se eliminan automáticamente del sistema después de un mes.

#### Registro de Invitados
- **Funcionalidad:** Permite a los clientes registrar invitados al gimnasio.
- **Proceso:**
  1. Se registra la información del invitado (nombre, cédula, fecha de visita).
  2. Se controla el límite de cuatro invitados por mes por cliente.

#### Visualización de Datos
- **Funcionalidad:** Proporciona una interfaz para visualizar los datos de clientes y empleados.
- **Proceso:**
  1. Los datos se muestran en tablas con opciones de filtrado y búsqueda.
  2. Las tablas adicionales, como las condiciones médicas y sucursales, se pueden visualizar para obtener información más detallada.

### Seguridad y Validación
- **Validación de Datos:** Implementación de mecanismos para asegurar que los datos ingresados cumplen con los requisitos establecidos.
- **Seguridad de la Conexión:** Uso de métodos de autenticación y cifrado para proteger la información sensible.
- **Manejo de Errores:** Gestión adecuada de errores para proporcionar mensajes claros y comprensibles a los usuarios.

### Documentación y Soporte
- **Documentación:** El proyecto cuenta con manuales de usuario y guías de instalación detalladas.
- **Soporte:** Sistema de soporte para resolver dudas y problemas de los usuarios, garantizando una experiencia satisfactoria y correcta utilización de la aplicación.

### Configuración de la Base de Datos
Para el uso de la base de datos, asegúrate de reemplazar en el código de conexión:
```csharp
New SqlConnection("server='Nombre de su Servidor';database=POWERFITBD;Integrated Security=true")
```

## 🔭 Vista - Ejecución
<p align="center">
  <a href="https://www.youtube.com/watch?v=q1ows47WVEA">
    <img src="https://img.youtube.com/vi/q1ows47WVEA/0.jpg" alt="Video de PowerFit" width="600">
  </a>
</p>

---
<p align="center">
*Este proyecto fue desarrollado en equipo como parte de un curso universitario en la Universidad Tecnológica de Panamá*
</p>

<br>
<div align="center">
<h3 align="center">Let's connect 😋</h3>
</div>
<p align="center">
<a href="https://www.linkedin.com/in/jjosemoreno24" target="blank">
<img align="center" width="30px" alt="Hector's LinkedIn" src="https://www.vectorlogo.zone/logos/linkedin/linkedin-icon.svg"/></a> &nbsp; &nbsp;
<a href="https://twitter.com" target="blank">
<img align="center" width="30px" alt="Hector's Twitter" src="https://www.vectorlogo.zone/logos/twitter/twitter-official.svg"/></a> &nbsp; &nbsp;
<a href="https://www.twitch.tv" target="blank">
<img align="center" width="30px" alt="Hector's Twitch" src="https://www.vectorlogo.zone/logos/twitch/twitch-icon.svg"/></a> &nbsp; &nbsp;
<a href="https://www.youtube.com" target="blank">
<img align="center" width="30px" alt="Hector's Youtube" src="https://www.vectorlogo.zone/logos/youtube/youtube-icon.svg"/></a> &nbsp; &nbsp;
</p>
