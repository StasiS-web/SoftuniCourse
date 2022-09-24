function solve (usd) {
    const USD = 1.79549;                       1
    let lv = usd * USD;
    console.log(`${lv.toFixed(2)} BGN`)
}

solve(20);
solve(100);
solve(12.5);