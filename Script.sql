/*Criando o banco de dados*/

create database dbprojeto;

/* use dbprojeto;*/

/*Criando as tabelas do banco*/

create table tbCliente (
codCli int primary key auto_increment,
nome varchar(50),
telefone varchar(20),
email varchar(50)
);

select * from tbCliente;