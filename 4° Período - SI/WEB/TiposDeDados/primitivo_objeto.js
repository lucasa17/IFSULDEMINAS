// Primitivos não são objetos
const nome = 'Lucas';
const altura = 1.71;
const filhos = true;

console.log("Type nome: ", typeof nome);
console.log("Type altura: ", typeof altura);
console.log("Type filhos: ", typeof filhos);

// Métodos em variaveis primitivos
console.log("Nome em caixa alta: ", nome.toUpperCase());
console.log("Altura 1 casa decimais: ", altura.toFixed(1));
console.log("Filhos em caixa alta: ", filhos.toString().toUpperCase());

console.log("\n\nVendo a coersão acontecer");
console.log("Nome: ", nome);
console.log('Tamanho nome: ', nome.length);
console.log("Type nome: ", typeof nome);

String.prototype.meuObjeto = function(){
    return this;
}

const copiaDoNome = nome.meuObjeto();
console.log("copiaDoNome: ", copiaDoNome);
console.log('Tamanho copiaDoNome: ', copiaDoNome.length);
console.log("Type copiaDoNome: ", typeof copiaDoNome);  