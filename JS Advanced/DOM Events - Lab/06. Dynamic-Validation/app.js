function validate() {
    let email = document.getElementById('email');
    email.addEventListener('change', error);

   function error(event) {
        let regex = new RegExp(/\w+@\w+.\w+/);

        if (regex.test(email.value)) {
            event.target.classList.remove('error');
        }
        else {
           event.target.classList.add('error');
        }
   }
}