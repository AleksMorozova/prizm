ECHO OFF

IF [%1]==[] (
ECHO TEMPLATE NOT SET
EXIT 1
)

SET "name=%1"
SET "file=%name%.resources"
SET date=%DATE:~10,4%%DATE:~4,2%%DATE:~7,2%

echo RESULT = %file%

IF EXIST %name%.txt (
 IF EXIST .\Resources\%file% (
 echo EXISTED FILE WILL BE BACKUPED
 ren .\Resources\%file% %name%-%date%.bak
 ) ELSE (
 rem
 )
.\Resources\Resgen %name%.txt .\Resources\%name%.resources
) ELSE (
echo TEMPLATE NOT EXIST
)