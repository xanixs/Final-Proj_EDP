[Setup]
AppName=EDP
AppVersion=1.0
AppPublisher=nicolet
DefaultDirName={autopf}\EDP
DefaultGroupName=EDP
OutputDir=C:\Users\NicoleB\Downloads\EDP
OutputBaseFilename=EDP
Compression=lzma
SolidCompression=yes
ArchitecturesAllowed=x64
ArchitecturesInstallIn64BitMode=x64
ChangesAssociations=yes
DisableProgramGroupPage=yes
WizardStyle=modern

[Dirs]
Name: "{app}"

[Files]
; Main executable
Source: "C:\Users\NicoleB\Downloads\EDP\bin\Debug\EDP.exe"; DestDir: "{app}"; Flags: ignoreversion

; All DLLs in Debug folder
Source: "C:\Users\NicoleB\Downloads\EDP\bin\Debug\*.dll"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs

; SQL file
Source: "C:\Users\NicoleB\OneDrive\Documents\dumps\apartmentdatabase.sql"; DestDir: "{app}"; Flags: ignoreversion

; Other necessary files (excluding EXE and DLLs to prevent duplicates)
Source: "C:\Users\NicoleB\Downloads\EDP\bin\Debug\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs; Excludes: "*.exe,*.dll"

[Icons]
; Start menu shortcut
Name: "{group}\EDP"; Filename: "{app}\EDP.exe"

; Optional desktop shortcut
Name: "{commondesktop}\EDP"; Filename: "{app}\EDP.exe"; Tasks: desktopicon

[Tasks]
Name: "desktopicon"; Description: "Create a &desktop shortcut"; GroupDescription: "Additional icons:"

[Run]
Filename: "{app}\EDP.exe"; Flags: nowait postinstall skipifsilent