create database Locadora;

use Locadora;

create table if not exists cliente(
cpf_cnpj varchar(14) not null,
nome varchar(50),
id_contratos_fk int,
id_pagamento_fk int,

primary key (cpf_cnpj)
);

create table if not exists email(
email varchar(100) not null,
id_cliente_fk int not null,

primary key (email)
);

create table if not exists telefone(
telefone varchar(11) not null,
id_cliente_fk int not null,

primary key (telefone)
);

create table if not exists endereco(
codigo int, 
rua varchar(50) not null,
numero smallint not null,
bairro varchar(30) not null,
cep varchar(9),
complemento varchar(10),
id_cliente_fk int not null,

primary key (codigo)
);

create table if not exists pagamento(
id_pagamento int auto_increment not null,
valor_pago decimal(10,2),
data_pagameto date,

primary key (id_pagamento)
);

