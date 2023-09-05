

create table tbl_cliente(
 id serial constraint pk_id_cliente primary key,
 d_cadastro date not null,
 nome varchar(150) not null, 
 telefone varchar(16) not null,
 cep varchar(9) not null,
 logradouro varchar(150) not null,
 numero_casa int4 not null default 0,
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

create table tbl_servico(
 id serial constraint pk_id_servico primary key,
 d_cadastro date not null,
 nome varchar(150) not null,
 valor money 
);

create table tbl_venda_produto(
 id serial constraint pk_id_venda_produto primary key,
 d_cadastro date not null,
 tipo_pagamento varchar(6),
 total money not null, 
 produtos text,
 adicionais text,
 observacao text,
 id_cliente int not null,
 id_receita int not null,
 foreign key (id_receita) references tbl_receita (id) 
 on  delete  cascade,
 foreign key (id_cliente) references tbl_cliente (id) 
 on  delete  cascade
);


create table tbl_venda_servico(
 id serial constraint pk_id_venda_servico primary key,
 d_cadastro date not null,
 tipo_pagamento varchar(6),
 total money not null, 
 observacao text,
 servicos text not null
);


create table tbl_produto(
 id serial constraint pk_id_produto primary key,
 d_cadastro date not null,
 nome varchar(150) not null,
 quantidade int,
 valor money not null
);


create table tbl_caixa(
	 id serial constraint pk_id_caixa primary key,
	 valor money not null
);


create table tbl_movimentacao(
	 id serial constraint pk_id_movimentacao primary key,
	 d_cadastro date not null,
	 descricao varchar(200) not null,
	 tipo varchar(7) not null,
	 id_venda int,
	 valor money not null
);



create table tbl_transacoes(
	 id serial constraint pk_id_transacoes primary key,
	 d_cadastro date not null,
	 tipo_transacao varchar(7) not null,
	 tipo_venda varchar(7) not null,
	 valor money not null,
	 id_servico int,
	 id_produto int,
	 foreign key (id_servico) references tbl_venda_servico (id) 
	 on  delete  cascade,
	 foreign key (id_produto) references tbl_venda_produto (id) 
	 on  delete  cascade
);




























