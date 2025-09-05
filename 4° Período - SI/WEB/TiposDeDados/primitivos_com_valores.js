const nome = "Lucas"
const altura = 1.70
const filhos = 0
const casado = false

const idade = function(dia, mes, ano){
    if(dia == undefined || mes == undefined || ano == undefined){
        return 'Parametros inválidos';
    }
    if(dia == null || mes == null || ano == null){
        return 'Parametros inválidos';
    }

    const hoje = new Date();
    const nascimento = new Date(ano, mes - 1, dia)
    const miliSegundosPorAno = 31536000000
    return Math.floor((hoje - nascimento)/miliSegundosPorAno)
}
console.log(`Idade do ${nome}`, idade(16, 4, 2006), idade())

const hobbies = ['Futebol', 'Corrida', 'Bike']

//JSON JavaScript Objection Notation
const lucas = {
    nome: nome,
    altura: altura,
    filhos: filhos,
    casado: casado,
    idade: idade(),
    hobbies: hobbies
}