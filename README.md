UnityBuild
========

This is an extension of Sublime Text 2 to support Unity 3d builds.

Use Unity as build system and enjoy !

Windows
========

If it does not work at the first time, check the xbuild path in UnityBuild.sublime-build (it uses the default location of Unity)
(C:\\Program Files (x86)\\Unity\\Editor\\Data\\Mono\\bin\\)

OSX
========

Make sure you have MonoDevelop 2.10.2 installed on your OSX in the default location.
If get it here : http://download.mono-project.com/archive/2.10.2/macos-10-x86/5.4/MonoFramework-MRE-2.10.2_5.4.macos10.novell.x86.dmg

If it does not work at the first time, check the xbuild path in UnityBuild.sublime-build (it uses the default location of Unity)
(/Applications/Unity/MonoDevelop.app/Contents/Frameworks/Mono.framework/Commands/xbuild)


NB : The logger used is based on Jacob Pennock's logger