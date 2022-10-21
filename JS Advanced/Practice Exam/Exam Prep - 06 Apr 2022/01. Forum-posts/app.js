window.addEventListener("load", solve);

function solve() {
    document.getElementsByTagName('button')[0].addEventListener('click', createPosts);
    document.querySelector('#clear-btn').addEventListener('click', clearPost);

    let title = document.getElementById('post-title');
    let category = document.getElementById('post-category');
    let content = document.getElementById('post-content');
    let [review, published] = document.querySelectorAll('ul');

    function createPosts() {
        let titleValue = title.value;
        let categoryValue = category.value;
        let contentValue = content.value;

        if(!titleValue || !categoryValue || !contentValue) {   
            return;
        }

        createHTMLElements(titleValue, categoryValue, contentValue);
        clearForm();
    }

    function clearForm(){
        title.value = '';
        category.value = '';
        content.value = '';
    }

    function createHTMLElements(titleValue, categoryValue, contentValue) {
        let li = document.createElement('li');
        li.classList.add('rpost');

        let article = document.createElement('article');
        let h = document.createElement('h4');
        h.textContent = titleValue;
        let categoryP = document.createElement('p');
        categoryP.textContent = `Category: ${categoryValue}`;
        let contentP = document.createElement('p');
        contentP.textContent = `Content: ${contentValue}`;

        li.appendChild(article);
        article.appendChild(h);
        article.appendChild(categoryP);
        article.appendChild(contentP);

        let editButton = document.createElement('button');
        editButton.classList.add('action-btn');
        editButton.classList.add('edit');
        editButton.textContent = 'Edit';
        editButton.addEventListener('click', editPost);

        let approveButton = document.createElement('button');
        approveButton.classList.add('action-btn');
        approveButton.classList.add('approve');
        approveButton.textContent = 'Approve';
        approveButton.addEventListener('click', approvePost);

        li.appendChild(article)
        li.appendChild(approveButton);
        li.appendChild(editButton);
        
        review.appendChild(li);
    }

    function editPost(event) {
        let currentPost = event.target.parentElement;
        let articleContent = currentPost.getElementsByTagName('article')[0].children;
        let titleValue = articleContent[0].textContent;
        let categoryValue = articleContent[1].textContent;
        let contentValue = articleContent[2].textContent;

        title.value = titleValue;
        category.value = categoryValue.split(': ')[1];
        content.value = contentValue.split(': ')[1];
        currentPost.remove();
    }

    function approvePost(event) {
        let currentPost = event.target.parentElement;
        published.appendChild(currentPost);
        Array.from(currentPost.querySelectorAll('button')).forEach(btn => btn.remove());
    }

    function clearPost(event) {
        Array.from(published.children).forEach(li => li.remove());
    }
}

