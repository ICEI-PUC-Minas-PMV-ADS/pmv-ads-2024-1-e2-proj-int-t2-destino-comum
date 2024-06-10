# Registro de Testes de Software

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>, <a href="8-Plano de Testes de Software.md"> Plano de Testes de Software</a>

Para cada caso de teste definido no Plano de Testes de Software, realize o registro das evidências dos testes feitos na aplicação pela equipe, que comprovem que o critério de êxito foi alcançado (ou não!!!). Para isso, utilize uma ferramenta de captura de tela que mostre cada um dos casos de teste definidos (obs.: cada caso de teste deverá possuir um vídeo do tipo _screencast_ para caracterizar uma evidência do referido caso).

| **Caso de Teste** 	| **CT-01 – Buscar Cidade** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-001 - A aplicação deve apresentar, na página principal, a funcionalidade de pesquisa de cidades e receber informações das cidades. |
|Registro de evidência | https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t2-destino-comum/assets/144973239/6c319021-f7b2-4657-a352-3248d258662c |


| **Caso de Teste** 	| **CT-02 – Cadastrar perfil** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-002 - A aplicação deve apresentar, na página principal, a funcionalidade de cadastro de usuários para que esses consigam criar e gerenciar seu perfil. |
|Registro de evidência | Cadastro Usuário Comum (https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t2-destino-comum/assets/144973239/0c46a58f-b4b0-4f49-9563-021a7ead50e0) |


| **Caso de Teste** 	| **CT-03 – Tipos de perfil** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-016 - A aplicação deve conter perfis de gestor (administrador) e cliente (usuário comum). |
|Registro de evidência | Perfil Administrador vs Usuário Comum: https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t2-destino-comum/assets/145787867/6b3ef409-b886-4648-b38b-bce2afe17a75 |


| **Caso de Teste** 	| **CT-04 – Realizar login e logout** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-003 - A aplicação permitirá o usuário a realizar login e logout |
|Registro de evidência |https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t2-destino-comum/assets/145787867/65678416-4661-4289-a73c-76d372023eae|

| **Caso de Teste** 	| **CT-05 – O administrador poderá consultar os usuários cadastrados e poderá excluí-los** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-010 - A aplicação deve permitir que o administrador consulte quais usuários estão cadastrados e permitirá excluí-los |
|Registro de evidência | - Consultar usuários cadastrados: https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t2-destino-comum/assets/145787867/5e9277c9-ef92-40d5-b133-046e7a7e50e1 <br> - Exportar dados dos administradores: https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t2-destino-comum/assets/145787867/888e4efc-0513-4b77-975b-e33e588acfb7 <br> - Exportar dados dos usuários comuns: https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t2-destino-comum/assets/145787867/24ced66c-89ec-45fe-a8e8-13aa2e98f3a1



| **Caso de Teste** 	| **CT-06 – O administrador poderá ativar ou inativar o acesso de usuários cadastrados** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-015 - A aplicação deve permitir que o administrador ative ou inative o acesso de usuários cadastrados |
|Registro de evidência | https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t2-destino-comum/assets/145787867/80b2b0b0-12de-4b61-ab0b-7b16d6b98da0 <br> - Excluir usuários: FALTA IMPLEMENTAR|


| **Caso de Teste** 	| **CT-07 – O administrador poderá criar, editar, excluir e ver detalhes das cidades** 	|
|:---:	|:---:	|
|	Requisito Associado 	| RF-012 - A aplicação deve permitir que o administrador crie, edite e exclua as cidades |
|Registro de evidência | - Criar cidade: https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t2-destino-comum/assets/145787867/ff77f8be-c16c-4b61-ab15-5b39ffed735e <br> - Editar cidade: https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t2-destino-comum/assets/145787867/44654e23-f87e-4990-bcef-d71776abae20 <br> - Detalhes da cidade: https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t2-destino-comum/assets/145787867/47056eca-e44f-48c1-8bb1-0ef59db20ff5 <br> Exportar dados da cidade: https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t2-destino-comum/assets/145787867/07b86686-9995-4c2d-b9d4-0a88f29907cb <br> Excluir cidade: FALTA IMPLEMENTAR|


## Avaliação

Todas as funções implementadas até o presente momento encontram-se funcionais. Ainda há a necessidade de implementar as seguintes funcionalidades: (i) Administrador excluir cidade; (ii) Administrador excluir usuário. 

O cadastro de usuários está funcionando somente com o perfil logado. Caso o cliente ainda não seja usuário cadastrado, está havendo uma inconsistência no cadastro. Isso será averiguado nos próximos dias. Ademais, seguindo o planejamento inicial, há que se implementar diversas funcionalidades, tais como: possibilidade de o usuário favoritar cidades; possibilidade de o usuário comentar na aba das cidades entre outros. Deve-se avaliar se haverá tempo para a conclusão dessas funcionalidades.

> **Links Úteis**:
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
