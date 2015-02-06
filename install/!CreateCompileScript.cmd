@set COMPILE_CMD_FILE=!Compile.cmd

@if not exist %COMPILE_CMD_FILE% goto CreateFile

@set /p ANSWER=Do you want to remove old %COMPILE_CMD_FILE% [Y/N]?

if "%ANSWER%" == "Y" or if "%ANSWER%" == "y" (
   del %COMPILE_CMD_FILE%
   goto CreateFile
)

   echo Exiting...
   exit



:CreateFile

@echo set PRIZM_EXTERNAL=..\..\prizm_external> %COMPILE_CMD_FILE%
@echo set DEV_EXPRESS14_PATH=C:\Program Files (x86)\DevExpress 14.2\Components\Bin\Framework\>> %COMPILE_CMD_FILE%
@echo.  >> %COMPILE_CMD_FILE%
@echo FOR /F "delims=" %%%%F IN (^'..\src\bin\Release\Version.exe ..\src\bin\Release\Prism.Program.exe^') DO @SET VERSION=%%%%F >> %COMPILE_CMD_FILE%
@echo FOR /F "delims=" %%%%F IN (^'..\src\bin\Release\Version.exe ..\src\bin\Release\Prism.Data.dll^') DO @SET DATA_VERSION=%%%%F >> %COMPILE_CMD_FILE%
@echo FOR /F "delims=" %%%%F IN (^'..\src\bin\Release\Version.exe ..\src\bin\Release\Prism.DatabaseMigrator.exe^') DO @SET MIGRATOR_VERSION=%%%%F >> %COMPILE_CMD_FILE%
@echo FOR /F "delims=" %%%%F IN (^'..\src\bin\Release\Version.exe ..\src\bin\Release\Prism.Domain.dll^') DO @SET DOMAIN_VERSION=%%%%F >> %COMPILE_CMD_FILE%
@echo.  >> %COMPILE_CMD_FILE%
@echo if "%%VERSION%%" == "" (  >> %COMPILE_CMD_FILE%
@echo echo Version is empty! Exiting...   >> %COMPILE_CMD_FILE%
@echo exit  >> %COMPILE_CMD_FILE%
@echo )  >> %COMPILE_CMD_FILE%
@echo.  >> %COMPILE_CMD_FILE%
@echo if "%%DATA_VERSION%%" == "%%VERSION%%" (  >> %COMPILE_CMD_FILE%
@echo    if "%%MIGRATOR_VERSION%%" == "%%VERSION%%" (  >> %COMPILE_CMD_FILE%
@echo       if "%%DOMAIN_VERSION%%" == "%%VERSION%%" (  >> %COMPILE_CMD_FILE%
@echo          goto CreateInstallationPackage  >> %COMPILE_CMD_FILE%
@echo       )  >> %COMPILE_CMD_FILE%
@echo    ) >> %COMPILE_CMD_FILE%
@echo ) >> %COMPILE_CMD_FILE%
@echo echo Version of packages do not correspond:  >> %COMPILE_CMD_FILE%
@echo echo Program: %%VERSION%%  >> %COMPILE_CMD_FILE%
@echo echo Data: %%DATA_VERSION%%  >> %COMPILE_CMD_FILE%
@echo echo Domain: %%DOMAIN_VERSION%%  >> %COMPILE_CMD_FILE%
@echo echo Migrator: %%MIGRATOR_VERSION%%  >> %COMPILE_CMD_FILE%
@echo echo Exiting...  >> %COMPILE_CMD_FILE%
@echo exit  >> %COMPILE_CMD_FILE%
@echo.  >> %COMPILE_CMD_FILE%
@echo.  >> %COMPILE_CMD_FILE%
@echo :CreateInstallationPackage  >> %COMPILE_CMD_FILE%
@echo.  >> %COMPILE_CMD_FILE%
@echo echo #define MyAppVersion "%%VERSION%%" ^> version.txt >> %COMPILE_CMD_FILE%
@echo.  >> %COMPILE_CMD_FILE%
@echo "%ProgramFiles(x86)%\Inno Setup 5\iscc" "%CD%\prizm_demo_installer_script.iss" >> %COMPILE_CMD_FILE%