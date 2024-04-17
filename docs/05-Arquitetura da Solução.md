# Arquitetura da Solução

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>

Definição de como o software é estruturado em termos dos componentes que fazem parte da solução e do ambiente de hospedagem da aplicação.

## Diagrama de Classes

O diagrama de classes mostra as classes e métodos que são usados no programa:

![diagramaDeClasses_PUC](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t2-destino-comum/blob/main/docs/img/Diagrama%20de%20classes.png)

Este diagrama foi feito no programa Astah UML.

O diagrama de classes ilustra graficamente como será a estrutura do software, e como cada uma das classes da sua estrutura estarão interligadas. Essas classes servem de modelo para materializar os objetos que executarão na memória.

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Classes”.

> - [Diagramas de Classes - Documentação da IBM](https://www.ibm.com/docs/pt-br/rational-soft-arch/9.6.1?topic=diagrams-class)
> - [O que é um diagrama de classe UML? | Lucidchart](https://www.lucidchart.com/pages/pt/o-que-e-diagrama-de-classe-uml)

## Modelo ER (Projeto Conceitual)
O Modelo ER representa através de um diagrama como as entidades (coisas, objetos) se relacionam entre si na aplicação interativa.

Para a confecção deste diagrama, foi utilizada a ferramenta "brModelo". 

Neste diagrama é possível perceber que:
- Um usuário pode fazer diversos comentários, mas um comentário está relacionado a um único usuário (usuário específico);
- Um administrador pode excluir diverssos comentários, e um comentário pode ser editado por pelo menos um administrador;
- Uma cidade pode ter diverssos comentários, mas um comentário em específico está relacionado a uma única cidade; e
- Cada usuário pode pesquisar zero ou mais cidades e cada cidade pode ser acessada por zero ou mais usuários.

Isso pode ser melhor visto na figura abaixo.

![DiagramaConceitual_PUC](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t2-destino-comum/assets/145787867/82e1b757-2b95-41a5-9347-5188d9f2e002)





## Projeto da Base de Dados

O projeto da base de dados corresponde à representação das entidades e relacionamentos identificadas no Modelo ER, no formato de tabelas, com colunas e chaves primárias/estrangeiras necessárias para representar corretamente as restrições de integridade.
 
Para a confecção deste modelo lógico, foi utilizada a ferramenta "brModelo". 
A entidade "Fiscaliza" foi adicionada ao modelo, pois a relação entre as entidades "Comentario" e "Adminsitrador" é (0,N) : (1,N). A entidade "Fiscaliza" possui como chave primária e estrangeira as chaves primárias das outras duas tabelas ("Comentário" e "Administrador").

Por sua vez, A entidade "Pesquisa e Acessa" foi adicionada ao modelo, pois a relação entre as entidades "Usuario" e "Cidade" é (0,N) : (0,N). A entidade "PesquisaAcessa" possui como chave primária e estrangeira as chaves primárias das outras duas tabelas ("Usuario" e "Cidade"). Tudo isso pode ser visto na figura abaixo.

![DiagramaLogico_PUC](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t2-destino-comum/assets/145787867/9b5e0175-7e71-45b7-8472-88f4039c05e5)




## Tecnologias Utilizadas

Descreva aqui qual(is) tecnologias você vai usar para resolver o seu problema, ou seja, implementar a sua solução. Liste todas as tecnologias envolvidas, linguagens a serem utilizadas, serviços web, frameworks, bibliotecas, IDEs de desenvolvimento, e ferramentas.

Apresente também uma figura explicando como as tecnologias estão relacionadas ou como uma interação do usuário com o sistema vai ser conduzida, por onde ela passa até retornar uma resposta ao usuário.

## Hospedagem

Explique como a hospedagem e o lançamento da plataforma foi feita.

> **Links Úteis**:
>
> - [Website com GitHub Pages](https://pages.github.com/)
> - [Programação colaborativa com Repl.it](https://repl.it/)
> - [Getting Started with Heroku](https://devcenter.heroku.com/start)
> - [Publicando Seu Site No Heroku](http://pythonclub.com.br/publicando-seu-hello-world-no-heroku.html)
