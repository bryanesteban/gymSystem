
/*
httpClient
      .then( response => response.json())
      .then(data => console.log(data));

console.log('Hola que tal!');
*/
const findAllUsers = async() =>{
    const response  = await fetch('https://jsonplaceholder.typicode.com/users');
    const users = await response.json();
    const ul = document.

    users.forEach(user  =>{
        const li = document.createElement('li');
        li.innerText = user.name;
        console.log(user, name);
    })
  }
  
  
  findAllUsers();
  
  //console.log(users)
  console.log('Hola que tal!');