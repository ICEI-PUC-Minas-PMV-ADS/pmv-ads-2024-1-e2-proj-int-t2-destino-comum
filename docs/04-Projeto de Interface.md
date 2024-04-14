
# Projeto de Interface

Para mapear todo fluxo de navegação do usuário na aplicação, foi utilizada a técnina Fluxo de Usuário (User Flow). Isto é, foi feita uma representação visual de etapas que um usuário percorre enquanto interage com um sistema.

Entre as considerações relevantes para a concepção da interface do sistema, o grupo decidiu priorizar aspectos como velocidade de resposta, acessibilidade e facilidade de utilização.

Dessa forma, o projeto visa manter e aderir uma identidade visual consistente em todas as telas, com o fim de operar eficientemente em computadores desktop e dispositivos móveis.



## Diagrama de Fluxo

<s>O diagrama apresenta o estudo do fluxo de interação do usuário com o sistema interativo e  muitas vezes sem a necessidade do desenho do design das telas da interface. Isso permite que o design das interações seja bem planejado e gere impacto na qualidade no design do wireframe interativo que será desenvolvido logo em seguida.

O diagrama de fluxo pode ser desenvolvido com “boxes” que possuem internamente a indicação dos principais elementos de interface - tais como menus e acessos - e funcionalidades, tais como editar, pesquisar, filtrar, configurar - e a conexão entre esses boxes a partir do processo de interação. Você pode ver mais explicações e exemplos https://www.lucidchart.com/blog/how-to-make-a-user-flow-diagram.




As referências abaixo irão auxiliá-lo na geração do artefato “Diagramas de Fluxo”.

> **Links Úteis**:
> - [Fluxograma online: seis sites para fazer gráfico sem instalar nada | Produtividade | TechTudo](https://www.techtudo.com.br/listas/2019/03/fluxograma-online-seis-sites-para-fazer-grafico-sem-instalar-nada.ghtml)

</s>

O diagrama apresentado nas figuras (abaixo) mostram o fluxo de interação do usuário por meio das telas do sistema. Cada uma das telas da figura supramencionada é detalhada na seção de Wireframes a seguir. Destaca-se que o nome escolhido para o portal é "Destino Comum, conexão viajante", pois transmite a ideia de um lugar que todos podem compartilhar experiências de viagens anteriores e explorar juntos novos destinos, independentemente de origens ou interesses diversos, criando uma sensação de inclusão e abertura para todos os viajantes.

### Diagrama de Fluxo (Busca Ciddade e Comentários)

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t2-destino-comum/assets/144973239/a9856529-282d-4bf5-b200-6c55ad1d14b9)

## Wireframes

Para esta seção, foram utlizados  protótipos de baixa fidelidade, cujo objetivo foi apresentar, de forma simplificada, o design da interface e o relacionamento entre suas páginas, permitindo evolução da proposta da solução. Neste projeto, os utilizaremos para apoiar a validação dos requisitos e efetuar mudanças dos mesmos, caso seja necessário, para menor impacto na codificação da aplicação.

Conforme fluxo de telas do projeto, apresentado no item anterior, as telas do sistema são apresentadas, em detalhes, nos itens que se seguem.

### Tela Home-Page

A tela de home-page mostra, basicamente, todo o conteúdo do site que pode ser acessado. Isto é, é possível acessar  "CIDADES E TIPOS DE DESTINO" bem como efetuar o login. A figura principal da tela inicial traz uma mensagem, que diz: “ Conecete-se com aventuras e inspirações de viajanetes".

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t2-destino-comum/assets/144973239/b381e36a-8c10-449e-b12c-e509df608549)


### Tela Tipo de Destino

Nesta tela, o usuário pode navegar pelas opções de destinos para encontrar um tipo de viagem requerida por ele. Ou seja, ele pode escolher entre aventura, romance ou diversão em família e descobrir uma variedade de cidades com diversas dicas de outros viajantes. Para acessar as cidades, basta clicar no ícone "CIDADES"disponibilizado em cada tipo de destino.

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t2-destino-comum/assets/144973239/c7992919-b16a-413c-aac8-4a5159c0fcf5)

### Tela Tipo de Destino Escolhido

Uma vez escolhido o tipo de destino, será aberta uma tela (tipo de destino escolhido) contendo uma foto e uma breve descrição das cidades. Clicando na foto da cidade, o usuário é direcionado à página do respectivo local.

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t2-destino-comum/assets/144973239/24c09011-3cbd-488d-af17-db1ed7f06f4e)

### Tela Cidade Escolhida
Uma vez escolhido o tipo de destino e a cidade, o usuário é direcionado à página da respectiva localidade. Nesta tela haverá uma descrição da cidade. Ademais, o usuário poderá selecionar o tipo de informação - clima, pontos turístios e alimentação - que deseja obter daquele centro urbano. Lembrando que todas essas informações serão fornecidas por outros viajantes que já visitaram aquele local.

![Queenstown](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t2-destino-comum/assets/145787867/e36f9e5f-579f-4048-855f-f1bc310aadbf)



### Tela Login
Nesta tela, o usuário irá fornecer as suas credenciais de acesso (email e senha) para efetuar o login. Caso não seja cadastrado, ele pode clicar em "Cadastrar-se".

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t2-destino-comum/assets/144973239/f3983e7b-f20a-421f-8983-2d2573d587c9)

### Cadastro

Nesta tela, o usuário irá fornecer e-mail e cadastrar uma senha para que o cadastro de usuário seja efetuado. Caso o cadastro seja realizado com sucesso, uma mensagem aparecerá na tela. Caso haja divergência no email cadastrado e na senha cadastrada, as seguintes mensagens seræo disponibilizadas: "Os emails não coincidem, por favor, digite os emails iguais!"; "As senhas não coincidem, por favor, digite as senhas iguais!"

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t2-destino-comum/assets/144973239/1ea90bfa-70aa-430d-bcc5-80956c2a6bd0)

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t2-destino-comum/assets/144973239/31797729-da1d-487a-96da-154a1334aaa8)

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t2-destino-comum/assets/144973239/3f075b4a-43ea-40d9-8875-66427b397ad0)

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t2-destino-comum/assets/144973239/00cc97fe-36f8-46b5-91e1-4c91e206929d)


### Página do usuário
Após finalização do cadastro e login, será apresentada tela com os dados basicos do usuário, lista de comentários realizados e cidades favoritas.
![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t2-destino-comum/assets/144973239/e99688f5-376e-4d3e-913f-91c84f174c6e)



