import json
import os
os.system('cls')


carros_json='{"marca":"honda","modelo":"civic","cor":"prata"}'

carros=json.loads(carros_json)#carrega o conteúdo json na variavel carros, carros ficara como dictionary

print(carros)

for k,v in carros.items():
    print(k,v)

print(carros)

for k in carros.keys():
    print(k)

print(carros)

for v in carros.values():
    print(v)


carros_json=json.dumps(carros)#carrego a variavel carros_json com conteudo da dictionary carros, agora posso gerar arquivo json. 
print(carros_json)