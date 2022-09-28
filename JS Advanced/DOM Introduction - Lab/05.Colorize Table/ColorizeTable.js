function colorize() {
    let row = Array.from(document.querySelectorAll('tr:nth-child(2n)'));

    for(let i = 0; i < row.length; i++) {
        row[i].style.background = 'Teal'
    }
}