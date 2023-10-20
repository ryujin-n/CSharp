create database t14_miniprojeto
use t14_miniprojeto

create table usuario
(
	id_usuario int not null identity primary key,
	nome_usuario varchar(50) not null  ,
	login_usuario varchar(30) not null unique ,
	senha_usuario varchar(30) not null  ,
	data_usuario smalldatetime not null default getdate() ,
	obs_usuario varchar(255) null  ,
	status_usuario varchar(20) not null default 'ATIVO' 
)

insert into usuario (nome_usuario,login_usuario,senha_usuario,obs_usuario)values('Administrador','admin','123','Usuário adm padrão')

select * from usuario
delete from usuario where id_usuario = 2


create table func
(
	 id_funcionario int not null identity primary key ,
	 nome_funcionario varchar(50) not null  ,
	 nasc_funcionario date not null  ,
	 data_funcionario smalldatetime not null default getdate() ,
	 cpf_funcionario char(14) not null unique ,
	 logradouro_funcionario varchar(50) not null  ,
	 numero_funcionario int not null  ,
	 comp_funcionario varchar(20) null  ,
	 cep_funcionario char(9) not null  ,
	 bairro_funcionario varchar(50) not null  ,
	 cidade_funcionario varchar(50) not null  ,
	 uf_funcionario char(2) not null  ,
	 telefone1_funcionario char(16) not null  ,
	 telefone2_funcionario char(16) null  ,
	 obs_funcionario varchar(200) null  ,
	 status_funcionario varchar(20) not null default 'ATIVO' 

)
select * from func

select * from prod

create table prod

(
	id_produto int not null identity primary key ,
	nome_produto varchar(30) not null unique ,
	data_produto smalldatetime not null default getdate() ,
	qtde_produto int not null  ,
	Vcusto_produto decimal(10,2) not null  ,
	Vvenda_produto decimal(10,2) not null  ,
	obs_produto varchar(200) null  ,
	status_produto varchar(20) not null default 'ATIVO' 
)
select * from prod


create table forn
(
	id_fornecedor int not null identity primary key ,
	nome_fornecedor varchar(50) not null  ,
	abert_fornecedor date not null  ,
	data_fornecedor smalldatetime not null default getdate() ,
	cnpj_fornecedor char(18) not null unique ,
	logradouro_fornecedor varchar(50) not null  ,
	numero_fornecedor int not null  ,
	cep_fornecedor varchar(9) null  ,
	bairro_fornecedor char(50) not null  ,
	cidade_fornecedor varchar(50) not null  ,
	uf_fornecedor char(2) not null  ,
	telefone1_fornecedor char(16) not null  ,
	telefone2_fornecedor char(16) not null  ,
	contato_fornecedor char(50) null  ,
	obs_fornecedor varchar(200) null  ,
	status_fornecedor varchar(20) not null default 'ATIVO' 

)
select * from forn
drop table forn

create table locest
(
	 id_LocalEstoque int not null identity primary key ,
	 nome_LocalEstoque varchar(50) not null  ,
	 data_LocalEstoque smalldatetime not null default getdate() ,
	 obs_LocalEstoque varchar(255) null  ,
	 status_LocalEstoque varchar(20) not null default 'ATIVO' 
)
select * from locest
drop table locest
select * from locest
