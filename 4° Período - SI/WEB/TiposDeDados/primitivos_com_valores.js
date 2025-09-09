const nome = "Lucas"
const altura = 1.70
const filhos = 0
const casado = false
const hobbies = ['Futebol', 'Corrida', 'Bike']

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

//JSON JavaScript Objection Notation
const lucas = {
    nome: nome,
    altura: altura,
    filhos: filhos,
    casado: casado,
    idade: idade(16, 4, 2006),
    hobbies: hobbies
}
console.log("Tipo usuário: ", typeof lucas)
console.log(`Tipo nome: ${typeof lucas.nome}`)
console.log(`Tipo altura: ${typeof lucas.altura}`)
console.log(`Tipo filhos: ${typeof lucas.filhos}`)
console.log(`Tipo casado: ${typeof lucas.casado}`)
console.log(`Tipo idade obj: ${typeof lucas.idade}`, `Tipo idade ori: ${typeof idade}`)
console.log(`Tipo hobbies: ${typeof lucas.hobbies}`, `Construtor hobbies${lucas.hobbies.constructor}`)





console.log("Usuário: ", lucas)
console.log("Tipo: ", lucas.constructor)

