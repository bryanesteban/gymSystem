/*
const sayHello =  (name = 'Pepe', age = 0 ) => {
    const greeting = `Hola mundo function! ${name} edad ${age}`;
    //console.log('Hola Mundo function!');
    return greeting;
}
*/

/*
const sayHello =  (name = 'Pepe', age = 0 ) => {
     return  `Hola mundo function! ${name} edad ${age}`;
    //console.log('Hola Mundo function!');
}
*/

const sayHello =  (name = 'Pepe', age = 0 ) => `Hola mundo function! ${name} edad ${age}`;


const result = sayHello('Bryan', 10);

console.log(result);