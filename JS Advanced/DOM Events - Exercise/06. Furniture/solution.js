function solve() {
  let tableBody = document.querySelector('tbody');
  let [input, result] = document.getElementsByTagName('textarea');
  let [generateBtn, buy] = document.getElementsByTagName('button');

  generateBtn.addEventListener('click', () => {
    let currentProducts = JSON.parse(input.value);

    for(let item of currentProducts) {
      let row = document.createElement('tr');
      row.innerHTML = `<td><img src="${item.img}"/></td>
                       <td><p>${item.name}</p></td>
                       <td><p>${item.price}</p></td>
                       <td><p>${item.decFactor}</p></td>
                       <td><input type="checkbox"></td>`;

      tableBody.appendChild(row);
    }
  });

  buy.addEventListener('click', () => {
    let bought = Array.from(document.querySelectorAll('tbody tr'));
    let [productName, prices, decorFactors] = [[], [], []];

    for (let item of bought) {
      if(item.querySelectorAll('input[type="checkbox"]')[0].checked) {
        let data = item.querySelectorAll('p');
        productName.push(data[0].textContent);
        prices.push(Number(data[1].textContent));
        decorFactors.push(Number(data[2].textContent));
      }
    }

    let totalPrice = prices.reduce((a, b) => a += b);
    let factor = decorFactors.reduce((a, b) => a += b) / decorFactors.length;

    result.textContent = [`Bought furniture: ${productName.join(', ')}`, 
                        `Total price: ${totalPrice.toFixed(2)}`, 
                        `Average decoration factor: ${factor}`].join('\n');

  });
}