function focused() {
   let inputs = Array.from(document.querySelectorAll('input'));
   
   inputs.forEach(event => {
            event.addEventListener('focus', Focus);
            event.addEventListener('blur', Blur);
   });

    function Focus (event) {
        event.target.parentElement.classList.add('focused');
    }

    function Blur (event) {
        event.target.parentElement.classList.remove('focused');
    }
}