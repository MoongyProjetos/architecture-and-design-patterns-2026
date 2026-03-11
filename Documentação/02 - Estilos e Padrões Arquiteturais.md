# Estilos e Padrões Arquiteturais

## Introdução à programação orientada a objetos

![alt text](Diagramas/IntroducaoOOP.drawio.png)

A programação orientada a objetos permite modelar **entidades do mundo real** como objetos no sistema.

No contexto de uma **plataforma de delivery**, podemos ter objetos como:

* `Cliente`
* `Restaurante`
* `Pedido`
* `Entregador`
* `Pagamento`

Cada objeto possui:

* **Estado** (dados)
* **Comportamento** (métodos)
* **Responsabilidades bem definidas**

---

# FoodNow 🚚

*(Plataforma de Delivery Online)*

## 🏛 História e Evolução

A **FoodNow** é uma das maiores plataformas de delivery da web, fundada em **2020** com o objetivo de conectar **clientes, restaurantes e entregadores** em uma única plataforma digital.

Inicialmente operava apenas em uma cidade, permitindo que restaurantes locais oferecessem entrega através de um aplicativo simples. Com o crescimento da procura por entregas durante os anos seguintes, a empresa expandiu rapidamente.

Em **2024**, a plataforma foi adquirida pelo conglomerado internacional **Zuquinha International**, permitindo a expansão para diversos países da Europa e África.

Hoje a FoodNow processa **milhões de pedidos por mês**, conectando milhares de restaurantes e entregadores.

---

## 🌍 Presença Internacional

A **FoodNow** opera atualmente em vários países:

* Portugal
* Espanha
* França
* Luxemburgo
* Angola
* Moçambique
* Cabo Verde

Cada país possui integração com **restaurantes locais, sistemas de pagamento e logística de entregadores**.

---

## 💼 Produtos e Serviços

A plataforma oferece vários serviços digitais:

* **Delivery de refeições**
* **Pickup no restaurante**
* **Agendamento de pedidos**
* **Entrega expressa**
* **Sistema de avaliação de restaurantes**
* **Rastreamento do pedido em tempo real**

Além disso, inclui funcionalidades como:

* **FoodNow Premium** (entregas grátis)
* **FoodNow Business** (para empresas)
* **FoodNow Market** (entrega de supermercado)

---

## 🍔 Marca e Simbolismo

O nome **FoodNow** reflete a promessa principal da plataforma:

> “Receber comida rapidamente, em qualquer lugar.”

A marca está associada a:

* rapidez
* conveniência
* tecnologia
* experiência do usuário

---

## 🌱 Responsabilidade Social

A **FoodNow** possui iniciativas de sustentabilidade, incluindo:

* otimização de rotas para reduzir emissões
* incentivo ao uso de **bicicletas elétricas**
* parceria com restaurantes para **redução de desperdício alimentar**
* programas de apoio a pequenos restaurantes locais

---

# 🏛️ Princípios de boa arquitetura de software

Esses princípios ajudam a construir sistemas **escaláveis, fáceis de manter e evoluir**, especialmente em plataformas complexas como um sistema de delivery.

---

## 🔹 1. Coesão

**Definição:** Mede o quão bem os elementos dentro de um módulo estão relacionados entre si.

Alta coesão significa que um componente tem **uma responsabilidade clara**.

### Exemplo

Uma classe `DeliveryPriceCalculator` deveria **apenas calcular o valor da entrega**.

Se ela também:

* envia notificações
* atualiza estado do pedido
* grava logs

então possui **baixa coesão**.

---

## 🔹 2. Acoplamento

**Definição:** Grau de dependência entre módulos.

Em uma plataforma de delivery existem vários componentes:

* gestão de pedidos
* pagamentos
* notificações
* logística

Se o módulo de **Pedidos** depende diretamente do módulo de **Pagamentos**, qualquer mudança pode quebrar o sistema.

### Boas práticas

* usar interfaces
* usar injeção de dependência
* separar contratos e implementações

---

## 🔹 3. Separação de Responsabilidades (SRP)

Cada classe deve ter **uma única responsabilidade**.

### Exemplo ruim

Um `OrderController` que:

* cria pedidos
* calcula preço
* processa pagamento
* envia notificações

### Melhor abordagem

Separar em serviços:

* `OrderService`
* `PaymentService`
* `NotificationService`
* `DeliveryService`

---

## 🔹 4. Princípio Aberto/Fechado (OCP)

Um sistema deve estar **aberto para extensão e fechado para modificação**.

### Exemplo

Imagine que o sistema suporta diferentes tipos de entrega:

* bicicleta
* carro
* drone

Ao invés de alterar código existente, podemos adicionar novas estratégias de cálculo de entrega usando **Strategy Pattern**.

---

## 🔹 5. Inversão de Dependência (DIP)

Módulos de alto nível não devem depender de implementações concretas.

### Exemplo

Em vez de:

```csharp
var payment = new StripePayment();
```

o sistema deve depender de uma abstração:

```csharp
IPaymentService
```

Assim podemos trocar facilmente:

* Stripe
* PayPal
* MBWay
* Apple Pay

---

## 🔹 6. Encapsulamento

Cada objeto deve esconder sua implementação interna.

### Exemplo

O objeto `Order` pode controlar suas mudanças de estado:

```text
Created → Preparing → Ready → Delivering → Delivered
```

Outras partes do sistema não devem manipular diretamente esses estados.

---

## 🔹 7. Princípio da Substituição de Liskov

Subtipos devem poder substituir o tipo base sem quebrar o comportamento.

### Exemplo

Se temos:

```
DeliveryVehicle
```

Podemos ter:

```
Bike
Car
Scooter
```

Todos devem funcionar corretamente quando usados como `DeliveryVehicle`.

---

## 🔹 8. DRY (Don't Repeat Yourself)

Evitar duplicação de lógica.

### Exemplo

Se vários módulos calculam a taxa de entrega:

* OrderService
* CheckoutService
* DeliveryService

Isso gera inconsistência.

A solução é centralizar essa lógica em:

```
DeliveryPricingService
```

---

## 🔹 9. YAGNI (You Ain’t Gonna Need It)

Evitar implementar funcionalidades antes de serem necessárias.

Exemplo:

Criar suporte a **entrega por drones** antes de existir essa operação real.

---

## 🔹 10. KISS (Keep It Simple)

Soluções simples são mais fáceis de manter.

Em um sistema de delivery, uma solução simples pode ser:

* serviços claros
* APIs bem definidas
* responsabilidades separadas

---

# 🏛️ Estilos e Padrões Arquiteturais

## 📐 O que são?

### Estilos arquiteturais

Definem **a organização geral do sistema**.

Exemplos:

* Monolítico
* Microservices
* Event-Driven
* Serverless

---

### Padrões arquiteturais

São **soluções reutilizáveis para problemas comuns na arquitetura**.

Exemplos:

* MVC
* MVP
* MVVM
* CQRS

---

# 🔁 Padrões Arquiteturais Clássicos

| Padrão | Objetivo                   | Quando usar        | Exemplo na FoodNow    |
| ------ | -------------------------- | ------------------ | --------------------- |
| MVC    | Separar UI, lógica e dados | aplicações web     | API de pedidos        |
| MVP    | Desacoplar UI              | aplicações desktop | painel administrativo |
| MVVM   | Data binding               | mobile apps        | aplicativo do cliente |

---

# ⚖️ Comparação entre os padrões

| Aspecto       | MVC    | MVP       | MVVM              |
| ------------- | ------ | --------- | ----------------- |
| Acoplamento   | Médio  | Baixo     | Muito baixo       |
| Testabilidade | Boa    | Excelente | Excelente         |
| Data Binding  | Manual | Manual    | Automático        |
| Uso comum     | Web    | Desktop   | Mobile / Frontend |

---

# 📌 Discussão de Casos Reais

## Caso 1 — Web API de pedidos

Backend em **ASP.NET Core** usando MVC.

Responsabilidades:

* `OrderController`
* `OrderService`
* `OrderRepository`

Benefícios:

* separação clara de responsabilidades
* fácil manutenção
* integração simples com apps mobile

---

## Caso 2 — Aplicativo Mobile do cliente

Aplicativo mobile que permite:

* buscar restaurantes
* fazer pedidos
* acompanhar entrega

Arquitetura:

**MVVM**

* **View:** telas do aplicativo
* **ViewModel:** lógica da interface
* **Model:** pedidos, restaurantes, pagamentos

---

## Caso 3 — Painel de gestão de restaurantes

Interface usada por restaurantes para:

* aceitar pedidos
* atualizar status
* gerenciar cardápio

Arquitetura:

**MVP**

O Presenter controla a lógica da interface e comunica com os serviços do backend.

---

# 🧠 Dica prática

No contexto de uma plataforma de delivery:

* **MVC** é ideal para APIs backend
* **MVVM** funciona muito bem para apps mobile
* **MVP** pode ser útil em interfaces administrativas


---
> © MoOngy 2026 | Este repositório é parte do programa de formação contínua em Engenharia de Software.
