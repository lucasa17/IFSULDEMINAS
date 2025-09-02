let name;

function globalAutomatico(){
    name = "Emerson";
    age = 42;
}

globalAutomatico();

console.log(name, age);
console.log("Na janela: ", window.age);