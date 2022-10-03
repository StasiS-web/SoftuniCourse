function addItem() {
    let input = document.getElementById('newItemText').value;
    let list = document.getElementById('items');
    let addNewItem = document.createElement('li');

    let links = document.createElement('a');
    links.href = '#';
    links.textContent = '[Delete]'
    
    addNewItem.textContent = input;
    addNewItem.appendChild(links);
    links.addEventListener('click', Delete);

    list.appendChild(addNewItem);
    input = '';

    function Delete(e){
        e.target.parentElement.remove();
    }
}