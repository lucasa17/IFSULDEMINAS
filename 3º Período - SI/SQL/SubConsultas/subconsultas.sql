use sakila;

select  customer_id as ID,
		first_name as Nome, 
		last_name as Sobrenome
from customer;

create view vw_lista_clientes as
	select  customer_id as ID,
			concat(first_name, " ", last_name) as Nome
    from customer;

select * from vw_lista_clientes;


create view vw_lista_atores as
	select  actor_id as ID,
			concat(first_name, " ", last_name) as Nome
    from actor;

select * from vw_lista_atores;



select * from film;

select distinct rental_duration as "Durações de aluguel"
from film
order by rental_duration asc;
    
create view vw_duracao_aluguel as
	select distinct rental_duration as "Durações de aluguel"
	from film
    order by rental_duration asc;

select * from vw_duracao_aluguel;


select  count(film_id),
		rental_duration
from film 
group by rental_duration;

create view vw_quantia_filme_duracao_aluguel as
	select  count(film_id) as "Número de titulos",
			rental_duration as "Tempo de aluguel"
	from film 
	group by rental_duration;
    
select * from vw_quantia_filme_duracao_aluguel;


select * from customer;
select * from address;
select * from city;

select  C.customer_id as "ID cliente",
		concat(C.first_name, " ",C.last_name) as "Nome do cliente",
        A.district as Distrito,
        CI.city as Cidade
from customer C,
	 address A,
     city CI
where C.address_id = A.address_id and A.city_id = CI.city_id;       

create view vw_cliente_cidade_distrito as 
	select  C.customer_id as "ID cliente",
			concat(C.first_name, " ",C.last_name) as "Nome do cliente",
			A.district as Distrito,
			CI.city as Cidade
	from customer C,
		 address A,
		 city CI
	where C.address_id = A.address_id and A.city_id = CI.city_id; 

select * from  vw_cliente_cidade_distrito;

select * from payment;

select  concat(C.first_name, " ",C.last_name) as "Nome do cliente",
		C.customer_id as ID,
        sum(P.amount)
from customer C,
	 payment P
where C.customer_id = P.customer_id 
group by C.customer_id;

create view vw_gasto_clente as 
	select  concat(C.first_name, " ",C.last_name) as "Nome do cliente",
		C.customer_id as ID,
        sum(P.amount) as "Gasto total"
	from customer C,
		 payment P
	where C.customer_id = P.customer_id 
	group by C.customer_id;

show view vw_gasto_clente;
