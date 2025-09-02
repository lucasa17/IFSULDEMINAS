// var faz hoiting de variaveis

function testeDeEscopo(){
    const marca = "Fiat";
    let modelo = "Palio";
    var ano = 2015;

    if(true){
        const marca2 = "Toyota";
        let modelo2 = "Corolla";
        var ano2 = 2010;    
    }

    console.log(marca, modelo, ano);
    console.log(ano2);
}

testeDeEscopo();

//console.log(marca, modelo, ano);
