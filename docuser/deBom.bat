@rem http://im.snibgo.com/snutf8.htm#debom

@rem Removes any Byte Order Marks (BOM) in a file.

@setlocal enabledelayedexpansion

@set BOMFILE=%~dp0bom.txt

@if not exist %BOMFILE% @(
  @echo Can't find %BOMFILE%
  @exit /B 1
)

@for /F %%a in (%BOMFILE%) do @set bom=%%a

@for /F "tokens=*" %%a in (%1) do @(
  @set line=%%a
  @set line=!line:%bom%=!
  @echo !line!
)
@exit /B 0