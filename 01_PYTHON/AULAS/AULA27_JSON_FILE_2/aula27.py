import json
import os
os.system('cls')

carros_dictionary={"marca":"honda","modelo":"civic","cor":"prata"}
#Dictionary -> Objeto Json

carros_list=["Honda", "Volkswagem", "Ford", "Fiat", "GM Chevrolet"]
#List -> Array/List Json

carros_tuple=("Honda", "Volkswagem", "Ford", "Fiat", "GM Chevrolet")
#List -> Array/List Json, as tuples viram arrays

carros_j=json.dumps(carros_dictionary, indent=4,separators=(": ","="),sort_keys=True)

#indent=define o spaçamento da identação.
#separators= define o separador
#sort.keys=classifica em ordem alfabetica ou numerica crescente.


print(carros_j)