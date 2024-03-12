# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Personas
As personas levantadas durante o processo de entendimento do problema são apresentadas na Figuras que se seguem.

### Antônia Tamires Silva de Carvalho
Idade: 34 anos
Cargo/ Função: Gerente do laboratório 

Escolaridade: Superior

Descrição da sua ocupação: A gerente é responsável pela supervisão geral das operações do laboratório de montagem de óculos. Toma decisões estratégicas relacionadas à produção, recursos humanos, finanças e estratégias de negócios.
Monitora o desempenho operacional e financeiro do laboratório. Define metas e objetivos de produção, qualidade e eficiência. Utiliza o aplicativo para acessar dados e relatórios de desempenho, realizar análises e tomar decisões estratégicas para otimizar os processos de produção.

### Marcela Lima
Idade: 2 anos
Cargo/ Função: Assistente administrativo 

Escolaridade: Superior Completo

Descrição da sua ocupação:  A assistente administrativa oferece suporte administrativo e logístico às operações do laboratório. É responsável pelo agendamento de pedidos, gerenciamento de estoque e comunicação com fornecedores. Auxilia na emissão de documentos, como faturas, ordens de compra e relatórios de produção. Utiliza o aplicativo para registrar estoque, verificar o status de entregas, gerenciar inventário e manter registros atualizados.

### Wanderson Rodrigo Pinheiro
Idade: 19 anos
Cargo/ Função: Montador

Escolaridade: Superior Incompleto

Descrição da sua ocupação: O montador é responsável pela montagem física dos óculos de acordo com as especificações e padrões estabelecidos. Realiza tarefas como encaixe de lentes nas armações, ajustes de tamanho e montagem de componentes adicionais.
Garante a qualidade e precisão do produto final, seguindo procedimentos e padrões de controle de qualidade. Utiliza o aplicativo para receber instruções de montagem, registrar o progresso do trabalho e reportar eventuais problemas ou defeitos identificados durante o processos.

### Ótica (cliente)
Cargo/ Função: cliente que solicita o pedido de montagem dos óculos

Descrição da sua ocupação: A óptica representa o cliente externo que solicita a realização dos óculos ao laboratório de montagem, pode ser um profissional independente que possui uma óptica ou uma loja de varejo de produtos ópticos.
Ele fornece as especificações do pedido, incluindo informações sobre a prescrição do cliente, tipo de lente, tratamentos desejados e preferências de armação. Espera uma comunicação clara e eficiente com o laboratório para acompanhar o status do pedido, fazer ajustes quando necessário e garantir a entrega dentro do prazo. Utiliza o aplicativo para enviar e acompanhar pedidos, verificar o status de produção, comunicar-se com o laboratório e garantir a satisfação do cliente final.


## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Antônia Tamires Silva de Carvalho    | Cadastrar nota fiscal e encaminha para ótica referente ao pedido     | Deixar ciente sobre o valor do pedido solicitado|
|Antônia Tamires Silva de Carvalho     | Ter acesso a todos os pedidos encaminhados ao setor de montagem               | Analisar o andamento e a restrição de cada pedido |
|Antônia Tamires Silva de Carvalho     | Ter acesso ao estoque e a solicitação de compra enviada pelo setor de montagem              | Repor estoque e aprovar ordem de compra ao fornecedor |
|Wanderson Rodrigo Pinheiro     | Receber os pedidos enviados pelas óticas (clientes)             | Cadastrar serviço e dar início a montagem |
|Samilly Sousa de Lima    | Enviar ordem de serviço para Antônia Tamires Silva de Carvalho aprovar serviço de terceirização das lentes   | Encaminhar aos laboratórios a terceirização do serviço |
|Ótica (cliente)     | Acessar os pedidos em andamentos             | Receber o serviço de montagem|
|Ótica (cliente)     | Cadastrar pedido         | Cadastrar serviço e dar início a montagem |
|Opti Prime     | Cadastrar notas fiscais de entrada e verificar histórico de pedidos             | Gerar relatórios financeiro e atualizar estoque |


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
|RNF-001| O site deve ser publicado em um ambiente acessível publicamente na Internet (Repl.it, GitHub Pages, Heroku); | ALTA | 
|RNF-002| O site deverá ser responsivo permitindo a visualização em um celular de forma adequada |  ALTA | 
|RNF-003| O site deve ter bom nível de contraste entre os elementos da tela em conformidade |  MÉDIA | 
|RNF-004| O site deve ser compatível com os principais navegadores do mercado (Google Chrome, Firefox, Microsoft Edge) |  ALTA | 
|RNF-005| O tempo de resposta das operações não pode ultrapassar 3 segundos |  ALTA | 


## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID   | Restrição                                             |
|-----|-------------------------------------------------------|
|RE-01| O projeto deverá ser entregue no final do semestre letivo, não podendo extrapolar a data de 23/06/2024. |
|RE-02| O projeto deve ser planejado e executado dentro dos recursos financeiros disponíveis, incluindo custos relacionados a hardware, software, ferramentas de desenvolvimento e quaisquer outros gastos associados ao projeto. |
|RE-03| A equipe não pode subcontratar o desenvolvimento do trabalho. |

## Diagrama de Casos de Uso



O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

