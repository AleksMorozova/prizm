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
@echo "%ProgramFiles(x86)%\Inno Setup 5\iscc" "%CD%\prizm_demo_installer_script.iss" >> %COMPILE_CMD_FILE%