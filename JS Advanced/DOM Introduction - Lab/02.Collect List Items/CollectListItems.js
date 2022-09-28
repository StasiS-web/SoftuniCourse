function extractText() {
    let listItems = Array.from(document.querySelectorAll('li'));
    let result = listItems.map(e => e.textContent).join('\n');

    document.getElementById('result').textContent = result;
}