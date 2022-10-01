function solve() {
    let text = document.getElementById('text').value;
    let conventionCase = document.getElementById('naming-convention').value;
    let result = '';

    if(conventionCase == "Camel Case") {
      result += camelCase(text);
    }
    else if (conventionCase == "Pascal Case") {
      result += pascalCase(text);
    }
    else {
      result += 'Error!';
    }

    document.getElementById('result').textContent = result;

    function camelCase(text) {
      let result = '';

      for (let i = 0; i < text.length; i++) {
        if(text[i] === ' ') {
            result += text[i + 1].toUpperCase();
            i++;
        }
        else {
          result += text[i].toLowerCase();
        }
      }

      return result;
    }

    function pascalCase(text) {
      let result = text[0].toUpperCase();

      for(let i = 1; i < text.length; i++) {
        if(text[i] === ' ') {
          result += text[i + 1].toUpperCase();
          i++;
        }
        else {
          result += text[i].toLowerCase();
        }
      }

      return result;
    }
}