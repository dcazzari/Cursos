import os
import json
os.system('cls')

nome="teste"
ext=[".txt",".json"]
arquivoTxt=open("C:/Users/TAMMY/Documents/00 CURSOS/04 PYTHON/AULA36_FILE_READ/"+nome+ext[0],"at")
arquivoJson=open("C:/Users/TAMMY/Documents/00 CURSOS/04 PYTHON/AULA36_FILE_READ/"+nome+ext[1],"at")

conteudoTxt=input("Digite o conteudo do arquivo de texto: ")
arquivoTxt.write(conteudoTxt+"\n")

conteudoJson=json.dumps('{"nome":"Daniel","time":"aviadores","energia":"True","mochila":["pederneira","corda","linha","arame"],"aeronaves":[{"tipo":"transporte","habilidade":80},{"tipo":"ataque","habilidade":100},{"tipo":"reconhecimento","habilidade":50}]}')
arquivoJson.write(conteudoJson+"\n")

arquivoJson.close()
arquivoTxt.close()