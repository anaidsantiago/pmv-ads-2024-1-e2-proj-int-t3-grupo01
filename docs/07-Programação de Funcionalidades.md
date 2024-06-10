# Programação de Funcionalidades

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="4-Metodologia.md"> Metodologia</a>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="5-Arquitetura da Solução.md"> Arquitetura da Solução</a>

# Programação de Funcionalidades

As Funcionalidades produzidas até o momento **(ETAPA 4 - 09/06/2024)** foram:


|ID    | Descrição do Requisito  | Artefato(s) produzido(s) |
|------|-----------------------------------------|----|
|RF-001| A aplicação deve ser capaz de realizar o cadastro e atualização de usuários | [Usuário - Index.cshtml](url) |
|RF-002| A aplicação deve permitir que o usuário cadastre e atualize pedidos | [Pedido Index.cshtml](url)|
|RF-003| A aplicação deve permitir que o usuário realize o cadastro e atualização do estoque de materiais | [Index.cshtml](url) | 
|RF-004| A aplicação deve permitir que o usuário exporte relatório a partir de filtros pré-definidos  | Desenvolvendo |
|RF-005| A aplicação deve permitir que o usuário visualize um pedido em andamento ou finalizado | [Index.cshtml](url)
|RF-006|A aplicação deve permitir armazenamento de notas fiscais | Desenvolvendo |
|RF-007| A aplicação deve permitir que o usuário realize login |[ Index.cshtml](url)|


# Instruções de acesso

Site para visualização do que está sendo produzido até então:


(http://joaoantunes-001-site1.jtempurl.com/)


Cada tipo de usuário terá a sua própria visualização dentro do site, sendo os tipos criados até o momento:

- Administrador 
- Montador
- Cliente

> Tela de Login:
> ![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/PMV-ADS-2024-1-E2-IntApp-Proj-T3-Grupo2-Padrin.ly/assets/110932147/1d8e2619-9608-4d33-859d-dc682e3d3530)


Nota: para cada usuário, a fim de testarmos as funcionalidades em desenvolvimento, criamos perfis fictícios, descritos abaixo.

### Visão do administrador:

Permite ver, editar e excluir Usuários e Produtos:


login: admin@admin.com <br>
senha: admin <br>

>Tela inicial

<img width="964" alt="image" src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t3-grupo01/assets/109355915/6a0c23f3-c5ec-4338-a99e-c163f7681900">


> Tela de usuários
> <img width="955" alt="image" src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t3-grupo01/assets/109355915/0c134fe8-4e13-4b27-95fb-a0c77547832b">

> Tela de Produtos

> <img width="950" alt="image" src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t3-grupo01/assets/109355915/3b9698b2-789a-4223-bba4-44c7b0eefa5b">





#### Visão do Montador:

Permite ver e editar pedidos:


login: 	mont@mont.com.br <br>
senha: montador <br>
("M" maiúsculo)

> Tela inicial
> <img width="953" alt="image" src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t3-grupo01/assets/109355915/8002e0e7-929e-4e4b-bdb0-411ac7953989">

> Tela de Estoque
> <img width="937" alt="image" src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t3-grupo01/assets/109355915/1c1a48fd-5443-41f4-8d03-f60053902b49">

>Tela de Pedidos 
> <img width="958" alt="image" src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t3-grupo01/assets/109355915/b478e9fd-5d99-49a1-bf0b-51f255c9c297">




### Visão do Cliente:


Os perfis dos clientes serão criados pelo administrador da aplicação. O cliente consegue adicionar pedidos e extrair relatórios.


Também há um perfil fictício para teste:

login: cliente1@cli.com.br <br>
senha: cli <br>

> Tela inicial
> <img width="966" alt="image" src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t3-grupo01/assets/109355915/f1ba186f-03d1-421e-b2ea-adf7d05909dc">

> Tela de pedidos
<img width="951" alt="image" src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t3-grupo01/assets/109355915/6bc39267-e0d3-48f1-8fd2-bf2628a25a0e">

