import os
import re #RegEx
os.system('cls')

texto="Curso de Python do CFB Cursos, no canal do youtube"


pesquisa=input("Pesquisar: ")

res=re.search(pesquisa,texto)

print("Pesquisa: " + str(res))
print("texto")
if res:
    print("Texto encontrado")
    print("___________________________")
    #for r in res:
    pi=res.start()
    pf=res.end()
    tam=pf-pi
    print("Texto: " + str(res) + " - Posição: " + str(pi) + "-" + str(pf) + " - Tamanho: " + str(tam))
else: 
    print("texto não encntrado")