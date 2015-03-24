type .\markdown\*.md >> .\markdown\combine.markdown

node run.js
.\node_modules\bin\wkhtmltopdf .\markdown\result.html documentation.pdf

del .\markdown\combine.markdown
del .\markdown\result.html