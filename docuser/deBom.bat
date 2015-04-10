@rem Removes any Byte Order Marks (BOM) in a file.

@set BOMFILE=%~dp0bom.txt

@if not exist %BOMFILE% @(
  @echo Can't find %BOMFILE%
  @exit /B 1
)

@for /F %%a in (%BOMFILE%) do @set bom=%%a

@for /F "tokens=*" %%a in (%1) do @(
  @set line=%%a
  @call set line=%%line:%bom%=%%
  @call echo. %%line%%
)
@exit /B 0