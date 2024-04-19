select Usuarios.IdUsuario, Usuarios.Email, Usuarios.Nome, Usuarios.Permissao
from Usuarios
where Permissao = 'Administrador'

select * from Albuns
where DataLancamento = '26/07/2024'

select * from Usuarios
where Usuarios.Email = 'enzo@email.com' and Usuarios.Senha = '1234'

select * from Albuns
where Albuns.Ativo = 'sim'