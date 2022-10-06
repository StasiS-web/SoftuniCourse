function attachEventsListeners() {
    let button = document.getElementById('convert');
    
    button.addEventListener('click', () => {
        let input = Number(document.getElementById('inputDistance').value);
        let inputUnits = document.getElementById('inputUnits').value;

        switch(inputUnits) {
            case 'km':
                input *=  1000;
                break;
            case 'cm':
                input /=  100;
                break;
            case 'mm':
                input = input / 100 / 10;
                break;
            case 'mi':
               input *= 1609.34;
               break;
            case 'yrd':
                input *= 0.9144;
                break;
            case 'ft':
                input *= 0.3048;
                break;
            case 'in':
                input *= 0.0254;
                break;
        }

        let outputUnits = document.getElementById('outputUnits').value;
        let output = document.getElementById('outputDistance');

        switch(outputUnits) {
            case 'km':
                input /=  1000;
                break;
            case 'cm':
                input *=  100;
                break;
            case 'mm':
                input = input * 100 * 10;
                break;
            case 'mi':
               input /= 1609.34;
               break;
            case 'yrd':
                input /= 0.9144;
                break;
            case 'ft':
                input /= 0.3048;
                break;
            case 'in':
                input /= 0.0254;
                break;
        }
        
        output.value = input;
    });
}