#Key - Value
carro1={
    "Fabricante":"Honda",
    "Modelo":"HRV"
}
carro2={
    "Fabricante":"Fiat",
    "Modelo":"Uno"
}
carro3={
    "Fabricante":"Ford",
    "Modelo":"Focus"
}
carros={
    "c1":carro1,
    "c2":carro2,
    "c3":carro3,
}

print(carros)
print(carros["c1"])
print(carros["c1"]["Modelo"])