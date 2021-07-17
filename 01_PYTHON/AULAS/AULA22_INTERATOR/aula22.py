import os
os.system('cls')
carros=["Prisma","Corolla","HRV","Tigo","Gol"]
itCarros=iter(carros)
while itCarros:
    try:
        print(next(itCarros))
    except StopIteration:
        print("Fim da Lista")
        break