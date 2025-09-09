let entradaUm;
let entradaDois = undefined;
let resultado = null;

console.log(`Igualdade null vs undefined = ${entradaUm == null}`);
console.log(`Identidade null vs undefined = ${entradaUm === null}`);

entradaDois = 1;
console.log(`${entradaUm ? 'tem valor' : 'não tem valor'}`);
console.log(`${entradaDois ? 'tem valor' : 'não tem valor'}`);
console.log(`${resultado ? 'tem valor' : 'não tem valor'}`);

console.log(`Tipo 'entradaUm:' ${typeof entradaUm}`);
console.log(`Tipo 'entradaDois:' ${typeof entradaDois}`);
console.log(`Tipo 'resultado:' ${typeof resultado}`);


let indefinido = undefined;
let nulo = null;
let dois = 2;
let soma;

soma = dois + indefinido;
console.log(`Soma: ${soma}`, `Tipo soma: ${typeof soma}`);

soma +=1;
console.log(soma);

soma = dois + nulo;
console.log(`Soma: ${soma}`, `Tipo soma: ${typeof soma}`);

soma +=1;
console.log(soma);

