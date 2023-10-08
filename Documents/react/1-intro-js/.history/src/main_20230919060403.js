

const products = ['mesa', 'silla', 'notebook', 'teclado'];

const products2 = products.concat(['pantalla lcd', 'sony tv']);

products.push('pantalla lcd', 'sony tv');

const fruits = ['peras', 'manzanas', 'sandias', 'frutillas'];


const mercado = [...products, ...fruits, 'lechuga', 'papas', 'uvas'];


console.log(mercado);