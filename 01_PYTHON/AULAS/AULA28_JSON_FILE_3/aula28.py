import json
import os
os.system('cls')

#objeto json
jogador_j='{"nome":"Daniel","time":"aviadores","energia":"True","mochila":["pederneira","corda","linha","arame"],"aeronaves":[{"tipo":"transporte","habilidade":80},{"tipo":"ataque","habilidade":100},{"tipo":"reconhecimento","habilidade":50}]}'

#carregar objeto json em variavel python
jogador=json.loads(jogador_j)

#carregar as chaves
for c in jogador:
    print(c)
print("____________________________________________________________")    

#carregar itens(keys and values)
for i in jogador.items():
    print(i)
print("____________________________________________________________")

#carregar values
for v in jogador.values():
    print(v)
print("____________________________________________________________")

#carregar valor de uma chave
print(jogador["nome"])#carrega o valor da chave nome
print(jogador["time"])#carrega o valor da chave time
print(jogador["mochila"])#carrega o valor da chave nome
print("____________________________________________________________")

#carregar itens da chave mochila, seu valor é uma list
for im in jogador["mochila"]:
    print(im)
print("____________________________________________________________")

#carregar itens da chave aeronave, seu valor é um json
for a in jogador["aeronaves"]:
    print(a["tipo"] + " - " + str(a["habilidade"]))
print("____________________________________________________________")



