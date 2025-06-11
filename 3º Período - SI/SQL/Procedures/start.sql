show databases;

use bancobd22025;

delimiter #
create procedure sp_hello_world()
	begin
		select"Hello world" as Mensagem;
	end#
delimiter ;

call sp_hello_world();

drop procedure sp_hello_world;

delimiter #
create procedure sp_list_accounts()
	begin
		select * from conta co, 
        cliente cli,
        contavinculada cv
        where Cliente_idCLIENTE = CONTA_idCONTA;
	end#
delimiter ;

call sp_list_accounts();
