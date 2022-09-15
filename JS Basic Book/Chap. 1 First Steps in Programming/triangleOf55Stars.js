'use strict'

function solve() {
    let n = '*';
    let count = 0;

    for(count = 1; count <= 10; count++) {
        console.log(n.repeat(count));
    }
}

solve();