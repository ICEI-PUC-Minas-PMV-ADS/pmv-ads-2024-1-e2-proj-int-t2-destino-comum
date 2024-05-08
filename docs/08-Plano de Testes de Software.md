# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.

Não deixe de enumerar os casos de teste de forma sequencial e de garantir que o(s) requisito(s) associado(s) a cada um deles está(ão) correto(s) - de acordo com o que foi definido na seção "2 - Especificação do Projeto". 

Por exemplo:


| **Caso de Teste** 	| **01 – Buscar cidade** |
|-----------------------|-------------------------------------------------------------------------------------------------------------------------|
| Requisito Associado 	| - RF-001 - A aplicação deve apresentar, na página principal, a funcionalidade de pesquisa de cidades e receber informações das cidades. |
| Objetivo do Teste 	| - Verificar se o sistema retornar as devídas informações da cidade. |
| Passos 	            | - Acessar o navegador <br> - Informar o endereço do site l<br> - Clicar em "Pesquisar" <br> - informar o nome da cidade <br> clicar em "Buscar" |
| Critério de Êxito     | - Exibir informações da cidade para o usuario. |
|   |    |
| **Caso de Teste** 	| **02 – Cadastrar perfil** |
| Requisito Associado 	| - RF-002 - A aplicação deve apresentar, na página principal, a funcionalidade de cadastro de usuários para que esses consigam criar e gerenciar seu perfil. |
| Objetivo do Teste 	| - Verificar se o usuário consegue se cadastrar na aplicação. |
| Passos 	            | - Acessar o navegador <br> - Informar o endereço do site l<br> - Clicar em "Criar conta" <br> - Preencher os campos obrigatórios com suas informações <br> - <br> - Clicar em "Registrar" |
| Critério de Êxito     | - O cadastro foi realizado com sucesso e salvo no banco de dados. |
|   |    |
| **Caso de Teste** 	| **03 – Efetuar login logout** |
| Requisito Associado   | - RF-003 - A aplicação permitirá: usuário a realizar login e logout |
| Objetivo do Teste 	| - Verificar se o usuário consegue realizar login. |
| Passos 	            | - Acessar o site da aplicação <br> - Clicar no botão "Login" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" |
| Critério de Êxito     | - O login foi realizado com sucesso. |
|   |    |
| **Caso de Teste** 	| **03 – Efetuar logout** |
| Requisito Associado   | - RF-003 -  A aplicação permitirá: usuário a realizar login e logout |
| Objetivo do Teste 	| - Verificar se o usuário consegue realizar logout. |
| Passos 	            | - Uma vez logado no sistema, o usuário deve clicar em "sair" |
| Critério de Êxito     | - O logout foi realizado com sucesso. |
|   |    |
| **Caso de Teste** 	| **04 – Escrever comentário** |
| Requisito Associado   | - RF-004 - A aplicação deve apresentar a opção de escrever comemtários nas cidades procuradas. |
| Objetivo do Teste 	| - Verificar se o usuário é capaz de deixa um comentário visível na página procurada. |
| Passos 	            | - Acessar o site da aplicação <br> - Clicar no botão "Pesquisar" <br> - Digitar o mnome de uma cidade <br> - Clicar em "Buscar" <br> - Clicar na opção "Escrever comentário" <br> - Escrever o seu cometário <br> - Clicar em confirmar. |
| Critério de Êxito     | - Vizualizar seu comentário na página selecionada. |
|   |    |
| **Caso de Teste** 	| **05 – Curtir cidade** |
| Requisito Associado   | - RF-005 - A aplicação deve possibitar a opção de curtir comentários. |
| Objetivo do Teste 	| - Verificar se o usúario é capaz de curtir comentário. |
| Passos 	            | - Acessar o site da aplicação <br> - Digitar o nome de uma cidade no botão "Pesquisar" <br> - Clicar em "Buscar" <br> - Selecionar botão curtir ao lado de algum comentário |
| Critério de Êxito     | - Incrementar o contador em 1 do comentário. |
|   |    |
| **Caso de Teste** 	| **06 – favoritar cidade** |
| Requisito Associado   | - RF-007 - A aplicação deve possibitar a opção de curtir comentários. |
| Objetivo do Teste 	| - Verificar se o usúario é capaz de curtir comentário. |
| Passos 	            | - Acessar o site da aplicação <br> - Digitar o nome de uma cidade no botão "Pesquisar" <br> - Clicar em "Buscar" <br> - Selecionar botão "favoritar" no site da cidade |
| Critério de Êxito     | - Cidade adicionada na sua lista de favoritos. |
|   |    |
| **Caso de Teste** 	| **07 – reportar Comentário** |
| Requisito Associado   | - RF-008 - A aplicação deve possibitar a opção de reportar usúario. |
| Objetivo do Teste 	| - Verificar se o usúario é capaz de reportar usúarios. |
| Passos 	            | - Acessar o site da aplicação <br> - Digitar o nome de uma cidade no botão "Pesquisar" <br> - Clicar em "Buscar" <br> - Selecionar a opção "Reportar usúario" ao lado do comentário do usúario. |
| Critério de Êxito     | - Comentário reportado. |
|   |    |
| **Caso de Teste Admin** 	| **08 – excluir Usúario** |
| Requisito Associado   | - RF-010 - A aplicação deve possibitar a opção de excluir usúario. |
| Objetivo do Teste 	| - Verificar se o usúario de Admin é capaz de excluir usúarios. |
| Passos 	            | - Acessar o site da aplicação <br> - Clicar em "Login" <br> - Realizar login inserindo email e senha de administrador <br> - Buscar o nome do usuário <br> - Clicar em "Excluir usúario". |
| Critério de Êxito     | - Usúario exclúido. |
|   |    |
| **Caso de Teste Admin** 	| **09 – excluir Comentário** |
| Requisito Associado   | - RF-011 - A aplicação deve possibitar a opção de excluir comentarios. |
| Objetivo do Teste 	| - Verificar se o usúario de Admin é capaz de excluir usúarios. |
| Passos 	            | - Acessar o site da aplicação <br> - Clicar em "Login" <br> - Clicar em "Admin" <br> - Realizar login inserindo email e senha <br> -Clicar em "Buscar" <br> - Digitar o nome da cidade <br> - Clicar em "Excluir comentário". |
| Critério de Êxito     | - Comentario exclúido. |
|   |    |
| **Caso de Teste Admin** 	| **10 – ativar ou inativar Usúario** |
| Requisito Associado   | - RF-015 - A aplicação deve possibitar a opção de ativar ou inativar o usúario temporariamente. |
| Objetivo do Teste 	| - Verificar se o usúario Admin é capaz de ativar ou inativar os usúarios. |
| Passos 	            | - Acessar o site da aplicação <br> - Clicar em "Login" <br> - Clicar em "Admin" <br> - Realizar login de Administrador inserindo email e senha <br> - Clicar em "Clientes" <br> - Procurar pelo nome do usuário <br> - Clicar em "Detalhes". <br> - Selecionar a opção "Ativar/Inativar Usuário"|
| Critério de Êxito     | - Usúario ativado/inativado com sucesso. |
|   |    |
| **Caso de Teste Admin** 	| **11 – criar, editar e excluir as cidades** |
| Requisito Associado   | - RF-012 - A aplicação deve permitir que o administrador crie, edite e exclua as cidades. |
| Objetivo do Teste 	| - Verificar se o usúario Admin é capaz de criar, editar e excluir as cidades. |
| Passos 	            | - Acessar o site da aplicação <br> - Clicar em "Login" <br> - Realizar login de Administrador inserindo email e senha <br> -Clicar em "Cidades" <br> - Procurar pela cidade <br> - Clicar em "Cadastrar Cidade", "Editar Cidade" , "Detalhes" ou "Escluir Cidades" conforme o que o administrador deseja realizar. <br> - Selecionar a opção "Editar/Cadastrar/Escluir Cidade"|
| Critério de Êxito     | - Cidade editada/cadastrada/excluída com sucesso. |


> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
