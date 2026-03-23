# 🧠 Aula: Arquiteturas Assíncronas e Event-Driven

📅 **Data**: 21/07/2025
⏱️ **Duração**: 2 horas
🎯 **Público-alvo**: Desenvolvedores, arquitetos de software, estudantes avançados
📌 **Objetivo**: Compreender os conceitos, padrões e práticas de arquiteturas baseadas em eventos e assíncronas, com foco em **escalabilidade**, **resiliência** e **casos aplicados a seguradoras**.

---

## 📋 Estrutura da Aula

---

![alt text](/Documentação/Imagens/Events.png)

### 1. Abertura e Contextualização (10 min)

**Objetivo:** Apresentar o tema e engajar os participantes.
**Contexto:**

* Processos típicos de uma seguradora são **naturalmente assíncronos** (cotação, sinistro, antifraude, emissão).
* Forte necessidade de **integração com terceiros** (SUSEP, Detran, Corretores, Assinatura Digital).

**Tópicos abordados:**

* Diferença entre arquitetura **síncrona vs assíncrona**
* Onde **arquiteturas orientadas a eventos** se aplicam bem

**🎯 Pergunta disparadora:**

> "Quais etapas de um processo de seguro (auto, saúde, residencial) você acredita que poderiam ser executadas de forma assíncrona ou por eventos?"

---

### 2. Event-Driven Architecture (30 min)

**Objetivo:** Entender os principais conceitos e componentes de EDA.
**Tópicos:**

* O que é Event-Driven Architecture (EDA)
* Componentes: Producers, Consumers, Event Bus/Broker, Event Store
* Tipos de eventos: **evento de fato**, **comando**, **evento de integração**
* Modelos: **Pub/Sub**, **Event Sourcing**, **CQRS**

**🔍 Exemplo aplicado (Seguradora - Cotação Auto):**

* **Produtor:** Portal Web → envia `cotacao.solicitada`
* **Broker:** Kafka (tópico `cotacao.request`)
* **Consumidores:**

  * Cálculo de prêmio
  * Análise de perfil
  * Módulo antifraude
* Geração do evento `cotacao.gerada` → envia proposta

**🛠️ Atividade em grupo:**

> Desenhar uma arquitetura EDA para emissão de **seguro de vida ou residencial**, com:
>
> * Eventos: `proposta.recebida`, `validacao.sucesso`, `assinatura.finalizada`
> * Serviços produtores e consumidores

---

### 3. Padrões para Sistemas Distribuídos (30 min)

**Objetivo:** Apresentar padrões que ajudam no design de sistemas assíncronos.
**Tópicos:**

* Message Broker (Kafka, RabbitMQ, SQS)
* **Message Queue vs Event Stream**
* **Retry & Dead Letter Queue (DLQ)**
* **Idempotência**
* **Saga Pattern**: Orquestração vs Coreografia
* **Circuit Breaker & Bulkhead**
* **Consistência eventual**

**📘 Exemplo aplicado (Seguradora - Cancelamento de Apólice):**

* Etapas:

  1. Registro do cancelamento
  2. Notificação à contabilidade
  3. Estorno da comissão
* Cada serviço escuta o evento anterior (**coreografia**)

**⚖️ Atividade - Debate orientado:**

> "Se um cliente inicia uma proposta de seguro, mas não conclui a assinatura digital, como lidamos com esse processo assíncrono? Orquestração ou coreografia?"

---

### 4. Escalabilidade e Resiliência (30 min)

**Objetivo:** Discutir como EDA ajuda a escalar e manter a resiliência do sistema.
**Tópicos:**

* **Escalabilidade horizontal** e desacoplamento
* **Backpressure** e gerenciamento de fila
* **Auto-scaling** com base no consumo de mensagens
* **Failover** e tolerância a falhas
* **Observabilidade**: tracing distribuído, logs centralizados

**🔍 Exemplo aplicado (Seguradora):**

* Campanhas de cotação em massa → filas com auto-scaling
* Sistema de assinatura digital fora do ar → eventos ficam na fila
* Retry & DLQ para envio de SMS, email, integrações externas
* Tracing do fluxo: `sinistro.avisado` → `vistoria.concluida` → `indenizacao.paga`

**🧪 Estudo de caso sugerido:**

> "Como uma seguradora pode usar EDA para processar **sinistros** de forma **escalável e resiliente**?"

---

### 5. Encerramento e Discussão (20 min)

**Objetivo:** Reforçar o aprendizado, tirar dúvidas e incentivar aprofundamento.

**📊 Atividades:**

* **Quiz rápido** (via Kahoot ou similar)
  Exemplos de perguntas:

  * Qual a diferença entre evento e comando?
  * Quando o assíncrono pode prejudicar a experiência do usuário?
  * Papel do broker em EDA?

* **Espaço para perguntas**

**📚 Leituras e ferramentas recomendadas (Seguradoras):**

* Livros:

  * “Enterprise Integration Patterns” – Gregor Hohpe
  * “Event-Driven Microservices” – Chris Richardson
  * “Microservices Patterns” – Chris Richardson

* Ferramentas úteis:

  * Kafka, Kafka Streams
  * AWS SNS/SQS
  * **Temporal.io** (workflow de sinistro, emissão, renovação)

---

## 🧰 Recursos e Materiais

* Slides com diagramas e exemplos
* Ferramentas: [draw.io](https://draw.io), [Miro](https://miro.com) para atividades visuais em grupo
* Ambiente com `docker-compose` (Kafka, RabbitMQ, etc.)
* Demos online: [Confluent Cloud](https://developer.confluent.io/)
* Simuladores ou flows usando Temporal, Camunda ou AWS Step Functions (se desejar aprofundar em workflow)


https://learn.microsoft.com/en-us/azure/architecture/guide/architecture-styles/event-driven



---
  > © MoOngy 2026 | Este repositório é parte do programa de formação contínua em Engenharia de Software.
