create database Lucasana;

use lucasana;

create table usuario(
id_usuario int not null auto_increment primary key,
nome_usuario varchar(50),
cpf_usuario int not null unique
);

create user lucas identified by '123';

create user lucas identified by '123';
set password for lucas = '321';
grant all on lucasana.usuario to lucas;
revoke update on lucasana.usuario from lucas;
revoke delete on lucasana.usuario from lucas;

create user ana@10.0.24.38 identified by '123';
grant select, insert on lucasana.usuario to ana@10.0.24.38;

create user lucasadm identified by '123';
grant insert, update, delete, select on lucasana.usuario to lucasadm;


use sakila;

show tables;

select * from film_actor;
select * from actor;


select concat(C.first_name, " ", C.last_name) 
as Nome, P.amount as Valor
from customer as C, payment as P
where C.customer_id = P.customer_id and P.amount > (select avg(amount) from payment)
order by Valor desc;


select concat(A.first_name, " ", A.last_name) 
as "Ator(a)", F.title as Filme, F.length as Duração
from film_actor as FA,
	 film as F,
     actor as A
where A.actor_id = FA.actor_id and 
FA.film_id = F.film_id and
F.length > (select avg(length) from film);


select concat(A.first_name, " ", A.last_name) 
as "Ator(a)", F.title as Filme, F.length as Duração
from film_actor as FA,
	 film as F,
     actor as A
where A.actor_id = FA.actor_id and 
FA.film_id = F.film_id and
F.length > (select avg(length) from film);


select * from film_actor where film_id in(
	select film_id from film where length > (
		select avg(length) from film));
        
        
        

