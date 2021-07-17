import datetime
import os
os.system('cls')

date=datetime.datetime.now()
nasc=str(datetime.datetime(1992,3,26))

print(str(date.day) + "/" + str(date.month) + "/" + str(date.year))
print(nasc[8:10]+ "/" +nasc[5:7]+ "/" +nasc[0:4])

print(date.strftime("%A"))#%A - retorna dia da semana completo
print(date.strftime("%a"))#%a - retorna dia da semana resumido
print(date.strftime("%w"))#%a - retorna dia em numero, ex: domingo igual a zero
print(date.strftime("%d"))#%d - retorna dia do mês
print(date.strftime("%b"))#%b - retorna nome do mês resumido
print(date.strftime("%B"))#%B - retorna nome do mês completo
print(date.strftime("%m"))#%m - retorna numero do mês completo
print(date.strftime("%y"))#%y - retorna ano com 2 digitos
print(date.strftime("%Y"))#%Y - retorna ano com 4 digitos
print(date.strftime("%H"))#%H - retorna hora com 2 digitos - 00 a 23
print(date.strftime("%I"))#%I - retorna hora com 2 digitos - 00 a 12
print(date.strftime("%p"))#%p - retorna am/pm
print(date.strftime("%M"))#%M - retorna minutos com 2 digitos
print(date.strftime("%S"))#%S - retorna segundos com 2 digitos
print(date.strftime("%f"))#%f - retorna micro-segundos com 6 digitos
print(date.strftime("%j"))#%j - retorna dia do ano 001 - 366
print(date.strftime("%W"))#%W - retorna numero da semana no ano
