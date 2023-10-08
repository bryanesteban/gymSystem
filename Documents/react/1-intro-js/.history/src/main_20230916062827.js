

const invoice = {
    id: 10,
    name: 'Compras de oficina',
    date: new Date(),
    client: 
    {
        id: 2,
        name: 'Jhon ',
        lastname: 'Doe',
        Age: 20,
    },
    total: 1000 

};


console.log(invoice.client);

invoice.client.name = 'Pepe Roe';
invoice.total = 5000;

console.log(invoice);