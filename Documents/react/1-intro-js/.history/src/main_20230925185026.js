
const invoices = [

    {
        id: 1,
        name: 'Compras de oficina',
        date: new Date(),
        client: 
        {
            name: 'Maria ',
            lastname: 'Doe',
        },
        items:[
            {
                producto: 'keyboard',
                price: 399,
                quantity:2,
            },
            {
                producto: 'mouse',
                price: 200,
                quantity:1,
            },
            {
                producto: 'paper',
                price: 100,
                quantity:10,
            }
        ],
    },
    {
        id: 2,
        name: 'Compras de computacion',
        date: new Date(),
        client: 
        {
            name: 'Pepe ',
            lastname: 'Doe',
        },
        items:[
            {
                producto: 'keyboard',
                price: 399,
                quantity:2,
            },
            {
                producto: 'screem 17',
                price: 500,
                quantity:1,
            },
            {
                producto: 'cpu',
                price: 1000,
                quantity:10,
            }
        ],
    },
    {
        id: 3,
        name: 'Compras de papeleria',
        date: new Date(),
        client: 
        {
            name: 'Jhon ',
            lastname: 'Doe',
        },
        items:[
            {
                producto: 'pencil',
                price: 50,
                quantity:1,
            },
            {
                producto: 'paper',
                price: 100,
                quantity:10,
            }
        ],
    }
];

const  invoicesName = invoices.map( i => {
    return i.name;
});

console.log(invoices);
console.log(invoicesName);


const  invoicesClient = invoices.map( i => {
    return i.client.name;
});

console.log(invoicesClient);

const invoiceById = invoices.find(i => i.name === 'Compras de computacion');

console.log(invoiceById);