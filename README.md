# Command Pattern
Encapsular uma solicitação como um objeto, desta forma permitindo que clientes parametrizem diferentes solicitações 
 - http://en.wikipedia.org/wiki/Command_pattern!

# Classificação
 - http://en.wikipedia.org/wiki/Software_design_pattern

# Referências/Exemplos
 - http://amzn.to/1he63wd
 - http://www.csi.uneb.br/padroes_de_projetos/command_2.html

#Dojo
```
Problema: Cash Machine

#1: Operação de débito
    Dado que um caixa eletrônico pode gerenciar a conta/caixa de um cliente
    	E operações de "pagamentos" são realizadas diariamente
    Quando um pagamento for realizado
    Então deverá ser debitado da conta do cliente o valor informado 
 	E uma vez identificado que o mesmo não possui fundos(caixa < 0)deverá emitir notificacao para possível emprestimo

#2: Operação de Deposito
    Dado que um caixa eletrônico pode gerenciar a conta/caixa de um cliente
 	E operações de "Deposito" são realizadas diariamente
    Quando um deposito for processado
    Então deverá ser acrescido junto a conta do cliente o valor arrecadado
 	E uma vez identificado que o mesmo possui fundos(caixa > 5.000) deverá emitir notificacao para a possibilidade de investimentos

#3: Consultar o saldo!!
 	
```
