REM ~ %comspec% /k ""D:\devel\Microsoft Visual Studio 10.0\VC\vcvarsall.bat"" x86

""D:\devel\Microsoft Visual Studio 10.0\VC\vcvarsall.bat"" x86

REM ~ @echo off


pushd .
cd src/Edocsys
call publish.cmd
popd


pushd .
cd ssh
call publish-ssh.cmd
popd