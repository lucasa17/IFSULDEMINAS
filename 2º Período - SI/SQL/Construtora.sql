create database construtora;

use construtora;

create table if not exists projeto(
cod int primary key auto_increment not null,
nome varchar(50),
local varchar(50),
data_ini date not null,
data_term date not null,
status varchar(12) not null,
id_equipe_fk int,
id_finan_fk int

); 

create table if not exists financeiro(
id_finan int primary key auto_increment not null,
despesas decimal(10,2) not null,
receitas decimal(10,2) not null

);

create table if not exists equipe(
id_equipe int primary key auto_increment not null,
lider varchar(50),
id_tarefa_fk int

);

create table if not exists funcionario(
cpf varchar(11) primary key not null,
nome varchar(50) not null,
cargo varchar(50) not null,
salario decimal(10,2) not null

);

create table if not exists possui(
id_equipe_fk int primary key not null,
cpf_fk varchar(11) not null,
papel varchar(100)

);

create table if not exists tarefa(
id_tarefa int primary key not null,
data_ini date not null,
data_term date not null,
descricao varchar(100),
status varchar(12)

);

create table if not exists requerem(
id_tarefa_fk int not null,
id_materiais_fk int not null,
quantidade int not null,
data_retirada date,

primary key(id_tarefa_fk, id_materiais_fk)
);

create table if not exists materiais(
id_materiais int primary key auto_increment not null,
quant_estoque int not null,
descricao varchar(100)

);

create table if not exists fornecedor(
id_fornecedor int primary key auto_increment not null,
nome varchar(50)

);

create table if not exists telefone(
telefone varchar(13) not null,
id_fornecedor_fk int not null,

primary key(telefone, id_fornecedor_fk)
);

create table if not exists endereco(
id_endereco int auto_increment not null, 
rua varchar(50) not null,
numero smallint not null,
bairro varchar(30) not null,
cep varchar(9),
complemento varchar(10),
id_fornecedor_fk int not null,

primary key(id_endereco, id_fornecedor_fk)
);

create table if not exists fornece(
id_materiais_fk int not null,
id_fornecedor_fk int not null,
preco decimal(10,2),
met_pag varchar(7),
quantidade int,

primary key(id_materiais_fk, id_fornecedor_fk)
);



alter table projeto 
add constraint projeto_equipe 
foreign key (id_equipe_fk) references equipe(id_equipe);

alter table projeto 
add constraint projeto_financeiro 
foreign key (id_finan_fk) references financeiro(id_finan);

alter table equipe 
add constraint equipe_tarefa 
foreign key (id_tarefa_fk) references tarefa(id_tarefa);

alter table possui 
add constraint possui_equipe 
foreign key (id_equipe_fk) references equipe(id_equipe);

alter table possui 
add constraint possui_funcionario 
foreign key (cpf_fk) references funcionario(cpf);

alter table requerem 
add constraint requerem_tarefa 
foreign key (id_tarefa_fk) references tarefa(id_tarefa);

alter table requerem 
add constraint requerem_materiais 
foreign key (id_materiais_fk) references materiais(id_materiais);

alter table telefone 
add constraint telefone_fornecedor 
foreign key (id_fornecedor_fk) references fornecedor(id_fornecedor);

alter table endereco 
add constraint endereco_fornecedor 
foreign key (id_fornecedor_fk) references fornecedor(id_fornecedor);

alter table fornece 
add constraint fornece_materiais 
foreign key (id_materiais_fk) references materiais(id_materiais);

alter table fornece 
add constraint fornece_fornecedor 
foreign key (id_fornecedor_fk) references fornecedor(id_fornecedor);