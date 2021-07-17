import os
import json
os.system('cls')

#abertura do arquivo externo json
with open('C:/Users/TAMMY/Documents/00 CURSOS/04 PYTHON/AULAS/AULA29_JSON__FILE_READ/jogador.json') as f:
    jogador=json.load(f)

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


