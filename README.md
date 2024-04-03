# Sobre o projeto

O projeto tem como objetivo principal fornecer uma experiência prática na construção de uma API utilizando a plataforma .NET Core e a linguagem de programação C#. A abordagem adotada para a arquitetura do projeto segue os princípios do Domain-Driven Design (DDD), que é uma metodologia de desenvolvimento de software voltada para a modelagem de domínios complexos.

Ao construir esta API, os participantes terão a oportunidade de aprender sobre os fundamentos do desenvolvimento de software orientado a objetos, a estrutura e organização de projetos em .NET Core, bem como os conceitos essenciais do DDD. Isso inclui a definição de entidades de domínio, a implementação de serviços de aplicação e repositórios, a separação de responsabilidades entre as camadas da aplicação, entre outros aspectos cruciais.

Além disso, o projeto proporcionará uma compreensão mais profunda sobre os recursos oferecidos pelo .NET Core para o desenvolvimento de APIs, como a criação de endpoints RESTful, o uso de middleware para tratamento de requisições HTTP, a validação de dados de entrada, a serialização de objetos para formatos como JSON, entre outros.

Em resumo, o projeto serve como um ambiente de aprendizado prático para aqueles que desejam adquirir habilidades em desenvolvimento de APIs usando .NET Core e implementando uma arquitetura sólida baseada em DDD.

___

# Comandos básicos CLI

### 1. Criar uma solution

~~~javascript
dotnet new sln --name ['Nome da Solution']
//Ex:
dotnet new sln --name API
~~~

### 2. Criar um projeto WebApi
~~~javascript
// -n tag para especificar o nome
// -o tag para especificar a pasta de saída do projeto
// --no-https configuração para não ser https
dotnet new webapi -n ['nome do projeto'] -o ['pasta de saída do projeto'] --no-https

//Ex:
dotnet new webapi -n application -o Api.Application --no-https
~~~

### 3. Vincular o projeto na solution

**OBS: TODO PROJETO DEVE SER VINCULADO À SOLUTION**

~~~js
dotnet sln add ['pasta de saída do projeto']

//Ex:
dotnet sln add Api.Application
~~~

### 4. Criar uma classe de library

**OBS: TODA classe de library DEVE SER VINCULADO À SOLUTION**

~~~js
// -n tag para especificar o nome
// -o tag para especificar a pasta de saída do projeto
// -f tag para especificar qual framework e versão deverá ser usada para a criação da classe
dotnet new classlib -n ['Nome da classe'] -o['pasta de saída da classe'] -f ['framework e versão']

//Ex:
dotnet new classlib -n Service -o Api.Service -f netcoreapp3.1
~~~


### 5. Restore da aplicação

**O comando dotnet restore é usado no ambiente de desenvolvimento .NET Core para restaurar as dependências de um projeto.**

~~~js
dotnet restore
~~~

### 6. Build da aplicação

**O comando dotnet build é usado no ambiente de desenvolvimento .NET Core para compilar um projeto e suas dependências.**

~~~js
// Ao fazer o build automaticamente também faz o:
// dotnet restore
dotnet build
~~~

dotnet ef migrations add Inital_Migration

### 7. Gerar Migration

**O comando deve ser executado estando dentro da pasta Api.Data.**

~~~js
//Inital_Migration é o nome da migration então pode ser trocado
dotnet ef migrations add Inital_Migration
~~~


### 8. Executar Migration

**O comando deve ser executado estando dentro da pasta Api.Data.**

~~~js

dotnet ef database update
~~~


# Entendendo o DDD

A principal ideia do DDD é a de que o mais importante em um software não é o seu código, nem sua arquitetura, nem a tecnologia sobre a qual foi desenvolvido, mas sim o problema que o mesmo se propõe a resolver, ou em outras palavras, a regra de negócio. Ela é a razão do software existir, por isso deve receber o máximo de tempo e atenção possíveis. Em praticamente todos os projetos de software, a complexidade não está localizada nos aspectos técnicos, mas sim no negócio, na atividade que é exercida pelo cliente ou problema que o mesmo possui. Como já diz o título do livro de Eric Evans, esse é o “coração”, o ponto central de qualquer aplicação, portanto todo o resto deve ser trabalhado de forma que este “coração” seja entendido e concebido da melhor forma possível.

Vamos utilizar um exemplo para tentar clarificar essa ideia: imagine que o mais novo cliente de sua empresa é um call center e você precisa desenvolver um software que controle todos os processos do mesmo. Mas quem conhece os processos de um call center? Seu gerente? Os desenvolvedores? Com certeza não. Todos estes provavelmente já foram atendidos por um, talvez tenham ideias vagas sobre o funcionamento, mas ninguém possui conhecimento suficiente para guiar o desenvolvimento desse projeto. Quem realmente conhece o negócio são os atendentes, supervisores e demais funcionários desse call center. É deles que esse conhecimento deve ser extraído, de maneira que a equipe do projeto possa se alinhar com seus desejos e expectativas.

Após esse exemplo, vamos fazer um paralelo com alguns conceitos do DDD. O funcionamento e processos do call center são considerados o domínio da aplicação. O domínio é o ponto central de qualquer aplicação, é por causa dele que o software é criado afinal de contas. Reforçando o que já foi falado anteriormente, é o domínio que concentra a maior parte da complexidade de quase todos os projetos de software. O que muitas vezes acontece é um foco excessivo em aspectos técnicos (o velho exemplo da equipe que está “ansiosa” por aplicar a mais nova versão de determinado framework) em detrimento de um conhecimento mais aprofundado no domínio. O grande ponto a ser destacado aqui é que para desenvolver uma aplicação de qualidade, que atenda todas as necessidades do cliente de forma satisfatória, não basta apenas ter muito conhecimento técnico e utilizar os melhores frameworks e plataformas, é necessário que a equipe do projeto tenha uma clara compreensão sobre o problema que o software se propõe a resolver, pois é isso que realmente traz valor ao produto final.


# Estrutura usada nesse projeto

