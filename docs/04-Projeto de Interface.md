
# Projeto de Interface

<s> <span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Documentação de Especificação</a></span>

Visão geral da interação do usuário pelas telas do sistema e protótipo interativo das telas com as funcionalidades que fazem parte do sistema (wireframes).

 Apresente as principais interfaces da plataforma. Discuta como ela foi elaborada de forma a atender os requisitos funcionais, não funcionais e histórias de usuário abordados nas <a href="2-Especificação do Projeto.md"> Documentação de Especificação</a>. 
 
 </s>

Para mapear todo fluxo de navegação do usuário na aplicação, foi utilizada a técnina Fluxo de Usuário (User Flow). Isto é, foi feita uma representação visual de etapas que um usuário percorre enquanto interage com um sistema.

Entre as considerações relevantes para a concepção da interface do sistema, o grupo decidiu priorizar aspectos como velocidade de resposta, acessibilidade e facilidade de utilização.

Dessa forma, o projeto visa manter e aderir uma identidade visual consistente em todas as telas, com o fim de operar eficientemente em computadores desktop e dispositivos móveis.



## Diagrama de Fluxo

<s>O diagrama apresenta o estudo do fluxo de interação do usuário com o sistema interativo e  muitas vezes sem a necessidade do desenho do design das telas da interface. Isso permite que o design das interações seja bem planejado e gere impacto na qualidade no design do wireframe interativo que será desenvolvido logo em seguida.

O diagrama de fluxo pode ser desenvolvido com “boxes” que possuem internamente a indicação dos principais elementos de interface - tais como menus e acessos - e funcionalidades, tais como editar, pesquisar, filtrar, configurar - e a conexão entre esses boxes a partir do processo de interação. Você pode ver mais explicações e exemplos https://www.lucidchart.com/blog/how-to-make-a-user-flow-diagram.

![Exemplo de Diagrama de Fluxo](img/diagramafluxo2.jpg)

As referências abaixo irão auxiliá-lo na geração do artefato “Diagramas de Fluxo”.

> **Links Úteis**:
> - [Fluxograma online: seis sites para fazer gráfico sem instalar nada | Produtividade | TechTudo](https://www.techtudo.com.br/listas/2019/03/fluxograma-online-seis-sites-para-fazer-grafico-sem-instalar-nada.ghtml)

</s>

O diagrama apresentado na Figura 1 (abaixo) mostra o fluxo de interação do usuário por meio das telas do sistema. Cada uma das telas da figura supramencionada é detalhada na seção de Wireframes a seguir. Destaca-se que o nome escolhido para o portal é "ABCD" , pois ...

## Wireframes

<s> ![Exemplo de Wireframe](img/wireframe-example.png)

São protótipos usados em design de interface para sugerir a estrutura de um site web e seu relacionamentos entre suas páginas. Um wireframe web é uma ilustração semelhante do layout de elementos fundamentais na interface.
 
> **Links Úteis**:
> - [Protótipos vs Wireframes](https://www.nngroup.com/videos/prototypes-vs-wireframes-ux-projects/)
> - [Ferramentas de Wireframes](https://rockcontent.com/blog/wireframes/)
> - [MarvelApp](https://marvelapp.com/developers/documentation/tutorials/)
> - [Figma](https://www.figma.com/)
> - [Adobe XD](https://www.adobe.com/br/products/xd.html#scroll)
> - [Axure](https://www.axure.com/edu) (Licença Educacional)
> - [InvisionApp](https://www.invisionapp.com/) (Licença Educacional)
>
</s>

Para esta seção, foram utlizados  protótipos de baixa fidelidade, cujo objetivo foi apresentar, de forma simplificada, o design da interface e o relacionamento entre suas páginas, permitindo evolução da proposta da solução. Neste projeto, os utilizaremos para apoiar a validação dos requisitos e efetuar mudanças dos mesmos, caso seja necessário, para menor impacto na codificação da aplicação.

Conforme fluxo de telas do projeto, apresentado no item anterior (Figura 1), as telas do sistema são apresentadas, em detalhes, nos itens que se seguem.

### Tela Home-Page

A tela de home-page mostra, basicamente, todo o conteúdo do site que pode ser acessado. Isto é, é possível acessar  "CIDADES E TIPOS DE DESTINO" bem como efetuar o login. A figura principal da tela inicial traz uma mensagem, que diz: “ Conecete-se com aventuras e inspirações de viajanetes".

![1 Home](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t2-destino-comum/assets/145787867/165479c6-a8d0-445c-b132-709e6157a825)

### Tela Tipo de Destino

Nesta tela, o usuário pode navegar pelas opções de destinos para encontrar um tipo de viagem requerida por ele. Ou seja, ele pode escolher entre aventura, romance ou diversão em família e descobrir uma variedade de cidades com diversas dicas de outros viajantes. Para acessar as cidades, basta clicar no ícone "CIDADES"disponibilizado em cada tipo de destino.

![2 tipos de destino](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t2-destino-comum/assets/145787867/3719ee16-086a-46a3-83d3-183561518102)

### Tela Tipo de Destino Escolhido

Uma vez escolhido o tipo de destino, será aberta uma tela (tipo de destino escolhido) contendo uma foto e uma breve descrição das cidades. Clicando na foto da cidade, o usuário é direcionado à página do respectivo local.

![3 - Tipo de Destino Escolhido](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t2-destino-comum/assets/145787867/60f97e6b-3539-434d-9766-36f7cd66532e)

### Tela Cidade Escolhida
Uma vez escolhido o tipo de destino e a cidade, o usuário é direcionado à página da respectiva localidade. Nesta tela haverá uma descrição da cidade. Ademais, o usuário poderá selecionar o tipo de informação - clima, pontos turístios e alimentação - que deseja obter daquele centro urbano. Lembrando que todas essas informações serão fornecidas por outros viajantes que já visitaram aquele local.

![4 - cidade escolhida](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t2-destino-comum/assets/145787867/c502eb4d-2a97-4bfb-bb54-ff13ae25414f)

### Tela Clima
Na tela "Cidade Escolhida", caso o usuário selecione "Clima", ele será direcionado a uma tela contendo comentários, de diversos outros usuários, sobre o clima da região. Os comentários são ranqueados conforme a quantidade de "likes" recebida. Isto é, os melhores comentários, cinco estrelas, aparecem acima dos comentários de "quatro estrelas". Nesta tela, o usuário poderá clicar em "comentário" para escrever suas observações sobre o tema (clima). Lembrando que o cliente somente poderá tecer algum comentário caso esteja logado na plataforma.

![5 - clima](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t2-destino-comum/assets/145787867/6ef65270-4a6e-4861-8091-9f1773ec03b3)

### Tela Pontos Turísticos

Na tela "Cidade Escolhida", caso o usuário selecione "Pontos Turísticos", ele será direcionado a uma tela contendo comentários, de diversos outros usuários, sobre os pontos turísticos daquela região. Os comentários são ranqueados conforme a quantidade de "likes" recebida. Isto é, os melhores comentários, cinco estrelas, aparecem acima dos comentários de "quatro estrelas". Nesta tela, o usuário poderá clicar em "comentário" para escrever suas observações sobre o tema. Lembrando que o cliente somente poderá tecer algum comentário caso esteja logado na plataforma.

 ![6 pontos turisticos](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t2-destino-comum/assets/145787867/4eea1f6e-7d14-456d-a264-b06366222009)


### Tela Alimentação
Na tela "Cidade Escolhida", caso o usuário selecione "Alimentação", ele será direcionado a uma tela contendo comentários, de diversos outros usuários, sobre locais para se alimentar naquela região. Os comentários são ranqueados conforme a quantidade de "likes" recebida. Isto é, os melhores comentários, cinco estrelas, aparecem acima dos comentários de "quatro estrelas". Nesta tela, o usuário poderá clicar em "comentário" para escrever suas observações sobre o tema. Lembrando que o cliente somente poderá tecer algum comentário caso esteja logado na plataforma.

![7 alimentacao](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t2-destino-comum/assets/145787867/21da5f8f-5df0-411e-acc0-4b467a532d1d)


### Tela Redigir Comentário
Caso o usuário esteja logado, ele poderá comentar sobre os temas (clima, pontos turísticos e alimentação) da cidade escolhida. Clicando em "SALVAR", o comentário é publicado. Caso o usuário não esteja logado à plataforma, ele será redirecionado para a tela de login. 

![8 - comentario](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t2-destino-comum/assets/145787867/d0ac8ebc-fbe5-453c-bbf4-725f6f7cb625)


### Tela Login
Nesta tela, o usuário irá fornecer as suas credenciais de acesso (email e senha) para efetuar o login. Caso não seja cadastrado, ele pode clicar em "Cadastrar-se".

![9 - login](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t2-destino-comum/assets/145787867/52667329-0f90-4c57-afe3-dc5c90ae3799)

### Cadastro

Nesta tela, o usuário irá fornecer e-mail e cadastrar uma senha para que o cadastro de usuário seja efetuado. Caso o cadastro seja realizado com sucesso, uma mensagem aparecerá na tela. Caso haja divergência no email cadastrado e na senha cadastrada, as seguintes mensagens seræo disponibilizadas: "Os emails não coincidem, por favor, digite os emails iguais!"; "As senhas não coincidem, por favor, digite as senhas iguais!"

![10 cadastro](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t2-destino-comum/assets/145787867/e8d88538-afdd-4067-900d-97b654a6ac32)
![13](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t2-destino-comum/assets/145787867/33a77479-1c17-48ca-af25-99272fc7d8ef)
![12 email cadastro](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t2-destino-comum/assets/145787867/65fcbf7d-f3cf-4efa-af9a-3a170026265b)





