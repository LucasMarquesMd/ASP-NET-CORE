const fetchAPI = fetch('http://localhost:5028/times', {
    method: 'GET',
    headers:{
        'Content-Type': 'application/json'
    }
    
})
.then((res) => res.json())
.then((data) => console.log(data));
