#ATRIBUTOS PARA STRING.

curso=" Curso de Python "
print(curso[0])#conversão para pegar trechos de string, cria indexador.
print("Tamanho: " + str(len(curso)))#atributo len() obtem o tamanha da string. 
curso = curso.strip()#atributo strip() remove os espaços do inicio e fim da string.
print(curso)
print("Tamanho: " + str(len(curso)))
print(curso.lower())#converte cnteudo da string para minisculo.
print(curso.upper())#converte cnteudo da string para maiusculo.
print(curso.replace("Python","C#"))#substitui o conteudo da string.
textodividido=curso.split(" ")##o atributo split divide o texto a partir do parametroindicado, ele cria um array/list com o tatotal de vivisões.
print(textodividido)#exibindo o total de indices da lista criada.
print(textodividido[0])#exibindo o primeiro indice da lista criada.
print(textodividido[1])#exibindo o segundo indice da lista criada.
print(textodividido[2])#exibindo o terceiro indice da lista criada.



