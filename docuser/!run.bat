set MOD=..\..\prizm_external\external\Documentation\Modules

type .\content\*.md >> .\content\combine.markdown

node htmlconverter.js
%MOD%\Wkh\wkhtmltopdf .\content\result.html ".\Documentation\PRISM v.2 Users Guide.pdf"

del .\content\combine.markdown
del .\content\result.html