import { html, render } from '../node_modules/lit-html/lit-html.js'
import { get, create } from './lib/request.js';

const rootOptions = document.getElementById('menu');
const form = document.querySelector('form');
form.addEventListener('submit', onSubmit);

getData();

async function getData() {
    const data = await get();
    update(Object.values(data).map(x => itemTemplate(x)));
}

function update(value) {
    render(value, rootOptions);
}

function itemTemplate(data) {
    return html`<option value=${data._id}>${data.text}</option>`
}

function onSubmit(event){
    event.preventDefault();

    const input = form.querySelector('#itemText');
    const text = input.value;
    addItem(text)
}

async function addItem(text) {
    if (text.length !== 0) {
        await create(text);
    }

    form.reset();
    getData();
}

