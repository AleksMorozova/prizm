var marked = require('..\\..\\prizm_external\\external\\Documentation\\Modules\\marked'), fs = require('fs');
var options = {encoding:"utf8"};

fs.readFile('.\\content.md', options, function(err, data){
    fs.writeFile(".\\content.html","\ufeff" + marked(data),options);
});