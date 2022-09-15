'use strict'

function wordsUppercase(text) { 
    text = text.toUpperCase().match(/\w+/g).filter(w => w !== '');

    console.log(text.join(', '));
}

wordsUppercase('Hi, how are you?');
console.log('-------------')
wordsUppercase('hello');