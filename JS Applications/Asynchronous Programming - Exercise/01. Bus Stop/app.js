async function getInfo() {
    let url =  `http://localhost:3030/jsonstore/bus/businfo`;
    let input = document.getElementById('stopId');
    let divElement = document.getElementById('stopName');
    let ulElement = document.getElementById('buses');

    try {
        await fetch(`${url}/${input.value}`)
        .then(response => response.json())
        .then(data => {
            let name = data.name;
            let busTime = data.buses;

            divElement.textContent = name;
            ulElement.innerHTML = '';
            Object.keys(busTime).forEach(bus => {
                let liItem = document.createElement('li');
                liItem.textContent = `Bus ${bus} arrives in ${busTime[bus]} minutes`;
                ulElement.appendChild(liItem);
            })
        });
    }
    catch(error)  {
            divElement.textContent = 'Error';
            ulElement.innerHTML = ``;
    }
}