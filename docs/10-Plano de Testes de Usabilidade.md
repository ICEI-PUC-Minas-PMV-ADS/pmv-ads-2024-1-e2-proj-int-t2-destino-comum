# Plano de Testes de Usabilidade

Um plano de teste de usabilidade foi elaborado para a detecção de eventuais problemas e aprimorar a experiência do usuário na presente aplicação. A seguir, apresentamos um exemplo prático deste plano.

## Objetivo do Teste de Usabilidade:
O objetivo principal deste teste de usabilidade é avaliar a facilidade de uso e a eficácia do processo de execução das tarefas associadas aos casos de uso propostos na aplicação. Dessa forma, para conduzir essa avaliação foi adotado o "plano de testes" como roteiro e utilizado o método de observação direta para medição das variáveis previamente estabelecidas.

### Variáveis para Análise:

- Navegabilidade: A facilidade com que os usuários podem transitar entre diferentes funcionalidades na plataforma.
- Compreensão da Interface: A habilidade dos usuários em entender e utilizar a interface da plataforma.
- Eficiência Temporal: O tempo necessário para realizar uma tarefa específica.
- Efetividade das Tarefas: A capacidade dos usuários de completar as tarefas com sucesso.

### Critérios de Avaliação:

- Índice de Êxito: A proporção de tarefas concluídas com sucesso pelos usuários.
- Duração Média: O tempo médio requerido pelos usuários para finalizar uma tarefa.
- Quantidade de Erros: A frequência de erros feitos pelos usuários durante o teste.
- Contentamento do Usuário: O grau de satisfação dos usuários, medido através da observação de suas interações e feedback direto após a realização das tarefas.

### Abordagem Metodológica:

- Introdução ao Cenário: apresentar aos participantes o contexto detalhado da tarefa conforme descrito no documento de teste. Instruir os participantes a seguirem as etapas delineadas.
- Monitoramento do Tempo e Dificuldades: documentar o tempo gasto pelos participantes em cada tarefa, bem como quaisquer obstáculos que eles enfrentem.
- Contagem de Interações e Erros: anotar a quantidade de vezes que os participantes interagem com a tarefa e registrar quaisquer equívocos cometidos durante o processo.
- Feedback Pós-Tarefa: solicitar que os participantes forneçam feedback após completarem a tarefa, com foco em apontar partes da interface que acharam intuitivas ou confusas.
- Análise de Usabilidade: examinar as informações coletadas para detectar pontos que necessitam de aprimoramento na usabilidade da plataforma.

                                                           
| RTU 1 - Realizar cadastro de Usuário |
|-------------------------------------|
| **Usuário:**                   Todos |
| **Objetivo do teste:**         Examinar a forma como o usuário utiliza a tela de cadastro |
| **Ações essenciais:**          |
| 1. Acessar a tela home do site pelo navegador; |
| 2. Clicar em “Cadastre-se”; |
| 3. Preencher o formulário com as informações solicitadas nos campos; |
| 4. Clicar em “Cadastrar”. |

| RTU 2 - Realizar Login |
|-------------------------------------|
| **Usuário:**                   Todos |
| **Objetivo do teste:**         Examinar a forma como o usuário realiza o login |
| **Ações essenciais:**          |
| 1. Acessar a tela home do site pelo navegador; |
| 2. Clicar em “Login”; |
| 3. Preencher e-mail cadastrado no campo indicado; |
| 4. Preencher a senha no campo indicado; |
| 5. Clicar em "Entrar". |

| RTU 3 - Cadastrar Cidade |
|-------------------------------------|
| **Usuário:**                   Todos |
| **Objetivo do teste:**         Examinar a forma como o usuário utiliza a tela de cadastrar cidade |
| **Ações essenciais:**          |
| 1. Acessar a tela home do site pelo navegador; |
| 2. Clicar em “Login”; |
| 3. Preencher e-mail e senha de perfil "Administrador"|
| 4. Uma vez logado como perfil de administrador na tela home, clicar em "Painel Administrativo > Cidades"; |
| 5. Clicar em "Cadastrar Cidade"; |
| 6. Preencher o formulário com as informações solicitadas nos campos; |
| 7. Clicar em "Cadastrar". |

| RTU 4 - Gerenciar Cidades Cadastradas |
|-------------------------------------|
| **Usuário:**                   Todos |
| **Objetivo do teste:**         Examinar a forma como o usuário utiliza a tela "Lista de Cidades" |
| **Ações essenciais:**          |
| 1. Acessar a tela home do site pelo navegador; |
| 2. Clicar em “Login”; |
| 3. Preencher e-mail e senha de perfil "Administrador"|
| 4. Uma vez logado como perfil de administrador na tela home, clicar em "Painel Administrativo > Cidades"; |
| 5. Visualizar as cidades e identificar as opções de editar, detalhes, e excluir; |

| RTU 5 - Gerenciar Usuários Cadastrados |
|-------------------------------------|
| **Usuário:**                   Todos |
| **Objetivo do teste:**         Examinar a forma como o usuário utiliza a tela "Lista de Usuários" |
| **Ações essenciais:**          |
| 1. Acessar a tela home do site pelo navegador; |
| 2. Clicar em “Login”; |
| 3. Preencher e-mail e senha de perfil "Administrador"|
| 4. Uma vez logado como perfil de administrador na tela home, clicar em "Painel Administrativo > Clientes"; |
| 5. Visualizar os usuários e identificar as opções "detalhes" e "editar"; |

| RTU 6 - Gerenciar Usuários Cadastrados (Ativar ou inativar Usúario)|
|-------------------------------------|
| **Usuário:**                   Todos |
| **Objetivo do teste:**         Examinar a forma como o usuário utiliza a função "ativar/inativar" usuário |
| **Ações essenciais:**          |
| 1. Acessar a tela home do site pelo navegador; |
| 2. Clicar em “Login”; |
| 3. Preencher e-mail e senha de perfil "Administrador"|
| 4. Uma vez logado como perfil de administrador na tela home, clicar em "Painel Administrativo > Clientes"; |
| 5. Visualizar os usuários e clicar na opção "detalhes" |
| 6. Encontrar o usuário e clicar em "ativar usuário" se ele estiver inativo ou clicar em "inativar usuário" se ele estiver ativo |

| RTU 7 - Gerenciar Administradores Cadastrados |
|-------------------------------------|
| **Usuário:**                   Todos |
| **Objetivo do teste:**         Examinar a forma como o usuário utiliza a tela "Cadastro de Funcionários" |
| **Ações essenciais:**          |
| 1. Acessar a tela home do site pelo navegador; |
| 2. Clicar em “Login”; |
| 3. Preencher e-mail e senha de perfil "Administrador"|
| 4. Uma vez logado como perfil de administrador na tela home, clicar em "Painel Administrativo > Administradores"; |
| 5. Visualizar os usuários-administradores e identificar as opções "detalhes" e "editar"; |

| RTU 8 - Gerar relatórios sobre cidades, funcionários e usuários |
|-------------------------------------|
| **Usuário:**                   Todos |
| **Objetivo do teste:**         Examinar a forma como o usuário utiliza a tela "Relatórios" |
| **Ações essenciais:**          |
| 1. Acessar a tela home do site pelo navegador; |
| 2. Clicar em “Login”; |
| 3. Preencher e-mail e senha de perfil "Administrador"|
| 4. Uma vez logado como perfil de administrador na tela home, clicar em "Painel Administrativo > Relatórios"; |
| 5. Visualizar os tipos de relatórios ("Cidades", "Clientes", "Funcionários") e clicar na opção desejada para baixar o relatório em formato ".xls" |
| 6. Abrir o arquivo baixado e visualizar as informações desejadas|

| RTU 9 - Buscar cidades por meio de filtro de pesquisa |
|-------------------------------------|
| **Usuário:**                   Todos |
| **Objetivo do teste:**         Examinar a forma como o usuário utiliza a tela "Cidades" |
| **Ações essenciais:**          |
| 1. Acessar a tela home do site pelo navegador; |
| 2. Clicar em “Login”; |
| 3. Preencher e-mail e senha de perfil "Administrador"|
| 4. Uma vez logado como perfil de administrador na tela home, clicar em "Painel Administrativo > Cidades"; |
| 5. Buscar a cidade utilizando o filtro de pesquisa |
