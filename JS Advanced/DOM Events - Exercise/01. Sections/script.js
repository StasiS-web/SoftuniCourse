function create(words) {
   let content = document.getElementById('content');

   for (let i = 0; i < words.length; i++) {
      let p = document.createElement('p');
      p.style.display = 'none';
      p.textContent = words[i];

      let newElement = document.createElement('div');
      newElement.addEventListener('click', displays);
      newElement.appendChild(p);

      function displays() { 
         p.style.display = 'block';
      }
      
      content.appendChild(newElement);
   }
}