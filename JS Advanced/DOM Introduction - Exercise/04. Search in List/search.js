function search() {
   let towns = Array.from(document.querySelectorAll('ul li'));

   for(let i=0; i < towns.length; i++) {
      towns[i].style.textDecoration = 'none';
      towns[i].style.fontWeight = 'normal';
   }

   let patterns = document.getElementById('searchText').value.toLowerCase();
   let matches = 0;

   for(let i=0; i < towns.length; i++) {
      let char = towns[i].textContent.toLowerCase();

      if(char.includes(patterns)) {
         matches++;
         towns[i].style.textDecoration = 'underline';
         towns[i].style.fontWeight = 'bold';
      }
   }

   document.getElementById('result').textContent = `${matches} matches found`;
}
