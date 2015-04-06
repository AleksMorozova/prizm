@echo off & setlocal ENABLEEXTENSIONS

set BIN=..\..\prizm_external\external\Documentation\Modules
set CONTENT=content.md
set HCONTENT=content.html

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

echo. >> %CONTENT%
type .\content\00Header.md >> %CONTENT%

FOR /F "delims=" %%F IN ('type %~1.txt') DO (
   set MERGED=MERGED
   echo. >> %CONTENT%
   type "%%F" >> %CONTENT%
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
%BIN%\Wkh\wkhtmltopdf .\%HCONTENT% %PDFFILE%

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
