# Arquitetura da Solução

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>

A concepção da interface do sistema foi elaborada para melhorar a experiência do usuário. Desta forma, a facilidade de uso e eficiência serão considerados pilares do desenvolvimento desta aplicação.

## Diagrama de Classes

O diagrama de classes mostra as classes e métodos que são usados no programa:

![diagramaDeClasses_PUC](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t2-destino-comum/blob/main/docs/img/Diagrama%20de%20classes.png)

Este diagrama foi feito no programa Astah UML.

O diagrama de classes ilustra graficamente como será a estrutura do software, e como cada uma das classes da sua estrutura estarão interligadas. Essas classes servem de modelo para materializar os objetos que executarão na memória.


## Modelo ER (Projeto Conceitual)
O Modelo ER representa através de um diagrama como as entidades (coisas, objetos) se relacionam entre si na aplicação interativa.

Para a confecção deste diagrama, foi utilizada a ferramenta "brModelo". 

Neste diagrama é possível perceber que:
- Um usuário pode fazer diversos comentários, mas um comentário está relacionado a um único usuário (usuário específico);
- Um administrador pode excluir diverssos comentários, e um comentário pode ser editado por pelo menos um administrador;
- Uma cidade pode ter diverssos comentários, mas um comentário em específico está relacionado a uma única cidade; e
- Cada usuário pode pesquisar zero ou mais cidades e cada cidade pode ser acessada por zero ou mais usuários.

Isso pode ser melhor visto na figura abaixo.

![Conceitual](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t2-destino-comum/assets/145787867/d56b0cec-1144-4492-9bdb-27f6ceca56b9)





## Projeto da Base de Dados

O projeto da base de dados corresponde à representação das entidades e relacionamentos identificadas no Modelo ER, no formato de tabelas, com colunas e chaves primárias/estrangeiras necessárias para representar corretamente as restrições de integridade.
 
Para a confecção deste modelo lógico, foi utilizada a ferramenta "brModelo". 
A entidade "Fiscaliza" foi adicionada ao modelo, pois a relação entre as entidades "Comentario" e "Adminsitrador" é (0,N) : (1,N). A entidade "Fiscaliza" possui como chave primária e estrangeira as chaves primárias das outras duas tabelas ("Comentário" e "Administrador").

Por sua vez, A entidade "Pesquisa e Acessa" foi adicionada ao modelo, pois a relação entre as entidades "Usuario" e "Cidade" é (0,N) : (0,N). A entidade "PesquisaAcessa" possui como chave primária e estrangeira as chaves primárias das outras duas tabelas ("Usuario" e "Cidade"). Tudo isso pode ser visto na figura abaixo.


![Logico](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2024-1-e2-proj-int-t2-destino-comum/assets/145787867/d7a686ac-ae9f-43f2-9e27-86323c24dd4f)




## Tecnologias Utilizadas

Para implementar a solução, serão utilizads aplicações que abrangem o front-end bem como o back-end. No front-end, serão empregadas as linguagens HTML, CSS e JavaScript. Por sua vez, para o desenvolvimento do back-end, será utilizada a linguagem C# em conjunto com o Framework da API Web do ASP.NET Core. O sistema de gerenciamento de banco de dados (SGBD) será o SQL Server. Durante a fase de implementação e desenvolvimento, será usado o Visual Studio Code para a criação de códigos. Por fim, o GitHub será a plataforma utilizada para hospedar o código-fonte.

## Hospedagem

Explique como a hospedagem e o lançamento da plataforma foi feita.

> **Links Úteis**:
>
> - [Website com GitHub Pages](https://pages.github.com/)
> - [Programação colaborativa com Repl.it](https://repl.it/)
> - [Getting Started with Heroku](https://devcenter.heroku.com/start)
> - [Publicando Seu Site No Heroku](http://pythonclub.com.br/publicando-seu-hello-world-no-heroku.html)
