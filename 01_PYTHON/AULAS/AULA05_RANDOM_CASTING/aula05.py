import random #importando a classe random

num_i=10
num_f=5.2
num_c=1j
num_r=[ #List/Array de seis psiçoes que recebe valores aleatórios de a 0 60
    random.randrange(0,60), 
    random.randrange(0,60),
    random.randrange(0,60),
    random.randrange(0,60),
    random.randrange(0,60),
    random.randrange(0,60)
]

x=(num_r)#realizando esse casting a variável x recebera o valor inteiro de num_f

print("Valor da posição 1: " + str(x[0]) + " - Tipo = " + str(type(x[0])))
print("Valor da posição 2: " + str(x[1]) + " - Tipo = " + str(type(x[1])))
print("Valor da posição 3: " + str(x[2]) + " - Tipo = " + str(type(x[2])))
print("Valor da posição 4: " + str(x[3]) + " - Tipo = " + str(type(x[3])))
print("Valor da posição 5: " + str(x[4]) + " - Tipo = " + str(type(x[4])))
print("Valor da posição 6: " + str(x[5]) + " - Tipo = " + str(type(x[5])))