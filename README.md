O que o SaudeFit faz:

Gestão de Perfil do Usuário — criação e edição de perfil com altura, peso e idade.

Cálculo e Classificação de IMC — cálculo automático do IMC (Índice de Massa Corporal) e classificação por categoria: Abaixo do peso, Peso normal, Sobrepeso, Obesidade.

Exercícios Sugeridos — 4 cards dinâmicos de treinos por categoria de peso; recomendações atualizam automaticamente quando o perfil é alterado.

Dicas de Alimentação Saudável — 4 cards de sugestões (café da manhã, almoço, lanche, jantar) adaptadas à categoria do usuário.

Autenticação e Segurança — registro, login e logout com JWT/cookies e gerenciamento de estado no cliente (AuthStateProvider).

Arquitetura — camadas separadas (Domain, Application, Infrastructure, API, UI), DTOs, services e controllers — tudo organizado para facilitar evolução e testes.

Experiência do usuário:

Usuário se registra e faz login.
Cria/edita perfil (altura, peso, idade). O sistema calcula IMC e classifica automaticamente.
Dashboard mostra cards com ações (Meu Perfil, Exercícios, Nutrição, Evolução etc.).
Página “Exercícios Sugeridos” e “Nutrição” consomem o perfil e mostram recomendações adaptadas. 


<img width="1919" height="1039" alt="Captura de tela 2026-03-01 133237" src="https://github.com/user-attachments/assets/62a87774-a18e-4288-937a-9f70254d873e" />


<img width="1919" height="1079" alt="Captura de tela 2026-03-01 133136" src="https://github.com/user-attachments/assets/c1923230-6783-44dc-9be1-5bb54af8f8bb" />


<img width="1919" height="1049" alt="Captura de tela 2026-03-01 133202" src="https://github.com/user-attachments/assets/cddc81da-f0a9-45fc-a4a0-96c68076a61b" />



