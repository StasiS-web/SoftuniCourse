function attachEvents() {
    let sendBtn = document.getElementById('submit');
    let refreshBtn = document.getElementById('refresh');

    sendBtn.addEventListener('click', sendMessages);
    refreshBtn.addEventListener('click', getAllMessages);

}

function sendMessages() {
    const authorName = document.querySelector('input[name="author');
    const content = document.querySelector('input[name="content"]');

    const body = {
        author: authorName.value,
        content: content.value
    }

    authorName.value = '';
    content.value = '';
    postMessage(body);
}

function renderMessage(data) {
   let textArea = document.getElementById('messages');
   const content = Object.values(data).map(entry => `${entry.author}: ${entry.content}`).join('\n');
   textArea.textContent = content;
}

async function getAllMessages() {
   const url = 'http://localhost:3030/jsonstore/messenger';
   const response = await fetch(url);
   const data =  await response.json();

   return renderMessage(data);
}

async function postMessage(body) {
    const url = 'http://localhost:3030/jsonstore/messenger';
    const response = await fetch(url, {
        method: 'POST',
        headers: {
            "Content-type": "application/json"
        }, 
        body: JSON.stringify(body)
    });

    const data = await response.json();

    getAllMessages();
}

attachEvents();