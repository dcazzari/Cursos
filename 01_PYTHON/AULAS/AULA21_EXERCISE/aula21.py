import os
os.system('cls')
carros=[]

class Carro:
    nome=""
    pot=0
    velMax=0
    ligado=False
    def __init__(self, nome, pot):
        self.nome=nome
        self.pot=pot
        self.velMax=int(pot*2)
        self.ligado=False

    def Ligar(self):
        self.ligado=True

    def Desligar(self):
        self.ligado=False

    def Info(self):
        print("Nome...............:" + str(self.nome))
        print("Potência...........:" + str(self.pot))
        print("Velocidade Máxima..:" + str(self.nome))
        print("Liagdo.............:" + ("sim" if self.ligado==True else "não"))
        
def Menu():
    os.system('cls')
    print("1 - Cadastrar novo carro")
    print("2 - Informações do carro")
    print("3 - Excluir carro cadastrado")
    print("4 - Ligar carro")
    print("5 - Desligar carro")
    print("6 - Listar carros cadastrados")
    print("7 - Sair")
    print("Total de carrro cadastrados no sistema: "+str(len(carros)))
    opc=input("Escolha uma opção do menu acima:")
    return opc

def NovoCarro():
    os.system('cls')
    n=input("Nome do carro.........:")
    p=input("Potência do carro.....:")
    car=Carro(n,p)
    carros.append(car)
    print("Novo carro incluido na base")
    os.system('pause')

def Informacoes():
    os.system('cls')
    n=input("Informe o carro.....:")
    try:
        carros[int(n)].Info()
    except:
        print("Carro não localizado na base")
    os.system('pause')    

def ExcluirCarro():
    os.system('cls')
    n=input("Informe o carro.....:")
    try:
        del carros[int(n)]
    except:
        print("Carro não localizado na base")
    os.system('pause')    


def LigarCarro():
    os.system('cls')
    n=input("Informe o carro.....:")
    try:
        carros[int(n)].Ligar()
        print("Carro Ligado")
    except:
        print("Carro não localizado na base")
    os.system('pause')    

def DesligarCarro():
    os.system('cls')
    n=input("Informe o carro.....:")
    try:
        carros[int(n)].DEsligar()
        print("Carro Desigado")
    except:
        print("Carro não localizado na base")
    os.system('pause')   

def ListarCarros():
    os.system('cls')
    p=0
    for c in carros:
        print(str(p) + " - " + c.nome)
        p+=1
    os.system('pause')  

ret=int(Menu())
while ret < 8:
    if ret==1:
        NovoCarro()
    elif ret==2:
        Informacoes()
    elif ret==3:
        ExcluirCarro()
    elif ret==4:
        LigarCarro()
    elif ret==5:
        DesligarCarro()
    elif ret==6:
        ListarCarros()
    elif ret==7:
        print("Obrigado por Usas nosso Sistema")
        break            
    else:
        print("Opção inválida, escolha uma opção válida")
    ret=int(Menu())