window.onload = app;

function app() {
    document.getElementById('form').addEventListener('submit', createNewStudent);

    const url = `http://localhost:3030/jsonstore/collections/students`;
    const tableBody = document.querySelector('tbody');

    displayStudent();

    async function createNewStudent(event) {
        event.preventDefault();
        const form = new FormData(event.target);

        let firstName = form.get('firstName');
        let lastName = form.get('lastName');
        let facultyNumber = form.get('facultyNumber');
        let grade = form.get('grade');

        if (!firstName || !lastName || !facultyNumber || !grade) {
            alert('All fields are required! Please filled them up.')
            return; 
        }

        const body = {
                    firstName: firstName,
                    lastName: lastName,
                    facultyNumber: facultyNumber,
                    grade: grade
                }
        const res = await fetch(url, {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json'
                },
                body: JSON.stringify(body)
            });

            if(!res.ok) {
                const err = await res.json();
                throw new Error(err.message);
            }
           
        displayStudent();
    }
    
    async function displayStudent(){
        const response = await fetch(url);
        const data = await response.json();
        tableBody.innerHTML = '';
    
        Object.values(data).forEach(rec => {
            const trElement = document.createElement('tr');
            tableBody.appendChild(trElement);

            const tdFirstName = document.createElement('td');
            tdFirstName.textContent = rec.firstName;
            trElement.appendChild(tdFirstName);

            const tdLastName = document.createElement('td');
            tdLastName.textContent = rec.lastName;
            trElement.appendChild(tdLastName);

            const tdFacultyNum = document.createElement('td');
            tdFacultyNum.textContent = rec.facultyNumber;
            trElement.appendChild(tdFacultyNum);
            
            const tdGrade = document.createElement('td');
            tdGrade.textContent = rec.grade;
            trElement.appendChild(tdGrade);
    
            tableBody.appendChild(trElement);
        });
    }
}

