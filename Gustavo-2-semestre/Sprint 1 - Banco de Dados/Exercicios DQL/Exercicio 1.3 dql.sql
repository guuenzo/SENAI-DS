select
Veterinario.IdClinica,
Veterinario.Nome,
Veterinario.CRMV
from
Veterinario

select
Raca.Descricao
from
Raca
where Raca.Descricao like 's%'

select 
TipoPet.Descricao
from
TipoPet
where TipoPet.Descricao like '%o'

select 
Pet.Nome, Dono.Nome
from Pet
inner join Dono
on Pet.IdDono = Dono.IdDono

select
Atendimentos.Descricao as Atendimento, 
Veterinario.Nome as [Nome Veterinario], 
Pet.Nome as [Nome do pet], 
Raca.Descricao as Raca, 
TipoPet.Descricao as [Tipo do pet], 
Dono.Nome as [Nome do dono], 
Clinica.IdClinica as Clinica
from Atendimentos 
inner join Veterinario
on Atendimentos.IdVeterinario = Veterinario.IdVeterinario
inner join Pet
on Atendimentos.IdPet = Pet.IdPet
inner join Raca 
on Pet.IdRaca = Raca.IdRaca
inner join TipoPet
on Pet.IdTipoPet = TipoPet.IdTipoPet
inner join Dono
on Pet.IdDono = Dono.IdDono
inner join Clinica
on Veterinario.IdClinica = Clinica.IdClinica

-- listar todos os atendimentos mostrando o nome do veterinário que atendeu, o nome, a raça e o tipo do pet que foi atendido, o nome do dono do pet e o nome da clínica onde o pet foi atendido




