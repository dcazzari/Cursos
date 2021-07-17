print("digite o primeiro valor....:")
a=int(input())
print("digite o segundo valor.....:")
b=int(input())
print("digite o operador (+,-,*,/):")
op=str(input())
if op=="+":
    res=a+b
else:
    if op=="-":
        res=a-b
    else:
        if op=="*":
            res=a*b
        else:
            if b==0:
                res="ERRO"
                print("Não é possivel dividir por zero")
            else:    
                res=a/b
print(str(a)+op+str(b)+"="+str(res))    
