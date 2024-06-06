![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t2-destino-comum/assets/145787867/91eb90ff-88ff-4d0f-8af5-11e6593a51db)# Plano de Testes de Usabilidade

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

| RTU 8 - Buscar cidades por meio de filtro de pesquisa |
|-------------------------------------|
| **Usuário:**                   Todos |
| **Objetivo do teste:**         Examinar a forma como o usuário utiliza a tela "Cidades" |
| **Ações essenciais:**          |
| 1. Acessar a tela home do site pelo navegador; |
| 2. Clicar em “Login”; |
| 3. Preencher e-mail e senha de perfil "Administrador"|
| 4. Uma vez logado como perfil de administrador na tela home, clicar em "Painel Administrativo > Cidades"; |
| 5. Buscar a cidade utilizando o filtro de pesquisa |





| Tarefas                                             | Facilidade de Uso (1-5) | Feedback Detalhado                                                                                        | Tempo (min) | Cliques | Número de Erros |
|----------------------------------------------------|-------------------------|------------------------------------------------------------------------------------------------------------|-------------|---------|-----------------|
| Criar nova conta de usuário na aplicação          | Usuário vai dar uma nota de (1 a 5) para a facilidade da tarefa 1 | Feedback detalhado do usuário sobre a tarefa 1 | Minutagem do usuário para finalizar a tarefa 1 | Contando quantos cliques o usuário precisou para concluir a tarefa 1 | Usuário irá informar quantos erros teve ao realizar a tarefa 1 |
| Realizar o login na aplicação                     | Usuário vai dar uma nota de (1 a 5) para a facilidade da tarefa 2 | Feedback detalhado do usuário sobre a tarefa 2 | Minutagem do usuário para finalizar a tarefa 2 | Contando quantos cliques o usuário precisou para concluir a tarefa 2 | Usuário irá informar quantos erros teve ao realizar a tarefa 2 |
| Pesquisar por cidades de interesse na aplicação   | Usuário vai dar uma nota de (1 a 5) para a facilidade da tarefa 3 | Feedback detalhado do usuário sobre a tarefa 3 | Minutagem do usuário para finalizar a tarefa 3 | Contando quantos cliques o usuário precisou para concluir a tarefa 3 | Usuário irá informar quantos erros teve ao realizar a tarefa 3 |
| Escrever e editar perguntas ou dicas             | Usuário vai dar uma nota de (1 a 5) para a facilidade da tarefa 4 | Feedback detalhado do usuário sobre a tarefa 4 | Minutagem do usuário para finalizar a tarefa 4 | Contando quantos cliques o usuário precisou para concluir a tarefa 4 | Usuário irá informar quantos erros teve ao realizar a tarefa 4 |
| Votar em perguntas ou dicas favoritas            | Usuário vai dar uma nota de (1 a 5) para a facilidade da tarefa 5 | Feedback detalhado do usuário sobre a tarefa 5 | Minutagem do usuário para finalizar a tarefa 5 | Contando quantos cliques o usuário precisou para concluir a tarefa 5 | Usuário irá informar quantos erros teve ao realizar a tarefa 5 |
| Definir destinos favoritos            | Usuário vai dar uma nota de (1 a 5) para a facilidade da tarefa 6 | Feedback detalhado do usuário sobre a tarefa 6 | Minutagem do usuário para finalizar a tarefa 6 | Contando quantos cliques o usuário precisou para concluir a tarefa 6 | Usuário irá informar quantos erros teve ao realizar a tarefa 6 |
| Reportar comentários impróprios             | Usuário vai dar uma nota de (1 a 5) para a facilidade da tarefa 7 | Feedback detalhado do usuário sobre a tarefa 7 | Minutagem do usuário para finalizar a tarefa 7 | Contando quantos cliques o usuário precisou para concluir a tarefa 7 | Usuário irá informar quantos erros teve ao realizar a tarefa 7 |
| Receber notificações            | Usuário vai dar uma nota de (1 a 5) para a facilidade da tarefa 8 | Feedback detalhado do usuário sobre a tarefa 8 | Minutagem do usuário para finalizar a tarefa 8 | Contando quantos cliques o usuário precisou para concluir a tarefa 8 | Usuário irá informar quantos erros teve ao realizar a tarefa 8 |


| Relatório do Teste de Usabilidade do usuário 2|
|-----------------------------------|
| **Projeto:**   Destino Comum                   |
| **Fase:**            1             |
| **Data:**        00/00/0000                 |
| **Moderador:**  Gabriel Oliveira   |
| **Usuário:**       |
| **Quantidade de Tarefas:** 8|
| **Remoto ou Presencial:** |



| Tarefas                                             | Facilidade de Uso (1-5) | Feedback Detalhado                                                                                        | Tempo (min) | Cliques | Número de Erros |
|----------------------------------------------------|-------------------------|------------------------------------------------------------------------------------------------------------|-------------|---------|-----------------|
| Criar nova conta de usuário na aplicação          | Usuário vai dar uma nota de (1 a 5) para a facilidade da tarefa 1 | Feedback detalhado do usuário sobre a tarefa 1 | Minutagem do usuário para finalizar a tarefa 1 | Contando quantos cliques o usuário precisou para concluir a tarefa 1 | Usuário irá informar quantos erros teve ao realizar a tarefa 1 |
| Realizar o login na aplicação                     | Usuário vai dar uma nota de (1 a 5) para a facilidade da tarefa 2 | Feedback detalhado do usuário sobre a tarefa 2 | Minutagem do usuário para finalizar a tarefa 2 | Contando quantos cliques o usuário precisou para concluir a tarefa 2 | Usuário irá informar quantos erros teve ao realizar a tarefa 2 |
| Pesquisar por cidades de interesse na aplicação   | Usuário vai dar uma nota de (1 a 5) para a facilidade da tarefa 3 | Feedback detalhado do usuário sobre a tarefa 3 | Minutagem do usuário para finalizar a tarefa 3 | Contando quantos cliques o usuário precisou para concluir a tarefa 3 | Usuário irá informar quantos erros teve ao realizar a tarefa 3 |
| Escrever e editar perguntas ou dicas             | Usuário vai dar uma nota de (1 a 5) para a facilidade da tarefa 4 | Feedback detalhado do usuário sobre a tarefa 4 | Minutagem do usuário para finalizar a tarefa 4 | Contando quantos cliques o usuário precisou para concluir a tarefa 4 | Usuário irá informar quantos erros teve ao realizar a tarefa 4 |
| Votar em perguntas ou dicas favoritas            | Usuário vai dar uma nota de (1 a 5) para a facilidade da tarefa 5 | Feedback detalhado do usuário sobre a tarefa 5 | Minutagem do usuário para finalizar a tarefa 5 | Contando quantos cliques o usuário precisou para concluir a tarefa 5 | Usuário irá informar quantos erros teve ao realizar a tarefa 5 |
| Definir destinos favoritos            | Usuário vai dar uma nota de (1 a 5) para a facilidade da tarefa 6 | Feedback detalhado do usuário sobre a tarefa 6 | Minutagem do usuário para finalizar a tarefa 6 | Contando quantos cliques o usuário precisou para concluir a tarefa 6 | Usuário irá informar quantos erros teve ao realizar a tarefa 6 |
| Reportar comentários impróprios             | Usuário vai dar uma nota de (1 a 5) para a facilidade da tarefa 7 | Feedback detalhado do usuário sobre a tarefa 7 | Minutagem do usuário para finalizar a tarefa 7 | Contando quantos cliques o usuário precisou para concluir a tarefa 7 | Usuário irá informar quantos erros teve ao realizar a tarefa 7 |
| Receber notificações            | Usuário vai dar uma nota de (1 a 5) para a facilidade da tarefa 8 | Feedback detalhado do usuário sobre a tarefa 8 | Minutagem do usuário para finalizar a tarefa 8 | Contando quantos cliques o usuário precisou para concluir a tarefa 8 | Usuário irá informar quantos erros teve ao realizar a tarefa 8 |


| Relatório do Teste de Usabilidade do usuário 3|
|-----------------------------------|
| **Projeto:**   Destino Comum                   |
| **Fase:**            1             |
| **Data:**        00/00/0000                 |
| **Moderador:**  Gabriel Oliveira   |
| **Usuário:**       |
| **Quantidade de Tarefas:** 8|
| **Remoto ou Presencial:** |



| Tarefas                                             | Facilidade de Uso (1-5) | Feedback Detalhado                                                                                        | Tempo (min) | Cliques | Número de Erros |
|----------------------------------------------------|-------------------------|------------------------------------------------------------------------------------------------------------|-------------|---------|-----------------|
| Criar nova conta de usuário na aplicação          | Usuário vai dar uma nota de (1 a 5) para a facilidade da tarefa 1 | Feedback detalhado do usuário sobre a tarefa 1 | Minutagem do usuário para finalizar a tarefa 1 | Contando quantos cliques o usuário precisou para concluir a tarefa 1 | Usuário irá informar quantos erros teve ao realizar a tarefa 1 |
| Realizar o login na aplicação                     | Usuário vai dar uma nota de (1 a 5) para a facilidade da tarefa 2 | Feedback detalhado do usuário sobre a tarefa 2 | Minutagem do usuário para finalizar a tarefa 2 | Contando quantos cliques o usuário precisou para concluir a tarefa 2 | Usuário irá informar quantos erros teve ao realizar a tarefa 2 |
| Pesquisar por cidades de interesse na aplicação   | Usuário vai dar uma nota de (1 a 5) para a facilidade da tarefa 3 | Feedback detalhado do usuário sobre a tarefa 3 | Minutagem do usuário para finalizar a tarefa 3 | Contando quantos cliques o usuário precisou para concluir a tarefa 3 | Usuário irá informar quantos erros teve ao realizar a tarefa 3 |
| Escrever e editar perguntas ou dicas             | Usuário vai dar uma nota de (1 a 5) para a facilidade da tarefa 4 | Feedback detalhado do usuário sobre a tarefa 4 | Minutagem do usuário para finalizar a tarefa 4 | Contando quantos cliques o usuário precisou para concluir a tarefa 4 | Usuário irá informar quantos erros teve ao realizar a tarefa 4 |
| Votar em perguntas ou dicas favoritas            | Usuário vai dar uma nota de (1 a 5) para a facilidade da tarefa 5 | Feedback detalhado do usuário sobre a tarefa 5 | Minutagem do usuário para finalizar a tarefa 5 | Contando quantos cliques o usuário precisou para concluir a tarefa 5 | Usuário irá informar quantos erros teve ao realizar a tarefa 5 |
| Definir destinos favoritos            | Usuário vai dar uma nota de (1 a 5) para a facilidade da tarefa 6 | Feedback detalhado do usuário sobre a tarefa 6 | Minutagem do usuário para finalizar a tarefa 6 | Contando quantos cliques o usuário precisou para concluir a tarefa 6 | Usuário irá informar quantos erros teve ao realizar a tarefa 6 |
| Reportar comentários impróprios             | Usuário vai dar uma nota de (1 a 5) para a facilidade da tarefa 7 | Feedback detalhado do usuário sobre a tarefa 7 | Minutagem do usuário para finalizar a tarefa 7 | Contando quantos cliques o usuário precisou para concluir a tarefa 7 | Usuário irá informar quantos erros teve ao realizar a tarefa 7 |
| Receber notificações            | Usuário vai dar uma nota de (1 a 5) para a facilidade da tarefa 8 | Feedback detalhado do usuário sobre a tarefa 8 | Minutagem do usuário para finalizar a tarefa 8 | Contando quantos cliques o usuário precisou para concluir a tarefa 8 | Usuário irá informar quantos erros teve ao realizar a tarefa 8 |


| Relatório do Teste de Usabilidade do usuário 4|
|-----------------------------------|
| **Projeto:**   Destino Comum                   |
| **Fase:**            1             |
| **Data:**        00/00/0000                 |
| **Moderador:**  Gabriel Oliveira   |
| **Usuário:**       |
| **Quantidade de Tarefas:** 8|
| **Remoto ou Presencial:** |



| Tarefas                                             | Facilidade de Uso (1-5) | Feedback Detalhado                                                                                        | Tempo (min) | Cliques | Número de Erros |
|----------------------------------------------------|-------------------------|------------------------------------------------------------------------------------------------------------|-------------|---------|-----------------|
| Criar nova conta de usuário na aplicação          | Usuário vai dar uma nota de (1 a 5) para a facilidade da tarefa 1 | Feedback detalhado do usuário sobre a tarefa 1 | Minutagem do usuário para finalizar a tarefa 1 | Contando quantos cliques o usuário precisou para concluir a tarefa 1 | Usuário irá informar quantos erros teve ao realizar a tarefa 1 |
| Realizar o login na aplicação                     | Usuário vai dar uma nota de (1 a 5) para a facilidade da tarefa 2 | Feedback detalhado do usuário sobre a tarefa 2 | Minutagem do usuário para finalizar a tarefa 2 | Contando quantos cliques o usuário precisou para concluir a tarefa 2 | Usuário irá informar quantos erros teve ao realizar a tarefa 2 |
| Pesquisar por cidades de interesse na aplicação   | Usuário vai dar uma nota de (1 a 5) para a facilidade da tarefa 3 | Feedback detalhado do usuário sobre a tarefa 3 | Minutagem do usuário para finalizar a tarefa 3 | Contando quantos cliques o usuário precisou para concluir a tarefa 3 | Usuário irá informar quantos erros teve ao realizar a tarefa 3 |
| Escrever e editar perguntas ou dicas             | Usuário vai dar uma nota de (1 a 5) para a facilidade da tarefa 4 | Feedback detalhado do usuário sobre a tarefa 4 | Minutagem do usuário para finalizar a tarefa 4 | Contando quantos cliques o usuário precisou para concluir a tarefa 4 | Usuário irá informar quantos erros teve ao realizar a tarefa 4 |
| Votar em perguntas ou dicas favoritas            | Usuário vai dar uma nota de (1 a 5) para a facilidade da tarefa 5 | Feedback detalhado do usuário sobre a tarefa 5 | Minutagem do usuário para finalizar a tarefa 5 | Contando quantos cliques o usuário precisou para concluir a tarefa 5 | Usuário irá informar quantos erros teve ao realizar a tarefa 5 |
| Definir destinos favoritos            | Usuário vai dar uma nota de (1 a 5) para a facilidade da tarefa 6 | Feedback detalhado do usuário sobre a tarefa 6 | Minutagem do usuário para finalizar a tarefa 6 | Contando quantos cliques o usuário precisou para concluir a tarefa 6 | Usuário irá informar quantos erros teve ao realizar a tarefa 6 |
| Reportar comentários impróprios             | Usuário vai dar uma nota de (1 a 5) para a facilidade da tarefa 7 | Feedback detalhado do usuário sobre a tarefa 7 | Minutagem do usuário para finalizar a tarefa 7 | Contando quantos cliques o usuário precisou para concluir a tarefa 7 | Usuário irá informar quantos erros teve ao realizar a tarefa 7 |
| Receber notificações            | Usuário vai dar uma nota de (1 a 5) para a facilidade da tarefa 8 | Feedback detalhado do usuário sobre a tarefa 8 | Minutagem do usuário para finalizar a tarefa 8 | Contando quantos cliques o usuário precisou para concluir a tarefa 8 | Usuário irá informar quantos erros teve ao realizar a tarefa 8 |


| Relatório do Teste de Usabilidade do usuário 5|
|-----------------------------------|
| **Projeto:**   Destino Comum                   |
| **Fase:**            1             |
| **Data:**        00/00/0000                 |
| **Moderador:**  Gabriel Oliveira   |
| **Usuário:**       |
| **Quantidade de Tarefas:** 8|
| **Remoto ou Presencial:** |



| Tarefas                                             | Facilidade de Uso (1-5) | Feedback Detalhado                                                                                        | Tempo (min) | Cliques | Número de Erros |
|----------------------------------------------------|-------------------------|------------------------------------------------------------------------------------------------------------|-------------|---------|-----------------|
| Criar nova conta de usuário na aplicação          | Usuário vai dar uma nota de (1 a 5) para a facilidade da tarefa 1 | Feedback detalhado do usuário sobre a tarefa 1 | Minutagem do usuário para finalizar a tarefa 1 | Contando quantos cliques o usuário precisou para concluir a tarefa 1 | Usuário irá informar quantos erros teve ao realizar a tarefa 1 |
| Realizar o login na aplicação                     | Usuário vai dar uma nota de (1 a 5) para a facilidade da tarefa 2 | Feedback detalhado do usuário sobre a tarefa 2 | Minutagem do usuário para finalizar a tarefa 2 | Contando quantos cliques o usuário precisou para concluir a tarefa 2 | Usuário irá informar quantos erros teve ao realizar a tarefa 2 |
| Pesquisar por cidades de interesse na aplicação   | Usuário vai dar uma nota de (1 a 5) para a facilidade da tarefa 3 | Feedback detalhado do usuário sobre a tarefa 3 | Minutagem do usuário para finalizar a tarefa 3 | Contando quantos cliques o usuário precisou para concluir a tarefa 3 | Usuário irá informar quantos erros teve ao realizar a tarefa 3 |
| Escrever e editar perguntas ou dicas             | Usuário vai dar uma nota de (1 a 5) para a facilidade da tarefa 4 | Feedback detalhado do usuário sobre a tarefa 4 | Minutagem do usuário para finalizar a tarefa 4 | Contando quantos cliques o usuário precisou para concluir a tarefa 4 | Usuário irá informar quantos erros teve ao realizar a tarefa 4 |
| Votar em perguntas ou dicas favoritas            | Usuário vai dar uma nota de (1 a 5) para a facilidade da tarefa 5 | Feedback detalhado do usuário sobre a tarefa 5 | Minutagem do usuário para finalizar a tarefa 5 | Contando quantos cliques o usuário precisou para concluir a tarefa 5 | Usuário irá informar quantos erros teve ao realizar a tarefa 5 |
| Definir destinos favoritos            | Usuário vai dar uma nota de (1 a 5) para a facilidade da tarefa 6 | Feedback detalhado do usuário sobre a tarefa 6 | Minutagem do usuário para finalizar a tarefa 6 | Contando quantos cliques o usuário precisou para concluir a tarefa 6 | Usuário irá informar quantos erros teve ao realizar a tarefa 6 |
| Reportar comentários impróprios             | Usuário vai dar uma nota de (1 a 5) para a facilidade da tarefa 7 | Feedback detalhado do usuário sobre a tarefa 7 | Minutagem do usuário para finalizar a tarefa 7 | Contando quantos cliques o usuário precisou para concluir a tarefa 7 | Usuário irá informar quantos erros teve ao realizar a tarefa 7 |
| Receber notificações            | Usuário vai dar uma nota de (1 a 5) para a facilidade da tarefa 8 | Feedback detalhado do usuário sobre a tarefa 8 | Minutagem do usuário para finalizar a tarefa 8 | Contando quantos cliques o usuário precisou para concluir a tarefa 8 | Usuário irá informar quantos erros teve ao realizar a tarefa 8 |


> **Links Úteis**:
> - [Teste De Usabilidade: O Que É e Como Fazer Passo a Passo (neilpatel.com)](https://neilpatel.com/br/blog/teste-de-usabilidade/)
> - [Teste de usabilidade: tudo o que você precisa saber! | by Jon Vieira | Aela.io | Medium](https://medium.com/aela/teste-de-usabilidade-o-que-voc%C3%AA-precisa-saber-39a36343d9a6/)
> - [Planejando testes de usabilidade: o que (e o que não) fazer | iMasters](https://imasters.com.br/design-ux/planejando-testes-de-usabilidade-o-que-e-o-que-nao-fazer/)
> - [Ferramentas de Testes de Usabilidade](https://www.usability.gov/how-to-and-tools/resources/templates.html)
