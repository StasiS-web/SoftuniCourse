'use strict'

function lastNumbersSequence(n, k) {
  let sum = [1];

  for (let i = 1; i < n; i++) {
    let start = Math.max(0, i - k);
    let currElement = sum.slice(start, start + k).reduce((a, b) => a + b, 0);

    sum.push(currElement);
  }

  return sum;
}

console.log(lastNumbersSequence(6, 3));
console.log('-------------')
console.log(lastNumbersSequence(8, 2));