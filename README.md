\# ecommerce-checkout-xunit



Solução .NET 10 para cálculo de cupons, itens e frete de uma loja online, com testes unitários em xUnit. Atividade da disciplina Gestão e Qualidade de Software.



\## Estrutura



\- `EcommerceCheckout.App`: código de produção (classe `PedidoService`)

\- `EcommerceCheckout.Tests`: testes unitários (classe `PedidoServiceTests`)



\## Métodos



| Método | Retorno | Regra |

|---|---|---|

| `GerarCodigoRastreio(string regiao, int numeroPedido)` | `string` | Região em maiúsculas + número do pedido com 4 dígitos. Ex.: `"sudeste"`, `42` → `"SUDESTE-0042"` |

| `CalcularPontosFidelidade(int valorTotal)` | `int` | 2 pontos a cada R$ 10 em compras. Ex.: `150` → `30` |

| `TemDireitoAFreteGratis(int valorTotal, bool eClienteVIP)` | `bool` | Frete grátis se o valor for maior ou igual a R$ 200 ou se o cliente for VIP |



\## Cobertura dos testes



| Teste | Asserção | Cenário |

|---|---|---|

| `GerarCodigoRastreio\_DeveRetornarMascaraExata` | `Assert.Equal` | `"sudeste"` e `42` retornam `"SUDESTE-0042"` |

| `CalcularPontosFidelidade\_DeveRetornar30ParaCompraDe150` | `Assert.Equal` | `150` retorna `30` |

| `TemDireitoAFreteGratis\_ClienteVipAbaixoDe200\_DeveRetornarTrue` | `Assert.True` | Cliente VIP com compra de R$ 150 |

| `TemDireitoAFreteGratis\_NaoVipAbaixoDe200\_DeveRetornarFalse` | `Assert.False` | Cliente não VIP com compra de R$ 150 |



Os três métodos da classe `PedidoService` são cobertos pelos quatro testes.



\## Como executar



Requisito: .NET 10 SDK.



```bash

git clone https://github.com/Albano-de-Souza/ecommerce-checkout-xunit.git

cd ecommerce-checkout-xunit

dotnet test

```



\## Licença



MIT

