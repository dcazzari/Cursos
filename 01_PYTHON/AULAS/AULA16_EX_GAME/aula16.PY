import random
import os
erro=0
sorteado=random.randrange(0,100)
jogador=int(input("Digite seu numero:"))
while (sorteado != jogador):
    os.system('cls')
    if(sorteado>jogador):
        print("ERROUUUUUU, o numero é maior")
    elif(sorteado<jogador):
        print("ERROUUUUUU, o numero é menor")
    
    erro=erro+1
    
    jogador=int(input("Digite seu numero:"))

print("Parabéns!!! Você acertou o número "+str(jogador)+" em "+str(erro)+" tentativas")