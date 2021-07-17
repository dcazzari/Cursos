#ATRIBUTOS PARA STRING.

curso="Curso de Python"
canal="CFB Cursos"
res="Python" in curso#verifica se a string Python esta presente va variavel curso, caso positivo restorna true, caso falso, retorna false.
print(res)
res="Python" not in curso#verifica se a string Python não esta presente va variavel curso, caso positivo restorna true, caso falso, retorna false.
print(res)
cidade="Osasco"
dia=6
mes="junho"
ano=2021
# \"" = exibe conteudo de aspas na tela.
# \n = pula linha 
# \' = exibe apostrofres
# \r = retorno de carro
# \t = tabulação
# \b = backspace
data="{}, {} de {} de {}\n\"{}\"\n{} "#variavel recebe place holders
print(data.format(cidade,dia,mes,ano,canal,curso))#metodo format tras o conteudos das varaiaveis apontadas como parametros para os place holders apontados da variavel data.
