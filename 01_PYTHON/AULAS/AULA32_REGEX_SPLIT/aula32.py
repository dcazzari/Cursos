import os
import re #RegEx
os.system('cls')

texto="Curso de Python do CFB Cursos, no canal do youtube"

# metodo split retorna lista com a divisão do texto a partir do parametro passado, 
# no exemplo abaixo ele dividira o texto a partir do espaços.

res=re.split("\s",texto)#\s = espaço

print(res)
