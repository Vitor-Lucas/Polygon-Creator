# Polygon Creator

Uma aplicação desktop para criação interativa de polígonos, desenvolvida em C# com Windows Forms.

## 📋 Descrição

O **Polygon Creator** é uma ferramenta de desenho geométrico que permite ao usuário criar polígonos de forma interativa. Basta clicar na tela para adicionar vértices: a aplicação conecta automaticamente os pontos com linhas, formando as arestas do polígono. Um preview em tempo real exibe a próxima aresta enquanto o mouse se move, facilitando o posicionamento dos vértices.

## 🚀 Funcionalidades

- **Criação interativa de polígonos** – Clique em qualquer ponto da tela para adicionar vértices.
- **Preview em tempo real** – Uma linha de pré-visualização acompanha o cursor do mouse, mostrando onde a próxima aresta será desenhada.
- **Histórico de linhas** – Todas as arestas desenhadas são mantidas e redesenhadas automaticamente.
- **Botão de reset** – Limpa todo o canvas, permitindo começar um novo polígono do zero.

## 🛠️ Tecnologias

| Tecnologia       | Versão        |
|------------------|---------------|
| Linguagem        | C#            |
| Framework        | .NET Framework 4.7.2 |
| Interface gráfica | Windows Forms |
| IDE recomendada  | Visual Studio 2022 |

## 📦 Pré-requisitos

- **Windows** (a aplicação utiliza Windows Forms)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) **ou** [.NET Framework 4.7.2 Developer Pack](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net472)

## ⚙️ Como compilar e executar

### Usando o Visual Studio

1. Clone o repositório:
   ```bash
   git clone https://github.com/Vitor-Lucas/Polygon-Creator.git
   ```
2. Abra o arquivo de solução `Polygon Creator/Polygon Creator.sln` no Visual Studio.
3. Pressione **F5** para compilar e executar em modo Debug, ou **Ctrl+Shift+B** para apenas compilar.

### Usando o MSBuild (linha de comando)

```bash
# Na raiz do repositório (use aspas por causa do espaço no nome do diretório)
msbuild "Polygon Creator/Polygon Creator.sln" /p:Configuration=Release
```

O executável gerado ficará em:
```
Polygon Creator/bin/Release/Polygon Creator.exe
```

## 🎮 Como usar

1. **Inicie a aplicação.**
2. **Clique** em qualquer ponto do canvas para posicionar o primeiro vértice.
3. **Clique novamente** para adicionar o segundo vértice – uma aresta será desenhada entre os dois pontos.
4. **Continue clicando** para adicionar mais vértices e construir o polígono.
5. **Mova o mouse** entre os cliques para ver um preview da próxima aresta.
6. **Clique em "Reset"** para limpar o canvas e começar um novo polígono.

## 🗂️ Estrutura do projeto

```
Polygon Creator/
├── Program.cs              # Ponto de entrada da aplicação
├── Form1.cs                # Lógica principal: eventos de mouse e desenho
├── Form1.Designer.cs       # Código gerado automaticamente pelo designer do VS
├── Form1.resx              # Arquivo de recursos do formulário
├── Polygon Creator.csproj  # Configuração do projeto C#
├── Polygon Creator.sln     # Arquivo de solução do Visual Studio
├── App.config              # Configurações de runtime
└── Properties/
    ├── AssemblyInfo.cs     # Metadados do assembly
    ├── Resources.resx      # Recursos globais
    └── Settings.settings   # Configurações do usuário
```

### Principais classes

| Classe / Arquivo | Responsabilidade |
|------------------|-----------------|
| `Program`        | Inicializa o runtime do WinForms e abre o `Form1`. |
| `Form1`          | Gerencia o canvas, captura eventos de mouse e coordena o desenho das arestas. |
| `Line`           | Representa uma aresta do polígono (dois pontos `p1` e `p2`) e expõe o método `Draw`. |

## 🤝 Contribuindo

Contribuições são bem-vindas! Para contribuir:

1. Faça um *fork* do repositório.
2. Crie uma *branch* para a sua feature: `git checkout -b minha-feature`.
3. Commit suas alterações: `git commit -m 'Adiciona minha feature'`.
4. Faça o *push* para a branch: `git push origin minha-feature`.
5. Abra um *Pull Request*.

## 📄 Licença

Este projeto está disponível como código aberto. Consulte o repositório para verificar a licença aplicável.
