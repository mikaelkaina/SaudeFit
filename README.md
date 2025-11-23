Projeto em andamento: SaudeFit – Plataforma de Bem-Estar Inteligente com .NET 9 e Blazor

Apresento meu mais recente projeto pessoal: SaudeFit, uma aplicação web completa desenvolvida com .NET 9, ASP.NET Core e Blazor, conectada a um banco de dados SQL Server.
O SaudeFit foi projetado para oferecer uma experiência prática e moderna de monitoramento de saúde e bem-estar, combinando análise de perfil, sugestões de exercícios e dicas de alimentação personalizada.

Principais funcionalidades:
Gestão de Perfil do Usuário – Criação e edição de perfil com informações de altura, peso e IMC.
Classificação Automática por Categoria de Peso – Abaixo do peso, peso normal, sobrepeso e obesidade.
Exercícios Sugeridos – 4 cards dinâmicos de treinos ajustados à categoria de peso, atualizados automaticamente a cada alteração de perfil.
Dicas de Alimentação Saudável – 4 cards com sugestões balanceadas (café da manhã, almoço, lanche e jantar), também adaptadas ao perfil do usuário.
Navegação Inteligente – Sistema de “Voltar” com detecção de contexto, garantindo retorno fluido à página correta.
Interface Responsiva e Moderna – Tema escuro, transições suaves, animações e feedbacks visuais.

Arquitetura e boas práticas aplicadas:
Estrutura em camadas com Controllers, Services, Interfaces e DTOs.
Consumo de API via HttpClient no Blazor.
Seed de dados automatizado via OnModelCreating para geração inicial de conteúdo no banco.
Padrões reutilizáveis e consistência entre os módulos de exercícios e alimentação.
Foco em UX e performance, com carregamento dinâmico e mensagens de status amigáveis.

Esse projeto foi uma excelente oportunidade para consolidar conceitos de Blazor Server, Entity Framework Core, injeção de dependência, navegação inteligente, 
e o uso das novidades do .NET 9 em um contexto prático e funcional. As abas de "meu progresso" e "configurações" irão ser continuadas.. Se tiverem sugestões, podem deixar nos comentários.
Tecnologias principais:
.NET 9 | ASP.NET Core | Blazor | Entity Framework Core | SQL Server | C# | HTML | CSS
SaudeFit demonstra como a combinação entre arquitetura limpa, usabilidade e recursos modernos do .NET pode resultar em uma aplicação fluida, modular e elegante.
