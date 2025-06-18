-- Nome: Lucas Silva da Rosa

use burger;
show tables;

-- 1. Criar uma Stored Procedure que, passando o código do cliente e o e-mail, atualize o e-mail de um cliente na tabela cliente.

delimiter #
create procedure sp_atualiza_email_por_codigo (
in p_codigo int, in p_email varchar(200)
)
begin
	update cliente set email = p_email 
    where codCliente = p_codigo;
end#
delimiter ;

-- 2. Criar uma Stored Procedure que, passando um nome novo, insira uma nova marca na tabela marca.
select * from marca;
describe marca;

delimiter #
create procedure sp_insere_marca (
in snome varchar(100)
)
begin
	insert into marca (nome) values (snome);
end#
delimiter ;

call sp_insere_marca("Lucas");

-- 3. Criar uma Stored Procedure que, passando o código e um nome novo, atualize o nome da marca na tabela marca.
select * from marca;

delimiter #
create procedure sp_atualiza_marca (
in scodMarca int, in snome varchar(100)
)
begin
	update marca set nome = snome 
    where codMarca = scodMarca;
end#
delimiter ;

call sp_atualiza_marca(8, "Lucasa");


-- 4. Criar uma Stored Procedure que, passando o código de uma marca, apague uma marca na tabela marca.
select * from marca;

delimiter #
create procedure sp_deleta_marca (
in scodMarca int
)
begin
	delete from marca 
    where codMarca = scodMarca;
end#
delimiter ;

call sp_deleta_marca(8);

-- 5.Criar uma Stored Procedure que, passando um nome novo, insira uma nova categoria na tabela categoria.
select * from categoria;
describe categoria;

delimiter #
create procedure sp_insere_categoria (
in snome varchar(100)
)
begin
	insert into categoria (nome) values (snome);
end#
delimiter ;

call sp_insere_categoria("bagulhos estranhos");

-- 6.Criar uma Stored Procedure que, passando o nome do cliente e a data de nascimento, insira um novo cliente na tabela cliente.
select * from cliente;
describe cliente;

delimiter #
create procedure sp_insere_cliente (
in snome varchar(100), in sdata date
)
begin
	insert into cliente (nome, dataNascimento) values (snome, sdata);
end#
delimiter ;

call sp_insere_cliente("Lucas Rosa", "2000-02-02");


-- 7.Criar uma Stored Procedure que, passando o código e uma nova margem de lucro, atualize a margem de lucro de um produto na tabela produto. 
-- Caso o código não corresponda a um produto, retornar a mensagem de “Produto não encontrado”.
select * from produto;
describe produto;

delimiter #
create procedure sp_atualiza_lucro (
in scodProduto int, in smargemLucro decimal(5,2)
)
begin
	update produto set margemLucro = smargemLucro
    where codProduto = scodProduto;
    
    if row_count() = 0 then
		select"Produto não encontrado" as Mensagem;
	end if;
end#
delimiter ; 

call sp_atualiza_lucro(1, 120);
call sp_atualiza_lucro(2, 120);

-- 8.Criar uma Stored Procedure que, passando os campos obrigatórios, 
-- insira um novo produto na tabela produto.*/Add commentMore actions
describe produto;
DELIMITER //
CREATE PROCEDURE sp_insere_produto(
    IN snome VARCHAR(200),
    IN sprecoCusto DECIMAL(10,2),
    IN sprecoVenda DECIMAL(10,2),
    IN sCATEGORIA_codCategoria INT(11),
    IN sMARCA_codMarca INT(11))
    BEGIN
		INSERT INTO produto (nome,precoCusto,precoVenda,CATEGORIA_codCategoria,MARCA_codMarca)
        VALUES (snome, sprecoCusto, sprecoVenda, sCATEGORIA_codCategoria, sMARCA_codMarca);
END //
DELIMITER ;

call sp_insere_produto("a", 1, 1, 1, 1);
select * from produto;

-- 9.Criar uma Stored Procedure que, passando parte do nome do cliente, 
-- seja possível consultar os clientes que possuem esta informação em qualquer parte do seu nome. 
DELIMITER //
CREATE PROCEDURE sp_procura_cliente(
	IN snome VARCHAR(200))
    BEGIN
    SELECT * FROM cliente WHERE nome LIKE concat("%",snome,"%");
END //
DELIMITER ;

select * from cliente;
call sp_procura_cliente("Telles");
