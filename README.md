# NightCycle Mod para Rain World
**NOTA:** Esto es un ReadMe temporal hecho con chatgpt, puede contener informacion errada, luego se procedera a la revision.


## Descripción

NightCycle es un mod para el juego Rain World que introduce un ciclo de día y noche en el juego. Este mod cambia la apariencia y el comportamiento del mundo del juego dependiendo de la hora del día, proporcionando una experiencia de juego más dinámica y envolvente.

## Características

- Ciclo de día y noche que afecta la apariencia del mundo.
- Diferentes comportamientos de los personajes y el entorno según la hora del día.
- Fácil integración con otros mods de Rain World.

## Instalación

1. **Requisitos Previos**:
   -

2. **Descargar el Mod**:
   - Descarga repositorio, agrega las referencias necesarias y compila, se te generara un .dll en bin/Debug/NigthCicle.dll.

3. **Instalar el Mod**:
   - Extrae el .dll compilado y agregalo en un mod propio en la carpeta de plugins

4. **Ejecutar el Juego**:
   - Inicia Rain World y activa el mod en Remix.

## Uso

El mod se activa en Remix. El ciclo de día y noche comenzará a afectar el mundo del juego inmediatamente.

## Desarrollo

### Estructura del Proyecto

- `Plugin.cs`: Contiene la clase principal del mod que se encarga de la inicialización.
- `NightCycleHooks.cs`: Contiene los hooks que modifican el comportamiento del juego.
- `Utils/Helper.cs`: Contiene funciones auxiliares utilizadas por el mod.

### Compilar desde el Código Fuente

1. Clona este repositorio: `git clone https://github.com/tu-usuario/nightcycle.git`
2. Abre el proyecto en tu IDE preferido (por ejemplo, Visual Studio).
3. Asegúrate de tener las referencias necesarias (BepInEx, MonoMod).
4. Compila el proyecto y copia el archivo DLL generado en la carpeta `BepInEx/plugins` de tu instalación de Rain World.

## Créditos

- **Autor**: [IAHunter](https://github.com/tu-usuario)
- **Colaboradores**: qtpi, felipe

## Licencia

Este proyecto está licenciado bajo la Licencia MIT. Consulta el archivo [LICENSE](LICENSE) para más detalles.

## Contacto

Para cualquier pregunta o sugerencia, puedes abrir un issue en este repositorio o contactarme a través de [....](---).

