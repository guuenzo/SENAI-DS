--DQL 
use HealthClinic 
select 
     Consulta.IdConsulta,
     Consulta.Dia,
     Consulta.Horario,
     Clinica.Nome,
     [Nome Do Paciente].Nome as [Nome do paciente],
     [Nome Do Medico].Nome as [Nome do Medico],
     Especialidade.Titulo as [EspecialidadeMedico],
     Medico.CRM,
     Consulta.Prontuario
     --Comentario.Descricao 
from Consulta 
inner join Medico 
on Medico.IdMedico = Consulta.IdMedico

inner join Clinica
on Clinica.IdClinica = Medico.IdClinica

inner join Especialidade
on Especialidade.IdEspecialidade = Medico.IdEspecialidade

inner join Paciente
on Paciente.IdPaciente = Consulta.IdPaciente

inner join Usuario as [Nome Do Paciente]
on Paciente.IdUsuario = [Nome Do Paciente].IdUsuario 

inner join Usuario as [Nome Do Medico]
on Medico.IdUsuario = [Nome Do Medico].IdUsuario 

create function VerEspecialidade
(
	@Especialidade VARCHAR(30)
)
returns table
as
return
(
select
	 Usuario.Nome AS 'Nome do Médico',
	 Especialidade.Titulo AS 'Especialização'
from Especialidade
inner join Medico
on Medico.IdEspecialidade = Especialidade.IdEspecialidade

inner join Usuario
on Usuario.IdUsuario = Medico.IdUsuario

where Especialidade.Titulo = @Especialidade
)

--Execução da função
select * from VerEspecialidade('Neurologista');
