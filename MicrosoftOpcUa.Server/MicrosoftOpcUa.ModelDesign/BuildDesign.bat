@echo off
setlocal

REM SET PATH=%PATH%;..\..\..\Scripts;..\..\Bin;..\..\..\Bin

echo Microsoft Building ModelDesign
Opc.Ua.ModelCompiler.exe -d2 ".\ModelDesign.xml" -cg ".\ModelDesign.csv" -o2 ".\"
echo Success!

copy MicrosoftOpcUa.Constants.cs ..\Client
copy MicrosoftOpcUa.DataTypes.cs ..\Client


