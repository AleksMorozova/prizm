var marked = require('marked'), fs = require('fs');
var options = {encoding:"utf8"};

fs.readFile('.\\markdown\\combine.markdown', options, function(err, data){
    fs.writeFile(".\\markdown\\result.html","\ufeff" + marked(data),options);
});