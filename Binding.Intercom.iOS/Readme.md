The manifest file is included to compensate for differences between compilation on a Windows machine, where it's not included in the nuget package, and compilation on a Mac machine, where it is included.

When updating the native library, make sure to also update the manifest file by copying it from the output folder, after building on a Mac.