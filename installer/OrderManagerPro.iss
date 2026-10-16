; OrderManagerPro Inno Setup Script
; Production installer packaging for Windows 10 & 11
; Biohazard Corp / Creator-NL

#define MyAppName "OrderManagerPro"
#define MyAppVersion "1.0.0"
#define MyAppPublisher "Biohazard Corp / Creator-NL"
#define MyAppURL "https://github.com/Creator-NL/OrderManagerPro"
#define MyAppExeName "OrderManagerPro.exe"

[Setup]
AppId={{78A9D746-3E28-4DCE-8868-903FD2F73509}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppVerName={#MyAppName} v{#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}/issues
AppUpdatesURL={#MyAppURL}/releases
DefaultDirName={autopf}\Biohazard Corp\{#MyAppName}
DefaultGroupName={#MyAppName}
DisableProgramGroupPage=yes
LicenseFile=..\LICENSE
OutputDir=output
OutputBaseFilename={#MyAppName}-Setup-v{#MyAppVersion}
SetupIconFile=..\OrderManagerPro\OrderIcon.ico
Compression=lzma2/ultra64
SolidCompression=yes
ArchitecturesInstallIn64BitMode=x64compatible
PrivilegesRequired=admin
WizardStyle=modern
UninstallDisplayIcon={app}\{#MyAppExeName}

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "dutch"; MessagesFile: "compiler:Languages\Dutch.isl"
Name: "german"; MessagesFile: "compiler:Languages\German.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
; Main Executable & Configuration
Source: "..\OrderManagerPro\bin\Release\OrderManagerPro.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\OrderManagerPro\bin\Release\OrderManagerPro.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\LICENSE"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\README.md"; DestDir: "{app}"; Flags: ignoreversion

; Database Scripts
Source: "..\database\schema.sql"; DestDir: "{app}\database"; Flags: ignoreversion
Source: "..\database\seed_data.sql"; DestDir: "{app}\database"; Flags: ignoreversion

; Pre-seeded Database file into C:\DataBase (if not already existing)
Source: "C:\DataBase\DatabaseOrderManagerPro.mdf"; DestDir: "C:\DataBase"; Flags: onlyifdoesntexist uninsneveruninstall
Source: "C:\DataBase\DatabaseOrderManagerPro_log.ldf"; DestDir: "C:\DataBase"; Flags: onlyifdoesntexist uninsneveruninstall

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; IconFilename: "{app}\{#MyAppExeName}"
Name: "{group}\{cm:UninstallProgram,{#MyAppName}}"; Filename: "{uninstallexe}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent
