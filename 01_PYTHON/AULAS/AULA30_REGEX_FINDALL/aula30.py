import os
import re #RegEx
os.system('cls')

texto="Curso de Python do CFB Cursos, no canal do youtube"


pesquisa=input("Pesquisar: ")

res=re.findall(pesquisa,texto)
qtde=len(res)
print(res)
print("Qtde: " + str(qtde))

for t in texto:
    print(t)