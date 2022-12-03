# MissionPlanner

[![Gitter](https://badges.gitter.im/Join%20Chat.svg)](https://gitter.im/ArduPilot/MissionPlanner?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge) [![Build status](https://ci.appveyor.com/api/projects/status/2c5tbxr2wvcguihp?svg=true)](https://ci.appveyor.com/project/meee1/missionplanner)

Website : http://ardupilot.org/planner/  

Forum : http://discuss.ardupilot.org/c/ground-control-software/mission-planner

Download latest stable version : http://firmware.ardupilot.org/Tools/MissionPlanner/MissionPlanner-latest.msi

Changelog : https://github.com/ArduPilot/MissionPlanner/blob/master/ChangeLog.txt  

License : https://github.com/ArduPilot/MissionPlanner/blob/master/COPYING.txt  


## How to compile

### On Windows (Recommended)

#### 1. Install software

##### Main requirements

Currently, Mission Planner needs:

- Microsoft .NET Framework 4.6.1
- Microsoft .NET standard 2.0

##### IDE

###### Visual Studio Community
The recommended way to compile Mission Planner is through Visual Studio. You could do it with Visual Studio Community (version 15.3 or newer to include .NET standard 2.0) : [Visual Studio Download page](https://visualstudio.microsoft.com/downloads/ "Visual Studio Download page").
Visual Studio suite is quite complet and comes with Git support. On installation phase, please install support for :
- Developpement .NET Desktop
- Microsoft .NET Framework 4.6.1
- Microsoft .NET standard 2.0

###### VSCode
Currently VSCode with C# plugin is able to parse the code but cannot build.

#### 2. Get the code

If you get Visual Studio Community, you should be able to use Git from the IDE. 
Just clone `https://github.com/ArduPilot/MissionPlanner.git` to get the full code.

In case you didn't install an IDE, you will need to manually install Git. Please follow instruction in https://ardupilot.org/dev/docs/where-to-get-the-code.html#downloading-the-code-using-git

#### 3. Build

To build the code:
- Open MissionPlanner.sln with Visual Studio
- Compile

### On other systems
Building Mission Planner on other systems isn't support currently.

## Launching Mission Planner on other system

Mission Planner can be use with Mono on non-Windows system. 
Be aware that all the functionnalities aren't working.

### On Linux

#### Requirements

Those instructions were tested on Ubuntu 18.04.
Please install Mono, either :
- ` sudo apt install mono-runtime libmono-system-windows-forms4.0-cil libmono-system-core4.0-cil libmono-winforms2.0-cil libmono-corlib2.0-cil libmono-system-management4.0-cil libmono-system-xml-linq4.0-cil`

or full Mono :
- `sudo apt install mono-complete`

#### Launching

- Get the lastest zipped version of Mission Planner here : https://firmware.ardupilot.org/Tools/MissionPlanner/MissionPlanner-latest.zip
- Unzip in the directory you want
- Go into the directory
- run with `mono MissionPlanner.exe`

You can debug Mission Planner on Mono with `MONO_LOG_LEVEL=debug mono MissionPlanner.exe`


[![FlagCounter](https://s01.flagcounter.com/count2/A4bA/bg_FFFFFF/txt_000000/border_CCCCCC/columns_8/maxflags_40/viewers_0/labels_1/pageviews_0/flags_0/percent_0/)](https://info.flagcounter.com/A4bA)


# Projet Delta
## Pour pull : 
- Git add .
- Git submodule update (voir google)
- Utiliser la ligne de commande pour changer la branche vers Dev : git checkout Dev (Dev avec un D majiscule)

## Apres le pull et checkout fonctionne :
- Installer les Dependences que visual studio propose a partir de visual sudio installer (normalement il s'ouvre automatiquement) : .NET / SDK
- Installer les librairies necessaires pour le plugin : LiveCharts / LiveCharts.WinForms / LiveCharts.Wpf/PresentationFramwork ( à partir de NuGet Manager) , si c'est deja installer il faut juste référer au bon endroit le .dll de la librairie dans le dossier locale (ca peut etre dans MissionPlanner/pachages/...)
- Les Packages de LiveCharts sont normalement dans : MissionPlanner/packages/…./…dll on les apportent en ajouter des references manuellement au projet du GraphiquePlugin
- Il faut être sur du chemin de la sortie du .dll dans les propriétés du projet : C:\Users\aliha\Documents\MissionPlanner\bin\Debug\net461\plugins    :   GraphiquePlugin.dll

![image](https://user-images.githubusercontent.com/43253813/205459700-d74f490d-425f-484b-8641-746eee4dfbe6.png)

## Changements

Pour trouver les parties de codes ajouté :  **chercher dans le code : Ctrl+F (ou find in files): Projet_Delta**

Le Projet de Plugin se trouve dans Plugins/GraphiquePlugin
### Les fishiers changé à l'Exterieure du projet plugin :
- MissionPlanner\ExtLibs\ArduPilot\Mavlink\MAVLinkInterface.cs
- Missionplanner\ExtLibs\Mavlink\Mavlink.cs
- Missionplanner\ExtLibs\Mavlink\message_definitions\ardupilotmega.xml
- Missionplanner\ExtLibs\ArduPilot\CurrentState.cs

