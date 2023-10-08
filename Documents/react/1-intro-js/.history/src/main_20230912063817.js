function sayHello(name = 'Pepe', age = 0 ){
    const greeting = `Hola mundo function! ${name} edad ${age}`;
    //console.log('Hola Mundo function!');
    return greeting;
}

const result = sayHello('Bryan', 10);

console.log(result);