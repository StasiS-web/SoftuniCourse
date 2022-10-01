function solve() {
   document.querySelector('#searchBtn').addEventListener('click', onClick);

   function onClick() {
      let tableContent = Array.from(document.querySelectorAll('tbody, tr'));
      let inputText = document.getElementById('searchField').value.toLowerCase();

      for(let element of tableContent) {  

         if(element.textContent.toLowerCase().includes(inputText)) {
              element.classList.add('select');
         }
         else {
            element.classList.remove('select');
         }
      }
      document.getElementById('searchField').value = '';
   }
}