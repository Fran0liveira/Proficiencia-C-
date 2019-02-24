create database proficiencia

go

use proficiencia

go

create table cliente(
	codigo int identity(1,1),
	nome varchar(40) not null,
	rg char(9),
	cpf char(11),
	tel_residencial char(11),
	tel_celular char(11),
	sexo varchar(20),
	primary key(codigo),
);

go

select * from cliente

alter table cliente 
drop chk_sexo

