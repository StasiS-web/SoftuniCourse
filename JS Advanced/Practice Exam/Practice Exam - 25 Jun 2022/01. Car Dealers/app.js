window.addEventListener("load", solve);

function solve() {
    document.getElementById('publish').addEventListener('click', createOffer);

    let make = document.getElementById('make');
    let model = document.getElementById('model');
    let year = document.getElementById('year');
    let fuelType = document.getElementById('fuel');
    let originalCost = document.getElementById('original-cost');
    let sellingPrice = document.getElementById('selling-price');
    let tableBody = document.getElementById('table-body');
    let carsList = document.getElementById('cars-list');
    let totalProfit = document.getElementById('profit');
    
    function createOffer(event) {
      event.preventDefault();
      let makeValue = make.value;
      let modelValue = model.value;
      let yearValue = year.value;
      let fuelTypeValue = fuelType.value;
      let originalCostValue = originalCost.value;
      let sellingPriceValue = sellingPrice.value;

      if (!makeValue || !modelValue || !yearValue || !fuelTypeValue || 
            !originalCostValue || !sellingPriceValue || 
            Number(originalCostValue) > Number(sellingPriceValue)) {
          return;
      }

      make.value = '';
      model.value = '';
      year.value = '';
      fuelType.value = '';
      originalCost.value = '';
      sellingPrice.value = '';

      createElements(makeValue, modelValue, yearValue, fuelTypeValue, originalCostValue, sellingPriceValue);
    }

    function createElements(makeValue, modelValue, yearValue, fuelTypeValue, originalCostValue, sellingPriceValue) {
      let tr = document.createElement('tr');
      tr.classList.add('row');

      let tdMake = document.createElement('td');
      tdMake.textContent = makeValue;
      let tdModel = document.createElement('td');
      tdModel.textContent = modelValue;
      let tdYear = document.createElement('td');
      tdYear.textContent = yearValue;
      let tdFuelType = document.createElement('td');
      tdFuelType.textContent = fuelTypeValue;
      let tdOriginalCost = document.createElement('td');
      tdOriginalCost.textContent = originalCostValue;
      let tdSellingPrice = document.createElement('td');
      tdSellingPrice.textContent = sellingPriceValue;

      let tdButtons = document.createElement('td');
      let editButton = document.createElement('button');
      editButton.classList.add('action-btn');
      editButton.classList.add('edit');
      editButton.textContent = 'Edit';
      editButton.addEventListener('click', () => editOffer(tr, makeValue, modelValue, yearValue, fuelTypeValue, originalCostValue, sellingPriceValue));

      let sellButton = document.createElement('button');
      sellButton.classList.add('action-btn');
      sellButton.classList.add('sell');
      sellButton.textContent = 'Sell';
      sellButton.addEventListener('click', () => sellCar(tr, makeValue, modelValue, yearValue, originalCostValue, sellingPriceValue));

      tdButtons.appendChild(editButton);
      tdButtons.appendChild(sellButton);

      tr.appendChild(tdMake);
      tr.appendChild(tdModel);
      tr.appendChild(tdYear);
      tr.appendChild(tdFuelType);
      tr.appendChild(tdOriginalCost);
      tr.appendChild(tdSellingPrice);
      tr.appendChild(tdButtons);

      tableBody.appendChild(tr);
    }

    function editOffer(tr, makeValue, modelValue, yearValue, fuelTypeValue, originalCostValue, sellingPriceValue) {
      make.value = makeValue;
      model.value = modelValue;
      year.value = yearValue;
      fuelType.value = fuelTypeValue;
      originalCost.value = originalCostValue;
      sellingPrice.value = sellingPriceValue;

      tr.remove();
    }

    function sellCar(tr, makeValue, modelValue, yearValue, originalCostValue, sellingPriceValue) {
      let li = document.createElement('li');
      li.classList.add('each-list');
      let spanCar = document.createElement('span');
      spanCar.textContent = `${makeValue} ${modelValue}`;
      let spanYear = document.createElement('span');
      spanYear.textContent = yearValue;
      let spanDiffCost = document.createElement('span');
      spanDiffCost.textContent = `${Number(sellingPriceValue) - Number(originalCostValue)}`;

      li.appendChild(spanCar);
      li.appendChild(spanYear);
      li.appendChild(spanDiffCost);
      carsList.appendChild(li);
      tr.remove();

      totalProfit.textContent = `${(Number(totalProfit.textContent) + Number(spanDiffCost.textContent)).toFixed(2)}`;
    }
}
