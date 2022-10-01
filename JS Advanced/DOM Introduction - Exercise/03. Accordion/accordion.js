function toggle() {
    let button = document.getElementsByClassName('button')[0];
    let displayStyle = document.getElementById('extra');

    switch(button.textContent) {
        case 'More':
            button.textContent = 'Less';
            displayStyle.style.display = 'block';
            break;
        case 'Less':
            button.textContent = 'More';
            displayStyle.style.display = 'none';
         break;
    }
}