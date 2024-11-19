create database Locadora;

use Locadora;

create table if not exists cliente(
cpf_cnpj varchar(14) not null,
nome varchar(50),
id_contrato_fk int,
id_pagamento_fk int,

primary key (cpf_cnpj)
);

create table if not exists email(
email varchar(100) not null,
cpf_cnpj_fk varchar(14) not null,

primary key (email)
);

create table if not exists telefone(
telefone varchar(11) not null,
cpf_cnpj_fk varchar(14) not null,

primary key (telefone)
);

create table if not exists endereco(
codigo int auto_increment not null, 
rua varchar(50) not null,
numero smallint not null,
bairro varchar(30) not null,
cep varchar(9),
complemento varchar(10),
cpf_cnpj_fk varchar(14) not null,

primary key (codigo)
);

create table if not exists pagamento(
id_pagamento int auto_increment not null,
valor_pago decimal(10,2),
data_pagameto date,

primary key (id_pagamento)
);

create table if not exists credito(
id_pagamento_fk int not null,
num_cartao varchar(16) not null,
val_cartao date not null,

primary key(id_pagamento_fk)
);

create table if not exists debito(
id_pagamento_fk int not null,
num_cartao varchar(16) not null,
val_cartao date not null,

primary key(id_pagamento_fk)
);

create table if not exists pix(
id_pagamento_fk int not null,
chave_pix varchar(100),

primary key(id_pagamento_fk)
);

create table if not exists contrato_locacao(
id_contrato int auto_increment not null,
data_inicio date not null,
data_termino date not null,
id_pagamento_fk int,
  
primary key(id_contrato)
);

create table if not exists veiculo(
placa varchar(7) not null,
marca varchar(20),
modelo varchar(100),
ano varchar(4),
categoria varchar(15),
status bit not null,
  
primary key(placa)
);

create table if not exists manutencao(
id_manutencao int auto_increment not null,
tipo varchar(50) not null,
data_manutencao date not null,
  
primary key(id_manutencao)
);

create table if not exists faz(
placa_fk varchar(7) not null,
id_manutencao_fk int not null,
  
primary key(id_manutencao_fk)
);


alter table cliente 
add constraint cliente_contrato
foreign key (id_contrato_fk) references contrato_locacao(id_contrato);

alter table cliente 
add constraint cliente_pagamento
foreign key (id_pagamento_fk) references pagamento(id_pagamento);

alter table email 
add constraint email_cliente
foreign key (cpf_cnpj_fk) references cliente(cpf_cnpj);

alter table telefone 
add constraint telefone_cliente
foreign key (cpf_cnpj_fk) references cliente(cpf_cnpj);

alter table endereco 
add constraint endereco_cliente
foreign key (cpf_cnpj_fk) references cliente(cpf_cnpj);

alter table credito 
add constraint credito_pagamento
foreign key (id_pagamento_fk) references pagamento(id_pagamento);

alter table debito 
add constraint debito_pagamento
foreign key (id_pagamento_fk) references pagamento(id_pagamento);

alter table pix 
add constraint pix_pagamento
foreign key (id_pagamento_fk) references pagamento(id_pagamento);

alter table contrato_locacao 
add constraint contrato_pagamento
foreign key (id_pagamento_fk) references pagamento(id_pagamento);

alter table faz
add constraint faz_manutencao
foreign key (id_manutencao_fk) references manutencao(id_manutencao);

alter table faz
add constraint faz_veiculo
foreign key (placa_fk) references veiculo(placa);
