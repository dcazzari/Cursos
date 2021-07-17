carros=["HRV", "Golf", "Argo", "Focus"]
carros.clear()# metodo clear limpa a lista.
print(carros)
carros=["HRV", "Golf", "Argo", "Focus"]
print(carros[-2])# o indice -1 imprime o ultimo item, -2 o penultimo e assim sucessivamente.
carros.append("Fit")# metodo append() adiciona itens a lista
carros.append("Fusion")
carros.append("Polo")
print(str(len(carros))+" carros na lista")# metodo len() retorna valor inteiro com tamanho da lista.
print(carros)
carros.remove("Focus")# metodo remove() exclui item da lista.
print("Focus removido da lista")
print(str(len(carros))+" carros na lista")# metodo len() retorna valor inteiro com tamanho da lista.
print(carros)
carros.pop()# o método pop() remove o ultimo item da lista.
print(carros)
del carros[2]# comando del remove o indice da lista.
print(carros)
carros2=list(carros)# o método list() copia/converte em lista o seu parametro.
print(carros2)
carros=["HRV", "Golf", "Argo", "Focus"]
print(carros[-2])# o indice -1 imprime o ultimo item, -2 o penultimo e assim sucessivamente.
carros.append("Fit")# metodo append() adiciona itens a lista
carros.append("Fusion")
carros.append("Polo")
carros2=["Fusca", "147", "Brasilia", "Celta"]
carros3=carros+carros2
print(carros3)
print(str(len(carros3))+" carros na lista")