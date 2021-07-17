#variavel tipo boolean
aula=True
print(aula)

aula=""#aula é uma string agora, porem vazia.
print(bool(aula))#ao converter uma string vazia para bool, seu valor se torna False.
if aula:
    print("varialvel aula contem texto")
else:
    print("variavel aula esta vazia")


aula="CFB Cursos"#aula é uma string com conteudo.
print(bool(aula))#ao converter uma string com conteudo para bool, seu valor se torna True.
if aula:
    print("varialvel aula contem texto")
else:
    print("variavel aula esta vazia")

aula=0
print(bool(aula))#qualquer valor inteiro <> de 0 retorna true, igual a zero retorna false.