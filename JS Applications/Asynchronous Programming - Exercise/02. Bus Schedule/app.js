function solve() {
    let divElement = document.querySelector('.info');
    let departBtn = document.getElementById('depart');
    let arriveBtn= document.getElementById('arrive');

    let busStop = {
        next: 'depot'
    }

    function depart() {
        departBtn.disabled = true;
        let url = `http://localhost:3030/jsonstore/bus/schedule/${busStop.next}`;
       
        fetch(url)
            .then(response => response.json())
            .then(data => {
                busStop = Object.assign(data);
                divElement.textContent = `Next stop ${busStop.name}`;
            })
            .catch(error => {
                divElement.textContent = `Error`;
            })
        arriveBtn.disabled = false;
    }

    function arrive() {
        divElement.textContent = `Arriving at ${busStop.name}`
        departBtn.disabled = false;
        arriveBtn.disabled = true;
    }

    return {
        depart,
        arrive
    };
}

let result = solve();