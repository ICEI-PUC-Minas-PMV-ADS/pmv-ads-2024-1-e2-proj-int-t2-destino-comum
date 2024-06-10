# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Abaixo, estão apresentados os cenários de testes utilizados associados aos requisitos funcionais (RF) correspondentes na realização dos testes da atual aplicação.


| **Caso de Teste** 	| **01 – Buscar cidade** |
|-----------------------|-------------------------------------------------------------------------------------------------------------------------|
| Requisito Associado 	| - RF-001 - A aplicação deve apresentar, na página principal, a funcionalidade de pesquisa de cidades e receber informações das cidades. |
| Objetivo do Teste 	| - Verificar se o sistema retornar as devídas informações da cidade. |
| Passos 	            | - Acessar o navegador <br> - Informar o endereço do site l<br> - Clicar em "Pesquisar" <br> - informar o nome da cidade <br> clicar em "Buscar" |
| Critério de Êxito     | - Exibir informações da cidade para o usuario. |


| **Caso de Teste** 	| **02 – Cadastrar perfil** |
|-----------------------|-------------------------------------------------------------------------------------------------------------------------|
| Requisito Associado 	| - RF-002 - A aplicação deve apresentar, na página principal, a funcionalidade de cadastro de usuários comuns, ou com perfil de administrador, para que esses consigam criar e gerenciar seu perfil. |
| Objetivo do Teste 	| - Verificar se o usuário consegue se cadastrar na aplicação. |
| Passos 	            | - Acessar o navegador <br> - Informar o endereço do site l<br> - Clicar em "Criar conta" <br> - Preencher os campos obrigatórios com suas informações <br> - <br> - Clicar em "Registrar" |
| Critério de Êxito     | - O cadastro foi realizado com sucesso e salvo no banco de dados. |


| **Caso de Teste** 	| **03 – Efetuar login** |
|-----------------------|-------------------------------------------------------------------------------------------------------------------------|
| Requisito Associado   | - RF-003 - A aplicação permitirá: usuário a realizar login e logout |
| Objetivo do Teste 	| - Verificar se o usuário consegue realizar login. |
| Passos 	            | - Acessar o site da aplicação <br> - Clicar no botão "Login" <br> - Preencher o campo de e-mail <br> - Preencher o campo da senha <br> - Clicar em "Login" |
| Critério de Êxito     | - O login foi realizado com sucesso. |


| **Caso de Teste** 	| **04 – Efetuar logout** |
|-----------------------|-------------------------------------------------------------------------------------------------------------------------|
| Requisito Associado   | - RF-003 -  A aplicação permitirá: usuário a realizar login e logout                                                    |
| Objetivo do Teste 	| - Verificar se o usuário consegue realizar logout.                                                                        |
| Passos 	            | - Uma vez logado no sistema, o usuário deve clicar em "sair"                                                              |
| Critério de Êxito     | - O logout foi realizado com sucesso.                                                                                   |


| **Caso de Teste Admin** 	| **05 – Excluir Usúario** |
|-----------------------|-------------------------------------------------------------------------------------------------------------------------|
| Requisito Associado   | - RF-010 - A aplicação deve possibitar a opção de excluir usúario.                                                      |
| Objetivo do Teste 	| - Verificar se o usúario de Admin é capaz de excluir usúarios.                                                            |
| Passos 	            | - Acessar o site da aplicação <br> - Clicar em "Login" <br> - Realizar login inserindo email e senha de administrador <br> - Buscar o nome do usuário <br> - Clicar em "Excluir usúario".                                                                                               |
| Critério de Êxito     | - Usúario exclúido.                                                                                                     |

| **Caso de Teste Admin** 	| **06 – Criar, Editar e Excluir as Cidades** |
|-----------------------|-------------------------------------------------------------------------------------------------------------------------|
| Requisito Associado   | - RF-012 - A aplicação deve permitir que o administrador crie, edite e exclua as cidades. |
| Objetivo do Teste 	| - Verificar se o usúario Admin é capaz de criar, editar e excluir as cidades. |
| Passos 	            | - Acessar o site da aplicação <br> - Clicar em "Login" <br> - Realizar login de Administrador inserindo email e senha <br> -Clicar em "Cidades" <br> - Procurar pela cidade <br> - Clicar em "Cadastrar Cidade", "Editar Cidade" , "Detalhes" ou "Escluir Cidades" conforme o que o administrador deseja realizar. <br> - Selecionar a opção "Editar/Cadastrar/Escluir Cidade"|
| Critério de Êxito     | - Cidade editada/cadastrada/excluída com sucesso. |


| **Caso de Teste Admin** 	| **07 – Ativar ou Inativar Usúario** |
|-----------------------|-------------------------------------------------------------------------------------------------------------------------|
| Requisito Associado   | - RF-015 - A aplicação deve possibitar a opção de ativar ou inativar o usúario temporariamente. |
| Objetivo do Teste 	| - Verificar se o usúario Admin é capaz de ativar ou inativar os usúarios. |
| Passos 	            | - Acessar o site da aplicação <br> - Clicar em "Login" <br> - Clicar em "Admin" <br> - Realizar login de Administrador inserindo email e senha <br> - Clicar em "Clientes" <br> - Procurar pelo nome do usuário <br> - Clicar em "Detalhes". <br> - Selecionar a opção "Ativar/Inativar Usuário"|
| Critério de Êxito     | - Usúario ativado/inativado com sucesso. |


