import os
os.system('cls')
carros=[]
carro=input("Digite o nome do novo carro ou -1 para finalizar:")
while carro != "-1":
    carros.append(carro)
    carro=input("Digite o nome do novo carro ou -1 para finalizar:")
os.system('cls')
for x in carros:
    print(x)    
