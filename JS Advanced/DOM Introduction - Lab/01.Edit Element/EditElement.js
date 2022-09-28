function editElement (content, match, replacer) {
    let text = content.textContent;
    let matcher = new RegExp(match, 'g');
    let result = text.replace(matcher, replacer);
    content.textContent = result;
}
