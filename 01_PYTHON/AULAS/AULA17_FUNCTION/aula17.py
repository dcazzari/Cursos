valores=[10,10,5,5,5,5,10,10,10,10,900,20]

#def somar(*num):  *n permite que se receba n parametros
def somar(num):  
    s=0
    for n in num:
        n=int(n)
        s+=n
    return s

def somar2(n1, n2, n3): # permite recebimento de 1 ou mais parametros
    s=n1+n2+n3
    print("A soma é: " + str(s))


n1=10
n2=20
def somar3(): # não necessita de parametros
    s=n1+n2
    print("A soma é: " + str(s))

#print( str(valores) + " A soma é: " + str(somar(valores)))
r=somar(valores)
print( str(valores) + " A soma é: " + str(r))
somar2(10,10,5)
somar3()

