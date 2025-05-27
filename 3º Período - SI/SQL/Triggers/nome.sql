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

delimiter //
create trigger tr_atualiza_data_alteracao_cpf 
	before update on cliente
    for each row
    begin
		if (new.cpf != old.cpf) then
			update contavinculada 
            set dataAbertura = now()
            where old.idCLIENTE = CLIENTE_idCLIENTE;
		end if;
	end//
delimiter ;

select * from contavinculada;
select * from cliente;

update cliente 
set cpf = '123.123.123-12'
where idCLIENTE = 1;


