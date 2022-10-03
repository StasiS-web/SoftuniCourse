function solve() {
    let products = Array.from(document.getElementsByClassName('product'));
    products.forEach(p => p.addEventListener('click', addProduct));
    let checkout = document.querySelector('.checkout');
    checkout.addEventListener('click', checkOut);
    let textarea = document.querySelector('textarea');
    
    let productsName = [];
    let totalCost = 0;

   function addProduct(event) {
        let product = {
            name: event.target.parentNode.previousElementSibling.firstElementChild.textContent,
            price: event.target.parentNode.nextElementSibling.textContent
        }

        if(!productsName.includes(product.name)) {
            productsName.push(product.name);
        }

        textarea.value += `Added ${product.name} for ${product.price} to the cart.\n`
        totalCost += Number(product.price);
   }

   function checkOut() {
      textarea.value += `You bought ${productsName.join(', ')} for ${totalCost.toFixed(2)}.`;
      products.forEach(p => p.removeEventListener('click', addProduct));
      checkout.removeEventListener('click', checkOut);
   }
}