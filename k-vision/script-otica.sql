create table tbl_cliente(
 id serial constraint pk_id_cliente primary key,
 d_cadastro date not null,
 nome varchar(150) not null, 
 telefone varchar(16) not null
);

create table tbl_receita(
 id serial constraint pk_id_receita primary key,
 d_cadastro date not null, 
 d_exame date not null, 
 d_val_exame date not null,
 nome_examinador varchar(150) not null, 
 id_cliente int not null,
 foreign key (id_cliente) references tbl_cliente (id) 
 on  delete  cascade
);

create table tbl_prescricao(
 id serial constraint pk_id_prescricao primary key,
 d_cadastro date not null,
 tipo varchar(6) not null, 
 esf_direito decimal null, 
 cil_direito decimal null, 
 eixo_direito decimal null, 
 dnp_direito decimal null, 
 esf_esquerdo decimal null, 
 cil_esquerdo decimal null, 
 eixo_esquerdo decimal null, 
 dnp_esquerdo decimal null, 
 id_receita int not null,
 foreign key (id_receita) references tbl_receita (id) 
 on  delete  cascade
);

create table tbl_pedido(
 id serial constraint pk_id_pedido primary key,
 d_cadastro date not null,
 tipo_pagamento varchar(6),
 total money not null, 
 id_cliente int not null,
 id_receita int not null,
 foreign key (id_receita) references tbl_receita (id) 
 on  delete  cascade,
 foreign key (id_cliente) references tbl_cliente (id) 
 on  delete  cascade
);


create table tbl_adicional(
 id serial constraint pk_id_adicional primary key,
 d_cadastro date not null,
 descricao varchar(150) not null, 
 valor money not null, 
 id_pedido int,
 foreign key (id_pedido) references tbl_pedido (id) 
 on  delete  cascade
);


create table tbl_produto(
 id serial constraint pk_id_produto primary key,
 d_cadastro date not null,
 nome varchar(150) not null,
 quantidade int,
 valor money not null
);

create table tbl_item_pedido(
 id serial constraint pk_id_item_pedido primary key,
 d_cadastro date not null,
 id_pedido int,
 id_produto int,
 foreign key (id_pedido) references tbl_pedido (id) 
 on  delete  cascade,
 foreign key (id_produto) references tbl_produto (id) 
 on  delete  cascade
);

















