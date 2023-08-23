

create table tbl_cliente(
 id serial constraint pk_id_cliente primary key,
 d_cadastro date not null,
 nome varchar(150) not null, 
 telefone varchar(16) not null,
 cep varchar(9) not null,
 logradouro varchar(150) not null,
 complemento  varchar(200) null,
 bairro varchar(150) not null,
 localidade varchar(20) not null
);

CREATE TABLE public.tbl_prescricao_adicional (
	id serial CONSTRAINT pk_id_prescricao_adicional PRIMARY key,
	d_cadastro date NOT NULL,
	adicao_direito varchar NULL,
	altura_direito varchar NULL,
	adicao_esquerdo varchar NULL,
	altura_esquerdo varchar NULL
);


create table tbl_receita(
 id serial constraint pk_id_receita primary key,
 d_cadastro date not null, 
 d_exame date not null, 
 d_val_exame date not null,
 nome_examinador varchar(150) not null, 
 id_cliente int not null,
 id_adicional int4,
 CONSTRAINT tbl_cliente_id_fkey foreign key (id_cliente) references public.tbl_cliente (id) on  delete  cascade,
 CONSTRAINT tbl_prescricao_id_adicional_fkey FOREIGN KEY (id_adicional) REFERENCES public.tbl_prescricao_adicional(id) ON DELETE CASCADE
);



CREATE TABLE public.tbl_prescricao (
	id serial CONSTRAINT pk_id_prescricao PRIMARY KEY,
	d_cadastro date NOT NULL,
	tipo int4 NOT NULL,
	esf_direito varchar NULL,
	cil_direito varchar NULL,
	eixo_direito varchar NULL,
	dnp_direito varchar NULL,
	esf_esquerdo varchar NULL,
	cil_esquerdo varchar NULL,
	eixo_esquerdo varchar NULL,
	dnp_esquerdo varchar NULL,
	id_receita int4 NOT NULL,
	CONSTRAINT tbl_prescricao_id_receita_fkey FOREIGN KEY (id_receita) REFERENCES public.tbl_receita(id) ON DELETE cascade
);



create table tbl_venda(
 id serial constraint pk_id_venda primary key,
 d_cadastro date not null,
 tipo_pagamento varchar(6),
 total money not null, 
 produtos text,
 adicionais text,
 id_cliente int not null,
 id_receita int not null,
 foreign key (id_receita) references tbl_receita (id) 
 on  delete  cascade,
 foreign key (id_cliente) references tbl_cliente (id) 
 on  delete  cascade
);

create table tbl_produto(
 id serial constraint pk_id_produto primary key,
 d_cadastro date not null,
 nome varchar(150) not null,
 quantidade int,
 valor money not null
);

































