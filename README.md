<h1 align="center">🌸 Floricultura</h1>

<p align="center"><b>Sistema de gerenciamento desenvolvido em C# Windows Forms conectado com Banco de Dados MySQL!</b></p>

---

## 📋🌸 Sobre o Projeto

Aplicação desktop desenvolvida como Projeto Final da disciplina de **Linguagens e Técnicas de Programação** (IFSULDEMINAS — Campus Machado, Prof. Matheus Franco). O objetivo do sistema é informatizar o atendimento, o controle de estoque de flores, o cadastro de clientes, o registro de pedidos e a emissão de relatórios de vendas de uma floricultura.

### 🌸Linguagens Utilizadas:
- C#
- SQL

### 🌸Ferramentas Utilizadas:
- Microsoft Visual Studio Community
- MySQL Server
- MySQL Workbench

### 🌸Funções do Software:
- Autenticação de usuário (Login conectado ao MySQL);
- Inserir, listar, buscar e alterar produtos (flores com foto e controle de estoque);
- Inserir e listar categorias de flores;
- Inserir, listar, buscar e alterar clientes (além de cadastro rápido na venda);
- Registrar pedidos com múltiplos itens no carrinho e baixa automática no estoque;
- Gerar relatórios de vendas filtrados por período e por categoria;

---

## ⚙️🌸 Instruções de Instalação e Execução

1. **Clone o repositório:**
   ```bash
   git clone https://github.com/Meillymi/FLORICULTURA-Projeto-CSharp.git
   ```
2. **Importe o Banco de Dados:**
   - Abra o **MySQL Workbench** e execute/importe o arquivo **`banco_floricultura.sql`** presente na pasta do projeto (ele cria o banco `banco_floricultura`, as 6 tabelas e as 16 *Stored Procedures*).
   - Caso precise criar um usuário de acesso ao sistema, execute:
     ```sql
     USE banco_floricultura;
     INSERT INTO usuario (nome, senha) VALUES ('admin', '1234');
     ```
3. **Configure a Conexão (`ConectaBanco.cs`):**
   - Abra a solução `.sln` no **Visual Studio** e ajuste `USER` e `PASSWORD` em `ConectaBanco.cs` de acordo com o seu MySQL local (verifique também se o pacote NuGet **`MySql.Data`** está restaurado).
4. **Execute o Aplicativo:**
   - Pressione **`F5`** no Visual Studio e entre com `admin` / `1234`.

---

## 📸🌸 Telas do Sistema

### Tela de Login:
<img width="489" height="572" alt="Captura de tela 2026-11-25 144950" src="https://github.com/user-attachments/assets/db7c3462-3a9e-41ee-8d10-21cefe36462a" />

### Tela de Menu Principal:
<img width="968" height="587" alt="Captura de tela 2026-11-25 145013" src="https://github.com/user-attachments/assets/25118fb4-97f7-487b-ad82-5fa8090af32f" />

### Tela de Produtos (Flores) e Categorias:
<img width="969" height="589" alt="Captura de tela 2026-11-25 145028" src="https://github.com/user-attachments/assets/299860c6-6db7-4310-96d7-032a570345a0" />

### Tela de Clientes:
<img width="966" height="584" alt="Captura de tela 2026-11-25 145038" src="https://github.com/user-attachments/assets/f0d85958-c422-4645-948d-20e714c9703e" />

### Tela de Pedidos:
<img width="970" height="593" alt="Captura de tela 2026-11-25 145052" src="https://github.com/user-attachments/assets/092772f5-c069-4822-a73c-1dd2a63d3e90" />

### Tela de Relatórios:
<img width="970" height="589" alt="Captura de tela 2026-11-25 145104" src="https://github.com/user-attachments/assets/7fdcbc69-905d-4aaf-ae77-e4c83bf6f706" />

### Banco de Dados (Diagrama ER):
<img width="981" height="789" alt="Captura de tela 2026-11-25 151953" src="https://github.com/user-attachments/assets/e75dc68a-25fe-4566-bdf0-3c988befa3c2" />

