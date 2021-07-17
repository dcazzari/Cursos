#tipos de variaveis

x=1 #int
x="CFB cursos" #string
x=15.9 #float
x=True #bool
n1=5;n2=2;x=complex(n1,n2) #complex

print("parte real de x......: " + str(x.imag) )
print("parte imaginaria de x: " + str(x.real))
print("Tipo de x: " + str(type(x)))

x=["Carro","Avião","Navio",1,58.3,True] #List / Array - aceita tipos diferentes de dados na coleção
x=("Carro","Avião","Navio",1,58.3,True) #Tuple - caracteristicas da list, porem fechada, é uma constante, não aceita mudança de valor no indices
x=range(0,100,1) #List - cria uma lista de 0 a 100 indices incrementando os indices de 1 em 1 
x=range(0,100,2) #List - cria uma lista de 0 a 100 indices incrementando os indices de 1 em 1 
x={#dict - Dictionary
    "canal":"CFB Cursos",
    "curso":"Python",
    "nome":"Daniel"
}
x={5,7,4,5,7,4,8} #set - desconsidera valores reptidos
x=frozenset({5,7,4,5,7,4,8})#set - cria um set congelado


print("Valor de x: " + str(x) )
print("Tipo de x: " + str(type(x)))