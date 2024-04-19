select Cliente.Nome, Modelo.Nome 
from
Aluguel
inner join Cliente
on Aluguel.IdCliente = Cliente.IdCliente
inner join Veiculo
on Aluguel.IdVeiculo = Veiculo.IdVeiculo
inner join Modelo 
on Veiculo.IdModelo = Modelo.IdModelo

where Cliente.IdCliente = 1

select * from Veiculo