function callback(){
    console.log("Função de callback executou");
}

function f4(){
    console.log("Função 4 executou");
    setTimeout(() => console.log("Função de callback executou"), 5000);
    setTimeout(callback, 5000);
}

function f3(){
    console.log("Função 3 executou");
    f4();
}

function f2(){
    console.log("Função 2 executou");
    f3();
}

function f1(){
    console.log("Função 1 executou")
    f2();
}

f1();

console.log("Script terminou");