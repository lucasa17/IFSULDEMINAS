create database TesteTrigger;

use TesteTrigger;

create table Estoque(
id_estoque int auto_increment primary key,
nome_item_estoque varchar(45) not null,
preco_item decimal(10,2) not null,
preco_desconto decimal(10,2) not null
);

describe Estoque;

create trigger tr_preco_desconto
before insert 
on Estoque
for each row
	set new.preco_desconto = (new.preco_item * 0.5);
    
show triggers;

insert into Estoque (nome_item_estoque, preco_item)
values ('Monitor', 1000);

insert into Estoque (nome_item_estoque, preco_item)
values ('Mouse', 300);

insert into Estoque (nome_item_estoque, preco_item)
values ('Teclado', 150);

select * from Estoque;

create table Cliente(
id_cliente int auto_increment primary key,
nome varchar(45) not null,
idade int not null,
ano_nascimento int not null
);

create trigger tr_atualiza_ano_nascimento
before insert 
on Cliente
for each row
	set new.ano_nascimento = (year(now()) - new.idade);
    
drop trigger tr_atualiza_ano_nascimento;

insert into cliente(nome, idade) values ('Lucas', 19);

delete from cliente where id_cliente = 2;

select * from cliente;

create table auditoria(
id_auditoria int auto_increment primary key,
nome_item_estoque varchar(45) not null,
preco_item decimal(10,2) not null,
preco_desconto decimal(10,2) not null,
data_insercao datetime
);

create trigger tr_logs_auditoria 
after insert 
on Estoque
for each row
	insert into auditoria(nome_item_estoque, preco_item, preco_desconto, data_insercao) 
    values (new.nome_item_estoque, new.preco_item, new.preco_desconto, now());
    
insert into Estoque (nome_item_estoque, preco_item)
values ('Placa de video', 1500);

select * from estoque;
select * from auditoria;
