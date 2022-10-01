function solve() {
    document.querySelector('#selectMenuTo option').textContent = 'Binary';
    document.querySelector('#selectMenuTo option').value = 'binary'
    const selectTo = document.getElementById('selectMenuTo');
    selectTo.innerHTML += '<option selected value="hexadecimal">Hexadecimal</option>';

    let btn = document.querySelector('#container button');
     
    btn.onclick = function convert() {
        const number = Number(document.getElementById('input').value);
        let output = document.getElementById('result');
        let result = '';

        switch (selectTo.value) {
            case 'binary': 
                result = number.toString(2);
            break;

            case 'hexadecimal':
                result = number.toString(16).toUpperCase();
            break;
        }

        output.value = result;
    }
}
   