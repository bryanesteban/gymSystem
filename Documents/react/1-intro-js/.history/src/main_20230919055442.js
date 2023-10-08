

const products = ['mesa', 'silla', 'notebook', 'teclado'];

products.push('pantalla lcd', 'sony tv');

const fruits = ['peras', 'manzanas', 'sandias', 'frutillas', ...products];


const mercado = [...fruits, 'lechuga', 'papas', 'uvas'];


console.log(mercado);