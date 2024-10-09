# AlbertOS

**AlbertOS** es un proyecto de sistema operativo minimalista en sus primeras etapas de desarrollo. Actualmente, su única funcionalidad es recibir un texto del usuario y devolverlo en pantalla. Este proyecto está construido utilizando el framework [COSMOS](https://github.com/CosmosOS/Cosmos), que permite crear sistemas operativos en C# y .NET.

## Características

En su estado actual, AlbertOS incluye las siguientes funciones básicas:

- **Entrada de texto**: El sistema recibe una cadena de texto del usuario.
- **Salida de texto**: El sistema imprime de vuelta la misma cadena en la pantalla.

Este proyecto está diseñado como una base para futuras mejoras, donde se irán añadiendo más características de un sistema operativo real.

## Requisitos

Para compilar y ejecutar **AlbertOS**, necesitarás:

- [Visual Studio 2022](https://visualstudio.microsoft.com/)
- Extensión de [COSMOS](https://github.com/CosmosOS/Cosmos) instalada en Visual Studio
- Un emulador de máquina virtual como **Bochs** o **VMWare Player** para pruebas

### Instalación de COSMOS

1. **Descargar COSMOS**: Instala la extensión de COSMOS desde el [sitio oficial](https://cosmosos.github.io/) o desde Visual Studio Marketplace.
2. **Configurar Visual Studio**: Asegúrate de tener el SDK de .NET configurado.

## Compilar y Ejecutar

Sigue estos pasos para compilar y ejecutar **AlbertOS**:

1. Clona este repositorio:
    ```bash
    git clone https://github.com/tu-usuario/AlbertOS.git
    cd AlbertOS
    ```

2. Abre el proyecto en **Visual Studio**.

3. Haz clic derecho sobre el proyecto y selecciona `Run in Cosmos`.

4. Selecciona el emulador que prefieras (Bochs o VMWare) para ejecutar **AlbertOS**.

## Cómo Funciona

Una vez que AlbertOS esté ejecutándose:

1. **Entrada**: Ingresa un texto en la consola.
2. **Salida**: El sistema imprimirá de vuelta el mismo texto.

### Ejemplo:

