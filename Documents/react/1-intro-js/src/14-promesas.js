import {findInvoiceById} from './data/invoices.js'

/*
promise.then((result) =>{
  console.log(result);
  console.log('Realizando con exito alguna tarea con demora.');
}).catch((error) => {console.error(error)});
*/
findInvoiceById(3).then(console.log)
                   .catch(console.error);



