# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Personas



|![Fernanda Lopes](https://user-images.githubusercontent.com/84281638/194553518-44f6bc6e-1ed0-4b25-88fc-c014f7732180.png)|Fernanda Lopes|
---|---
|Idade| 35 anos|
|Estado civil| Solteira|
|Ocupação| Gerente de vendas|
|Aplicativos| Linkedin; Instagram|
|Motivações| Viagem a lazer; mais tempo com seu pet; andar pela cidade sem se preocupar onde estacionar|
|Frustações| Atrasos em eventos que permitem entrada de pets; não poder ir a longa distâncias com seu gato|
|Hoobies| Yoga; leitura; caminhada|

|![Renato Silva](https://user-images.githubusercontent.com/84281638/194552880-853d452f-d952-445d-a37b-1c335b1f7b93.png)|Renato Silva|
---|---
|Idade| 39 anos|
|Estado civil| Casado|
|Ocupação| Vendedor de imóveis|
|Aplicativos| Waze; CamScanner|
|Motivações|Poder se exercitar com seu cachorro|
|Frustações| Limitações de opções e lugares onde ir com seu pet|
|Hoobies| Futebol; correr|

|![Carlos Nascimento](https://user-images.githubusercontent.com/84281638/194552547-071c82c4-3145-4ed0-985a-2606c38706f6.png)|Carlos Nascimento|
---|---
|Idade| 25 anos; deficiente visual|
|Estado civil| Solteiro|
|Ocupação|Vendedor|
|Aplicativos| Instagram; youtube|
|Motivações|Passeear livremente com seu cão guia; pontualidade|
|Frustações| Ter corridas canceladas por ter cão guia|
|Hoobies| Sair com os amigos; escutar música|

|![Roberto Ferreira](https://user-images.githubusercontent.com/84281638/194554412-814791bd-1ce6-4580-a36b-05fec32c8ddd.png)|Roerto Ferreira|
---|---
|Idade| 45 anos|
|Estado civil| Divorciado|
|Ocupação|Fotografo profissional|
|Aplicativos| Facebook; linkedin|
|Motivações|Companhia do seu pet|
|Frustações| Não ter serviço específico para transporte com seu pet|
|Hoobies| Fotografia; filmes|


## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Fernanda Lopes |um aplicativo de corrida que aceite viagens com meu cachorro | mais lazer com meu cachorro |
|Fernanda Lopes     | ir para eventos com meu cachorro sem a necessidade de ir com meu própio carro |evitar longo tempo procurando lugares para estacionar |
|Renato Silva|mandar per para banho e tosa sem precisar estar presente|falta de tempo, pois trabalha e estuda|
|Renato Silva| conseguir acompanhar a viagem do pet|segurança quando solicitar um serviço de transporte para o pet|
|Carlos Nascimento| um transporte seguro para o pet (cão guia) que possa confiar|por ser cego, necessita de segurança para  se locomover com seu cão guia|
|Carlos Nascimento|passear com o pet para lugares mais distantes quando necessario|por não ter carro, as vezes fica impossibilitado de realizar determinados passeios|
|Renato Ferreira| mandar buscar o pet em casa|com um ptransporte seguro e de qualidade, possibilidade de mandar o pet sozinho|


## Modelagem do Processo de Negócio 

### Análise da Situação Atual

Apresente aqui os problemas existentes que viabilizam sua proposta. Apresente o modelo do sistema como ele funciona hoje. Caso sua proposta seja inovadora e não existam processos claramente definidos, apresente como as tarefas que o seu sistema pretende implementar são executadas atualmente, mesmo que não se utilize tecnologia computacional. 

### Descrição Geral da Proposta

Apresente aqui uma descrição da sua proposta abordando seus limites e suas ligações com as estratégias e objetivos do negócio. Apresente aqui as oportunidades de melhorias.

### Processo 1 – NOME DO PROCESSO

Apresente aqui o nome e as oportunidades de melhorias para o processo 1. Em seguida, apresente o modelo do processo 1, descrito no padrão BPMN. 

![Processo 1](img/02-bpmn-proc1.png)

### Processo 2 – NOME DO PROCESSO

Apresente aqui o nome e as oportunidades de melhorias para o processo 2. Em seguida, apresente o modelo do processo 2, descrito no padrão BPMN.

![Processo 2](img/02-bpmn-proc2.png)

## Indicadores de Desempenho

Apresente aqui os principais indicadores de desempenho e algumas metas para o processo. Atenção: as informações necessárias para gerar os indicadores devem estar contempladas no diagrama de classe. Colocar no mínimo 5 indicadores. 

Usar o seguinte modelo: 

![Indicadores de Desempenho](img/02-indic-desemp.png)
Obs.: todas as informações para gerar os indicadores devem estar no diagrama de classe a ser apresentado a posteriori. 

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto. Para determinar a prioridade de requisitos, aplicar uma técnica de priorização de requisitos e detalhar como a técnica foi aplicada.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| Criação de conta de usuário | ALTA | 
|RF-002| Login de conta   | ALTA |
|RF-003| Alterar conta   | ALTA |
|RF-004|Cadastro forma de pagamento   | ALTA |
|RF-005| Visualizar motoristas nas proximidades   |MÉDIA |
|RF-006|Simular preço de corrida  | ALTA |
|RF-007| Solicitar corrida   | ALTA |
|RF-008| Cancelar corrida  | ALTA |
|RF-009| Alertas sobre corrida solicitada  |BAIXA |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |
|-------|-------------------------|
|RNF-001| O sistema deve ser capaz de apresentar uma boa usabilidade para o usuário |
|RNF-002| O sistema deve ser capaz de tratar exceções e se recuperar de falhas sem que haja perda de dados |
|RNF-003| O sistema não pode demorar para processar as informações mais de 3 segundos |



## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| A aplicação deve se restringir às tecnologias solicitadas para os requsiitos do projeto|
|03| A equipe não pode subcontratar o desenvolvimento do trabalho|



## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

![image4](https://user-images.githubusercontent.com/84281638/194567411-a9783750-cf1c-4bda-ae5d-077761a58726.png)

Tabela dos atores e suas definições no diagrama de cados de uso:

|Ator|Definição|
|---|---|
|Tutor | Usuário que necessida de prestação de serviços automotivos|
|Motorista | Profissional da área automotiva|
|Administrador | Pessoa responsável por gerenciar o sistema, usuários e prestadores|


# Matriz de Rastreabilidade

A matriz de rastreabilidade é uma ferramenta usada para facilitar a visualização dos relacionamento entre requisitos e outros artefatos ou objetos, permitindo a rastreabilidade entre os requisitos e os objetivos de negócio. 


| |RF 01|RF 02|RF 03|RF 04|RF 05|RF 06|RF 07|RF 08|RF 09|
|---|:---:|:---:|:---:|:---:|:---:|:---:|:---:|:---:|:---:|
|RF 01| | | | | | | | | |
|RF 02|X| | | | | | | | |
|RF 03|X| | | | | | | | |
|RF 04| |X| | | | | | | |
|RF 05| | | | | | | | | |
|RF 06| | | |X| | | | | |
|RF 07| | | |X| | | | | |
|RF 08| | | | | | | | | |
|RF 09| | | | | | | | | |


# Gerenciamento de Projeto

De acordo com o PMBoK v6 as dez áreas que constituem os pilares para gerenciar projetos, e que caracterizam a multidisciplinaridade envolvida, são: Integração, Escopo, Cronograma (Tempo), Custos, Qualidade, Recursos, Comunicações, Riscos, Aquisições, Partes Interessadas. Para desenvolver projetos um profissional deve se preocupar em gerenciar todas essas dez áreas. Elas se complementam e se relacionam, de tal forma que não se deve apenas examinar uma área de forma estanque. É preciso considerar, por exemplo, que as áreas de Escopo, Cronograma e Custos estão muito relacionadas. Assim, se eu amplio o escopo de um projeto eu posso afetar seu cronograma e seus custos.

## Gerenciamento de Tempo

Com diagramas bem organizados que permitem gerenciar o tempo nos projetos, o gerente de projetos agenda e coordena tarefas dentro de um projeto para estimar o tempo necessário de conclusão.

O gráfico de Gantt ou diagrama de Gantt também é uma ferramenta visual utilizada para controlar e gerenciar o cronograma de atividades de um projeto. Com ele, é possível listar tudo que precisa ser feito para colocar o projeto em prática, dividir em atividades e estimar o tempo necessário para executá-las.
![image5](https://user-images.githubusercontent.com/84281638/194570928-4e12c07f-0990-4d6f-a906-c897991ab9f4.png)


## Gerenciamento de Equipe

O gerenciamento adequado de tarefas contribuirá para que o projeto alcance altos níveis de produtividade. Por isso, é fundamental que ocorra a gestão de tarefas e de pessoas, de modo que os times envolvidos no projeto possam ser facilmente gerenciados. 

![Simple Project Timeline](img/02-project-timeline.png)

## Gestão de Orçamento

O processo de determinar o orçamento do projeto é uma tarefa que depende, além dos produtos (saídas) dos processos anteriores do gerenciamento de custos, também de produtos oferecidos por outros processos de gerenciamento, como o escopo e o tempo.

![Orçamento](img/02-orcamento.png)




