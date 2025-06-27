# 🧼 MySoapService - Serviço WCF com SOAP em .NET

Este projeto demonstra a criação de um serviço WCF (Windows Communication Foundation) utilizando o protocolo SOAP com dois endpoints principais: um para **validação de dados (Email, CPF e CNPJ)** e outro para **busca de informações de pessoas e empresas (Mock)**.

---

## 📚 Descrição do Projeto

O projeto consiste em um serviço WCF auto-hospedado via `ServiceHost`, que expõe dois contratos de serviço:

- `IValidationService`: para validação de e-mails, CPF e CNPJ
- `ISearchService`: para busca de dados de pessoas e empresas com base em e-mail ou documentos

Além disso, são implementados 2 clientes diferentes que irão consumir esses serviços:
- `Generated`: gerado automaticamente via Visual Studio por meio de uma referência aos serviços conectados (utiliza `svcutil`).
- `Manual`: criado manualmente e consumido via `ChannelFactory<T>`.

Por fim, o serviço também conta com o endpoint especial `http://localhost:8080/MySoapService?wsdl`, que irá fornecer o WSDL (Web Services Description Language), um arquivo XML que descreve:
- As operações disponíveis nos serviços (Search, Validation)
- Os tipos de dados usados nas mensagens (como PersonResponse, CompanyResponse)
- Os tipos de falhas usadas no serviço em casos de erro (como PersonNotFoundFault, CompanyNotFoundFault)
- Os bindings e endereços necessários para que um cliente possa consumir o serviço

Ele serve para que:
- Permita que ferramentas de terceiros como SoapUI, Postman (modo SOAP) ou Visual Studio descubram e integrem automaticamente o serviço.
- Pode ser usado para gerar clientes automaticamente via svcutil, Add Service Reference ou dotnet-svcutil.

---

## 🔌 Endpoints SOAP

Os serviços SOAP estão disponíveis nos seguintes endpoints:

| Interface              | URL                                      |
|------------------------|-------------------------------------------|
| `IValidationService`   | `http://localhost:8080/MySoapService/Validation` |
| `ISearchService`       | `http://localhost:8080/MySoapService/Search`     |

---

## 💡 Funcionalidades

### 🔍 Busca (Search)
- Buscar pessoa por e-mail
- Buscar pessoa por CPF
- Buscar empresa por e-mail
- Buscar empresa por CNPJ

### ✅ Validação (Validation)
- Validar e-mail
- Validar CPF
- Validar CNPJ
---

## ▶️ Como executar

1. Compile o projeto com `dotnet build`
2. Execute com `dotnet run` (ou direto pela IDE)
3. O serviço será iniciado em: `http://localhost:8080/MySoapService/`
4. As chamadas serão feitas diretamente no console