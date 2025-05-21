use bancobd22025;

show tables;

select * from cliente;

create trigger tr_nome_maiusculo
	before insert
	on cliente
	for each row
		set new.nome = upper(new.nome);
        
insert into cliente (nome, cpf, rg, dataNascimento, telefone) 
	values ('Joana', 6464, 7327837, '2019-02-02', 26725);

select * from cliente order by idCLIENTE desc;
