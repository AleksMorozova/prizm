@echo off

set DEVENV_BIN="C:\Program Files (x86)\Microsoft Visual Studio 11.0\Common7\IDE\devenv.exe"
set EXTERNAL_PATH=.\..\prizm_external\external\
set NUNIT_BIN=%EXTERNAL_PATH%NUnit-2.6.3\bin\nunit-console.exe

call:GetLogTimeStamp
call:GetLogFileNames %LOGTIMESTAMP% comp


call:Banner "Rebuilding..."
%DEVENV_BIN% src/PrizmMainSolution.sln /rebuild release /out .\%LOGNAME% 2> .\%LOGNAMEERR%
call:CheckError %LOGNAMEERR% break


call:Banner "Running unit tests..."
call:GetLogFileNames %LOGTIMESTAMP% unit
set TESTRESULT=TestResult.xml
%NUNIT_BIN% ./src/UnitTests/bin/Release/UnitTests.dll > .\%LOGNAME% 2> .\%LOGNAMEERR%
findstr success=\"False\" %TESTRESULT% >> .\%LOGNAMEERR%
ren %TESTRESULT% TestResult_%LOGTIMESTAMP%.xml
call:CheckError %LOGNAMEERR%


call:Banner "Creating installation package..."
cd install
call:GetLogFileNames %LOGTIMESTAMP% inst
call !Compile.cmd > .\..\%LOGNAME% 2> .\..\%LOGNAMEERR%
cd ..
call:CheckError %LOGNAMEERR%


call:Banner "Creating documentation..."
cd docuser
call:GetLogFileNames %LOGTIMESTAMP% doc
call !run.bat > .\..\%LOGNAME% 2> .\..\%LOGNAMEERR%
cd ..
call:CheckError %LOGNAMEERR%


call:Banner "All done."

goto:eof

rem --------------------
:CheckError

for %%A in (%~1) do (
   if %%~zA==0 (
       if exist %~1 del %~1
   ) else (
       call:Banner "Errors! check %~1."
       if "%~2" neq "" exit
   )
)

goto:eof

rem --------------------
:Banner

echo ============== %~1

goto:eof

rem --------------------
:GetLogFileNames

set LOGNAME=log_%~1_%~2.txt
set LOGNAMEERR=log_%~1_%~2err.txt

goto:eof

rem --------------------
rem http://stackoverflow.com/questions/1192476/format-date-and-time-in-a-windows-batch-script
rem --------------------
:GetLogTimeStamp

:: Check WMIC is available
WMIC.EXE Alias /? >NUL 2>&1 || GOTO s_error

:: Use WMIC to retrieve date and time
FOR /F "skip=1 tokens=1-6" %%G IN ('WMIC Path Win32_LocalTime Get Day^,Hour^,Minute^,Month^,Second^,Year /Format:table') DO (
   IF "%%~L"=="" goto s_done
      Set _yyyy=%%L
      Set _mm=00%%J
      Set _dd=00%%G
      Set _hour=00%%H
      SET _minute=00%%I
      SET _second=00%%K
)
:s_done

:: Pad digits with leading zeros
      Set _mm=%_mm:~-2%
      Set _dd=%_dd:~-2%
      Set _hour=%_hour:~-2%
      Set _minute=%_minute:~-2%
      Set _second=%_second:~-2%

Set logtimestamp=%_yyyy%-%_mm%-%_dd%_%_hour%_%_minute%_%_second%
goto make_dump

:s_error
echo WMIC is not available, using default log filename
Set logtimestamp=_

:make_dump

goto:eof
rem --------------------
