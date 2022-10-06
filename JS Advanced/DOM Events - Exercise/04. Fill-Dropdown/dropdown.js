function addItem() {
    let inputText = document.getElementById('newItemText');
    let inputValue = document.getElementById('newItemValue');
    let optElement = document.createElement('option');

    if(inputText.value !== '' && inputValue.value !== '') {
        optElement.textContent = inputText.value;
        optElement.value = inputValue.value;
        document.getElementById('menu').appendChild(optElement);
    }

    inputText.value = '';
    inputValue.value = '';
}