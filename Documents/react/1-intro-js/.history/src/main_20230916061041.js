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
const add = (a = 0 , b = 0) => a + b;

const result = sayHello('Bryan', 10);

console.log(result);
console.log(add(10,5));