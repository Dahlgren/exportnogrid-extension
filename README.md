# ExportNoGrid

Native extension for Arma that triggers ExportNoGrid using a AutoHotKey binary.

Make sure the exportnogrid.exe is right next to the built dll.

## Supported calls

### export

Starts the process, returns the PID of the process

### reset

Kills any running process and resets the extension state

### status

Returns True / False depending on if the process is running

### version

Returns the current version
