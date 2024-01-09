<h1 align="center"> .NET 6: criando uma web API </h1>

<p align="center">
Projeto de uma api para controle de acesso de usuários feito por Thiago Sette.
</p>

<p align="center">
  <a href="#-tecnologias">Tecnologias</a>&nbsp;&nbsp;&nbsp;
  |&nbsp;&nbsp;&nbsp;
  <a href="#-tecnologias">Projeto</a>&nbsp;&nbsp;&nbsp;
  |&nbsp;&nbsp;&nbsp;
  <a href="#-Requisições">Gestão de Requisições na API</a>&nbsp;&nbsp;&nbsp;
  |&nbsp;&nbsp;&nbsp;
  <a href="#-Padronização">Padronização na Entrega de Informações</a>&nbsp;&nbsp;&nbsp;
  |&nbsp;&nbsp;&nbsp;
  <a href="#-DTOs">Data Transfer Objects (DTOs)</a>&nbsp;&nbsp;&nbsp;
  |&nbsp;&nbsp;&nbsp;
  <a href="#-DbContext">Dados no Banco (DbContext)</a>&nbsp;&nbsp;&nbsp;
  |&nbsp;&nbsp;&nbsp;
  <a href="#-MySQL">MySQL</a>&nbsp;&nbsp;&nbsp;
 </p>
<br>

## 🚀 Tecnologias

Esse projeto foi desenvolvido com as seguintes tecnologias:

- Autenticação e Cadastro de Usuários:
  * Utilização eficiente do Identity para simplificar o cadastro e autenticação de usuários.

- Segurança:
  * Implementação de tokens JWT para reforçar a segurança.

- Comunicação e Interatividade:
  * Integração do ASP.NET para aprimorar o envio eficiente de e-mails.

- Proteção de Dados Sensíveis:
  * Adoção de práticas de segurança, como ocultação de informações através de secrets.

- Usabilidade:
  * Combinação de tecnologias visando proporcionar uma solução eficaz e intuitiva para os usuários

## 💻 Projeto

Implementamos uma abordagem abrangente para lidar com requisições em nossa API. Com uma compreensão aprofundada dos principais verbos HTTP, como GET e POST, conseguimos estabelecer uma comunicação eficiente entre o cliente e o servidor. A padronização na entrega de informações ao usuário não apenas aprimorou a experiência do usuário, mas também facilitou a manutenção do código ao longo do tempo. A utilização estratégica de Data Transfer Objects (DTOs) permitiu-nos gerenciar de maneira eficaz as requisições e respostas, promovendo uma comunicação clara e estruturada. Além disso, ao dominar o DbContext para operações de escrita, conseguimos manipular os dados de forma segura e consistente no banco, assegurando a integridade das informações. Esse conjunto de habilidades foi essencial para a criação de uma aplicação web coesa, eficiente e pronta para evoluir conforme as necessidades do projeto.


## 💻 Gestão de Requisições na API

A Gestão de Requisições na API é fundamental para estabelecer uma comunicação eficiente entre clientes e servidores em projetos web. Compreende a habilidade de receber e processar solicitações HTTP, sendo crucial para a execução de operações diversas. A compreensão dos principais verbos HTTP, como GET, POST e DELETE, possibilita a manipulação adequada das requisições, permitindo a recuperação de dados, envio de informações e ações específicas no servidor. Uma implementação eficaz dessa tecnologia não apenas facilita a interação entre componentes, mas também contribui para a construção de APIs robustas e escaláveis, essenciais para o desenvolvimento de aplicações modernas.

## 💻 Política de acesso

A Política de Acesso é uma tecnologia crucial para o controle de permissões e restrições em sistemas de software. Essa abordagem define diretrizes e regras que determinam quais usuários ou entidades têm autorização para acessar recursos específicos dentro de uma aplicação. Ao estabelecer políticas de acesso, os desenvolvedores podem gerenciar de maneira granular as permissões de usuários, restringindo ou permitindo ações com base em funções, atributos ou outros critérios definidos. Essa tecnologia é fundamental para garantir a segurança e a conformidade em ambientes digitais, permitindo a configuração flexível de acessos de acordo com as necessidades específicas de cada sistema. A implementação eficiente de políticas de acesso contribui para a construção de aplicações robustas, adaptáveis e alinhadas aos princípios de segurança e governança exigidos em diversos contextos.Handlers

## 💻 Handlers

Handlers são uma tecnologia essencial no desenvolvimento de software, desempenhando um papel fundamental na manipulação de eventos, requisições ou situações específicas em um sistema. Em contextos como frameworks web, os handlers são frequentemente utilizados para processar solicitações HTTP, permitindo que desenvolvedores personalizem o comportamento da aplicação em diferentes estágios do ciclo de vida de uma requisição. Esses componentes são responsáveis por lidar com tarefas específicas, como autenticação, autorização, logging, entre outros. A flexibilidade oferecida pelos handlers permite a modularização do código, simplificando a manutenção e proporcionando uma arquitetura mais escalável e adaptável. Ao permitir a execução de código personalizado em momentos específicos, os handlers desempenham um papel crucial na implementação de lógicas específicas, contribuindo para a eficiência e a personalização de sistemas diversos.Secrets

## 💻 Secrets

Handlers são uma tecnologia essencial no desenvolvimento de software, desempenhando um papel fundamental na manipulação de eventos, requisições ou situações específicas em um sistema. Em contextos como frameworks web, os handlers são frequentemente utilizados para processar solicitações HTTP, permitindo que desenvolvedores personalizem o comportamento da aplicação em diferentes estágios do ciclo de vida de uma requisição. Esses componentes são responsáveis por lidar com tarefas específicas, como autenticação, autorização, logging, entre outros. A flexibilidade oferecida pelos handlers permite a modularização do código, simplificando a manutenção e proporcionando uma arquitetura mais escalável e adaptável. Ao permitir a execução de código personalizado em momentos específicos, os handlers desempenham um papel crucial na implementação de lógicas específicas, contribuindo para a eficiência e a personalização de sistemas diversos.