function attachGradientEvents() {
    let gradient = document.getElementById('gradient')
    let result = document.getElementById('result');

    gradient.addEventListener('mousemove', MouseOver);

    function MouseOver(event) {
        result.textContent = Math.floor(event.offsetX / gradient.clientWidth * 100) + '%';
    }
}