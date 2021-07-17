import os
import random

l1=0
c1=0
j1=False
cpu=False
soma=0
vitoria=False
simbolo=" "

jogarNovamente=2
jogadas=0
quemJoga=2 #1=cpu 2-Jogador
maxJogadas=9
velha=[
    [" "," "," "],
    [" "," "," "],
    [" "," "," "]
]

def Tela():
    global velha
    global jogadas
    os.system('cls')
    print("   0    1    2")
    print("0:  "+ velha[0][0] + " | " + velha[0][1] + " | " + velha[0][2])
    print("-----------------")
    print("1:  "+ velha[1][0] + " | " + velha[1][1] + " | " + velha[1][2])
    print("-----------------")
    print("2:  "+ velha[2][0] + " | " + velha[2][1] + " | " + velha[2][2])
    print("Jogadas: " +  str(jogadas))

def jogadorJoga():
    global jogadas
    global quemJoga
    global maxJogadas
    if quemJoga==2 and jogadas<maxJogadas:
        try:
            l=int(input("Linha......:"))
            c=int(input("Coluna.....:"))
            while velha[l][c] != " ":
                l=int(input("Linha......:"))
                c=int(input("Coluna.....:"))            
            velha[l][c]="X"
            quemJoga=1
            jogadas+=1
        except:
            print("Linha ou coluna inválida")
            os.system('pause') 

def cpuJoga():
    global jogadas
    global quemJoga
    global maxJogadas
    if quemJoga==1 and jogadas<maxJogadas:
        l=int(random.randrange(0,3))
        c=int(random.randrange(0,3))
        while velha[l][c] != " ":
            l=int(random.randrange(0,3))
            c=int(random.randrange(0,3))    
        velha[l][c]="O"  
        quemJoga=2
        jogadas+=1    

def verificaVitoria():
    global l1
    global c1
    global j1
    global cpu
    global soma
    global simbolo
    global vitoria
    simbolo="X"
    verificaLinha()
    if j1:
        print("Jogador ganhou")
        os.system('pause')
    verificacoluna()
    if j1:
        print("Jogador ganhou")
        os.system('pause')
    simbolo="O"
    verificaLinha()
    if cpu:
        print("CPU ganhou")
        os.system('pause')
    verificacoluna()    
    if cpu:
        print("CPU ganhou")
        os.system('pause')
    verificadiagonal()
    if cpu:
        print("CPU ganhou")
        os.system('pause')
    verificacoluna()    
    if cpu:
        print("CPU ganhou")
        os.system('pause')
    verificadiagonal()
    if j1:
        print("Jogador ganhou")
        os.system('pause')
    verificacoluna()
    if j1:
        print("Jogador ganhou")
        os.system('pause')
        

def verificaLinha():
    global l1
    global c1
    global j1
    global cpu
    global soma
    global simbolo
    global vitoria
    while c1<3:
        if velha[l1][c1]==simbolo:
           soma+=1
        c1+=1    
    if soma==3:
        vitoria=True
    else:
        soma=0
        l1+=1
        while c1<3:
            if velha[l1][c1]==simbolo:
               soma+=1
            c1+=1 
        if soma==3:
           vitoria=True
        else:
            soma=0
            l1+=1
            while c1<3:
                if velha[l1][c1]==simbolo:
                   soma+=1
                c1+=1 
            if soma==3:
                vitoria=True
            else:
                 soma=0
                 l1=0
                 c1=0
    if vitoria and simbolo=="X":
        j1=True
        cpu=False

    if vitoria and simbolo=="O":
        j1=False
        cpu=True        

def verificacoluna():
    global l1
    global c1
    global j1
    global cpu
    global soma
    global simbolo
    global vitoria
    l1=0
    c1=0
    while l1<3:
        if velha[l1][c1]==simbolo:
           soma+=1
        l1+=1    
    if soma==3:
        vitoria=True
    else:
        soma=0
        c1+=1
        while l1<3:
            if velha[l1][c1]==simbolo:
               soma+=1
            l1+=1 
        if soma==3:
           vitoria=True
        else:
            soma=0
            c1+=1
            while l1<3:
                if velha[l1][c1]==simbolo:
                   soma+=1
                l1+=1 
            if soma==3:
                vitoria=True
            else:
                 soma=0
                 l1=0
                 c1=0
    if vitoria and simbolo=="X":
        j1=True
        cpu=False

    if vitoria and simbolo=="O":
        j1=False
        cpu=True       
            

def verificadiagonal():
    global l1
    global c1
    global j1
    global cpu
    global soma
    global simbolo
    global vitoria
    global velha

    if velha[0][0]=="X" and velha[1][1]=="X" and velha[2][2]=="X":
        j1=True
        cpu=False
    elif velha[0][2]=="X" and velha[1][1]=="X" and velha[2][0]=="X": 
         j1=True
         cpu=False 
    if velha[0][0]=="O" and velha[1][1]=="O" and velha[2][2]=="O":
        cpu=True
        j1=False
    elif velha[0][2]=="O" and velha[1][1]=="O" and velha[2][0]=="O": 
         cpu=True  
         j1=False 

def Principal():
    os.system('cls')
    velha=[
    ["  ","  ","  "],
    ["  ","  ","  "],
    ["  ","  ","  "]
    ]
    while True:
         Tela()
         jogadorJoga()
         verificaVitoria()
         cpuJoga()
         verificaVitoria()

Principal()