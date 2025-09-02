function callback(){
    console.log(nome, idade, filhos);
}

const nome = "Emerson";
let idade = 42;
var filhos = 1;

function imprimeDados(){
    console.log(nome, idade, filhos);
    setTimeout(callback, 5000);
}

imprimeDados();

