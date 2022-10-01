function generateReport() {
    let checkboxes = Array.from(document.getElementsByTagName('input'));
    let rows = Array.from(document.getElementsByTagName('tr'));
    let report = document.getElementById('output');

    let objReport = [];
    let colLocation = [];

    for(let i = 0; i < checkboxes.length; i++) {
       if(checkboxes[i].checked) {
            colLocation.push(i);
       }
    }

    for(let i = 0; i < rows.length; i++) {
        let item = rows[i].children;
        let obj = {}

        for(let j = 0; j < item.length; j++) {
            if(colLocation.includes(j)) {
                let property = checkboxes[j].name;
                obj[property] = item[j].textContent;
            }
        }

        if(i !== 0) {
            objReport.push(obj);
        }
    }
    
    report.textContent = JSON.stringify(objReport);
}
