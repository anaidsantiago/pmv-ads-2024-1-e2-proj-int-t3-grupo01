# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Personas
#As personas levantadas durante o processo de entendimento do problema são apresentadas na Figuras que se seguem.

### Antônia Tamires Silva de Carvalho
Idade: 34 anos
Cargo/ Função: Gerente do laboratório 

Escolaridade: Superior

Descrição da sua ocupação: Supervisão administrativa, coordenar e desempenhar atividades referentes ao Laboratório; organizar e controlar estoque de laboratório.
Enumere e detalhe as personas da sua solução. Para tanto, baseie-se tanto nos documentos disponibilizados na disciplina e/ou nos seguintes links:

### Wanderson Rodrigo Pinheiro
Idade: 19 anos
Cargo/ Função: Montador e supervisor

Escolaridade: Superior Incompleto

Descrição da sua ocupação: Conferência de lentes, montagem de lentes manual e automático, adaptações, consertos em gerais, digitação do caderno de montagem, relatório mensal do caderno de montagem, atualização do estoque de lentes, manutenção, consertos e limpeza das máquinas, busca dos malotes, relatório de repasse de falta de equipamentos e lentes, organização e limpeza do laboratório, retirar e adicionar lentes no Dropbox, ajustes de relógios, remoção de antirreflexo, organizar e despachar malotes, montagem de moldes.

### Samilly Sousa de Lima
Idade: 24 anos
Cargo/ Função: Montador e auxiliar administrativo 

Escolaridade: Superior Incompleto

Descrição da sua ocupação: Conferência de lentes, montagem de lentes automático, adaptações, consertos em gerais, atualização do estoque de lentes, limpeza das máquinas, relatório de repasse de falta de lentes, organização e limpeza do laboratório, relatório de saída de lentes, arquivar receitas virtuais, relatório de receitas não arquivadas, pedido de lentes Fitlab e Unilab, retirar e adicionar lentes no Dropbox, ajustes de relógios, remoção de antirreflexo, organização de malotes, montagem de moldes.

### Edcarlos Junior
Idade: 18 anos
Cargo/ Função: auxiliar de montagem

Escolaridade: Ensino Médio

Descrição da sua ocupação: Conferência de lentes, montagem de lentes automático, consertos de algumas armações, limpezas das máquinas, organização e limpeza do laboratório, arquivar receitas físicas, ajustes de alguns relógios, remoção de antirreflexo.

### Ótica (cliente)
Cargo/ Função: cliente que solicita o pedido de montagem dos óculos

Descrição da sua ocupação: encaminhar pedido ao setor de montagem, solicitar nota de serviço, acompanhar o status do serviço contratado e verificar prazo de entrega.

### Opti Prime
Cargo/ Função: fornecedor de produtos 

Descrição da sua ocupação: fornece lentes multifocais e lentes filtro azul

### Perego
Cargo/ Função: distribuidor de lentes 

Descrição da sua ocupação: fornece lentes Essilor, Zeiss, Hoya, Younger, Transitions

### FIT LAB
Cargo/ Função: laboratório de apoio externo 

Descrição da sua ocupação: terceirização de serviços - surfaçagem

### UNILAB
Cargo/ Função: laboratório de apoio externo

Descrição da sua ocupação: terceirização de serviços - surfaçagem




> **Links Úteis**:
> - [Rock Content](https://rockcontent.com/blog/personas/)
> - [Hotmart](https://blog.hotmart.com/pt-br/como-criar-persona-negocio/)
> - [O que é persona?](https://resultadosdigitais.com.br/blog/persona-o-que-e/)
> - [Persona x Público-alvo](https://flammo.com.br/blog/persona-e-publico-alvo-qual-a-diferenca/)
> - [Mapa de Empatia](https://resultadosdigitais.com.br/blog/mapa-da-empatia/)
> - [Mapa de Stalkeholders](https://www.racecomunicacao.com.br/blog/como-fazer-o-mapeamento-de-stakeholders/)
>
Lembre-se que você deve ser enumerar e descrever precisamente e personalizada todos os clientes ideais que sua solução almeja.

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Antônia Tamires 
Silva de Carvalho    | Cadastrar nota fiscal e encaminha
                       para ótica referente ao pedido     | Não esquecer de fazê-las               |
|Administrador       | Alterar permissões                 | Permitir que possam administrar contas |




## Requisitos

O escopo funcional do projeto é definido por meio dos requisitos funcionais que descrevem as possibilidades interação dos usuários, bem como os requisitos não funcionais que descrevem os aspectos que o sistema deverá apresentar de maneira geral. Estes requisitos são apresentados a seguir.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| A aplicação deve permitir que o usuário gerencie suas tarefas | ALTA | 
|RF-002| A aplicação deve emitir um relatório de tarefas realizadas no mês   | MÉDIA |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| A aplicação deve ser responsiva | MÉDIA | 
|RNF-002| A aplicação deve processar requisições do usuário em no máximo 3s |  BAIXA | 

Com base nas Histórias de Usuário, enumere os requisitos da sua solução. Classifique esses requisitos em dois grupos:

- [Requisitos Funcionais
 (RF)](https://pt.wikipedia.org/wiki/Requisito_funcional):
 correspondem a uma funcionalidade que deve estar presente na
  plataforma (ex: cadastro de usuário).
- [Requisitos Não Funcionais
  (RNF)](https://pt.wikipedia.org/wiki/Requisito_n%C3%A3o_funcional):
  correspondem a uma característica técnica, seja de usabilidade,
  desempenho, confiabilidade, segurança ou outro (ex: suporte a
  dispositivos iOS e Android).
Lembre-se que cada requisito deve corresponder à uma e somente uma
característica alvo da sua solução. Além disso, certifique-se de que
todos os aspectos capturados nas Histórias de Usuário foram cobertos.

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| Não pode ser desenvolvido um módulo de backend        |


Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
