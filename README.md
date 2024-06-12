# Arquitetura-MSC
Projeto de exemplo para o padrão de arquitetura MSC

Model, Service e Controller == Simples e organizado.

A arquitetura MSC é uma forma nova de aplicar o desenvolvimento do backend em poucas camadas, mas sendo muito eficiente para a manutenção do código e tambem facilitar na escalabilidade e uso para utilizar em microserviços.

Com um código simples, minimalista, estruturado e organizado, é de acesso rápido as todas as funções no projeto.

Definição MSC:
CONTROLLER: Camada responsável por receber e responder as requisições, é a camada de nivel 1 , responsavel tambem por chamar a camada SERVICE.

SERVICE: Camada responsável pelo processamento em si das regras de negócio da aplicação, é a camada de nivel 2 a qual é responsavel por usar a camada MODEL, que é utilizada para definição dos objetos da aplicação tanto para o armazendo de dados quanto para o processamento das informações.

MODEL: Camada responsável por definir os objetos do sistema, relacionado com o armazenamento de dados e processamento de informações. É a camada de nivel 3 que em resumo representa os objetos de nossa aplicação.


