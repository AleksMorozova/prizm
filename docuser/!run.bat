@echo off & setlocal ENABLEEXTENSIONS

set BIN=..\..\prizm_external\external\Documentation\Modules
set CONTENT=content.md
set HCONTENT=content.html
set HEADER=00Header.md
set MDFOLDER=.\content\

call:ProcessMds

call:ProcessOne ListMill             "PRISM v.2 Mill User Guide (ru).pdf"
call:ProcessOne ListMaster           "PRISM v.2 Master User Guide (ru).pdf"
call:ProcessOne ListConstruction     "PRISM v.2 Construction User Guide (ru).pdf"
call:ProcessOne ListInstallation     "PRISM v.2 Installation Guide (ru).pdf"
call:ProcessOne ListCustomReports    "PRISM v.2 Custom Reports Guide (ru).pdf"
call:ProcessOne ListCustomReportsEng "PRISM v.2 Custom Reports Guide (en).pdf"
call:ProcessOne ListTranslation      "PRISM v.2 Translation Guide (ru).pdf"

echo All done.

goto:eof



rem --------------------
:ProcessMds

rem --- Check if used at least in one txt file

FOR /F "delims=" %%F IN ('dir /b /a-d-h-s %MDFOLDER%*.md') DO (
    IF "%%F" neq "%HEADER%" (
       call:SetFound
       FOR /F %%I in ('findstr %%F List*.txt') do (
          call:SetFound %%I 
       )
       call:CheckFound %%F
   )
)

goto:eof

rem --------------------
rem this method is necessary because simple checking inside FOR does not work in batch file
:CheckFound
   if "%FOUND%" equ "" (
       echo File %~1 is not a member of any document. >&2
   )
goto:eof

rem --------------------
rem this method is necessary because simple set inside FOR does not work in batch file
:SetFound
   set FOUND=%~1
goto:eof

rem --------------------
:ProcessOne

echo =======================================================================================
echo Processing:  %~1  to  %~2 
echo =======================================================================================

call:DeleteTmpFiles

set MERGED=

call:MergeSections %~1

if "%MERGED%" neq "" (
   call:CreatePDF "%~2"
) else (
   echo "%~2" can not be created: merged file is empty. 1>&2
)

call:DeleteTmpFiles

echo %~1 done.

goto:eof

rem --------------------
:MergeSections

type %MDFOLDER%%HEADER% >> %CONTENT%

FOR /F "delims=" %%F IN ('type %~1.txt') DO (
   set MERGED=MERGED
   echo. >> %CONTENT%
   call deBom %%F >> %CONTENT%
   echo. >> %CONTENT%
)

echo Combined file created.

goto:eof

rem --------------------
:CreatePDF

echo Convert to HTML...
node htmlconverter.js

set PDFFILE=".\Documentation\%~1"

echo Removing old file %PDFFILE% ...
call:DeleteFile %PDFFILE%

echo Convert HTML to PDF %PDFFILE% ...
%BIN%\Wkh\wkhtmltopdf .\%HCONTENT% %PDFFILE% 2>&1

goto:eof

rem --------------------
:DeleteTmpFiles

echo Removing temporary files ...

call:DeleteFile %CONTENT%
call:DeleteFile %HCONTENT%

goto:eof

rem --------------------
:DeleteFile

if exist %~1 del %~1

goto:eof
rem --------------------
