# Amazon Store Desktop App
![Platform](https://img.shields.io/badge/platform-Windows-0078d7)
![Framework](https://img.shields.io/badge/framework-.NET%208-512bd4)
![License](https://img.shields.io/badge/license-MIT-green)

A dedicated Windows desktop application for a streamlined Amazon shopping experience. Built using **.NET 8** and **WebView2**, this app provides a native-like environment that is faster and more focused than a standard web browser.

## ✨ Key Features
- **Modern Engine:** Powered by Microsoft Edge WebView2 for high security and performance.
- **Native Experience:** WinForms integration with .NET 8.0 for Windows 10/11.
- **Optimized Build:** Published as a self-contained, single-file executable.

## 📦 Installation
Ready-to-use installers are available in the **[Releases](https://github.com/YOUR_USERNAME/YOUR_REPO_NAME/releases)** section. 

1. Download the latest `amazon.msi`.
2. Run the installer and follow the setup wizard.
3. Launch "Amazon Store" from your Desktop.

## 🛠 Prerequisites for Development
To build this project locally, you will need:
- [Visual Studio 2022](https://visualstudio.microsoft.com/) or [VS Code](https://code.visualstudio.com/)
- [.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [WiX Toolset v4](https://wixtoolset.org/)

## 🚀 Building the Project
If you want to compile the project yourself, run the following commands in your terminal:

### 1. Publish the App
```powershell
dotnet publish -r win-x64 --self-contained true -p:PublishSingleFile=true -o bin\Release\net8.0-windows\win-x64\publish\
```
### 2. Build the Installer
```powershell
wix build amazon.wxs -o amazon.msi
```
