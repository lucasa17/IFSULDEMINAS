const local = new String("Sacolão Center");
const frutas = ["Melancia", "Abacaxi", "Laranja"];
const nome = "Lucas";
const numero = 5;

console.log(local, typeof local);
console.log("String? ", local instanceof String);

console.log(frutas ,typeof frutas);
console.log("Vetor? ", frutas instanceof Array);

if(local instanceof String){
    console.log("É seguro usar local como String");
}

console.log("\nLiterais")
console.log("Tipo nome?", typeof nome)
console.log("nome é string?", nome instanceof String);
console.log("Tipo numero?", typeof numero)
console.log("numero é Number?", numero instanceof Number);

console.log("\nPropiedade 'constructor'");
console.log("Tipo nome?", typeof nome);
console.log("constructor de nome: ", nome.constructor);

