<h1 align="center">
    <img src="docs/images/3d-space.png" width="1000px">
</h1>

> 3D Renderer is a project I made when I was around 12-13 to demonstrate my knowledge about matrix calculation & rendering I learned from documentations & tutorials over the internet.

It is a good template to use to create your own 3D XNA / Monogame game. It is using the [Monogame framework](https://www.monogame.net/) & the [Visual Studio Community IDE](https://visualstudio.microsoft.com/fr/downloads).

## How to move
Note that you can always adapt the keys to your needs. To modify the main keys (AZERTY to QWERTY) in Unity, go to `Camera.cs`, go down to the line `101`, and from that you can modify the keys to the one prefered *(Example: `Keys.Z` to `Keys.W`)*.
|Keyboard & Mouse keys      | Action                |
|---------------------------|-----------------------|
| `Z`                       | Move forward          |
| `S`                       | Move backwards        |
| `Q`                       | Go on the left        |
| `D`                       | Go on the right       |
| `Space`                   | Go Up                 |
| `Caps Lock`               | Go Down               |

## Getting Started
### Install Visual Studio 2019
Before installing Monogame, you'll need to install [Visual Studio 2019](https://visualstudio.microsoft.com/vs/) or later (any edition, including Community) with the following components, depending on your target platform:
* .NET cross-platform development - For Desktop OpenGL and DirectX platforms
* Mobile Development with .NET - For Android and iOS platforms
* Universal Windows Platform development - For Windows 10 and Xbox UWP platforms
* .Net Desktop Development - For Desktop OpenGL and DirectX platforms to target normal .NET Framework

<img src="docs/images/installer_vs_components.png" width="950px">
Once it's open, simply search for MonoGame in the top right search window, as shown above, and install the "MonoGame project templates". You now have the MonoGame templates installed, ready to create new projects.

### Install MonoGame extension for Visual Studio 2019
To create new projects from within Visual Studio, you will need to install the Visual Studio 2019 extension, which can be installed from "Extensions -> Manage Extensions" in the Visual Studio menu bar.
<img src="docs/images/visual_studio_extension_manager.png" width="950px">
Note that you can also install Monogame with the nuget package manager. For more informations, refer to [this tutorial](https://www.youtube.com/watch?v=YlN9PlJwDlg).
### Install MGCB Editor
MGCB Editor is a tool for editing .mgcb files, which are used for building content.

To register the MGCB Editor tool with Windows and Visual Studio 2019, run the following from the Command Prompt or run `scripts/install_mgcb_editor.bat`.
```batch
dotnet tool install --global dotnet-mgcb-editor
mgcb-editor --register
```

### [Optional] Install MonoGame templates for .NET CLI or Rider IDE
```bat
dotnet new --install MonoGame.Templates.CSharp
```

## Clone it
```bat
git clone https://github.com/vertueux/rendering.git
```

Now, you can open it in your Visual Studio IDE by clicking on the solution file ```RenderingDemo.sln``` from the file explorer.
You can now run this project by clicking on the green flag in your Visual Studio IDE.

--- 
Note: This project only has been tested on Windows.