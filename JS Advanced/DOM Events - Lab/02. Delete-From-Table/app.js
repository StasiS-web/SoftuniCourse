function deleteByEmail() {
    let takeEmail = document.querySelector('input').value;
    let allEmails = Array.from(document.querySelectorAll('tbody tr'));
    let result = document.getElementById('result');

    for(let i = 0; i < allEmails.length; i++) {
         if(allEmails[i].textContent.includes(takeEmail)) {
            result.textContent = 'Deleted.'
            allEmails[i].remove();
         }
        
         result.textContent = 'Not found.'
    }
}