create database if not exists Atividade;

use Atividade;

create table if not exists projetos(
cod int not null auto_increment,
nome varchar(30),
valHora int not null,

primary key (cod)
);

create table if not exists colaborador(
cpf varchar(11) not null,
nomeComp varchar(50),

primary key (cpf)
);

create table if not exists email(
email varchar(100) not null,
cpf_colaborador varchar(11) not null,

primary key (email)
);

create table if not exists orcamento(
cod int not null auto_increment,
validadeOrcamento date not null,
cliente varchar(50) not null, 
tempoEstimado int not null,
projeto_fk int not null,

primary key (cod)
);

create table if not exists trabalhos(
cod int not null auto_increment,
orcamento_fk int not null,
colaborador_fk int not null,
dataInicio date not null,
dataFim date not null,
qntHoras int not null,
valor int not null,

primary key (cod)
);

alter table orcamento
add foreign key (projeto_fk) references projetos(cod);

alter table trabalhos
add foreign key (orcamento_fk) references orcamento(cod);

alter table trabalhos
add foreign key (colaborador_fk) references colaborador(cpf);
