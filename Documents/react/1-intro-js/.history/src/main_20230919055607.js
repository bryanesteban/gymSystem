

const products = ['mesa', 'silla', 'notebook', 'teclado'];

products.concat('pantalla lcd', 'sony tv');

const fruits = ['peras', 'manzanas', 'sandias', 'frutillas'];


const mercado = [...products, ...fruits, 'lechuga', 'papas', 'uvas'];


console.log(mercado);