function addItem() {
    let input = document.getElementById('newItemText').value;
    let list = document.getElementById('items');
    let addNewItem = document.createElement('li');
    
    addNewItem.textContent = input;
    list.appendChild(addNewItem);
    input = '';
}