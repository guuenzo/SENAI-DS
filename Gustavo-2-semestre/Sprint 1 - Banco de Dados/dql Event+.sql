--DQL

select Usuario.Nome,
  TiposDeUsuario.TituloTipoUsuario as [TipoUsuario],
  Evento.DataEvento,
  Instituicao.NomeFantasia as [NomeInstituicao],
  Instituicao.Endereco, 
  TiposDeEvento.TituloTipoEvento as [TipoEvento],
  Evento.Nome as [NomeEvento],
  Evento.Descricao as [DescricaoEvento],
  case when PresencasEvento.Situacao = 1 then 'Confirmado' else 'Não confirmado' end as [SituacaoEvento],
  ComentarioEvento.Descricao as [ComentarioEvento]
from PresencasEvento
  inner join Usuario
  on PresencasEvento.IdUsuario = Usuario.IdUsuario
  inner join TiposDeUsuario
  on Usuario.IdTipoDeUsuario = TiposDeUsuario.IdTipoDeUsuario
  inner join Evento
  on PresencasEvento.IdEvento = Evento.IdEvento
  inner join Instituicao
  on Evento.IdInstituicao = Instituicao.IdInstituicao
  inner join TiposDeEvento 
  on Evento.IdTipoDeEvento = TiposDeEvento.IdTipoDeEvento
  inner join ComentarioEvento 
  on Usuario.IdUsuario = ComentarioEvento.IdUsuario
