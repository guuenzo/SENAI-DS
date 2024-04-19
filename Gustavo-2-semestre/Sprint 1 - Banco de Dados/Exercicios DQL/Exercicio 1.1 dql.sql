--DQL

use Exercicio_1_1

select
p.Nome as Batata, 
Telefone.Numero as Telefone, 
e.EnderecoEmail as Emaiil, 
p.CNH
from 
Pessoa as p, 
Telefone, 
Email as e
where
p.IdPessoa = e.IdPessoa 
and p.IdPessoa = Telefone.IdPessoa
--Ordena a consulta por ordem alfabetica "DESC, faz o contrario"
order by Nome
--"as" para colocar apelidos nas colunas de uma tabela na hora da consulta

insert into Pessoa values('Artur', '12343214')
insert into Email values(1, 'artur@email.com')
insert into Telefone values(1, '11987675433')

select * from Telefone