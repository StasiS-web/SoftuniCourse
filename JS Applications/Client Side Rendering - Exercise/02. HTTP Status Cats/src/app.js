import { html, render } from '../node_modules/lit-html/lit-html.js';
import { cats } from './catSeeder.js';

const section = document.getElementById('allCats');

const renderCats = html`
    <ul>
        ${cats.map(cat => createCatCard(cat))}
    </ul>`;

function createCatCard(cat) {
    const catsInfo = html`
        <li>
            <img src="./images/${cat.imageLocation}.jpg" width="250" height="250" alt="Card image cap">
            <div class="info">
                <button class="showBtn" @click=${showDetails}>Show status code</button>
                <div class="status" style="display: none" id="100">
                    <h4>Status Code: ${cat.statusCode}</h4>
                    <p>${cat.statusMessage}</p>
                </div>
            </div>
        </li>
    `;
    return catsInfo
}

render(renderCats, section);

function showDetails(event) {
    event.preventDefault();

    const btn = event.target;
    const info = event.target.parentNode;
    const details = info.querySelector('.status');

    if(details.style.display == 'block') {
        details.style.display = 'none';
        btn.textContent = 'Show status code';
    }
    else {
        details.style.display = 'block';
        btn.textContent = '"Hide status code';
    }
}
