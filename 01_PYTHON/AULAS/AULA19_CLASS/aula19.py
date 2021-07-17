import os
os.system('cls')

class Carro:
    velMax=0
    ligado=False
    cor=""
    def __init__(self,v,l,c):
        self.velMax=v
        self.ligado=l
        self.cor=c
    def Mostrar(self):
        print("Velocidade Máxima.: " + str(self.velMax))
        print("Cor...............: " + self.cor)
        estado="Sim" if self.ligado else "Não"
        print("Ligado............: " + estado)
        print("_____________________________________")
    def Ligar(self):
        self.ligado=True
    def Desligar(self):
        self.ligado=False


c1=Carro(200,False,"Preto")
c2=Carro(120,False,"branco")
c3=Carro(180,True,"cinza")

c1.Mostrar()
c2.Mostrar()
c3.Mostrar()
