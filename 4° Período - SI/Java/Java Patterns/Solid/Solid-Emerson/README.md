# 🧩 SolidSrpViolation_LP3

Projeto desenvolvido para demonstrar **uma violação do Princípio da Responsabilidade Única (SRP)**, um dos cinco princípios do **SOLID**.  
Faz parte da disciplina **Linguagem de Programação III** e exemplifica como a mistura de responsabilidades em uma única classe pode tornar o código mais difícil de manter, testar e evoluir.

---

## 📚 Sobre o Projeto

O projeto simula um pequeno sistema de **faturamento (Invoice)** com envio de e-mails e formatação de dados.  
Ele **viola o princípio SRP**, pois a classe principal assume múltiplas responsabilidades:

- Cálculo e gerenciamento de uma fatura (`Invoice`)
- Formatação e exibição dos dados (`InvoiceFormatter`)
- Envio de e-mails (`EmailService`)

Essas ações deveriam ser separadas em classes com **uma única razão para mudar**, mas aqui estão misturadas de propósito para fins didáticos.

---

## 🧠 Conceito de SRP (Single Responsibility Principle)

> “Uma classe deve ter apenas uma única razão para mudar.”

Em outras palavras, **cada classe deve ter apenas uma responsabilidade bem definida**.  
A violação ocorre quando uma classe acumula várias funções, como lógica de negócio, persistência de dados e apresentação.

