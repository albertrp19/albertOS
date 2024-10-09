# AlbertOS

**AlbertOS** és un projecte de sistema operatiu minimalista en les seves primeres etapes de desenvolupament. Actualment, la seva única funcionalitat és rebre un text de l'usuari i tornar-lo a mostrar a la pantalla. Aquest projecte està construït utilitzant el framework [COSMOS](https://github.com/CosmosOS/Cosmos), que permet crear sistemes operatius en C# i .NET.

## Característiques

En el seu estat actual, AlbertOS inclou les següents funcions bàsiques:

- **Entrada de text**: El sistema rep una cadena de text de l'usuari.
- **Sortida de text**: El sistema imprimeix de nou la mateixa cadena a la pantalla.

Aquest projecte està dissenyat com una base per a futures millores, on s'aniran afegint més característiques d'un sistema operatiu real.

## Requisits

Per compilar i executar **AlbertOS**, necessitaràs:

- [Visual Studio 2022](https://visualstudio.microsoft.com/)
- Extensió de [COSMOS](https://github.com/CosmosOS/Cosmos) instal·lada a Visual Studio
- Un emulador de màquina virtual com **Bochs** o **VMWare Player** per a les proves

### Instal·lació de COSMOS

1. **Descarregar COSMOS**: Instal·la l'extensió de COSMOS des del [lloc oficial](https://cosmosos.github.io/) o des del Visual Studio Marketplace.
2. **Configurar Visual Studio**: Assegura't de tenir el SDK de .NET configurat.

## Compilar i Executar

Segueix aquests passos per compilar i executar **AlbertOS**:

1. Clona aquest repositori:
    ```bash
    git clone https://github.com/tu-usuari/AlbertOS.git
    cd AlbertOS
    ```

2. Obre el projecte a **Visual Studio**.

3. Fes clic amb el botó dret sobre el projecte i selecciona `Run in Cosmos`.

4. Selecciona l'emulador que prefereixis (Bochs o VMWare) per executar **AlbertOS**.

## Com Funciona

Un cop **AlbertOS** estigui en funcionament:

1. **Entrada**: Introdueix un text a la consola.
2. **Sortida**: El sistema imprimirà de nou el mateix text.

### Exemple:

