function solve() {
   let content = document.getElementById('input').value;
   let splitContent = content.split('.').filter(s => s !== '');
   let result = document.getElementById('output');

   while (splitContent[0]) {
      let text = document.createTextNode('');

      for(let i = 0; i < 3; i++) {
          if(splitContent[0])  {
            text.appendData(splitContent[0] + '.');
            splitContent.shift();
          }
      }

      let child = document.createElement('p');
      child.appendChild(text);
      result.appendChild(child);
   }
}