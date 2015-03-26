var marked = require('..\\..\\prizm_external\\external\\Documentation\\Modules\\marked'), fs = require('fs');
var options = {encoding:"utf8"};

fs.readFile('.\\content\\combine.markdown', options, function(err, data){
    fs.writeFile(".\\content\\result.html","\ufeff" + marked(data),options);
});