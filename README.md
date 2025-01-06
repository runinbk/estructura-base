# Sistema de Gráficos 3D con OpenTK

## 📝 Descripción
Sistema de visualización y manipulación de objetos 3D implementado en C# utilizando OpenTK. Este proyecto permite crear, manipular y visualizar objetos 3D con una estructura jerárquica de datos que facilita la organización y transformación de elementos gráficos.

## ✨ Características
- Renderizado de objetos 3D básicos (cubos, pirámides)
- Sistema de transformaciones (rotación, traslación, escalado)
- Cámara interactiva con control de mouse
- Estructura de datos jerárquica para objetos 3D
- Persistencia de objetos mediante serialización JSON
- Sistema de coordenadas visual con ejes X, Y, Z

## 🔧 Requisitos Previos
- Visual Studio 2022 o superior
- .NET 8.0 SDK
- Sistema operativo compatible con OpenGL

## 📦 Paquetes NuGet Requeridos
- OpenTK (Version 4.0.0)
- Microsoft.Win32.SystemEvents (Version 8.0.0)
- System.Drawing.Common (Version 8.0.0)

## 🚀 Instalación

1. Clonar el repositorio:
```bash
git clone https://github.com/runinbk/estructura-base.git
```

2. Abrir la solución en Visual Studio:
```bash
cd estructura-base
start estructura-base.sln
```

3. Restaurar los paquetes NuGet:
   - Click derecho en la solución
   - Seleccionar "Restaurar paquetes NuGet"

4. Compilar y ejecutar el proyecto

## 💻 Uso

### Controles
- **Click izquierdo + Arrastrar**: Rotar la cámara
- **Rueda del mouse**: Zoom in/out
- **ESC**: Salir de la aplicación

### Funcionalidades Principales
```csharp
// Crear un nuevo objeto
Objeto cubo = CrearCubo();

// Agregar objeto a la escena
escenario.AddObjeto("MiCubo", cubo);

// Aplicar transformaciones
cubo.rotar(new Punto(0, 45, 0));
cubo.trasladar(new Punto(1, 0, 0));
cubo.escalar(2.0f);
```

## 📁 Estructura del Proyecto

```
GraficosOpenTK/
│
├── Program.cs              # Punto de entrada
├── Game.cs                # Ventana principal y loop de renderizado
├── Clases/
│   ├── Punto.cs          # Representación de puntos 3D
│   ├── Poligono.cs       # Manejo de polígonos
│   ├── Parte.cs          # Agrupación de polígonos
│   ├── Objeto.cs         # Objetos 3D completos
│   └── Escenario.cs      # Contenedor principal
│
├── Interfaces/
│   └── IGraphics.cs      # Interfaz común para gráficos
│
└── Utilidades/
    └── AdministradorObjetos.cs  # Manejo de persistencia
```

## 🛠️ Desarrollo

### Compilación
```bash
dotnet build
```

### Ejecución
```bash
dotnet run
```

## 🤝 Contribuir

### Proceso de Contribución
1. Fork el proyecto
2. Crear una rama para tu feature (`git checkout -b feature/AmazingFeature`)
3. Realizar los cambios siguiendo los estándares de código
4. Commit de los cambios siguiendo Conventional Commits
5. Push a la rama (`git push origin feature/AmazingFeature`)
6. Abrir un Pull Request

### Conventional Commits
Todos los mensajes de commit deben seguir el estándar de [Conventional Commits](https://www.conventionalcommits.org/). El formato básico es:

```
<tipo>[alcance opcional]: <descripción>

[cuerpo opcional]

[nota de pie opcional]
```

#### Tipos de Commit
- `feat`: Nuevas características
- `fix`: Corrección de errores
- `docs`: Cambios en documentación
- `style`: Cambios que no afectan el código (formato, espacios, etc)
- `refactor`: Refactorización del código
- `test`: Añadir o modificar tests
- `chore`: Tareas de mantenimiento, cambios en build, etc.

#### Ejemplos
```bash
feat: añadir sistema de rotación automática
fix(render): corregir cálculo de centro de masa
docs: actualizar instrucciones de instalación
style: formatear código según estándares
refactor(objetos): simplificar sistema de transformaciones
test: añadir tests para rotaciones
chore: actualizar dependencias
```

### Pull Requests
- Asegúrate de que tu PR incluya una descripción clara de los cambios
- Referencia cualquier issue relacionado
- Actualiza la documentación si es necesario
- Asegúrate de que todos los tests pasen

## 📝 Licencia
Este proyecto está bajo la Licencia MIT - ver el archivo [LICENSE.md](LICENSE.md) para detalles

## 👥 Autores
* **Kevin B. Gomez R.** - *Trabajo Inicial* - [runinbk](https://github.com/runinbk)

## 🎓 Reconocimientos
* OpenTK por proporcionar el framework base
* OpenGL por el sistema de renderizado
* Todos los contribuidores que participaron en este proyecto

## 📞 Soporte
Para soporte y preguntas, por favor abre un issue en el repositorio.
