import {html, render} from './node_modules/lit-html/lit-html.js';

const form = document.querySelector('form');
const root = document.getElementById('root');

form.addEventListener('submit', (event) => {
    event.preventDefault();
    const formData = new FormData(form);
    const {towns} = Object.fromEntries(formData);
    const data = towns.split(', ');

    const result = createTown(data);
    render(result, root);
    form.reset();
});

function createTown (data) {
    const ul = html`
       <ul>
            ${data.map(town => html`<li>${town}</li>`)}
       </ul>
    `;
    return ul;
}