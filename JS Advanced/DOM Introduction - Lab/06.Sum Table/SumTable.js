function sumTable() {
    const rows = Array.from(document.querySelectorAll('table tr')).slice(1, -1);
    let sum = 0;

    for(const row of rows) {
        sum += Number(row.lastElementChild.textContent);
    }

    document.getElementById('sum').textContent = sum;
}