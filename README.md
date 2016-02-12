# Unity3D Build

This is a Sublime Text 3 package to support Unity3D builds.
This is a fork of https://github.com/fredpointzero/UnityBuild as the original project is no longer maintained.

Tested with:
* Windows 7
* Unity 5.3.2p2
* Sublime Text 3 Build 3103 

The logger used is based on Jacob Pennock's logger
* [Blog](http://www.jacobpennock.com/Blog/using-sublime-text-2-with-unity3d-2/)
* [Unity3D Forum](http://forum.unity3d.com/threads/using-unity-with-sublime-text-2-how-to-get-everything-set-up.128352/)

## How to install

Clone this repo into `Sublime Text 3\Packages`.

## Usage

1) Create a ST3 project exactly named like the Unity3D project.
2) Select a build system `Tools -> Build System -> Unity`

Hint: You ST3 project file must have the same name as your project's `.sln` file

### Windows

`F7` starts the build. 
`Ctr+Shift+B` lets you select a between `build` and `clean`
`F4` jumps to the next error or warning
`Shift+F4` jumps to the previous error or warning

### OSX

TODO!

## How To Build

1) Build the Sublime Logger `.dll` from source.
2) Copy the `.dll` next to the `.sublime-build`.
