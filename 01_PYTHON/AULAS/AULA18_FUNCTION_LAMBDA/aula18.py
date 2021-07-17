import os
os.system('cls')

soma=lambda a,b:a+b
r=soma(5,2)
print(r)
print((lambda a,b,c:(a+b)*c)(2,5,10))

r=lambda x,func:x+func(x)
res=r(2, lambda x:x*x)
print(res)