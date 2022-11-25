const host = 'http://localhost:3030/';

async function request(url, method, data) {
    const options = {
        method,
        headers: {}
    };

    if (data != undefined) {
        options.headers['Content-Type'] = 'application/json';
        options.body = JSON.stringify(data);
    }

    try {
         const response = await fetch(host + url, options);
         
         if(!response.ok) {
            const error = await response.json();
            throw new Error(error.message);
         }
 
         if(response.status == 204){
            return response;
        }
        else {
            return  response.json();
        }
    }
     catch(err){
         alert(err.message);
         throw err;
     }
 }

 export async function create(data) {
    return await request('jsonstore/advanced/dropdown', 'POST', { text: data });
 }

 export async function get() {
    return await request('jsonstore/advanced/dropdown', 'GET');
 }