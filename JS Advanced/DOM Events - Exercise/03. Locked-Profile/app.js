function lockedProfile() {
    const buttons = Array.from(document.querySelectorAll('button'));
    
    function showHiddenInfo(event) {
        const profile = event.target.parentElement;
        const isLocked = profile.querySelector('input[type="radio"]').checked
        let btn = profile.querySelector('button');
        let info = profile.querySelector('div');

        if (!isLocked) {
            if(event.target.textContent === 'Show more') {
                info.style.display = 'block';
                btn.textContent = 'Hide it';
            }
            else if(event.target.textContent === 'Hide more') {
                info.style.display = 'none';
                btn.textContent = 'Show more';
            }
        }
    }

    for (let button of buttons) {
        button.addEventListener('click', showHiddenInfo);
    }
}