function attachEvents() {
    let location = document.getElementById('location');
    let getBtn = document.getElementById('submit');
    let divDisplay = document.getElementById('forecast');
    let currDiv = document.getElementById('current');
    let upcoming = document.getElementById('upcoming');
    let url = 'http://localhost:3030/jsonstore/forecaster';
   
    let symbol = {
        'Sunny': '&#x2600',  // ☀
        'Partly sunny': '&#x26C5',  // ⛅ 
        'Overcast': '&#x2601', // ☁
        'Rain': '&#x2614' // ☂
    }

    let degrees = `&#176`; 
    let code = '';
    let divItemUpcoming = document.createElement('div');
    let divItemCurrent = document.createElement('div');

    getBtn.addEventListener('click', (event) => {
        divItemUpcoming.innerHTML = '';
        divItemCurrent.innerHTML = '';

        divItemUpcoming.setAttribute('class', 'forecast-info');
        divItemCurrent.setAttribute('class', 'forecast');

        divDisplay.style.display = 'inline';

        fetch(`${url}/locations`)
            .then(response => response.json())
            .then(data => {
                data.forEach(locationInfoObj => {
                    if(locationInfoObj.name === location.value) {
                        return code = locationInfoObj.code;
                    }
                });

                fetch(`${url}/today/${code}`)
                    .then(response => response.json())
                    .then(data => {
                        let spanGroup = document.createElement('span');
                        let conditionSpan = document.createElement('span');
                        let temperatureSpan = document.createElement('span');
                        let locationSpan = document.createElement('span');
                        let iconSpan = document.createElement('span');

                        iconSpan.setAttribute('class', 'condition symbol');
                        spanGroup.setAttribute('class', 'condition');
                        locationSpan.setAttribute('class', 'forecast-data');
                        temperatureSpan.setAttribute('class', 'forecast-data');
                        conditionSpan.setAttribute('class', 'forecast-data');

                        locationSpan.textContent = data.name;
                        temperatureSpan.innerHTML = `${data.forecast.low}${degrees}/${data.forecast.high}${degrees}`;
                        conditionSpan.textContent = data.forecast.condition;

                        switch(data.forecast.condition) {
                            case 'Sunny': iconSpan.innerHTML = symbol.Sunny; break;
                            case 'Partly sunny': iconSpan.innerHTML = symbol["Partly sunny"]; break;
                            case 'Overcast': iconSpan.innerHTML = symbol.Overcast; break;
                            case 'Rain': iconSpan.innerHTML = symbol.Rain; break;
                        }

                        spanGroup.appendChild(locationSpan);
                        spanGroup.appendChild(temperatureSpan);
                        spanGroup.appendChild(conditionSpan);
                        divItemCurrent.appendChild(iconSpan);
                        divItemCurrent.appendChild(spanGroup);

                        currDiv.appendChild(divItemCurrent);
                    })
                    . catch(error => console.log(error))

                fetch(`${url}/upcoming/${code}`)
                    .then(response => response.json())
                    .then(data => {
                        let nextDays = data.forecast;

                        nextDays.forEach(x => {
                            let spanGroup = document.createElement('span');
                            let conditionSpan = document.createElement('span');
                            let temperatureSpan = document.createElement('span');
                            let iconSpan = document.createElement('span');

                            iconSpan.setAttribute('class', 'symbol');
                            spanGroup.setAttribute('class', 'upcoming');
                            temperatureSpan.setAttribute('class', 'forecast-data');
                            conditionSpan.setAttribute('class', 'forecast-data');

                            temperatureSpan.innerHTML = `${x.low}${degrees}/${x.high}${degrees}`;
                            conditionSpan.textContent = x.condition;

                            switch(x.condition) {
                                case 'Sunny': iconSpan.innerHTML = symbol.Sunny; break;
                                case 'Partly sunny': iconSpan.innerHTML = symbol["Partly sunny"]; break;
                                case 'Overcast': iconSpan.innerHTML = symbol.Overcast; break;
                                case 'Rain': iconSpan.innerHTML = symbol.Rain; break;
                            }
    
                            spanGroup.appendChild(iconSpan);
                            spanGroup.appendChild(temperatureSpan);
                            spanGroup.appendChild(conditionSpan);
                            divItemUpcoming.appendChild(spanGroup);
                            upcoming.appendChild(divItemUpcoming);
                        })
                    })
                    .catch(error => console.log(error));
            })
            .catch(error => console.log('Error'));
    })
}

attachEvents();