@echo off

REM Set VS2010 environment
REM ~ %comspec% /k ""D:\devel\Microsoft Visual Studio 10.0\VC\vcvarsall.bat"" x86

""D:\devel\Microsoft Visual Studio 10.0\VC\vcvarsall.bat"" x86


pushd .
cd src/Edocsys
call publish.cmd
popd


pushd .
cd ssh
call publish-ssh.cmd
popd