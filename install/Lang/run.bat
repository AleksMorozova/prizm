rem ECHO OFF

IF [%1]==[] (
ECHO TEMPLATE NOT SET
EXIT 1
)

SET "name=%1"
SET "file=%name%.resources"
SET date=%DATE:~10,4%%DATE:~4,2%%DATE:~7,2%
SET DIR=%~dp0
IF  [%2]==[] (
SET RESGEN_PATH=%DIR%Resources
SET LOCAL=
SET RESOURCES=Resources\
) ELSE (
SET RESGEN_PATH=%2\external\Lang
SET LOCAL=Translations\
SET RESOURCES=Translations\
)

echo RESULT = %file%

IF EXIST %DIR%%LOCAL%%name%.txt (
 IF EXIST %DIR%%RESOURCES%%file% (
 echo EXISTED FILE WILL BE BACKUPED
 ren %DIR%%RESOURCES%%file% %name%-%date%.bak
 ) ELSE (
 rem
 )
%RESGEN_PATH%\Resgen %DIR%%LOCAL%%name%.txt %DIR%%RESOURCES%%name%.resources
) ELSE (
echo TEMPLATE NOT EXIST
)