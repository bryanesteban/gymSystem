

const user = {
    username : 'andres',
    email: 'correo@google.com',
    age : 20,
    ranking: 9,
}

/*
const username = user.username;
const ranking = user.ranking;
const age = user.age;
*/
//const{ username, ranking} = user ;
const detail = (user) =>{
    const{username, ranking, age} = user;
    
    console.log(`El detalle del usuario ${ username} con correo ${email}`)
}

detail(user)