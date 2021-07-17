import os
import re #RegEx
os.system('cls')

texto="Curso de Python do CFB Cursos, no canal do youtube"

# metodo sub realiza o replace.

res=re.sub("\s","-",texto)

print(res)
