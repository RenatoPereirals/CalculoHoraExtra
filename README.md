# Documentação do Software de Cálculo de Horas Extras (BSD)

## Introdução

Este documento descreve os requisitos, entidades e funcionalidades do software de cálculo de horas extras desenvolvido em Windows Forms. O objetivo principal do software é calcular horas extras com base em critérios pré-definidos, armazenando informações sobre usuários, trabalhadores e detalhes das horas trabalhadas.

### Requisitos do Sistema

- Sistema Operacional: Windows
- Framework: .NET
- Interface Gráfica: Windows Forms

## Entidades

### 1. User

#### Propriedades:

- **Id:** Chave primária auto incrementada.
- **FirstName:** Primeiro nome do usuário.
- **LastName:** Segundo nome do usuário.
- **Sector:** Sigla do setor do usuário.
- **UserName:** Combinação de FirstName e LastName (Exemplo: Renato.Silva).
- **Password:** Senha de acesso do usuário.

#### Funcionalidades:

- Cadastro e atualização de usuários.
- Apenas usuários cadastrados podem manipular as entidades.

### 2. Worker

#### Propriedades:

- **Matricula:** Chave primária, inserida manualmente.
- **DigitoMatricula:** Número de um caractere, inserido manualmente.
- **FullName:** Nome completo do trabalhador.

#### Funcionalidades:

- Cadastro e atualização de trabalhadores.
- Possibilidade de correção em caso de erro de digitação.

### 3. Bsd (Banco de Dados de Serviço)

#### Propriedades:

- **BsdId:** Chave primária, inserida manualmente.
- **Worker:** Referência a um objeto da classe Worker.
- **TipoDeDia:** Indica se o dia trabalhado é um feriado, dia de semana ou domingo.
- **DiaNormai:** Quantidade de dias normais trabalhados.
- **DiaFeriado:** Quantidade de dias feriados trabalhados.
- **DiaDomingo:** Quantidade de dias domingos trabalhados.
- **TotalDeDiasTrabalhados:** Calculado como a soma de DiasNormais, DiasFeriados e DiasDomingo.
- **DataBDS:** Data dos dias trabalhados.
- **HoraInicio:** Hora do início da atividade.
- **HoraFim:** Hora do fim da atividade.
- **Escala:** 03 para serviço da operação, 21 para serviço da guarda.
- **CodigoServico:** P110 (Operacional) ou P140 (Guarda).
- **CodigoDeHoraExtra:** Código que determina o tipo de hora extra, conforme critérios pré-definidos.

## Cálculo de Horas Extras

O cálculo de horas extras será realizado com base nas propriedades específicas da entidade Bsd. Os códigos de hora extra são atribuídos conforme a escala e tipo de serviço.

### Códigos de Hora Extra:

- **1913:** Refeição (2 horas por dias normais trabalhados).
- **1937:** A partir da 10ª hora (7 horas por domingos trabalhados).
- **1935:** Adicional noturno (11 horas por dia trabalhados, 12 horas se a escala for 03).
- **1902:** 3 horas por dia normal trabalhado.
- **1921:** 3 horas por feriado trabalhado.
- **1934:** Refeição em feriados (2 horas por feriado trabalhados).
- **1932:** 18 horas por feriado trabalhado.
- **1938:** 1 hora por feriado trabalhado.

## Considerações Finais

Este software proporciona uma solução eficiente para o cálculo de horas extras, considerando critérios específicos e armazenando dados relevantes sobre usuários, trabalhadores e horas trabalhadas. Para utilizar o sistema, é necessário cadastrar os usuários e trabalhadores, inserir os dados de horas trabalhadas na entidade Bsd e o software realizará automaticamente os cálculos necessários.

**Desenvolvido por:** Renato Pereira da Silva 
**Versão:** 1.0  



