# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Personas
#### Nome: Amanda Alves <br> 
Idade: 46. <br>
Ocupação: estagiária em análise e desenvolvimento de sistemas. <br>
Hobbies : Viajar, Ler, Escutar música. <br>
Praticar esporte. <br>
História:  Amanda Alves, é uma jovem de 19 anos, apaixonada pelo turismo, e está sempre procurando lugares novos para conhecer.<br>

#### Paulo Gonçalves <br>
Idade: 47<br>
Ocupação: Dono de uma empresa de carros.<br>
Hobbies : Acompanhar corridas de carros,  viajar, Acompanhar o mundo de investimentos.<br>
História: Paulo Gonçalves, é um homem de 40 anos, apaixonado por carros e viajem, está sempre procurando locais novo para visitar. <br>

#### Adriana Silva <br>
Idade: 48. <br>
Ocupação: Ex-atleta paraolímpica e atual designer gráfica. <br>
Hobbies : Leitura, desenho, assistir filmes e séries. <br>
História: há alguns anos, Ana sofreu um acidente de carro que resultou em lesões na coluna vertebral, deixando-a parcialmente paralisada da cintura para baixo. Apesar dos desafios físicos, Ana é uma pessoa determinada e apaixonada por sua atual profissão. Ela adaptou seu ambiente de trabalho em casa para garantir que tudo esteja acessível e confortável para suas necessidades. <br>

#### Roberto Nascimento <br>
Idade: 52. <br>
Ocupação: Policial. <br>
Hobbies : Treinamento físico, leitura de livros sobre segurança pública, passeios ao ar livre com a família. <br>
História: Nascimento é um policial dedicado com 15 anos de experiência na força policial local. Desde jovem, ele sempre teve uma vocação para servir e proteger sua comunidade. Seu interesse pela segurança pública começou quando ele testemunhou um crime em sua vizinhança durante a adolescência, o que o motivou a seguir a carreira policial. Marcos é conhecido por sua ética de trabalho exemplar e sua determinação. Ele realiza patrulhas regularmente, respondendo a chamadas de emergência e garantindo a segurança dos cidadãos. Fora do trabalho, Marcos dedica seu tempo livre ao treinamento físico e à leitura de livros sobre táticas policiais e estratégias de segurança para aprimorar suas habilidades profissionais. Além disso, Marcos valoriza muito o tempo passado com sua família e costuma fazer passeios ao ar livre com sua esposa e filhos nos fins de semana, sempre atento à segurança deles e de todos ao seu redor. <br>

#### Gabriela Torres <br>
Idade: 51. <br>
Ocupação: Professora de história. <br>
Hobbies : Viajar, estudar culturas locais, fotografia, colecionar artefatos históricos. <br>
História: Gabriela é uma professora de história apaixonada por culturas locais e viagens. Ela leciona história há mais de uma década, inspirando seus alunos a explorar e compreender o mundo por meio do estudo do passado. Sempre que possível, Gabriela aproveita suas férias para viajar e explorar novos lugares, mergulhando na riqueza cultural e histórica de cada destino. Gabriela também é uma entusiasta da fotografia, capturando momentos significativos de suas viagens e colecionando artefatos históricos como lembranças. <br>


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
|Administrador       | Alterar permissões                 | Permitir que possam administrar contas |
|Usuário do sistema  | Registrar minhas tarefas           | Não esquecer de fazê-las               |
|Usuário do sistema  | Encontrar informações sobre destinos turísticos populares em diferentes cidades          | Planejar minha próxima viagem              |
|Usuário do sistema  | Ler comentários e respostas de outros viajantes sobre atrações turísticas (locais históricos, museus, restaurantes etc) de uma determinada cidade          | Planejar os locais que irei visitar em determinada cidade              |
|Usuário do sistema  | Escrever perguntas e respostas em seções específicas de cada destino | Esclarecer dúvidas e ajudar outros usuários da página  |
|Usuário do sistema  | Avaliar as perguntas e respostas postadas em seções específicas de cada destino como 'gostei'e 'não gostei' | classificar os comentários pela sua relevância e utilidade |
|Usuário do sistema  | Definir minhas cidades favoritas do sit e acompanhar os comentários e notícias | Me atualizar sobre as informações postadas das minhas cidades de maior interesse |
|Usuário do sistema  | Selecionar o tipo de atividade (aventura, caminhada, esportes radicais, atividades para família) que quero fazer em uma determinada cidade| localizar, mais facilmente, as atividades disponíveis em cada região |
|Usuário do sistema  |Comentar em seções específicas acerca do local visitado, como alimentação, transporte, hospedagem e clima | Fornecer feedback dos lugares  que visitei |
|Usuário do sistema  |Informações  sobre a história e cultura da cidade a ser visitada| localizar, mais facilmente, as atividades disponíveis em cada região | Fornecer feedback dos lugares  que visitei |
|Usuário do sistema (de orçamento limitado) |Encontrar dicas e guias para viagens econômicas (hospedagens e locais de visitação) | Para compreender melhor o contexto do local antes de visitá-lo |
|Usuário do sistema (com folga orçamentária) |Encontrar dicas e guias para viagens (hospedagens e locais de visitação) | Para que a viagem seja adequada ao orçamento disponível |
|Usuário do sistema (com mobilidade reduzida) |Informações sobre a acessibilidade de atrações turísticas em uma determinada cidade | Para que consiga ter uma boa experiência nos locais a serem visitados |
|Usuário do sistema (interessado em segurança) |Gostaria de encontrar informações sobre os índices de criminalidade | Para planejar uma viagem tranquila sob o ponto de vista da segurança |

> **Links Úteis**:
> - [Histórias de usuários com exemplos e template](https://www.atlassian.com/br/agile/project-management/user-stories)
> - [Como escrever boas histórias de usuário (User Stories)](https://medium.com/vertice/como-escrever-boas-users-stories-hist%C3%B3rias-de-usu%C3%A1rios-b29c75043fac)
> - [User Stories: requisitos que humanos entendem](https://www.luiztools.com.br/post/user-stories-descricao-de-requisitos-que-humanos-entendem/)
> - [Histórias de Usuários: mais exemplos](https://www.reqview.com/doc/user-stories-example.html)
> - [9 Common User Story Mistakes](https://airfocus.com/blog/user-story-mistakes/)

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição de Requisitos Funcionais | Prioridade |
|------|-----------------------------------------|----|
|RF-001| A aplicação deve exibir os dados básicos da cidade escolhida pelo usúario tais como;  Alimentação, transporte, clima e atração turística | ALTA |
|RF-002| A aplicação deve permitir aos usuários a opção de realizar postagens de perguntas ou dicas referentes aos destinos escolhidos | ALTA |
|RF-004| A aplicação deve permitir que os demais usuários possam votar em suas perguntas ou dicas favoritas | MÉDIA | 
|RF-005| A aplicação deve automaticamente avaliar os melhores comentário e os evidenciar em "destaque" | MÉDIA |
|RF-006| A aplicação deve permitir aos usúarios que possam favoritar seus detinos favoritos | MÉDIA |
|RF-007| A aplicação deve permitir aos usúarios que possam aplicar filtros que permitam selecionar roteirso de viagens de acordo com a sua disponibilidade orçamentária | BAIXA |
|RF-008| A aplicação deve permitir aos usúarios que possam aplicar filtros que forneçaem informaçoes básicas acerca da infraestrutura de locomoção para usuários com mobilidade reduzida | BAIXA |
|RF-009| A aplicação deve permitir aos usúarios que possam aplicar filtros que forneçaem informaçoes básicas sobre a segurança dos locais a serem visitados | BAIXA |
          
### Requisitos não Funcionais

|ID     | Descrição de Requisitos Não Funcionais |Prioridade |
|-------|-------------------------|----|
|RNF-001| O sistema deve ser protegido contra acesso não autorizado | ALTA |
|RNF-002| O Sistema deve ser capaz de trazer informações revelantes sobre a pesquisa de cada destino selecionado como o clima da região, e atração turística | ALTA |
|RNF-003| O Sistema deve ser capaz de salvar os dados salvos do usúario de maneira individual para que cada usúario mantenha os próprios dados ao deslogar e logar | ALTA |
|RNF-004| O Sistema deve funcionar de maneira correta mesmo com vários usúarios utilizando a plataforma ao mesmo tempo| ALTA |

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
|02| Deve ser desenvolvido um módulo de backend        |


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
